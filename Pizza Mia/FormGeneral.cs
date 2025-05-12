namespace Pizza_Mia
{
    public partial class FormGeneral : Form
    {
        public FormGeneral()
        {
            InitializeComponent();
        }

        private void ButtonDishes_Click(object sender, EventArgs e)
        {
            FormDishes formdishes = new FormDishes();
            formdishes.ShowDialog();
        }

        private void ButtonCategoriesOfDishes_Click(object sender, EventArgs e)
        {
            FormСategoriesOfDishes FormСategoriesOfDishes = new FormСategoriesOfDishes();
            FormСategoriesOfDishes.ShowDialog();
        }

        private void ButtonIngredients_Click(object sender, EventArgs e)
        {
            FormIngredients formIngredients = new FormIngredients();
            formIngredients.ShowDialog();
        }
    }
}
