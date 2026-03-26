using System;
using System.Collections.Generic;

namespace RandomDungeon
{
    public class Arena
    {
        private List<Enemy> enemies;

        public Arena(List<Enemy> enemies)
        {
            this.enemies = enemies;
        }

        public List<Enemy> GetEnemies()
        {
            return enemies;
        }

        public void SetEnemies(List<Enemy> value)
        {
            enemies = value;
        }

        public void AddEnemy(Enemy enemy)
        {
            enemies.Add(enemy);
        }

        public void RemoveEnemy(Enemy enemy)
        {
            enemies.Remove(enemy);
        }

        // Método Para Mostrar Todos os Inimigos Atuais
        // Exemplo: "Arena: Troll, Skeleton, Ogre"
        public static void ShowEnemies(Enemy[] enemies)
        {
            // CÓDIGO AQUI
            Console.WriteLine($"Arena: {enemies}");
        }
        
        // Simula uma Batalha Entre Dois Inimigos
        public void Battle(Enemy attacker, Enemy defender)
        {
            // Subtrai o Ataque do Atacante à Vida do Defensor
            // Garante que a Vida Não Fique Negativa
            int attack = attacker.GetAttack();
            int health = defender.GetHealth();
            if (health > attack)
            {
                health -=attack;
                defender.SetHealth(health);
            }
            
            // Se a Vida do Defensor Chegar a 0, Remove-o da Arena
            // CÓDIGO AQUI
            else
            {
                defender.SetHealth(0);
                RemoveEnemy(defender);
            }
        }
    }
}