namespace Hearthstone_Deck_Tracker.Hearthstone
{
	public class Mechanic
	{
		public Mechanic(string name, Deck deck)
		{
			Name = name;
			Count = deck.GetMechanicCount(name);
		}

		public string Name { get; }
		public int Count { get; }

		public string DisplayValue => $"{getDisplayValueCN(Name)}: {Count}";

        private string getDisplayValueCN(string name) {
            if (name == "Battlecry") {
                return "ս��";
            } else if (name == "Charge") {
                return "���";
            } else if (name == "Combo")
            {
                return "����";
            }
            else if (name == "Deathrattle")
            {
                return "����";
            }
            else if (name == "Divine Shield")
            {
                return "ʥ��";
            }
            else if (name == "Freeze")
            {
                return "����";
            }
            else if (name == "Inspire")
            {
                return "����";
            }
            else if (name == "Secret")
            {
                return "����";
            }
            else if (name == "Taunt")
            {
                return "����";
            }
            else if (name == "Spellpower")
            {
                return "��ǿ";
            }
            else if (name == "Windfury")
            {
                return "��ŭ";
            }
            return name;
        }
	}
}