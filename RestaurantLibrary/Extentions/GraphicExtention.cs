using System.Drawing;

namespace RestaurantLibrary.Extentions
{
    public static class GraphicExtention
    {
        public static void TableOneGreenLight(this Graphics formGraphics, bool tableAvailable)
        {
            SolidBrush myBrush = new SolidBrush(Color.Green);

            if (!tableAvailable)
            {
                myBrush = new SolidBrush(Color.Red);
            }
            formGraphics.FillEllipse(myBrush, new Rectangle(420, 85, 25, 25));
        }
        public static void TableTwoGreenLight(this Graphics formGraphics, bool tableAvailable)
        {
            SolidBrush myBrush = new SolidBrush(Color.Green);

            if (!tableAvailable)
            {
                myBrush = new SolidBrush(Color.Red);
            }
            formGraphics.FillEllipse(myBrush, new Rectangle(420, 275, 25, 25));
        }
        public static void TableThreeGreenLight(this Graphics formGraphics, bool tableAvailable)
        {
            SolidBrush myBrush = new SolidBrush(Color.Green);

            if (!tableAvailable)
            {
                myBrush = new SolidBrush(Color.Red);
            }
            formGraphics.FillEllipse(myBrush, new Rectangle(420, 465, 25, 25));
        }
    }
}