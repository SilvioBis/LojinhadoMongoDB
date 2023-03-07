using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace LojinhaServer.Collections;

[Table("products")]
[BsonIgnoreExtraElements]
public class Product
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string Id { get; set; }

    [BsonElement]
    [JsonPropertyName("Nome")]
    public string Name { get; set; }

    [BsonElement("description")]
    [JsonPropertyName("Descrição")]
    public string description { get; set; }

    [BsonElement("Price")]
    public decimal Prince { get; set; }

    [BsonElement("offiPrince")]
    public decimal OffPrince { get; set; }

    [BsonElement("tags")]
    public List <string>Tags { get; set; }

    [BsonElement ("brand")]
    public string Brand { get; set; }

}