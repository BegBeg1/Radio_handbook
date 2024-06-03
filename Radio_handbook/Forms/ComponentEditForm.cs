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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Radio_handbook.Forms
{
    public partial class ComponentEditForm : System.Windows.Forms.Form
    {
        readonly RadioComponent radioComponent = new RadioComponent();
        public ComponentEditForm(RadioComponent radioComponent)
        {
            InitializeComponent();

            nameTextBox.TextChanged += new EventHandler(TextChanged);
            resistanceNumericUpDown.TextChanged += new EventHandler(TextChanged);
            capacitanceNumericUpDown.TextChanged += new EventHandler(TextChanged);
            inductanceNumericUpDown.TextChanged += new EventHandler(TextChanged);

            this.radioComponent = radioComponent;
            idNumericUpDown.Text = radioComponent.Id.ToString();
            nameTextBox.Text = radioComponent.Name;
            typeСomboBox.Text = radioComponent.Type;
            resistanceNumericUpDown.Text = radioComponent.Resistance.ToString();
            capacitanceNumericUpDown.Text = radioComponent.Capacitance.ToString();
            inductanceNumericUpDown.Text = radioComponent.Inductance.ToString();
            descriptionTextBox.Text = radioComponent.Description;

        }
        private void TextChanged(object sender, EventArgs e)
        {
            textChangedCheck();
        }
        private void textChangedCheck()
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
            }
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Ви впевнені, що хочете зберегти зміни?", "confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                radioComponent.Id = Convert.ToInt32(idNumericUpDown.Text);
                radioComponent.Name = nameTextBox.Text;
                radioComponent.Type = typeСomboBox.Text;
                if (typeСomboBox.SelectedIndex == 0)
                {
                    radioComponent.Resistance = Convert.ToDouble(resistanceNumericUpDown.Text);
                    radioComponent.Capacitance = null;
                    radioComponent.Inductance = null;
                }
                else if (typeСomboBox.SelectedIndex == 1)
                {
                    radioComponent.Resistance = null;
                    radioComponent.Capacitance = Convert.ToDouble(capacitanceNumericUpDown.Text);
                    radioComponent.Inductance = null;
                }
                else 
                {
                    radioComponent.Resistance = null;
                    radioComponent.Capacitance = null;
                    radioComponent.Inductance = Convert.ToDouble(inductanceNumericUpDown.Text);
                }
                radioComponent.Description = descriptionTextBox.Text;
                Close();
            }
        }
        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
