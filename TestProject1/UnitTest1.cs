using Domain;

namespace TestProject1
{
    public class UnitTest1
    {
        private readonly IStorage _storage;

        public UnitTest1(IStorage storage)
        {
            _storage = storage;
        }

        [Fact]
        public async ValueTask Test1()
        {
            Assert.True(await _storage.InsertAsync("d"));
            var result = await _storage.GetAsync("d");
            Assert.True(result);
        }
    }
}