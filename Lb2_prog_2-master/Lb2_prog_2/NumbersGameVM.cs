using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Documents;
using Lb2_prog_2.model;

namespace Lb2_prog_2
{
    internal class NumbersGameVM : INotifyPropertyChanged
    {
        private NumGame game;
       
        private int counter;
        public int Counter { get { return counter; } set { counter = value; } }
        
        public NumGame Game { get { return game; } }
        //private Versi ver;
        //public Versi Ver { get { return ver; } set { ver = value; } }


        private int vers;
        public int Vers { get { return vers; } set { vers = value; OnPropertyChanged("Vers"); } }
        
        
        
        private Versi ver;
        public Versi Ver {get { return ver; } set { ver = value; } }


        public int GetValue()
        {
            MessageBox.Show(Ver.ToString());
            return 0;
        }

        public NumbersGameVM()
        {


            Random random = new Random();
            vers = random.Next(1, 3);

            if (vers == 1)
                game = new SmallGame();
            if (vers == 2)
                game = new SmallGame();
            game = new ExtendedSmallGame(Game);
            if (vers == 3)
                game = new BigGame();
            game.StartNewGame(5);

            /*ver = new Versi();
            if(ver.Vers == 1)
                game = new SmallGame();
            if (ver.Vers == 2)
                game = new SmallGame();
                game = new ExtendedSmallGame(Game);
            if (ver.Vers == 3)
                game = new BigGame();
            game.StartNewGame(5);*/


        }

        

       
        public void StopGame()
        {
            if (Game.NumList.Count == Game.Gs)
            {
                MessageBox.Show("Игра окончена! Ваш результат: "+Counter.ToString()+" ходов.");                
                Counter = 0;
                
            }
        }

        private Command startNewGameCommand;
        public Command StartNewGameCommand
        {
            get {
                return startNewGameCommand ??
                    (startNewGameCommand = new Command(obj =>
                    {
                        if (int.TryParse((string)obj, out int num))
                        {

                            
                            if (!game.StartNewGame(num))
                                MessageBox.Show("Неверный ввод");
                        }
                        else MessageBox.Show("Введите числовое значение", "Неверный ввод");
                    })); }
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
