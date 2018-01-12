using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace StudyAssistant.Model
{
    public class EventBlockListItem
    {

        [Key]
        public int EventId { get; set; }

        [Required]
        public Guid StudentId { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }


        public DateTime? Start { get; set; }

        public DateTime? End { get; set; }

        public bool? EventRepeat { get; set; }

        public bool? IsAllDay { get; set; }

        
        public string ThemeColor { get; set; }

        [Display(Name = "Event")]
        public override string ToString() => $"[{EventId}] {Title} {Description} {Start} {End} {EventRepeat} {IsAllDay} {ThemeColor}";

    }
}