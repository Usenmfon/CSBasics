namespace CSBasics
{
    public class CustomerAccount : IAccount
    {
        private decimal balance = 0;
        public bool WithdrawFunds (decimal amount)
        {
            if (balance < amount)
            {
                return false;
            }
            balance = balance - amount;
            return true;
        }
        public void PayInFunds (decimal amount)
        {
            balance = balance + amount;
        }
        public decimal GetBalance ()
        {
            return balance;
        }
    }
}