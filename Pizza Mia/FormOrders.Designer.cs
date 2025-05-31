namespace Pizza_Mia
{
    partial class FormOrders
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
            buttonAdd = new Button();
            buttonUpdate = new Button();
            flowLayoutPanelTop = new FlowLayoutPanel();
            buttonDelete = new Button();
            flowLayoutPanelOrders = new FlowLayoutPanel();
            flowLayoutPanelTop.SuspendLayout();
            SuspendLayout();
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
            flowLayoutPanelTop.Size = new Size(1158, 61);
            flowLayoutPanelTop.TabIndex = 2;
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
            // 
            // flowLayoutPanelOrders
            // 
            flowLayoutPanelOrders.BackColor = Color.Azure;
            flowLayoutPanelOrders.Dock = DockStyle.Fill;
            flowLayoutPanelOrders.Location = new Point(0, 61);
            flowLayoutPanelOrders.Name = "flowLayoutPanelOrders";
            flowLayoutPanelOrders.Size = new Size(1158, 719);
            flowLayoutPanelOrders.TabIndex = 3;
            // 
            // FormOrders
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1158, 780);
            Controls.Add(flowLayoutPanelOrders);
            Controls.Add(flowLayoutPanelTop);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(5);
            Name = "FormOrders";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Заказы";
            flowLayoutPanelTop.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button buttonAdd;
        private Button buttonUpdate;
        private FlowLayoutPanel flowLayoutPanelTop;
        private Button buttonDelete;
        private FlowLayoutPanel flowLayoutPanelOrders;
    }
}