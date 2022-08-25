namespace PieShop.Models
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly AppDbContext _appDbcontext;

        public CategoryRepository(AppDbContext appDbcontext)
        {
            _appDbcontext = appDbcontext;
        }
        public IEnumerable<Category> AllCategories => _appDbcontext.Categories;
    }
}
