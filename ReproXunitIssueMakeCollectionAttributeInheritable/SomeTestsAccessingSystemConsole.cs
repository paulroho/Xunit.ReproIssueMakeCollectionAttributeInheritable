using System;
using System.IO;
using Xunit;

namespace ReproXunitIssueMakeCollectionAttributeInheritable
{
    [Collection("Tests using System.Console")]
    public class SomeTestsAccessingSystemConsole
    {
        [Fact]
        public void TestSayingHelloWorld()
        {
            var stringWriter = new StringWriter();
            Console.SetOut(stringWriter);

            Console.Write("Hello World!");

            stringWriter.Flush();
            var output = stringWriter.ToString();
            Assert.Equal("Hello World!", output);
        }
    }
}
