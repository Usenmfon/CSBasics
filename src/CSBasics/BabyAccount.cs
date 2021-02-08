namespace CSBasics
{
    public class BabyAccount : Account
    {
        public override bool WithdrawFunds (decimal amount)
        {
            if (amount > 10)
            {
                return false;
            }
            return base.WithdrawFunds(amount);
        }
        public override string RudeLetterString()
        {
            return "Tell daddy you are overdrawn";
        }
    }
}