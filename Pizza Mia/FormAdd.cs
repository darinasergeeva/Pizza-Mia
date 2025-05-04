using System;
using System.Linq;
using System.Windows.Forms;
using Pizza_Mia.Models; // Убедитесь, что это правильное пространство имен

namespace Pizza_Mia
{
    public partial class FormAdd : Form
    {
        public string DishName => textBoxNameDish.Text;
        public string DishDescription => textBoxDescriptionOfTheDish.Text;
        public decimal DishPrice => decimal.TryParse(textBoxThePriceOfTheDish.Text, out var price) ? price : 0;
        public int CookingTime => int.TryParse(textBoxCookingTime.Text, out var time) ? time : 0;
        public string PhotoPath => textBoxPhotoOfTheDish.Text;
        public int DishCategoryId => comboBoxDishСategory.SelectedValue != null ? (int)comboBoxDishСategory.SelectedValue : 0;

        public FormAdd()
        {
            InitializeComponent();
            LoadDishCategories();
        }

        private void LoadDishCategories()
        {
            using (var db = new Pizza_Mia.Models.AppContext()) // Указываем полное имя
            {
                var categories = db.CategoriesDishes
                    .Select(c => new { c.Id, c.Name })
                    .ToList();

                comboBoxDishСategory.DataSource = categories;
                comboBoxDishСategory.DisplayMember = "Name";
                comboBoxDishСategory.ValueMember = "Id";
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(DishName) ||
                string.IsNullOrWhiteSpace(DishDescription) ||
                DishPrice <= 0 ||
                CookingTime <= 0 ||
                string.IsNullOrWhiteSpace(PhotoPath) ||
                DishCategoryId == 0)
            {
                MessageBox.Show("Пожалуйста, заполните все поля и выберите категорию.");
                return;
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}