namespace DivLoopList_DavidRamirez
{
    partial class Form1
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
            this.LableStart = new System.Windows.Forms.Label();
            this.LabelEnd = new System.Windows.Forms.Label();
            this.TxtStartYear = new System.Windows.Forms.TextBox();
            this.TxtEndYear = new System.Windows.Forms.TextBox();
            this.checkBoxElection = new System.Windows.Forms.CheckBox();
            this.checkBoxCensus = new System.Windows.Forms.CheckBox();
            this.BtnGo = new System.Windows.Forms.Button();
            this.ListBoxOFYears = new System.Windows.Forms.ListBox();
            this.BtnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LableStart
            // 
            this.LableStart.AutoSize = true;
            this.LableStart.Location = new System.Drawing.Point(51, 22);
            this.LableStart.Name = "LableStart";
            this.LableStart.Size = new System.Drawing.Size(91, 13);
            this.LableStart.TabIndex = 0;
            this.LableStart.Text = "Start Year (YYYY)";
            // 
            // LabelEnd
            // 
            this.LabelEnd.AutoSize = true;
            this.LabelEnd.Location = new System.Drawing.Point(207, 22);
            this.LabelEnd.Name = "LabelEnd";
            this.LabelEnd.Size = new System.Drawing.Size(88, 13);
            this.LabelEnd.TabIndex = 0;
            this.LabelEnd.Text = "End Year (YYYY)";
            // 
            // TxtStartYear
            // 
            this.TxtStartYear.Location = new System.Drawing.Point(54, 39);
            this.TxtStartYear.Name = "TxtStartYear";
            this.TxtStartYear.Size = new System.Drawing.Size(100, 20);
            this.TxtStartYear.TabIndex = 1;
            // 
            // TxtEndYear
            // 
            this.TxtEndYear.Location = new System.Drawing.Point(194, 39);
            this.TxtEndYear.Name = "TxtEndYear";
            this.TxtEndYear.Size = new System.Drawing.Size(100, 20);
            this.TxtEndYear.TabIndex = 1;
            // 
            // checkBoxElection
            // 
            this.checkBoxElection.AutoSize = true;
            this.checkBoxElection.Location = new System.Drawing.Point(88, 79);
            this.checkBoxElection.Name = "checkBoxElection";
            this.checkBoxElection.Size = new System.Drawing.Size(192, 17);
            this.checkBoxElection.TabIndex = 2;
            this.checkBoxElection.Text = "Indicate Presidential Election Years";
            this.checkBoxElection.UseVisualStyleBackColor = true;
            // 
            // checkBoxCensus
            // 
            this.checkBoxCensus.AutoSize = true;
            this.checkBoxCensus.Location = new System.Drawing.Point(89, 101);
            this.checkBoxCensus.Name = "checkBoxCensus";
            this.checkBoxCensus.Size = new System.Drawing.Size(132, 17);
            this.checkBoxCensus.TabIndex = 3;
            this.checkBoxCensus.Text = "Indicate Census Years";
            this.checkBoxCensus.UseVisualStyleBackColor = true;
            // 
            // BtnGo
            // 
            this.BtnGo.Location = new System.Drawing.Point(146, 141);
            this.BtnGo.Name = "BtnGo";
            this.BtnGo.Size = new System.Drawing.Size(75, 23);
            this.BtnGo.TabIndex = 4;
            this.BtnGo.Text = "Go";
            this.BtnGo.UseVisualStyleBackColor = true;
            this.BtnGo.Click += new System.EventHandler(this.BtnGo_Click);
            // 
            // ListBoxOFYears
            // 
            this.ListBoxOFYears.FormattingEnabled = true;
            this.ListBoxOFYears.Location = new System.Drawing.Point(12, 210);
            this.ListBoxOFYears.Name = "ListBoxOFYears";
            this.ListBoxOFYears.Size = new System.Drawing.Size(331, 160);
            this.ListBoxOFYears.TabIndex = 5;
            this.ListBoxOFYears.SelectedIndexChanged += new System.EventHandler(this.ListBoxOFYears_SelectedIndexChanged);
            // 
            // BtnClear
            // 
            this.BtnClear.Location = new System.Drawing.Point(146, 170);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(75, 23);
            this.BtnClear.TabIndex = 6;
            this.BtnClear.Text = "Clear";
            this.BtnClear.UseVisualStyleBackColor = true;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 378);
            this.Controls.Add(this.BtnClear);
            this.Controls.Add(this.ListBoxOFYears);
            this.Controls.Add(this.BtnGo);
            this.Controls.Add(this.checkBoxCensus);
            this.Controls.Add(this.checkBoxElection);
            this.Controls.Add(this.TxtEndYear);
            this.Controls.Add(this.TxtStartYear);
            this.Controls.Add(this.LabelEnd);
            this.Controls.Add(this.LableStart);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LableStart;
        private System.Windows.Forms.Label LabelEnd;
        private System.Windows.Forms.TextBox TxtStartYear;
        private System.Windows.Forms.TextBox TxtEndYear;
        private System.Windows.Forms.CheckBox checkBoxElection;
        private System.Windows.Forms.CheckBox checkBoxCensus;
        private System.Windows.Forms.Button BtnGo;
        private System.Windows.Forms.ListBox ListBoxOFYears;
        private System.Windows.Forms.Button BtnClear;
    }
}

