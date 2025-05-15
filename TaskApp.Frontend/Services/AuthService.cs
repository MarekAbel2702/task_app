using Microsoft.JSInterop;

namespace TaskApp.Frontend.Services
{
    public class AuthService
    {
        private readonly IJSRuntime _js;

        public AuthService(IJSRuntime js)
        {
            _js = js;
        }

        public async Task SaveToken(string token)
        {
            await _js.InvokeVoidAsync("localStorage.setItem", "token", token);
        }

        public async Task<string?> GetToken()
        {
            return await _js.InvokeAsync<string>("localStorage.getItem", "token");
        }

        public async Task RemoveToken()
        {
            await _js.InvokeVoidAsync("localStorage.removeItem", "token");
        }
    }
}
