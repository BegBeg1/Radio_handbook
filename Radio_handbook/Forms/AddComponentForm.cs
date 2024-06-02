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
            idTextBox.Text = Convert.ToString(handbook[handbook.Count].Id + 1);
        }

        private void idTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void okButton_Click(object sender, EventArgs e)
        {
            handbook.Add(new RadioComponent
            {
                Id = Convert.ToInt32(idTextBox.Text),
                Name = nameTextBox.Text,
                Type = typeTextBox.Text,
                Resistance = Convert.ToDouble(resistanceTextBox.Text),
                Capacitance = Convert.ToDouble(capacitanceTextBox.Text),
                Inductance = Convert.ToDouble(inductanceTextBox.Text),
                Description = descriptionTextBox.Text
            });
            Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
