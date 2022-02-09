using System.Text;

var rowText = "eWlueW9uZ3hpYW4=";
byte[] fromBase64String = Convert.FromBase64String(rowText);
var text = Encoding.UTF8.GetString(fromBase64String);

Console.WriteLine(text);

var bytes = Encoding.UTF8.GetBytes(text);
var base64String = Convert.ToBase64String(bytes);

//Console.ReadKey();