namespace SimpleFactory;

public class CreditCardFactory
{
    public static CreditCard? GetCreditCard(string cardType)
    {
        CreditCard? cardDetails = cardType switch
        {
            "MoneyBack" => new MoneyBack(),
            "Titanium" => new Titanium(),
            "Platinum" => new Platinum(),
            _ => null
        };

        return cardDetails;
    }
}