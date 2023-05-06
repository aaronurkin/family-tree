using FamilyTree.Domain.Entities;

namespace FamilyTree.Application.Models
{
    public interface IHaveKidModel
    {
        public int MotherId { get; set; }

        public int FatherId { get; set; }

        public int KidId { get; set; }

        public string KidName { get; set; }

        public PersonGender KidGender { get; set; }
    }
}
