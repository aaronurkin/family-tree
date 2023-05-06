namespace FamilyTree.Application.Models
{
    public interface ICreateFamilyTreeModel
    {
        public int MotherId { get; set; }

        string MotherName { get; set; }

        int FatherId { get; set; }

        string FatherName { get; set; }
    }
}
