using Pizza_Mia.Models;

namespace Pizza_Mia
{
    public partial class FormGeneral : Form
    {
        private User currentUser; // Добавляем переменную для текущего пользователя

        public FormGeneral(User user) // Изменяем конструктор, чтобы принимать пользователя
        {
            InitializeComponent();
            currentUser = user; // Инициализируем текущего пользователя
            ConfigureAccess(); // Настраиваем доступ в зависимости от роли пользователя
        }

        private void ConfigureAccess()
        {
            if (currentUser.Role == "Admin")
            {
                EnableAllControls();
            }
            else if (currentUser.Role == "Cashier")
            {
                PartiallyEnableControlsCashier();
            }
            else if (currentUser.Role == "Cook")
            {
                PartiallyEnableControlsCook();
            }
            else if (currentUser.Role == "Client")
            {
                PartiallyEnableControlsClient();
            }
        }

        private void EnableAllControls()
        {
            buttonDishes.Enabled = true;
            buttonCategoriesOfDishes.Enabled = true;
            buttonIngredients.Enabled = true;
            buttonOrders.Enabled = true;
            buttonUserManagement.Enabled = true;
        }

        private void PartiallyEnableControlsCashier()
        {
            buttonDishes.Enabled = true;
            buttonCategoriesOfDishes.Enabled = true;
            buttonIngredients.Enabled = false;
            buttonOrders.Enabled = true;
            buttonUserManagement.Enabled = false;
        }

        private void PartiallyEnableControlsCook()
        {
            buttonDishes.Enabled = true;
            buttonCategoriesOfDishes.Enabled = true;
            buttonIngredients.Enabled = true;
            buttonOrders.Enabled = true;
            buttonUserManagement.Enabled = false;
        }

        private void PartiallyEnableControlsClient()
        {
            buttonDishes.Enabled = true;
            buttonCategoriesOfDishes.Enabled = false;
            buttonIngredients.Enabled = false;
            buttonOrders.Enabled = true;
            buttonUserManagement.Enabled = false;
        }

        private void ButtonDishes_Click(object sender, EventArgs e)
        {
            FormDishes formDishes = new FormDishes(currentUser);
            formDishes.ShowDialog();
        }

        private void ButtonCategoriesOfDishes_Click(object sender, EventArgs e)
        {
            FormСategoriesOfDishes formCategoriesOfDishes = new FormСategoriesOfDishes(currentUser);
            formCategoriesOfDishes.ShowDialog();
        }

        private void ButtonIngredients_Click(object sender, EventArgs e)
        {
            FormIngredients formIngredients = new FormIngredients(currentUser);
            formIngredients.ShowDialog();
        }

        private void ButtonOrders_Click(object sender, EventArgs e)
        {
            FormOrders formOrders = new FormOrders(currentUser);
            formOrders.ShowDialog();
        }

        private void ButtonUserManagement_Click(object sender, EventArgs e)
        {
            FormUserManagement formUserManagement = new FormUserManagement();
            formUserManagement.ShowDialog();
        }
    }
}
