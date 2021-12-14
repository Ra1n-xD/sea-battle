using System;

namespace SeaBattle
{
    public delegate void deShowShip(Point place, int nr);
    public delegate void deShowFight(Point place, Status status);

    class Sea
    {
        public static Point size_sea = new Point(10, 10);
        public static int all_ships = 10;

        public deShowShip ShowShip;
        public deShowFight ShowFight;

        protected int[,] map_ship; // -1 - пусто, 0..9 номера кораблей которые стоят
        protected Status[,] map_shot; // по мере игры значения будут разные, сначала неизсветсно

        protected Ship[] ship;
        public int stand
        { get; protected set; }
        public int dead
        { get; protected set; }

        public Sea()
        {
            map_ship = new int[size_sea.x, size_sea.y];
            map_shot = new Status[size_sea.x, size_sea.y];
            ship = new Ship[all_ships];

        }

        
        public Status MapHit(Point t)
        { 
            if (InSea(t))
                return map_shot[t.x, t.y];
            return Status.unknown;
        }

        public bool InSea(Point t)
        {
            return (t.x >= 0 && t.x < size_sea.x &&
                    t.y >= 0 && t.y < size_sea.y);
        }
        public Status Shot(Point t)
        {
            if (!InSea(t))
                return Status.unknown;
            if (map_shot[t.x, t.y] != Status.unknown)
                return map_shot[t.x, t.y];
            Status status;
            if(map_ship[t.x, t.y] == -1)
            {
                map_shot[t.x, t.y] = Status.miss;
                status = Status.miss;
            }
            else
                status = ship[map_ship[t.x, t.y]].Shot(t);

            map_shot[t.x, t.y] = status;
            if (status == Status.killed)
            {
                dead++;
                if (dead >= stand)
                    status = Status.win;
            }
            ShowFight(t, status);
            return status;
        }
       
    }
}
