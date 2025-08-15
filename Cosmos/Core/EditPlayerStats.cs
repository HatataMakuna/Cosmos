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
        private Dictionary<string, int> _originalStats;
        private Dictionary<string, int> _editedStats;
        private int _originalAvailablePoints;
        private int _editedAvailablePoints;
        public int EditedAvailablePoints => _editedAvailablePoints;

        public event PropertyChangedEventHandler PropertyChanged;

        public EditPlayerStats(Player player)
        {
            _currentPlayer = player ?? throw new ArgumentNullException(nameof(player));
            _originalStats = new Dictionary<string, int>
            {
                { "Speed", player.speed },
                { "Tech", player.tech },
                { "Grip", player.grip },
                { "Strength", player.strength },
                { "Endurance", player.endurance },
                { "Agility", player.agility },
                { "Balance", player.balance },
                { "Lache", player.lache },
                { "Stamina", player.stamina },
                { "Intelligence", player.intelligence }
            };
            _editedStats = new Dictionary<string, int>(_originalStats);
            _originalAvailablePoints = player.availablePoints;
            _editedAvailablePoints = _originalAvailablePoints;
        }

        public int GetEditedStat(string stat)
        {
            return _editedStats.ContainsKey(stat) ? _editedStats[stat] : 0;
        }

        public int GetOriginalStat(string stat)
        {
            return _originalStats.ContainsKey(stat) ? _originalStats[stat] : 0;
        }

        public void AddStat(string stat)
        {
            if (_editedAvailablePoints > 0 && _editedStats.ContainsKey(stat))
            {
                _editedStats[stat]++;
                _editedAvailablePoints--;
                OnPropertyChanged(stat);
                OnPropertyChanged("AvailablePoints");
            }
        }

        public void MinusStat(string stat)
        {
            if (_editedStats.ContainsKey(stat) && _editedStats[stat] > _originalStats[stat])
            {
                _editedStats[stat]--;
                _editedAvailablePoints++;
                OnPropertyChanged(stat);
                OnPropertyChanged("AvailablePoints");
            }
        }

        public bool CanAddStat(string stat)
        {
            return _editedAvailablePoints > 0;
        }

        public bool CanMinusStat(string stat)
        {
            return _editedStats.ContainsKey(stat) && _editedStats[stat] > _originalStats[stat];
        }

        public void SaveStats()
        {
            foreach (var stat in _editedStats.Keys)
            {
                typeof(Player).GetProperty(stat.ToLower()).SetValue(_currentPlayer, _editedStats[stat]);
            }
            _currentPlayer.availablePoints = _editedAvailablePoints;
        }

        public void ResetStats()
        {
            _editedStats = new Dictionary<string, int>(_originalStats);
            _editedAvailablePoints = _originalAvailablePoints;
            foreach (var stat in _editedStats.Keys)
            {
                OnPropertyChanged(stat);
            }
            OnPropertyChanged("AvailablePoints");
        }

        // Enable save button when changes are made
        public bool HasChanges()
        {
            return !_editedStats.SequenceEqual(_originalStats) || _editedAvailablePoints != _originalAvailablePoints;
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
