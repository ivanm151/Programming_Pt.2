using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace WpfApp12
{
    public class TestQuestion
    {
        public BitmapImage QuestionImage { get; set; }
        public List<string> Options { get; set; }
        public int CorrectOptionIndex { get; set; }
        public int UserAnswerIndex { get; set; }
        public int Points { get; set; }
    }

    public class TestResult
    {
        public List<TestQuestion> Questions { get; set; }
        public List<int> UserAnswers { get; set; }
        public double PercentageCorrect { get; set; }
        public bool Passed { get; set; }
    }
}
