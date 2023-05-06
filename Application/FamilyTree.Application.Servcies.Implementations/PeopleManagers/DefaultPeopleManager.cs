using FamilyTree.Application.Models;
using FamilyTree.Domain.Entities;
using System;

namespace FamilyTree.Application.Servcies.Implementations
{
    public class DefaultPeopleManager : IPeopleManager
    {
        /// <summary>
        /// Gives new kid to a couple
        /// </summary>
        public void HaveKid(IHaveKidModel model)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Marries an existing person (id) to a newly created person
        /// with given otherId and otherName.An existing person
        /// who is getting married must not be already married and
        /// can already have kids(e.g.from previous marriage).
        /// </summary>
        public void Marry(IMarryModel model)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Separates a couple.
        /// Custody can be: <see cref="Custody.WithMother"/> or <see cref="Custody.WithFather"/>.
        /// If a person, who kids stay with, is not integral part of the tree –
        /// person’s kids are removed from the tree
        /// </summary>
        public void Divorce(IDivorceModel model)
        {
            throw new NotImplementedException();
        }
    }
}
