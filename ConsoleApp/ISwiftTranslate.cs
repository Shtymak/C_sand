
using System;

namespace ConsoleApp
{
    public interface ISwiftTranslate
    {
        public int Id { get; set; }
        public string IbanNumber { get; set; }
        public IAccountHolder AccountHolder { get; set; }
        public int Amount { get; set; }
        public CurrencyType Currency { get; set; } 
        public int FeeAmount { get; set; }
        public DateTime PaymentDate { get; set; }
    }
}