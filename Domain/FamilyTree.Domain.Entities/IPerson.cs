namespace FamilyTree.Domain.Entities
{
    public interface IPerson
    {
        Person Couple { get; set; }
        Person Father { get; set; }
        PersonGender Gender { get; }
        int Id { get; }
        MaritalStatus MaritalStatus { get; set; }
        Person Mother { get; set; }
        string Name { get; }
        Person NextSibling { get; set; }
    }
}