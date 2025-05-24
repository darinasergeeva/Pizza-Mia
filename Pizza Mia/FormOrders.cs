using Microsoft.EntityFrameworkCore;
using Pizza_Mia.Models;
using System.Data;

namespace Pizza_Mia
{
    public partial class FormOrders : Form
    {
        private PizzaAppContext db;
        public FormOrders()
        {
            InitializeComponent();
        }
        protected override async void OnLoad(EventArgs e)
        {
            base.OnLoad(e); // Вызываем базовый метод загрузки формы
            db = new PizzaAppContext(); // Создаем новый экземпляр контекста базы данных
            db.Orders.Load();
            dataGridViewOrders.DataSource = db.Orders.Local.OrderBy(o=>o.Status).ToList();

            dataGridViewOrders.Columns["id"].Visible = false;
            dataGridViewOrders.Columns["Customer"].Visible = false;

            dataGridViewOrders.Columns["OrderDate"].HeaderText = "Дата заказа";
            dataGridViewOrders.Columns["IdCustomer"].HeaderText = "Заказчик";
            dataGridViewOrders.Columns["TotalAmount"].HeaderText = "Стоимость";
            dataGridViewOrders.Columns["Status"].HeaderText = "Статус заказа";


        }
    }
}
