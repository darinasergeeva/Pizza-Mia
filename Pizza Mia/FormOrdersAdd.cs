using System;
using System.Windows.Forms;
using Pizza_Mia.Models;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Pizza_Mia
{
    public partial class FormOrdersAdd : Form
    {
        public Order OrderData { get; private set; }

        // Свойства для доступа к данным формы
        public string SelectedCustomerName => comboBoxNameCustomer.SelectedItem?.ToString();
        public DateOnly OrderDate => DateOnly.FromDateTime(dateTimePickerOrderDate.Value);
        public decimal TotalAmount => decimal.TryParse(textBoxTotalAmount.Text, out var amount) ? amount : 0;
        public string Status => textBoxStatus.Text;

        public FormOrdersAdd()
        {
            InitializeComponent();
            LoadCustomers(); // Загружаем список клиентов в comboBoxNameCustomer при создании формы
        }

        public FormOrdersAdd(Order order) : this() // Конструктор для редактирования существующего заказа
        {
            OrderData = order;

            // Заполняем контролы значениями из заказа
            comboBoxNameCustomer.SelectedItem = order.Customer?.Name ?? null;
            dateTimePickerOrderDate.Value = new DateTime(order.OrderDate.Year, order.OrderDate.Month, order.OrderDate.Day); // Преобразуем DateOnly в DateTime
            textBoxTotalAmount.Text = order.TotalAmount.ToString("F2");
            textBoxStatus.Text = order.Status;
        }

        private void LoadCustomers()
        {
            using (var db = new PizzaAppContext())
            {
                var customers = db.Customers 
                    .Select(c => c.Name) // Берём имя клиента
                    .ToList();

                comboBoxNameCustomer.Items.Clear();
                comboBoxNameCustomer.Items.AddRange(customers.ToArray());

                if (comboBoxNameCustomer.Items.Count > 0)
                    comboBoxNameCustomer.SelectedIndex = 0;
            }
        }

        private async void ButtonSave_Click(object sender, EventArgs e) 
        {
            if (comboBoxNameCustomer.SelectedItem == null)
            {
                MessageBox.Show("Выберите клиента.");
                return;
            }

            if (!decimal.TryParse(textBoxTotalAmount.Text, out decimal totalAmount))
            {
                MessageBox.Show("Введите корректную сумму заказа.");
                return;
            }
            if (OrderData == null)
                OrderData = new Order();

            using (var db = new PizzaAppContext()) // Создаем экземпляр контекста базы данных
            {
                // Заполняем данные из контролов
                OrderData.IdCustomer = (await db.Customers.FirstOrDefaultAsync(c => c.Name == comboBoxNameCustomer.SelectedItem.ToString()))?.Id ?? 0; // Получаем ID клиента
                OrderData.OrderDate = OrderDate; // Присваиваем DateOnly
                OrderData.TotalAmount = totalAmount;
                OrderData.Status = Status;

                if (OrderData.Id == 0) // Если это новый заказ
                {
                    db.Orders.Add(OrderData);
                    Console.WriteLine("Добавляем новый заказ.");
                }
                else // Если это редактирование существующего заказа
                {
                    db.Orders.Update(OrderData); // Обновляем объект
                    Console.WriteLine("Обновляем существующий заказ.");
                }

                try
                {
                    await db.SaveChangesAsync(); // Сохраняем изменения в базе данных
                    MessageBox.Show("Заказ успешно добавлен или обновлен!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при сохранении заказа: {ex.Message}");
                }

                DialogResult = DialogResult.OK;
                Close();
            }
        }

    }
}
