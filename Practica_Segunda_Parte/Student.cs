using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_Segunda_Parte
{
    class Student
    {
        public int idStudent { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public int age { get; set; }
        public string gender { get; set; }
        public static List<Student> GetStudents()
        {
            List<Student> students = new List<Student>
            {
                new Student{idStudent=1001,firstName="Ana",lastName="Florez",age=22,gender="Femenino"},
                new Student{idStudent=1002,firstName="Sofia",lastName="Lopez",age=25,gender="Femenino"},
                new Student{idStudent=1003,firstName="Rafael",lastName="Gonzales",age=20,gender="Masculino"},
                new Student{idStudent=1004,firstName="Donato",lastName="Cruz",age=19,gender="Masculino"},
                new Student{idStudent=1005,firstName="Emilio",lastName="Campos",age=22,gender="Masculino"},
                new Student{idStudent=1006,firstName="Alfredo",lastName="Lainez",age=21,gender="Masculino"},
                new Student{idStudent=1007,firstName="Amanda",lastName="Ramirez",age=22,gender="Femenino"},
                
            };
            return students;
                
        }
        
    }
}
