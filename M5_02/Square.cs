namespace M5_02
{
    public class Square: Rectangle
    {
        public double side;

        public Square(double side) : base(side, side) 
        {
            this.side = side;
        }

        public void SetSide(double newSide)
        {
            width = newSide;
            height = newSide;
            side = newSide; 
        }

        public override void SetWidth(double newSide)
        {
            width = newSide;
            height= newSide;
            side= newSide;
        }

        public override void SetHeight(double newSide)
        {
            width = newSide;
            height = newSide;
            side = newSide;
        }

        public override string GetStringDescription()
        {
            return $"Square(side={side})";
        }
    }
}
