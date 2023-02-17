using M5_02;

namespace Test_M5_02
{
    public class RectangleTest
    {

        Rectangle rect = new(3, 6);
        Rectangle rect2 = new(2, 4);
        Rectangle rect3 = new(2, 1);
        Rectangle rect4 = new(2, 23);
        Rectangle rect5 = new(1, 2);

        [Fact]
        public void Rectangle_set_width()
        {
            rect.SetWidth(8);
            double actual = rect.width;
            Assert.Equal(8, actual);
            rect.SetWidth(39);
            rect.SetWidth(15);
            actual = rect.width;
            Assert.Equal(15, actual);
        }

        [Fact]
        public void Rectangle_set_height()
        {
            rect.SetHeight(7);
            double actual = rect.height;
            Assert.Equal(7, actual);
            rect.SetHeight(8);
            rect.SetHeight(33);
            actual= rect.height;
            Assert.Equal(33, actual);
        }

        [Fact]
        public void Rectangle_get_area()
        {
            double area = rect.GetArea();
            Assert.Equal(18, area);
            rect.SetWidth(6);
            rect.SetHeight(6);
            area = rect.GetArea();
            Assert.Equal(36, area);
        }

        [Fact]
        public void Rectangle_get_perimeter()
        {
            double perimeter = rect.GetPerimeter();
            Assert.Equal(18, perimeter);
            rect.SetWidth(2);
            rect.SetHeight(3);
            perimeter = rect.GetPerimeter();
            Assert.Equal(10, perimeter);
        }

        [Fact]
        public void Rectangle_get_diagonal()
        {
            double diagonal = rect.GetDiagonal();
            double expected = 6.71;
            Assert.Equal(expected, diagonal);
            rect.SetWidth(3);
            rect.SetHeight(4);
            diagonal = rect.GetDiagonal();
            Assert.Equal(5, diagonal);
        }

        [Fact]
        public void Rectangle_get_picture()
        {
            string actual = rect.GetPicture();
            string expected = "***\n***\n***\n***\n***\n***\n";
            Assert.Equal(expected, actual);
            rect.SetWidth(2);
            rect.SetHeight(3);
            actual = rect.GetPicture();
            expected = "**\n**\n**\n";
            Assert.Equal(expected, actual);
            rect.SetWidth(300);
            actual = rect.GetPicture();
            Assert.Equal("Too big for picture.", actual);
        }

        [Fact]
        public void Rectangle_get_amount_inside()
        {
            double actual = rect.GetAmountInside(rect2);
            double expected = 1;
            Assert.Equal(expected, actual); 
            actual= rect.GetAmountInside(rect3);
            expected= 6;
            Assert.Equal(expected, actual);
            actual= rect.GetAmountInside(rect4);
            expected= 0;
            Assert.Equal(expected, actual);
            actual= rect.GetAmountInside(rect5);
            expected = 9;
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Rectangle_get_string_description()
        {
            string actual = rect.GetStringDescription();
            string expected = "Rectangle(width=3, height=6)";
            Assert.Equal(expected, actual);
        }
    }
}
