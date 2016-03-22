using IntegrationDashboard.Views;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace IntegrationDashboard
{
    class SliderEngine
    {
        private Task sliderWorker;
        private CancellationToken cancelToken;
        private CancellationTokenSource tokenSource;

        public void Stop()
        {
            tokenSource.Cancel();
        }

        public void Start()
        {
            tokenSource = new CancellationTokenSource();
            cancelToken = tokenSource.Token;

            Frame rootFrame = Window.Current.Content as Frame;

            if (rootFrame == null)
            {
                rootFrame = new Frame();

                Window.Current.Content = rootFrame;
            }

            if (rootFrame.Content == null)
            {
                sliderWorker = Task.Factory.StartNew(() => SliderWorker(rootFrame,cancelToken), cancelToken);
                sliderWorker.Wait();
            }
        }

        private async void SliderWorker(Frame rootFrame,CancellationToken token)
        {     
                List<System.Type> pagesList = new List<Type>();
                pagesList.Add(typeof(TeamcityTops));
                pagesList.Add(typeof(Settings));

                while (true)
                {
                    if (token.IsCancellationRequested)
                        break;

                    foreach (System.Type page in pagesList)
                    {
                        rootFrame.Navigate(page);
                        Window.Current.Activate();
                        await Task.Delay(30000);
                    }
                }
            }
        }

    }
