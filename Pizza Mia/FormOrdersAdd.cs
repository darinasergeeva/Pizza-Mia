using Microsoft.EntityFrameworkCore;
using Pizza_Mia.Models;

namespace Pizza_Mia
{
    public partial class FormOrdersAdd : Form
    {
        public Order NewOrder { get; private set; }

        public FormOrdersAdd()
        {
            InitializeComponent();
            Load += FormOrdersAdd_Load;
        }

        private async void FormOrdersAdd_Load(object sender, EventArgs e)
        {
            using var db = new PizzaAppContext();
            var customers = await db.Customers.ToListAsync();
            comboBoxNameCustomer.DataSource = customers;
            comboBoxNameCustomer.DisplayMember = "Name";
            comboBoxNameCustomer.ValueMember = "Id";
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs()) return;
            if (comboBoxNameCustomer.SelectedValue == null ||
    !int.TryParse(comboBoxNameCustomer.SelectedValue.ToString(), out int customerId))
            {
                MessageBox.Show("Пожалуйста, выберите клиента из списка.");
                return;
            }
            NewOrder = new Order
            {
                OrderDate = DateOnly.FromDateTime(dateTimePickerOrderDate.Value),
                IdCustomer = customerId,
                TotalAmount = decimal.Parse(textBoxTotalAmount.Text),
                Status = textBoxStatus.Text.Trim()
            };

            DialogResult = DialogResult.OK;
            Close();
        }

        private bool ValidateInputs()
        {
            if (comboBoxNameCustomer.SelectedValue == null)
            {
                MessageBox.Show("Выберите клиента.");
                return false;
            }

            if (!decimal.TryParse(textBoxTotalAmount.Text, out var totalAmount) || totalAmount <= 0)
            {
                MessageBox.Show("Введите корректную сумму.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(textBoxStatus.Text))
            {
                MessageBox.Show("Введите статус заказа.");
                return false;
            }

            return true;
        }
    }
}
