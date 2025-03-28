using Fluxor;

namespace RWKBlazor.Client.Store.CounterUseCase
{
    public static class Reducers
    {
        [ReducerMethod]
        public static CounterState ReduceIncrementCountAction(CounterState state, IncrementCountAction action)
            => state with
            {
                Count = state.Count + 1
            };
    }
}
