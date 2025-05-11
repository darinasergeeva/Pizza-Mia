namespace Pizza_Mia
{
    partial class FormСategoriesOfDishes
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
            flowLayoutPanelTop = new FlowLayoutPanel();
            buttonСategoriesAdd = new Button();
            buttonСategoriesUpdate = new Button();
            buttonСategoriesDelete = new Button();
            panelFill = new Panel();
            dataGridViewСategories = new DataGridView();
            flowLayoutPanelTop.SuspendLayout();
            panelFill.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewСategories).BeginInit();
            SuspendLayout();
            // 
            // flowLayoutPanelTop
            // 
            flowLayoutPanelTop.AutoSize = true;
            flowLayoutPanelTop.Controls.Add(buttonСategoriesAdd);
            flowLayoutPanelTop.Controls.Add(buttonСategoriesUpdate);
            flowLayoutPanelTop.Controls.Add(buttonСategoriesDelete);
            flowLayoutPanelTop.Dock = DockStyle.Top;
            flowLayoutPanelTop.Location = new Point(0, 0);
            flowLayoutPanelTop.Name = "flowLayoutPanelTop";
            flowLayoutPanelTop.Padding = new Padding(10);
            flowLayoutPanelTop.Size = new Size(559, 61);
            flowLayoutPanelTop.TabIndex = 0;
            // 
            // buttonСategoriesAdd
            // 
            buttonСategoriesAdd.BackColor = Color.White;
            buttonСategoriesAdd.Location = new Point(13, 13);
            buttonСategoriesAdd.Name = "buttonСategoriesAdd";
            buttonСategoriesAdd.Size = new Size(150, 35);
            buttonСategoriesAdd.TabIndex = 0;
            buttonСategoriesAdd.Text = "Добавить";
            buttonСategoriesAdd.UseVisualStyleBackColor = false;
            buttonСategoriesAdd.Click += ButtonСategoriesAdd_Click;
            // 
            // buttonСategoriesUpdate
            // 
            buttonСategoriesUpdate.BackColor = Color.White;
            buttonСategoriesUpdate.Location = new Point(169, 13);
            buttonСategoriesUpdate.Name = "buttonСategoriesUpdate";
            buttonСategoriesUpdate.Size = new Size(150, 35);
            buttonСategoriesUpdate.TabIndex = 1;
            buttonСategoriesUpdate.Text = "Редактировать";
            buttonСategoriesUpdate.UseVisualStyleBackColor = false;
            // 
            // buttonСategoriesDelete
            // 
            buttonСategoriesDelete.BackColor = Color.White;
            buttonСategoriesDelete.Location = new Point(325, 13);
            buttonСategoriesDelete.Name = "buttonСategoriesDelete";
            buttonСategoriesDelete.Size = new Size(150, 35);
            buttonСategoriesDelete.TabIndex = 2;
            buttonСategoriesDelete.Text = "Удалить";
            buttonСategoriesDelete.UseVisualStyleBackColor = false;
            // 
            // panelFill
            // 
            panelFill.Controls.Add(dataGridViewСategories);
            panelFill.Dock = DockStyle.Fill;
            panelFill.Location = new Point(0, 61);
            panelFill.Name = "panelFill";
            panelFill.Padding = new Padding(10);
            panelFill.Size = new Size(559, 352);
            panelFill.TabIndex = 1;
            // 
            // dataGridViewСategories
            // 
            dataGridViewСategories.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader;
            dataGridViewСategories.BackgroundColor = Color.White;
            dataGridViewСategories.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewСategories.Dock = DockStyle.Fill;
            dataGridViewСategories.Location = new Point(10, 10);
            dataGridViewСategories.MultiSelect = false;
            dataGridViewСategories.Name = "dataGridViewСategories";
            dataGridViewСategories.ReadOnly = true;
            dataGridViewСategories.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewСategories.Size = new Size(539, 332);
            dataGridViewСategories.TabIndex = 0;
            // 
            // FormСategoriesOfDishes
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(559, 413);
            Controls.Add(panelFill);
            Controls.Add(flowLayoutPanelTop);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(5);
            Name = "FormСategoriesOfDishes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Категории блюд";
            flowLayoutPanelTop.ResumeLayout(false);
            panelFill.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewСategories).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanelTop;
        private Button buttonСategoriesAdd;
        private Button buttonСategoriesUpdate;
        private Button buttonСategoriesDelete;
        private Panel panelFill;
        private DataGridView dataGridViewСategories;
    }
}