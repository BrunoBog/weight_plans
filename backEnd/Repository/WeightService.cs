using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;

namespace weight.Database
{
    public class WeightRepository
    {
        public WeightRepository(IDatabaseSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);

            Weights = database.GetCollection<Weight>("weight");
        }

        public IMongoCollection<Weight> Weights { get; }

        public List<Weight> Get() =>
            Weights.Find(WeightDTO => true).SortByDescending(w => w.Day).ToList();

        public List<Weight> GetFromUser(string email) => 
        Weights.Find(WeightDTO => WeightDTO.UserMail.Equals(email)).SortBy(w => w.Day).ToList();

        public Weight Get(ObjectId id) =>
            Weights.Find<Weight>(WeightDTO => WeightDTO.Id == id).FirstOrDefault();

        public Weight Create(Weight WeightDTO)
        {
            if (WeightDTO.Id == null)
                WeightDTO.Id = MongoDB.Bson.ObjectId.GenerateNewId();

            Weights.InsertOne(WeightDTO);
            return WeightDTO;
        }

        internal async Task<Weight> GetLastWeightAsync(string name){
                var r = await Weights.Find<Weight>(x => x.UserMail.Equals(name))
                .SortByDescending(d => d.Day)
                .Limit(1)
                .FirstOrDefaultAsync();

                return new Weight{
                    BodyFatValue = r.BodyFatValue,
                    Day = r.Day,
                    WeightValue = r.WeightValue,
                    Description = r.Description, 
                    UserMail = r.UserMail
                };
                }
            // await Weights.Aggregate().SortByDescending(w => w.Day).FirstAsync();
        

        public void Update(ObjectId id, Weight WeightDTOIn) =>
            Weights.ReplaceOne(WeightDTO => WeightDTO.Id == id, WeightDTOIn);

        public void Remove(Weight WeightDTOIn) =>
            Weights.DeleteOne(WeightDTO => WeightDTO.Id == WeightDTOIn.Id);

        public void Remove(ObjectId id) =>
            Weights.DeleteOne(WeightDTO => WeightDTO.Id == id);
    }
}