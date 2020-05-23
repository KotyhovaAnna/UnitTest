using NUnit.Framework;

namespace NUnitTestProjectKORRECT
{
    public class Tests
    {

        [Test]
        public void Test()
        {
            for (int x = 0; x <= 20; x++)
                for (int y = 0; y <= 20; y++)
                {
                    Calculator.Methods s = new Calculator.Methods();

                    s.multiplication(x, y);
                    var a = s.multiplication(x, y);
                    Assert.IsTrue(x * y == a, "При x = {0} и y = {1} получили = {2}", x, y, a);


                    s.addition(x, y);
                    var b = s.addition(x, y);
                    Assert.IsTrue(x + y == b, "При x = {0} и y = {1} получили = {2}", x, y, b);

                    s.difference(x, y);
                    var c = s.difference(x, y);
                    Assert.IsTrue(x - y == c, "При x = {0} и y = {1} получили = {2}", x, y, c);

                    s.division(x, y);
                    var d = s.division(x, y);

                    if (y == 0)
                    { Assert.Pass(); }
                    else
                    {
                        Assert.IsTrue(x / y == d, "При x = {0} и y = {1} получили = {2}", x, y, d);
                    }

                }

        }
    }
}