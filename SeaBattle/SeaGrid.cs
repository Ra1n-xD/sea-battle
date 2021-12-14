using System.Drawing;
using System.Windows.Forms;

namespace SeaBattle
{
    class SeaGrid
    {
        DataGridView grid;

        static string abc = "ПОСТАВЬТЕ5";
        Color color_back = Color.SkyBlue;
        Color[] color_ship = {
                Color.Black,
                Color.Black, Color.Black,
                Color.Black, Color.Black, Color.Black,
                Color.Black, Color.Black, Color.Black, Color.Black };

        Color[] color_fight = {
                Color.SkyBlue,
                Color.DarkGray,
                Color.Red,
                Color.DarkRed,
                Color.Red, };

        public SeaGrid (DataGridView grid)
        {
            this.grid = grid;
            InitGrid();
        }

        private void InitGrid()
        {
            grid.Rows.Clear();
            grid.Columns.Clear();
            grid.DefaultCellStyle.BackColor = color_back;
            for (int x = 0; x < Sea.size_sea.x; x++)
                grid.Columns.Add("col_" + x.ToString(), abc.Substring(x, 1));
            for (int y = 0; y < Sea.size_sea.y; y++)
            {
                grid.Rows.Add();
                grid.Rows[y].HeaderCell.Value = (y + 1).ToString();
            }
            grid.Height = Sea.size_sea.y * grid.Rows[0].Height + grid.ColumnHeadersHeight;
            grid.ClearSelection();
        }

        public void ShowShip(Point place, int nr)
        {
            if (nr < 0)
                grid[place.x, place.y].Style.BackColor = color_back;
            else
                grid[place.x, place.y].Style.BackColor = color_ship[nr];
        }

        public void ShowFight(Point place, Status status)
        {
            grid[place.x, place.y].Style.BackColor = color_fight[(int)status];
        }

        public Point[] GetSelectedCells()
        {
            if (grid.SelectedCells.Count == 0)
                return null;

            Point[] ship = new Point[grid.SelectedCells.Count];
            int j = 0;
            foreach (DataGridViewCell cell in grid.SelectedCells)
            {
                ship[j++] = new Point(cell.ColumnIndex, cell.RowIndex);
            }
            grid.ClearSelection();

            return ship;
            
        }
    }
}
