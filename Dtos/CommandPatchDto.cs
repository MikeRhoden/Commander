using System.ComponentModel.DataAnnotations;

namespace Commander.Dtos
{
    public class CommandPatchDto
    {
        public string HowTo { get; set; }
        public string Line { get; set; }
        public string Platform { get; set; }
    }
}