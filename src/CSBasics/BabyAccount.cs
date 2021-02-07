namespace CSBasics
{
    public class BabyAccount : CustomerAccount, IAccount
    {
        private decimal balance = 0;
        public override bool WithdrawFunds (decimal amount)
        {
            if (amount > 10)
            {
                return false;
            }
            if (balance < amount)
            {
                return false;
            }
            balance = balance - amount;
            return true;
        }
    }
}