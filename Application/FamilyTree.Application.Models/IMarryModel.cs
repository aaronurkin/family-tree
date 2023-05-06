namespace FamilyTree.Application.Models
{
    public interface IMarryModel
    {
        public int Id { get; set; }

        public int OtherId { get; set; }

        public string OtherName { get; set; }

        public string OtherGender { get; set; }
    }
}
