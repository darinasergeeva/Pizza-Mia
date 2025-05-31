using Pizza_Mia.Models; 

namespace Pizza_Mia
{
    public partial class FormUserManagement : Form 
    {
        private PizzaAppContext db; // Объявляем переменную для контекста базы данных

    public FormUserManagement() 
    {
        InitializeComponent(); 
        db = new PizzaAppContext(); // Создаем экземпляр контекста базы данных
        LoadUsers(); // Загружаем пользователей в таблицу
    }

    private void LoadUsers() // Метод для загрузки пользователей
    {
        var usersList = db.users.ToList(); // Получаем список пользователей из базы данных
        dataGridViewUsers.DataSource = usersList; // Устанавливаем источник данных для DataGridView

        comboBoxRoles.Items.Clear(); // Очищаем элементы ComboBox для ролей
        comboBoxRoles.Items.AddRange(new string[] { "Client", "Cashier", "Cook", "Admin" }); // Добавляем роли в ComboBox

        dataGridViewUsers.Columns["Id"].Visible = false; 
        dataGridViewUsers.Columns["Password"].Visible = false;

        dataGridViewUsers.Columns["Username"].HeaderText = "Логин"; 
        dataGridViewUsers.Columns["Email"].HeaderText = "Email";
        dataGridViewUsers.Columns["Role"].HeaderText = "Роль";
    }

    private void DataGridViewUsers_SelectionChanged(object sender, EventArgs e) 
    {
        if (dataGridViewUsers.SelectedRows.Count > 0) // Проверяем, есть ли выбранные строки
        {
            var selectedUser = (User)dataGridViewUsers.SelectedRows[0].DataBoundItem; // Получаем выбранного пользователя
            comboBoxRoles.SelectedItem = selectedUser.Role; // Устанавливаем выбранную роль в ComboBox
        }
    }

    private void ButtonChangeRole_Click_1(object sender, EventArgs e) 
    {
        if (dataGridViewUsers.SelectedRows.Count == 0) 
        {
            MessageBox.Show("Выберите пользователя."); 
            return; 
        }

        if (comboBoxRoles.SelectedItem == null)
        {
            MessageBox.Show("Выберите роль для назначения."); 
            return; 
        }

        var selectedUser = (User)dataGridViewUsers.SelectedRows[0].DataBoundItem; // Получаем выбранного пользователя
        string newRole = comboBoxRoles.SelectedItem.ToString(); // Получаем новую роль из ComboBox

        if (selectedUser.Role == newRole) // Проверяем, совпадает ли новая роль с текущей
        {
            MessageBox.Show("Роль совпадает с текущей.");
            return; 
        }

        try
        {
            var userInDb = db.users.Find(selectedUser.Id); // Ищем пользователя в базе данных по Id
            if (userInDb != null) // Проверяем, найден ли пользователь
            {
                userInDb.Role = newRole; // Изменяем роль пользователя
                db.SaveChanges(); // Сохраняем изменения в базе данных

                MessageBox.Show($"Роль пользователя '{userInDb.Username}' изменена на '{newRole}'."); 
                LoadUsers(); // Обновляем список пользователей
            }
            else
            {
                MessageBox.Show("Пользователь не найден в базе."); 
            }
        }
        catch (Exception ex) 
        {
            MessageBox.Show("Ошибка при изменении роли: " + ex.Message); 
            Console.WriteLine(ex); 
        }
    }

    private void ButtonRefresh_Click_1(object sender, EventArgs e) 
    {
        LoadUsers(); // Загружаем пользователей заново
    }
}
}
