using System;
using System.Collections.Generic;
using System.Drawing;

namespace SlotMachine.Models
{
    public abstract class Theme
    {
        public abstract List<string> Symbols { get; }
        public abstract Font ThemeFont { get; }
        public abstract Color ThemeColor { get; }
    }
}
