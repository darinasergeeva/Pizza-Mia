namespace Pizza_Mia
{
    partial class FormIngredientsAdd
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
            components = new System.ComponentModel.Container();
            flowLayoutPanelBottm = new FlowLayoutPanel();
            buttonSave = new Button();
            buttonCancel = new Button();
            textBoxNameOfTheIngredient = new TextBox();
            panelFill = new Panel();
            textBoxQuantityInStock = new TextBox();
            labelQuantityInStock = new Label();
            textBoxUnit = new TextBox();
            labelUnit = new Label();
            labelNameOfTheIngredient = new Label();
            errorProvider = new ErrorProvider(components);
            flowLayoutPanelBottm.SuspendLayout();
            panelFill.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // flowLayoutPanelBottm
            // 
            flowLayoutPanelBottm.AutoSize = true;
            flowLayoutPanelBottm.BackColor = Color.FromArgb(244, 232, 211);
            flowLayoutPanelBottm.Controls.Add(buttonSave);
            flowLayoutPanelBottm.Controls.Add(buttonCancel);
            flowLayoutPanelBottm.Dock = DockStyle.Bottom;
            flowLayoutPanelBottm.FlowDirection = FlowDirection.RightToLeft;
            flowLayoutPanelBottm.Location = new Point(0, 207);
            flowLayoutPanelBottm.Name = "flowLayoutPanelBottm";
            flowLayoutPanelBottm.Padding = new Padding(15);
            flowLayoutPanelBottm.Size = new Size(432, 71);
            flowLayoutPanelBottm.TabIndex = 3;
            // 
            // buttonSave
            // 
            buttonSave.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            buttonSave.BackColor = Color.FromArgb(103, 186, 128);
            buttonSave.DialogResult = DialogResult.OK;
            buttonSave.Location = new Point(249, 18);
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
            buttonCancel.Location = new Point(93, 18);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(150, 35);
            buttonCancel.TabIndex = 1;
            buttonCancel.Text = "Отмена";
            buttonCancel.UseVisualStyleBackColor = false;
            // 
            // textBoxNameOfTheIngredient
            // 
            textBoxNameOfTheIngredient.Dock = DockStyle.Top;
            textBoxNameOfTheIngredient.Location = new Point(15, 40);
            textBoxNameOfTheIngredient.Name = "textBoxNameOfTheIngredient";
            textBoxNameOfTheIngredient.Size = new Size(402, 33);
            textBoxNameOfTheIngredient.TabIndex = 1;
            textBoxNameOfTheIngredient.TextChanged += TextBoxNameOfTheIngredient_TextChanged;
            textBoxNameOfTheIngredient.Validating += TextBoxNameOfTheIngredient_Validating;
            // 
            // panelFill
            // 
            panelFill.BackColor = Color.White;
            panelFill.Controls.Add(textBoxQuantityInStock);
            panelFill.Controls.Add(labelQuantityInStock);
            panelFill.Controls.Add(textBoxUnit);
            panelFill.Controls.Add(labelUnit);
            panelFill.Controls.Add(textBoxNameOfTheIngredient);
            panelFill.Controls.Add(labelNameOfTheIngredient);
            panelFill.Dock = DockStyle.Fill;
            panelFill.Location = new Point(0, 0);
            panelFill.Name = "panelFill";
            panelFill.Padding = new Padding(15);
            panelFill.Size = new Size(432, 278);
            panelFill.TabIndex = 2;
            // 
            // textBoxQuantityInStock
            // 
            textBoxQuantityInStock.Dock = DockStyle.Top;
            textBoxQuantityInStock.Location = new Point(15, 156);
            textBoxQuantityInStock.Name = "textBoxQuantityInStock";
            textBoxQuantityInStock.Size = new Size(402, 33);
            textBoxQuantityInStock.TabIndex = 5;
            textBoxQuantityInStock.TextChanged += TextBoxQuantityInStock_TextChanged;
            textBoxQuantityInStock.Validating += TextBoxQuantityInStock_Validating;
            // 
            // labelQuantityInStock
            // 
            labelQuantityInStock.AutoSize = true;
            labelQuantityInStock.Dock = DockStyle.Top;
            labelQuantityInStock.Location = new Point(15, 131);
            labelQuantityInStock.Name = "labelQuantityInStock";
            labelQuantityInStock.Size = new Size(203, 25);
            labelQuantityInStock.TabIndex = 4;
            labelQuantityInStock.Text = "Количество на складе";
            // 
            // textBoxUnit
            // 
            textBoxUnit.Dock = DockStyle.Top;
            textBoxUnit.Location = new Point(15, 98);
            textBoxUnit.Name = "textBoxUnit";
            textBoxUnit.Size = new Size(402, 33);
            textBoxUnit.TabIndex = 3;
            textBoxUnit.TextChanged += TextBoxUnit_TextChanged;
            textBoxUnit.Validating += TextBoxUnit_Validating;
            // 
            // labelUnit
            // 
            labelUnit.AutoSize = true;
            labelUnit.Dock = DockStyle.Top;
            labelUnit.Location = new Point(15, 73);
            labelUnit.Name = "labelUnit";
            labelUnit.Size = new Size(205, 25);
            labelUnit.TabIndex = 2;
            labelUnit.Text = "Единица измерения(г)";
            // 
            // labelNameOfTheIngredient
            // 
            labelNameOfTheIngredient.AutoSize = true;
            labelNameOfTheIngredient.Dock = DockStyle.Top;
            labelNameOfTheIngredient.Location = new Point(15, 15);
            labelNameOfTheIngredient.Name = "labelNameOfTheIngredient";
            labelNameOfTheIngredient.Size = new Size(263, 25);
            labelNameOfTheIngredient.TabIndex = 0;
            labelNameOfTheIngredient.Text = "Наименование ингредиента ";
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // FormIngredientsAdd
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(432, 278);
            Controls.Add(flowLayoutPanelBottm);
            Controls.Add(panelFill);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(5);
            Name = "FormIngredientsAdd";
            flowLayoutPanelBottm.ResumeLayout(false);
            panelFill.ResumeLayout(false);
            panelFill.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanelBottm;
        private Button buttonSave;
        private Button buttonCancel;
        protected internal TextBox textBoxNameOfTheIngredient;
        private Panel panelFill;
        private Label labelNameOfTheIngredient;
        protected internal TextBox textBoxQuantityInStock;
        private Label labelQuantityInStock;
        protected internal TextBox textBoxUnit;
        private Label labelUnit;
        private ErrorProvider errorProvider;
    }
}