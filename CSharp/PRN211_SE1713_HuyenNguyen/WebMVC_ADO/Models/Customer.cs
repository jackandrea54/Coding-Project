namespace WebMVC_ADO.Models
{
    public class Customer
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Gender { get; set; }
        public string Dob { get; set; }

        public Customer()
        {

        }

        public Customer(string iD, string name, string dob, string gender, string address)
        {
            ID = iD;
            Name = name;
            Address = address;
            Gender = gender;
            Dob = dob;
        }
    }
}