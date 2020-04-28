using System;
using System.Collections.Generic;
using System.Text;

namespace DayGame.Boss
{
    class BossBattle
    {

        private string character; //to be changed to character class
        private Boss boss;
        private string dialogue; //to be changed to gui component

        public BossBattle(Boss boss, string character) 
        {
            this.boss = boss;
            this.character = character;
        }


        public void SelectAction()
        {
            dialogue = "Select action";
            string action = "Attack"; // example action
            if (action == "Attack"){
                CharacterAttack();
            }
            else if (action == "Spells")
            {
                UseSpells(new Spell("sample", "a sample spell", 0, 10, 10));
            }
            else if (action == "Potions")
            {
                UsePotions(new Potion("sample", "a sample potion", 0, 10, 10));
            }
        }

        public void CharacterAttack()
        {
            int characterDamage = 10; //to be changed
            dialogue = String.Format("Whoa! You  have dealt {} damage", characterDamage);
        }

        public void UseSpells(Spell spell)
        {
            dialogue = String.Format("Whoa! You  have dealt {} damage", spell.Damage);
        }

        public void UsePotions(Potion potion)
        {
            dialogue = String.Format("You have regenerated {} hit points", potion.Hit_point_regain);
        }

        public void BossAttack()
        {
            dialogue = String.Format("Boss dealt {} damage", boss.Damage);
        }
    }

}
