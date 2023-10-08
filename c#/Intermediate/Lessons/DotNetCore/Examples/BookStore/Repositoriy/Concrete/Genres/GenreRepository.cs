using Entity.Concrete.Models;
using Repository.Concrete.Ef;
using Repository.Contracts.Genres;

namespace Repository.Concrete.Genres
{
    public class GenreRepository : RepositoryBase<Genre>, IGenreRepository
    {
        public GenreRepository(EfRepositoryContext context) : base(context)
        { }
        public override IEnumerable<Genre>? GetHashSet(bool trackChanges = false)
        {
            return base.GetHashSet(trackChanges)?.Where(x => x.IsActive).ToHashSet();
        }
    }
}
