namespace CSBasics
{
    public interface IAccount
    {
        void PayInFunds ( decimal amount);
        bool WithdrawFunds ( decimal amount);
        decimal GetBalance ();
        string GetName();
        string RudeLetterString();
    }
}