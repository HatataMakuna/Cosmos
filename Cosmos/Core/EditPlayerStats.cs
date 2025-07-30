using Cosmos.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cosmos.Core
{
    public class EditPlayerStats
    {
        private Player _currentPlayer;
        public event PropertyChangedEventHandler PropertyChanged;

        public EditPlayerStats(Player player)
        {
            _currentPlayer = player ?? throw new ArgumentNullException(nameof(player));
        }

        public void AddStat(string stat)
        {
            switch (stat)
            {
                case "Speed":
                    if (_currentPlayer.availablePoints > 0)
                    {
                        _currentPlayer.speed++;
                        _currentPlayer.availablePoints--;
                        OnPropertyChanged(nameof(_currentPlayer.speed));
                        OnPropertyChanged(nameof(_currentPlayer.availablePoints));
                    }
                    break;
                case "Tech":
                    if (_currentPlayer.availablePoints > 0)
                    {
                        _currentPlayer.tech++;
                        _currentPlayer.availablePoints--;
                        OnPropertyChanged(nameof(_currentPlayer.tech));
                        OnPropertyChanged(nameof(_currentPlayer.availablePoints));
                    }
                    break;
                case "Grip":
                    if (_currentPlayer.availablePoints > 0)
                    {
                        _currentPlayer.grip++;
                        _currentPlayer.availablePoints--;
                        OnPropertyChanged(nameof(_currentPlayer.grip));
                        OnPropertyChanged(nameof(_currentPlayer.availablePoints));
                    }
                    break;
                case "Strength":
                    if (_currentPlayer.availablePoints > 0)
                    {
                        _currentPlayer.strength++;
                        _currentPlayer.availablePoints--;
                        OnPropertyChanged(nameof(_currentPlayer.strength));
                        OnPropertyChanged(nameof(_currentPlayer.availablePoints));
                    }
                    break;
                case "Endurance":
                    if (_currentPlayer.availablePoints > 0)
                    {
                        _currentPlayer.endurance++;
                        _currentPlayer.availablePoints--;
                        OnPropertyChanged(nameof(_currentPlayer.endurance));
                        OnPropertyChanged(nameof(_currentPlayer.availablePoints));
                    }
                    break;
                case "Agility":
                    if (_currentPlayer.availablePoints > 0)
                    {
                        _currentPlayer.agility++;
                        _currentPlayer.availablePoints--;
                        OnPropertyChanged(nameof(_currentPlayer.agility));
                        OnPropertyChanged(nameof(_currentPlayer.availablePoints));
                    }
                    break;
                case "Balance":
                    if (_currentPlayer.availablePoints > 0)
                    {
                        _currentPlayer.balance++;
                        _currentPlayer.availablePoints--;
                        OnPropertyChanged(nameof(_currentPlayer.balance));
                        OnPropertyChanged(nameof(_currentPlayer.availablePoints));
                    }
                    break;
                case "Lache":
                    if (_currentPlayer.availablePoints > 0)
                    {
                        _currentPlayer.lache++;
                        _currentPlayer.availablePoints--;
                        OnPropertyChanged(nameof(_currentPlayer.lache));
                        OnPropertyChanged(nameof(_currentPlayer.availablePoints));
                    }
                    break;
                case "Stamina":
                    if (_currentPlayer.availablePoints > 0)
                    {
                        _currentPlayer.stamina++;
                        _currentPlayer.availablePoints--;
                        OnPropertyChanged(nameof(_currentPlayer.stamina));
                        OnPropertyChanged(nameof(_currentPlayer.availablePoints));
                    }
                    break;
                case "Intelligence":
                    if (_currentPlayer.availablePoints > 0)
                    {
                        _currentPlayer.intelligence++;
                        _currentPlayer.availablePoints--;
                        OnPropertyChanged(nameof(_currentPlayer.intelligence));
                        OnPropertyChanged(nameof(_currentPlayer.availablePoints));
                    }
                    break;
                default: break;
            }
        }

        protected void OnPropertyChanged(string name)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(name));
            }
        }
    }
}
