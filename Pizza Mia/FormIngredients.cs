using Microsoft.EntityFrameworkCore;
using Pizza_Mia.Models;
using System.ComponentModel;
using AppContext = Pizza_Mia.Models.AppContext;
namespace Pizza_Mia
{
    public partial class FormIngredients : Form
    {
        private AppContext db;
        public FormIngredients()
        {
            InitializeComponent();
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this.db = new AppContext();
            this.db.Ingredients.Load();
            this.dataGridViewIngredients.DataSource = this.db.Ingredients.Local.OrderBy(o => o.Name).ToList();
            dataGridViewIngredients.Columns["Id"].Visible = false;
            dataGridViewIngredients.Columns["Deliveries"].Visible = false;
            dataGridViewIngredients.Columns["DishIgredients"].Visible = false;

            dataGridViewIngredients.Columns["Name"].HeaderText = "Наименование";
            dataGridViewIngredients.Columns["Unit"].HeaderText = "Единица измерения(г)";
            dataGridViewIngredients.Columns["StockQuantity"].HeaderText = "Количество на складе";
        }
        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
            this.db?.Dispose();
            this.db = null;
        }

        private void ButtonIngredientsAdd_Click(object sender, EventArgs e)
        {
            FormIngredientsAdd formIngredientsAdd = new FormIngredientsAdd();
            DialogResult result = formIngredientsAdd.ShowDialog(this);
            if (result == DialogResult.Cancel)
                return;
            // Создаем новый объект Ingredient и заполняем его данными из формы
            Ingredient ingredient = new Ingredient
            {
                Name = formIngredientsAdd.textBoxNameOfTheIngredient.Text,
                Unit = int.Parse(formIngredientsAdd.textBoxUnit.Text),
                StockQuantity = int.Parse(formIngredientsAdd.textBoxQuantityInStock.Text)
            };
            // Добавляем новый ингредиент в контекст базы данных
            db.Ingredients.Add(ingredient);
            // Сохраняем изменения в базе данных
            db.SaveChanges();
            MessageBox.Show("Новый ингредиент добавлен");
            // Обновляем источник данных для DataGridView, если он используется для отображения ингредиентов
            this.dataGridViewIngredients.DataSource = this.db.Ingredients.Local.OrderBy(o => o.Name).ToList();
        }

        private void ButtonIngredientsUpdate_Click(object sender, EventArgs e)
        {
            // Проверка, что выбран хотя бы один элемент в DataGridView
            if (dataGridViewIngredients.SelectedRows.Count == 0)
            {
                MessageBox.Show("Пожалуйста, выберите ингредиент для редактирования.");
                return;
            }

            // Получаем индекс выбранной строки
            int index = dataGridViewIngredients.SelectedRows[0].Index;

            //ID ингредиента из первой колонки (индекс 0) выбранной строки
            if (!int.TryParse(dataGridViewIngredients[0, index].Value?.ToString(), out int id))
            {
                MessageBox.Show("Не удалось получить корректный ID ингредиента.");
                return;
            }

            // Ищем ингредиент в базе по ID
            Ingredient ingredient = db.Ingredients.Find(id);


            FormIngredientsAdd formIngredientsAdd = new FormIngredientsAdd();
            formIngredientsAdd.textBoxNameOfTheIngredient.Text = ingredient.Name;
            formIngredientsAdd.textBoxUnit.Text = ingredient.Unit.ToString();
            formIngredientsAdd.textBoxQuantityInStock.Text = ingredient.StockQuantity.ToString();


            DialogResult result = formIngredientsAdd.ShowDialog(this);
            if (result == DialogResult.Cancel)
                return;

            // Валидируем и обновляем данные ингредиента из формы
            ingredient.Name = formIngredientsAdd.textBoxNameOfTheIngredient.Text;

            if (!int.TryParse(formIngredientsAdd.textBoxUnit.Text, out int unit))
            {
                MessageBox.Show("Пожалуйста, введите корректное целочисленное значение для поля 'Единица измерения'.");
                return;
            }
            ingredient.Unit = unit;

            if (!int.TryParse(formIngredientsAdd.textBoxQuantityInStock.Text, out int quantity))
            {
                MessageBox.Show("Пожалуйста, введите корректное целочисленное значение для поля 'Количество на складе'.");
                return;
            }
            ingredient.StockQuantity = quantity;
            db.SaveChanges();
            MessageBox.Show("Ингредиент успешно обновлен.");
            dataGridViewIngredients.DataSource = db.Ingredients.Local.OrderBy(i => i.Name).ToList();
        }

        private void ButtonIngredientsDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewIngredients.SelectedRows.Count == 0)
            {
                return;
            }
            DialogResult result = MessageBox.Show(
                "Вы уверены, что хотите удалить объект?",
                "",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (result == DialogResult.No) { return; }
            int index = dataGridViewIngredients.SelectedRows[0].Index;
            int id;
            bool converted = Int32.TryParse(dataGridViewIngredients[0, index].Value.ToString(), out id);
            if (!converted)
                return;
            Ingredient ingredient = db.Ingredients.Find(id);

            db.Ingredients.Remove(ingredient);

            db.SaveChanges();
            MessageBox.Show("Объект удалён");
            this.dataGridViewIngredients.DataSource = this.db.Ingredients.Local.OrderBy(o => o.Name).ToList();
        }
    }
}
