using _2023_GC_A2_Partiel_POO.Level_2;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2023_GC_A2_Partiel_POO.Tests.Level_2
{
    public class FightMoreTests
    {
        // Tu as probablement remarqué qu'il y a encore beaucoup de code qui n'a pas été testé ...
        // À présent c'est à toi de créer les TU sur le reste et de les implémenter

        // Ce que tu peux ajouter:
        // - Ajouter davantage de sécurité sur les tests apportés
        // - un heal ne régénère pas plus que les HP Max
        // - si on abaisse les HPMax les HP courant doivent suivre si c'est au dessus de la nouvelle valeur
        // - ajouter un equipement qui rend les attaques prioritaires puis l'enlever et voir que l'attaque n'est plus prioritaire etc)
        // - Le support des status (sleep et burn) qui font des effets à la fin du tour et/ou empeche le pkmn d'agir
        // - Gérer la notion de force/faiblesse avec les différentes attaques à disposition (skills.cs)
        // - Cumuler les force/faiblesses en ajoutant un type pour l'équipement qui rendrait plus sensible/résistant à un type

        [Test]
        public void HealCheck()
        {
            //Check working
            Character c = new Character(100, 50, 30, 20, TYPE.NORMAL, false);
            Punch p = new Punch();

            c.ReceiveAttack(p);
            c.Heal(10000);

            Assert.That(c.CurrentHealth, Is.EqualTo(100));
        }

        [Test]
        public void HPMaxHPCurCheck()
        {
            //Check unfinished
            Character c = new Character(100, 50, 30, 20, TYPE.NORMAL, false);

            c.LowerHPMax(50);

            Assert.That(c.CurrentHealth, Is.EqualTo(50));
        }

        [Test]
        public void PriorityAttackCheck()
        {
            //Check working
            //Bon je sais pas si c'est le plus facile à voir avec les tests mais ça check bien si un perso a un équipement priorité
            //Et en fonction ça fait attaquer celui qui a l'équipement

            Character c1PrioON = new Character(100, 50000, 30, 20, TYPE.NORMAL, true);
            Character c1PrioOFF = new Character(100, 50, 30, 20, TYPE.NORMAL, false);

            Character c2PrioONInvert = new Character(100, 50, 30, 20, TYPE.NORMAL, false);
            Character c2PrioOFFInvert = new Character(100, 500000, 30, 20, TYPE.NORMAL, true);

            Fight f1 = new Fight(c1PrioON, c1PrioOFF);
            Fight f2 = new Fight(c2PrioONInvert, c2PrioOFFInvert);
            Punch p = new Punch();

            f1.ExecuteTurn(p, p);
            f2.ExecuteTurn(p, p);

            Assert.That(c1PrioOFF.CurrentHealth, Is.EqualTo(0));
            Assert.That(c2PrioONInvert.CurrentHealth, Is.EqualTo(0));
        }
    }
}
