using EventBlockText.Tests.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StudentAssistant.Contracts;
using StudyAssistantMVC.Controllers;
using System;

namespace EventBlockText.Controllers
{
    [TestClass]
    public abstract class EventControllerTextBase
    {

        protected EventBlockController Controller;
        protected FakeEventBlockService EventBlockService;
        

        [TestInitialize]
        public virtual void Arrange()
        {
            EventBlockService = new FakeEventBlockService();
            EventBlockController Controller = (new EventBlockController(new Lazy<IEvent>(() => EventBlockService)));
        }


    }

    internal class EventBlockCreateController
    {
    }
}