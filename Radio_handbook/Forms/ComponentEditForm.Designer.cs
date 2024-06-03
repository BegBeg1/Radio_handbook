namespace Radio_handbook.Forms
{
    partial class ComponentEditForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            capacitanceNumericUpDown = new NumericUpDown();
            inductanceNumericUpDown = new NumericUpDown();
            resistanceNumericUpDown = new NumericUpDown();
            idNumericUpDown = new NumericUpDown();
            typeСomboBox = new ComboBox();
            cancelButton = new Button();
            okButton = new Button();
            descriptionTextBox = new TextBox();
            descriptionLabel = new Label();
            inductanceLabel = new Label();
            capacitanceLabel = new Label();
            resistanceLabel = new Label();
            typeLabel = new Label();
            nameTextBox = new TextBox();
            nameLabel = new Label();
            idLabel = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)capacitanceNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)inductanceNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)resistanceNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)idNumericUpDown).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(capacitanceNumericUpDown);
            panel1.Controls.Add(inductanceNumericUpDown);
            panel1.Controls.Add(resistanceNumericUpDown);
            panel1.Controls.Add(idNumericUpDown);
            panel1.Controls.Add(typeСomboBox);
            panel1.Controls.Add(cancelButton);
            panel1.Controls.Add(okButton);
            panel1.Controls.Add(descriptionTextBox);
            panel1.Controls.Add(descriptionLabel);
            panel1.Controls.Add(inductanceLabel);
            panel1.Controls.Add(capacitanceLabel);
            panel1.Controls.Add(resistanceLabel);
            panel1.Controls.Add(typeLabel);
            panel1.Controls.Add(nameTextBox);
            panel1.Controls.Add(nameLabel);
            panel1.Controls.Add(idLabel);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(540, 245);
            panel1.TabIndex = 1;
            // 
            // capacitanceNumericUpDown
            // 
            capacitanceNumericUpDown.Location = new Point(94, 119);
            capacitanceNumericUpDown.Name = "capacitanceNumericUpDown";
            capacitanceNumericUpDown.Size = new Size(427, 23);
            capacitanceNumericUpDown.TabIndex = 11;
            // 
            // inductanceNumericUpDown
            // 
            inductanceNumericUpDown.Location = new Point(94, 149);
            inductanceNumericUpDown.Name = "inductanceNumericUpDown";
            inductanceNumericUpDown.Size = new Size(427, 23);
            inductanceNumericUpDown.TabIndex = 13;
            // 
            // resistanceNumericUpDown
            // 
            resistanceNumericUpDown.Location = new Point(94, 91);
            resistanceNumericUpDown.Name = "resistanceNumericUpDown";
            resistanceNumericUpDown.Size = new Size(427, 23);
            resistanceNumericUpDown.TabIndex = 9;
            // 
            // idNumericUpDown
            // 
            idNumericUpDown.Enabled = false;
            idNumericUpDown.Location = new Point(94, 4);
            idNumericUpDown.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            idNumericUpDown.Name = "idNumericUpDown";
            idNumericUpDown.Size = new Size(427, 23);
            idNumericUpDown.TabIndex = 3;
            // 
            // typeСomboBox
            // 
            typeСomboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            typeСomboBox.FormattingEnabled = true;
            typeСomboBox.Items.AddRange(new object[] { "Резистор", "Конденсатор", "Котушка індуктивності" });
            typeСomboBox.Location = new Point(94, 61);
            typeСomboBox.Name = "typeСomboBox";
            typeСomboBox.Size = new Size(427, 23);
            typeСomboBox.TabIndex = 7;
            typeСomboBox.SelectedIndexChanged += typeСomboBox_SelectedIndexChanged;
            // 
            // cancelButton
            // 
            cancelButton.Location = new Point(334, 211);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(114, 29);
            cancelButton.TabIndex = 17;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += cancelButton_Click;
            // 
            // okButton
            // 
            okButton.DialogResult = DialogResult.OK;
            okButton.Location = new Point(106, 211);
            okButton.Name = "okButton";
            okButton.Size = new Size(114, 29);
            okButton.TabIndex = 16;
            okButton.Text = "Ok";
            okButton.UseVisualStyleBackColor = true;
            okButton.Click += okButton_Click;
            // 
            // descriptionTextBox
            // 
            descriptionTextBox.Location = new Point(94, 177);
            descriptionTextBox.Name = "descriptionTextBox";
            descriptionTextBox.Size = new Size(427, 23);
            descriptionTextBox.TabIndex = 15;
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new Point(10, 180);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new Size(36, 15);
            descriptionLabel.TabIndex = 14;
            descriptionLabel.Text = "Опис";
            // 
            // inductanceLabel
            // 
            inductanceLabel.AutoSize = true;
            inductanceLabel.Location = new Point(10, 151);
            inductanceLabel.Name = "inductanceLabel";
            inductanceLabel.Size = new Size(80, 15);
            inductanceLabel.TabIndex = 12;
            inductanceLabel.Text = "Індуктивність";
            // 
            // capacitanceLabel
            // 
            capacitanceLabel.AutoSize = true;
            capacitanceLabel.Location = new Point(10, 122);
            capacitanceLabel.Name = "capacitanceLabel";
            capacitanceLabel.Size = new Size(50, 15);
            capacitanceLabel.TabIndex = 10;
            capacitanceLabel.Text = "Ємність";
            // 
            // resistanceLabel
            // 
            resistanceLabel.AutoSize = true;
            resistanceLabel.Location = new Point(10, 93);
            resistanceLabel.Name = "resistanceLabel";
            resistanceLabel.Size = new Size(33, 15);
            resistanceLabel.TabIndex = 8;
            resistanceLabel.Text = "Опір";
            // 
            // typeLabel
            // 
            typeLabel.AutoSize = true;
            typeLabel.Location = new Point(10, 64);
            typeLabel.Name = "typeLabel";
            typeLabel.Size = new Size(27, 15);
            typeLabel.TabIndex = 6;
            typeLabel.Text = "Тип";
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(94, 32);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(427, 23);
            nameTextBox.TabIndex = 5;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new Point(10, 35);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(39, 15);
            nameLabel.TabIndex = 4;
            nameLabel.Text = "Назва";
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new Point(10, 6);
            idLabel.Name = "idLabel";
            idLabel.Size = new Size(17, 15);
            idLabel.TabIndex = 2;
            idLabel.Text = "Id";
            // 
            // ComponentEditForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(564, 269);
            Controls.Add(panel1);
            MinimumSize = new Size(580, 308);
            Name = "ComponentEditForm";
            Text = "ComponentEditForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)capacitanceNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)inductanceNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)resistanceNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)idNumericUpDown).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button cancelButton;
        private Button okButton;
        private TextBox descriptionTextBox;
        private Label descriptionLabel;
        private Label inductanceLabel;
        private Label capacitanceLabel;
        private Label resistanceLabel;
        private Label typeLabel;
        private TextBox nameTextBox;
        private Label nameLabel;
        private Label idLabel;
        private ComboBox typeСomboBox;
        private NumericUpDown idNumericUpDown;
        private NumericUpDown capacitanceNumericUpDown;
        private NumericUpDown inductanceNumericUpDown;
        private NumericUpDown resistanceNumericUpDown;
    }
}