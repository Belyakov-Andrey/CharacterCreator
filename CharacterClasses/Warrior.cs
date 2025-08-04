namespace CharacterClasses
{
    public class Warrior : Character
    {
        public override int Health => 100 + Endurance * 10;
        public override int Damage => 10 + Strength * 2;
        public override double CritChance => 0.1 + Dexterity * 0.01;

        public override string GetClassDescription()
        {
            return "Воин - мастер ближнего боя с высокой выносливостью.";
        }
    }
}