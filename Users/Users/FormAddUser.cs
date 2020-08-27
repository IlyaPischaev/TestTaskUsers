using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace Users
{
    public partial class FormAddUser : Form
    {
        private readonly Form1 mainForm1;
        public FormAddUser()
        {
            InitializeComponent();
        }

        public FormAddUser(Form1 mainForm)
        {
            InitializeComponent();

            mainForm1 = mainForm;
        }

        private void checkBoxIsFired_CheckStateChanged(object sender, EventArgs e)
        {
            dateTimePickerFired.Enabled = checkBoxIsFired.Checked;
            dateTimePickerFired.Visible = checkBoxIsFired.Checked;
            labelDateFired.Visible = checkBoxIsFired.Checked;
        }

        private void FormAddUser_Load(object sender, EventArgs e)
        {
            dateTimePickerFired.Enabled = checkBoxIsFired.Checked;
            dateTimePickerFired.Visible = checkBoxIsFired.Checked;
            labelDateFired.Visible = checkBoxIsFired.Checked;
        }

        private void buttonAddUser_Click(object sender, EventArgs e)
        {
            try
            {
                string name = textBoxName.Text;
                string surname = textBoxSurname.Text;
                string thirdName = textBoxThirdName.Text;
                string jobPosition = textBoxJobPosition.Text;
                int salary = Decimal.ToInt32(numericSalary.Value);

                DateTime hireDate = dateTimePickerFired.Value.Date;
                Nullable<DateTime> fireDate;

                if (checkBoxIsFired.Checked)
                {
                    fireDate = dateTimePickerFired.Value.Date;
                }
                else
                {
                    fireDate = null;
                }

                TableTest newUser = new TableTest
                {
                    Name = name,
                    Surname = surname,
                    ThirdName = thirdName,
                    JobPosition = jobPosition,
                    Salary = salary,
                    HireDate = hireDate,
                    FireDate = fireDate
                };

                using (testEntities context = new testEntities())
                {
                    context.TableTests.Add(newUser);
                    context.SaveChanges();
                }
            }
            catch when (ContainInappropriateSymbols(textBoxName))
            {
                MessageBox.Show("Введенноё имя не соответствует требованиям");
            }
            catch when (ContainInappropriateSymbols(textBoxSurname))
            {
                MessageBox.Show("Введенная фамилия не соответствует требованиям");
            }
            catch when (ContainInappropriateSymbols(textBoxThirdName))
            {
                MessageBox.Show("Введенноё отчество не соответствует требованиям");
            }
            catch when (ContainInappropriateSymbols(textBoxJobPosition))
            {
                MessageBox.Show("Введенная должность не соответствует требованиям");
            }

            /*
            string name = textBoxName.Text;
            string surname = textBoxSurname.Text;
            string thirdName = textBoxThirdName.Text;
            string jobPosition = textBoxJobPosition.Text;
            int salary = Decimal.ToInt32(numericSalary.Value);

            DateTime hireDate = dateTimePickerFired.Value.Date;
            Nullable<DateTime> fireDate;

            if (checkBoxIsFired.Checked)
            {
                fireDate = dateTimePickerFired.Value.Date;
            }
            else
            {
                fireDate = null;
            }

            TableTest newUser = new TableTest
            {
                Name = name,
                Surname = surname,
                ThirdName = thirdName,
                JobPosition = jobPosition,
                Salary = salary,
                HireDate = hireDate,
                FireDate = fireDate
            };
                     
            using (testEntities context = new testEntities())
            {
                context.TableTests.Add(newUser);
                context.SaveChanges();
            }
            */

            /*
            try
            {

            }
            */

            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormAddUser_FormClosing(object sender, FormClosingEventArgs e)
        {
            mainForm1.RefreshGrid();
        }

        private bool ContainInappropriateSymbols (TextBox textBox)
        {
            string digits = "123456789!#$%&'*+-/=?^_`{|}~";

            if (textBox.Text.Contains(digits)) return true;
            return false;
        }
    }
}
