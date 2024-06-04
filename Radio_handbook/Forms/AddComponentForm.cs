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

namespace Radio_handbook.Forms
{
    public partial class AddComponentForm : Form
    {
        readonly List<RadioComponent> handbook = new();
        public AddComponentForm(List<RadioComponent> handbook)
        {
            InitializeComponent();

            resistanceNumericUpDown.Text = "";
            voltageNumericUpDown.Text = "";
            currentNumericUpDown.Text = "";
            priceNumericUpDown.Text = "";

            this.handbook = handbook;
            if (handbook.Count != 0)
            {
                idNumericUpDown.Text = Convert.ToString(handbook[handbook.Count - 1].Id + 1);
            } 
            else
            {
                idNumericUpDown.Text = "1";
            }
            typeСomboBox.SelectedIndex = 0;
            nameTextBox.TextChanged += new EventHandler(TextChanged);
            brandTextBox.TextChanged += new EventHandler(TextChanged);
            resistanceNumericUpDown.TextChanged += new EventHandler(TextChanged);
            voltageNumericUpDown.TextChanged += new EventHandler(TextChanged);
            currentNumericUpDown.TextChanged += new EventHandler(TextChanged);
            priceNumericUpDown.TextChanged += new EventHandler(TextChanged);
            TextChangedCheck();
        }
        void TextChangedCheck()
        {
            if (nameTextBox.Text.Trim() == "" || resistanceNumericUpDown.Text.Trim() == "" ||
                brandTextBox.Text.Trim() == "" || voltageNumericUpDown.Text.Trim() == "" ||
                currentNumericUpDown.Text.Trim() == "" || priceNumericUpDown.Text.Trim() == "")
            {
                okButton.Enabled = false;
            }
            else
            {
                okButton.Enabled = true;
            }
        }
        private void TextChanged(object sender, EventArgs e)
        {
            TextChangedCheck();
        }

        private void okButton_Click(object sender, EventArgs e)
        {

            var result = new RadioComponent
            {
                Id = Convert.ToInt32(idNumericUpDown.Text),
                Name = nameTextBox.Text.Trim(),
                Type = typeСomboBox.Text,
                Brand = brandTextBox.Text.Trim(),
                Resistance = Convert.ToDouble(resistanceNumericUpDown.Text),
                Voltage = Convert.ToDouble(voltageNumericUpDown.Text),
                Сurrent = Convert.ToDouble(currentNumericUpDown.Text),
                Price = Convert.ToDouble(priceNumericUpDown.Text),
                Description = descriptionTextBox.Text.Trim()
            };
            handbook.Add(result);
            Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
