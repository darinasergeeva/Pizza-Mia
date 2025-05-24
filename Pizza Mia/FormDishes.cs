using Microsoft.EntityFrameworkCore;
using Pizza_Mia.Models;
using PizzaAppContext = Pizza_Mia.Models.PizzaAppContext;

namespace Pizza_Mia 
{
    public partial class FormDishes : Form
    {
        // Контекст для работы с базой данных
        private PizzaAppContext db;
        // Переменная для хранения выбранного ID блюда (null, если ничего не выбрано)
        private int? SelectedDishId = null;
        public FormDishes()
        {
            InitializeComponent();
        }

        // Метод, который вызывается при загрузке формы
        protected override async void OnLoad(EventArgs e)
        {
            base.OnLoad(e); // Вызываем базовый метод загрузки формы
            db = new PizzaAppContext(); // Создаем новый экземпляр контекста базы данных
            await ShowDishesAsCardsAsync(); //загружаем и отображаем блюда на форме
        }
        private async void ButtonAdd_Click(object sender, EventArgs e)
        {
            using var formAdd = new FormAdd();
            if (formAdd.ShowDialog(this) == DialogResult.OK)
            {
                try
                {
                    // Создаем новый объект блюдо, заполняем его данными с формы
                    var newDish = new Dish
                    {
                        Name = formAdd.DishName,
                        Description = formAdd.DishDescription,
                        Price = formAdd.DishPrice,
                        СookingTime = formAdd.CookingTime,
                        Photo = formAdd.PhotoPath,
                        IdCategory = formAdd.DishCategoryId
                    };

                    db.Dishes.Add(newDish);          // Добавляем блюдо в базу данных (в контекст)
                    await db.SaveChangesAsync();    // сохраняем изменения в базе данных

                    await ShowDishesAsCardsAsync(newDish.Id); // Обновляем отображение, выделяя добавленное блюдо

                    MessageBox.Show("Новое блюдо добавлено!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка: {ex.Message}");
                }
            }
        }
        private async void ButtonUpdate_Click(object sender, EventArgs e)
        {
            if (SelectedDishId == null)
            {
                MessageBox.Show("Пожалуйста, выберите блюдо для редактирования.");
                return;
            }

            // Загружаем блюдо из базы вместе с категорией, по выбранному ID
            var dishToEdit = await db.Dishes
                .Include(d => d.CategoriesDish)                       // Включаем навигационное свойство "Категория"
                .FirstOrDefaultAsync(d => d.Id == SelectedDishId.Value); // Ищем блюдо по ID

            if (dishToEdit == null)
            {
                MessageBox.Show("Блюдо не найдено.");
                return;
            }
            using var formAdd = new FormAdd(dishToEdit);
            if (formAdd.ShowDialog(this) == DialogResult.OK) // Если пользователь подтвердил изменения
            {
                try
                {
                    // Обновляем объект блюда с новыми данными из формы
                    dishToEdit.Name = formAdd.DishName;
                    dishToEdit.Description = formAdd.DishDescription;
                    dishToEdit.Price = formAdd.DishPrice;
                    dishToEdit.СookingTime = formAdd.CookingTime;
                    dishToEdit.Photo = formAdd.PhotoPath;
                    dishToEdit.IdCategory = formAdd.DishCategoryId;

                    await db.SaveChangesAsync();                // Сохраняем изменения в базе

                    await ShowDishesAsCardsAsync(dishToEdit.Id); // Обновляем отображение, выделяя отредактированное блюдо

                    MessageBox.Show("Блюдо обновлено!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при обновлении: {ex.Message}");
                }
            }
        }
        private async void ButtonDelete_Click(object sender, EventArgs e)
        {
            if (SelectedDishId == null)
            {
                MessageBox.Show("Пожалуйста, выберите блюдо для удаления.");
                return;
            }
            var confirm = MessageBox.Show(
                "Вы уверены, что хотите удалить выбранное блюдо?",
                "Подтверждение удаления",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (confirm == DialogResult.Yes)
            {
                try
                {
                    // Ищем блюдо по ID в базе
                    var dishToDelete = await db.Dishes.FindAsync(SelectedDishId.Value);
                    if (dishToDelete != null) // Если блюдо найдено
                    {
                        db.Dishes.Remove(dishToDelete);    // Удаляем блюдо из контекста базы
                        await db.SaveChangesAsync();        // Сохраняем изменения в базе
                        await ShowDishesAsCardsAsync();    // Обновляем отображение карточек
                        SelectedDishId = null;              // Сбрасываем выбор
                        MessageBox.Show("Блюдо успешно удалено.");
                    }
                    else
                    {
                        MessageBox.Show("Блюдо не найдено.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при удалении: {ex.Message}");
                }
            }
        }

        // Метод для отображения блюд в виде карточек
        private async Task ShowDishesAsCardsAsync(int? selectDishId = null)
        {
            flowLayoutPanelDishes.Controls.Clear();                       // Очищаем контейнер с карточками

            // Загружаем список блюд из базы с загрузкой категорий, сортируем по имени
            var dishesList = await db.Dishes
                .Include(d => d.CategoriesDish)
                .OrderBy(d => d.Name)
                .ToListAsync();

            // Для каждого блюда создаём карточку и добавляем в FlowLayoutPanel
            foreach (var dish in dishesList)
                flowLayoutPanelDishes.Controls.Add(CreateDishCard(dish));

            if (selectDishId.HasValue)
                SelectDishCard(selectDishId.Value); // Выделяем карточку, если указано ID
            else
                SelectedDishId = null;              // Иначе сбрасываем выбор
        }

        // Создание "карточки" для отдельного блюда
        private Panel CreateDishCard(Dish dish)
        {
            // Создаем панель, которая будет служить карточкой блюда
            var panel = new Panel
            {
                Width = 250,
                Height = 150,
                Margin = new Padding(10),         // Отступы вокруг карточки
                BackColor = Color.White,
                BorderStyle = BorderStyle.FixedSingle,
                Tag = dish.Id                    // Сохраняем ID блюда в Tag для идентификации
            };

            // Создаем Label с названием блюда
            var nameLabel = new Label
            {
                Text = dish.Name,
                Location = new Point(10, 10),
                Size = new Size(230, 25),
                Font = new Font("Segoe UI", 12, FontStyle.Bold),
                ForeColor = Color.Black,
                AutoEllipsis = true               // Показывать многоточие, если текст не помещается
            };
            panel.Controls.Add(nameLabel);          // Добавляем к панели

            // Label с категорией блюда
            var categoryLabel = new Label
            {
                Text = $"Категория: {dish.CategoriesDish?.Name ?? "не указана"}", // Имя категории, либо "не указана"
                Location = new Point(10, 40),
                Size = new Size(230, 20),
                Font = new Font("Segoe UI", 9, FontStyle.Italic),
                ForeColor = Color.DarkSlateGray
            };
            panel.Controls.Add(categoryLabel);

            // Описание блюда, сокращаем если длинное
            string description = dish.Description ?? "";
            if (description.Length > 100)
                description = description.Substring(0, 97) + "...";

            var descLabel = new Label
            {
                Text = description,
                Location = new Point(10, 65),
                Size = new Size(230, 50),
                Font = new Font("Segoe UI", 9),
                ForeColor = Color.DimGray,
                AutoEllipsis = true
            };
            panel.Controls.Add(descLabel);

            // Label с ценой блюда
            var priceLabel = new Label
            {
                Text = $"Цена: {dish.Price?.ToString("F2") ?? "—"} ₽",
                Location = new Point(10, 120),
                AutoSize = true,
                Font = new Font("Segoe UI", 10, FontStyle.Bold),
                ForeColor = Color.DarkGreen
            };
            panel.Controls.Add(priceLabel);

            // Label с временем приготовления
            var timeLabel = new Label
            {
                Text = $"Время: {dish.СookingTime} мин",
                Location = new Point(150, 120),
                AutoSize = true,
                Font = new Font("Segoe UI", 10, FontStyle.Bold),
                ForeColor = Color.DarkOrange
            };
            panel.Controls.Add(timeLabel);

            // Метод для добавления обработчика клика ко всем элементам карточки
            void AttachClick(Control control)
            {
                control.Click += (s, e) =>
                {
                    // При клике снимаем выделение с других карточек
                    foreach (Control ctrl in flowLayoutPanelDishes.Controls)
                        ctrl.BackColor = Color.White;

                    // Выделяем текущую карточку
                    panel.BackColor = Color.LightPink;

                    // Запоминаем выбранное блюдо
                    SelectedDishId = dish.Id;
                };
                // добавляем обработчик ко всем дочерним элементам контролла
                foreach (Control child in control.Controls)
                    AttachClick(child);
            }

            AttachClick(panel); // Вешаем обработчики событий клика

            return panel; // Возвращаем готовую карточку
        }

        // Метод для выделения карточки по ID
        private void SelectDishCard(int dishId)
        {
            // Снимаем выделение со всех карточек
            foreach (Control ctrl in flowLayoutPanelDishes.Controls)
                ctrl.BackColor = Color.White;

            // Ищем карточку с нужным ID
            var selectedPanel = flowLayoutPanelDishes.Controls
                .Cast<Control>()
                .FirstOrDefault(c => (int?)c.Tag == dishId);

            if (selectedPanel != null) // Если нашли
            {
                selectedPanel.BackColor = Color.LightPink; // Выделяем её
                SelectedDishId = dishId;                    // Устанавливаем ID выбранного блюда
                flowLayoutPanelDishes.ScrollControlIntoView(selectedPanel); // Прокручиваем к ней
            }
        }

        private void FormDishes_Load(object sender, EventArgs e)
        {

        }
    }
}
