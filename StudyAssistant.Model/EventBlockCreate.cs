using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace StudyAssistant.Model
{
    public class EventBlockCreate
    {
        [Required]
        public Guid StudentId { get; set; }

        [Required]
        public string Title { get; set; }

        public bool? IsAllDay { get; set; }

        public DateTime? Start { get; set; }

        public DateTime? End { get; set; }

        public string Description { get; set; }

        public string ThemeColor { get; set; }

        public bool? EventRepeat { get; set; }

        public override string ToString() => Title;
    }
}
