using System.ComponentModel;

namespace Pizza_Mia
{
    public partial class FormAddCategories : Form
    {
        public FormAddCategories()
        {
            InitializeComponent();
        }

        private void TextBoxCategoriesOfDishes_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxCategoriesOfDishes.Text))
            {
                errorProvider.SetError(textBoxCategoriesOfDishes, "Поле не может быть пустым ");
                buttonSave.Enabled = false;
            }
            else
            {
                errorProvider.Clear();
                buttonSave.Enabled = true;
            }
        }

        private void TextBoxCategoriesOfDishes_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxCategoriesOfDishes.Text))
            {
                errorProvider.SetError(textBoxCategoriesOfDishes, "Поле не может быть пустым ");
                buttonSave.Enabled = false;
            }
            else
            {
                errorProvider.Clear();
                buttonSave.Enabled = true;
            }
        }
    }
}
