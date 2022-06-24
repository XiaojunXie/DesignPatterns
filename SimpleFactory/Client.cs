namespace SimpleFactory;

public static class Client
{
    public static void Do(string cardType)
    {
        //Generally we will get the Card Type from UI.

        CreditCard? cardDetails = cardType switch
        {
            //Based of the CreditCard Type we are creating the
            //appropriate type instance using if else condition
            "MoneyBack" => new MoneyBack(),
            "Titanium" => new Titanium(),
            "Platinum" => new Platinum(),
            _ => null
        };

        if (cardDetails != null)
        {
            Console.WriteLine("CardType : " + cardDetails.GetCardType());
            Console.WriteLine("CreditLimit : " + cardDetails.GetCreditLimit());
            Console.WriteLine("AnnualCharge :" + cardDetails.GetAnnualCharge());
        }
        else
        {
            Console.Write("Invalid Card Type");
        }
    }
}
//
// The above code implementation introduces the following problems
//
//  First, the tight coupling between the client class (Program) and Product Class (MoneyBack, Titanium, and Platinum).
//  Secondly, if we add a new Credit Card, then also we need to modify the Main method by adding an extra if-else condition which not only overheads in the development but also in the testing process
