using Microsoft.EntityFrameworkCore; // Подключаем пространство имен для работы с Entity Framework
using Pizza_Mia.Models; // Подключаем пространство имен для моделей

namespace Pizza_Mia
{
    public partial class FormMenu : Form // Определяем класс FormMenu, который наследует от Form
    {
        // Контекст для работы с базой данных
        private PizzaAppContext db;

        public FormMenu() // Конструктор класса FormMenu
        {
            InitializeComponent(); // Инициализируем компоненты формы
        }

        // Метод, который вызывается при загрузке формы
        protected override async void OnLoad(EventArgs e)
        {
            base.OnLoad(e); // Вызываем базовый метод загрузки формы
            db = new PizzaAppContext(); // Создаем новый экземпляр контекста базы данных
            await ShowDishesAsCardsAsync(); // Загружаем и отображаем блюда на форме
        }

        // Метод для отображения блюд в виде карточек
        private async Task ShowDishesAsCardsAsync()
        {
            flowLayoutPanelDishes.Controls.Clear(); // Очищаем контейнер с карточками

            // Загружаем список блюд из базы с загрузкой категорий, сортируем по имени
            var dishesList = await db.Dishes
                .Include(d => d.CategoriesDish) // Включаем навигационное свойство "Категория"
                .OrderBy(d => d.Name) // Сортируем по имени
                .ToListAsync(); // Получаем список блюд

            // Для каждого блюда создаём карточку и добавляем в FlowLayoutPanel
            foreach (var dish in dishesList)
                flowLayoutPanelDishes.Controls.Add(CreateDishCard(dish)); // Добавляем карточку блюда
        }

        // Создание "карточки" для отдельного блюда
        private Panel CreateDishCard(Dish dish)
        {
            // Создаем панель, которая будет служить карточкой блюда
            var panel = new Panel
            {
                Width = 250,
                Height = 150,
                Margin = new Padding(10), // Отступы вокруг карточки
                BackColor = Color.White,
                BorderStyle = BorderStyle.FixedSingle,
                Tag = dish.Id // Сохраняем ID блюда в Tag для идентификации
            };

            // Создаем Label с названием блюда
            var nameLabel = new Label
            {
                Text = dish.Name,
                Location = new Point(10, 10),
                Size = new Size(230, 25),
                Font = new Font("Segoe UI", 12, FontStyle.Bold),
                ForeColor = Color.Black,
                AutoEllipsis = true // Показывать многоточие, если текст не помещается
            };
            panel.Controls.Add(nameLabel); // Добавляем к панели

            // Label с категорией блюда
            var categoryLabel = new Label
            {
                Text = $"Категория: {dish.CategoriesDish?.Name ?? "не указана"}", // Имя категории, либо "не указана"
                Location = new Point(10, 40),
                Size = new Size(230, 20),
                Font = new Font("Segoe UI", 9, FontStyle.Italic),
                ForeColor = Color.DarkSlateGray
            };
            panel.Controls.Add(categoryLabel); // Добавляем к панели

            // Описание блюда, сокращаем если длинное
            string description = dish.Description ?? "";
            if (description.Length > 100)
                description = description.Substring(0, 97) + "..."; // Сокращаем описание

            var descLabel = new Label
            {
                Text = description,
                Location = new Point(10, 65),
                Size = new Size(230, 50),
                Font = new Font("Segoe UI", 9),
                ForeColor = Color.DimGray,
                AutoEllipsis = true
            };
            panel.Controls.Add(descLabel); // Добавляем к панели

            // Label с ценой блюда
            var priceLabel = new Label
            {
                Text = $"Цена: {dish.Price?.ToString("F2") ?? "—"} ₽", // Форматируем цену
                Location = new Point(10, 120),
                AutoSize = true,
                Font = new Font("Segoe UI", 10, FontStyle.Bold),
                ForeColor = Color.DarkGreen
            };
            panel.Controls.Add(priceLabel); // Добавляем к панели

            // Label с временем приготовления
            var timeLabel = new Label
            {
                Text = $"Время: {dish.СookingTime} мин", // Время приготовления
                Location = new Point(150, 120),
                AutoSize = true,
                Font = new Font("Segoe UI", 10, FontStyle.Bold),
                ForeColor = Color.DarkOrange
            };
            panel.Controls.Add(timeLabel); // Добавляем к панели

            return panel; // Возвращаем готовую карточку
        }
    }
}
