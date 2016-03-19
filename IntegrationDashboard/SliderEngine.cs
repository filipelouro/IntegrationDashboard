using System.Collections.Generic;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;

namespace IntegrationDashboard
{
    class SliderEngine
    {
        private List<Page> pagesList;
        private bool IsRunning = false;
        private Task sliderWorker;
        private Frame rootFrame;

        public SliderEngine(List<Page> pagesList, Frame rootFrame)
        {
            this.pagesList = pagesList;
            this.rootFrame = rootFrame;
        }

        public void Stop()
        {
            IsRunning = false;
        }

        public void Start()
        {
            sliderWorker = Task.Run(() => SliderWorker());
            sliderWorker.Start();
        }

        public async void SliderWorker()
        {
            while (IsRunning)
            {
                foreach (Page page in pagesList)
                {
                    this.rootFrame.Navigate(page.GetType());
                    await Task.Delay(30000);
                }
            }
        }

    }
}
