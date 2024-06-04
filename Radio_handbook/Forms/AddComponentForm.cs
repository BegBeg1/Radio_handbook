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
            capacitanceNumericUpDown.Text = "";
            inductanceNumericUpDown.Text = "";

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
            resistanceNumericUpDown.TextChanged += new EventHandler(TextChanged);
            capacitanceNumericUpDown.TextChanged += new EventHandler(TextChanged);
            inductanceNumericUpDown.TextChanged += new EventHandler(TextChanged);
            TextChangedCheck();
        }
        void TextChangedCheck()
        {
            if (nameTextBox.Text.Trim() == "" ||
                ((typeСomboBox.SelectedIndex == 0 && resistanceNumericUpDown.Text.Trim() == "") ||
                (typeСomboBox.SelectedIndex == 1 && capacitanceNumericUpDown.Text.Trim() == "") ||
                (typeСomboBox.SelectedIndex == 2 && inductanceNumericUpDown.Text.Trim() == "")))
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
        
        private void typeСomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (typeСomboBox.SelectedIndex)
            {
                case 0:
                    resistanceNumericUpDown.Enabled = true;
                    capacitanceNumericUpDown.Text = "";
                    capacitanceNumericUpDown.Enabled = false;
                    inductanceNumericUpDown.Text = "";
                    inductanceNumericUpDown.Enabled = false;
                    break;
                case 1:
                    resistanceNumericUpDown.Text = "";
                    resistanceNumericUpDown.Enabled = false;
                    capacitanceNumericUpDown.Enabled = true;
                    inductanceNumericUpDown.Text = "";
                    inductanceNumericUpDown.Enabled = false;
                    break;
                case 2:
                    resistanceNumericUpDown.Text = "";
                    resistanceNumericUpDown.Enabled = false;
                    capacitanceNumericUpDown.Text = "";
                    capacitanceNumericUpDown.Enabled = false;
                    inductanceNumericUpDown.Enabled = true;
                    break;
                case 3:
                    resistanceNumericUpDown.Enabled = true;
                    capacitanceNumericUpDown.Enabled = true;
                    inductanceNumericUpDown.Enabled = true;
                    break;
            }
        }

        private void okButton_Click(object sender, EventArgs e)
        {

            var result = new RadioComponent
            {
                Id = Convert.ToInt32(idNumericUpDown.Text),
                Name = nameTextBox.Text.Trim(),
                Type = typeСomboBox.Text,
                Resistance = null,
                Capacitance = null,
                Inductance = null,
                Description = descriptionTextBox.Text.Trim()
            };
            if (typeСomboBox.SelectedIndex == 0) 
            {
                result.Resistance = Convert.ToDouble(resistanceNumericUpDown.Text);
            }
            else if (typeСomboBox.SelectedIndex == 1)
            {
                result.Capacitance = Convert.ToDouble(capacitanceNumericUpDown.Text);
            }
            else
            {
                result.Inductance = Convert.ToDouble(inductanceNumericUpDown.Text);
            }
            handbook.Add(result);
            Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
