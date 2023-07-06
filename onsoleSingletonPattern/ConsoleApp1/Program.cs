// See https://aka.ms/new-console-template for more information
using ConsoleApp1;
using OKXAPI_AA;

AA_OKxClient obj = new AA_OKxClient();
obj.SetApiCredentials("fd9aa94c-d7b9-43dc-9289-6095e17620b6", "B07E8D42EDEEB4F9589E0921959D93CC", "Developer1!");
var test = obj.PlaceOrder("BTC-USDT", "cash", "buy", "limit", "0.01", "1000");
Console.WriteLine(test);
var singleObj = EmailService.getInstance;
singleObj.sendEmail();
