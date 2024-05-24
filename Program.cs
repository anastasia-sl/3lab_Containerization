using Newtonsoft.Json;

var obj = new { Name = "Me", Mark = 100 };
string json = JsonConvert.SerializeObject(obj);
var person = JsonConvert.DeserializeObject<Person>(json);
if (person.Mark < 60) {
    Console.WriteLine("Dopsession");
} else {
    Console.WriteLine("Good");
}
Console.WriteLine(json);
