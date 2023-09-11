using System.Text.Json.Serialization;

namespace Domain.Entities;

public class Product
{
    public int Id { get; set; }

    public string Name { get; set; }

    public string Description { get; set; }

    [JsonConverter(typeof(JsonStringEnumConverter))]
    public ProductType ProductType { get; set; }
    
    public double Price { get; set; }
    

}