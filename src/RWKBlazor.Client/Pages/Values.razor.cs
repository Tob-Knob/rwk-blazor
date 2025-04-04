using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Components;
using RWKBlazor.Shared.Services;

namespace RWKBlazor.Client.Pages
{
    public partial class Values
    {
        private readonly IValueService _valueService;
        private string[] _values;

        public Values(IValueService valueService)
        {
            _valueService = valueService;
        }

        protected override async Task OnInitializedAsync()
        {
            await base.OnInitializedAsync();

            var values = await _valueService.GetValuesAsync();
            _values = values.ToArray();
        }
    }
}
