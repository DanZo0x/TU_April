
namespace _2023_GC_A2_Partiel_POO.Level_2
{
    /// <summary>
    /// Défintion simple d'un équipement apportant des boost de stats
    /// </summary>
    public class Equipment
    {
        int _baseBonusHealth;
        int _baseBonusAttack;
        int _baseBonusDefense;
        int _baseBonusSpeed;

        public Equipment(int bonusHealth, int bonusAttack, int bonusDefense, int bonusSpeed)
        {
            _baseBonusHealth = bonusHealth;
            _baseBonusAttack = bonusAttack;
            _baseBonusDefense = bonusDefense;
            _baseBonusSpeed = bonusSpeed;
        }

        public int BonusHealth
        {
            get => _baseBonusHealth;
        }
        public int BonusAttack
        {
            get => _baseBonusAttack;
        }
        public int BonusDefense
        {
            get => _baseBonusDefense;
        }
        public int BonusSpeed
        {
            get => _baseBonusSpeed;
        }
    }
}
