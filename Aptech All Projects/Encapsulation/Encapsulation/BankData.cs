using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
     class BankData
    {
        private int accountNumber;
        private int holderAge;
        private int holderNumber;
        private int totalAmount;
        private int withDrawAmount;
        private string holderName;
        private string accountType;
        private string accountDescription;
        private string accountName;

        public int AccountNumber { get => accountNumber; set => accountNumber = value; }
        public int HolderAge { get => holderAge; set => holderAge = value; }
        public int HolderNumber { get => holderNumber; set => holderNumber = value; }
        public int TotalAmount { get => totalAmount; set => totalAmount = value; }
        public int WithDrawAmount { get => withDrawAmount; set => withDrawAmount = value; }
        public string HolderName { get => holderName; set => holderName = value; }
        public string AccountType { get => accountType; set => accountType = value; }
        public string AccountDescription { get => accountDescription; set => accountDescription = value; }
        public string AccountName { get => accountName; set => accountName = value; }
    }
}
