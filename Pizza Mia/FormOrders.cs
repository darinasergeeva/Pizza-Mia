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
            await db.Orders.Include(o => o.Customer).LoadAsync(); // Загружаем заказы с клиентами

            // Создаем список анонимных объектов для отображения в DataGridView
            var ordersList = db.Orders.Local
                .Select(o => new
                {
                    o.Id,
                    OrderDate = o.OrderDate,
                    CustomerName = o.Customer != null ? o.Customer.Name : "Не указано", // Получаем имя клиента
                    o.TotalAmount,
                    o.Status
                })
                .OrderBy(o => o.Status) // Сортируем по статусу
                .ToList();

            dataGridViewOrders.DataSource = ordersList; // Устанавливаем источник данных

            // Скрываем ненужные колонки
            dataGridViewOrders.Columns["Id"].Visible = false; // Скрываем ID заказа

            // Переименовываем заголовки столбцов
            dataGridViewOrders.Columns["OrderDate"].HeaderText = "Дата заказа";
            dataGridViewOrders.Columns["CustomerName"].HeaderText = "Заказчик"; 
            dataGridViewOrders.Columns["TotalAmount"].HeaderText = "Стоимость";
            dataGridViewOrders.Columns["Status"].HeaderText = "Статус заказа";
        }
    }
}
