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

namespace Game
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private int[][] _data;

        public MainPage()
        {
            this.InitializeComponent();

        }

        private void Page_KeyDown(object sender, KeyRoutedEventArgs e)
        {
            switch (e.Key)
            {
                case Windows.System.VirtualKey.Down:
                case Windows.System.VirtualKey.S:
                    //MoveDown();
                    break;
                case Windows.System.VirtualKey.Left:
                case Windows.System.VirtualKey.A:
                    //MoveLeft();
                    break;
                case Windows.System.VirtualKey.Right:
                case Windows.System.VirtualKey.D:
                    //MoveRight();
                    break;
                case Windows.System.VirtualKey.Up:
                case Windows.System.VirtualKey.W:
                    //MoveUp();
                    break;
                default:
                    break;
            }
        }

        private void MoveUp()
        {
            //
        }

        private void MoveDown()
        {

        }

        private void MoveLeft()
        {

        }

        private void MoveRight()
        {

        }
    }
}
