using System;

namespace FamilyTree.Domain.Entities
{
    public class Person : IPerson
    {
        public Person(
            int id,
            string name,
            PersonGender gender
        ) : this(id, name, gender, MaritalStatus.Single)
        {
        }

        public Person(
            int id,
            string name,
            PersonGender gender,
            MaritalStatus maritalStatus
        ) : this(id, name, gender, maritalStatus, default(Person))
        {
        }

        public Person(
            int id,
            string name,
            PersonGender gender,
            MaritalStatus maritalStatus,
            Person couple = null
        )
        {
            if (gender == PersonGender.Unknown)
            {
                throw new ArgumentException($"Please specify person's gender", nameof(gender));
            }

            if (maritalStatus == MaritalStatus.Unknown)
            {
                throw new ArgumentException($"Please specify person's marital status", nameof(maritalStatus));
            }

            if (maritalStatus == MaritalStatus.Married && couple == null)
            {
                throw new ArgumentNullException(nameof(couple), $"The '{nameof(couple)}' cannot be null when the person is married");
            }

            Id = id;
            Name = name;
            Gender = gender;
            Couple = couple;
            MaritalStatus = maritalStatus;
        }

        public int Id { get; }

        public string Name { get; }

        public PersonGender Gender { get; }

        public MaritalStatus MaritalStatus { get; set; }

        public Person Couple { get; set; }

        public Person Mother { get; set; }

        public Person Father { get; set; }

        public Person NextSibling { get; set; }
    }
}
