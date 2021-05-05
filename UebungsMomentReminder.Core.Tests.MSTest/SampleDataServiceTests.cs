using System.Linq;
using System.Threading.Tasks;

using Microsoft.VisualStudio.TestTools.UnitTesting;

using UebungsMomentReminder.Core.Services;

namespace UebungsMomentReminder.Core.Tests.MSTest
{
    [TestClass]
    public class SampleDataServiceTests
    {
        public SampleDataServiceTests()
        {
        }

        // Remove or update this once your app is using real data and not the SampleDataService.
        // This test serves only as a demonstration of testing functionality in the Core library.
        [TestMethod]
        public async Task EnsureSampleDataServiceReturnsListDetailsDataAsync()
        {
            var sampleDataService = new SampleDataService();

            var data = await sampleDataService.GetListDetailsDataAsync();

            Assert.IsTrue(data.Any());
        }
    }
}
