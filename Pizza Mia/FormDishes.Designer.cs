namespace Pizza_Mia
{
    partial class FormDishes
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
            buttonAdd = new Button();
            buttonUpdate = new Button();
            buttonDelete = new Button();
            flowLayoutPanelDishes = new FlowLayoutPanel();
            flowLayoutPanelTop.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanelTop
            // 
            flowLayoutPanelTop.AutoSize = true;
            flowLayoutPanelTop.BackColor = Color.PowderBlue;
            flowLayoutPanelTop.Controls.Add(buttonAdd);
            flowLayoutPanelTop.Controls.Add(buttonUpdate);
            flowLayoutPanelTop.Controls.Add(buttonDelete);
            flowLayoutPanelTop.Dock = DockStyle.Top;
            flowLayoutPanelTop.Location = new Point(0, 0);
            flowLayoutPanelTop.Margin = new Padding(0);
            flowLayoutPanelTop.Name = "flowLayoutPanelTop";
            flowLayoutPanelTop.Padding = new Padding(10);
            flowLayoutPanelTop.Size = new Size(1684, 61);
            flowLayoutPanelTop.TabIndex = 0;
            // 
            // buttonAdd
            // 
            buttonAdd.BackColor = Color.LightCyan;
            buttonAdd.Location = new Point(13, 13);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(150, 35);
            buttonAdd.TabIndex = 0;
            buttonAdd.Text = "Добавить";
            buttonAdd.UseVisualStyleBackColor = false;
            buttonAdd.Click += ButtonAdd_Click;
            // 
            // buttonUpdate
            // 
            buttonUpdate.BackColor = Color.LightCyan;
            buttonUpdate.Location = new Point(169, 13);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(150, 35);
            buttonUpdate.TabIndex = 1;
            buttonUpdate.Text = "Редактировать";
            buttonUpdate.UseVisualStyleBackColor = false;
            buttonUpdate.Click += ButtonUpdate_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.BackColor = Color.LightCyan;
            buttonDelete.Location = new Point(325, 13);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(150, 35);
            buttonDelete.TabIndex = 2;
            buttonDelete.Text = "Удалить";
            buttonDelete.UseVisualStyleBackColor = false;
            buttonDelete.Click += ButtonDelete_Click;
            // 
            // flowLayoutPanelDishes
            // 
            flowLayoutPanelDishes.AutoScroll = true;
            flowLayoutPanelDishes.AutoSize = true;
            flowLayoutPanelDishes.BackColor = Color.Azure;
            flowLayoutPanelDishes.Dock = DockStyle.Fill;
            flowLayoutPanelDishes.Location = new Point(0, 61);
            flowLayoutPanelDishes.Margin = new Padding(0);
            flowLayoutPanelDishes.Name = "flowLayoutPanelDishes";
            flowLayoutPanelDishes.Padding = new Padding(10);
            flowLayoutPanelDishes.Size = new Size(1684, 761);
            flowLayoutPanelDishes.TabIndex = 1;
            // 
            // FormDishes
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1684, 822);
            Controls.Add(flowLayoutPanelDishes);
            Controls.Add(flowLayoutPanelTop);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(5);
            Name = "FormDishes";
            Text = "Меню";
            flowLayoutPanelTop.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanelTop;
        private Button buttonAdd;
        private Button buttonUpdate;
        private Button buttonDelete;
        private FlowLayoutPanel flowLayoutPanelDishes;
    }
}