namespace Pizza_Mia
{
    partial class FormIngredients
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
            buttonIngredientsAdd = new Button();
            buttonIngredientsUpdate = new Button();
            buttonIngredientsDelete = new Button();
            dataGridViewIngredients = new DataGridView();
            panelFill = new Panel();
            flowLayoutPanelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewIngredients).BeginInit();
            panelFill.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanelTop
            // 
            flowLayoutPanelTop.AutoSize = true;
            flowLayoutPanelTop.BackColor = Color.FromArgb(244, 232, 211);
            flowLayoutPanelTop.Controls.Add(buttonIngredientsAdd);
            flowLayoutPanelTop.Controls.Add(buttonIngredientsUpdate);
            flowLayoutPanelTop.Controls.Add(buttonIngredientsDelete);
            flowLayoutPanelTop.Dock = DockStyle.Top;
            flowLayoutPanelTop.Location = new Point(0, 0);
            flowLayoutPanelTop.Name = "flowLayoutPanelTop";
            flowLayoutPanelTop.Padding = new Padding(10);
            flowLayoutPanelTop.Size = new Size(613, 61);
            flowLayoutPanelTop.TabIndex = 1;
            // 
            // buttonIngredientsAdd
            // 
            buttonIngredientsAdd.BackColor = Color.FromArgb(103, 186, 128);
            buttonIngredientsAdd.Location = new Point(13, 13);
            buttonIngredientsAdd.Name = "buttonIngredientsAdd";
            buttonIngredientsAdd.Size = new Size(150, 35);
            buttonIngredientsAdd.TabIndex = 0;
            buttonIngredientsAdd.Text = "Добавить";
            buttonIngredientsAdd.UseVisualStyleBackColor = false;
            buttonIngredientsAdd.Click += ButtonIngredientsAdd_Click;
            // 
            // buttonIngredientsUpdate
            // 
            buttonIngredientsUpdate.BackColor = Color.FromArgb(103, 186, 128);
            buttonIngredientsUpdate.Location = new Point(169, 13);
            buttonIngredientsUpdate.Name = "buttonIngredientsUpdate";
            buttonIngredientsUpdate.Size = new Size(150, 35);
            buttonIngredientsUpdate.TabIndex = 1;
            buttonIngredientsUpdate.Text = "Редактировать";
            buttonIngredientsUpdate.UseVisualStyleBackColor = false;
            // 
            // buttonIngredientsDelete
            // 
            buttonIngredientsDelete.BackColor = Color.FromArgb(103, 186, 128);
            buttonIngredientsDelete.Location = new Point(325, 13);
            buttonIngredientsDelete.Name = "buttonIngredientsDelete";
            buttonIngredientsDelete.Size = new Size(150, 35);
            buttonIngredientsDelete.TabIndex = 2;
            buttonIngredientsDelete.Text = "Удалить";
            buttonIngredientsDelete.UseVisualStyleBackColor = false;
            // 
            // dataGridViewIngredients
            // 
            dataGridViewIngredients.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewIngredients.BackgroundColor = Color.White;
            dataGridViewIngredients.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewIngredients.Dock = DockStyle.Fill;
            dataGridViewIngredients.Location = new Point(10, 10);
            dataGridViewIngredients.MultiSelect = false;
            dataGridViewIngredients.Name = "dataGridViewIngredients";
            dataGridViewIngredients.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewIngredients.Size = new Size(593, 576);
            dataGridViewIngredients.TabIndex = 0;
            // 
            // panelFill
            // 
            panelFill.Controls.Add(dataGridViewIngredients);
            panelFill.Dock = DockStyle.Fill;
            panelFill.Location = new Point(0, 61);
            panelFill.Name = "panelFill";
            panelFill.Padding = new Padding(10);
            panelFill.Size = new Size(613, 596);
            panelFill.TabIndex = 2;
            // 
            // FormIngredients
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(613, 657);
            Controls.Add(panelFill);
            Controls.Add(flowLayoutPanelTop);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(5);
            Name = "FormIngredients";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ингредиенты";
            flowLayoutPanelTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewIngredients).EndInit();
            panelFill.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanelTop;
        private Button buttonIngredientsAdd;
        private Button buttonIngredientsUpdate;
        private Button buttonIngredientsDelete;
        private DataGridView dataGridViewIngredients;
        private Panel panelFill;
    }
}