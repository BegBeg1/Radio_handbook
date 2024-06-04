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
            brandTextBox.TextChanged += new EventHandler(TextChanged);
            resistanceNumericUpDown.TextChanged += new EventHandler(TextChanged);
            voltageNumericUpDown.TextChanged += new EventHandler(TextChanged);
            currentNumericUpDown.TextChanged += new EventHandler(TextChanged);
            priceNumericUpDown.TextChanged += new EventHandler(TextChanged);


            this.radioComponent = radioComponent;
            idNumericUpDown.Text = radioComponent.Id.ToString();
            nameTextBox.Text = radioComponent.Name;
            typeСomboBox.Text = radioComponent.Type;
            resistanceNumericUpDown.Text = radioComponent.Resistance.ToString();
            voltageNumericUpDown.Text = radioComponent.Voltage.ToString();
            currentNumericUpDown.Text = radioComponent.Сurrent.ToString();
            descriptionTextBox.Text = radioComponent.Description;

        }
        private void TextChanged(object sender, EventArgs e)
        {
            textChangedCheck();
        }
        private void textChangedCheck()
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
        private void okButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Ви впевнені, що хочете зберегти зміни?", "confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                radioComponent.Id = Convert.ToInt32(idNumericUpDown.Text);
                radioComponent.Name = nameTextBox.Text.Trim();
                radioComponent.Type = typeСomboBox.Text.Trim();
                radioComponent.Brand = typeLabel.Text.Trim();
                radioComponent.Resistance = Convert.ToDouble(resistanceNumericUpDown.Text);
                radioComponent.Voltage = Convert.ToDouble(voltageNumericUpDown.Text);
                radioComponent.Сurrent = Convert.ToDouble(currentNumericUpDown.Text);
                radioComponent.Price = Convert.ToDouble(currentNumericUpDown.Text);
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
