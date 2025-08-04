namespace CharacterClasses
{
    public class Mage : Character
    {
        public override int Health => 60 + Endurance * 6;
        public override int Damage => 5 + Intelligence * 3;
        public override double CritChance => 0.15 + Intelligence * 0.015;

        public override string GetClassDescription()
        {
            return "Маг - мощный заклинатель, чья сила зависит от интеллекта.";
        }
    }
}