using Q2.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Q2
{
    public partial class Form1 : Form
    {
        PE_PRN_Sum21Context context;
        public Form1()
        {
            InitializeComponent();
            context = new PE_PRN_Sum21Context();
            bindGrid();

        }
         void bindGrid()
        {
            dataGridView1.DataSource = context.Employees.ToList();
            dataGridView1.Columns["Contracts"].Visible = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Employee employee = new Employee
            {
                EmployeeName = txtEmployeeName.Text,
                Male = rdoMale.Checked,
                Salary = (float) nudSalary.Value,
                Phone = txtPhone.Text

            };
            try
            {
                context.Employees.Add(employee);
                context.SaveChanges();
                MessageBox.Show("Added!");
                bindGrid(); 
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int employeeId = (int) dataGridView1.Rows[e.RowIndex].Cells["EmployeeId"].Value;
            Employee employee = context.Employees.Find(employeeId);
            txtEmployeeName.Text = employee.EmployeeName;
            rdoMale.Checked = employee.Male;
            rdoFemale.Checked = !employee.Male;
            nudSalary.Value = (decimal) employee.Salary;
            txtPhone.Text = employee.Phone;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count < 1) return;

            int employeeId = (int) dataGridView1.SelectedRows[0].Cells["EmployeeId"].Value;

            Employee employee = context.Employees.Find(employeeId);
            employee.EmployeeName = txtEmployeeName.Text;
            employee.Male = rdoMale.Checked;
            employee.Salary = (float) nudSalary.Value;
            employee.Phone = txtPhone.Text;

            try
            {
                context.Employees.Update(employee);
                context.SaveChanges();
                MessageBox.Show("Updated!");
                bindGrid();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count < 1) return;

            int employeeId = (int)dataGridView1.SelectedRows[0].Cells["EmployeeId"].Value;

            Employee employee = context.Employees.Find(employeeId);
     

            try
            {
                context.Employees.Remove(employee);
                context.SaveChanges();
                MessageBox.Show("Deleted!");
                bindGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
