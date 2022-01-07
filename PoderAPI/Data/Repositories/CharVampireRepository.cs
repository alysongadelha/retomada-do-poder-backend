using MongoDB.Driver;
using PoderAPI.Data.Configurations;
using PoderAPI.Data.Interfaces;
using PoderAPI.Model;
using System;
using System.Collections.Generic;

namespace PoderAPI.Data.Repositories
{
    public class CharVampireRepository : ICharVampireRepository
    {
        private readonly IMongoCollection<CharVampire> _charVampire;

        public CharVampireRepository(IDatabaseConfig databseConfig)
        {
            var c = new MongoClient(databseConfig.ConnectionString);
            var d = c.GetDatabase(databseConfig.DatabaseName);

            _charVampire = d.GetCollection<CharVampire>("charVampire");
        }

        public void AddCharVampire(CharVampire charVampire)
        {
            _charVampire.InsertOne(charVampire);
        }

        public void DeleteCharVampire(string id)
        {
            _charVampire.DeleteOne(vampire => vampire.Id == id);
        }

        public IEnumerable<CharVampire> GetCharVampire()
        {
            return _charVampire.Find(vampire => true).ToList();
        }

        public CharVampire GetCharVampireByID(string id)
        {
            return _charVampire.Find(vampire => vampire.Id == id).FirstOrDefault();
        }

        public void UpdateCharVampire(string id, CharVampire charVampire)
        {
            _charVampire.ReplaceOne(vampire => vampire.Id == id, charVampire);
        }
    }
}
