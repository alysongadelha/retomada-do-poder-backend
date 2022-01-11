using PoderAPI.Helpers;
using PoderAPI.Model;
using System.Collections.Generic;

namespace PoderAPI.Data.Interfaces
{
    public interface ICharVampireRepository
    {
        IEnumerable<CharVampire> GetCharVampire();

        CharVampire GetCharVampireByID(string id);

        void AddCharVampire(CharVampire charVampire);

        void DeleteCharVampire(string id);

        void UpdateCharVampire(string id, CharVampire charVampire);

        PagedList<CharVampire> GetCharVampiresByFlag(int filiation, CharacterParameters characterParameters);

    }
}
