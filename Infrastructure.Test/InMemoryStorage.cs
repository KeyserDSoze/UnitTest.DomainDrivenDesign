using Domain;

namespace Infrastructure.Test
{
    internal sealed class InMemoryStorage : IStorage
    {
        private readonly Dictionary<string, bool> _entities = new();
        public ValueTask<bool> GetAsync(string id)
        {
            return ValueTask.FromResult(_entities[id]);
        }

        public ValueTask<bool> InsertAsync(string id)
        {
            _entities.Add(id, true);
            return ValueTask.FromResult(true);
        }
    }
}