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

            this.handbook = handbook;
            if (handbook.Count != 0)
            {
                idTextBox.Text = Convert.ToString(handbook[handbook.Count - 1].Id + 1);
            } 
            else
            {
                idTextBox.Text = "1";
            }
            typeСomboBox.SelectedIndex = 0;
            nameTextBox.TextChanged += new EventHandler(TextChanged);
            resistanceTextBox.TextChanged += new EventHandler(TextChanged);
            capacitanceTextBox.TextChanged += new EventHandler(TextChanged);
            inductanceTextBox.TextChanged += new EventHandler(TextChanged);
            TextChangedCheck();
        }
        void TextChangedCheck()
        {
            if (nameTextBox.Text.Trim() == "" ||
                ((typeСomboBox.SelectedIndex == 0 && resistanceTextBox.Text.Trim() == "") ||
                (typeСomboBox.SelectedIndex == 1 && capacitanceTextBox.Text.Trim() == "") ||
                (typeСomboBox.SelectedIndex == 2 && inductanceTextBox.Text.Trim() == "")))
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
                    resistanceTextBox.Enabled = true;
                    capacitanceTextBox.Text = "";
                    capacitanceTextBox.Enabled = false;
                    inductanceTextBox.Text = "";
                    inductanceTextBox.Enabled = false;
                    break;
                case 1:
                    resistanceTextBox.Text = "";
                    resistanceTextBox.Enabled = false;
                    capacitanceTextBox.Enabled = true;
                    inductanceTextBox.Text = "";
                    inductanceTextBox.Enabled = false;
                    break;
                case 2:
                    resistanceTextBox.Text = "";
                    resistanceTextBox.Enabled = false;
                    capacitanceTextBox.Text = "";
                    capacitanceTextBox.Enabled = false;
                    inductanceTextBox.Enabled = true;
                    break;
            }
        }

        private void idTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void okButton_Click(object sender, EventArgs e)
        {
            handbook.Add(new RadioComponent
            {
                Id = Convert.ToInt32(idTextBox.Text),
                Name = nameTextBox.Text.Trim(),
                Type = typeСomboBox.Text,
                //Resistance = Convert.ToDouble(resistanceTextBox.Text),
                //Capacitance = Convert.ToDouble(capacitanceTextBox.Text),
                //Inductance = Convert.ToDouble(inductanceTextBox.Text),
                Resistance = null,
                Capacitance = null,
                Inductance = null,
                Description = descriptionTextBox.Text.Trim()
            });
            Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
