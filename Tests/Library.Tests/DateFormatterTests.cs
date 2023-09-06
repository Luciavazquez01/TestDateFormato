namespace Library.Tests;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void CasoCorrecto()
    {
        string testDate = "10/11/1997";
        string dateFormatterTests1 = TestDateFormat.DateFormatter.ChangeFormat(testDate);
        string expected= "1997-11-10";
        Assert.AreEqual (dateFormatterTests1, expected);
    }
    [Test]
    public void CasoIncorrecto(){

        string testDate2 = "10//11//";
        string resultado1 = TestDateFormat.DateFormatter.ChangeFormat(testDate2);
        string expected= "error";
        Assert.AreEqual(resultado1, expected);
    }
    [Test]
    public void CasoVacio (){
        string testDate3 = "";
        bool resultado2= TestDateFormat.DateFormatter.CheckFormat(testDate3);
        Assert.False (resultado2);
        

    }
}
