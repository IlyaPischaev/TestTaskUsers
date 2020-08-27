namespace Users
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonAddUser = new System.Windows.Forms.Button();
            this.buttonDeleteUser = new System.Windows.Forms.Button();
            this.checkBoxNewParams = new System.Windows.Forms.CheckBox();
            this.labelUserCount = new System.Windows.Forms.Label();
            this.textBoxUserCount = new System.Windows.Forms.TextBox();
            this.textBoxMiddleSalary = new System.Windows.Forms.TextBox();
            this.labelMiddleSalary = new System.Windows.Forms.Label();
            this.textBoxSurnameSearch = new System.Windows.Forms.TextBox();
            this.textBoxNameSearch = new System.Windows.Forms.TextBox();
            this.buttonNameSearch = new System.Windows.Forms.Button();
            this.buttonSurnameSearch = new System.Windows.Forms.Button();
            this.buttonSaveFile = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thirdNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jobPositionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salaryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hireDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fireDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableTestBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableTestBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.surnameDataGridViewTextBoxColumn,
            this.thirdNameDataGridViewTextBoxColumn,
            this.jobPositionDataGridViewTextBoxColumn,
            this.salaryDataGridViewTextBoxColumn,
            this.hireDateDataGridViewTextBoxColumn,
            this.fireDateDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.tableTestBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(12, 170);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(776, 268);
            this.dataGridView2.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Snow;
            this.textBox1.Location = new System.Drawing.Point(13, 144);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(111, 20);
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = "Список сотрудников";
            // 
            // buttonAddUser
            // 
            this.buttonAddUser.Location = new System.Drawing.Point(13, 11);
            this.buttonAddUser.Name = "buttonAddUser";
            this.buttonAddUser.Size = new System.Drawing.Size(140, 23);
            this.buttonAddUser.TabIndex = 5;
            this.buttonAddUser.Text = "Добавить сотрудника";
            this.buttonAddUser.UseVisualStyleBackColor = true;
            this.buttonAddUser.Click += new System.EventHandler(this.buttonAddUser_Click);
            // 
            // buttonDeleteUser
            // 
            this.buttonDeleteUser.Location = new System.Drawing.Point(13, 41);
            this.buttonDeleteUser.Name = "buttonDeleteUser";
            this.buttonDeleteUser.Size = new System.Drawing.Size(140, 23);
            this.buttonDeleteUser.TabIndex = 6;
            this.buttonDeleteUser.Text = "Удалить сотрудника";
            this.buttonDeleteUser.UseVisualStyleBackColor = true;
            this.buttonDeleteUser.Click += new System.EventHandler(this.buttonDeleteUser_Click);
            // 
            // checkBoxNewParams
            // 
            this.checkBoxNewParams.AutoSize = true;
            this.checkBoxNewParams.Location = new System.Drawing.Point(353, 11);
            this.checkBoxNewParams.Name = "checkBoxNewParams";
            this.checkBoxNewParams.Size = new System.Drawing.Size(165, 17);
            this.checkBoxNewParams.TabIndex = 8;
            this.checkBoxNewParams.Text = "Дополнительные сведения";
            this.checkBoxNewParams.UseVisualStyleBackColor = true;
            this.checkBoxNewParams.CheckedChanged += new System.EventHandler(this.checkBoxNewParams_CheckedChanged);
            // 
            // labelUserCount
            // 
            this.labelUserCount.AutoSize = true;
            this.labelUserCount.Location = new System.Drawing.Point(350, 34);
            this.labelUserCount.Name = "labelUserCount";
            this.labelUserCount.Size = new System.Drawing.Size(133, 13);
            this.labelUserCount.TabIndex = 9;
            this.labelUserCount.Text = "Количество сотрудников";
            // 
            // textBoxUserCount
            // 
            this.textBoxUserCount.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBoxUserCount.Location = new System.Drawing.Point(489, 27);
            this.textBoxUserCount.Name = "textBoxUserCount";
            this.textBoxUserCount.ReadOnly = true;
            this.textBoxUserCount.Size = new System.Drawing.Size(100, 20);
            this.textBoxUserCount.TabIndex = 10;
            // 
            // textBoxMiddleSalary
            // 
            this.textBoxMiddleSalary.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBoxMiddleSalary.Location = new System.Drawing.Point(489, 66);
            this.textBoxMiddleSalary.Name = "textBoxMiddleSalary";
            this.textBoxMiddleSalary.ReadOnly = true;
            this.textBoxMiddleSalary.Size = new System.Drawing.Size(100, 20);
            this.textBoxMiddleSalary.TabIndex = 11;
            // 
            // labelMiddleSalary
            // 
            this.labelMiddleSalary.AutoSize = true;
            this.labelMiddleSalary.Location = new System.Drawing.Point(350, 66);
            this.labelMiddleSalary.Name = "labelMiddleSalary";
            this.labelMiddleSalary.Size = new System.Drawing.Size(106, 13);
            this.labelMiddleSalary.TabIndex = 12;
            this.labelMiddleSalary.Text = "Средняя зарпллата";
            // 
            // textBoxSurnameSearch
            // 
            this.textBoxSurnameSearch.Location = new System.Drawing.Point(595, 144);
            this.textBoxSurnameSearch.Name = "textBoxSurnameSearch";
            this.textBoxSurnameSearch.Size = new System.Drawing.Size(180, 20);
            this.textBoxSurnameSearch.TabIndex = 13;
            // 
            // textBoxNameSearch
            // 
            this.textBoxNameSearch.Location = new System.Drawing.Point(426, 144);
            this.textBoxNameSearch.Name = "textBoxNameSearch";
            this.textBoxNameSearch.Size = new System.Drawing.Size(163, 20);
            this.textBoxNameSearch.TabIndex = 14;
            // 
            // buttonNameSearch
            // 
            this.buttonNameSearch.Location = new System.Drawing.Point(426, 115);
            this.buttonNameSearch.Name = "buttonNameSearch";
            this.buttonNameSearch.Size = new System.Drawing.Size(163, 23);
            this.buttonNameSearch.TabIndex = 15;
            this.buttonNameSearch.Text = "Поиск сотрудника по имени";
            this.buttonNameSearch.UseVisualStyleBackColor = true;
            this.buttonNameSearch.Click += new System.EventHandler(this.buttonNameSearch_Click);
            // 
            // buttonSurnameSearch
            // 
            this.buttonSurnameSearch.Location = new System.Drawing.Point(595, 115);
            this.buttonSurnameSearch.Name = "buttonSurnameSearch";
            this.buttonSurnameSearch.Size = new System.Drawing.Size(180, 23);
            this.buttonSurnameSearch.TabIndex = 16;
            this.buttonSurnameSearch.Text = "Поиск сотрудника по фамилии";
            this.buttonSurnameSearch.UseVisualStyleBackColor = true;
            this.buttonSurnameSearch.Click += new System.EventHandler(this.buttonSurnameSearch_Click);
            // 
            // buttonSaveFile
            // 
            this.buttonSaveFile.Location = new System.Drawing.Point(615, 5);
            this.buttonSaveFile.Name = "buttonSaveFile";
            this.buttonSaveFile.Size = new System.Drawing.Size(173, 23);
            this.buttonSaveFile.TabIndex = 17;
            this.buttonSaveFile.Text = "Сохранить данные в виде XML файла";
            this.buttonSaveFile.UseVisualStyleBackColor = true;
            this.buttonSaveFile.Click += new System.EventHandler(this.buttonSaveFile_Click);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Имя";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Width = 54;
            // 
            // surnameDataGridViewTextBoxColumn
            // 
            this.surnameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.surnameDataGridViewTextBoxColumn.DataPropertyName = "Surname";
            this.surnameDataGridViewTextBoxColumn.HeaderText = "Фамилия";
            this.surnameDataGridViewTextBoxColumn.Name = "surnameDataGridViewTextBoxColumn";
            this.surnameDataGridViewTextBoxColumn.ReadOnly = true;
            this.surnameDataGridViewTextBoxColumn.Width = 81;
            // 
            // thirdNameDataGridViewTextBoxColumn
            // 
            this.thirdNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.thirdNameDataGridViewTextBoxColumn.DataPropertyName = "ThirdName";
            this.thirdNameDataGridViewTextBoxColumn.HeaderText = "Отчество";
            this.thirdNameDataGridViewTextBoxColumn.Name = "thirdNameDataGridViewTextBoxColumn";
            this.thirdNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.thirdNameDataGridViewTextBoxColumn.Width = 79;
            // 
            // jobPositionDataGridViewTextBoxColumn
            // 
            this.jobPositionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.jobPositionDataGridViewTextBoxColumn.DataPropertyName = "JobPosition";
            this.jobPositionDataGridViewTextBoxColumn.HeaderText = "Должность";
            this.jobPositionDataGridViewTextBoxColumn.Name = "jobPositionDataGridViewTextBoxColumn";
            this.jobPositionDataGridViewTextBoxColumn.ReadOnly = true;
            this.jobPositionDataGridViewTextBoxColumn.Width = 90;
            // 
            // salaryDataGridViewTextBoxColumn
            // 
            this.salaryDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.salaryDataGridViewTextBoxColumn.DataPropertyName = "Salary";
            this.salaryDataGridViewTextBoxColumn.HeaderText = "Оклад";
            this.salaryDataGridViewTextBoxColumn.Name = "salaryDataGridViewTextBoxColumn";
            this.salaryDataGridViewTextBoxColumn.ReadOnly = true;
            this.salaryDataGridViewTextBoxColumn.Width = 64;
            // 
            // hireDateDataGridViewTextBoxColumn
            // 
            this.hireDateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.hireDateDataGridViewTextBoxColumn.DataPropertyName = "HireDate";
            this.hireDateDataGridViewTextBoxColumn.HeaderText = "Дата найма";
            this.hireDateDataGridViewTextBoxColumn.Name = "hireDateDataGridViewTextBoxColumn";
            this.hireDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.hireDateDataGridViewTextBoxColumn.Width = 86;
            // 
            // fireDateDataGridViewTextBoxColumn
            // 
            this.fireDateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.fireDateDataGridViewTextBoxColumn.DataPropertyName = "FireDate";
            this.fireDateDataGridViewTextBoxColumn.HeaderText = "Дата увольнения";
            this.fireDateDataGridViewTextBoxColumn.Name = "fireDateDataGridViewTextBoxColumn";
            this.fireDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.fireDateDataGridViewTextBoxColumn.Width = 110;
            // 
            // tableTestBindingSource
            // 
            this.tableTestBindingSource.DataSource = typeof(Users.TableTest);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonSaveFile);
            this.Controls.Add(this.buttonSurnameSearch);
            this.Controls.Add(this.buttonNameSearch);
            this.Controls.Add(this.textBoxNameSearch);
            this.Controls.Add(this.textBoxSurnameSearch);
            this.Controls.Add(this.labelMiddleSalary);
            this.Controls.Add(this.textBoxMiddleSalary);
            this.Controls.Add(this.textBoxUserCount);
            this.Controls.Add(this.labelUserCount);
            this.Controls.Add(this.checkBoxNewParams);
            this.Controls.Add(this.buttonDeleteUser);
            this.Controls.Add(this.buttonAddUser);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableTestBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource tableTestBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn surnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn thirdNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jobPositionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salaryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hireDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fireDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonAddUser;
        private System.Windows.Forms.Button buttonDeleteUser;
        private System.Windows.Forms.CheckBox checkBoxNewParams;
        private System.Windows.Forms.Label labelUserCount;
        private System.Windows.Forms.TextBox textBoxUserCount;
        private System.Windows.Forms.TextBox textBoxMiddleSalary;
        private System.Windows.Forms.Label labelMiddleSalary;
        private System.Windows.Forms.TextBox textBoxSurnameSearch;
        private System.Windows.Forms.TextBox textBoxNameSearch;
        private System.Windows.Forms.Button buttonNameSearch;
        private System.Windows.Forms.Button buttonSurnameSearch;
        private System.Windows.Forms.Button buttonSaveFile;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

