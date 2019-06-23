/*
Zhuravlev Nikita Sergeevich 05.04.2019 ©
Lite CDR parser for getting total call length
nzhuravlev.pthade@yandex.ru
*/
using System;
using System.IO;
using System.Windows.Forms;

namespace CDRworks
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog DirDialog = new FolderBrowserDialog();
            DirDialog.Description = "Select directory";
            DirDialog.SelectedPath = @"C:\";

            if (DirDialog.ShowDialog() == DialogResult.OK)
            {
                PathArcTextBox.Text = DirDialog.SelectedPath;
                DirDialog.SelectedPath = DirDialog.SelectedPath;
            }
        }

        private void CDRGetResult_Click(object sender, EventArgs e)
        {
            int callengthpos = 2;
            int callerpos = 7;
            string caller = "Rostelekom";
            long summarysecs = 0;
            long summarysecsin = 0;
            long summarysecsout = 0;
            long summarycalls = 0;
            long summaryincalls = 0;
            long summaryoutcalls = 0;
            pbCalc.Value = 0;
            if (cbParam.Checked == true)
            {
                try
                {
                    callengthpos = Convert.ToInt32(tbLengthPosition.Text) - 1;
                    callerpos = Convert.ToInt32(tbCallerPosition.Text) - 1;
                    caller = tbCaller.Text;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                
            }
            try
            {
                DirectoryInfo dir = new DirectoryInfo(PathArcTextBox.Text);

                pbCalc.Maximum = dir.GetDirectories().Length;
                foreach (var item in dir.GetDirectories())
                {
                    pbCalc.Value++;
                    foreach (var it in item.GetFiles())
                    {
                        string sinput = File.ReadAllText(it.FullName);
                        string[] cdrblock = sinput.Trim().Split('\n');
                        summarycalls += cdrblock.Length;
                        foreach (var block in cdrblock)
                        {
                            string[] cdrval = block.Split(';');
                            if (cdrval.Length > 1)
                            {
                                if (cdrval[callerpos] == caller)
                                {
                                    summaryincalls++;
                                    summarysecsin += Convert.ToInt64(cdrval[callengthpos]);
                                }
                                else
                                {
                                    summaryoutcalls++;
                                    summarysecsout += Convert.ToInt64(cdrval[callengthpos]);
                                }
                                summarysecs += Convert.ToInt64(cdrval[callengthpos]);
                            }

                        }

                    }

                }

                lblResulc.Text = Convert.ToString(summarycalls);
                lblResultci.Text = Convert.ToString(summaryincalls);
                lblResultco.Text = Convert.ToString(summaryoutcalls);
                result.Text = Convert.ToString(summarysecs / 60);
                lblTotalin.Text = Convert.ToString(summarysecsin / 60);
                lblTotalout.Text = Convert.ToString(summarysecsout / 60);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cbParam_CheckedChanged(object sender, EventArgs e)
        {
            if (settings.Visible == true) settings.Visible = false;
            else settings.Visible = true;
        }
    }
}
