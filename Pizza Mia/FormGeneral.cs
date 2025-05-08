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

        private void buttonCategoriesOfDishes_Click(object sender, EventArgs e)
        {

        }
    }
}
