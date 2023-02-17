namespace M5_02
{
    internal class Program
    {
        private static void Main()
        {

            Rectangle rect = new(5, 10);
            Console.WriteLine(rect.GetArea());
            rect.SetWidth(3);
            Console.WriteLine(rect.GetPerimeter());
            Console.WriteLine(rect.GetStringDescription());

            Square sq = new(9);
            Console.WriteLine(sq.GetArea());
            sq.SetSide(4);
            Console.WriteLine(sq.GetDiagonal());
            Console.WriteLine(sq.GetPicture());

            Console.WriteLine("Thank you!!!");
        }
    }
}
