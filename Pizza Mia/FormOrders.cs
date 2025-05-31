using Microsoft.EntityFrameworkCore;
using Pizza_Mia.Models;

namespace Pizza_Mia
{
    public partial class FormOrders : Form
    {
        private PizzaAppContext db; // Объявляем переменную для контекста базы данных
        private User currentUser; // Добавляем переменную для текущего пользователя
        private int? SelectedOrderId = null; // ID выбранного заказа

        public FormOrders(User user)
        {
            InitializeComponent();
            currentUser = user; // Инициализируем текущего пользователя
        }

        protected override async void OnLoad(EventArgs e)
        {
            base.OnLoad(e); // Вызываем базовый метод загрузки формы
            db = new PizzaAppContext(); // Создаем новый экземпляр контекста базы данных
            await ShowOrdersAsCardsAsync(); // Загружаем и отображаем заказы в виде карточек
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
                // Полный доступ
                EnableAllControls();
            }
            else if (currentUser.Role == "Cook")
            {
                // Только просмотр
                DisableAllControlsExceptView();
            }
            else if (currentUser.Role == "Client")
            {
                // Только просмотр добавление 
                PartiallyEnableControls();
            }
        }

        private void EnableAllControls()
        {
            buttonAdd.Visible = true;
            buttonUpdate.Visible = true;
            buttonDelete.Visible = true;
        }

        private void DisableAllControlsExceptView()
        {
            buttonAdd.Visible = false;
            buttonUpdate.Visible = false;
            buttonDelete.Visible = false;
        }
        private void PartiallyEnableControls()
        {
            buttonUpdate.Visible = false;
            buttonDelete.Visible = false;
        }


        private async Task ShowOrdersAsCardsAsync(int? selectedOrderId = null)
        {
            flowLayoutPanelOrders.Controls.Clear(); // Очищаем текущие карточки

            var ordersList = await db.Orders
                .Include(o => o.Customer) // Загружаем связанные данные о клиенте
                .OrderByDescending(o => o.OrderDate) // Сортируем заказы по дате
                .ToListAsync(); // Получаем список заказов

            foreach (var order in ordersList)
            {
                var card = CreateOrderCard(order); // Создаем карточку для каждого заказа
                card.Tag = order.Id; // Сохраняем ID заказа в Tag
                flowLayoutPanelOrders.Controls.Add(card); // Добавляем карточку на форму
            }

            
            if (selectedOrderId.HasValue)
            {
                var selectedPanel = flowLayoutPanelOrders.Controls
                    .OfType<Panel>()
                    .FirstOrDefault(p => (int)p.Tag == selectedOrderId.Value);
                if (selectedPanel != null)
                {
                    selectedPanel.BackColor = Color.LightBlue; // Выделяем цветом
                    flowLayoutPanelOrders.ScrollControlIntoView(selectedPanel); // Прокручиваем к выбранной карточке
                }
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
                Text = order.OrderDate.ToString("dd MMM yyyy") ?? "Дата не указана",
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

            // Добавляем обработчик события клика
            panel.Click += (sender, e) =>
            {
                // Снимаем выделение с предыдущей карточки
                if (SelectedOrderId.HasValue)
                {
                    var previousPanel = flowLayoutPanelOrders.Controls
                        .OfType<Panel>()
                        .FirstOrDefault(p => (int)p.Tag == SelectedOrderId.Value);
                    if (previousPanel != null)
                    {
                        previousPanel.BackColor = Color.White; // Возвращаем цвет
                    }
                }

                // Выделяем текущую карточку
                SelectedOrderId = order.Id;
                panel.BackColor = Color.LightBlue; // Выделяем цветом
            };

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

        private async void ButtonAdd_Click(object sender, EventArgs e)
        {
            using var formAdd = new FormOrdersAdd(); // Открываем форму добавления заказа
            if (formAdd.ShowDialog(this) == DialogResult.OK)
            {
                try
                {
                    // Создаем новый объект заказа, заполняем его данными с формы
                    var newOrder = new Order
                    {
                        IdCustomer = (await db.Customers.FirstOrDefaultAsync(c => c.Name == formAdd.SelectedCustomerName))?.Id ?? 0, // Присваиваем ID клиента
                        OrderDate = formAdd.OrderDate, // Используем OrderDate как DateOnly
                        TotalAmount = formAdd.TotalAmount, // Получаем сумму из textBox
                        Status = formAdd.Status // Получаем статус из textBox
                    };
                    db.Orders.Add(newOrder); // Добавляем заказ в базу данных
                    await db.SaveChangesAsync(); // Сохраняем изменения в базе данных
                    await ShowOrdersAsCardsAsync(); // Обновляем отображение заказов
                    MessageBox.Show("Новый заказ добавлен!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при добавлении заказа: {ex.Message}");
                }
            }
        }


        private async void ButtonUpdate_Click(object sender, EventArgs e)
        {
            if (SelectedOrderId == null)
            {
                MessageBox.Show("Пожалуйста, выберите заказ для редактирования.");
                return;
            }

            try
            {
                // Загружаем заказ из базы, включая связанные данные (например, клиента)
                var orderToEdit = await db.Orders
                    .Include(o => o.Customer)
                    .FirstOrDefaultAsync(o => o.Id == SelectedOrderId.Value);

                if (orderToEdit == null)
                {
                    MessageBox.Show("Заказ не найден.");
                    return;
                }

                // Открываем форму редактирования, передаём заказ
                using var formEdit = new FormOrdersAdd(orderToEdit);

                if (formEdit.ShowDialog(this) == DialogResult.OK)
                {
                    // Обновляем свойства заказа из данных формы
                    orderToEdit.IdCustomer = (await db.Customers.FirstOrDefaultAsync(c => c.Name == formEdit.SelectedCustomerName))?.Id ?? 0;
                    orderToEdit.OrderDate = formEdit.OrderDate;
                    orderToEdit.TotalAmount = formEdit.TotalAmount;
                    orderToEdit.Status = formEdit.Status;

                    await db.SaveChangesAsync(); // Сохраняем изменения

                    MessageBox.Show("Заказ успешно обновлен!");

                    // Обновляем отображение заказов
                    await ShowOrdersAsCardsAsync(); // Обновляем отображение заказов
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при редактировании заказа: {ex.Message}");
            }
        }



    }
}


