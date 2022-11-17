namespace WindowsFormsApp1
{
    partial class mainForm
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
            this.MainCloseButton = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.topPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.topPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainCloseButton
            // 
            this.MainCloseButton.AutoSize = true;
            this.MainCloseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MainCloseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainCloseButton.Location = new System.Drawing.Point(764, 9);
            this.MainCloseButton.Name = "MainCloseButton";
            this.MainCloseButton.Size = new System.Drawing.Size(24, 29);
            this.MainCloseButton.TabIndex = 4;
            this.MainCloseButton.Text = "x";
            this.MainCloseButton.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Sitka Subheading", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(297, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(205, 44);
            this.label2.TabIndex = 2;
            this.label2.Text = "Главный экран";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.topPanel.Controls.Add(this.MainCloseButton);
            this.topPanel.Controls.Add(this.label2);
            this.topPanel.Controls.Add(this.label1);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(800, 100);
            this.topPanel.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Sitka Subheading", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(297, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "авторизация";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.topPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "mainForm";
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label MainCloseButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Label label1;
    }
}