using Microsoft.JSInterop;

namespace BlazorMovies.Client.Helpers
{
    public static class IJSRRuntimeExtensionMethods
    {
        public static async ValueTask<bool> Confirm(this IJSRuntime js, string message)
        {
            await js.InvokeVoidAsync(message);
            return await js.InvokeAsync<bool>("confirm", message);
        }

        public static async ValueTask MuFunction(this IJSRuntime js, string message)
        {
            await js.InvokeVoidAsync("my_function", message);
        }
    }
}
