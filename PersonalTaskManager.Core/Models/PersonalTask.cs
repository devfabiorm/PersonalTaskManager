using PersonalTaskManager.Core.Enums;
using PersonalTaskManager.Core.Models.Base;
using System;

namespace PersonalTaskManager.Core.Models
{
    public class PersonalTask : BaseModel
    {
        public PersonalTask(string title, DateOnly limitDate, Category category, string? description = null)
        {
            Title = title;
            Description = description;
            LimitDate = limitDate;
            Category = category;
        }

        public string Title { get; set; }
        public string Description { get; set; }
        public DateOnly LimitDate { get; set; }
        public DateOnly FinishedAt { get; set; }
        public ETaskStatus Status { get; set; }
        public Category Category { get; set; }
    }
}
