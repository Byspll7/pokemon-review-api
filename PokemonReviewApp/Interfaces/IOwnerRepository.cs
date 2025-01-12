using PokemonReviewApp.Models;

namespace PokemonReviewApp.Interfaces
{
    public interface IOwnerRepository
    {
        ICollection<Owner> GetOwners();
        Owner GetOwner(int ownerId);
        ICollection<Owner> GetOwnersOfAPokemon(int pokeId);
        ICollection<Pokemon> GetPokemonByOwner(int ownerId);
        bool OwnerExsists(int ownerId);
        bool CreateOwner(Owner owner);
        bool Update(Owner owner);
        bool DeleteOwner(Owner owner);
        bool Save();
    }
}
