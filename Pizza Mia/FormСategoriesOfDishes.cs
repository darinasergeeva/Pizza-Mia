using Microsoft.EntityFrameworkCore;
using AppContext = Pizza_Mia.Models.AppContext;
namespace Pizza_Mia
{
   
    public partial class FormСategoriesOfDishes : Form
    { 
        private AppContext db;
        public FormСategoriesOfDishes()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this.db = new AppContext();
            this.db.CategoriesDishes.Load();
            this.dataGridViewСategories.DataSource = this.db.CategoriesDishes.Local.OrderBy(o=>o.Name).ToList();
            dataGridViewСategories.Columns["Id"].Visible = false;
            dataGridViewСategories.Columns["Dishes"].Visible = false;
            
            dataGridViewСategories.Columns["Name"].HeaderText = "Категория блюда";
        }
    }
}
