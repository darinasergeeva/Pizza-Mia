using Pizza_Mia.Models;

namespace Pizza_Mia
{
    public partial class FormRegister : Form
    {
        public FormRegister()
        {
            InitializeComponent();
        }

        private void ButtonRegister_Click(object sender, EventArgs e)
        {
            using (var db = new PizzaAppContext()) // Создаем новый экземпляр контекста базы данных
            {
                // Проверяем, занято ли имя пользователя
                if (db.users.Any(u => u.Username == txtUsername.Text)) // Проверяем, существует ли пользователь с таким именем
                {
                    MessageBox.Show("Имя пользователя уже занято.");
                    return;
                }

                // Создаем нового пользователя
                var user = new User // Создаем новый объект User
                {
                    Username = txtUsername.Text,
                    Email = txtEmail.Text,
                    Role = "Client", // Устанавливаем роль по умолчанию как "Клиент"
                    Password = txtPassword.Text
                };

                // Добавляем пользователя в базу данных
                db.users.Add(user); // Добавляем нового пользователя в коллекцию пользователей
                db.SaveChanges(); // Сохраняем изменения в базе данных

                MessageBox.Show("Регистрация успешна!");

                // Передаем нового пользователя в FormGeneral
                FormGeneral formGeneral = new FormGeneral(user);
                formGeneral.ShowDialog(); // Открываем главную форму как модальную
                this.Close(); // Закрываем форму регистрации после закрытия главной формы
            }
        }

        private void LinkLabelLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormLogin loginForm = new FormLogin();
            loginForm.ShowDialog();
        }
    }
}
