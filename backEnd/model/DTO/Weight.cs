using System;
using MongoDB.Bson;

public class Weight
{
    public ObjectId Id { get; set; }
    public DateTime Day { get; set; }
    public decimal WeightValue { get; set; }
    public decimal BodyFatValue { get; set; }
    public string Description { get; set; }    
    public string UserMail { get; set; }
}