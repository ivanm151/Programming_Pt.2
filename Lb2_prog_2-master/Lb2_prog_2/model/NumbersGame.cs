using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Lb2_prog_2.model
{
    abstract class NumGame : INotifyPropertyChanged
    {
        public struct Number
        {
            // Структура для более удобного хранения информации о содержимом кнопки
            public Number(int i, string l)
            {
                id = i;
                number = l;
                isNotPressed = true;
            }
            public int id { get; set; }
            public string number { get; set; }
            public bool isNotPressed { get; set; }
        }
        // Список символов достыхных для набора слова
        private ObservableCollection<Number> numbers;
        public ReadOnlyObservableCollection<Number> Numbers { get; }
        // Список введённых слов, которые прошли проверку
        private ObservableCollection<string> numList;
        public ReadOnlyObservableCollection<string> NumList { get; }
        private ObservableCollection<string> guess;
        public ReadOnlyObservableCollection<string> Guess { get; }
        private int gs;
        public int Gs { get { return gs; } set { gs = value; } }



       
        public NumGame()
        {
            gs = 1;
            Gs = gs;
            
            guess = new ObservableCollection<string>();
            Guess = new ReadOnlyObservableCollection<string>(this.guess);
            numbers = new ObservableCollection<Number>();
            Numbers = new ReadOnlyObservableCollection<Number>(this.numbers);
            numList = new ObservableCollection<string>();
            NumList = new ReadOnlyObservableCollection<string>(this.numList);
        }
        public abstract int UpLimit();
        public abstract int NumsLimit();
        public bool StartNewGame(int num)
        {
            if (num < 4 || num > NumsLimit())
                return false;
            
            for (int i = 0; i < numbers.Count; i++)
            {
                Number letter = numbers[i];
                letter.isNotPressed = true;
                numbers[i] = letter;
            }
            guess.Clear();
            numList.Clear();
            SetRandomLetters(num);
            return true;
        }
        private void SetRandomLetters(int num)
        {
            numbers.Clear();
            Random random = new Random();
            int c;
            for (int i = 0; i < num; i++)
            {
                c = random.Next(1, UpLimit());
                numbers.Add(new Number(i, c.ToString()));
            }
            while (guess.Count < gs)
            {
                int a = random.Next(numbers.Count);
                string s = numbers[a].number;
                CheckGs(s);
            }
        }
       
        public bool PressLetter(int id)
        {
            if (id >= 0 && id < numbers.Count)
            {
                var l = numbers[id];                
                CheckWord(l.number);
                l.isNotPressed = false;
                numbers[id] = l;
                return true;
            }
            return false;
        }
        public bool CheckGs(string word)
        {
            if (!guess.Contains(word))
            {
                guess.Add(word);
                return true;
            }
            else
                return false;
        }       
        public bool CheckWord(string word)
        {
            if (!numList.Contains(word) && guess.Contains(word))
            {               
                numList.Add(word);
                return true;
            }            
            return false;
        }   
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }   
    class BigGame : NumGame
    {
        public BigGame() : base() { }
        public override int NumsLimit()
        {
            return 25;
        }
        public override int UpLimit()
        {
            return 1000;
        }
    }
    class SmallGame : NumGame
    {
        public SmallGame() : base() { }
        public override int NumsLimit()
        {
            return 10;
        }
        public override int UpLimit()
        {
            return 100;
        }
    }
    abstract class NumGameDecorator : NumGame
    {
        protected NumGame game;
        public NumGameDecorator(NumGame game) : base()
        {
            this.game = game;
        }
    }
    class ExtendedSmallGame : NumGameDecorator
    {
        public ExtendedSmallGame(NumGame game1) : base(game1) { }
        public override int NumsLimit()
        {
            return game.NumsLimit() + 5;
        }
        public override int UpLimit()
        {
            return game.UpLimit() + 100;
        }
    }
    public class Versi : INotifyPropertyChanged
    {
        private int vers;
        public int Vers
        {
            get { return vers; }
            set
            {
                vers = value;
                OnPropertyChanged("Vers");
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
