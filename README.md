# YYX.BuildEventsDemo
1. Copy file to other directory after the build completes
```shell
echo %cd%
echo f | xcopy /y bin\Debug\net6.0\YYX.BuildEventsDemo.exe ..\YYX.BuildEventsDemo.exe   
```
2. Decrypt and encrypt the same as before is Base64String

```csharp
using System.Text;

var rowText = "eWlueW9uZ3hpYW4=";
byte[] fromBase64String = Convert.FromBase64String(rowText);
var text = Encoding.UTF8.GetString(fromBase64String);

Console.WriteLine(text);

var bytes = Encoding.UTF8.GetBytes(text);
var base64String = Convert.ToBase64String(bytes);
```

