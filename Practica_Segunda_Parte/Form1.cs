using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_Segunda_Parte
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns.Add("idStudents", "Codigo");
            dataGridView1.Columns.Add("firstName", "Nombre");
            dataGridView1.Columns.Add("lastName", "Apellido");
            dataGridView1.Columns.Add("age", "Edad");
            dataGridView1.Columns.Add("gender", "Genero");
            foreach(var student in selectAllData())
            {
                dataGridView1.Rows.Add(student.idStudent, student.firstName, student.lastName, student.age,student.gender);
            }
        }
        private List<Student> selectAllData()
        {
            List<Student> result = (
                                 from student in Student.GetStudents()
                                 select new Student()
                                 {
                                     idStudent = student.idStudent,
                                     firstName = student.firstName,
                                     lastName = student.lastName,
                                     age = student.age,
                                     gender=student.gender
                                 }
                ).ToList();
                return result;
        }
    }
}
