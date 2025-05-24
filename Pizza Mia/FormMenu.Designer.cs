namespace Pizza_Mia
{
    partial class FormMenu
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
            flowLayoutPanelDishes = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // flowLayoutPanelDishes
            // 
            flowLayoutPanelDishes.AutoScroll = true;
            flowLayoutPanelDishes.AutoSize = true;
            flowLayoutPanelDishes.BackColor = Color.Azure;
            flowLayoutPanelDishes.Dock = DockStyle.Fill;
            flowLayoutPanelDishes.Location = new Point(0, 0);
            flowLayoutPanelDishes.Margin = new Padding(0);
            flowLayoutPanelDishes.Name = "flowLayoutPanelDishes";
            flowLayoutPanelDishes.Padding = new Padding(16, 17, 16, 17);
            flowLayoutPanelDishes.Size = new Size(861, 598);
            flowLayoutPanelDishes.TabIndex = 2;
            // 
            // FormMenu
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(861, 598);
            Controls.Add(flowLayoutPanelDishes);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(5);
            Name = "FormMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Меню";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanelDishes;
    }
}