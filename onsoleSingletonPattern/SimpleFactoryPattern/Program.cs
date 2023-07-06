// See https://aka.ms/new-console-template for more information
using SimpleFactoryPattern;
using SimpleFactoryPattern.Implementation;
using SimpleFactoryPattern.Interfaces;

Console.WriteLine("Please enter type of credit card you need?");
string type = Console.ReadLine();
ICreditCardSelection selection = new CreditCardSelection();
ICreditCard objCreditCardType = selection.SelectCreditCard(type.ToEnum<CreditCardType>());
Console.WriteLine(objCreditCardType.creditCardLimit());
