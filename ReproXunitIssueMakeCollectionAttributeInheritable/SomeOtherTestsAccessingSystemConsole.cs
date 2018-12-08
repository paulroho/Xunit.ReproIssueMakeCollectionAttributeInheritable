using System;
using System.IO;
using Xunit;

namespace ReproXunitIssueMakeCollectionAttributeInheritable
{
    [Collection("Tests using System.Console")]
    public class SomeOtherTestsAccessingSystemConsole
    {
        [Fact]
        public void TestSayingHelloXunit()
        {
            var stringWriter = new StringWriter();
            Console.SetOut(stringWriter);

            Console.Write("Hello xunit!");

            stringWriter.Flush();
            var output = stringWriter.ToString();
            Assert.Equal("Hello xunit!", output);
        }
    }
}
