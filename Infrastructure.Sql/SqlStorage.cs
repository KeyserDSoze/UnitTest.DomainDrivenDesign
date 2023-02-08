using Domain;

namespace Infrastructure.Sql
{
    internal sealed class SqlStorage : IStorage
    {
        private readonly Dictionary<string, bool> _entities = new();
        public ValueTask<bool> GetAsync(string id)
        {
            //like EF _context.GetAsync(id);
            return ValueTask.FromResult(_entities[id]);
        }

        public ValueTask<bool> InsertAsync(string id)
        {
            //like EF _context.Insert(id, true);
            _entities.Add(id, true);
            return ValueTask.FromResult(true);
        }
    }
}