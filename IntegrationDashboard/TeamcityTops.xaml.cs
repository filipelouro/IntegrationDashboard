using IntegrationDashboard.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace IntegrationDashboard
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class TeamcityTops : Page
    {
        public TeamcityTops()
        {
            this.InitializeComponent();

            Dictionary<User, int> teste = new Dictionary<User, int>();

            User user = new User();
            user.Name = "Ana Matos";
            user.Photo = "http://adesivifacebook.com/wp-content/uploads/2013/07/minion-studioso.png";

            User user2 = new User();
            user2.Name = "Filipe Louro";
            user2.Photo = "http://adesivifacebook.com/wp-content/uploads/2013/07/minion-studioso.png";

            teste.Add(user, 10);
            teste.Add(user2, 45);

            TopBreakersView.ItemsSource = teste;
        }

    }
}
