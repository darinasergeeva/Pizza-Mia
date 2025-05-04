namespace Pizza_Mia
{
    partial class FormAdd
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
            flowLayoutPanelFill = new FlowLayoutPanel();
            DishСategory = new Label();
            comboBoxDishСategory = new ComboBox();
            NameDish = new Label();
            textBoxNameDish = new TextBox();
            DescriptionOfTheDish = new Label();
            textBoxDescriptionOfTheDish = new TextBox();
            labelThePriceOfTheDish = new Label();
            textBoxThePriceOfTheDish = new TextBox();
            labelCookingTime = new Label();
            textBoxCookingTime = new TextBox();
            labelPhotoOfTheDish = new Label();
            textBoxPhotoOfTheDish = new TextBox();
            flowLayoutPanelBotton = new FlowLayoutPanel();
            buttonSave = new Button();
            buttonCancel = new Button();
            flowLayoutPanelFill.SuspendLayout();
            flowLayoutPanelBotton.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanelFill
            // 
            flowLayoutPanelFill.BackColor = Color.White;
            flowLayoutPanelFill.Controls.Add(DishСategory);
            flowLayoutPanelFill.Controls.Add(comboBoxDishСategory);
            flowLayoutPanelFill.Controls.Add(NameDish);
            flowLayoutPanelFill.Controls.Add(textBoxNameDish);
            flowLayoutPanelFill.Controls.Add(DescriptionOfTheDish);
            flowLayoutPanelFill.Controls.Add(textBoxDescriptionOfTheDish);
            flowLayoutPanelFill.Controls.Add(labelThePriceOfTheDish);
            flowLayoutPanelFill.Controls.Add(textBoxThePriceOfTheDish);
            flowLayoutPanelFill.Controls.Add(labelCookingTime);
            flowLayoutPanelFill.Controls.Add(textBoxCookingTime);
            flowLayoutPanelFill.Controls.Add(labelPhotoOfTheDish);
            flowLayoutPanelFill.Controls.Add(textBoxPhotoOfTheDish);
            flowLayoutPanelFill.Dock = DockStyle.Fill;
            flowLayoutPanelFill.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            flowLayoutPanelFill.Location = new Point(0, 0);
            flowLayoutPanelFill.Name = "flowLayoutPanelFill";
            flowLayoutPanelFill.Padding = new Padding(10);
            flowLayoutPanelFill.Size = new Size(360, 419);
            flowLayoutPanelFill.TabIndex = 4;
            // 
            // DishСategory
            // 
            DishСategory.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            DishСategory.Location = new Point(13, 10);
            DishСategory.Name = "DishСategory";
            DishСategory.Size = new Size(201, 29);
            DishСategory.TabIndex = 1;
            DishСategory.Text = "Категория блюда";
            // 
            // comboBoxDishСategory
            // 
            comboBoxDishСategory.Location = new Point(13, 42);
            comboBoxDishСategory.Name = "comboBoxDishСategory";
            comboBoxDishСategory.Size = new Size(338, 33);
            comboBoxDishСategory.TabIndex = 9;
            // 
            // NameDish
            // 
            NameDish.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            NameDish.Location = new Point(13, 78);
            NameDish.Name = "NameDish";
            NameDish.Size = new Size(256, 29);
            NameDish.TabIndex = 3;
            NameDish.Text = "Наименование блюда";
            // 
            // textBoxNameDish
            // 
            textBoxNameDish.Location = new Point(13, 110);
            textBoxNameDish.Name = "textBoxNameDish";
            textBoxNameDish.Size = new Size(338, 33);
            textBoxNameDish.TabIndex = 4;
            // 
            // DescriptionOfTheDish
            // 
            DescriptionOfTheDish.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            DescriptionOfTheDish.Location = new Point(13, 146);
            DescriptionOfTheDish.Name = "DescriptionOfTheDish";
            DescriptionOfTheDish.Size = new Size(256, 26);
            DescriptionOfTheDish.TabIndex = 5;
            DescriptionOfTheDish.Text = "Описание блюда";
            // 
            // textBoxDescriptionOfTheDish
            // 
            textBoxDescriptionOfTheDish.Location = new Point(13, 175);
            textBoxDescriptionOfTheDish.Name = "textBoxDescriptionOfTheDish";
            textBoxDescriptionOfTheDish.Size = new Size(338, 33);
            textBoxDescriptionOfTheDish.TabIndex = 6;
            // 
            // labelThePriceOfTheDish
            // 
            labelThePriceOfTheDish.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelThePriceOfTheDish.Location = new Point(13, 211);
            labelThePriceOfTheDish.Name = "labelThePriceOfTheDish";
            labelThePriceOfTheDish.Size = new Size(201, 29);
            labelThePriceOfTheDish.TabIndex = 10;
            labelThePriceOfTheDish.Text = "Цена блюда(руб)";
            // 
            // textBoxThePriceOfTheDish
            // 
            textBoxThePriceOfTheDish.Location = new Point(13, 243);
            textBoxThePriceOfTheDish.Name = "textBoxThePriceOfTheDish";
            textBoxThePriceOfTheDish.Size = new Size(338, 33);
            textBoxThePriceOfTheDish.TabIndex = 11;
            // 
            // labelCookingTime
            // 
            labelCookingTime.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelCookingTime.Location = new Point(13, 279);
            labelCookingTime.Name = "labelCookingTime";
            labelCookingTime.Size = new Size(324, 29);
            labelCookingTime.TabIndex = 12;
            labelCookingTime.Text = "Время приготовления(мин)";
            // 
            // textBoxCookingTime
            // 
            textBoxCookingTime.Location = new Point(13, 311);
            textBoxCookingTime.Name = "textBoxCookingTime";
            textBoxCookingTime.Size = new Size(338, 33);
            textBoxCookingTime.TabIndex = 13;
            // 
            // labelPhotoOfTheDish
            // 
            labelPhotoOfTheDish.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelPhotoOfTheDish.Location = new Point(13, 347);
            labelPhotoOfTheDish.Name = "labelPhotoOfTheDish";
            labelPhotoOfTheDish.Size = new Size(201, 29);
            labelPhotoOfTheDish.TabIndex = 14;
            labelPhotoOfTheDish.Text = "Фотография блюда";
            // 
            // textBoxPhotoOfTheDish
            // 
            textBoxPhotoOfTheDish.Location = new Point(13, 379);
            textBoxPhotoOfTheDish.Name = "textBoxPhotoOfTheDish";
            textBoxPhotoOfTheDish.Size = new Size(338, 33);
            textBoxPhotoOfTheDish.TabIndex = 15;
            // 
            // flowLayoutPanelBotton
            // 
            flowLayoutPanelBotton.AutoSize = true;
            flowLayoutPanelBotton.BackColor = Color.FromArgb(244, 232, 211);
            flowLayoutPanelBotton.Controls.Add(buttonSave);
            flowLayoutPanelBotton.Controls.Add(buttonCancel);
            flowLayoutPanelBotton.Dock = DockStyle.Bottom;
            flowLayoutPanelBotton.FlowDirection = FlowDirection.RightToLeft;
            flowLayoutPanelBotton.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            flowLayoutPanelBotton.Location = new Point(0, 419);
            flowLayoutPanelBotton.Name = "flowLayoutPanelBotton";
            flowLayoutPanelBotton.Padding = new Padding(10);
            flowLayoutPanelBotton.Size = new Size(360, 61);
            flowLayoutPanelBotton.TabIndex = 5;
            // 
            // buttonSave
            // 
            buttonSave.BackColor = Color.FromArgb(103, 186, 128);
            buttonSave.DialogResult = DialogResult.OK;
            buttonSave.FlatStyle = FlatStyle.Flat;
            buttonSave.Location = new Point(187, 13);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(150, 35);
            buttonSave.TabIndex = 0;
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = false;
            // 
            // buttonCancel
            // 
            buttonCancel.BackColor = Color.FromArgb(103, 186, 128);
            buttonCancel.DialogResult = DialogResult.Cancel;
            buttonCancel.FlatStyle = FlatStyle.Flat;
            buttonCancel.Location = new Point(31, 13);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(150, 35);
            buttonCancel.TabIndex = 1;
            buttonCancel.Text = "Отмена";
            buttonCancel.UseVisualStyleBackColor = false;
            // 
            // FormAdd
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(360, 480);
            Controls.Add(flowLayoutPanelFill);
            Controls.Add(flowLayoutPanelBotton);
            Name = "FormAdd";
            Text = "FormAdd";
            flowLayoutPanelFill.ResumeLayout(false);
            flowLayoutPanelFill.PerformLayout();
            flowLayoutPanelBotton.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanelFill;
        private Label TypeOfSupplier;
        private ComboBox comboBoxSupplierType;
        private Label NameSupplier;
        public TextBox textBoxName;
        private Label TIN;
        public TextBox textBoxTin;
        private CheckBox checkBoxCurrent;
        private FlowLayoutPanel flowLayoutPanelBotton;
        private Button buttonSave;
        private Button buttonCancel;
        private Label DishСategory;
        private ComboBox comboBoxDishСategory;
        private Label NameDish;
        public TextBox textBoxNameDish;
        private Label DescriptionOfTheDish;
        public TextBox textBoxDescriptionOfTheDish;
        private Label label1;
        private Label labelThePriceOfTheDish;
        public TextBox textBoxThePriceOfTheDish;
        private Label label2;
        public TextBox textBox1;
        public TextBox textBox2;
        private Label labelCookingTime;
        public TextBox textBoxCookingTime;
        private Label labelPhotoOfTheDish;
        public TextBox textBoxPhotoOfTheDish;
    }
}