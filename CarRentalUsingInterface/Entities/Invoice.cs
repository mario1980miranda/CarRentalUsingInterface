using System.Globalization;

namespace CarRentalUsingInterface.Entities
{
    class Invoice
    {
        public double BasicPayment { get; set; }
        public double Tax { get; set; }

        public Invoice(double basicPayment, double tax)
        {
            BasicPayment = basicPayment;
            Tax = tax;
        }

        public double TotalPayment
        {
            get { return BasicPayment + Tax; }
        }

        public override string ToString()
        {
            return "Paiement de base: "
                + BasicPayment.ToString("F2", CultureInfo.InvariantCulture)
                + "\nTarif: "
                + Tax.ToString("F2", CultureInfo.InvariantCulture)
                + "\nPaiement total: "
                + TotalPayment.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
