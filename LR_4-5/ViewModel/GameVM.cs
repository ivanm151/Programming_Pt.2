using LR_4_5.Model;
using System.Windows;


namespace LR_4_5.ViewModel
{
    public class GameVM : VM
    {
        private Game game1;
        public Game Game1 { get { return game1; } }

        public GameVM()
        {
            game1 = new Game();
            game1.StartNewGame(16);
        }

        private Command startNewGameCommand;
        public Command StartNewGameCommand
        {
            get
            {
                return startNewGameCommand ??
                    (startNewGameCommand = new Command(obj =>
                    {
                        if (int.TryParse((string)obj, out int num))
                        {
                            if (!game1.StartNewGame(num))
                                MessageBox.Show("Минимальное количество букв: 4", "Неверный ввод");

                        }
                        else MessageBox.Show("Введите числовое значение", "Неверный ввод");
                    }));
            }
        }

        private Command clearCommand;
        public Command ClearCommand
        {
            get
            {
                return clearCommand ??
                    (clearCommand = new Command(obj =>
                    {
                        game1.ClearWord();
                    }));
            }
        }

        /* private Command checkCommand;
        public Command CheckCommand
        {
            get
            {
                return checkCommand ??
                    (checkCommand = new Command(async obj =>
                    {
                        if (!await game1.CheckWord(CheckWordTextGears.CheckWord, "b1D2VhZMMzRyD4bF"))
                            MessageBox.Show("Введите другое значение", "Некорректный ввод");
                    }));
            }
        }*/

        private Command letterCommand;
        public Command LetterCommand
        {
            get
            {
                return letterCommand ??
                    (letterCommand = new Command(obj =>
                    {
                        if (int.TryParse((string)obj, out int id))
                        {
                            game1.PressLetter(id);
                        }
                    }));
            }
        }
    }

}
