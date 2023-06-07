using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2
{
    public class Student
    {
        //property
        /*public int getsetID  
        {
            get { return id; }
            set { id = value; }
        }*/



        public int ID { get; set; } //Cach viet tat setter getter cho Id trong C#, day vua dung lam 

        public String Name { get; set; } //Cach viet tat setter getter cho name trong C#

        public Student()
                {
                }

        public Student(int iD, string name)
        {
            ID = iD;
            Name = name;
        }

        public virtual void Display()
        {
            Console.WriteLine("Student ID: " + ID + ", Name: " +  Name);
        }

        public virtual void Input()
        {
            Console.WriteLine("Nhap vao ID: ");
            ID = Convert.ToInt32(Console.ReadLine()); //Readline tra String nen phai conver ve
            Console.WriteLine("Nhap vao ten: ");
            Name = Console.ReadLine();
        }

        public override bool Equals(object? obj)
        {
            return obj is Student student &&
                   ID == student.ID &&
                   Name == student.Name;
        }
    }

    class SEStudent : Student
    {
        public SEStudent()
        {
        }

        public string skill { get; set; }



        /*public SEStudent(int id, string name , string skill) //Cach 1
        {
            ID = id;
            Name = name;
            this.skill = skill;
        }*/

        //Cach 2
        public SEStudent(int id, string name, string skill):base(id,name) // goi constructor cua lop cha
        {
            this.skill = skill;
        }

        //Phai them override o lop con va virtual o lop cha thi moi override duoc
        public override void Display() 
        {
            base.Display();
            /*Console.WriteLine("Skill: " + skill);*/
            Console.WriteLine($"Skill: {skill}");
        }

        public override void Input()
        {
            base.Input();
            Console.WriteLine("Nhap skill: ");
            skill = Console.ReadLine();
        }
    }
}
