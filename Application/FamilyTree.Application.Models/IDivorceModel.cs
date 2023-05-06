using FamilyTree.Domain.Entities;

namespace FamilyTree.Application.Models
{
    public interface IDivorceModel
    {
        public int MotherId { get; set; }

        public int FatherId { get; set; }

        public Custody Custody { get; set; }
    }
}
