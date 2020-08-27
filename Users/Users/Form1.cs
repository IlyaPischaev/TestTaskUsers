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
using System.Xml.Linq;

namespace Users
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        private void Form1_Load(object sender, EventArgs e)
        {

            RefreshGrid();

            labelUserCount.Visible = checkBoxNewParams.Checked;
            labelMiddleSalary.Visible = checkBoxNewParams.Checked;

            textBoxUserCount.Visible = checkBoxNewParams.Checked;
            textBoxMiddleSalary.Visible = checkBoxNewParams.Checked;
        }

        private void buttonAddUser_Click(object sender, EventArgs e)
        {
            FormAddUser formAddUser = new FormAddUser(this);

            formAddUser.Show();
        }

        public void RefreshGrid()
        {
            using (testEntities context = new testEntities())
            {
                dataGridView2.DataSource = context.TableTests.ToList();

                List<TableTest> newList = new List<TableTest>();

                newList = context.TableTests.ToList();

                int sum = 0, workingsUsers = 0;
                double middleSalary;

                foreach (TableTest tableTest in newList)
                {
                    if (tableTest.FireDate == null)
                    {
                        sum += tableTest.Salary;
                        workingsUsers++;
                    }
                }

                middleSalary = sum / workingsUsers;

                textBoxUserCount.Text = workingsUsers.ToString();
                textBoxMiddleSalary.Text = Convert.ToInt32(middleSalary).ToString();
            }
        }

        private void buttonDeleteUser_Click(object sender, EventArgs e)
        {
            int selectedRowCount = dataGridView2.Rows.GetRowCount(DataGridViewElementStates.Selected);

            try
            {
                using (testEntities context = new testEntities())
                {
                    for (int i = 0; i < selectedRowCount; i++)
                    {
                        DataGridViewRow row = dataGridView2.SelectedRows[i];
                        int rowId = Int32.Parse(row.Cells[0].Value.ToString());
                        TableTest forDelete = context.TableTests.FirstOrDefault(u => u.id == rowId);

                        context.TableTests.Remove(forDelete);
                    }

                    context.SaveChanges();
                    RefreshGrid();
                }
            }
            catch (ArgumentOutOfRangeException ex)
            {
                MessageBox.Show("Вы не выбрали сотрудника для удаления");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }         
        }

        private void checkBoxNewParams_CheckedChanged(object sender, EventArgs e)
        {
            labelUserCount.Visible = checkBoxNewParams.Checked;
            labelMiddleSalary.Visible = checkBoxNewParams.Checked;

            textBoxUserCount.Visible = checkBoxNewParams.Checked;
            textBoxMiddleSalary.Visible = checkBoxNewParams.Checked;
        }

        private void buttonNameSearch_Click(object sender, EventArgs e)
        {
            string nameSearchValue = textBoxNameSearch.Text;
            bool rowSelected = false;

            try
            {
                foreach (DataGridViewRow row in dataGridView2.Rows)
                {
                    if (row.Cells[1].Value.ToString().Equals(nameSearchValue))
                    {
                        row.Selected = true;
                        rowSelected = true;
                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            if (!rowSelected)
            {
                MessageBox.Show("Сотрудник не найден");
            }
        }

        private void buttonSurnameSearch_Click(object sender, EventArgs e)
        {
            string surnameSearchValue = textBoxSurnameSearch.Text;
            bool rowSelected = false;

            try
            {
                foreach (DataGridViewRow row in dataGridView2.Rows)
                {
                    if (row.Cells[2].Value.ToString().Equals(surnameSearchValue))
                    {
                        row.Selected = true;
                        rowSelected = true;
                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            if (!rowSelected)
            {
                MessageBox.Show("Сотрудник не найден");
            }
        }

        private void buttonSaveFile_Click(object sender, EventArgs e)
        {
            using (testEntities context = new testEntities())
            {
                List<TableTest> newList = new List<TableTest>();
                newList = context.TableTests.ToList();

                XDocument xdoc = new XDocument(
                    new XDeclaration("1.0", "utf-8", "yes"),
                    new XElement("Workers",
                    from worker in newList
                    select
                        new XElement("Worker", new XAttribute("ID", worker.id),
                        new XElement("Name", worker.Name),
                        new XElement("Surname", worker.Surname),
                        new XElement("ThirdName", worker.ThirdName),
                        new XElement("JobPosition", worker.JobPosition),
                        new XElement("Salary", worker.Salary),
                        new XElement("HireDate", worker.HireDate),
                        new XElement("FireDate", worker.FireDate))));

                saveFileDialog1.Filter = "XML-File | *.xml";

                if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                    return;
                string filename = saveFileDialog1.FileName;

                xdoc.Save(filename);
            }         
        }
    }
}
