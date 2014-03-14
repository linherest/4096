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
using Game.Model;
using Game.Constant;
using Windows.UI;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace Game
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private Cell[,] _cells;
        private TextBlock[,] _textBlock;

        public MainPage()
        {
            this.InitializeComponent();
            _cells = new Cell[Constants.CELL_SIZE, Constants.CELL_SIZE];
            _textBlock = new TextBlock[Constants.CELL_SIZE, Constants.CELL_SIZE];

            SolidColorBrush brush = new SolidColorBrush(Colors.Black);

            for (int i = 0; i < Constants.CELL_SIZE; i++)
            {
                for (int j = 0; j < Constants.CELL_SIZE; j++)
                {
                    //Initialize cells
                    _cells[i,j] = new Cell(Constants.DEFAULT_SCORE, i, j);

                    //Add to Grid
                    _textBlock[i, j] = new TextBlock();                    
                    GameBoard.Children.Add(_textBlock[i, j]);

                    //Position cells in grids
                    Grid.SetRow(_textBlock[i, j], i);
                    Grid.SetColumn(_textBlock[i, j], j);

                    //Cell properties
                    //if (_cells[i, j].Score != Constants.DEFAULT_SCORE)
                    {
                        _textBlock[i, j] = _cells[i, j].Score.ToString();
                    }

                    _textBlock[i, j].Foreground = brush;
                    _textBlock[i, j].Visibility = Visibility.Visible;
                    _textBlock[i, j].VerticalAlignment = VerticalAlignment.Top;
                    _textBlock[i, j].HorizontalAlignment = HorizontalAlignment.Center;
                    _textBlock[i, j].Height = 115;
                    _textBlock[i, j].Width = 115;
                }
            }
        }

        public void InitializeBoard()
        {
            //Random X
            var x = GeneratePosition();
            var y = GeneratePosition();
        }

        public int GeneratePosition()
        {
            Random ran = new Random(0);
            var pos = ran.Next(Constants.MIN_X, Constants.MAX_X);
            return pos;
        }

        public int GenerateScore(int x, int y)
        {
            return 0;
        }

        private void Page_KeyDown(object sender, KeyRoutedEventArgs e)
        {
            switch (e.Key)
            {
                case Windows.System.VirtualKey.Down:
                case Windows.System.VirtualKey.S:
                    MoveDown();
                    break;
                case Windows.System.VirtualKey.Left:
                case Windows.System.VirtualKey.A:
                    MoveLeft();
                    break;
                case Windows.System.VirtualKey.Right:
                case Windows.System.VirtualKey.D:
                    MoveRight();
                    break;
                case Windows.System.VirtualKey.Up:
                case Windows.System.VirtualKey.W:
                    MoveUp();
                    break;
                default:
                    break;
            }
        }

        private void MoveUp()
        {
            
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
