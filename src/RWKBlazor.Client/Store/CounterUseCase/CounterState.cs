using Fluxor;

namespace RWKBlazor.Client.Store.CounterUseCase
{
    [FeatureState]
    public record CounterState(int Count)
    {
        private CounterState() : this(0)
        {

        }
    }
}
