namespace FamilyTree.Domain.Entities
{
    public interface IFamilyTreeRoot
    {
        Person Adam { get; }
        Person Eve { get; }
        Person FirstChild { get; set; }
    }
}
