namespace Pizza_Mia
{
    partial class FormGeneral
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
            buttonDishes = new Button();
            buttonCategoriesOfDishes = new Button();
            SuspendLayout();
            // 
            // buttonDishes
            // 
            buttonDishes.BackColor = Color.Gainsboro;
            buttonDishes.ForeColor = SystemColors.ControlText;
            buttonDishes.ImageAlign = ContentAlignment.MiddleRight;
            buttonDishes.Location = new Point(12, 12);
            buttonDishes.Name = "buttonDishes";
            buttonDishes.Size = new Size(191, 39);
            buttonDishes.TabIndex = 0;
            buttonDishes.Text = "Меню";
            buttonDishes.UseVisualStyleBackColor = false;
            buttonDishes.Click += ButtonDishes_Click;
            // 
            // buttonCategoriesOfDishes
            // 
            buttonCategoriesOfDishes.BackColor = Color.Gainsboro;
            buttonCategoriesOfDishes.ForeColor = SystemColors.ControlText;
            buttonCategoriesOfDishes.ImageAlign = ContentAlignment.MiddleRight;
            buttonCategoriesOfDishes.Location = new Point(424, 12);
            buttonCategoriesOfDishes.Name = "buttonCategoriesOfDishes";
            buttonCategoriesOfDishes.Size = new Size(191, 39);
            buttonCategoriesOfDishes.TabIndex = 1;
            buttonCategoriesOfDishes.Text = "Категории блюд";
            buttonCategoriesOfDishes.UseVisualStyleBackColor = false;
            buttonCategoriesOfDishes.Click += buttonCategoriesOfDishes_Click;
            // 
            // FormGeneral
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.YFouxYbs8wo;
            ClientSize = new Size(627, 429);
            Controls.Add(buttonCategoriesOfDishes);
            Controls.Add(buttonDishes);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(5);
            MaximizeBox = false;
            Name = "FormGeneral";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pizza Mia";
            ResumeLayout(false);
        }

        #endregion

        private Button buttonDishes;
        private Button buttonCategoriesOfDishes;
    }
}