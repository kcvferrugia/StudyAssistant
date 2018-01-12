using StudyAssistant.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentAssistant.Contracts
{
    public interface IEvent
    {
        bool CreateEvent(EventBlockCreate model);
        bool EditEvent(EventBlockEdit model);
        bool DeleteEvent(int id);
        EventBlockDetail GetEventById(int eventId);
        IEnumerable<EventBlockListItem> GetEvent();
    }
}
