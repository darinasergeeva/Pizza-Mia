using Microsoft.EntityFrameworkCore;
using Pizza_Mia.Models;
using AppContext = Pizza_Mia.Models.AppContext;

namespace Pizza_Mia
{
    public partial class FormDishes : Form
    {
        private AppContext db;
        public FormDishes()
        {
            InitializeComponent();
        }
        protected override async void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            db = new AppContext(); // Инициализируем контекст базы данных

            await UpdateDishesListAsync(); // Загружаем список блюд асинхронно

            // Настраиваем цвет выделения строк в DataGridView
            dataGridViewDishes.DefaultCellStyle.SelectionBackColor = Color.Pink;
            dataGridViewDishes.DefaultCellStyle.SelectionForeColor = Color.White;
        }

        private void FormDishes_Load(object sender, EventArgs e)
        {

        }

        private async void ButtonAdd_Click(object sender, EventArgs e)
        {
            // Создаем экземпляр формы для добавления блюда
            using (FormAdd formAdd = new FormAdd())
            {
                if (formAdd.ShowDialog(this) == DialogResult.OK)
                {
                    try
                    {
                        // Создаем новый объект блюда и заполняем его данными из формы
                        Dish newDish = new Dish
                        {
                            Name = formAdd.DishName,
                            Description = formAdd.DishDescription,
                            Price = formAdd.DishPrice,
                            СookingTime = formAdd.CookingTime,
                            Photo = formAdd.PhotoPath,
                            IdCategory = formAdd.DishCategoryId
                        };

                        db.Dishes.Add(newDish); // Добавляем новое блюдо в контекст
                        await db.SaveChangesAsync(); // Сохраняем изменения в базе данных

                        await UpdateDishesListAsync(); // Обновляем список блюд

                        MessageBox.Show("Новое блюдо добавлено!"); 
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Ошибка: {ex.Message}");
                    }
                }
            }
        }
        private async Task UpdateDishesListAsync()
        {
            try
            {
                // Загружаем блюда из базы данных с категориями и проецируем в анонимный тип
                var dishesList = await db.Dishes
                    .Include(d => d.CategoriesDish)
                    .Select(d => new
                    {
                        d.Id,
                        d.Name,
                        CategoryName = d.CategoriesDish != null ? d.CategoriesDish.Name : "",
                        d.Description,
                        d.Price,
                        d.СookingTime,
                        d.Photo
                    })
                    .OrderBy(d => d.Name) // Сортируем по имени блюда
                    .ToListAsync(); // Преобразуем в список асинхронно

                dataGridViewDishes.DataSource = dishesList; // Устанавливаем источник данных для DataGridView

                dataGridViewDishes.Columns["Id"].Visible = false;
                dataGridViewDishes.Columns["Name"].HeaderText = "Наименование блюда";
                dataGridViewDishes.Columns["CategoryName"].HeaderText = "Категория блюда";
                dataGridViewDishes.Columns["Description"].HeaderText = "Описание блюда";
                dataGridViewDishes.Columns["Price"].HeaderText = "Цена блюда(р)";
                dataGridViewDishes.Columns["СookingTime"].HeaderText = "Время приготовления (мин)";
                dataGridViewDishes.Columns["Photo"].HeaderText = "Фотография блюда";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при обновлении списка блюд: {ex.Message}");
            }
        }

        private async void ButtonUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridViewDishes.SelectedRows.Count > 0) // Проверяем, выбрана ли строка
            {
                int selectedDishId = (int)dataGridViewDishes.SelectedRows[0].Cells["Id"].Value; // Получаем Id выбранного блюда

                var dishToEdit = await db.Dishes // Загружаем блюдо из базы с подгрузкой категории
                    .Include(d => d.CategoriesDish)
                    .FirstOrDefaultAsync(d => d.Id == selectedDishId);

                if (dishToEdit != null) // Проверяем, что блюдо найдено
                {
                    {
                        using (FormAdd formAdd = new FormAdd(dishToEdit))  // Открываем форму добавления/редактирования, передавая выбранное блюдо
                        {
                            if (formAdd.ShowDialog(this) == DialogResult.OK)
                            {
                                try
                                {
                                    // Обновляем свойства блюда
                                    dishToEdit.Name = formAdd.DishName;
                                    dishToEdit.Description = formAdd.DishDescription;
                                    dishToEdit.Price = formAdd.DishPrice;
                                    dishToEdit.СookingTime = formAdd.CookingTime;
                                    dishToEdit.Photo = formAdd.PhotoPath;
                                    dishToEdit.IdCategory = formAdd.DishCategoryId;

                                    await db.SaveChangesAsync(); // Сохраняем изменения в базе данных
                                    await UpdateDishesListAsync(); // Обновляем список блюд

                                    MessageBox.Show("Блюдо обновлено!");
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show($"Ошибка при обновлении блюда: {ex.Message}");
                                }
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Пожалуйста, выберите блюдо для редактирования.");
                }
            }
        }

        private async void ButtonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewDishes.SelectedRows.Count == 0)
            {
                MessageBox.Show("Пожалуйста, выберите блюдо для удаления.");
                return;
            }

            // Получаем Id выбранного блюда
            int dishId = (int)dataGridViewDishes.SelectedRows[0].Cells["Id"].Value;

            // Подтверждение удаления
            var confirmResult = MessageBox.Show($"Вы уверены, что хотите удалить выбранное блюдо?",
                                                "Подтверждение удаления",
                                                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirmResult == DialogResult.Yes)
            {
                try
                {
                    var dishToDelete = await db.Dishes.FindAsync(dishId); // Находим блюдо по Id
                    if (dishToDelete != null) 
                    {
                        db.Dishes.Remove(dishToDelete); // Удаляем блюдо из контекста
                        await db.SaveChangesAsync(); // Сохраняем изменения в базе данных

                        await UpdateDishesListAsync(); // Обновляем список блюд

                        MessageBox.Show("Блюдо успешно удалено.");
                    }
                    else
                    {
                        MessageBox.Show("Ошибка: блюдо не найдено.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при удалении блюда: {ex.Message}");
                }
            }
        }
    }
}
