# When to use the Factory Design Pattern in real-time applications?
It would not be a good programming approach to specify the exact class name while creating the objects by the client which leads to tight coupling between the client and the product. To overcome this problem, we need to use the Factory Design Pattern in C#. This design pattern provides the client with a simple mechanism to create the object. So, we need to use the Factory Design Pattern in C# when

* The Object needs to be extended to the subclasses
* Classes don’t know what exact sub-classes it has to create
* The Product implementation going to change over time and the Client remains unchanged

# Problems of Simple Factory Pattern in C#
* If we need to add any new product (i.e. new credit card) then we need to add a new if else condition in the GetCreditCard method of the CreditCardFactory class. This violates the open/closed design principle.
* We also have a tight coupling between the Factory (CreditCardFactory) class and product classes (MoneyBack, Titanium, and Platinum).