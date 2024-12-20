using System.Collections.Generic;
using System.Drawing;


namespace SlotMachine.Models
{
    public class JewelsTheme : Theme
    {
        public override List<string> Symbols => new List<string> { "💎", "🌟", "💖", "💛" };
        public override Font ThemeFont => new Font("Times New Roman", 30, FontStyle.Underline);
        public override Color ThemeColor => Color.Blue;
    }
}
