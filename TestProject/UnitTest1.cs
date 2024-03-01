using exercise;

namespace TestProject;

public class Tests
{
    Word _word;
    [SetUp]
    public void Setup()
    {
        _word = new Word();
    }

    [TestCase("wow", true)]
    [TestCase("Anna", true)]
    [TestCase("word", false)]
    public void Word_PrintNewString_ReturnString(string word, bool Exepted)
    {   
        Assert.That(_word.Palindrome(word), Is.EqualTo(Exepted));
    }
}