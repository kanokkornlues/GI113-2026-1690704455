/*
* Student ID : 1690704455
* Name       : 
* Section    : 129D
* No.        : 
* Course     : GI113 Computer Programming (GI)
*/
namespace Lab03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int MaxLevel = 10;
            var bossName = "Kirin";   // ต้องประกาศด้วย var ห้ามเขียน string ตรงๆ
            var rank = 'S';            // ต้องประกาศด้วย var ห้ามเขียน char ตรงๆ
            int level = 7;
            int maxHp = 240;
            int currentHp = 115;       // ค่าตั้งต้นของ Lab นี้คือ HP "หลังโดนโจมตี" จาก Lab 2 แล้ว ไม่ใช่ 175
            float attackPower = 42.5f;
            double critMultiplier = 1.75;
            bool isBoss = true;
            Console.WriteLine("===== KIRIN SAVE CONVERTER =====");
            Console.WriteLine($"Name: {bossName}");
            Console.WriteLine($"Rank: {rank}");
            Console.WriteLine($"Level: {level}/{MaxLevel}");
            Console.WriteLine($"HP: {currentHp}/{maxHp}");
            Console.WriteLine($"Attack Power: {attackPower}");
            Console.WriteLine($"Critical Multiplier: {critMultiplier}");
            Console.WriteLine($"Is Boss: {isBoss}");
            // Implicit Conversion: currentHp (int) to double
            Console.WriteLine("\n----- Implicit Conversion: HP as double -----");
            double currentHpDouble = currentHp; // (double)currentHpDouble = (int)currentHp
            Console.WriteLine($"Current HP (double): {currentHpDouble}");


            //Calulate percent -->> double
            Console.WriteLine("\n----- Exact HP Percent (no integer truncation) -----");
            double hpPercentExact = currentHpDouble * 100 / maxHp;
            Console.WriteLine($"HP Percent (Exact): {hpPercentExact}%");



            //Exlicit Conversion cast attackPower (float) to int
            Console.WriteLine("\n----- Explicit Cast: Attack Power -> Display Int -----");
            double attackPowerDouble = attackPower;
            int attackDisplay = (int)attackPowerDouble;
            Console.WriteLine($"Attack Power (int cast): {attackDisplay}");



            //Cast vs. Convert critMultiplier (double) to int
            Console.WriteLine("\n----- Cast vs Convert: Crit Multiplier -----");
            double critMultiplierDouble = critMultiplier;
            int critMultiplierCast = (int)critMultiplier; 
            Console.WriteLine($"Crit Multiplier (int cast): {critMultiplierCast}");
            Console.WriteLine($"Crit Multiplier (Convert rounded): {Convert.ToInt32(critMultiplierDouble)}");

        }
    }
}
