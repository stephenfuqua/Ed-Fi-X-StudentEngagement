using System.Collections.Generic;
using System.Threading.Tasks;
using FakeItEasy;
using MSDF.StudentEngagement.Persistence.CommandsAndQueries.Queries;
using MSDF.StudentEngagement.Persistence.Models;
using MSDF.StudentEngagement.Web.Controllers;
using NUnit.Framework;
using Shouldly;

namespace MSDF.StudentEngagement.Web.Tests.Controllers
{
    [TestFixture]
    public class AllowlistControllerTests
    {
        public class WhenConstructingANewInstance
        {
            [Test]
            public void ItShouldNotThrowAnException()
            {
                _ = new AllowlistController(A.Fake<ILearningAppQueries>());
            }
        }

        public class WhenGettingTheAllowlist
        {
            public class GivenThereAreNoItems
            {
                [Test]
                public async Task ThenItShouldReturnAnEmptyJsonArray()
                {
                    // Arrange
                    var queries = A.Fake<ILearningAppQueries>();
                    A.CallTo(() => queries.GetAll()).Returns(
                        Task.FromResult(new List<LearningApp>())
                    );

                    var controller = new AllowlistController(queries);

                    // Act
                    var result = await controller.Get();

                    // Assert
                    result.ShouldBe("[]");
                }
            }

            public class GivenThereAreTwoItems
            {
                [Test]
                public async Task ThenItShouldReturnThoseItemsAsASerializedJsonArray()
                {
                    // Arrange
                    var queries = A.Fake<ILearningAppQueries>();
                    A.CallTo(() => queries.GetAll()).Returns(
                        Task.FromResult(new List<LearningApp>()
                        {
                            new LearningApp() {LearningAppIdentifier = "one", AllowlistRegex = "1"},
                            new LearningApp() {LearningAppIdentifier = "two", AllowlistRegex ="2"}
                        })
                    );

                    var controller = new AllowlistController(queries);

                    // Act
                    var result = await controller.Get();

                    // Assert
                    result.ShouldBe("[{\"app\":\"one\",\"regex\":\"1\"},{\"app\":\"two\",\"regex\":\"2\"}]");
                }
            }
        }
    }
}
