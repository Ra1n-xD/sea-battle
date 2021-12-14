using System;

namespace SeaBattle
{
    class Editor : Sea
    {
        static int[] size_ships = { 4, 3, 3, 2, 2, 2, 1, 1, 1, 1 };
        static Random rand = new Random();

        public Editor() : base()
        {

        }

        public bool SetStraight()
        {
            Drop();
            SetShip(0,
                new Point[] {
                    new Point(3, 1),
                    new Point(4, 1),
                    new Point(5, 1),
                    new Point(6, 1) });

            SetShip(1,
              new Point[] {
                    new Point(1, 3),
                    new Point(2, 3),
                    new Point(3, 3),
                    });

            SetShip(2,
              new Point[] {
                    new Point(6, 3),
                    new Point(7, 3),
                    new Point(8, 3),
                     });
            SetShip(3,
              new Point[] {
                    new Point(1, 5),
                    new Point(2, 5),
                     });
            SetShip(4,
             new Point[] {
                    new Point(4, 5),
                    new Point(5, 5),
                    });
            SetShip(5,
             new Point[] {
                    new Point(7, 5),
                    new Point(8, 5),
                    });
            SetShip(6,
             new Point[] {
                    new Point(1, 7),
                    });
            SetShip(7,
            new Point[] {
                    new Point(3, 7),
                   });

            SetShip(8,
            new Point[] {
                    new Point(6, 7),
                   });

            SetShip(9,
            new Point[] {
                    new Point(8, 7),
                   });


            return true;
        }

        public void Drop()
        {
            for (int x = 0; x < size_sea.x; x++)
            {
                for (int y = 0; y < size_sea.y; y++)
                {
                    map_ship[x, y] = -1;
                    ShowShip(new Point(x, y), -1);
                    map_shot[x, y] = Status.unknown;
                    ShowFight(new Point(x, y), Status.unknown);
                }
            }
            for (int k = 0; k < all_ships; k++)
            {
                ship[k] = null;
            }
            stand = 0;
            dead = 0;
        }

        public bool SetByPoint(Point[] deck)
        {
            int size = deck.Length;
            int number = FindNumber(size);
            if (number < 0)
                return false;
            Point LeftUp = deck[0];
            Point RightDown = deck[0];
            for (int j = 1; j < size; j++)
            {
                LeftUp.x = Math.Min(LeftUp.x, deck[j].x);
                LeftUp.y = Math.Min(LeftUp.y, deck[j].y);

                RightDown.x = Math.Max(RightDown.x, deck[j].x);
                RightDown.y = Math.Max(RightDown.y, deck[j].y);
            }
            if(RightDown.x == LeftUp.x) // вертикально
            {
                if (size != RightDown.y - LeftUp.y + 1) // есть промежутки 
                    return false;

            }
            else if (RightDown.y == LeftUp.y) // горизонтально 
            {
                if (size != RightDown.x - LeftUp.x + 1) // есть промежутки 
                    return false;
            }
            else
            {
                return false;
            }
            for (int j = 0; j < size; j++)
            {
                CleanOff(deck[j]);
            }
            SetShip(number, deck);
            return true;
        }

        protected int FindNumber(int size)
        {
            for (int j = 0; j < size_ships.Length; j++)
                if (size == size_ships[j])
                    if (WithoutShip(j))
                        return j;
            return -1;
        }


        public void SetShip(int number, Point[] deck)
        {
            if (ship[number] != null)
                DelateShip(number);
            ship[number] = new Ship(deck);
            foreach (Point t in deck)
            { 
                map_ship[t.x, t.y] = number;
                ShowShip(t, number);
            }
            stand++;
        }
        public void DelateShip(int number)
        {
            foreach (Point t in ship[number].deck)
            {
                map_ship[t.x, t.y] = -1;
                ShowShip(t, -1);
            }
            ship[number] = null;
            stand--;
        }

        public bool WithoutShip(int number)
        {
            return ship[number] == null;
        }

        public int MapShip(Point t)
        {
            if (InSea(t))
                return map_ship[t.x, t.y];
            return -1;
        }


        protected void CleanOff(Point t)
        {
            Point p;
            for (p.x = t.x - 1; p.x <= t.x + 1; p.x++)
                for (p.y = t.y - 1; p.y <= t.y + 1; p.y++)
                    CleanPoint(p);
        }

        public void CleanPoint(Point t)
        {
            if (!InSea(t))
                return;
            if (map_ship[t.x, t.y] == -1)
                return;
            DelateShip(map_ship[t.x, t.y]);
               
        }

        public bool SetRandom(int number)
        {
            int size = size_ships[number];
            Point nose;
            Point step;
            if(rand.Next(2) == 0) // горизонтально
            {
                nose = new Point(rand.Next(0, size_sea.x - size + 1), rand.Next(0, size_sea.y));
                step = new Point(1, 0);
            }
            else
            {
                nose = new Point(rand.Next(0, size_sea.x), rand.Next(0, size_sea.y - size + 1));
                step = new Point(0, 1);
            }
            Point[] deck = new Point[size];
            for (int j = 0; j < size; j++)
            { 
                deck[j] = new Point(nose.x + j * step.x, nose.y + j * step.y);
                CleanOff(deck[j]);
            }
            SetShip(number, deck);
            return true;

        }

        public void SetRandom()
        {
            Drop();
            int loop = 100;
            while (--loop > 0 && stand < Sea.all_ships)
            {
                for (int nr = 0; nr < Sea.all_ships; nr++)
                    if (WithoutShip(nr))
                        SetRandom(nr);
               
            }
            if (stand < Sea.all_ships)
                Drop();
        }

    }
}