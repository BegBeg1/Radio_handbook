namespace Radio_handbook.Forms
{
    partial class AddComponentForm
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
            resistanceTextBox = new NumericUpDown();
            capacitanceTextBox = new NumericUpDown();
            inductanceTextBox = new NumericUpDown();
            idTextBox = new NumericUpDown();
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
            ((System.ComponentModel.ISupportInitialize)resistanceTextBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)capacitanceTextBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)inductanceTextBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)idTextBox).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(resistanceTextBox);
            panel1.Controls.Add(capacitanceTextBox);
            panel1.Controls.Add(inductanceTextBox);
            panel1.Controls.Add(idTextBox);
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
            // resistanceTextBox
            // 
            resistanceTextBox.Location = new Point(94, 90);
            resistanceTextBox.Name = "resistanceTextBox";
            resistanceTextBox.Size = new Size(427, 23);
            resistanceTextBox.TabIndex = 35;
            // 
            // capacitanceTextBox
            // 
            capacitanceTextBox.Location = new Point(94, 119);
            capacitanceTextBox.Name = "capacitanceTextBox";
            capacitanceTextBox.Size = new Size(427, 23);
            capacitanceTextBox.TabIndex = 34;
            // 
            // inductanceTextBox
            // 
            inductanceTextBox.Location = new Point(94, 148);
            inductanceTextBox.Name = "inductanceTextBox";
            inductanceTextBox.Size = new Size(427, 23);
            inductanceTextBox.TabIndex = 33;
            // 
            // idTextBox
            // 
            idTextBox.Enabled = false;
            idTextBox.Location = new Point(94, 6);
            idTextBox.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            idTextBox.Name = "idTextBox";
            idTextBox.Size = new Size(427, 23);
            idTextBox.TabIndex = 2;
            // 
            // typeСomboBox
            // 
            typeСomboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            typeСomboBox.FormattingEnabled = true;
            typeСomboBox.Items.AddRange(new object[] { "Резистор", "Конденсатор", "Котушка індуктивності" });
            typeСomboBox.Location = new Point(94, 61);
            typeСomboBox.Name = "typeСomboBox";
            typeСomboBox.Size = new Size(427, 23);
            typeСomboBox.TabIndex = 30;
            typeСomboBox.SelectedIndexChanged += typeСomboBox_SelectedIndexChanged;
            // 
            // cancelButton
            // 
            cancelButton.Location = new Point(334, 211);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(114, 29);
            cancelButton.TabIndex = 29;
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
            okButton.TabIndex = 28;
            okButton.Text = "Ok";
            okButton.UseVisualStyleBackColor = true;
            okButton.Click += okButton_Click;
            // 
            // descriptionTextBox
            // 
            descriptionTextBox.Location = new Point(94, 177);
            descriptionTextBox.Name = "descriptionTextBox";
            descriptionTextBox.Size = new Size(427, 23);
            descriptionTextBox.TabIndex = 27;
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new Point(10, 180);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new Size(36, 15);
            descriptionLabel.TabIndex = 26;
            descriptionLabel.Text = "Опис";
            // 
            // inductanceLabel
            // 
            inductanceLabel.AutoSize = true;
            inductanceLabel.Location = new Point(10, 151);
            inductanceLabel.Name = "inductanceLabel";
            inductanceLabel.Size = new Size(80, 15);
            inductanceLabel.TabIndex = 24;
            inductanceLabel.Text = "Індуктивність";
            // 
            // capacitanceLabel
            // 
            capacitanceLabel.AutoSize = true;
            capacitanceLabel.Location = new Point(10, 122);
            capacitanceLabel.Name = "capacitanceLabel";
            capacitanceLabel.Size = new Size(50, 15);
            capacitanceLabel.TabIndex = 22;
            capacitanceLabel.Text = "Ємність";
            // 
            // resistanceLabel
            // 
            resistanceLabel.AutoSize = true;
            resistanceLabel.Location = new Point(10, 93);
            resistanceLabel.Name = "resistanceLabel";
            resistanceLabel.Size = new Size(33, 15);
            resistanceLabel.TabIndex = 20;
            resistanceLabel.Text = "Опір";
            // 
            // typeLabel
            // 
            typeLabel.AutoSize = true;
            typeLabel.Location = new Point(10, 64);
            typeLabel.Name = "typeLabel";
            typeLabel.Size = new Size(27, 15);
            typeLabel.TabIndex = 18;
            typeLabel.Text = "Тип";
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(94, 32);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(427, 23);
            nameTextBox.TabIndex = 17;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new Point(10, 35);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(39, 15);
            nameLabel.TabIndex = 16;
            nameLabel.Text = "Назва";
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new Point(10, 6);
            idLabel.Name = "idLabel";
            idLabel.Size = new Size(17, 15);
            idLabel.TabIndex = 14;
            idLabel.Text = "Id";
            // 
            // AddComponentForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(564, 269);
            Controls.Add(panel1);
            Name = "AddComponentForm";
            Text = "AddComponentForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)resistanceTextBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)capacitanceTextBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)inductanceTextBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)idTextBox).EndInit();
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
        private NumericUpDown idTextBox;
        private NumericUpDown resistanceTextBox;
        private NumericUpDown capacitanceTextBox;
        private NumericUpDown inductanceTextBox;
    }
}