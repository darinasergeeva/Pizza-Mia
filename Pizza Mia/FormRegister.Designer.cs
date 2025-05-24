namespace Pizza_Mia
{
    partial class FormRegister
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
            flowLayoutPanelBottm = new FlowLayoutPanel();
            buttonRegister = new Button();
            panelFill = new Panel();
            cmbRole = new ComboBox();
            labelRole = new Label();
            txtEmail = new TextBox();
            labelEmail = new Label();
            txtPassword = new TextBox();
            labelPassword = new Label();
            txtUsername = new TextBox();
            labelUsername = new Label();
            flowLayoutPanelBottm.SuspendLayout();
            panelFill.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanelBottm
            // 
            flowLayoutPanelBottm.AutoSize = true;
            flowLayoutPanelBottm.BackColor = Color.FromArgb(244, 232, 211);
            flowLayoutPanelBottm.Controls.Add(buttonRegister);
            flowLayoutPanelBottm.Dock = DockStyle.Bottom;
            flowLayoutPanelBottm.FlowDirection = FlowDirection.RightToLeft;
            flowLayoutPanelBottm.Font = new Font("Segoe UI", 14.25F);
            flowLayoutPanelBottm.Location = new Point(0, 278);
            flowLayoutPanelBottm.Name = "flowLayoutPanelBottm";
            flowLayoutPanelBottm.Padding = new Padding(15);
            flowLayoutPanelBottm.Size = new Size(335, 71);
            flowLayoutPanelBottm.TabIndex = 5;
            // 
            // buttonRegister
            // 
            buttonRegister.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            buttonRegister.BackColor = Color.FromArgb(103, 186, 128);
            buttonRegister.Location = new Point(29, 18);
            buttonRegister.Name = "buttonRegister";
            buttonRegister.Size = new Size(273, 35);
            buttonRegister.TabIndex = 0;
            buttonRegister.Text = "Зарегистрироваться";
            buttonRegister.UseVisualStyleBackColor = false;
            buttonRegister.Click += ButtonRegister_Click;
            // 
            // panelFill
            // 
            panelFill.BackColor = Color.White;
            panelFill.Controls.Add(cmbRole);
            panelFill.Controls.Add(labelRole);
            panelFill.Controls.Add(txtEmail);
            panelFill.Controls.Add(labelEmail);
            panelFill.Controls.Add(txtPassword);
            panelFill.Controls.Add(labelPassword);
            panelFill.Controls.Add(txtUsername);
            panelFill.Controls.Add(labelUsername);
            panelFill.Dock = DockStyle.Fill;
            panelFill.Font = new Font("Segoe UI", 14.25F);
            panelFill.Location = new Point(0, 0);
            panelFill.Name = "panelFill";
            panelFill.Padding = new Padding(15);
            panelFill.Size = new Size(335, 349);
            panelFill.TabIndex = 4;
            // 
            // cmbRole
            // 
            cmbRole.FormattingEnabled = true;
            cmbRole.Location = new Point(11, 236);
            cmbRole.Name = "cmbRole";
            cmbRole.Size = new Size(312, 33);
            cmbRole.TabIndex = 7;
            // 
            // labelRole
            // 
            labelRole.AutoSize = true;
            labelRole.Location = new Point(11, 208);
            labelRole.Name = "labelRole";
            labelRole.Size = new Size(185, 25);
            labelRole.TabIndex = 6;
            labelRole.Text = "Укажите вашу роль:";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(12, 172);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "Еmail";
            txtEmail.Size = new Size(311, 33);
            txtEmail.TabIndex = 5;
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Location = new Point(11, 142);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(177, 25);
            labelEmail.TabIndex = 4;
            labelEmail.Text = "Введите ваш email:";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(12, 106);
            txtPassword.Name = "txtPassword";
            txtPassword.PlaceholderText = "Пароль";
            txtPassword.Size = new Size(311, 33);
            txtPassword.TabIndex = 3;
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Location = new Point(11, 78);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(191, 25);
            labelPassword.TabIndex = 2;
            labelPassword.Text = "Придумайте пароль:";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(12, 42);
            txtUsername.Name = "txtUsername";
            txtUsername.PlaceholderText = "Логин";
            txtUsername.Size = new Size(311, 33);
            txtUsername.TabIndex = 1;
            // 
            // labelUsername
            // 
            labelUsername.AutoSize = true;
            labelUsername.Location = new Point(11, 14);
            labelUsername.Name = "labelUsername";
            labelUsername.Size = new Size(178, 25);
            labelUsername.TabIndex = 0;
            labelUsername.Text = "Придумайте логин:";
            // 
            // FormRegister
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(335, 349);
            Controls.Add(flowLayoutPanelBottm);
            Controls.Add(panelFill);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(5);
            MaximizeBox = false;
            Name = "FormRegister";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Регистрация";
            flowLayoutPanelBottm.ResumeLayout(false);
            panelFill.ResumeLayout(false);
            panelFill.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanelBottm;
        private Button buttonRegister;
        private Panel panelFill;
        private Label labelUsername;
        private TextBox txtUsername;
        private TextBox textBox3;
        private Label labelRole;
        private TextBox txtEmail;
        private Label labelEmail;
        private TextBox txtPassword;
        private Label labelPassword;
        private ComboBox cmbRole;
    }
}