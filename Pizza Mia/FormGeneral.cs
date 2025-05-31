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
            buttonDishes.Visible = true;
            buttonCategoriesOfDishes.Visible = true;
            buttonIngredients.Visible = true;
            buttonOrders.Visible = true;
            buttonUserManagement.Visible = true;
        }

        private void PartiallyEnableControlsCashier()
        {
            buttonDishes.Visible = true;
            buttonCategoriesOfDishes.Visible = true;
            buttonIngredients.Visible = false;
            buttonOrders.Visible = true;
            buttonUserManagement.Visible = false;
        }

        private void PartiallyEnableControlsCook()
        {
            buttonDishes.Visible = true;
            buttonCategoriesOfDishes.Visible = true;
            buttonIngredients.Visible = true;
            buttonOrders.Visible = true;
            buttonUserManagement.Visible = false;
        }

        private void PartiallyEnableControlsClient()
        {
            buttonDishes.Visible = true;
            buttonCategoriesOfDishes.Visible = false;
            buttonIngredients.Visible = false;
            buttonOrders.Visible = true;
            buttonUserManagement.Visible = false;
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
