using System.Collections.ObjectModel;

namespace Lb2_prog_2_master_Tests

{

    public class UnitTest1
    {
        ObservableCollection<string> guess = new ObservableCollection<string>();

        [Fact]
        public void CheckGsTest()
        {                      
            string word = "hello";
            guess.Add(word);
            Assert.Contains(word, guess);
        }
    }
}