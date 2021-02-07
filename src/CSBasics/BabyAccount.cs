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
            return base.WithdrawFunds(amount);
        }
    }
}