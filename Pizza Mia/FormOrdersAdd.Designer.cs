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
            LabelOrderDate = new Label();
            comboBoxNameCustomer = new ComboBox();
            LabelNameCustomer = new Label();
            LabelTotalAmount = new Label();
            flowLayoutPanelFill = new FlowLayoutPanel();
            dateTimePickerOrderDate = new DateTimePicker();
            textBoxTotalAmount = new TextBox();
            labelStatus = new Label();
            textBoxStatus = new TextBox();
            flowLayoutPanelBotton = new FlowLayoutPanel();
            buttonSave = new Button();
            buttonCancel = new Button();
            flowLayoutPanelFill.SuspendLayout();
            flowLayoutPanelBotton.SuspendLayout();
            SuspendLayout();
            // 
            // LabelOrderDate
            // 
            LabelOrderDate.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            LabelOrderDate.Location = new Point(13, 10);
            LabelOrderDate.Name = "LabelOrderDate";
            LabelOrderDate.Size = new Size(201, 29);
            LabelOrderDate.TabIndex = 1;
            LabelOrderDate.Text = "Дата заказа";
            // 
            // comboBoxNameCustomer
            // 
            comboBoxNameCustomer.Location = new Point(13, 110);
            comboBoxNameCustomer.Name = "comboBoxNameCustomer";
            comboBoxNameCustomer.Size = new Size(338, 33);
            comboBoxNameCustomer.TabIndex = 9;
            // 
            // LabelNameCustomer
            // 
            LabelNameCustomer.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            LabelNameCustomer.Location = new Point(13, 78);
            LabelNameCustomer.Name = "LabelNameCustomer";
            LabelNameCustomer.Size = new Size(256, 29);
            LabelNameCustomer.TabIndex = 3;
            LabelNameCustomer.Text = "Клиент";
            // 
            // LabelTotalAmount
            // 
            LabelTotalAmount.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            LabelTotalAmount.Location = new Point(13, 146);
            LabelTotalAmount.Name = "LabelTotalAmount";
            LabelTotalAmount.Size = new Size(256, 26);
            LabelTotalAmount.TabIndex = 5;
            LabelTotalAmount.Text = "Стоимость";
            // 
            // flowLayoutPanelFill
            // 
            flowLayoutPanelFill.BackColor = Color.White;
            flowLayoutPanelFill.Controls.Add(LabelOrderDate);
            flowLayoutPanelFill.Controls.Add(dateTimePickerOrderDate);
            flowLayoutPanelFill.Controls.Add(LabelNameCustomer);
            flowLayoutPanelFill.Controls.Add(comboBoxNameCustomer);
            flowLayoutPanelFill.Controls.Add(LabelTotalAmount);
            flowLayoutPanelFill.Controls.Add(textBoxTotalAmount);
            flowLayoutPanelFill.Controls.Add(labelStatus);
            flowLayoutPanelFill.Controls.Add(textBoxStatus);
            flowLayoutPanelFill.Dock = DockStyle.Fill;
            flowLayoutPanelFill.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            flowLayoutPanelFill.Location = new Point(0, 0);
            flowLayoutPanelFill.Name = "flowLayoutPanelFill";
            flowLayoutPanelFill.Padding = new Padding(10);
            flowLayoutPanelFill.Size = new Size(385, 287);
            flowLayoutPanelFill.TabIndex = 6;
            // 
            // dateTimePickerOrderDate
            // 
            dateTimePickerOrderDate.Location = new Point(13, 42);
            dateTimePickerOrderDate.Name = "dateTimePickerOrderDate";
            dateTimePickerOrderDate.Size = new Size(338, 33);
            dateTimePickerOrderDate.TabIndex = 14;
            // 
            // textBoxTotalAmount
            // 
            textBoxTotalAmount.Location = new Point(13, 175);
            textBoxTotalAmount.Name = "textBoxTotalAmount";
            textBoxTotalAmount.Size = new Size(338, 33);
            textBoxTotalAmount.TabIndex = 6;
            // 
            // labelStatus
            // 
            labelStatus.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelStatus.Location = new Point(13, 211);
            labelStatus.Name = "labelStatus";
            labelStatus.Size = new Size(324, 29);
            labelStatus.TabIndex = 12;
            labelStatus.Text = "Статус заказа";
            // 
            // textBoxStatus
            // 
            textBoxStatus.Location = new Point(13, 243);
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
            flowLayoutPanelBotton.Location = new Point(0, 287);
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
            ClientSize = new Size(385, 348);
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

        private Label LabelOrderDate;
        private Label LabelNameCustomer;
        private Label LabelTotalAmount;
        private FlowLayoutPanel flowLayoutPanelFill;
        public TextBox textBoxTotalAmount;
        private Label labelStatus;
        public TextBox textBoxStatus;
        private FlowLayoutPanel flowLayoutPanelBotton;
        private Button buttonSave;
        private Button buttonCancel;
        public DateTimePicker dateTimePickerOrderDate;
        public ComboBox comboBoxNameCustomer;
    }
}