namespace FactoryMethod;

public interface CreditCard
{
    string GetCardType();
    int GetCreditLimit();
    int GetAnnualCharge();
}