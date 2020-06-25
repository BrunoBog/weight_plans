using System;
using System.Collections.Generic;
using MongoDB.Driver;

namespace weight.Database
{
    public class WeightService
    {
        public WeightService(IDatabaseSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);

            Weights = database.GetCollection<Weight>("weight");
        }

        public IMongoCollection<Weight> Weights { get; }

        public List<Weight> Get() =>
            Weights.Find(WeightDTO => true).ToList();

        public Weight Get(string id) =>
            Weights.Find<Weight>(WeightDTO => WeightDTO.Id == id).FirstOrDefault();

        public Weight Create(Weight WeightDTO)
        {
            if (WeightDTO.Id == null)
                WeightDTO.Id = Guid.NewGuid().ToString();
                
            Weights.InsertOne(WeightDTO);
            return WeightDTO;
        }

        public void Update(string id, Weight WeightDTOIn) =>
            Weights.ReplaceOne(WeightDTO => WeightDTO.Id == id, WeightDTOIn);

        public void Remove(Weight WeightDTOIn) =>
            Weights.DeleteOne(WeightDTO => WeightDTO.Id == WeightDTOIn.Id);

        public void Remove(string id) => 
            Weights.DeleteOne(WeightDTO => WeightDTO.Id == id);
    }
}