namespace SingleResponsibilityPrinciple;
class Database
{
    public void Connect()
    {
        Console.WriteLine("veri tabanına bağlanıldı.");
    }
    public void DisConnect()
    {
        Console.WriteLine("veri tabanı bağlantısı kapatıldı");
    }
    public string State { get; set; }
}
class PersonService
{
    public List<Person> GetPersons()
    {
        return new()
        {
            new() { Name = "ali can", LastName = "yucel"
            },
              new() { Name="ali can",LastName="yucel"},
                new() { Name="veli can",LastName="yüksel"},
        };
    }
}