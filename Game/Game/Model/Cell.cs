using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Model
{
    class Cell
    {
        #region Member Variables
        private int _score;
        private int _x;
        private int _y;
        #endregion

        #region GET SET
        public int Score
        {
            get { return _score; }
            set { _score = value; }
        }

        public int X
        {
            get { return _x; }
            set { _x = value; }
        }

        public int Y
        {
            get { return _y; }
            set { _y = value; }
        }
        #endregion

        #region Methods
        public Cell(int score, int x, int y)
        {
            this._score = score;
            this._x = x;
            this._y = y; 
        }
        #endregion
    }
}
