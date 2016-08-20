#region

using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Media;
using Hearthstone_Deck_Tracker.Enums;

#endregion

namespace Hearthstone_Deck_Tracker.Stats.CompiledStats
{
	public class MatchupStats
	{
		public MatchupStats(string @class, IEnumerable<GameStats> games)
		{
			Class = @class;
            CNClass = translateClass2CN(Class);
            Games = games;
		}

        private string translateClass2CN(string s)
        {
            s = s.ToLowerInvariant();
            if (s.Equals("hunter"))
            {
                return "����";
            }
            else if (s.Equals("paladin"))
            {
                return "ʥ��ʿ";
            }
            else if (s.Equals("priest"))
            {
                return "��ʦ";
            }
            else if (s.Equals("warrior"))
            {
                return "սʿ";
            }
            else if (s.Equals("warlock"))
            {
                return "��ʿ";
            }
            else if (s.Equals("druid"))
            {
                return "��³��";
            }
            else if (s.Equals("mage"))
            {
                return "��ʦ";
            }
            else if (s.Equals("shaman"))
            {
                return "����";
            }
            else if (s.Equals("rogue"))
            {
                return "Ǳ����";
            }
            return s;
        }

        public IEnumerable<GameStats> Games { get; set; }

		public int Wins => Games.Count(x => x.Result == GameResult.Win);

		public int Losses => Games.Count(x => x.Result == GameResult.Loss);

		public double WinRate => (double)Wins / (Wins + Losses);

		public string Class { get; set; }
        public string CNClass { get; }

		public double WinRatePercent => Math.Round(WinRate * 100);

		public SolidColorBrush WinRateTextBrush
		{
			get
			{
				if(double.IsNaN(WinRate) || !Config.Instance.ArenaStatsTextColoring)
					return new SolidColorBrush(Config.Instance.StatsInWindow && Config.Instance.AppTheme != MetroTheme.BaseDark ? Colors.Black : Colors.White);
				return new SolidColorBrush(WinRate >= 0.5 ? Colors.Green : Colors.Red);
			}
		}

		public string Summary => Config.Instance.ConstructedStatsAsPercent ? (double.IsNaN(WinRate) ? "-" : $" {WinRatePercent}%") : $"{Wins} - {Losses}";
	}
}