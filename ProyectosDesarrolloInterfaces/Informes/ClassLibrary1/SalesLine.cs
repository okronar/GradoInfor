namespace ClassLibrary1
{
    public class SalesLine
    {
        public String CustAccount { get; set; }
        public String CustName { get; set; }
        public String ItemId { get; set; }
        public String Description { get; set; }
        public Decimal Qty { get; set; }

        public Decimal UnitPrice { get; set; }
        public Decimal TotalPrice { get; set; }
    }
}
