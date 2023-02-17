using M5_02;

namespace Test_M5_02
{
    
    public class SquareTest
    {
        Square sq1 = new(3);
        Rectangle rect1 = new(2, 1);
        Square sq2 = new(1);
        Square sq3 = new(5);

        [Fact]
        public void Square_is_Sublass_of_Rectangle()
        {
            bool actual = typeof(Square).IsSubclassOf(typeof(Rectangle));
            Assert.True(actual);
        }

        [Fact]
        public void Square_setSide() 
        {
            sq1.SetSide(6);
            double actual = sq1.side;

            Assert.Equal(6, actual);
        }

        [Fact]
        public void Square_setWidth()
        {
            sq1.SetWidth(11);
            double actualWidth = sq1.width;
            double actualHeight = sq1.height;
            double actualSide = sq1.side;
            
            Assert.Equal(11, actualWidth);
            Assert.Equal(11, actualHeight);
            Assert.Equal(11, actualSide);
        }

        [Fact]
        public void Square_setHeight()
        {
            sq1.SetHeight(123);
            double actualWidth = sq1.width;
            double actualHeight = sq1.height;
            double actualSide = sq1.side;

            Assert.Equal(123, actualWidth);
            Assert.Equal(123, actualHeight);
            Assert.Equal(123, actualSide);
        }

        [Fact]
        public void Square_getArea()
        {
            double actual = sq1.GetArea();
            Assert.Equal(9, actual);
            sq1.SetSide(5);
            actual= sq1.GetArea();
            Assert.Equal(25, actual);
        }

        [Fact]
        public void Square_getPerimeter()
        {
            double actual = sq1.GetPerimeter();
            Assert.Equal(12, actual);
            sq1.SetHeight(4);
            actual= sq1.GetPerimeter(); 
            Assert.Equal(16, actual);
        }

        [Fact]
        public void Square_getDiagonal()
        {
            double actual = sq1.GetDiagonal();
            Assert.Equal(4.24, actual);
            sq1.SetWidth(5);
            actual = sq1.GetDiagonal();
            Assert.Equal(7.07, actual);
        }

        public void Square_getPicture()
        {
            string actual = sq1.GetPicture();
            string expected = "***\n***\n***\n";
            Assert.Equal(expected, actual); 
        }

        [Fact]
        public void Square_getStringDescription()
        {
            string actual = sq1.GetStringDescription();
            string expected = "Square(side = 3)";
        }

        [Fact]
        public void Square_getAmountInside()
        {
            double actual = sq1.GetAmountInside(rect1);
            Assert.Equal(3, actual);
            actual = sq1.GetAmountInside(sq2);
            Assert.Equal(9, actual);
            actual = sq1.GetAmountInside(sq3);
            Assert.Equal(0, actual);
        }
    }
}
