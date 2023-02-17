namespace M5_02
{
    public class Rectangle
    {
        public double width, height;
        public Rectangle(double width, double height) 
        {
            this.width = width;
            this.height = height;
        }

        public virtual void SetWidth(double newWidth)
        {
            width = newWidth;
        }

        public virtual void SetHeight(double newHeight)
        {
            height = newHeight;
        }

        public double GetArea()
        {
            return width * height;
        }

        public double GetPerimeter()
        {
            return 2*width + 2*height;
        }

        public double GetDiagonal()
        {
            return Math.Round(Math.Sqrt(width * width + height * height), 2);
        }

        public string GetPicture()
        {
            if (width > 50 || height > 50)
                return "Too big for picture.";

            string picture = "";
            for (int h = 0; h < height; h++)
            {
                string line = "";
                for (int w = 0; w < width; w++)
                {
                    line += "*";
                } 
                picture += line +"\n";
            }
            return picture;
        }

        public double GetAmountInside(Rectangle insideObj)
        {
            double amount = 0;
            double objWidth = insideObj.width;
            double objHeight = insideObj.height;

            double onLenght = Math.Floor(width/objWidth);
            double onHeight = Math.Floor(height/objHeight);

            // amount = onLenght < onHeight ? onLenght : onHeight;
            amount = (onLenght * onHeight);
            return amount;
        }

        public virtual string GetStringDescription()
        {
            return $"Rectangle(width={width}, height={height})";
        }
    }
}
