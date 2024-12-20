using System;
using System.Collections.Generic;

namespace SlotMachine.Models
{
    public class Slot
    {
        private int _balance;
        private int _stake;
        private readonly List<Reel> _reels;
        private readonly Theme _theme;

        public Slot(Theme theme, List<Reel> reels, int initialBalance)
        {
            _theme = theme;
            _balance = initialBalance;
            _reels = reels;
        }

        public int Balance => _balance;

        public int Stake
        {
            get => _stake;
            set => _stake = value;
        }

        public void Spin()
        {
            foreach (var reel in _reels)
            {
                reel.Spin();
            }
        }

        public int CheckResult()
        {
            int winnings = 0;

            if (_reels[0].Symbol == _reels[1].Symbol && _reels[1].Symbol == _reels[2].Symbol)
            {
                winnings = _stake * 10;
            }
            else if (_reels[0].Symbol == _reels[1].Symbol || _reels[1].Symbol == _reels[2].Symbol || _reels[0].Symbol == _reels[2].Symbol)
            {
                winnings = _stake * 2;
            }

            return winnings;
        }

        public void UpdateBalance(int amount)
        {
            _balance += amount;
        }

        public void Play()
        {
            Console.WriteLine("Spinning...");
            foreach (var reel in _reels)
            {
                reel.Spin();
            }

            int winnings = CheckResult();
            if (winnings > 0)
            {
                Console.WriteLine($"Congratulations! You won {winnings} credits.");
                UpdateBalance(winnings);
            }
            else
            {
                Console.WriteLine("Better luck next time!");
                UpdateBalance(-_stake);
            }

            Console.WriteLine($"Your current balance is: {_balance} credits.");
        }
    }
}
