using System;
using System.Collections.Generic;
using MongoDB.Driver;

public class UserService
{
    public UserService(IDatabaseSettings settings)
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

    public User Create(User UserDTO)
    {
        if (UserDTO.Id == null)
            UserDTO.Id = Guid.NewGuid().ToString();

        User.InsertOne(UserDTO);
        return UserDTO;
    }

    public void Update(string id, User UserDTOIn) =>
        User.ReplaceOne(UserDTO => UserDTO.Id == id, UserDTOIn);

    public void Remove(User UserDTOIn) =>
        User.DeleteOne(UserDTO => UserDTO.Id == UserDTOIn.Id);

    public void Remove(string id) =>
        User.DeleteOne(UserDTO => UserDTO.Id == id);
}
