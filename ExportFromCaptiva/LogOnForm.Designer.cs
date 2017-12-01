namespace ExportFromCaptiva
{
    partial class LogOnForm
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
            this.TopPanel = new System.Windows.Forms.Panel();
            this.titelTopPanel = new System.Windows.Forms.Label();
            this.minimizePanel = new System.Windows.Forms.Panel();
            this.closePanel = new System.Windows.Forms.Panel();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.cancelButton = new System.Windows.Forms.Button();
            this.loginButton = new System.Windows.Forms.Button();
            this.iaServerAlertLabel = new System.Windows.Forms.Label();
            this.passwordAlertLabel = new System.Windows.Forms.Label();
            this.userAlertLabel = new System.Windows.Forms.Label();
            this.domainTextBox = new System.Windows.Forms.TextBox();
            this.serversTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.userTextBox = new System.Windows.Forms.TextBox();
            this.domainLabel = new System.Windows.Forms.Label();
            this.iaServerLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.userLabel = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.TopPanel.SuspendLayout();
            this.mainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TopPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TopPanel.Controls.Add(this.titelTopPanel);
            this.TopPanel.Controls.Add(this.minimizePanel);
            this.TopPanel.Controls.Add(this.closePanel);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(400, 26);
            this.TopPanel.TabIndex = 0;
            this.TopPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.TopPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.TopPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // titelTopPanel
            // 
            this.titelTopPanel.AutoSize = true;
            this.titelTopPanel.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titelTopPanel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.titelTopPanel.Location = new System.Drawing.Point(7, 4);
            this.titelTopPanel.Name = "titelTopPanel";
            this.titelTopPanel.Size = new System.Drawing.Size(84, 15);
            this.titelTopPanel.TabIndex = 3;
            this.titelTopPanel.Text = "IBM - Login";
            // 
            // minimizePanel
            // 
            this.minimizePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minimizePanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minimizePanel.Location = new System.Drawing.Point(329, 5);
            this.minimizePanel.Name = "minimizePanel";
            this.minimizePanel.Size = new System.Drawing.Size(30, 30);
            this.minimizePanel.TabIndex = 2;
            // 
            // closePanel
            // 
            this.closePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closePanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closePanel.Location = new System.Drawing.Point(365, 5);
            this.closePanel.Name = "closePanel";
            this.closePanel.Size = new System.Drawing.Size(30, 30);
            this.closePanel.TabIndex = 1;
            this.closePanel.Click += new System.EventHandler(this.closePanel_Click);
            this.closePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.closePanel_Paint);
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.mainPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mainPanel.Controls.Add(this.cancelButton);
            this.mainPanel.Controls.Add(this.loginButton);
            this.mainPanel.Controls.Add(this.iaServerAlertLabel);
            this.mainPanel.Controls.Add(this.passwordAlertLabel);
            this.mainPanel.Controls.Add(this.userAlertLabel);
            this.mainPanel.Controls.Add(this.domainTextBox);
            this.mainPanel.Controls.Add(this.serversTextBox);
            this.mainPanel.Controls.Add(this.passwordTextBox);
            this.mainPanel.Controls.Add(this.userTextBox);
            this.mainPanel.Controls.Add(this.domainLabel);
            this.mainPanel.Controls.Add(this.iaServerLabel);
            this.mainPanel.Controls.Add(this.passwordLabel);
            this.mainPanel.Controls.Add(this.userLabel);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 26);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(400, 274);
            this.mainPanel.TabIndex = 1;
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cancelButton.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.ForeColor = System.Drawing.Color.Silver;
            this.cancelButton.Location = new System.Drawing.Point(230, 231);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 13;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // loginButton
            // 
            this.loginButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.loginButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.loginButton.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginButton.ForeColor = System.Drawing.Color.Silver;
            this.loginButton.Location = new System.Drawing.Point(95, 231);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(75, 23);
            this.loginButton.TabIndex = 12;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = false;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // iaServerAlertLabel
            // 
            this.iaServerAlertLabel.AutoSize = true;
            this.iaServerAlertLabel.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iaServerAlertLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.iaServerAlertLabel.Location = new System.Drawing.Point(90, 161);
            this.iaServerAlertLabel.Name = "iaServerAlertLabel";
            this.iaServerAlertLabel.Size = new System.Drawing.Size(139, 13);
            this.iaServerAlertLabel.TabIndex = 10;
            this.iaServerAlertLabel.Text = "·Field cannot be empty";
            // 
            // passwordAlertLabel
            // 
            this.passwordAlertLabel.AutoSize = true;
            this.passwordAlertLabel.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordAlertLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.passwordAlertLabel.Location = new System.Drawing.Point(90, 110);
            this.passwordAlertLabel.Name = "passwordAlertLabel";
            this.passwordAlertLabel.Size = new System.Drawing.Size(157, 13);
            this.passwordAlertLabel.TabIndex = 9;
            this.passwordAlertLabel.Text = "·Password cannot be empty";
            // 
            // userAlertLabel
            // 
            this.userAlertLabel.AutoSize = true;
            this.userAlertLabel.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userAlertLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.userAlertLabel.Location = new System.Drawing.Point(90, 60);
            this.userAlertLabel.Name = "userAlertLabel";
            this.userAlertLabel.Size = new System.Drawing.Size(133, 13);
            this.userAlertLabel.TabIndex = 8;
            this.userAlertLabel.Text = "·User cannot be empty";
            // 
            // domainTextBox
            // 
            this.domainTextBox.BackColor = System.Drawing.Color.White;
            this.domainTextBox.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.domainTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.domainTextBox.Location = new System.Drawing.Point(90, 188);
            this.domainTextBox.Name = "domainTextBox";
            this.domainTextBox.Size = new System.Drawing.Size(215, 20);
            this.domainTextBox.TabIndex = 7;
            // 
            // serversTextBox
            // 
            this.serversTextBox.BackColor = System.Drawing.Color.White;
            this.serversTextBox.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serversTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.serversTextBox.Location = new System.Drawing.Point(90, 138);
            this.serversTextBox.Name = "serversTextBox";
            this.serversTextBox.Size = new System.Drawing.Size(241, 20);
            this.serversTextBox.TabIndex = 6;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.BackColor = System.Drawing.Color.White;
            this.passwordTextBox.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.passwordTextBox.Location = new System.Drawing.Point(90, 87);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '·';
            this.passwordTextBox.Size = new System.Drawing.Size(215, 20);
            this.passwordTextBox.TabIndex = 5;
            // 
            // userTextBox
            // 
            this.userTextBox.BackColor = System.Drawing.Color.White;
            this.userTextBox.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.userTextBox.Location = new System.Drawing.Point(90, 37);
            this.userTextBox.Name = "userTextBox";
            this.userTextBox.Size = new System.Drawing.Size(215, 20);
            this.userTextBox.TabIndex = 4;
            // 
            // domainLabel
            // 
            this.domainLabel.AutoSize = true;
            this.domainLabel.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.domainLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.domainLabel.Location = new System.Drawing.Point(10, 190);
            this.domainLabel.Name = "domainLabel";
            this.domainLabel.Size = new System.Drawing.Size(49, 13);
            this.domainLabel.TabIndex = 3;
            this.domainLabel.Text = "Domain:";
            // 
            // iaServerLabel
            // 
            this.iaServerLabel.AutoSize = true;
            this.iaServerLabel.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iaServerLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.iaServerLabel.Location = new System.Drawing.Point(10, 140);
            this.iaServerLabel.Name = "iaServerLabel";
            this.iaServerLabel.Size = new System.Drawing.Size(73, 13);
            this.iaServerLabel.TabIndex = 2;
            this.iaServerLabel.Text = "IA-Servers:";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.passwordLabel.Location = new System.Drawing.Point(10, 90);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(61, 13);
            this.passwordLabel.TabIndex = 1;
            this.passwordLabel.Text = "Password:";
            // 
            // userLabel
            // 
            this.userLabel.AutoSize = true;
            this.userLabel.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.userLabel.Location = new System.Drawing.Point(10, 40);
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(37, 13);
            this.userLabel.TabIndex = 0;
            this.userLabel.Text = "User:";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // LogOnForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(400, 300);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.TopPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(300, 200);
            this.Name = "LogOnForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "LogOn";
            this.Load += new System.EventHandler(this.LogOnForm_Load);
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.Panel minimizePanel;
        private System.Windows.Forms.Panel closePanel;
        private System.Windows.Forms.Label titelTopPanel;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.TextBox userTextBox;
        private System.Windows.Forms.Label domainLabel;
        private System.Windows.Forms.Label iaServerLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label userLabel;
        private System.Windows.Forms.Label iaServerAlertLabel;
        private System.Windows.Forms.Label passwordAlertLabel;
        private System.Windows.Forms.Label userAlertLabel;
        private System.Windows.Forms.TextBox domainTextBox;
        private System.Windows.Forms.TextBox serversTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Button cancelButton;
    }
}

