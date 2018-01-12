using Microsoft.VisualStudio.TestTools.UnitTesting;
using StudyAssistant.Data;
using StudyAssistant.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EventBlockText.Test.Controllers
{
    
    [TestClass]
    public class CreatePost : EventBlockControllerTextBase
    {

        private EventBlock _model;
        private object Controller;

        [TestInitialize]
        public override void Arrange()
        {
            base.Arrange();

            EventBlockService.EventBlockCreateReturnValue = true;
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