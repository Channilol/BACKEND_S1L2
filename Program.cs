using System.Reflection.Metadata.Ecma335;
using System.Text.RegularExpressions;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona pippo = new Persona();
            pippo.GetName();
            pippo.GetSurname();
            pippo.GetAge();
            pippo.GetHobbies();

            while (pippo.Hobbies == "")
            {
                Console.WriteLine("Devi scrivere qualcosa per andare avanti!");
                pippo.GetHobbies();
            }

            pippo.GetDetails();

            Console.WriteLine("Premere due volte il tasto invio per chiudere il programma");
            Console.ReadLine();
        }
    }

    class Persona
    {
        private string _name, _surname, _hobbies;
        private byte _age;
        public string Name 
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }
        public string Surname
        {
            get
            {
                return _surname;
            }
            set
            {
                _surname = value;
            }
        }
        public byte Age
        {
            get
            {
                return _age;
            }
            set
            {
                _age = value;
            }
        }

        public string Hobbies
        {
            get
            {
                return _hobbies;
            }
            set
            {
                _hobbies = value;
            }
        }

        public void GetName()
        {
            Console.WriteLine("Scrivi il nome della persona: ");
            string input = Console.ReadLine();

            if(input.All(char.IsLetter) && !string.IsNullOrWhiteSpace(input))
            {
                _name = input;
            }
            else
            {
                Console.WriteLine("Scrivi un nome vero!");
                GetName(); 
            }
        }

        public void GetSurname()
        {
            Console.WriteLine("Scrivi il cognome della persona: ");
            string input = Console.ReadLine();

            if (input.All(char.IsLetter) && !string.IsNullOrWhiteSpace(input))
            {
                _surname = input;
            }
            else
            {
                Console.WriteLine("Scrivi un cognome vero!");
                GetSurname();
            }
        }

        public void GetAge()
        {
            Console.WriteLine("Scrivi l'età della persona: ");
            string input = Console.ReadLine();

            bool ageString = byte.TryParse(input, out byte age);
            if (ageString && age > 0 && age < 110)
            {
                _age = age;
            }
            else
            {
                Console.WriteLine("Scrivi un'età vera!");
                GetAge();
            }
        }

        public void GetHobbies()
        {
            Console.WriteLine("Scrivi degli hobby della persona: ");
            _hobbies = Console.ReadLine(); 
        }

        public void GetDetails()
        {
            Console.WriteLine($"Questi sono i dettagli della persona: \n Nome: {Name} \n Cognome: {Surname} \n Età: {Age} \n Hobbies: {Hobbies} \n");
        }
    }
}
