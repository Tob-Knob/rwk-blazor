using RWKBlazor.Sdk;
using RWKBlazor.Shared.Services;

namespace RWKBlazor.Client.Services
{
    public class ValueService : IValueService
    {
        private RWKBlazorClient _client;

        public ValueService(RWKBlazorClient client)
        {
            _client = client;
        }

        public async Task<IEnumerable<string>> GetValuesAsync()
        {
            var values = await _client.ValuesAllAsync();
            return values;
        }
    }
}
