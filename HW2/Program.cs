using System;
using System.Text;

namespace MyApp 
{
    internal class Program
    {
        static void Main()
        {
            User TheBoyWhoLived = new();

            TheBoyWhoLived.userinit(57, "Harry", "Potter");

            Console.WriteLine(TheBoyWhoLived.GetFullNameAndId());
        }
        class User
        {
            public int id = -1;
            string name = "Undefined";
            string surname = "Undefined";

            public void userinit(int id,string name,string surname)
            {
                this.id = id;
                this.name = name;
                this.surname = surname;
            }

            public string GetFullNameAndId()
            {
                var nameid = new StringBuilder();

                nameid.Append(name);
                nameid.Append(" ");
                nameid.Append(surname);
                nameid.Append(" c ID=");
                nameid.Append(id);

                return nameid.ToString();
            }
        }
    }
}