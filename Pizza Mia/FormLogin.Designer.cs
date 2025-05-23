namespace Pizza_Mia
{
    partial class FormLogin
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
            txtUsername = new TextBox();
            flowLayoutPanelBottm = new FlowLayoutPanel();
            buttonLogin = new Button();
            panelFill = new Panel();
            txtPassword = new TextBox();
            flowLayoutPanelBottm.SuspendLayout();
            panelFill.SuspendLayout();
            SuspendLayout();
            // 
            // txtUsername
            // 
            txtUsername.Dock = DockStyle.Top;
            txtUsername.Location = new Point(15, 15);
            txtUsername.Margin = new Padding(10);
            txtUsername.Name = "txtUsername";
            txtUsername.PlaceholderText = "Логин";
            txtUsername.Size = new Size(319, 33);
            txtUsername.TabIndex = 1;
            // 
            // flowLayoutPanelBottm
            // 
            flowLayoutPanelBottm.AutoSize = true;
            flowLayoutPanelBottm.BackColor = Color.FromArgb(244, 232, 211);
            flowLayoutPanelBottm.Controls.Add(buttonLogin);
            flowLayoutPanelBottm.Dock = DockStyle.Bottom;
            flowLayoutPanelBottm.FlowDirection = FlowDirection.RightToLeft;
            flowLayoutPanelBottm.Font = new Font("Segoe UI", 14.25F);
            flowLayoutPanelBottm.Location = new Point(0, 108);
            flowLayoutPanelBottm.Name = "flowLayoutPanelBottm";
            flowLayoutPanelBottm.Padding = new Padding(15);
            flowLayoutPanelBottm.Size = new Size(349, 71);
            flowLayoutPanelBottm.TabIndex = 3;
            // 
            // buttonLogin
            // 
            buttonLogin.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            buttonLogin.BackColor = Color.FromArgb(103, 186, 128);
            buttonLogin.Location = new Point(26, 18);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(290, 35);
            buttonLogin.TabIndex = 0;
            buttonLogin.Text = "Войти";
            buttonLogin.UseVisualStyleBackColor = false;
            buttonLogin.Click += ButtonLogin_Click;
            // 
            // panelFill
            // 
            panelFill.BackColor = Color.White;
            panelFill.Controls.Add(txtPassword);
            panelFill.Controls.Add(txtUsername);
            panelFill.Dock = DockStyle.Fill;
            panelFill.Font = new Font("Segoe UI", 14.25F);
            panelFill.Location = new Point(0, 0);
            panelFill.Name = "panelFill";
            panelFill.Padding = new Padding(15);
            panelFill.Size = new Size(349, 179);
            panelFill.TabIndex = 2;
            // 
            // txtPassword
            // 
            txtPassword.Dock = DockStyle.Top;
            txtPassword.Location = new Point(15, 48);
            txtPassword.Margin = new Padding(10);
            txtPassword.Name = "txtPassword";
            txtPassword.PlaceholderText = "Пароль";
            txtPassword.Size = new Size(319, 33);
            txtPassword.TabIndex = 2;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(349, 179);
            Controls.Add(flowLayoutPanelBottm);
            Controls.Add(panelFill);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            MaximizeBox = false;
            Name = "FormLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Вход";
            flowLayoutPanelBottm.ResumeLayout(false);
            panelFill.ResumeLayout(false);
            panelFill.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        protected internal TextBox txtUsername;
        private FlowLayoutPanel flowLayoutPanelBottm;
        private Button buttonLogin;
        private Panel panelFill;
        protected internal TextBox txtPassword;
    }
}