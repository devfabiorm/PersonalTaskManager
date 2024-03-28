using PersonalTaskManager.Core.Models.Base;

namespace PersonalTaskManager.Core.Models
{
    public class Category : BaseModel
    {
        public string Label { get; set; }

        public Category(string label)
        {
            Label = label;
        }
    }
}
