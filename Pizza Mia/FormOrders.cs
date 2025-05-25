using Microsoft.EntityFrameworkCore; 
using Pizza_Mia.Models;

namespace Pizza_Mia 
{
    public partial class FormOrders : Form
    {
        private PizzaAppContext db; // Объявляем переменную для контекста базы данных

        public FormOrders()
        {
            InitializeComponent();
        }

        protected override async void OnLoad(EventArgs e)
        {
            base.OnLoad(e); // Вызываем базовый метод загрузки формы
            db = new PizzaAppContext(); // Создаем новый экземпляр контекста базы данных
            await ShowOrdersAsCardsAsync(); // Загружаем и отображаем заказы в виде карточек
        }

        private async Task ShowOrdersAsCardsAsync()
        {
            flowLayoutPanelOrders.Controls.Clear(); // Очищаем старые карточки из контейнера

            // Загружаем список заказов из базы данных, включая информацию о клиентах, и сортируем по дате заказа
            var ordersList = await db.Orders
                .Include(o => o.Customer) // Включаем связанные данные о клиенте
                .OrderByDescending(o => o.OrderDate) // Сортируем заказы по дате в порядке убывания
                .ToListAsync(); // Получаем список заказов

            // Для каждого заказа создаем карточку и добавляем ее в контейнер
            foreach (var order in ordersList)
            {
                var card = CreateOrderCard(order); // Создаем карточку для текущего заказа
                flowLayoutPanelOrders.Controls.Add(card); // Добавляем карточку в контейнер
            }
        }

        private Panel CreateOrderCard(Order order) // Метод для создания карточки заказа
        {
            var panel = new Panel // Создаем новую панель для карточки
            {
                Width = 350,
                Height = 120,
                Margin = new Padding(10),
                BackColor = Color.White,
                BorderStyle = BorderStyle.FixedSingle,
            };

            // Создаем Label для отображения даты заказа
            var orderDateLabel = new Label
            {
                Text = order.OrderDate?.ToString("dd MMM yyyy") ?? "Дата не указана",
                Font = new Font("Segoe UI", 12, FontStyle.Bold),
                Location = new Point(10, 10),
                AutoSize = true
            };
            panel.Controls.Add(orderDateLabel); // Добавляем Label на панель

            // Создаем Label для отображения имени клиента
            var customerNameLabel = new Label
            {
                Text = $"Клиент: {order.Customer?.Name ?? "Неизвестен"}",
                Font = new Font("Segoe UI", 10, FontStyle.Underline),
                Location = new Point(10, 40),
                AutoSize = true
            };
            panel.Controls.Add(customerNameLabel); // Добавляем Label на панель

            // Создаем Label для отображения общей стоимости заказа
            var totalAmountLabel = new Label
            {
                Text = $"Итого: {order.TotalAmount:C}",
                Font = new Font("Segoe UI", 10, FontStyle.Bold),
                ForeColor = Color.DarkGreen,
                Location = new Point(10, 70),
                AutoSize = true
            };
            panel.Controls.Add(totalAmountLabel);

            // Создаем Label для отображения статуса заказа
            var statusLabel = new Label
            {
                Text = $"Статус: {order.Status}",
                Font = new Font("Segoe UI", 10, FontStyle.Italic),
                Location = new Point(160, 70),
                AutoSize = true, // Автоматически подстраиваем размер по содержимому
                ForeColor = GetStatusColor(order.Status)
            };
            panel.Controls.Add(statusLabel); // Добавляем Label на панель

            return panel;
        }

        private Color GetStatusColor(string status) // Метод для получения цвета в зависимости от статуса заказа
        {
            return status?.ToLower() switch // Приводим статус к нижнему регистру и выбираем цвет
            {
                "готов" => Color.Green,
                "готовится" => Color.Orange,
                "отменен" => Color.Red,
                _ => Color.Black,
            };
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {

        }
    }
}
