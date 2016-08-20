namespace Hearthstone_Deck_Tracker.Enums
{
    public enum GameResult
    {
        None,
        Win,
        Loss,
        Draw
    }

    public enum GameResultAll
    {
        All,
        Win,
        Loss,
        Draw
    }

    public class GameResultAllConverter {
        public static string convert(GameResultAll res) {
            switch (res) {
                case GameResultAll.All:
                    return "ȫ��";
                case GameResultAll.Win:
                    return "ʤ��";
                case GameResultAll.Loss:
                    return "ʧ��";
                case GameResultAll.Draw:
                    return "����";
            }
            return "ȫ��";
        }
        public static GameResultAll convert(string res)
        {
            switch (res)
            {
                case "ȫ��":
                    return GameResultAll.All;
                case "ʤ��" :
                    return GameResultAll.Win;
                case "ʧ��":
                    return GameResultAll.Loss;
                case "����":
                    return GameResultAll.Draw;
            }
            return GameResultAll.All;
        }
    }
}