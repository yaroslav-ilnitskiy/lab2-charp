using System;

namespace lab3
{
    public class Contact
    {
        private string name;
        private string personalPhone;
        private string phone;
        private string description;

        public Contact(string name)
        {
            this.Name = name;
        }

        public string Description { get => description; set => description = value; }
        public string Phone { get => phone; set => phone = value; }
        public string PersonalPhone { get => personalPhone; set => personalPhone = value; }
        public string Name { get => name; set => name = value; }

        ~Contact()
        {
            Console.WriteLine("Contact " + this.Name + " removed");
        }
    }
}
