namespace CSBasics
{
    public class BabyAccount : CustomerAccount, IAccount
    {
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