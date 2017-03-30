using System;

namespace arrayTest
{
    class Student
    {
        private string surname;
        private int sumb;
        private static Random md = new Random();

        public static Student[] InitAr(Student[] stud)
        {
            for(int i = 0; i < stud.GetLength(0); i++)
            {
                stud[i] = new Student();
            }
            return stud;
        }

        public void SetValue(string surname)
        {
            this.surname = surname;
            sumb = md.Next(20, 99);
        }

        public override string ToString()
        {
            return "Student: " + surname + " " + sumb;
        }
    }
}
