namespace Pizza_Mia
{
    partial class FormUserManagement
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
            dataGridViewUsers = new DataGridView();
            labelSelectRole = new Label();
            comboBoxRoles = new ComboBox();
            buttonChangeRole = new Button();
            buttonRefresh = new Button();
            panelBottom = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridViewUsers).BeginInit();
            panelBottom.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridViewUsers
            // 
            dataGridViewUsers.BackgroundColor = Color.Beige;
            dataGridViewUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewUsers.Dock = DockStyle.Fill;
            dataGridViewUsers.Location = new Point(0, 0);
            dataGridViewUsers.Name = "dataGridViewUsers";
            dataGridViewUsers.Size = new Size(538, 455);
            dataGridViewUsers.TabIndex = 0;
            // 
            // labelSelectRole
            // 
            labelSelectRole.AutoSize = true;
            labelSelectRole.Location = new Point(12, 11);
            labelSelectRole.Name = "labelSelectRole";
            labelSelectRole.Size = new Size(160, 25);
            labelSelectRole.TabIndex = 3;
            labelSelectRole.Text = "Назначить роль: ";
            // 
            // comboBoxRoles
            // 
            comboBoxRoles.BackColor = Color.LemonChiffon;
            comboBoxRoles.FlatStyle = FlatStyle.Popup;
            comboBoxRoles.FormattingEnabled = true;
            comboBoxRoles.Location = new Point(12, 39);
            comboBoxRoles.Name = "comboBoxRoles";
            comboBoxRoles.Size = new Size(210, 33);
            comboBoxRoles.TabIndex = 4;
            // 
            // buttonChangeRole
            // 
            buttonChangeRole.BackColor = Color.Bisque;
            buttonChangeRole.FlatStyle = FlatStyle.Popup;
            buttonChangeRole.Location = new Point(12, 86);
            buttonChangeRole.Name = "buttonChangeRole";
            buttonChangeRole.Size = new Size(160, 35);
            buttonChangeRole.TabIndex = 5;
            buttonChangeRole.Text = "Изменить роль";
            buttonChangeRole.UseVisualStyleBackColor = false;
            buttonChangeRole.Click += ButtonChangeRole_Click_1;
            // 
            // buttonRefresh
            // 
            buttonRefresh.BackColor = Color.Bisque;
            buttonRefresh.FlatStyle = FlatStyle.Popup;
            buttonRefresh.Location = new Point(178, 86);
            buttonRefresh.Name = "buttonRefresh";
            buttonRefresh.Size = new Size(171, 35);
            buttonRefresh.TabIndex = 6;
            buttonRefresh.Text = "Обновить список";
            buttonRefresh.UseVisualStyleBackColor = false;
            buttonRefresh.Click += ButtonRefresh_Click_1;
            // 
            // panelBottom
            // 
            panelBottom.BackColor = Color.Linen;
            panelBottom.Controls.Add(labelSelectRole);
            panelBottom.Controls.Add(buttonRefresh);
            panelBottom.Controls.Add(comboBoxRoles);
            panelBottom.Controls.Add(buttonChangeRole);
            panelBottom.Dock = DockStyle.Bottom;
            panelBottom.Location = new Point(0, 322);
            panelBottom.Name = "panelBottom";
            panelBottom.Size = new Size(538, 133);
            panelBottom.TabIndex = 7;
            // 
            // FormUserManagement
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(538, 455);
            Controls.Add(panelBottom);
            Controls.Add(dataGridViewUsers);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(5);
            Name = "FormUserManagement";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Управление ролями пользователей";
            ((System.ComponentModel.ISupportInitialize)dataGridViewUsers).EndInit();
            panelBottom.ResumeLayout(false);
            panelBottom.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewUsers;
        private Label labelSelectRole;
        private ComboBox comboBoxRoles;
        private Button buttonChangeRole;
        private Button buttonRefresh;
        private Panel panelBottom;
    }
}