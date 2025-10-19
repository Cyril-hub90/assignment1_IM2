
namespace HW4
{
    partial class Form2
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
            this.pictureBoxDisplay = new System.Windows.Forms.PictureBox();
            this.txtMobileDisplay = new System.Windows.Forms.MaskedTextBox();
            this.txtFirstnameDisplay = new System.Windows.Forms.TextBox();
            this.txtLastnameDisplay = new System.Windows.Forms.TextBox();
            this.rbMaleDisplay = new System.Windows.Forms.RadioButton();
            this.rbFemaleDisplay = new System.Windows.Forms.RadioButton();
            this.cmbStatusDisplay = new System.Windows.Forms.ComboBox();
            this.dtpBirthdayDisplay = new System.Windows.Forms.DateTimePicker();
            this.txtLocationDisplay = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDisplay)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxDisplay
            // 
            this.pictureBoxDisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxDisplay.Location = new System.Drawing.Point(553, 29);
            this.pictureBoxDisplay.Name = "pictureBoxDisplay";
            this.pictureBoxDisplay.Size = new System.Drawing.Size(150, 150);
            this.pictureBoxDisplay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxDisplay.TabIndex = 0;
            this.pictureBoxDisplay.TabStop = false;
            this.pictureBoxDisplay.SizeModeChanged += new System.EventHandler(this.S);
            // 
            // txtMobileDisplay
            // 
            this.txtMobileDisplay.Location = new System.Drawing.Point(51, 82);
            this.txtMobileDisplay.Name = "txtMobileDisplay";
            this.txtMobileDisplay.Size = new System.Drawing.Size(159, 22);
            this.txtMobileDisplay.TabIndex = 1;
            // 
            // txtFirstnameDisplay
            // 
            this.txtFirstnameDisplay.Location = new System.Drawing.Point(51, 151);
            this.txtFirstnameDisplay.Name = "txtFirstnameDisplay";
            this.txtFirstnameDisplay.Size = new System.Drawing.Size(200, 22);
            this.txtFirstnameDisplay.TabIndex = 2;
            // 
            // txtLastnameDisplay
            // 
            this.txtLastnameDisplay.Location = new System.Drawing.Point(323, 151);
            this.txtLastnameDisplay.Name = "txtLastnameDisplay";
            this.txtLastnameDisplay.Size = new System.Drawing.Size(200, 22);
            this.txtLastnameDisplay.TabIndex = 3;
            // 
            // rbMaleDisplay
            // 
            this.rbMaleDisplay.AutoSize = true;
            this.rbMaleDisplay.Location = new System.Drawing.Point(51, 219);
            this.rbMaleDisplay.Name = "rbMaleDisplay";
            this.rbMaleDisplay.Size = new System.Drawing.Size(59, 21);
            this.rbMaleDisplay.TabIndex = 4;
            this.rbMaleDisplay.TabStop = true;
            this.rbMaleDisplay.Text = "Male";
            this.rbMaleDisplay.UseVisualStyleBackColor = true;
            // 
            // rbFemaleDisplay
            // 
            this.rbFemaleDisplay.AutoSize = true;
            this.rbFemaleDisplay.Location = new System.Drawing.Point(192, 219);
            this.rbFemaleDisplay.Name = "rbFemaleDisplay";
            this.rbFemaleDisplay.Size = new System.Drawing.Size(75, 21);
            this.rbFemaleDisplay.TabIndex = 5;
            this.rbFemaleDisplay.TabStop = true;
            this.rbFemaleDisplay.Text = "Female";
            this.rbFemaleDisplay.UseVisualStyleBackColor = true;
            // 
            // cmbStatusDisplay
            // 
            this.cmbStatusDisplay.FormattingEnabled = true;
            this.cmbStatusDisplay.Items.AddRange(new object[] {
            "Single",
            "Married",
            "Its Complicated"});
            this.cmbStatusDisplay.Location = new System.Drawing.Point(422, 218);
            this.cmbStatusDisplay.Name = "cmbStatusDisplay";
            this.cmbStatusDisplay.Size = new System.Drawing.Size(179, 24);
            this.cmbStatusDisplay.TabIndex = 6;
            // 
            // dtpBirthdayDisplay
            // 
            this.dtpBirthdayDisplay.Location = new System.Drawing.Point(51, 286);
            this.dtpBirthdayDisplay.Name = "dtpBirthdayDisplay";
            this.dtpBirthdayDisplay.Size = new System.Drawing.Size(200, 22);
            this.dtpBirthdayDisplay.TabIndex = 7;
            // 
            // txtLocationDisplay
            // 
            this.txtLocationDisplay.Location = new System.Drawing.Point(51, 339);
            this.txtLocationDisplay.Name = "txtLocationDisplay";
            this.txtLocationDisplay.Size = new System.Drawing.Size(510, 22);
            this.txtLocationDisplay.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(320, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 17);
            this.label3.TabIndex = 14;
            this.label3.Text = "Lastname";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 17);
            this.label1.TabIndex = 15;
            this.label1.Text = "Firstname";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(369, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 16;
            this.label2.Text = "Status";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 17);
            this.label4.TabIndex = 17;
            this.label4.Text = "Sex";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(48, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 17);
            this.label5.TabIndex = 18;
            this.label5.Text = "Mobile";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(49, 319);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 17);
            this.label6.TabIndex = 19;
            this.label6.Text = "Location";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(49, 254);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 17);
            this.label7.TabIndex = 20;
            this.label7.Text = "Birthday";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtLocationDisplay);
            this.Controls.Add(this.dtpBirthdayDisplay);
            this.Controls.Add(this.cmbStatusDisplay);
            this.Controls.Add(this.rbFemaleDisplay);
            this.Controls.Add(this.rbMaleDisplay);
            this.Controls.Add(this.txtLastnameDisplay);
            this.Controls.Add(this.txtFirstnameDisplay);
            this.Controls.Add(this.txtMobileDisplay);
            this.Controls.Add(this.pictureBoxDisplay);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDisplay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxDisplay;
        private System.Windows.Forms.MaskedTextBox txtMobileDisplay;
        private System.Windows.Forms.TextBox txtFirstnameDisplay;
        private System.Windows.Forms.TextBox txtLastnameDisplay;
        private System.Windows.Forms.RadioButton rbMaleDisplay;
        private System.Windows.Forms.RadioButton rbFemaleDisplay;
        private System.Windows.Forms.ComboBox cmbStatusDisplay;
        private System.Windows.Forms.DateTimePicker dtpBirthdayDisplay;
        private System.Windows.Forms.TextBox txtLocationDisplay;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}