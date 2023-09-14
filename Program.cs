using System.Runtime.CompilerServices;

namespace csharp_lista_indirizzi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Address> addresses = new List<Address>();

            try
            {
                StreamReader fileAddress = File.OpenText("C:\\Users\\Cinzia\\source\\repos\\csharp-lista-indirizzi\\my-addresses.csv");

                int lineNumber = 0;

                while (!fileAddress.EndOfStream)
                {
                    string line = fileAddress.ReadLine();

                    lineNumber++;

                    if (lineNumber > 1)
                    {

                        string[] stringSplits = line.Split(',');

                        if(stringSplits.Length == 6)
                        {
                            string name = stringSplits[0].TrimStart(' ');
                            string surname = stringSplits[1];
                            string street = stringSplits[2];
                            string city = stringSplits[3];
                            string province = stringSplits[4];
                            string ZIP = stringSplits[5];

                            Address newAddress = new Address(name, surname, street, city, province, ZIP);

                            Console.WriteLine(newAddress.ToString());
                        }
                        else
                        {
                            Console.WriteLine("Indirizzo non valido");
                        }
                    }
                }

                fileAddress.Close();
            } catch
            {
                Console.WriteLine("Ops! Qualcosa è andato storto! :(");
            }
        }
    }
}