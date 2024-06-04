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
            inductanceNumericUpDown = new NumericUpDown();
            resistanceNumericUpDown = new NumericUpDown();
            capacitanceNumericUpDown = new NumericUpDown();
            idNumericUpDown = new NumericUpDown();
            typeСomboBox = new ComboBox();
            descriptionTextBox = new TextBox();
            descriptionLabel = new Label();
            inductanceLabel = new Label();
            capacitanceLabel = new Label();
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
            typeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            resistanceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            capacitanceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            inductanceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            descriptionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            radioComponentBindingSource = new BindingSource(components);
            menuStrip1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)inductanceNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)resistanceNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)capacitanceNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)idNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)radioComponentBindingSource).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, toolsToolStripMenuItem, helpToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(794, 24);
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
            panel1.Anchor = AnchorStyles.None;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(inductanceNumericUpDown);
            panel1.Controls.Add(resistanceNumericUpDown);
            panel1.Controls.Add(capacitanceNumericUpDown);
            panel1.Controls.Add(idNumericUpDown);
            panel1.Controls.Add(typeСomboBox);
            panel1.Controls.Add(descriptionTextBox);
            panel1.Controls.Add(descriptionLabel);
            panel1.Controls.Add(inductanceLabel);
            panel1.Controls.Add(capacitanceLabel);
            panel1.Controls.Add(searchButton);
            panel1.Controls.Add(resistanceLabel);
            panel1.Controls.Add(typeLabel);
            panel1.Controls.Add(nameTextBox);
            panel1.Controls.Add(nameLabel);
            panel1.Controls.Add(idLabel);
            panel1.Location = new Point(131, 27);
            panel1.Name = "panel1";
            panel1.Size = new Size(533, 258);
            panel1.TabIndex = 1;
            // 
            // inductanceNumericUpDown
            // 
            inductanceNumericUpDown.Location = new Point(92, 159);
            inductanceNumericUpDown.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            inductanceNumericUpDown.Name = "inductanceNumericUpDown";
            inductanceNumericUpDown.Size = new Size(427, 23);
            inductanceNumericUpDown.TabIndex = 12;
            // 
            // resistanceNumericUpDown
            // 
            resistanceNumericUpDown.Location = new Point(92, 101);
            resistanceNumericUpDown.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            resistanceNumericUpDown.Name = "resistanceNumericUpDown";
            resistanceNumericUpDown.Size = new Size(427, 23);
            resistanceNumericUpDown.TabIndex = 8;
            // 
            // capacitanceNumericUpDown
            // 
            capacitanceNumericUpDown.Location = new Point(92, 130);
            capacitanceNumericUpDown.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            capacitanceNumericUpDown.Name = "capacitanceNumericUpDown";
            capacitanceNumericUpDown.Size = new Size(427, 23);
            capacitanceNumericUpDown.TabIndex = 10;
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
            typeСomboBox.Items.AddRange(new object[] { "", "Резистор", "Конденсатор", "Котушка індуктивності" });
            typeСomboBox.Location = new Point(92, 72);
            typeСomboBox.Name = "typeСomboBox";
            typeСomboBox.Size = new Size(427, 23);
            typeСomboBox.TabIndex = 6;
            typeСomboBox.SelectedIndexChanged += typeСomboBox_SelectedIndexChanged;
            // 
            // descriptionTextBox
            // 
            descriptionTextBox.Location = new Point(92, 188);
            descriptionTextBox.Name = "descriptionTextBox";
            descriptionTextBox.Size = new Size(427, 23);
            descriptionTextBox.TabIndex = 14;
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new Point(8, 191);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new Size(36, 15);
            descriptionLabel.TabIndex = 13;
            descriptionLabel.Text = "Опис";
            // 
            // inductanceLabel
            // 
            inductanceLabel.AutoSize = true;
            inductanceLabel.Location = new Point(8, 162);
            inductanceLabel.Name = "inductanceLabel";
            inductanceLabel.Size = new Size(80, 15);
            inductanceLabel.TabIndex = 11;
            inductanceLabel.Text = "Індуктивність";
            // 
            // capacitanceLabel
            // 
            capacitanceLabel.AutoSize = true;
            capacitanceLabel.Location = new Point(8, 133);
            capacitanceLabel.Name = "capacitanceLabel";
            capacitanceLabel.Size = new Size(50, 15);
            capacitanceLabel.TabIndex = 9;
            capacitanceLabel.Text = "Ємність";
            // 
            // searchButton
            // 
            searchButton.Location = new Point(201, 217);
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
            resistanceLabel.Location = new Point(8, 104);
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
            addButton.Anchor = AnchorStyles.None;
            addButton.Location = new Point(212, 510);
            addButton.Name = "addButton";
            addButton.Size = new Size(110, 30);
            addButton.TabIndex = 17;
            addButton.Text = "Додати";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // changeButton
            // 
            changeButton.Anchor = AnchorStyles.None;
            changeButton.Location = new Point(357, 510);
            changeButton.Name = "changeButton";
            changeButton.Size = new Size(110, 30);
            changeButton.TabIndex = 18;
            changeButton.Text = "Змінити";
            changeButton.UseVisualStyleBackColor = true;
            changeButton.Click += changeButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.Anchor = AnchorStyles.None;
            deleteButton.Location = new Point(492, 510);
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
            dataGridView1.Anchor = AnchorStyles.None;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.BackgroundColor = SystemColors.ControlLightLight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, typeDataGridViewTextBoxColumn, nameDataGridViewTextBoxColumn, resistanceDataGridViewTextBoxColumn, capacitanceDataGridViewTextBoxColumn, inductanceDataGridViewTextBoxColumn, descriptionDataGridViewTextBoxColumn });
            dataGridView1.DataSource = radioComponentBindingSource;
            dataGridView1.Location = new Point(4, 291);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(782, 213);
            dataGridView1.TabIndex = 20;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // typeDataGridViewTextBoxColumn
            // 
            typeDataGridViewTextBoxColumn.DataPropertyName = "Type";
            typeDataGridViewTextBoxColumn.HeaderText = "Тип";
            typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            typeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn.HeaderText = "Назва";
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // resistanceDataGridViewTextBoxColumn
            // 
            resistanceDataGridViewTextBoxColumn.DataPropertyName = "Resistance";
            resistanceDataGridViewTextBoxColumn.HeaderText = "Опір";
            resistanceDataGridViewTextBoxColumn.Name = "resistanceDataGridViewTextBoxColumn";
            resistanceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // capacitanceDataGridViewTextBoxColumn
            // 
            capacitanceDataGridViewTextBoxColumn.DataPropertyName = "Capacitance";
            capacitanceDataGridViewTextBoxColumn.HeaderText = "Ємність";
            capacitanceDataGridViewTextBoxColumn.Name = "capacitanceDataGridViewTextBoxColumn";
            capacitanceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // inductanceDataGridViewTextBoxColumn
            // 
            inductanceDataGridViewTextBoxColumn.DataPropertyName = "Inductance";
            inductanceDataGridViewTextBoxColumn.HeaderText = "Індуктивність";
            inductanceDataGridViewTextBoxColumn.Name = "inductanceDataGridViewTextBoxColumn";
            inductanceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            descriptionDataGridViewTextBoxColumn.HeaderText = "Опис";
            descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // radioComponentBindingSource
            // 
            radioComponentBindingSource.DataSource = typeof(Models.RadioComponent);
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(794, 541);
            Controls.Add(dataGridView1);
            Controls.Add(deleteButton);
            Controls.Add(changeButton);
            Controls.Add(addButton);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            MinimumSize = new Size(810, 580);
            Name = "MainForm";
            Text = "MainForm";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)inductanceNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)resistanceNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)capacitanceNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)idNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
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
        private Label capacitanceLabel;
        private TextBox descriptionTextBox;
        private Label descriptionLabel;
        private Label inductanceLabel;
        private Button addButton;
        private Button changeButton;
        private Button deleteButton;
        private DataGridView dataGridView1;
        private ComboBox typeСomboBox;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn resistanceDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn capacitanceDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn inductanceDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private BindingSource radioComponentBindingSource;
        private ToolStripMenuItem видалитиToolStripMenuItem;
        private ToolStripMenuItem searchToolStripMenuItem;
        private NumericUpDown idNumericUpDown;
        private NumericUpDown resistanceNumericUpDown;
        private NumericUpDown capacitanceNumericUpDown;
        private NumericUpDown inductanceNumericUpDown;
    }
}