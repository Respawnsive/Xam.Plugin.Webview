using System;
using System.Threading.Tasks;
using System.Windows.Input;
using Xam.Plugin.WebView.Abstractions.Delegates;
using Xam.Plugin.WebView.Abstractions.Enumerations;

namespace Xam.Plugin.WebView.Abstractions
{
    public interface IFormsWebView
    {

        event EventHandler<DecisionHandlerDelegate> OnNavigationStarted;

        event EventHandler<string> OnNavigationCompleted;

        event EventHandler<int> OnNavigationError;

        event EventHandler OnContentLoaded;

        WebViewContentType ContentType { get; set; }

        string Source { get; set; }

        string BaseUrl { get; set; }

        bool EnableGlobalCallbacks { get; set; }

        bool EnableGlobalHeaders { get; set; }

        bool Navigating { get; }

        bool CanGoBack { get; }

        bool CanGoForward { get; }

        void GoBack();

        void GoForward();

        void Refresh();

        Task<string> InjectJavascriptAsync(string js);

        void AddLocalCallback(string functionName, Action<string> action);

        void RemoveLocalCallback(string functionName);

        void RemoveAllLocalCallbacks();
        Task ClearCookiesAsync();

        bool IgnoreSSLErrors { get; set; }

        string Username { get; set; }

        string Password { get; set; }

        ICommand NavigationStartedCommand { get; set; }

        ICommand NavigationCompletedCommand { get; set; }

        ICommand NavigationFailedCommand { get; set; }

        ICommand ContentLoadedCommand { get; set; }
    }
}
