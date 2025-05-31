using Microsoft.EntityFrameworkCore;
using Pizza_Mia.Models;
using System.ComponentModel;
using PizzaAppContext = Pizza_Mia.Models.PizzaAppContext;
namespace Pizza_Mia
{

    public partial class FormСategoriesOfDishes : Form
    {
        private PizzaAppContext db;
        private User currentUser; // Добавляем переменную для текущего пользователя
        public FormСategoriesOfDishes(User user)
        {
            InitializeComponent();
            currentUser = user; // Инициализируем текущего пользователя
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this.db = new PizzaAppContext();
            this.db.CategoriesDishes.Load();
            this.dataGridViewСategories.DataSource = this.db.CategoriesDishes.Local.OrderBy(o => o.Name).ToList();
            dataGridViewСategories.Columns["Id"].Visible = false;
            dataGridViewСategories.Columns["Dishes"].Visible = false;

            dataGridViewСategories.Columns["Name"].HeaderText = "Категория блюда";
            ConfigureAccess(); // Настраиваем доступ в зависимости от роли пользователя
        }
        private void ConfigureAccess()
        {
            if (currentUser.Role == "Admin")
            {
                // Полный доступ
                EnableAllControls();
            }
            else if (currentUser.Role == "Cashier")
            {
                DisableAllControlsExceptView();
            }
            else if (currentUser.Role == "Cook")
            {
                // Только просмотр
                EnableAllControls();
            }
        }

        private void EnableAllControls()
        {
            buttonСategoriesAdd.Visible = true;
            buttonСategoriesUpdate.Visible = true;
            buttonСategoriesDelete.Visible = true;
        }

        private void DisableAllControlsExceptView()
        {
            buttonСategoriesAdd.Visible = false;
            buttonСategoriesUpdate.Visible = false;
            buttonСategoriesDelete.Visible = false;
        }
       
        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);

            this.db?.Dispose();
            this.db = null;
        }
        private void ButtonСategoriesAdd_Click(object sender, EventArgs e)
        {
            FormAddCategories formAddCategories = new FormAddCategories();
            DialogResult result = formAddCategories.ShowDialog(this);

            if (result == DialogResult.Cancel)
                return;

            CategoriesDish categoriesDish = new CategoriesDish
            {
                Name = formAddCategories.textBoxCategoriesOfDishes.Text
            };

            db.CategoriesDishes.Add(categoriesDish);
            db.SaveChanges();

            MessageBox.Show("Новый объект добавлен");

            this.dataGridViewСategories.DataSource = this.db.CategoriesDishes.Local.OrderBy(o => o.Name).ToList();
        }

        private void ButtonСategoriesUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridViewСategories.SelectedRows.Count == 0)
            {
                return;
            }

            int index = dataGridViewСategories.SelectedRows[0].Index;
            int id;
            bool converted = Int32.TryParse(dataGridViewСategories[0, index].Value.ToString(), out id);
            if (!converted)
                return;
            CategoriesDish categoriesDish = db.CategoriesDishes.Find(id);
            
            FormAddCategories formAddCategories = new();
            formAddCategories.textBoxCategoriesOfDishes.Text = categoriesDish.Name;
            DialogResult result = formAddCategories.ShowDialog(this);
            if (result == DialogResult.Cancel)
                return;
            categoriesDish.Name = formAddCategories.textBoxCategoriesOfDishes.Text;
            db.SaveChanges();
            MessageBox.Show("Объект обновлён");
            this.dataGridViewСategories.DataSource = this.db.CategoriesDishes.Local.OrderBy(o => o.Name).ToList();

        }

        private void ButtonСategoriesDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewСategories.SelectedRows.Count == 0)
            {
                return;
            }
            DialogResult result = MessageBox.Show(
                "Вы уверены, что хотите удалить объект?",
                "",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (result == DialogResult.No) {return;}
            int index = dataGridViewСategories.SelectedRows[0].Index;
            int id;
            bool converted = Int32.TryParse(dataGridViewСategories[0, index].Value.ToString(), out id);
            if (!converted)
                return;
            CategoriesDish categoriesDish = db.CategoriesDishes.Find(id);

            db.CategoriesDishes.Remove(categoriesDish);

            db.SaveChanges();
            MessageBox.Show("Объект удалён");
            this.dataGridViewСategories.DataSource = this.db.CategoriesDishes.Local.OrderBy(o => o.Name).ToList();
        }
    }
}
