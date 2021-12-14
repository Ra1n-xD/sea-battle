namespace SeaBattle
{
    class Ship
    {
        int hit;

        public Point[] deck
        {
            get; private set;
        }

        public Ship(Point[] deck)
        {
            this.deck = deck;
            hit = 0;
        }

        public Status Shot(Point t)
        {
            for (int j = 0; j < deck.Length; j++)
            {
                if (deck[j].x == t.x && deck[j].y == t.y)
                {
                    hit++;
                    if (hit == deck.Length)
                        return Status.killed;
                    else
                        return Status.wounded;       
                } 
            }
            return Status.miss;
        }
    } 
}
