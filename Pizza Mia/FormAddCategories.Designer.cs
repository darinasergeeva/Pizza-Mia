namespace Pizza_Mia
{
    partial class FormAddCategories
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
            panelFill = new Panel();
            textBoxCategoriesOfDishes = new TextBox();
            labelCategoriesOfDishes = new Label();
            flowLayoutPanelBottm = new FlowLayoutPanel();
            buttonSave = new Button();
            buttonCancel = new Button();
            errorProvider = new ErrorProvider(components);
            panelFill.SuspendLayout();
            flowLayoutPanelBottm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // panelFill
            // 
            panelFill.Controls.Add(textBoxCategoriesOfDishes);
            panelFill.Controls.Add(labelCategoriesOfDishes);
            panelFill.Dock = DockStyle.Fill;
            panelFill.Location = new Point(0, 0);
            panelFill.Name = "panelFill";
            panelFill.Padding = new Padding(15);
            panelFill.Size = new Size(384, 160);
            panelFill.TabIndex = 0;
            // 
            // textBoxCategoriesOfDishes
            // 
            textBoxCategoriesOfDishes.Dock = DockStyle.Top;
            textBoxCategoriesOfDishes.Location = new Point(15, 40);
            textBoxCategoriesOfDishes.Name = "textBoxCategoriesOfDishes";
            textBoxCategoriesOfDishes.Size = new Size(354, 32);
            textBoxCategoriesOfDishes.TabIndex = 1;
            textBoxCategoriesOfDishes.TextChanged += textBoxCategoriesOfDishes_TextChanged;
            textBoxCategoriesOfDishes.Validating += TextBoxCategoriesOfDishes_Validating;
            // 
            // labelCategoriesOfDishes
            // 
            labelCategoriesOfDishes.AutoSize = true;
            labelCategoriesOfDishes.Dock = DockStyle.Top;
            labelCategoriesOfDishes.Location = new Point(15, 15);
            labelCategoriesOfDishes.Name = "labelCategoriesOfDishes";
            labelCategoriesOfDishes.Size = new Size(162, 25);
            labelCategoriesOfDishes.TabIndex = 0;
            labelCategoriesOfDishes.Text = "Категория блюда";
            // 
            // flowLayoutPanelBottm
            // 
            flowLayoutPanelBottm.AutoSize = true;
            flowLayoutPanelBottm.Controls.Add(buttonSave);
            flowLayoutPanelBottm.Controls.Add(buttonCancel);
            flowLayoutPanelBottm.Dock = DockStyle.Bottom;
            flowLayoutPanelBottm.FlowDirection = FlowDirection.RightToLeft;
            flowLayoutPanelBottm.Location = new Point(0, 89);
            flowLayoutPanelBottm.Name = "flowLayoutPanelBottm";
            flowLayoutPanelBottm.Padding = new Padding(15);
            flowLayoutPanelBottm.Size = new Size(384, 71);
            flowLayoutPanelBottm.TabIndex = 1;
            // 
            // buttonSave
            // 
            buttonSave.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            buttonSave.BackColor = Color.White;
            buttonSave.DialogResult = DialogResult.OK;
            buttonSave.Location = new Point(201, 18);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(150, 35);
            buttonSave.TabIndex = 0;
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = false;
            // 
            // buttonCancel
            // 
            buttonCancel.BackColor = Color.White;
            buttonCancel.DialogResult = DialogResult.Cancel;
            buttonCancel.Location = new Point(45, 18);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(150, 35);
            buttonCancel.TabIndex = 1;
            buttonCancel.Text = "Отмена";
            buttonCancel.UseVisualStyleBackColor = false;
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // FormAddCategories
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(384, 160);
            Controls.Add(flowLayoutPanelBottm);
            Controls.Add(panelFill);
            Font = new Font("Segoe UI", 14F);
            Margin = new Padding(5);
            Name = "FormAddCategories";
            StartPosition = FormStartPosition.CenterScreen;
            panelFill.ResumeLayout(false);
            panelFill.PerformLayout();
            flowLayoutPanelBottm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelFill;
        private FlowLayoutPanel flowLayoutPanelBottm;
        private Label labelCategoriesOfDishes;
        private Button buttonSave;
        private Button buttonCancel;
        protected internal TextBox textBoxCategoriesOfDishes;
        private ErrorProvider errorProvider;
    }
}