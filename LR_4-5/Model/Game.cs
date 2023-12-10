using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace LR_4_5.Model
{
    public class Game : INotifyPropertyChanged
    {
        public struct Letter
        {
            // Структура для более удобного хранения информации о содержимом кнопки
            public Letter(string l)
            {               
                letter = l;                
                isNotPressed = true;
            }
            public string letter { get; set; }            
            public bool isNotPressed { get; set; }
        }

        readonly string ABC = "0123456789";


        // Баллы для каждого символа алфавита
        // Необходимо для присвоения одинаковым буквам одинаковых баллов
        private int[] letterPoints;
        // Список символов достыхных для набора слова
        private ObservableCollection<Letter> letters;
        public ReadOnlyObservableCollection<Letter> Letters { get; }
        // Список введённых слов, которые прошли проверку
        private ObservableCollection<string> wordsHistory;
        public ReadOnlyObservableCollection<string> WordsHistory { get; }
        // Текущее набираемое слово
        private string word;




        public string Word
        {
            get { return word; }
            private set
            {
                word = value;
                OnPropertyChanged("Word");
            }
        }


        public Game()
        {
            letterPoints = new int[ABC.Length];
            word = "";
            letters = new ObservableCollection<Letter>();
            Letters = new ReadOnlyObservableCollection<Letter>(this.letters);
            wordsHistory = new ObservableCollection<string>();
            WordsHistory = new ReadOnlyObservableCollection<string>(this.wordsHistory);
        }

        public bool StartNewGame(int num)
        {
            if (num < 4)
                return false;
            ClearWord();

            wordsHistory.Clear();

            SetRandomLetters(num);
            return true;
        }

        // Установка списка доступных для ввода символов
        private void SetRandomLetters(int num)
        {
            letters.Clear();
            Random random = new Random();           
            int c;
            for (int i = 0; i < num; i++)
            {
                c = (c = random.Next(ABC.Length + 10)) > 19 ? c - 10 : c / 2;
                letters.Add(new Letter(ABC[c].ToString()));
            }
        }

        public bool PressLetter(int id)
        {
            if (id >= 0 && id < letters.Count)
            {
                var l = letters[id];
                Word += l.letter;

                l.isNotPressed = false;
                letters[id] = l;
                return true;
            }
            return false;
        }

        private void SaveWord()
        {

            wordsHistory.Add(Word);
            ClearWord();
        }

        public bool CheckWord(string word)
        {
            if (!wordsHistory.Contains(word))
            {
                SaveWord();
                return true;
            }
            ClearWord();
            return false;
        }

        public void ClearWord()
        {

            Word = "";
            for (int i = 0; i < letters.Count; i++)
            {
                Letter letter = letters[i];
                letter.isNotPressed = true;
                letters[i] = letter;
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
