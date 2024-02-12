namespace Hill_Mortgage
{
    partial class MainFrm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblPrincipal = new System.Windows.Forms.Label();
            this.lbl_interest = new System.Windows.Forms.Label();
            this.txtPrincipal = new System.Windows.Forms.TextBox();
            this.lblYears = new System.Windows.Forms.Label();
            this.cboInterest = new System.Windows.Forms.ComboBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtOtherYear = new System.Windows.Forms.TextBox();
            this.radOther = new System.Windows.Forms.RadioButton();
            this.rad30year = new System.Windows.Forms.RadioButton();
            this.rad15year = new System.Windows.Forms.RadioButton();
            this.lblOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblPrincipal
            // 
            this.lblPrincipal.AutoSize = true;
            this.lblPrincipal.Location = new System.Drawing.Point(48, 28);
            this.lblPrincipal.Name = "lblPrincipal";
            this.lblPrincipal.Size = new System.Drawing.Size(53, 13);
            this.lblPrincipal.TabIndex = 0;
            this.lblPrincipal.Text = "Principal: ";
            // 
            // lbl_interest
            // 
            this.lbl_interest.AutoSize = true;
            this.lbl_interest.Location = new System.Drawing.Point(48, 146);
            this.lbl_interest.Name = "lbl_interest";
            this.lbl_interest.Size = new System.Drawing.Size(42, 13);
            this.lbl_interest.TabIndex = 1;
            this.lbl_interest.Text = "Interest";
            // 
            // txtPrincipal
            // 
            this.txtPrincipal.Location = new System.Drawing.Point(97, 25);
            this.txtPrincipal.Name = "txtPrincipal";
            this.txtPrincipal.Size = new System.Drawing.Size(100, 20);
            this.txtPrincipal.TabIndex = 6;
            this.txtPrincipal.TextChanged += new System.EventHandler(this.txtPrincipal_TextChanged);
            this.txtPrincipal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrincipal_KeyPress);
            // 
            // lblYears
            // 
            this.lblYears.AutoSize = true;
            this.lblYears.Location = new System.Drawing.Point(48, 54);
            this.lblYears.Name = "lblYears";
            this.lblYears.Size = new System.Drawing.Size(73, 13);
            this.lblYears.TabIndex = 10;
            this.lblYears.Text = "Term In Years";
            // 
            // cboInterest
            // 
            this.cboInterest.FormattingEnabled = true;
            this.cboInterest.Items.AddRange(new object[] {
            "3.0",
            "3.1",
            "3.2",
            "3.3",
            "3.4",
            "3.5",
            "3.6",
            "3.7",
            "3.8",
            "3.9",
            "4.0",
            "4.1",
            "4.2",
            "4.3",
            "4.4",
            "4.5"});
            this.cboInterest.Location = new System.Drawing.Point(89, 143);
            this.cboInterest.Name = "cboInterest";
            this.cboInterest.Size = new System.Drawing.Size(38, 21);
            this.cboInterest.TabIndex = 11;
            this.cboInterest.SelectedIndexChanged += new System.EventHandler(this.cboInterest_SelectedIndexChanged);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(51, 170);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(156, 36);
            this.btnCalculate.TabIndex = 12;
            this.btnCalculate.Text = "Calculate Payment";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(51, 212);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 40);
            this.btnReset.TabIndex = 13;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(132, 212);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 40);
            this.btnExit.TabIndex = 14;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtOtherYear
            // 
            this.txtOtherYear.Location = new System.Drawing.Point(109, 115);
            this.txtOtherYear.Name = "txtOtherYear";
            this.txtOtherYear.Size = new System.Drawing.Size(88, 20);
            this.txtOtherYear.TabIndex = 15;
            this.txtOtherYear.TextChanged += new System.EventHandler(this.txtOtherYear_TextChanged);
            this.txtOtherYear.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtOtherYear_KeyPress);
            // 
            // radOther
            // 
            this.radOther.AutoSize = true;
            this.radOther.Location = new System.Drawing.Point(51, 116);
            this.radOther.Name = "radOther";
            this.radOther.Size = new System.Drawing.Size(60, 17);
            this.radOther.TabIndex = 16;
            this.radOther.TabStop = true;
            this.radOther.Text = "Other...";
            this.radOther.UseVisualStyleBackColor = true;
            this.radOther.CheckedChanged += new System.EventHandler(this.radOther_CheckedChanged);
            // 
            // rad30year
            // 
            this.rad30year.AutoSize = true;
            this.rad30year.Location = new System.Drawing.Point(51, 93);
            this.rad30year.Name = "rad30year";
            this.rad30year.Size = new System.Drawing.Size(62, 17);
            this.rad30year.TabIndex = 17;
            this.rad30year.TabStop = true;
            this.rad30year.Text = "30 Year";
            this.rad30year.UseVisualStyleBackColor = true;
            this.rad30year.CheckedChanged += new System.EventHandler(this.rad30year_CheckedChanged);
            // 
            // rad15year
            // 
            this.rad15year.AutoSize = true;
            this.rad15year.Location = new System.Drawing.Point(51, 70);
            this.rad15year.Name = "rad15year";
            this.rad15year.Size = new System.Drawing.Size(62, 17);
            this.rad15year.TabIndex = 18;
            this.rad15year.TabStop = true;
            this.rad15year.Text = "15 Year";
            this.rad15year.UseVisualStyleBackColor = true;
            this.rad15year.CheckedChanged += new System.EventHandler(this.rad15year_CheckedChanged);
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Location = new System.Drawing.Point(55, 268);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(62, 13);
            this.lblOutput.TabIndex = 19;
            this.lblOutput.Text = "placeholder";
            // 
            // MainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(249, 302);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.rad15year);
            this.Controls.Add(this.rad30year);
            this.Controls.Add(this.radOther);
            this.Controls.Add(this.txtOtherYear);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.cboInterest);
            this.Controls.Add(this.lblYears);
            this.Controls.Add(this.txtPrincipal);
            this.Controls.Add(this.lbl_interest);
            this.Controls.Add(this.lblPrincipal);
            this.Name = "MainFrm";
            this.Text = "Riley Hill : Mortgage Calculator";
            this.Load += new System.EventHandler(this.MainFrm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPrincipal;
        private System.Windows.Forms.Label lbl_interest;
        private System.Windows.Forms.TextBox txtPrincipal;
        private System.Windows.Forms.Label lblYears;
        private System.Windows.Forms.ComboBox cboInterest;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtOtherYear;
        private System.Windows.Forms.RadioButton radOther;
        private System.Windows.Forms.RadioButton rad30year;
        private System.Windows.Forms.RadioButton rad15year;
        private System.Windows.Forms.Label lblOutput;
    }
}

