namespace CSBasics
{
    public class CustomerAccount : Account
    {
        public override string RudeLetterString()
        {
            return "You are overdrawn";
        }
    }
}