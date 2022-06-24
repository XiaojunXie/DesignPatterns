// See https://aka.ms/new-console-template for more information

using FactoryMethod;

var creditCard = new PlatinumFactory().CreateProduct();
Console.WriteLine("Card Type : " + creditCard.GetCardType());
Console.WriteLine("Credit Limit : " + creditCard.GetCreditLimit());
Console.WriteLine("Annual Charge :" + creditCard.GetAnnualCharge());

Console.WriteLine("--------------");
creditCard = new MoneyBackFactory().CreateProduct();

Console.WriteLine("Card Type : " + creditCard.GetCardType());
Console.WriteLine("Credit Limit : " + creditCard.GetCreditLimit());
Console.WriteLine("Annual Charge :" + creditCard.GetAnnualCharge());
