using Core.Entities.Abstract;

namespace Entities.Concrete
{
    public class Comment : IEntity
    {
        public int CommentId { get; set; }
        public string Text { get; set; }
        public int Rate { get; set; }
        public int PatientId { get; set; }
    }
}
