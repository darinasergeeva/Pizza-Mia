using Pizza_Mia.Models; 

namespace Pizza_Mia 
{
    public partial class FormLogin : Form 
    {
        public FormLogin() 
        {
            InitializeComponent(); 
        }

        private void ButtonLogin_Click(object sender, EventArgs e) 
        {
            using (var db = new PizzaAppContext()) // Создаем новый экземпляр контекста базы данных
            {
                // Ищем пользователя в базе данных по имени пользователя, введенному в текстовое поле
                var user = db.users.FirstOrDefault(u => u.Username == txtUsername.Text);

                // Проверяем, найден ли пользователь и совпадает ли введенный пароль с сохраненным паролем
                if (user != null && user.Password == txtPassword.Text)
                {
                    MessageBox.Show($"Добро пожаловать, {user.Username}!"); 
                    Program.CurrentUser = user; // Сохраняем текущего пользователя в статическом свойстве Program.CurrentUser 
                    new FormGeneral().Show(); 
                }
                else
                {
                    MessageBox.Show("Неверный логин или пароль."); 
                }
            }
        }
    }
}
