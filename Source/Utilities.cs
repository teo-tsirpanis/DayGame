using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace DayGame
{
    public static class Utilities
    {
        public static Button[] GetButtonsInOrder(Control parent) =>
            parent
                .Controls.OfType<Button>()
                .OrderBy(btn => btn.Location.Y)
                .ThenBy(btn => btn.Location.X)
                .ToArray();
    }
}
