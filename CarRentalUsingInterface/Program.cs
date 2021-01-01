using System;
using System.Globalization;
using CarRentalUsingInterface.Entities;
using CarRentalUsingInterface.Services;

namespace CarRentalUsingInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entrez avec les données de location.");
            Console.Write("Modele de la voiture: ");
            string model = Console.ReadLine();
            Console.Write("Temps pick-up (yyyy/MM/dd HH:mm): ");
            DateTime start = DateTime.ParseExact(Console.ReadLine(), "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture);
            Console.Write("Heure du retour (yyyy/MM/dd HH:mm): ");
            DateTime finish = DateTime.ParseExact(Console.ReadLine(), "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture);

            Console.Write("Entrez coût par heure: ");
            double hourPrice = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Entrez coût par jour: ");
            double jourPrice = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            CarRental carRental = new CarRental(start, finish, new Vehicle(model));

            RentalService rentalService = new RentalService(hourPrice, jourPrice, new BrazilTaxService());
            rentalService.ProcessInvoice(carRental);

            Console.WriteLine("FACTURE");
            Console.WriteLine(carRental.Invoice);
        }
    }
}
