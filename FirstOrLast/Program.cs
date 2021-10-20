using System;

namespace FirstOrLast
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajal sisestada ees- ja perekonnanime
            //programm kontrollib andmete pikkust
            //programm kuvab kumb nendest on pikem, kas ees- või perekonnanimi

            Console.WriteLine("Sisesta eesnimi:");
            string firstName = Console.ReadLine();
            Console.WriteLine("Sisesta perekonnanimi:");
            string lastName = Console.ReadLine();

            int firstNameLenght = firstName.Length;
            int lastNameLenght = lastName.Length;

            if(firstNameLenght > lastNameLenght)
            {
                Console.WriteLine("Eesnimi on pikem.");
            }
            else if(lastNameLenght > firstNameLenght)
            {
                Console.WriteLine("Perekonnanimi on pikem");
            }
            else
            {
                Console.WriteLine("Ees- ja perekonnanimi on võrdse pikkusega.");
            }
        }
    }
}
