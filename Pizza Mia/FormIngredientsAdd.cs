using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizza_Mia
{
    public partial class FormIngredientsAdd : Form
    {
        public FormIngredientsAdd()
        {
            InitializeComponent();
        }

        private void TextBoxNameOfTheIngredient_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxNameOfTheIngredient.Text))
            {
                errorProvider.SetError(textBoxNameOfTheIngredient, "Поле не может быть пустым ");
                buttonSave.Enabled = false;
            }
            else
            {
                errorProvider.Clear();
                buttonSave.Enabled = true;
            }
        }

        private void textBoxNameOfTheIngredient_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxNameOfTheIngredient.Text))
            {
                errorProvider.SetError(textBoxNameOfTheIngredient, "Поле не может быть пустым ");
                buttonSave.Enabled = false;
            }
            else
            {
                errorProvider.Clear();
                buttonSave.Enabled = true;
            }
        }

        private void TextBoxUnit_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxUnit.Text))
            {
                errorProvider.SetError(textBoxUnit, "Поле не может быть пустым ");
                buttonSave.Enabled = false;
            }
            else
            {
                errorProvider.Clear();
                buttonSave.Enabled = true;
            }
        }

        private void TextBoxUnit_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxUnit.Text))
            {
                errorProvider.SetError(textBoxUnit, "Поле не может быть пустым ");
                buttonSave.Enabled = false;
            }
            else
            {
                errorProvider.Clear();
                buttonSave.Enabled = true;
            }
        }

        private void TextBoxQuantityInStock_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxQuantityInStock.Text))
            {
                errorProvider.SetError(textBoxQuantityInStock, "Поле не может быть пустым ");
                buttonSave.Enabled = false;
            }
            else
            {
                errorProvider.Clear();
                buttonSave.Enabled = true;
            }
        }

        private void TextBoxQuantityInStock_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxQuantityInStock.Text))
            {
                errorProvider.SetError(textBoxQuantityInStock, "Поле не может быть пустым ");
                buttonSave.Enabled = false;
            }
            else
            {
                errorProvider.Clear();
                buttonSave.Enabled = true;
            }
        }
    }
}
