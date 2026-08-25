/*
 * Student ID : 1690704455
 * Name       : Lab02
 * Section    : 129D
 * No.        : N/A
 * Course     : GI113 Computer Programming (GI)
 */

using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Lab02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string bossName = "Kirin";
            char rank = 'S';
            int level = 7;
            int maxHp = 240;
            int currentHp = 175;
            float attackPower = 42.5f;
            double critMultiplier = 1.75;
            bool isBoss = true;

            // Lab02 part A

            Console.WriteLine("===== BOSS STATUS: INITIAL =====");
            Console.WriteLine($"Name: {bossName}");
            Console.WriteLine($"Rank: {rank}");
            Console.WriteLine($"Level: {level}");
            Console.WriteLine($"HP: {currentHp} / {maxHp}");
            Console.WriteLine($"Attack Power: {attackPower}");
            Console.WriteLine($"Crit Multiplier: {critMultiplier}");
            Console.WriteLine($"IsBoss: {isBoss}");
            Console.WriteLine();
            int hpPercent = currentHp * 100 / maxHp;
            Console.WriteLine($"HP Percent: {hpPercent}%");
            Console.WriteLine();
            currentHp = currentHp - 60;
            Console.WriteLine();
            Console.WriteLine("Kirin takes 60 damage!");
            Console.WriteLine();
            Console.WriteLine("===== BOSS STATUS: AFTER DAMAGE =====");
            Console.WriteLine($"HP: {currentHp} / {maxHp}");
            hpPercent = currentHp * 100 / maxHp;
            Console.WriteLine($"HP Percent: {hpPercent}%");
            Console.WriteLine();

            // Lab02 part B

            // CHARACTER 1
            string worlockName = "Shio";
            char worlockrank = 'B';
            int worlocklevel = 2;
            int worlockmaxHp = 150;
            float worlockSpell = 80.5f;
            double worlockCriticalHit = 1.25;
            bool worlockIsAlive = true;

            // CHARACTER 2
            string plipispilpName = "Plip";
            char plipispilpRank = 'F';
            int plipispilpLevel = 2;
            int plipispilpMaxHp = 67;
            float plipispilpSpell = 79.0f;
            double plipispilpCriticalHit = 0.1;
            bool plipispilpIsAlive = true;

            // CHARACTER 3
            string vianneName = "Vianne";
            char vianneRank = 'A';
            int vianneLevel = 2;
            int vianneMaxHp = 180;
            float vianneAttack = 90.0f;
            double vianneDefense = 6.7;
            bool vianneIsAlive = true;

            // Boss
            string dragonName = "Dragon";
            char dragonRank = 'S';
            int dragonLevel = 5;
            int dragonMaxHp = 200;
            int dragonCurrentHp = 66;
            float dragonAttack = 100.0f;
            double dragonCriticalHit = 2.0;
            bool dragonIsAlive = true;

            Console.WriteLine();
            Console.WriteLine("===== Attack the Dragon =====");
            Console.WriteLine();
            Console.WriteLine($"Name: {dragonName}");
            Console.WriteLine($"Rank: {dragonRank}");
            Console.WriteLine($"Level: {dragonLevel}");
            Console.WriteLine($"HP: {dragonMaxHp} / {dragonMaxHp}");
            Console.WriteLine($"Attack Power: {dragonAttack}");
            Console.WriteLine($"Crit Multiplier: {dragonCriticalHit}");
            Console.WriteLine($"IsAlive: {dragonIsAlive}");
            Console.WriteLine();
   
            Console.WriteLine();
            Console.WriteLine("---- Worlock ----");
            Console.WriteLine($"Name: {worlockName}");
            Console.WriteLine($"Rank: {worlockrank}");
            Console.WriteLine($"Level: {worlocklevel}");
            Console.WriteLine($"HP: {worlockmaxHp} / {worlockmaxHp}");
            Console.WriteLine($"Spell Power: {worlockSpell}");
            Console.WriteLine($"Critical Hit: {worlockCriticalHit}");
            Console.WriteLine($"IsAlive: {worlockIsAlive}");
            Console.WriteLine();
            Console.WriteLine(" = Cast a spell to attack the dragon! = ");
            Console.WriteLine();
            Console.WriteLine(" = The dragon takes damage 44 = ");
            Console.WriteLine();
            Console.WriteLine("---- Plipispilp ----");
            Console.WriteLine($"Name: {plipispilpName}");
            Console.WriteLine($"Rank: {plipispilpRank}");
            Console.WriteLine($"Level: {plipispilpLevel}");
            Console.WriteLine($"HP: {plipispilpMaxHp} / {plipispilpMaxHp}");
            Console.WriteLine($"Spell Power: {plipispilpSpell}");
            Console.WriteLine($"Critical Hit: {plipispilpCriticalHit}");
            Console.WriteLine($"IsAlive: {plipispilpIsAlive}");
            Console.WriteLine();
            Console.WriteLine(" = Cast a spell to attack the dragon! = ");
            Console.WriteLine();
            Console.WriteLine(" = The dragon takes damage 38 = ");
            Console.WriteLine();
            Console.WriteLine("---- Vianne ----");
            Console.WriteLine($"Name: {vianneName}");
            Console.WriteLine($"Rank: {vianneRank}");
            Console.WriteLine($"Level: {vianneLevel}");
            Console.WriteLine($"HP: {vianneMaxHp} / {vianneMaxHp}");
            Console.WriteLine($"Attack Power: {vianneAttack}");
            Console.WriteLine($"Defense: {vianneDefense}");
            Console.WriteLine($"IsAlive: {vianneIsAlive}");
            Console.WriteLine();
            Console.WriteLine(" = Swing your sword to attack the dragon! = ");
            Console.WriteLine();
            Console.WriteLine(" = The dragon takes damage 52 = ");
            Console.WriteLine();
            Console.WriteLine($"Dragon's HP: {dragonCurrentHp} / {dragonMaxHp}");
            hpPercent = dragonCurrentHp * 100 / dragonMaxHp;
            Console.WriteLine($"HP Percent: {hpPercent}%");
            Console.WriteLine();
            Console.WriteLine("The dragon withdrew and flew away, disappearing into the distance.");
        }
    }
}
