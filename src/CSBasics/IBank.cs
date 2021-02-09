namespace CSBasics
{
    public interface IBank
    {
        IAccount FindAcount (string name);
        bool StoreAccount (IAccount account);
    }
}