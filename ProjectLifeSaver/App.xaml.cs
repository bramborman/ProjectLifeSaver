﻿using System;
using System.Threading.Tasks;
using UWPHelper.UI;
using Windows.ApplicationModel;
using Windows.ApplicationModel.Activation;
using Windows.Foundation;
using Windows.UI;
using Windows.UI.ViewManagement;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

namespace ProjectLifeSaver
{
    public sealed partial class App : Application
    {
        public static new App Current { get; private set; }

        private BarsHelperColorsSetterColorInfo defaultBarsColorInfo;

        public App()
        {
            Current = this;

            InitializeComponent();
            Suspending += OnSuspending;
        }

        public async Task SetDefaultBarsColors()
        {
            await BarsHelper.Current.SetCustomTitleBarColorsSetterAsync(new BarsHelperTitleBarColorsSetter(true, null, defaultBarsColorInfo, defaultBarsColorInfo));
            await BarsHelper.Current.SetCustomStatusBarColorsSetterAsync(new BarsHelperStatusBarColorsSetter(1.0, true, null, defaultBarsColorInfo, defaultBarsColorInfo));

            if (BarsHelper.Current.IsInitialized)
            {
                await BarsHelper.Current.SetBarsColorsAsync();
            }
        }

        protected override async void OnActivated(IActivatedEventArgs args)
        {
            defaultBarsColorInfo = new BarsHelperColorsSetterColorInfo((Color)Resources["SystemAccentColor"], Colors.White);
            // Start loading lightweight data here

            Frame rootFrame = Window.Current.Content as Frame;

            if (rootFrame == null)
            {
                rootFrame = new Frame();
                rootFrame.NavigationFailed += OnNavigationFailed;

                if (args.PreviousExecutionState == ApplicationExecutionState.Terminated)
                {
                    //TODO: Load state from previously suspended application
                }

                Window.Current.Content = rootFrame;

                BarsHelper.Current.RequestedThemeGetter = () => ElementTheme.Dark;
                await SetDefaultBarsColors();
                await BarsHelper.Current.InitializeForCurrentViewAsync();

                ApplicationView.GetForCurrentView().SetPreferredMinSize(new Size(420, 520));
            }
            
            LaunchActivatedEventArgs launchArgs = args as LaunchActivatedEventArgs;

            // Finish loading the data here

            if (launchArgs?.PrelaunchActivated != true)
            {
                if (rootFrame.Content == null)
                {
                    rootFrame.Navigate(typeof(MainPage), launchArgs?.Arguments);
                }

                Window.Current.Activate();
            }
        }

        protected override void OnLaunched(LaunchActivatedEventArgs e)
        {
            OnActivated(e);
        }
        
        private void OnNavigationFailed(object sender, NavigationFailedEventArgs e)
        {
            throw new Exception("Failed to load Page " + e.SourcePageType.FullName);
        }
        
        private void OnSuspending(object sender, SuspendingEventArgs e)
        {
            SuspendingDeferral deferral = e.SuspendingOperation.GetDeferral();
            deferral.Complete();
        }
    }
}
