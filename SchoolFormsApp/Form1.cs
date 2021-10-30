using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchoolLibrary;
using System.Windows.Forms;

namespace SchoolFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void submitBtn_Click(object sender, EventArgs e)
        {

            School testSchool = new School();
            testSchool.Name = txtName.Text;
            testSchool.Address = txtAddress.Text;
            testSchool.City = txtCity.Text;
            testSchool.State = txtState.Text;
            testSchool.Zip = txtZip.Text;
            testSchool.PhoneNumber = txtPhone.Text;
            
            try { 
            testSchool.TwitterAddress = txtTwitter.Text;
            } catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }

            MessageBox.Show(testSchool.ToString());

            Teacher teacher = new Teacher();
            Student student = new Student();
            

        }

        private void textZip_TextChanged(object sender, EventArgs e)
        {

        }

        private void textPhone_TextChanged(object sender, EventArgs e)
        {

        }

        private void textTwitter_TextChanged(object sender, EventArgs e)
        {

        }

        private void textState_TextChanged(object sender, EventArgs e)
        {

        }

        private void textCity_TextChanged(object sender, EventArgs e)
        {

        }

        private void textName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnTestStudent_Click(object sender, EventArgs e)
        {
            Student student = new Student();
            var gradePointStudent = student.ComputeGradeAverage();
            MessageBox.Show($"The student's grade average is {gradePointStudent}");
        }

        private void btnTestTeacher_Click(object sender, EventArgs e)
        {
            Teacher teacher = new Teacher();
            var gradePointTeacher = teacher.ComputeGradeAverage();
            MessageBox.Show($"The teacher's grade average is {gradePointTeacher}");
        }
    }
}
