using System;
using System.Collections.Generic;
using System.Text;

namespace DayGame.Boss
{
    class BossBattle
    {

        private Character character;
        private Boss boss;
        private string dialogue; //to be changed to gui component

        public BossBattle(Boss boss, Character character)
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
                UseSpells(new Spell("sample", "a sample spell", null, 10, 10));
            }
            else if (action == "Potions")
            {
                UsePotions(new Potion("sample", "a sample potion", null, 10, 10));
            }
        }

        public void CharacterAttack()
        {
            int damage = character.Damage;
            boss.HitPoints -= damage;

            if (boss.HitPoints <= 0)
            {
                dialogue = "Whoa! You killed the boss";
            }
            else
            {
                dialogue = $"Whoa! You  have dealt {damage} damage";
            }

        }

        public void UseSpells(Spell spell)
        {
            int damage = spell.Damage;
            boss.HitPoints -= damage;

            if (boss.HitPoints <= 0)
            {
                dialogue = "Whoa! You killed the boss";
            }
            else
            {
                dialogue = $"Whoa! You  have dealt {damage} damage";
            }
        }

        public void UsePotions(Potion potion)
        {
            int heal = potion.Hit_point_regain;
            character.HitPoints += heal;
            dialogue = String.Format("You have regenerated {} hit points", heal);
        }

        public void BossAttack()
        {
            int damage = boss.Damage;
            character.HitPoints -= damage;
            if (character.HitPoints <= 0)
            {
                dialogue = "You have been killed";
            }
            dialogue = String.Format("Boss dealt {} damage", boss.Damage);
        }
    }

}
