namespace Pizza_Mia
{
    partial class FormOrdersAdd
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
            OrderDate = new Label();
            comboBoxNameCustomer = new ComboBox();
            NameCustomer = new Label();
            textBoxOrderDate = new TextBox();
            TotalAmount = new Label();
            flowLayoutPanelFill = new FlowLayoutPanel();
            textBoxTotalAmount = new TextBox();
            labelThePriceOfTheDish = new Label();
            textBoxThePriceOfTheDish = new TextBox();
            labelStatus = new Label();
            textBoxStatus = new TextBox();
            flowLayoutPanelBotton = new FlowLayoutPanel();
            buttonSave = new Button();
            buttonCancel = new Button();
            flowLayoutPanelFill.SuspendLayout();
            flowLayoutPanelBotton.SuspendLayout();
            SuspendLayout();
            // 
            // OrderDate
            // 
            OrderDate.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            OrderDate.Location = new Point(13, 10);
            OrderDate.Name = "OrderDate";
            OrderDate.Size = new Size(201, 29);
            OrderDate.TabIndex = 1;
            OrderDate.Text = "Дата заказа";
            // 
            // comboBoxNameCustomer
            // 
            comboBoxNameCustomer.Location = new Point(13, 110);
            comboBoxNameCustomer.Name = "comboBoxNameCustomer";
            comboBoxNameCustomer.Size = new Size(338, 33);
            comboBoxNameCustomer.TabIndex = 9;
            // 
            // NameCustomer
            // 
            NameCustomer.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            NameCustomer.Location = new Point(13, 78);
            NameCustomer.Name = "NameCustomer";
            NameCustomer.Size = new Size(256, 29);
            NameCustomer.TabIndex = 3;
            NameCustomer.Text = "Клиент";
            // 
            // textBoxOrderDate
            // 
            textBoxOrderDate.Location = new Point(13, 42);
            textBoxOrderDate.Name = "textBoxOrderDate";
            textBoxOrderDate.Size = new Size(338, 33);
            textBoxOrderDate.TabIndex = 4;
            // 
            // TotalAmount
            // 
            TotalAmount.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            TotalAmount.Location = new Point(13, 146);
            TotalAmount.Name = "TotalAmount";
            TotalAmount.Size = new Size(256, 26);
            TotalAmount.TabIndex = 5;
            TotalAmount.Text = "Стоимость";
            // 
            // flowLayoutPanelFill
            // 
            flowLayoutPanelFill.BackColor = Color.White;
            flowLayoutPanelFill.Controls.Add(OrderDate);
            flowLayoutPanelFill.Controls.Add(textBoxOrderDate);
            flowLayoutPanelFill.Controls.Add(NameCustomer);
            flowLayoutPanelFill.Controls.Add(comboBoxNameCustomer);
            flowLayoutPanelFill.Controls.Add(TotalAmount);
            flowLayoutPanelFill.Controls.Add(textBoxTotalAmount);
            flowLayoutPanelFill.Controls.Add(labelThePriceOfTheDish);
            flowLayoutPanelFill.Controls.Add(textBoxThePriceOfTheDish);
            flowLayoutPanelFill.Controls.Add(labelStatus);
            flowLayoutPanelFill.Controls.Add(textBoxStatus);
            flowLayoutPanelFill.Dock = DockStyle.Fill;
            flowLayoutPanelFill.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            flowLayoutPanelFill.Location = new Point(0, 0);
            flowLayoutPanelFill.Name = "flowLayoutPanelFill";
            flowLayoutPanelFill.Padding = new Padding(10);
            flowLayoutPanelFill.Size = new Size(385, 361);
            flowLayoutPanelFill.TabIndex = 6;
            // 
            // textBoxTotalAmount
            // 
            textBoxTotalAmount.Location = new Point(13, 175);
            textBoxTotalAmount.Name = "textBoxTotalAmount";
            textBoxTotalAmount.Size = new Size(338, 33);
            textBoxTotalAmount.TabIndex = 6;
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
            // labelStatus
            // 
            labelStatus.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelStatus.Location = new Point(13, 279);
            labelStatus.Name = "labelStatus";
            labelStatus.Size = new Size(324, 29);
            labelStatus.TabIndex = 12;
            labelStatus.Text = "Статус заказа";
            // 
            // textBoxStatus
            // 
            textBoxStatus.Location = new Point(13, 311);
            textBoxStatus.Name = "textBoxStatus";
            textBoxStatus.Size = new Size(338, 33);
            textBoxStatus.TabIndex = 13;
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
            flowLayoutPanelBotton.Location = new Point(0, 361);
            flowLayoutPanelBotton.Name = "flowLayoutPanelBotton";
            flowLayoutPanelBotton.Padding = new Padding(10);
            flowLayoutPanelBotton.Size = new Size(385, 61);
            flowLayoutPanelBotton.TabIndex = 7;
            // 
            // buttonSave
            // 
            buttonSave.BackColor = Color.FromArgb(103, 186, 128);
            buttonSave.DialogResult = DialogResult.OK;
            buttonSave.FlatStyle = FlatStyle.Flat;
            buttonSave.Location = new Point(212, 13);
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
            buttonCancel.Location = new Point(56, 13);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(150, 35);
            buttonCancel.TabIndex = 1;
            buttonCancel.Text = "Отмена";
            buttonCancel.UseVisualStyleBackColor = false;
            // 
            // FormOrdersAdd
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(385, 422);
            Controls.Add(flowLayoutPanelFill);
            Controls.Add(flowLayoutPanelBotton);
            MaximizeBox = false;
            Name = "FormOrdersAdd";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Редактор";
            flowLayoutPanelFill.ResumeLayout(false);
            flowLayoutPanelFill.PerformLayout();
            flowLayoutPanelBotton.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label OrderDate;
        private ComboBox comboBoxNameCustomer;
        private Label NameCustomer;
        public TextBox textBoxOrderDate;
        private Label TotalAmount;
        private FlowLayoutPanel flowLayoutPanelFill;
        public TextBox textBoxTotalAmount;
        private Label labelThePriceOfTheDish;
        public TextBox textBoxThePriceOfTheDish;
        private Label labelStatus;
        public TextBox textBoxStatus;
        private FlowLayoutPanel flowLayoutPanelBotton;
        private Button buttonSave;
        private Button buttonCancel;
    }
}