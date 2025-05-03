using Microsoft.EntityFrameworkCore;
using AppContext = Pizza_Mia.Models.AppContext;

namespace Pizza_Mia
{
    public partial class FormDishes : Form
    {
        private AppContext db;
        public FormDishes()
        {
            InitializeComponent();
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this.db = new AppContext();
            this.db.Dishes.Load();
            this.dataGridViewDishes.DataSource = this.db.Dishes.Local.OrderBy(o=>o.Name).ToList();
            dataGridViewDishes.Columns["Id"].Visible = false;
            dataGridViewDishes.Columns["DishIgredients"].Visible = false;
            dataGridViewDishes.Columns["CategoriesDish"].Visible = false;

            dataGridViewDishes.Columns["Name"].HeaderText = "Наименование блюда";
            dataGridViewDishes.Columns["IdCategory"].HeaderText = "Категория блюда";
            dataGridViewDishes.Columns["Description"].HeaderText = "Описание блюда";
            dataGridViewDishes.Columns["Price"].HeaderText = "Цена блюда(р)";
            dataGridViewDishes.Columns["СookingTime"].HeaderText = "Время приготовления (мин)";
            dataGridViewDishes.Columns["Photo"].HeaderText = "Фотография блюда";
        }

        private void FormDishes_Load(object sender, EventArgs e)
        {

        }
    }
}
