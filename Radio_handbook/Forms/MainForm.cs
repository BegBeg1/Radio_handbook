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
        Handbook handbook = new Handbook();

        public MainForm()
        {
            InitializeComponent();
            typeСomboBox.SelectedIndex = 0;
            searchButton_Click(null, null);
        }
        private void typeСomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (typeСomboBox.SelectedIndex)
            {
                case 0:
                    resistanceTextBox.Enabled = true;
                    capacitanceTextBox.Enabled = true;
                    inductanceTextBox.Enabled = true;
                    break;
                case 1:
                    resistanceTextBox.Enabled = true;
                    capacitanceTextBox.Text = "";
                    capacitanceTextBox.Enabled = false;
                    inductanceTextBox.Text = "";
                    inductanceTextBox.Enabled = false;
                    break;
                case 2:
                    resistanceTextBox.Text = "";
                    resistanceTextBox.Enabled = false;
                    capacitanceTextBox.Enabled = true;
                    inductanceTextBox.Text = "";
                    inductanceTextBox.Enabled = false;
                    break;
                case 3:
                    resistanceTextBox.Text = "";
                    resistanceTextBox.Enabled = false;
                    capacitanceTextBox.Text = "";
                    capacitanceTextBox.Enabled = false;
                    inductanceTextBox.Enabled = true;
                    break;
            }
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
            var result = handbook.Search(idTextBox.Text.Trim(), nameTextBox.Text.Trim(), typeСomboBox.Text.Trim(),
                                            resistanceTextBox.Text.Trim(), capacitanceTextBox.Text.Trim(),
                                            inductanceTextBox.Text.Trim(), descriptionTextBox.Text.Trim());
            dataGridView1.DataSource = result;
        }
        private void addButton_Click(Object sender, EventArgs e)
        {
            var addComponentForm = new AddComponentForm(handbook.RadioComponents);
            if (addComponentForm.ShowDialog() == DialogResult.OK)
            {
                searchButton_Click(null, null);
            }
        }
        private void changeButton_Click(Object sender, EventArgs e)
        {
            var componentEditForm = new ComponentEditForm(SelectedComponent);
            if (componentEditForm.ShowDialog() == DialogResult.OK)
            {
                searchButton_Click(null, null);
            }
        }
        private void deleteButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show($"Ви впевнені, що хочете видалити елемент {SelectedComponent.Name}?", "confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                handbook.RadioComponents.RemoveAt(handbook.RadioComponents.IndexOf(SelectedComponent));
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
            MessageBox.Show("Автор програми - Козир Дмитро Миколайович.\nПрограма призначення для зберігання інформації та порівняння компонентів радіоелектроніки.", "Про нас", MessageBoxButtons.OK);
        }
    }
}
