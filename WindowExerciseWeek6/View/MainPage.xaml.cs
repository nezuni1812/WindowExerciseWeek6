using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using WindowExerciseWeek6.ViewModel;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace WindowExerciseWeek6.View
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            this.DataContext = ViewModel;
        }

        MainPageViewModel ViewModel { get; set; } = new MainPageViewModel();

        private void editButton_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(EditPage), ViewModel.Info);
        }
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            ViewModel.Info = e.Parameter as string;
            base.OnNavigatedTo(e);
        }
    }
}
