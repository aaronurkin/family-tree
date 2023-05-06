using FamilyTree.Application.Models;

namespace FamilyTree.Application.Servcies
{
    public interface IFamilyTreeManager
    {
        void Create(ICreateFamilyTreeModel model);
        void Show();
    }
}
