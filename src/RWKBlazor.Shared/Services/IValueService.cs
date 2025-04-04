namespace RWKBlazor.Shared.Services
{
    public interface IValueService
    {
        Task<IEnumerable<string>> GetValuesAsync();
    }
}
