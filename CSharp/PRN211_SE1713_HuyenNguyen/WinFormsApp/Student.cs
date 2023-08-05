namespace WinFormsApp
{
    public class Student
    {
        public String Code { get; set; }
        public String Name { get; set; }
        public String Subject { get; set; }
        public int Mark { get; set; }

        public Student()
        {

        }

        public Student(string code, string name, string subject, int mark)
        {
            Code = code;
            Name = name;
            Subject = subject;
            Mark = mark;
        }

        public override string? ToString()
        {
            return Code + "\t" + Name + "\t" + Subject + "\t" + Mark;
        }
    }
}