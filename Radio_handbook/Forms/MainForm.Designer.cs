namespace Radio_handbook.Forms
{
    partial class MainForm
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
            components = new System.ComponentModel.Container();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            toolsToolStripMenuItem = new ToolStripMenuItem();
            searchToolStripMenuItem = new ToolStripMenuItem();
            addToolStripMenuItem = new ToolStripMenuItem();
            optionsToolStripMenuItem = new ToolStripMenuItem();
            видалитиToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            panel1 = new Panel();
            priceNumericUpDown = new NumericUpDown();
            priceLabel = new Label();
            brandTextBox = new TextBox();
            brandLabel = new Label();
            currentNumericUpDown = new NumericUpDown();
            resistanceNumericUpDown = new NumericUpDown();
            voltageNumericUpDown = new NumericUpDown();
            idNumericUpDown = new NumericUpDown();
            typeСomboBox = new ComboBox();
            descriptionTextBox = new TextBox();
            descriptionLabel = new Label();
            currentLabel = new Label();
            voltageLabel = new Label();
            searchButton = new Button();
            resistanceLabel = new Label();
            typeLabel = new Label();
            nameTextBox = new TextBox();
            nameLabel = new Label();
            idLabel = new Label();
            addButton = new Button();
            changeButton = new Button();
            deleteButton = new Button();
            dataGridView1 = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            typeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            brandDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            resistanceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            voltageDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            сurrentDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            priceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            descriptionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            radioComponentBindingSource1 = new BindingSource(components);
            radioComponentBindingSource = new BindingSource(components);
            menuStrip1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)priceNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)currentNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)resistanceNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)voltageNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)idNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)radioComponentBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)radioComponentBindingSource).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, toolsToolStripMenuItem, helpToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(936, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(53, 20);
            fileToolStripMenuItem.Text = "Меню";
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(103, 22);
            exitToolStripMenuItem.Text = "Вихід";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // toolsToolStripMenuItem
            // 
            toolsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { searchToolStripMenuItem, addToolStripMenuItem, optionsToolStripMenuItem, видалитиToolStripMenuItem });
            toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            toolsToolStripMenuItem.Size = new Size(33, 20);
            toolsToolStripMenuItem.Text = "Дії";
            // 
            // searchToolStripMenuItem
            // 
            searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            searchToolStripMenuItem.Size = new Size(126, 22);
            searchToolStripMenuItem.Text = "Пошук";
            searchToolStripMenuItem.Click += searchToolStripMenuItem_Click;
            // 
            // addToolStripMenuItem
            // 
            addToolStripMenuItem.Name = "addToolStripMenuItem";
            addToolStripMenuItem.Size = new Size(126, 22);
            addToolStripMenuItem.Text = "Додати";
            addToolStripMenuItem.Click += customizeToolStripMenuItem_Click;
            // 
            // optionsToolStripMenuItem
            // 
            optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            optionsToolStripMenuItem.Size = new Size(126, 22);
            optionsToolStripMenuItem.Text = "Змінити";
            optionsToolStripMenuItem.Click += optionsToolStripMenuItem_Click;
            // 
            // видалитиToolStripMenuItem
            // 
            видалитиToolStripMenuItem.Name = "видалитиToolStripMenuItem";
            видалитиToolStripMenuItem.Size = new Size(126, 22);
            видалитиToolStripMenuItem.Text = "Видалити";
            видалитиToolStripMenuItem.Click += deleteToolStripMenuItem_Click;
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aboutToolStripMenuItem });
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(75, 20);
            helpToolStripMenuItem.Text = "Допомога";
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(154, 22);
            aboutToolStripMenuItem.Text = "Про програму";
            aboutToolStripMenuItem.Click += aboutToolStripMenuItem_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(priceNumericUpDown);
            panel1.Controls.Add(priceLabel);
            panel1.Controls.Add(brandTextBox);
            panel1.Controls.Add(brandLabel);
            panel1.Controls.Add(currentNumericUpDown);
            panel1.Controls.Add(resistanceNumericUpDown);
            panel1.Controls.Add(voltageNumericUpDown);
            panel1.Controls.Add(idNumericUpDown);
            panel1.Controls.Add(typeСomboBox);
            panel1.Controls.Add(descriptionTextBox);
            panel1.Controls.Add(descriptionLabel);
            panel1.Controls.Add(currentLabel);
            panel1.Controls.Add(voltageLabel);
            panel1.Controls.Add(searchButton);
            panel1.Controls.Add(resistanceLabel);
            panel1.Controls.Add(typeLabel);
            panel1.Controls.Add(nameTextBox);
            panel1.Controls.Add(nameLabel);
            panel1.Controls.Add(idLabel);
            panel1.Location = new Point(202, 27);
            panel1.Name = "panel1";
            panel1.Size = new Size(533, 316);
            panel1.TabIndex = 1;
            // 
            // priceNumericUpDown
            // 
            priceNumericUpDown.Location = new Point(92, 217);
            priceNumericUpDown.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            priceNumericUpDown.Name = "priceNumericUpDown";
            priceNumericUpDown.Size = new Size(427, 23);
            priceNumericUpDown.TabIndex = 19;
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.Location = new Point(8, 219);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new Size(32, 15);
            priceLabel.TabIndex = 18;
            priceLabel.Text = "Ціна";
            // 
            // brandTextBox
            // 
            brandTextBox.Location = new Point(92, 101);
            brandTextBox.Name = "brandTextBox";
            brandTextBox.Size = new Size(427, 23);
            brandTextBox.TabIndex = 17;
            // 
            // brandLabel
            // 
            brandLabel.AutoSize = true;
            brandLabel.Location = new Point(8, 104);
            brandLabel.Name = "brandLabel";
            brandLabel.Size = new Size(40, 15);
            brandLabel.TabIndex = 16;
            brandLabel.Text = "Бренд";
            // 
            // currentNumericUpDown
            // 
            currentNumericUpDown.Location = new Point(92, 188);
            currentNumericUpDown.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            currentNumericUpDown.Name = "currentNumericUpDown";
            currentNumericUpDown.Size = new Size(427, 23);
            currentNumericUpDown.TabIndex = 12;
            // 
            // resistanceNumericUpDown
            // 
            resistanceNumericUpDown.Location = new Point(92, 130);
            resistanceNumericUpDown.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            resistanceNumericUpDown.Name = "resistanceNumericUpDown";
            resistanceNumericUpDown.Size = new Size(427, 23);
            resistanceNumericUpDown.TabIndex = 8;
            // 
            // voltageNumericUpDown
            // 
            voltageNumericUpDown.Location = new Point(92, 159);
            voltageNumericUpDown.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            voltageNumericUpDown.Name = "voltageNumericUpDown";
            voltageNumericUpDown.Size = new Size(427, 23);
            voltageNumericUpDown.TabIndex = 10;
            // 
            // idNumericUpDown
            // 
            idNumericUpDown.Location = new Point(92, 14);
            idNumericUpDown.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            idNumericUpDown.Name = "idNumericUpDown";
            idNumericUpDown.Size = new Size(427, 23);
            idNumericUpDown.TabIndex = 3;
            // 
            // typeСomboBox
            // 
            typeСomboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            typeСomboBox.FormattingEnabled = true;
            typeСomboBox.Items.AddRange(new object[] { "", "Резистор", "Транзистор", "Діод", "Тиристор" });
            typeСomboBox.Location = new Point(92, 72);
            typeСomboBox.Name = "typeСomboBox";
            typeСomboBox.Size = new Size(427, 23);
            typeСomboBox.TabIndex = 6;
            // 
            // descriptionTextBox
            // 
            descriptionTextBox.Location = new Point(92, 246);
            descriptionTextBox.Name = "descriptionTextBox";
            descriptionTextBox.Size = new Size(427, 23);
            descriptionTextBox.TabIndex = 14;
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new Point(8, 249);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new Size(36, 15);
            descriptionLabel.TabIndex = 13;
            descriptionLabel.Text = "Опис";
            // 
            // currentLabel
            // 
            currentLabel.AutoSize = true;
            currentLabel.Location = new Point(8, 191);
            currentLabel.Name = "currentLabel";
            currentLabel.Size = new Size(42, 15);
            currentLabel.TabIndex = 11;
            currentLabel.Text = "Струм";
            // 
            // voltageLabel
            // 
            voltageLabel.AutoSize = true;
            voltageLabel.Location = new Point(8, 162);
            voltageLabel.Name = "voltageLabel";
            voltageLabel.Size = new Size(53, 15);
            voltageLabel.TabIndex = 9;
            voltageLabel.Text = "Напруга";
            // 
            // searchButton
            // 
            searchButton.Location = new Point(201, 275);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(134, 30);
            searchButton.TabIndex = 15;
            searchButton.Text = "Пошук";
            searchButton.UseVisualStyleBackColor = true;
            searchButton.Click += searchButton_Click;
            // 
            // resistanceLabel
            // 
            resistanceLabel.AutoSize = true;
            resistanceLabel.Location = new Point(8, 133);
            resistanceLabel.Name = "resistanceLabel";
            resistanceLabel.Size = new Size(33, 15);
            resistanceLabel.TabIndex = 7;
            resistanceLabel.Text = "Опір";
            // 
            // typeLabel
            // 
            typeLabel.AutoSize = true;
            typeLabel.Location = new Point(8, 75);
            typeLabel.Name = "typeLabel";
            typeLabel.Size = new Size(27, 15);
            typeLabel.TabIndex = 5;
            typeLabel.Text = "Тип";
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(92, 43);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(427, 23);
            nameTextBox.TabIndex = 4;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new Point(8, 46);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(39, 15);
            nameLabel.TabIndex = 3;
            nameLabel.Text = "Назва";
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new Point(8, 17);
            idLabel.Name = "idLabel";
            idLabel.Size = new Size(17, 15);
            idLabel.TabIndex = 2;
            idLabel.Text = "Id";
            // 
            // addButton
            // 
            addButton.Anchor = AnchorStyles.Bottom;
            addButton.Location = new Point(283, 617);
            addButton.Name = "addButton";
            addButton.Size = new Size(110, 30);
            addButton.TabIndex = 17;
            addButton.Text = "Додати";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // changeButton
            // 
            changeButton.Anchor = AnchorStyles.Bottom;
            changeButton.Location = new Point(428, 617);
            changeButton.Name = "changeButton";
            changeButton.Size = new Size(110, 30);
            changeButton.TabIndex = 18;
            changeButton.Text = "Змінити";
            changeButton.UseVisualStyleBackColor = true;
            changeButton.Click += changeButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.Anchor = AnchorStyles.Bottom;
            deleteButton.Location = new Point(563, 617);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(110, 30);
            deleteButton.TabIndex = 19;
            deleteButton.Text = "Видалити";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += deleteButton_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.BackgroundColor = SystemColors.ControlLightLight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, nameDataGridViewTextBoxColumn, typeDataGridViewTextBoxColumn, brandDataGridViewTextBoxColumn, resistanceDataGridViewTextBoxColumn, voltageDataGridViewTextBoxColumn, сurrentDataGridViewTextBoxColumn, priceDataGridViewTextBoxColumn, descriptionDataGridViewTextBoxColumn });
            dataGridView1.DataSource = radioComponentBindingSource1;
            dataGridView1.Location = new Point(6, 349);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(917, 262);
            dataGridView1.TabIndex = 20;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn.HeaderText = "Name";
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // typeDataGridViewTextBoxColumn
            // 
            typeDataGridViewTextBoxColumn.DataPropertyName = "Type";
            typeDataGridViewTextBoxColumn.HeaderText = "Type";
            typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            typeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // brandDataGridViewTextBoxColumn
            // 
            brandDataGridViewTextBoxColumn.DataPropertyName = "Brand";
            brandDataGridViewTextBoxColumn.HeaderText = "Brand";
            brandDataGridViewTextBoxColumn.Name = "brandDataGridViewTextBoxColumn";
            brandDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // resistanceDataGridViewTextBoxColumn
            // 
            resistanceDataGridViewTextBoxColumn.DataPropertyName = "Resistance";
            resistanceDataGridViewTextBoxColumn.HeaderText = "Resistance";
            resistanceDataGridViewTextBoxColumn.Name = "resistanceDataGridViewTextBoxColumn";
            resistanceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // voltageDataGridViewTextBoxColumn
            // 
            voltageDataGridViewTextBoxColumn.DataPropertyName = "Voltage";
            voltageDataGridViewTextBoxColumn.HeaderText = "Voltage";
            voltageDataGridViewTextBoxColumn.Name = "voltageDataGridViewTextBoxColumn";
            voltageDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // сurrentDataGridViewTextBoxColumn
            // 
            сurrentDataGridViewTextBoxColumn.DataPropertyName = "Сurrent";
            сurrentDataGridViewTextBoxColumn.HeaderText = "Сurrent";
            сurrentDataGridViewTextBoxColumn.Name = "сurrentDataGridViewTextBoxColumn";
            сurrentDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            priceDataGridViewTextBoxColumn.HeaderText = "Price";
            priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            priceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // radioComponentBindingSource1
            // 
            radioComponentBindingSource1.DataSource = typeof(Models.RadioComponent);
            // 
            // radioComponentBindingSource
            // 
            radioComponentBindingSource.DataSource = typeof(Models.RadioComponent);
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(936, 648);
            Controls.Add(dataGridView1);
            Controls.Add(deleteButton);
            Controls.Add(changeButton);
            Controls.Add(addButton);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            MinimumSize = new Size(560, 580);
            Name = "MainForm";
            Text = "MainForm";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)priceNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)currentNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)resistanceNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)voltageNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)idNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)radioComponentBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)radioComponentBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem toolsToolStripMenuItem;
        private ToolStripMenuItem addToolStripMenuItem;
        private ToolStripMenuItem optionsToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private Panel panel1;
        private Label resistanceLabel;
        private Label typeLabel;
        private TextBox nameTextBox;
        private Label nameLabel;
        private Label idLabel;
        private Button searchButton;
        private Label voltageLabel;
        private TextBox descriptionTextBox;
        private Label descriptionLabel;
        private Label currentLabel;
        private Button addButton;
        private Button changeButton;
        private Button deleteButton;
        private DataGridView dataGridView1;
        private ComboBox typeСomboBox;
        private DataGridViewTextBoxColumn capacitanceDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn inductanceDataGridViewTextBoxColumn;
        private BindingSource radioComponentBindingSource;
        private ToolStripMenuItem видалитиToolStripMenuItem;
        private ToolStripMenuItem searchToolStripMenuItem;
        private NumericUpDown idNumericUpDown;
        private NumericUpDown resistanceNumericUpDown;
        private NumericUpDown voltageNumericUpDown;
        private NumericUpDown currentNumericUpDown;
        private TextBox brandTextBox;
        private Label brandLabel;
        private NumericUpDown priceNumericUpDown;
        private Label priceLabel;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn brandDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn resistanceDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn voltageDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn сurrentDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private BindingSource radioComponentBindingSource1;
    }
}