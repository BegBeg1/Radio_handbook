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
            voltageNumericUpDown = new NumericUpDown();
            currentNumericUpDown = new NumericUpDown();
            resistanceNumericUpDown = new NumericUpDown();
            idNumericUpDown = new NumericUpDown();
            typeСomboBox = new ComboBox();
            cancelButton = new Button();
            okButton = new Button();
            descriptionTextBox = new TextBox();
            descriptionLabel = new Label();
            currentLabel = new Label();
            voltageLabel = new Label();
            resistanceLabel = new Label();
            typeLabel = new Label();
            nameTextBox = new TextBox();
            nameLabel = new Label();
            idLabel = new Label();
            brandTextBox = new TextBox();
            brandLabel = new Label();
            priceNumericUpDown = new NumericUpDown();
            priceLabel = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)voltageNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)currentNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)resistanceNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)idNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)priceNumericUpDown).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(priceNumericUpDown);
            panel1.Controls.Add(priceLabel);
            panel1.Controls.Add(brandTextBox);
            panel1.Controls.Add(brandLabel);
            panel1.Controls.Add(voltageNumericUpDown);
            panel1.Controls.Add(currentNumericUpDown);
            panel1.Controls.Add(resistanceNumericUpDown);
            panel1.Controls.Add(idNumericUpDown);
            panel1.Controls.Add(typeСomboBox);
            panel1.Controls.Add(cancelButton);
            panel1.Controls.Add(okButton);
            panel1.Controls.Add(descriptionTextBox);
            panel1.Controls.Add(descriptionLabel);
            panel1.Controls.Add(currentLabel);
            panel1.Controls.Add(voltageLabel);
            panel1.Controls.Add(resistanceLabel);
            panel1.Controls.Add(typeLabel);
            panel1.Controls.Add(nameTextBox);
            panel1.Controls.Add(nameLabel);
            panel1.Controls.Add(idLabel);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(540, 319);
            panel1.TabIndex = 1;
            // 
            // voltageNumericUpDown
            // 
            voltageNumericUpDown.Location = new Point(94, 147);
            voltageNumericUpDown.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            voltageNumericUpDown.Name = "voltageNumericUpDown";
            voltageNumericUpDown.Size = new Size(427, 23);
            voltageNumericUpDown.TabIndex = 11;
            // 
            // currentNumericUpDown
            // 
            currentNumericUpDown.Location = new Point(94, 177);
            currentNumericUpDown.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            currentNumericUpDown.Name = "currentNumericUpDown";
            currentNumericUpDown.Size = new Size(427, 23);
            currentNumericUpDown.TabIndex = 13;
            // 
            // resistanceNumericUpDown
            // 
            resistanceNumericUpDown.Location = new Point(94, 119);
            resistanceNumericUpDown.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
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
            typeСomboBox.Items.AddRange(new object[] { "Резистор", "Транзистор", "Діод", "Тиристор" });
            typeСomboBox.Location = new Point(94, 61);
            typeСomboBox.Name = "typeСomboBox";
            typeСomboBox.Size = new Size(427, 23);
            typeСomboBox.TabIndex = 7;
            // 
            // cancelButton
            // 
            cancelButton.Location = new Point(339, 276);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(114, 29);
            cancelButton.TabIndex = 17;
            cancelButton.Text = "Відміна";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += cancelButton_Click;
            // 
            // okButton
            // 
            okButton.DialogResult = DialogResult.OK;
            okButton.Location = new Point(111, 276);
            okButton.Name = "okButton";
            okButton.Size = new Size(114, 29);
            okButton.TabIndex = 16;
            okButton.Text = "Ок";
            okButton.UseVisualStyleBackColor = true;
            okButton.Click += okButton_Click;
            // 
            // descriptionTextBox
            // 
            descriptionTextBox.Location = new Point(94, 235);
            descriptionTextBox.Name = "descriptionTextBox";
            descriptionTextBox.Size = new Size(427, 23);
            descriptionTextBox.TabIndex = 15;
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new Point(10, 238);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new Size(36, 15);
            descriptionLabel.TabIndex = 14;
            descriptionLabel.Text = "Опис";
            // 
            // currentLabel
            // 
            currentLabel.AutoSize = true;
            currentLabel.Location = new Point(10, 179);
            currentLabel.Name = "currentLabel";
            currentLabel.Size = new Size(42, 15);
            currentLabel.TabIndex = 12;
            currentLabel.Text = "Струм";
            // 
            // voltageLabel
            // 
            voltageLabel.AutoSize = true;
            voltageLabel.Location = new Point(10, 150);
            voltageLabel.Name = "voltageLabel";
            voltageLabel.Size = new Size(53, 15);
            voltageLabel.TabIndex = 10;
            voltageLabel.Text = "Напруга";
            // 
            // resistanceLabel
            // 
            resistanceLabel.AutoSize = true;
            resistanceLabel.Location = new Point(10, 121);
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
            // brandTextBox
            // 
            brandTextBox.Location = new Point(94, 90);
            brandTextBox.Name = "brandTextBox";
            brandTextBox.Size = new Size(427, 23);
            brandTextBox.TabIndex = 19;
            // 
            // brandLabel
            // 
            brandLabel.AutoSize = true;
            brandLabel.Location = new Point(10, 93);
            brandLabel.Name = "brandLabel";
            brandLabel.Size = new Size(40, 15);
            brandLabel.TabIndex = 18;
            brandLabel.Text = "Бренд";
            // 
            // priceNumericUpDown
            // 
            priceNumericUpDown.Location = new Point(94, 206);
            priceNumericUpDown.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            priceNumericUpDown.Name = "priceNumericUpDown";
            priceNumericUpDown.Size = new Size(427, 23);
            priceNumericUpDown.TabIndex = 21;
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.Location = new Point(10, 208);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new Size(32, 15);
            priceLabel.TabIndex = 20;
            priceLabel.Text = "Ціна";
            // 
            // ComponentEditForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(564, 339);
            Controls.Add(panel1);
            MinimumSize = new Size(580, 378);
            Name = "ComponentEditForm";
            Text = "ComponentEditForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)voltageNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)currentNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)resistanceNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)idNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)priceNumericUpDown).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button cancelButton;
        private Button okButton;
        private TextBox descriptionTextBox;
        private Label descriptionLabel;
        private Label currentLabel;
        private Label voltageLabel;
        private Label resistanceLabel;
        private Label typeLabel;
        private TextBox nameTextBox;
        private Label nameLabel;
        private Label idLabel;
        private ComboBox typeСomboBox;
        private NumericUpDown idNumericUpDown;
        private NumericUpDown voltageNumericUpDown;
        private NumericUpDown currentNumericUpDown;
        private NumericUpDown resistanceNumericUpDown;
        private TextBox brandTextBox;
        private Label brandLabel;
        private NumericUpDown priceNumericUpDown;
        private Label priceLabel;
    }
}