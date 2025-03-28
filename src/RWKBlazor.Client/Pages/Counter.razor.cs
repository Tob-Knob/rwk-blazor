using Fluxor;
using Microsoft.AspNetCore.Components;
using RWKBlazor.Client.Store.CounterUseCase;

namespace RWKBlazor.Client.Pages
{
    public partial class Counter
    {
        [Inject]
        private IState<CounterState> CounterState { get; set; } = default!;

        [Inject]
        private IDispatcher Dispatcher { get; set; } = default!;

        private void IncrementCount()
        {
            Dispatcher.Dispatch(new IncrementCountAction());
        }
    }
}
