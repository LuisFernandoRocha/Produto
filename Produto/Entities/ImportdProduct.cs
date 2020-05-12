
namespace Produto.Entities
{
    class ImportdProduct : Product
    {
        public double CustomsFee { get; set; }

        public ImportdProduct()
        {
        }

        public ImportdProduct(string name, double price, double customsFree)
             : base(name, price)
        {
            CustomsFee = customsFree;
        }

        public double TotalPrice()
        {
            return Price + CustomsFee;
        }
        public override string PriceTag()

        {
            return Name
                   + " $ "
                   + TotalPrice().ToString("F2", System.Globalization.CultureInfo.InvariantCulture)
                   + " (Customs fee: $ "
                   + CustomsFee.ToString("F2", System.Globalization.CultureInfo.InvariantCulture)
                   + ")";
        }
    
  
    }
}
