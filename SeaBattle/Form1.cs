using System;
using System.Windows.Forms;

namespace SeaBattle
{
    public partial class Game : Form
    {
        Editor sea_user;
        Editor sea_comp;

        SeaGrid GridUser;
        SeaGrid GridComp;

        AI ai;

        enum Mode
        {
            EditShips,
            PlayUser,        
            PlayComp,
            Finish
        };

        Mode mode;

        public Game()
        {
            InitializeComponent();
            sea_user = new Editor();
            sea_user.ShowShip = ShowUserShip;
            sea_user.ShowFight = ShowUserFight;

            sea_comp = new Editor();
            sea_comp.ShowShip = ShowCompShip;
            sea_comp.ShowFight = ShowCompFight;

            GridUser = new SeaGrid(grid_user);
            GridComp = new SeaGrid(grid_comp);

            Restart();

            timer1.Enabled = true;
        }

        private void Restart()
        {
            mode = Mode.EditShips;
            sea_user.Drop();
            sea_comp.Drop();
            sea_comp.SetStraight();
            
            buttonRandom.Visible = true;
            buttonClear.Visible = true;
            buttonStart.Visible = true;
            ShowUnplacedShips();
        }


        private void ShowUserShip (Point place, int nr)
        {
            GridUser.ShowShip(place, nr);
        }
        private void ShowCompShip(Point place, int nr)
        {
            if (mode == Mode.EditShips)
                GridComp.ShowShip(place, nr);
        }
        
        private void ShowUserFight(Point place, Status status)
        {
            GridUser.ShowFight(place, status);
        }
        private void ShowCompFight(Point place, Status status)
        {
            GridComp.ShowFight(place, status);
        }

        private void grid_user_MouseUp(object sender, MouseEventArgs e)
        {   
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
                PlaceShip();
            grid_user.ClearSelection();
        }

        private void PlaceShip()
        {
            if (mode != Mode.EditShips)
                return;
            Point[] ship = GridUser.GetSelectedCells();
            if(ship == null)
            {
                return;
            }
            if (ship.Length == 1)
            {
                sea_user.CleanPoint(ship[0]);
            }
            sea_user.SetByPoint(ship);

            ShowUnplacedShips();
        }
        private void ShowUnplacedShips()
        {
            sea_comp.SetStraight();
            for (int j = 0; j < Sea.all_ships; j++)
                if (!sea_user.WithoutShip(j))
                    sea_comp.DelateShip(j);
            buttonStart.Enabled = sea_user.stand == Sea.all_ships;
            
        }

        private void grid_user_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                PlaceShip();
            grid_user.ClearSelection();
        }

        private void buttonRestart_Click(object sender, EventArgs e)
        {
            Restart();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            if (mode != Mode.EditShips)
                return;
            if(sea_user.stand == Sea.all_ships)
            {
                mode = Mode.PlayUser;
                sea_comp.SetRandom();               
                ai = new AI(sea_user);
                

                buttonRandom.Visible = false;
                buttonClear.Visible = false;
                buttonStart.Visible = false;
            }
        }
        //-----
        private void buttonRandom_Click_1(object sender, EventArgs e)
        {
            if (mode != Mode.EditShips)
                return;
            sea_user.SetRandom();
            ShowUnplacedShips();
        }

        private void buttonClear_Click_1(object sender, EventArgs e)
        {
            if (mode != Mode.EditShips)
                return;
            sea_user.Drop();
            ShowUnplacedShips();
        }

        private void grid_comp_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            grid_comp.ClearSelection();
            if (mode != Mode.PlayUser)
                return;
            Status status = sea_comp.Shot(new Point(e.ColumnIndex, e.RowIndex));
           
            switch (status)
            {
                case Status.unknown:
                case Status.miss:
                    mode = Mode.PlayComp;
                    break;
                case Status.wounded:
                    mode = Mode.PlayUser;
                    break;
                case Status.killed:
                    mode = Mode.PlayUser;
                    break;
                case Status.win:
                    mode = Mode.Finish;
                    WinUser();
                    break;
            }
           
        }
     

        private void CompFight()
        {
            Point point;
            Status status = ai.Fight(out point);
            switch (status)
            {
                case Status.unknown:
                case Status.miss:
                    mode = Mode.PlayUser;
                    break;
                case Status.wounded:
                case Status.killed:
                    mode = Mode.PlayComp;
                    break;
                case Status.win:
                    mode = Mode.Finish;
                    WinComp();
                    break;
            }
        }

        private void WinUser()
        {
            MessageBox.Show("ММММаксимальное пробитие, вы победили!!!");
        }
        private void WinComp()
        {
            MessageBox.Show("Вас пробили((( Игра окончена");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(mode == Mode.PlayComp)
            {
                CompFight();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Game_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.OpenForms[0].Show();
            Application.OpenForms[1].Hide();
            this.Close();

        }

        
    }
}
