using StudyAssistant.Model;
using StudyAssistant.Service;
using System;
using System.Collections.Generic;


namespace EventBlockText.Tests.Controllers
{
    public class FakeEventBlockService : IEvent
    {

        public int CreateEventCallCount { get; private set; } = 1;
        public bool CreateEventReturnValue { private get; set; }

        public bool CreateEvent(EventBlockCreate model)
        {
            CreateEventCallCount++;
            return CreateEventReturnValue;
        }

        public bool EventCreate(EventBlockCreate model)
        {
            throw new NotImplementedException();
        }

        public bool DeleteEvent(int id)
        {
            throw new NotImplementedException();
        }

        public bool DeleteQuote(int quoteId)
        {
            throw new NotImplementedException();
        }

        public EventBlockDetail GetEventById(int eventid)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<EventBlockListItem> GetEvents()
        {
            throw new NotImplementedException();
        }

        public bool UpdateEvent(EventBlockEdit model)
        {
            throw new NotImplementedException();
        }
    }
}