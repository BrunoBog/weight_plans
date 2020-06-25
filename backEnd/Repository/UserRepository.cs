using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MongoDB.Driver;

public class UserRepository
{
    public UserRepository(IDatabaseSettings settings)
    {
        var client = new MongoClient(settings.ConnectionString);
        var database = client.GetDatabase(settings.DatabaseName);

        User = database.GetCollection<User>("user");
    }

    public IMongoCollection<User> User { get; }
    public List<User> Get() =>
    User.Find(User => true).ToList();

    public User Get(string id) =>
        User.Find<User>(UserDTO => UserDTO.Id == id).FirstOrDefault();

    public async Task<User> GetByEmailAndPasswordAsync(String email, String password) =>
        await User.Find(u => u.Email.Equals(email) && u.Password.Equals(password)).Limit(1).SingleAsync();

    public User Create(User UserDTO)
    {
        if (UserDTO.Id == null)
            UserDTO.Id = Guid.NewGuid().ToString();

        User.InsertOne(UserDTO);
        return UserDTO;
    }

    public async Task<User> CreateAsync(User UserDTO)
    {
        if (UserDTO.Id == null)
            UserDTO.Id = Guid.NewGuid().ToString();

        await User.InsertOneAsync(UserDTO);
        return UserDTO;
    }

    public void Update(string id, User UserDTOIn) =>
        User.ReplaceOne(UserDTO => UserDTO.Id == id, UserDTOIn);

    public void Remove(User UserDTOIn) =>
        User.DeleteOne(UserDTO => UserDTO.Id == UserDTOIn.Id);

    public void Remove(string id) =>
        User.DeleteOne(UserDTO => UserDTO.Id == id);
}
