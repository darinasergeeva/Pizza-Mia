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
            db = new AppContext();

            await UpdateDishesListAsync();

            dataGridViewDishes.DefaultCellStyle.SelectionBackColor = Color.Pink;
            dataGridViewDishes.DefaultCellStyle.SelectionForeColor = Color.White;
        }

        private void FormDishes_Load(object sender, EventArgs e)
        {

        }

        private async void ButtonAdd_Click(object sender, EventArgs e)
        {
            using (FormAdd formAdd = new FormAdd())
            {
                if (formAdd.ShowDialog(this) == DialogResult.OK)
                {
                    try
                    {
                        Dish newDish = new Dish
                        {
                            Name = formAdd.DishName,
                            Description = formAdd.DishDescription,
                            Price = formAdd.DishPrice,
                            СookingTime = formAdd.CookingTime,
                            Photo = formAdd.PhotoPath,
                            IdCategory = formAdd.DishCategoryId
                        };

                        db.Dishes.Add(newDish);
                        await db.SaveChangesAsync();

                        await UpdateDishesListAsync();

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
                    .OrderBy(d => d.Name)
                    .ToListAsync();

                dataGridViewDishes.DataSource = dishesList;

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
            if (dataGridViewDishes.SelectedRows.Count > 0)
            {
                int selectedDishId = (int)dataGridViewDishes.SelectedRows[0].Cells["Id"].Value;

                var dishToEdit = await db.Dishes
                    .Include(d => d.CategoriesDish)
                    .FirstOrDefaultAsync(d => d.Id == selectedDishId);

                if (dishToEdit != null)
                {
                    using (FormAdd formAdd = new FormAdd(dishToEdit)) 
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

                                await db.SaveChangesAsync();
                                await UpdateDishesListAsync(); 

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

        private void ButtonDelete_Click(object sender, EventArgs e)
        {

        }
    }
}
