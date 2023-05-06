namespace FamilyTree.Domain.Entities
{
    public class FamilyTreeRoot : IFamilyTreeRoot
    {
        public FamilyTreeRoot(Person adam, Person eve)
        {
            Adam = adam;
            Eve = eve;
        }

        public Person Adam { get; }

        public Person Eve { get; }

        public Person FirstChild { get; set; }
    }
}
