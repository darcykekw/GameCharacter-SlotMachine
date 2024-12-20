using System;
using System.Drawing;
using System.Windows.Forms;


namespace SlotMachine.Models
{
    public class Reel
    {
        private string _symbol;
        private readonly Label _label;
        private readonly Theme _theme;
        private static readonly Random _random = new Random();

        public Reel(Label label, Theme theme)
        {
            _label = label;
            _theme = theme;
            _label.Font = _theme.ThemeFont;
            _label.ForeColor = _theme.ThemeColor;

            Symbol = GetRandomSymbol();
        }

        public string Symbol
        {
            get => _symbol;
            private set
            {
                _symbol = value;
                _label.Text = _symbol;
            }
        }

        public void Spin()
        {
            Symbol = GetRandomSymbol();
        }

        private string GetRandomSymbol()
        {
            return _theme.Symbols[_random.Next(_theme.Symbols.Count)];
        }
    }
}
