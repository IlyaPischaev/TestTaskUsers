namespace Users
{
    partial class FormAddUser
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxSurname = new System.Windows.Forms.TextBox();
            this.textBoxThirdName = new System.Windows.Forms.TextBox();
            this.textBoxJobPosition = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePickerHired = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.checkBoxIsFired = new System.Windows.Forms.CheckBox();
            this.buttonAddUser = new System.Windows.Forms.Button();
            this.dateTimePickerFired = new System.Windows.Forms.DateTimePicker();
            this.labelDateFired = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.numericSalary = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericSalary)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(149, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Данные нового сотрудника";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Имя";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Фамилия";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Отчество";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(116, 34);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(208, 20);
            this.textBoxName.TabIndex = 4;
            // 
            // textBoxSurname
            // 
            this.textBoxSurname.Location = new System.Drawing.Point(116, 61);
            this.textBoxSurname.Name = "textBoxSurname";
            this.textBoxSurname.Size = new System.Drawing.Size(208, 20);
            this.textBoxSurname.TabIndex = 5;
            // 
            // textBoxThirdName
            // 
            this.textBoxThirdName.Location = new System.Drawing.Point(116, 88);
            this.textBoxThirdName.Name = "textBoxThirdName";
            this.textBoxThirdName.Size = new System.Drawing.Size(208, 20);
            this.textBoxThirdName.TabIndex = 6;
            // 
            // textBoxJobPosition
            // 
            this.textBoxJobPosition.Location = new System.Drawing.Point(116, 115);
            this.textBoxJobPosition.Name = "textBoxJobPosition";
            this.textBoxJobPosition.Size = new System.Drawing.Size(208, 20);
            this.textBoxJobPosition.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Должность";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(71, 142);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Оклад";
            // 
            // dateTimePickerHired
            // 
            this.dateTimePickerHired.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerHired.Location = new System.Drawing.Point(116, 168);
            this.dateTimePickerHired.Name = "dateTimePickerHired";
            this.dateTimePickerHired.Size = new System.Drawing.Size(208, 20);
            this.dateTimePickerHired.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(42, 168);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Дата найма";
            // 
            // checkBoxIsFired
            // 
            this.checkBoxIsFired.AutoSize = true;
            this.checkBoxIsFired.Location = new System.Drawing.Point(116, 195);
            this.checkBoxIsFired.Name = "checkBoxIsFired";
            this.checkBoxIsFired.Size = new System.Drawing.Size(64, 17);
            this.checkBoxIsFired.TabIndex = 13;
            this.checkBoxIsFired.Text = "Уволен";
            this.checkBoxIsFired.UseVisualStyleBackColor = true;
            this.checkBoxIsFired.CheckStateChanged += new System.EventHandler(this.checkBoxIsFired_CheckStateChanged);
            // 
            // buttonAddUser
            // 
            this.buttonAddUser.Location = new System.Drawing.Point(325, 359);
            this.buttonAddUser.Name = "buttonAddUser";
            this.buttonAddUser.Size = new System.Drawing.Size(75, 23);
            this.buttonAddUser.TabIndex = 14;
            this.buttonAddUser.Text = "Добавить";
            this.buttonAddUser.UseVisualStyleBackColor = true;
            this.buttonAddUser.Click += new System.EventHandler(this.buttonAddUser_Click);
            // 
            // dateTimePickerFired
            // 
            this.dateTimePickerFired.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerFired.Location = new System.Drawing.Point(116, 218);
            this.dateTimePickerFired.Name = "dateTimePickerFired";
            this.dateTimePickerFired.Size = new System.Drawing.Size(208, 20);
            this.dateTimePickerFired.TabIndex = 15;
            // 
            // labelDateFired
            // 
            this.labelDateFired.AutoSize = true;
            this.labelDateFired.Location = new System.Drawing.Point(15, 218);
            this.labelDateFired.Name = "labelDateFired";
            this.labelDateFired.Size = new System.Drawing.Size(95, 13);
            this.labelDateFired.TabIndex = 16;
            this.labelDateFired.Text = "Дата увольнения";
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(18, 359);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 17;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // numericSalary
            // 
            this.numericSalary.Location = new System.Drawing.Point(116, 142);
            this.numericSalary.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.numericSalary.Name = "numericSalary";
            this.numericSalary.Size = new System.Drawing.Size(208, 20);
            this.numericSalary.TabIndex = 18;
            // 
            // FormAddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 394);
            this.Controls.Add(this.numericSalary);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.labelDateFired);
            this.Controls.Add(this.dateTimePickerFired);
            this.Controls.Add(this.buttonAddUser);
            this.Controls.Add(this.checkBoxIsFired);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dateTimePickerHired);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxJobPosition);
            this.Controls.Add(this.textBoxThirdName);
            this.Controls.Add(this.textBoxSurname);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormAddUser";
            this.Text = "FormAddUser";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormAddUser_FormClosing);
            this.Load += new System.EventHandler(this.FormAddUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericSalary)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxSurname;
        private System.Windows.Forms.TextBox textBoxThirdName;
        private System.Windows.Forms.TextBox textBoxJobPosition;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimePickerHired;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox checkBoxIsFired;
        private System.Windows.Forms.Button buttonAddUser;
        private System.Windows.Forms.DateTimePicker dateTimePickerFired;
        private System.Windows.Forms.Label labelDateFired;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.NumericUpDown numericSalary;
    }
}