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
            resistanceTextBox.TextChanged += new EventHandler(TextChanged);
            capacitanceTextBox.TextChanged += new EventHandler(TextChanged);
            inductanceTextBox.TextChanged += new EventHandler(TextChanged);

            this.radioComponent = radioComponent;
            idTextBox.Text = radioComponent.Id.ToString();
            nameTextBox.Text = radioComponent.Name;
            typeСomboBox.Text = radioComponent.Type;
            resistanceTextBox.Text = radioComponent.Resistance.ToString();
            capacitanceTextBox.Text = radioComponent.Capacitance.ToString();
            inductanceTextBox.Text = radioComponent.Inductance.ToString();
            descriptionTextBox.Text = radioComponent.Description;

        }
        private void TextChanged(object sender, EventArgs e)
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

        private void okButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Ви впевнені, що хочете зберегти зміни?", "confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                radioComponent.Id = Convert.ToInt32(idTextBox.Text);
                radioComponent.Name = nameTextBox.Text;
                radioComponent.Type = typeСomboBox.Text;
                if (typeСomboBox.SelectedIndex == 0)
                {
                    radioComponent.Resistance = Convert.ToDouble(resistanceTextBox.Text);
                    radioComponent.Capacitance = null;
                    radioComponent.Inductance = null;
                }
                else if (typeСomboBox.SelectedIndex == 1)
                {
                    radioComponent.Resistance = null;
                    radioComponent.Capacitance = Convert.ToDouble(capacitanceTextBox.Text);
                    radioComponent.Inductance = null;
                }
                else 
                {
                    radioComponent.Resistance = null;
                    radioComponent.Capacitance = null;
                    radioComponent.Inductance = Convert.ToDouble(inductanceTextBox.Text);
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
