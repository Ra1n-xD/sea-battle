using System;

namespace SeaBattle
{
    class AI
    {
        Sea sea;
        Random rand;

        int[,] shape =
        {
            {1,2,1,3,1,2,1,3,1,2},
            {2,1,3,1,2,1,3,1,2,1},
            {1,3,1,2,1,3,1,2,1,3},
            {3,1,2,1,3,1,2,1,3,1},
            {1,2,1,3,1,2,1,3,1,2},
            {2,1,3,1,2,1,3,1,2,1},
            {1,3,1,2,1,3,1,2,1,3},
            {3,1,2,1,3,1,2,1,3,1},
            {1,2,1,3,1,2,1,3,1,2},
            {2,1,3,1,2,1,3,1,2,1}
        };

        bool modeDanger;
        int[] shipLenght = new int[5]; // кол-во живых кораблей и их длинны 
        int[,] map;
        int[,] put;

     


        public AI(Sea sea)
        {
            this.sea = sea;
            rand = new Random();
            map = new int[Sea.size_sea.x, Sea.size_sea.y];
            put = new int[Sea.size_sea.x, Sea.size_sea.y];
            Reset();
        }

        private void Reset()
        {
            shipLenght[1] = 4;
            shipLenght[2] = 3;
            shipLenght[3] = 2;
            shipLenght[4] = 1;
            for (int x = 0; x < Sea.size_sea.x; x++)
                for (int y = 0; y < Sea.size_sea.y; y++)
                    map[x, y] = 0;
            modeDanger = false;
        }

        public Status Fight (out Point target)
        {
            if (modeDanger)
                target = fightDanger();
            else
                target = fightShapes();

            Status status = sea.Shot(target);
            
            switch (status)
            {
                case Status.miss:
                    map[target.x, target.y] = 1;
                    break;
                case Status.wounded:
                    map[target.x, target.y] = 2;
                    modeDanger = true;
                    break;
                case Status.killed:
                case Status.win:
                    map[target.x, target.y] = 2;
                    int len = markKilledShip(target);
                    shipLenght[len]--;
                    modeDanger = false;
                    break;
            }
            return status;
        }

        private Point fightShapes()
        {
            InitPut();
            for (int x = 0; x < Sea.size_sea.x; x++)
                for (int y = 0; y < Sea.size_sea.y; y++)
                    if (map[x, y] == 0)
                        put[x, y] = shape[x, y];
            return RandomPut();
        }

        private Point fightDanger()
        {
            InitPut();

            for (int x = 0; x < Sea.size_sea.x; x++)
            {
                for (int y = 0; y < Sea.size_sea.y; y++)
                {
                    if (map[x, y] == 2)
                    {
                        bool longer = false;
                        Point ship = new Point(x, y);
                        for(int lenght = shipLenght.Length - 1; lenght >= 2; lenght--)
                        {
                            if (longer || shipLenght[lenght] > 0)
                            {
                                CheckShipDirection(ship, -1, 0, lenght);
                                CheckShipDirection(ship,  1, 0, lenght);
                                CheckShipDirection(ship,  0,-1, lenght);
                                CheckShipDirection(ship,  0, 1, lenght);
                                longer = true;
                            }
                        }
                    }
                }
            }
            

            return RandomPut();
        }

        //Проверить все клетки в указ.напр
        private void CheckShipDirection (Point ship, int sx, int sy, int length)
        {
            // текущая клетка должна быть со статусом "ранен"
            if (Map(ship.x, ship.y) != 2)
                return;
            //в остальных направлениях не должно быть клеток "ранен"
            if (Map(ship.x - sx, ship.y - sy) == 2)
                return;
            if (sx == 0)
            {
                if (Map(ship.x - 1, ship.y) == 2)
                    return;
                if (Map(ship.x + 1, ship.y) == 2)
                    return;
            }
            if (sy == 0)
            {
                if (Map(ship.x, ship.y - 1) == 2)
                    return;
                if (Map(ship.x, ship.y + 1) == 2)
                    return;
            }
            // может быть клетка "ранен"
            int unknown = 0;
            int unknown_j = 0;
            for (int j = 1; j < length; j++)
            {
                int p = Map(ship.x + j * sx, ship.y + j * sy);
                //в выбранном направлнеии не долдно быть клеток "мимо"
                if (p == 1)
                    return;
                if (p == -1)
                    return;
                //должны быть хоть одна клетка "неизвестно"
                if (p == 0)
                {
                    unknown++;
                    if (unknown == 1)
                        unknown_j = j;
                }
            }
            if (unknown >= 1)
                put[ship.x + unknown_j * sx, ship.y + unknown_j * sy]++;
        }

        private int Map(int x, int y)
        {
            if (sea.InSea(new Point(x, y)))
                return map[x, y];
            return -1;
        }

        private void InitPut()
        {
            for (int x = 0; x < Sea.size_sea.x; x++)
                for (int y = 0; y < Sea.size_sea.y; y++)
                    put[x, y] = 0;
        }

        private Point RandomPut()
        {
            int max = -1;
            int qty = 0;
            for (int x = 0; x < Sea.size_sea.x; x++)
                for (int y = 0; y < Sea.size_sea.y; y++)
                    if (put[x, y] > max)
                    {
                        max = put[x, y];
                        qty = 1;
                    }else
                    if (put[x, y] == max)
                        qty++;
                    

            int nr = rand.Next(0, qty);
            for (int x = 0; x < Sea.size_sea.x; x++)
                for (int y = 0; y < Sea.size_sea.y; y++)
                    if (put[x, y] == max)
                        if (nr-- == 0)
                            return new Point(x, y);
            return new Point(0, 0);

        }

        private int markKilledShip(Point place)
        {
            if (!sea.InSea(place))
                return 0;
            if (map[place.x, place.y] == 2)
            {
                map[place.x, place.y] = 3;
                int x, y;
                for (x = place.x - 1; x <= place.x + 1; x++)
                {
                    for (y = place.y - 1; y <= place.y + 1; y++)
                    {
                        if (Map(x, y) == 0)
                            map[x, y] = 1;

                    }
                }
                int length = 1;
                length += markKilledShip(new Point(place.x - 1, place.y));
                length += markKilledShip(new Point(place.x + 1, place.y));
                length += markKilledShip(new Point(place.x, place.y - 1));
                length += markKilledShip(new Point(place.x, place.y + 1));
                return length;
            }
            return 0;
        }

        


    }
}
