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
            dataGridViewBottom = new DataGridView();
            label1 = new Label();
            labelSelectRole = new Label();
            comboBoxRoles = new ComboBox();
            buttonChangeRole = new Button();
            buttonRefresh = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewUsers).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBottom).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewUsers
            // 
            dataGridViewUsers.BackgroundColor = Color.White;
            dataGridViewUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewUsers.Dock = DockStyle.Fill;
            dataGridViewUsers.Location = new Point(0, 0);
            dataGridViewUsers.Name = "dataGridViewUsers";
            dataGridViewUsers.Size = new Size(538, 654);
            dataGridViewUsers.TabIndex = 0;
            // 
            // dataGridViewBottom
            // 
            dataGridViewBottom.BackgroundColor = Color.White;
            dataGridViewBottom.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewBottom.Dock = DockStyle.Bottom;
            dataGridViewBottom.Location = new Point(0, 509);
            dataGridViewBottom.Name = "dataGridViewBottom";
            dataGridViewBottom.Size = new Size(538, 145);
            dataGridViewBottom.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(139, 25);
            label1.TabIndex = 2;
            label1.Text = "Пользователи:";
            // 
            // labelSelectRole
            // 
            labelSelectRole.AutoSize = true;
            labelSelectRole.Location = new Point(12, 519);
            labelSelectRole.Name = "labelSelectRole";
            labelSelectRole.Size = new Size(160, 25);
            labelSelectRole.TabIndex = 3;
            labelSelectRole.Text = "Назначить роль: ";
            // 
            // comboBoxRoles
            // 
            comboBoxRoles.FormattingEnabled = true;
            comboBoxRoles.Location = new Point(12, 547);
            comboBoxRoles.Name = "comboBoxRoles";
            comboBoxRoles.Size = new Size(210, 33);
            comboBoxRoles.TabIndex = 4;
            // 
            // buttonChangeRole
            // 
            buttonChangeRole.Location = new Point(12, 607);
            buttonChangeRole.Name = "buttonChangeRole";
            buttonChangeRole.Size = new Size(160, 35);
            buttonChangeRole.TabIndex = 5;
            buttonChangeRole.Text = "Изменить роль";
            buttonChangeRole.UseVisualStyleBackColor = true;
            // 
            // buttonRefresh
            // 
            buttonRefresh.Location = new Point(178, 607);
            buttonRefresh.Name = "buttonRefresh";
            buttonRefresh.Size = new Size(171, 35);
            buttonRefresh.TabIndex = 6;
            buttonRefresh.Text = "Обновить список";
            buttonRefresh.UseVisualStyleBackColor = true;
            // 
            // FormUserManagement
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(538, 654);
            Controls.Add(buttonRefresh);
            Controls.Add(buttonChangeRole);
            Controls.Add(comboBoxRoles);
            Controls.Add(labelSelectRole);
            Controls.Add(label1);
            Controls.Add(dataGridViewBottom);
            Controls.Add(dataGridViewUsers);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(5, 5, 5, 5);
            Name = "FormUserManagement";
            Text = "Управление ролями пользователей";
            ((System.ComponentModel.ISupportInitialize)dataGridViewUsers).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBottom).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewUsers;
        private DataGridView dataGridViewBottom;
        private Label label1;
        private Label labelSelectRole;
        private ComboBox comboBoxRoles;
        private Button buttonChangeRole;
        private Button buttonRefresh;
    }
}