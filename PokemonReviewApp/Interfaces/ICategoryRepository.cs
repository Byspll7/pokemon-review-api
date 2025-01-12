using PokemonReviewApp.Models;

namespace PokemonReviewApp.Interfaces
{
    public interface ICategoryRepository
    {
        ICollection<Category> GetCategories();
        Category GetCategory(int ID);
        ICollection<Pokemon> GetPokemonsByCategory(int categoryId);
        bool CategoryExsists(int id);
        bool CreateCategory(Category catgeory);
        bool UpdateCategory(Category category);
        bool DeleteCategory(Category category);
        bool Save();
    }
}
