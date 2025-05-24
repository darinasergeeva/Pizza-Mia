namespace Pizza_Mia
{
    partial class InitialForm
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
            buttonEnter = new Button();
            buttonRegistration = new Button();
            buttonMenu = new Button();
            SuspendLayout();
            // 
            // buttonEnter
            // 
            buttonEnter.BackColor = SystemColors.Control;
            buttonEnter.Location = new Point(267, 12);
            buttonEnter.Name = "buttonEnter";
            buttonEnter.Size = new Size(150, 35);
            buttonEnter.TabIndex = 0;
            buttonEnter.Text = "Войти";
            buttonEnter.UseVisualStyleBackColor = false;
            buttonEnter.Click += ButtonEnter_Click;
            // 
            // buttonRegistration
            // 
            buttonRegistration.BackColor = SystemColors.Control;
            buttonRegistration.Location = new Point(423, 12);
            buttonRegistration.Name = "buttonRegistration";
            buttonRegistration.Size = new Size(150, 35);
            buttonRegistration.TabIndex = 1;
            buttonRegistration.Text = "Регистрация ";
            buttonRegistration.UseVisualStyleBackColor = false;
            buttonRegistration.Click += ButtonRegistration_Click;
            // 
            // buttonMenu
            // 
            buttonMenu.Location = new Point(12, 336);
            buttonMenu.Name = "buttonMenu";
            buttonMenu.Size = new Size(556, 45);
            buttonMenu.TabIndex = 2;
            buttonMenu.Text = "Меню";
            buttonMenu.UseVisualStyleBackColor = true;
            buttonMenu.Click += ButtonMenu_Click;
            // 
            // InitialForm
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.YFouxYbs8wo;
            ClientSize = new Size(585, 405);
            Controls.Add(buttonMenu);
            Controls.Add(buttonRegistration);
            Controls.Add(buttonEnter);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(5);
            MaximizeBox = false;
            Name = "InitialForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Добро пожаловать!";
            ResumeLayout(false);
        }

        #endregion

        private Button buttonEnter;
        private Button buttonRegistration;
        private Button buttonMenu;
    }
}