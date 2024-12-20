using System.Collections.Generic;
using System.Drawing;


namespace SlotMachine.Models
{
    public class FruitsTheme : Theme
    {
        public override List<string> Symbols => new List<string> { "🍒", "🍋", "🔔", "⭐", "🍇", "💎" };
        public override Font ThemeFont => new Font("Segoe UI Emoji", 30, FontStyle.Bold);
        public override Color ThemeColor => Color.Red;
    }
}
