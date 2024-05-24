using Newtonsoft.Json;

public class Person
{
    [JsonProperty("name")]
    public string Name { get; set; }

    [JsonProperty("mark")]
    public int Mark { get; set; }
}
