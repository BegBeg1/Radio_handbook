using Radio_handbook.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Radio_handbook.Forms
{
    public partial class MainForm : System.Windows.Forms.Form
    {
        Handbook handbook = Handbook.LoadData();
        public MainForm()
        {
            InitializeComponent();

            handbook.SaveData();
            typeСomboBox.SelectedIndex = 0;
            idNumericUpDown.Text = "";
            resistanceNumericUpDown.Text = "";
            voltageNumericUpDown.Text = "";
            currentNumericUpDown.Text = "";
            priceNumericUpDown.Text = "";
            searchButton_Click(null, null);
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Ви впевнені, що хочете закрити програму?", "confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Close();
            }
        }
        public RadioComponent? SelectedComponent
        {
            get
            {
                var selectedRows = dataGridView1.SelectedRows;
                if (selectedRows == null || selectedRows.Count == 0)
                {
                    return null;
                }
                return selectedRows[0].DataBoundItem as RadioComponent;
            }
        }
        private void searchButton_Click(object sender, EventArgs e)
        {
            var result = handbook.Search(idNumericUpDown.Text.Trim(), nameTextBox.Text.Trim(), typeСomboBox.Text.Trim(),
                                            brandTextBox.Text.Trim(), resistanceNumericUpDown.Text.Trim(), 
                                            voltageNumericUpDown.Text.Trim(), currentNumericUpDown.Text.Trim(),
                                            priceNumericUpDown.Text.Trim() ,descriptionTextBox.Text.Trim());
            dataGridView1.DataSource = result;
        }
        private void addButton_Click(Object sender, EventArgs e)
        {
            var addComponentForm = new AddComponentForm(handbook.RadioComponents);
            if (addComponentForm.ShowDialog() == DialogResult.OK)
            {
                handbook.SaveData();
                searchButton_Click(null, null);
                deleteButton.Enabled = true;
                changeButton.Enabled = true;
            }
        }
        private void changeButton_Click(Object sender, EventArgs e)
        {
            var componentEditForm = new ComponentEditForm(SelectedComponent);
            if (componentEditForm.ShowDialog() == DialogResult.OK)
            {
                handbook.SaveData();
                searchButton_Click(null, null);
            }
        }
        private void deleteButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show($"Ви впевнені, що хочете видалити елемент {SelectedComponent.Name}?", "confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                handbook.RadioComponents.RemoveAt(handbook.RadioComponents.IndexOf(SelectedComponent));
                handbook.SaveData();
                searchButton_Click(null, null);
                if (SelectedComponent == null)
                {
                    deleteButton.Enabled = false;
                    changeButton.Enabled = false;
                }
            }
        }
        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            searchButton_Click(null, null);
        }
        private void customizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addButton_Click(null, null);
        }
        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            changeButton_Click(null, null);
        }
        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            deleteButton_Click(null, null);
        }
        private void aboutToolStripMenuItem_Click(Object sender, EventArgs e)
        {
            MessageBox.Show("Автор програми - Козир Дмитро Миколайович.\nПрограма призначення для зберігання інформації та порівняння компонентів радіоелектроніки.", "Про програму", MessageBoxButtons.OK);
        }
    }
}
