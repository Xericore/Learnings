using System;

namespace Net.Petricevic.Learnings.CSharp.Factory
{
    public class PersonFactory
    {
        public IPerson CreatePerson(PersonType personType)
        {
            switch (personType)
            {
                case PersonType.Rural:
                    return new Villager();
                case PersonType.Urban:
                    return new CityPerson();
                default:
                    throw new ArgumentOutOfRangeException(nameof(personType), personType, null);
            }
        }
    }
}