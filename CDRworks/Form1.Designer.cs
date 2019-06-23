namespace CDRworks
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.ButtonDirectory = new System.Windows.Forms.Button();
            this.PathArcTextBox = new System.Windows.Forms.TextBox();
            this.CDRGetResult = new System.Windows.Forms.Button();
            this.result = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTotalin = new System.Windows.Forms.Label();
            this.lblTotalout = new System.Windows.Forms.Label();
            this.pbCalc = new System.Windows.Forms.ProgressBar();
            this.tbLengthPosition = new System.Windows.Forms.TextBox();
            this.tbCallerPosition = new System.Windows.Forms.TextBox();
            this.cbParam = new System.Windows.Forms.CheckBox();
            this.settings = new System.Windows.Forms.GroupBox();
            this.tbCaller = new System.Windows.Forms.TextBox();
            this.lblInCal = new System.Windows.Forms.Label();
            this.lblCaller = new System.Windows.Forms.Label();
            this.lblRing = new System.Windows.Forms.Label();
            this.lblTotalc = new System.Windows.Forms.Label();
            this.lblTotalci = new System.Windows.Forms.Label();
            this.lblTotalco = new System.Windows.Forms.Label();
            this.lblResulc = new System.Windows.Forms.Label();
            this.lblResultci = new System.Windows.Forms.Label();
            this.lblResultco = new System.Windows.Forms.Label();
            this.settings.SuspendLayout();
            this.SuspendLayout();
            // 
            // ButtonDirectory
            // 
            this.ButtonDirectory.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonDirectory.Location = new System.Drawing.Point(12, 13);
            this.ButtonDirectory.Name = "ButtonDirectory";
            this.ButtonDirectory.Size = new System.Drawing.Size(220, 46);
            this.ButtonDirectory.TabIndex = 0;
            this.ButtonDirectory.Text = "Choose directory";
            this.ButtonDirectory.UseVisualStyleBackColor = true;
            this.ButtonDirectory.Click += new System.EventHandler(this.button1_Click);
            // 
            // PathArcTextBox
            // 
            this.PathArcTextBox.Location = new System.Drawing.Point(239, 13);
            this.PathArcTextBox.Name = "PathArcTextBox";
            this.PathArcTextBox.ReadOnly = true;
            this.PathArcTextBox.Size = new System.Drawing.Size(523, 31);
            this.PathArcTextBox.TabIndex = 1;
            // 
            // CDRGetResult
            // 
            this.CDRGetResult.Location = new System.Drawing.Point(547, 336);
            this.CDRGetResult.Name = "CDRGetResult";
            this.CDRGetResult.Size = new System.Drawing.Size(215, 73);
            this.CDRGetResult.TabIndex = 2;
            this.CDRGetResult.Text = "Get result";
            this.CDRGetResult.UseVisualStyleBackColor = true;
            this.CDRGetResult.Click += new System.EventHandler(this.CDRGetResult_Click);
            // 
            // result
            // 
            this.result.AutoSize = true;
            this.result.Location = new System.Drawing.Point(176, 294);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(95, 25);
            this.result.TabIndex = 3;
            this.result.Text = "no result";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 294);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Total(min)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 336);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Total in(min)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 377);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Total out(min)";
            // 
            // lblTotalin
            // 
            this.lblTotalin.AutoSize = true;
            this.lblTotalin.Location = new System.Drawing.Point(176, 336);
            this.lblTotalin.Name = "lblTotalin";
            this.lblTotalin.Size = new System.Drawing.Size(95, 25);
            this.lblTotalin.TabIndex = 7;
            this.lblTotalin.Text = "no result";
            // 
            // lblTotalout
            // 
            this.lblTotalout.AutoSize = true;
            this.lblTotalout.Location = new System.Drawing.Point(176, 377);
            this.lblTotalout.Name = "lblTotalout";
            this.lblTotalout.Size = new System.Drawing.Size(95, 25);
            this.lblTotalout.TabIndex = 8;
            this.lblTotalout.Text = "no result";
            // 
            // pbCalc
            // 
            this.pbCalc.Location = new System.Drawing.Point(13, 415);
            this.pbCalc.Name = "pbCalc";
            this.pbCalc.Size = new System.Drawing.Size(749, 23);
            this.pbCalc.TabIndex = 9;
            // 
            // tbLengthPosition
            // 
            this.tbLengthPosition.Location = new System.Drawing.Point(206, 48);
            this.tbLengthPosition.Name = "tbLengthPosition";
            this.tbLengthPosition.Size = new System.Drawing.Size(100, 31);
            this.tbLengthPosition.TabIndex = 10;
            // 
            // tbCallerPosition
            // 
            this.tbCallerPosition.Location = new System.Drawing.Point(206, 96);
            this.tbCallerPosition.Name = "tbCallerPosition";
            this.tbCallerPosition.Size = new System.Drawing.Size(100, 31);
            this.tbCallerPosition.TabIndex = 11;
            // 
            // cbParam
            // 
            this.cbParam.AutoSize = true;
            this.cbParam.Location = new System.Drawing.Point(12, 65);
            this.cbParam.Name = "cbParam";
            this.cbParam.Size = new System.Drawing.Size(122, 29);
            this.cbParam.TabIndex = 12;
            this.cbParam.Text = "Settings";
            this.cbParam.UseVisualStyleBackColor = true;
            this.cbParam.CheckedChanged += new System.EventHandler(this.cbParam_CheckedChanged);
            // 
            // settings
            // 
            this.settings.Controls.Add(this.tbCaller);
            this.settings.Controls.Add(this.lblInCal);
            this.settings.Controls.Add(this.lblCaller);
            this.settings.Controls.Add(this.lblRing);
            this.settings.Controls.Add(this.tbLengthPosition);
            this.settings.Controls.Add(this.tbCallerPosition);
            this.settings.Location = new System.Drawing.Point(12, 100);
            this.settings.Name = "settings";
            this.settings.Size = new System.Drawing.Size(326, 191);
            this.settings.TabIndex = 13;
            this.settings.TabStop = false;
            this.settings.Visible = false;
            // 
            // tbCaller
            // 
            this.tbCaller.Location = new System.Drawing.Point(206, 145);
            this.tbCaller.Name = "tbCaller";
            this.tbCaller.Size = new System.Drawing.Size(100, 31);
            this.tbCaller.TabIndex = 15;
            // 
            // lblInCal
            // 
            this.lblInCal.AutoSize = true;
            this.lblInCal.Location = new System.Drawing.Point(17, 151);
            this.lblInCal.Name = "lblInCal";
            this.lblInCal.Size = new System.Drawing.Size(68, 25);
            this.lblInCal.TabIndex = 14;
            this.lblInCal.Text = "Caller";
            // 
            // lblCaller
            // 
            this.lblCaller.AutoSize = true;
            this.lblCaller.Location = new System.Drawing.Point(17, 102);
            this.lblCaller.Name = "lblCaller";
            this.lblCaller.Size = new System.Drawing.Size(151, 25);
            this.lblCaller.TabIndex = 13;
            this.lblCaller.Text = "Caller Position";
            // 
            // lblRing
            // 
            this.lblRing.AutoSize = true;
            this.lblRing.Location = new System.Drawing.Point(17, 48);
            this.lblRing.Name = "lblRing";
            this.lblRing.Size = new System.Drawing.Size(161, 25);
            this.lblRing.TabIndex = 12;
            this.lblRing.Text = "Length Position";
            // 
            // lblTotalc
            // 
            this.lblTotalc.AutoSize = true;
            this.lblTotalc.Location = new System.Drawing.Point(290, 294);
            this.lblTotalc.Name = "lblTotalc";
            this.lblTotalc.Size = new System.Drawing.Size(118, 25);
            this.lblTotalc.TabIndex = 14;
            this.lblTotalc.Text = "Total(calls)";
            // 
            // lblTotalci
            // 
            this.lblTotalci.AutoSize = true;
            this.lblTotalci.Location = new System.Drawing.Point(290, 336);
            this.lblTotalci.Name = "lblTotalci";
            this.lblTotalci.Size = new System.Drawing.Size(91, 25);
            this.lblTotalci.TabIndex = 15;
            this.lblTotalci.Text = "Total(in)";
            // 
            // lblTotalco
            // 
            this.lblTotalco.AutoSize = true;
            this.lblTotalco.Location = new System.Drawing.Point(290, 377);
            this.lblTotalco.Name = "lblTotalco";
            this.lblTotalco.Size = new System.Drawing.Size(104, 25);
            this.lblTotalco.TabIndex = 16;
            this.lblTotalco.Text = "Total(out)";
            // 
            // lblResulc
            // 
            this.lblResulc.AutoSize = true;
            this.lblResulc.Location = new System.Drawing.Point(414, 294);
            this.lblResulc.Name = "lblResulc";
            this.lblResulc.Size = new System.Drawing.Size(95, 25);
            this.lblResulc.TabIndex = 17;
            this.lblResulc.Text = "no result";
            // 
            // lblResultci
            // 
            this.lblResultci.AutoSize = true;
            this.lblResultci.Location = new System.Drawing.Point(414, 336);
            this.lblResultci.Name = "lblResultci";
            this.lblResultci.Size = new System.Drawing.Size(95, 25);
            this.lblResultci.TabIndex = 18;
            this.lblResultci.Text = "no result";
            // 
            // lblResultco
            // 
            this.lblResultco.AutoSize = true;
            this.lblResultco.Location = new System.Drawing.Point(414, 377);
            this.lblResultco.Name = "lblResultco";
            this.lblResultco.Size = new System.Drawing.Size(95, 25);
            this.lblResultco.TabIndex = 19;
            this.lblResultco.Text = "no result";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblResultco);
            this.Controls.Add(this.lblResultci);
            this.Controls.Add(this.lblResulc);
            this.Controls.Add(this.lblTotalco);
            this.Controls.Add(this.lblTotalci);
            this.Controls.Add(this.lblTotalc);
            this.Controls.Add(this.settings);
            this.Controls.Add(this.cbParam);
            this.Controls.Add(this.pbCalc);
            this.Controls.Add(this.lblTotalout);
            this.Controls.Add(this.lblTotalin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.result);
            this.Controls.Add(this.CDRGetResult);
            this.Controls.Add(this.PathArcTextBox);
            this.Controls.Add(this.ButtonDirectory);
            this.Name = "Form1";
            this.Text = "CDRtotalLite";
            this.settings.ResumeLayout(false);
            this.settings.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonDirectory;
        private System.Windows.Forms.TextBox PathArcTextBox;
        private System.Windows.Forms.Button CDRGetResult;
        private System.Windows.Forms.Label result;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTotalin;
        private System.Windows.Forms.Label lblTotalout;
        private System.Windows.Forms.ProgressBar pbCalc;
        private System.Windows.Forms.TextBox tbLengthPosition;
        private System.Windows.Forms.TextBox tbCallerPosition;
        private System.Windows.Forms.CheckBox cbParam;
        private System.Windows.Forms.GroupBox settings;
        private System.Windows.Forms.TextBox tbCaller;
        private System.Windows.Forms.Label lblInCal;
        private System.Windows.Forms.Label lblCaller;
        private System.Windows.Forms.Label lblRing;
        private System.Windows.Forms.Label lblTotalc;
        private System.Windows.Forms.Label lblTotalci;
        private System.Windows.Forms.Label lblTotalco;
        private System.Windows.Forms.Label lblResulc;
        private System.Windows.Forms.Label lblResultci;
        private System.Windows.Forms.Label lblResultco;
    }
}

