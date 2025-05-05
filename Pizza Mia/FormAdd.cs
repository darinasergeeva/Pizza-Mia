using System;
using System.Linq;
using System.Windows.Forms;
using Pizza_Mia.Models;

namespace Pizza_Mia
{
    public partial class FormAdd : Form
    {
        // Свойства для получения данных из текстовых полей и комбобокса
        public string DishName => textBoxNameDish.Text;
        public string DishDescription => textBoxDescriptionOfTheDish.Text;
        public decimal DishPrice => decimal.TryParse(textBoxThePriceOfTheDish.Text, out var price) ? price : 0;
        public int CookingTime => int.TryParse(textBoxCookingTime.Text, out var time) ? time : 0;
        public string PhotoPath => textBoxPhotoOfTheDish.Text;
        public int DishCategoryId => comboBoxDishСategory.SelectedValue != null ? (int)comboBoxDishСategory.SelectedValue : 0;

        public FormAdd()
        {
            InitializeComponent();
            LoadDishCategories(); // Загружаем категории блюд
        }

        private void LoadDishCategories() // Метод для загрузки категорий блюд
        {
            using (var db = new Pizza_Mia.Models.AppContext())  // Создаем новый контекст базы данных
            {
                // Загружаем категории из базы данных
                var categories = db.CategoriesDishes
                    .Select(c => new { c.Id, c.Name }) // Выбираем Id и имя категории
                    .ToList();  // Преобразуем в список
                // Настраиваем комбобокс для выбора категории
                comboBoxDishСategory.DataSource = categories;
                comboBoxDishСategory.DisplayMember = "Name";
                comboBoxDishСategory.ValueMember = "Id";
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            // Проверяем, заполнены ли все обязательные поля
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
        public FormAdd(Dish dishToEdit) : this() // Вызываем основной конструктор
        {
            // Заполняем поля формы данными из объекта блюда
            textBoxNameDish.Text = dishToEdit.Name;
            textBoxDescriptionOfTheDish.Text = dishToEdit.Description ?? string.Empty;
            textBoxThePriceOfTheDish.Text = dishToEdit.Price?.ToString() ?? "";
            textBoxCookingTime.Text = dishToEdit.СookingTime.ToString();
            textBoxPhotoOfTheDish.Text = dishToEdit.Photo;

            // Устанавливаем выбранную категорию
            if (dishToEdit.IdCategory != null)
                comboBoxDishСategory.SelectedValue = dishToEdit.IdCategory; // Если категория выбрана, устанавливаем ее
            else
                comboBoxDishСategory.SelectedIndex = -1; // Если нет, сбрасываем выбор
        }
    }
}