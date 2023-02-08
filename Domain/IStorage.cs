namespace Domain
{
    public interface IStorage
    {
        ValueTask<bool> GetAsync(string id);
        ValueTask<bool> InsertAsync(string id);
    }
}