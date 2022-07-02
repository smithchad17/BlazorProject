using System.Collections.Generic;

namespace BlazorProject.Models
{
    public class NoteCardModel
    {
        public string Question { get; set; }
        public string Answer { get; set; }
        public bool isComplete { get; set; }
    }
}
