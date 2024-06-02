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
    public partial class ComponentEditForm : System.Windows.Forms.Form
    {
        readonly RadioComponent radioComponent = new RadioComponent();
        public ComponentEditForm(RadioComponent radioComponent)
        {
            InitializeComponent();

            this.radioComponent = radioComponent;
            idTextBox.Text = radioComponent.Id.ToString();
            nameTextBox.Text = radioComponent.Name;
            typeTextBox.Text = radioComponent.Type;
            resistanceTextBox.Text = radioComponent.Resistance.ToString();
            capacitanceTextBox.Text = radioComponent.Capacitance.ToString();
            inductanceTextBox.Text = radioComponent.Inductance.ToString();
            descriptionTextBox.Text = radioComponent.Description;

        }
        
        private void okButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Ви впевнені, що хочете зберегти зміни?", "confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                radioComponent.Id = Convert.ToInt32(idTextBox.Text);
                radioComponent.Name = nameTextBox.Text;
                radioComponent.Type = typeTextBox.Text;
                radioComponent.Resistance = Convert.ToDouble(resistanceTextBox.Text);
                radioComponent.Capacitance = Convert.ToDouble(capacitanceTextBox.Text);
                radioComponent.Inductance = Convert.ToDouble(inductanceTextBox.Text);
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
