using RWKBlazor.Shared.Services;

namespace RWKBlazor.Services
{
    public class ValueService : IValueService
    {
        public async Task<IEnumerable<string>> GetValuesAsync()
        {
            await Task.Delay(500);
            return ["value1", "value2"];
        }
    }
}
