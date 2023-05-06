using FamilyTree.Application.Models;

namespace FamilyTree.Application.Servcies
{
    public interface IPeopleManager
    {
        void HaveKid(IHaveKidModel model);
        void Marry(IMarryModel model);
    }
}
