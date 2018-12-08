using Xunit;

namespace ReproXunitIssueMakeCollectionAttributeInheritable
{
    public class TestsUsingSystemConsoleAttribute //: CollectionAttribute
    {
        public TestsUsingSystemConsoleAttribute()
            //: base("Tests using System.Console")
        { 
        }
    }
}