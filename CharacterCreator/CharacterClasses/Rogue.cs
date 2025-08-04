namespace CharacterClasses
{
    public class Rogue : Character
    {
        public override int Health => 80 + Endurance * 8;
        public override int Damage => 8 + Strength + Dexterity;
        public override double CritChance => 0.2 + Dexterity * 0.02;

        public override string GetClassDescription()
        {
            return "Разбойник - быстрый и смертоносный, с высоким шансом крита.";
        }
    }
}