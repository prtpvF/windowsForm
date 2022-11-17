namespace WindowsFormsApp1
{
    partial class registrationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(registrationForm));
            this.panelTop = new System.Windows.Forms.Panel();
            this.close_buttonClick = new System.Windows.Forms.Label();
            this.labelReg = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.userBox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button_registration = new System.Windows.Forms.Button();
            this.UserNameField = new System.Windows.Forms.TextBox();
            this.SurnameField = new System.Windows.Forms.TextBox();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.registerLabel = new System.Windows.Forms.Label();
            this.loginLabel = new System.Windows.Forms.Label();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelTop.Controls.Add(this.close_buttonClick);
            this.panelTop.Controls.Add(this.labelReg);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(795, 138);
            this.panelTop.TabIndex = 0;
            this.panelTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTop_MouseDown);
            this.panelTop.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelTop_MouseMove);
            // 
            // close_buttonClick
            // 
            this.close_buttonClick.AutoSize = true;
            this.close_buttonClick.Cursor = System.Windows.Forms.Cursors.Hand;
            this.close_buttonClick.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.close_buttonClick.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.close_buttonClick.Location = new System.Drawing.Point(764, 9);
            this.close_buttonClick.Name = "close_buttonClick";
            this.close_buttonClick.Size = new System.Drawing.Size(28, 32);
            this.close_buttonClick.TabIndex = 10;
            this.close_buttonClick.Text = "x";
            this.close_buttonClick.Click += new System.EventHandler(this.close_buttonClick_Click);
            // 
            // labelReg
            // 
            this.labelReg.AutoSize = true;
            this.labelReg.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelReg.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelReg.Location = new System.Drawing.Point(298, 48);
            this.labelReg.Name = "labelReg";
            this.labelReg.Size = new System.Drawing.Size(179, 32);
            this.labelReg.TabIndex = 0;
            this.labelReg.Text = "регистрация";
            this.labelReg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(413, 305);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(56, 48);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // userBox
            // 
            this.userBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.userBox.Location = new System.Drawing.Point(98, 305);
            this.userBox.Multiline = true;
            this.userBox.Name = "userBox";
            this.userBox.Size = new System.Drawing.Size(258, 48);
            this.userBox.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(31, 305);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(56, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // button_registration
            // 
            this.button_registration.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_registration.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.button_registration.FlatAppearance.BorderSize = 0;
            this.button_registration.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.button_registration.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_registration.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_registration.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_registration.Location = new System.Drawing.Point(177, 381);
            this.button_registration.Name = "button_registration";
            this.button_registration.Size = new System.Drawing.Size(399, 48);
            this.button_registration.TabIndex = 9;
            this.button_registration.Text = "регистрация";
            this.button_registration.UseVisualStyleBackColor = true;
            this.button_registration.Click += new System.EventHandler(this.button_registration_Click);
            // 
            // UserNameField
            // 
            this.UserNameField.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UserNameField.Location = new System.Drawing.Point(98, 214);
            this.UserNameField.Multiline = true;
            this.UserNameField.Name = "UserNameField";
            this.UserNameField.Size = new System.Drawing.Size(258, 48);
            this.UserNameField.TabIndex = 10;
            this.UserNameField.Enter += new System.EventHandler(this.UserNameField_Enter);
            this.UserNameField.Leave += new System.EventHandler(this.UserNameField_Leave);
            // 
            // SurnameField
            // 
            this.SurnameField.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SurnameField.Location = new System.Drawing.Point(480, 214);
            this.SurnameField.Multiline = true;
            this.SurnameField.Name = "SurnameField";
            this.SurnameField.Size = new System.Drawing.Size(258, 48);
            this.SurnameField.TabIndex = 11;
            this.SurnameField.Enter += new System.EventHandler(this.SurnameField_Enter);
            this.SurnameField.Leave += new System.EventHandler(this.SurnameField_Leave);
            // 
            // passwordBox
            // 
            this.passwordBox.Location = new System.Drawing.Point(480, 305);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.PasswordChar = '*';
            this.passwordBox.Size = new System.Drawing.Size(263, 22);
            this.passwordBox.TabIndex = 12;
            this.passwordBox.UseSystemPasswordChar = true;
            // 
            // registerLabel
            // 
            this.registerLabel.AutoSize = true;
            this.registerLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.registerLabel.Location = new System.Drawing.Point(544, 386);
            this.registerLabel.Name = "registerLabel";
            this.registerLabel.Size = new System.Drawing.Size(149, 27);
            this.registerLabel.TabIndex = 6;
            this.registerLabel.Text = "нет аккаунта?";
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginLabel.Location = new System.Drawing.Point(553, 392);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(146, 27);
            this.loginLabel.TabIndex = 13;
            this.loginLabel.Text = "есть аккаунт?";
            this.loginLabel.Click += new System.EventHandler(this.loginLabel_Click);
            // 
            // registrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(795, 450);
            this.Controls.Add(this.loginLabel);
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.SurnameField);
            this.Controls.Add(this.UserNameField);
            this.Controls.Add(this.button_registration);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.userBox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "registrationForm";
            this.Text = "registrationForm";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.registrationForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.registrationForm_MouseMove);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label labelReg;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox userBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button_registration;
        private System.Windows.Forms.Label close_buttonClick;
        private System.Windows.Forms.TextBox UserNameField;
        private System.Windows.Forms.TextBox SurnameField;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.Label registerLabel;
        private System.Windows.Forms.Label loginLabel;
    }
}