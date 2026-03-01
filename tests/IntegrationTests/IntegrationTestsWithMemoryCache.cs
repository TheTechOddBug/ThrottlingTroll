using ThrottlingTroll;

namespace IntegrationTests
{
    [TestClass]
    public class IntegrationTestsWithMemoryCache : IntegrationTestsBase
    {
        [ClassInitialize]
        public static void Setup(TestContext context)
        {
            Init(new MemoryCacheCounterStore());
        }

        [ClassCleanup]
        public static void Cleanup()
        {
            TearDown();
        }
    }
}