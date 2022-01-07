using PoderAPI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PoderAPI.Data.Interfaces
{
    public interface ICharVampireRepository
    {
        IEnumerable<CharVampire> GetCharVampire();

        CharVampire GetCharVampireByID(string id);

        void AddCharVampire(CharVampire charVampire);

        void DeleteCharVampire(string id);

        void UpdateCharVampire(string id, CharVampire charVampire);

    }
}
