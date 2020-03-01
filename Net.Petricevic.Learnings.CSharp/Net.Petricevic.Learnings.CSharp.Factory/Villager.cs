using Net.Petricevic.Learnings.CSharp.Factory.Person;

namespace Net.Petricevic.Learnings.CSharp.Factory
{
    public class Villager : IPerson
    {
        public string GetName()
        {
            return "Village Person";
        }
    }
}