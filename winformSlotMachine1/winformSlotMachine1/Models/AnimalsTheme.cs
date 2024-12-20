using System.Collections.Generic;
using System.Drawing;


namespace SlotMachine.Models
{
    public class AnimalsTheme : Theme
    {
        public override List<string> Symbols => new List<string> { "🐮", "🐇", "🐢", "🐼" };
        public override Font ThemeFont => new Font("Courier New", 30, FontStyle.Italic);
        public override Color ThemeColor => Color.Green;
    }
}
