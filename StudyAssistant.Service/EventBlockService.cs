//using StudyAssistant.Model;
//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace StudyAssistant.Service
//{
//    public class EventBlockService : IEvent
//    {

//            private readonly Guid _studentId;

//            public EventBlockService(Guid studentId)
//            {
//                _studentId = studentId;
//            }

//            public bool CreateEvent(EventBlockCreate model)
//            {
//                var entity =
//                    new Event()
//                    {

//                        Title = model.Title,
//                        IsAllDay = model.IsAllDay,
//                        Start = model.Start,
//                        End = model.End,
//                        Description = model.Description,
//                        ThemeColor = model.ThemeColor,

//                    };
//                using (var ctx = new StudyTimeHelperDbContext())
//                {
//                    ctx.Events.Add(entity);
//                    return ctx.SaveChanges() == 1;
//                }
//            }

//            public IEnumerable<EventBlockListItem> GetEvents()
//            {
//                using (var ctx = new StudyTimeHelperDbContext())
//                {
//                    var query =
//                        ctx
//                            .Events
//                            .Select(
//                                e =>
//                                    new EventBlockListItem
//                                    {
//                                        EventId = e.EventId,
//                                        Title = e.Title,
//                                        IsAllDay = e.IsAllDay,
//                                        Start = e.Start,
//                                        End = e.End,
//                                        Description = e.Description,
//                                        ThemeColor = e.ThemeColor,

//                                    });
//                    return query.ToArray();
//                }
//            }

//            public EventBlockDetail GetEventBlockById(int id)
//            {
//                using (var ctx = new StudyTimeHelperDbContext())
//                {
//                    var entity =
//                        ctx
//                            .Events
//                            .Single(e => e.EventId == id && e.StudentId == _studentId);
//                    return
//                        new EventBlockDetail
//                        {
//                            EventId = entity.EventId,
//                            Title = entity.Title,
//                            IsAllDay = entity.IsAllDay,
//                            Start = entity.Start,
//                            End = entity.End,
//                            Description = entity.Description,
//                            ThemeColor = entity.ThemeColor,

//                        };
//                }
//            }

//            public bool UpdateEventBlock(EventBlockEdit model)
//            {
//                using (var ctx = new StudyTimeHelperDbContext())
//                {
//                    var entity =
//                        ctx
//                            .Events
//                            .Single(e => e.EventId == model.EventId);

//                    entity.Title = model.Title;
//                    entity.IsAllDay = model.IsAllDay;
//                    entity.Start = model.Start;
//                    entity.End = model.End;
//                    entity.Description = model.Description;
//                    entity.ThemeColor = model.ThemeColor;

//                    return ctx.SaveChanges() == 1;
//                }
//            }

//            public bool DeleteEventBlock(int id)
//            {
//                using (var ctx = new StudyTimeHelperDbContext())
//                {
//                    var entity =
//                        ctx
//                            .Events
//                            .Single(e => e.EventId == id && e.StudentId == _studentId);

//                    ctx.Events.Remove(entity);
//                    return ctx.SaveChanges() == 1;
//                }
//            }
//        }

//    public interface IEvent
//    {
//    }
//}
//}
