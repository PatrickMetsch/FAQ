using System;
namespace FAQ.Models
{
    public class Question
    {
        public int QuestionId { get; set; }

        public string Ask { get; set; }

        public string Answer { get; set; }

        public string CategoryId { get; set; }
        public Category Category { get; set; }

        public string TopicId { get; set; }
        public Topic Topic { get; set; }

    }
}
