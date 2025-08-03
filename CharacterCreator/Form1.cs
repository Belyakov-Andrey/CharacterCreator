using System.Reflection;
using CharacterClasses;

namespace CharacterCreatorForm
{
    public partial class Form1 : Form
    {
        private Character currentCharacter;

        public Form1()
        {
            InitializeComponent();
            InitializeCharacterClasses();
            InitializeCharacter();
            UpdateCharacterInfo();
            UpdateClassImage();
        }

        private void InitializeCharacterClasses()
        {
            cmbClass.Items.AddRange(new object[] { "Воин", "Разбойник", "Маг" });
            cmbClass.SelectedIndex = 0;
        }

        private void InitializeCharacter()
        {
            CreateCharacterByClass(cmbClass.SelectedItem?.ToString());
            numStrength.Value = currentCharacter.Strength;
            numDexterity.Value = currentCharacter.Dexterity;
            numEndurance.Value = currentCharacter.Endurance;
            numIntelligence.Value = currentCharacter.Intelligence;
        }

        private void CreateCharacterByClass(string? className)
        {
            switch (className)
            {
                case "Воин":
                    currentCharacter = new Warrior();
                    break;
                case "Разбойник":
                    currentCharacter = new Rogue();
                    break;
                case "Маг":
                    currentCharacter = new Mage();
                    break;
                default:
                    currentCharacter = new Warrior();
                    break;
            }

            currentCharacter.Name = "Новый персонаж";
            currentCharacter.Strength = 10;
            currentCharacter.Dexterity = 10;
            currentCharacter.Endurance = 10;
            currentCharacter.Intelligence = 10;
        }

        private void UpdateCharacterInfo()
        {
            lblHealth.Text = currentCharacter.Health.ToString();
            lblDamage.Text = currentCharacter.Damage.ToString();
            lblCritChance.Text = $"{currentCharacter.CritChance * 100:0.0}%";
            lblClassDescription.Text = currentCharacter.GetClassDescription();
        }

        private void cmbClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            CreateCharacterByClass(cmbClass.SelectedItem?.ToString());
            currentCharacter.Strength = (int)numStrength.Value;
            currentCharacter.Dexterity = (int)numDexterity.Value;
            currentCharacter.Endurance = (int)numEndurance.Value;
            currentCharacter.Intelligence = (int)numIntelligence.Value;

            UpdateClassImage();
            UpdateCharacterInfo();
        }

        private void btnAttack_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this, currentCharacter.Attack(), "Атака", MessageBoxButtons.OK);
        }

        private void UpdateClassImage()
        {
            string imageName = cmbClass.SelectedItem?.ToString() switch
            {
                "Воин" => "warrior.png",
                "Разбойник" => "rogue.png",
                "Маг" => "mage.png",
                _ => ""
            };

            try
            {
                var assembly = Assembly.GetExecutingAssembly();
                using var stream = assembly.GetManifestResourceStream($"{assembly.GetName().Name}.Resources.{imageName}");
                picClass.Image = stream != null ? new Bitmap(stream) : CreateDefaultImage();
            }
            catch
            {
                picClass.Image = CreateDefaultImage();
            }
        }

        private Bitmap CreateDefaultImage()
        {
            Bitmap bmp = new Bitmap(100, 100);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.Clear(Color.LightGray);
                g.DrawString("No Image", new Font("Arial", 10), Brushes.Black, 10, 40);
            }
            return bmp;
        }

        private void CharacterStat_Changed(object sender, EventArgs e)
        {
            currentCharacter.Strength = (int)numStrength.Value;
            currentCharacter.Dexterity = (int)numDexterity.Value;
            currentCharacter.Endurance = (int)numEndurance.Value;
            currentCharacter.Intelligence = (int)numIntelligence.Value;

            UpdateCharacterInfo();
        }
    }
}