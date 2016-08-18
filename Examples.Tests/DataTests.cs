using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Examples.Data.UnitOfWork;
using Examples.Services;
using Examples.Tests.Mocks;

namespace Examples.Tests
{
    [TestClass]
    public class DataTests
    {
        private readonly IExamplesData _data;
        private ExamplesController controller;

        public DataTests()
            : this(new MoqExamplesRepository())
        {

        }

        private DataTests(IExamplesRepositoryMock dataMock)
        {
            this._data = dataMock.ExamplesData;
        }

        [TestInitialize]
        public void CreateController()
        {
            this.controller = new ExamplesController(this._data);
        }

        [TestMethod]
        public void TestSearchByNameShouldReturnFound()
        {
            var result = this.controller.GetExampleByName("pesho");

            Assert.AreEqual("pesho", result.Name);
        }
    }
}
