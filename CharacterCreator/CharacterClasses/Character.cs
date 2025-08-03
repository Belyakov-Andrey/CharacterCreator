namespace CharacterClasses
{
    public abstract class Character
    {
        public string? Name { get; set; }
        public int Strength { get; set; }       
        public int Dexterity { get; set; }      
        public int Endurance { get; set; }    
        public int Intelligence { get; set; }   

        public abstract int Health { get; }     
        public abstract int Damage { get; }     
        public abstract double CritChance { get; } 

     
        public string Attack()
        {
            Random rnd = new Random();
            double critRoll = rnd.NextDouble();

            if (critRoll < CritChance)
            {
                return $"Критический удар! Нанесено {Damage * 2} урона!";
            }
            else
            {
                return $"Нанесено {Damage} урона.";
            }
        }

        public abstract string GetClassDescription();
    }
}