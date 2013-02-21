using System;

namespace ES.Lab.Read
{
    public class Round
    {
        public Round(int round)
        {
            this.Number = round;
        }

        public int Number { get; set; }

        public bool PlayerOneHasMadeMove { get; set; }

        public bool PlayerTwoHasMadeMove { get; set; }
    }
}