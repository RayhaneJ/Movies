using BlazorMovies.Client.Helpers;
using BlazorMovies.Shared;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using static BlazorMovies.Client.Shared.MainLayout;

namespace BlazorMovies.Client.Pages
{
    public partial class Counter
    {
        private int currentCount = 0;

        [JSInvokable]
        public void IncrementCount()
        {
            currentCount++;
        }
    }
}
