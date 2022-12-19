using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantLibrary.Repositories
{
    public static class Clock
    {
        public static async Task ClockAsync(Label label)
        {
            for (; ; )
            {
                await Task.Delay(1);
                label.Text = DateTime.Now.ToString("HH:mm:ss");
            }
        }
    }
}