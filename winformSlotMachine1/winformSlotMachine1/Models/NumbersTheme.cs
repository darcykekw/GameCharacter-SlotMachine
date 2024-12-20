using System.Collections.Generic;
using System.Drawing;


namespace SlotMachine.Models
{
    public class NumbersTheme : Theme
    {
        public override List<string> Symbols => new List<string> { "1", "2", "3", "4", "5" };
        public override Font ThemeFont => new Font("Verdana", 30, FontStyle.Regular);
        public override Color ThemeColor => Color.Black;
    }
}
