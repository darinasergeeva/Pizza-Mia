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
    }
}
