using ConsoleApp1.sarah;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Client client = new Client("sarah", "bali", "sata.gghh@gmail.com", "1556", 522);
            Hotel hotel= new Hotel();
            hotel.AjouterClient(client);
            Console.WriteLine("les clients sont :"+client.ToString );

            
        }
    }
}