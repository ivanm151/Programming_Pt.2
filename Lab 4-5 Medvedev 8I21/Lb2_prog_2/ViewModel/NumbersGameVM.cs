using Lab_4_5.model;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;

namespace Lab_4_5
{
    internal class NumbersGameVM : INotifyPropertyChanged
    {
        private NumGame game;

        private int counter;
        public int Counter { get { return counter; } set { counter = value; } }

        public NumGame Game { get { return game; } }

        // Не меняются значения после приивязки
        private int vers;
        public int Vers { get { return vers; } set { vers = value; OnPropertyChanged("Vers"); } }

        public NumbersGameVM()
        {
            vers = new int();
            //ChooseGame(vers); vers не получает значение, game всегда null
            game = new SmallGame();
            game.StartNewGame(5);
        }

        public void ChooseGame(int a)
        {
            game = null;
            if (a == 1)
                game = new SmallGame();
            if (a == 2)
                game = new SmallGame();
            game = new ExtendedSmallGame(Game);
            if (a == 3)
                game = new BigGame();
        }
        public void StopGame()
        {
            if (Game.NumList.Count == Game.Gs)
            {
                MessageBox.Show("Игра окончена! Ваш результат: " + Counter.ToString() + " ходов.");
                Counter = 0;
            }
        }
        private Command startNewGameCommand;
        public Command StartNewGameCommand
        {
            get
            {
                return startNewGameCommand ??
                    (startNewGameCommand = new Command(obj =>
                    {
                        //ChooseGame(vers); vers не получает значение, game всегда null
                        if (int.TryParse((string)obj, out int num))
                        {

                            if (!game.StartNewGame(num))
                                MessageBox.Show("Неверный ввод");
                        }
                        else MessageBox.Show("Введите числовое значение", "Неверный ввод");
                    }));
            }
        }
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
                            game.PressLetter(id);
                            Counter += 1;
                            StopGame();
                        }
                    }));
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
