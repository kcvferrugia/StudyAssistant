using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StudyAssistant.Service;

namespace Event.Test
{
    [TestClass]
    public class CreatePost : EventTest.Controllers.EventControllerTestsBase
    {

        private EventCreate _model;

        [TestInitialize]
        public override void Arrange()
        {
            base.Arrange();

            EventBlockService.CreateEventBlockReturnValue = true;
        }

        private ActionResult Act()
        {

            return Controller.Create(_model);
        }

        [TestMethod]
        public void ShouldReturnRedirectToRouteResult()
        {
            var result = Act();

            Assert.IsInstanceOfType(result, typeof(RedirectToRouteResult));
        }

        [TestMethod]
        public void ShouldSetSaveResult()
        {
            Act();

            Assert.AreEqual("Your event was created.", Controller.TempData["SaveResult"]);
        }
    }


}

