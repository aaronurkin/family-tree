using FamilyTree.Application.Models;
using FamilyTree.Domain.Entities;
using System;

namespace FamilyTree.Application.Servcies.Implementations
{
    public class DefaultFamilyTreeManager : IFamilyTreeManager
    {
        private IFamilyTreeRoot _familyTreeRoot;

        /// <summary>
        /// Creates a "root" of a new family tree. Root of the family is always married and never divorce.
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public void Create(ICreateFamilyTreeModel model)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Prints family tree in a way that it’s readable
        /// </summary>
        public void Show()
        {
            throw new NotImplementedException();
        }
    }
}
