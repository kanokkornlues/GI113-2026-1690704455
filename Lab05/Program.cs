namespace Lab05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Game title, Sub-title
            Console.WriteLine("====== Good game or Dog game ======");
            Console.WriteLine("Hero vs. Monster -- Fight Damage Calculator\n");

            // Hero stats input Hp , ATH , DEF
            Console.Write("Hero health: ");
            bool heroHpOk = int.TryParse(Console.ReadLine(), out int heroHp);
            Console.Write("Hero Attack: ");
            bool heroAtkOk = int.TryParse(Console.ReadLine(), out int heroAtk);
            Console.Write("Hero Defense: ");
            bool heroDefOk = int.TryParse(Console.ReadLine(), out int heroDef);

            // Monster stats input Hp , ATH , DEF
            Console.Write("Monster health: ");
            bool monHpOk = int.TryParse(Console.ReadLine(), out int monHp);
            Console.Write("Monster Attack: ");
            bool monAtkOk = int.TryParse(Console.ReadLine(), out int monAtk);
            Console.Write("Monster Defense: ");
            bool monDefOk = int.TryParse(Console.ReadLine(), out int monDef);


            // Input validation / output
            bool heroStatValid = heroHpOk && heroAtkOk && heroDefOk;
            bool monsterStatValid = monHpOk || monAtkOk || monDefOk;
            Console.WriteLine($"\n HERO STAT: {heroStatValid}");
            Console.WriteLine($"\n MONSTER STAT: {monsterStatValid}");

            Console.WriteLine($"[HERO]     HP : {heroHp} ATK : {heroAtk} DEF : {heroDef}");
            Console.WriteLine($"[MONSTER   HP : {monHp} ATK : {monAtk} DEF : {monDef}]");

   
            // Compound Assign & Arithmetiv ( + ) ผู้เล่นดื่มยาก่อนต่อสู้
            int potionHeal = 5;

            heroHp += potionHeal;          //1. แบบสั้น แนะนำ นำ Hp Hero มา + กับ Potion
            //heroHp = heroHp + potionHeal;//2. แบบยาว
            Console.WriteLine($"\nHero drinks a potion, heals {potionHeal} HP. Hero HP: {heroHp}");
            //Normal Attack RPG Style combat ATK > DEF ถึงจะมี Damage ต่อสู้กับศัตรู
            //int normalDmg = heroAtk - monDef;
            int normalDmg = Math.Max(0, heroAtk - monDef);
            Console.WriteLine($"Hero deals normal attack damage: {normalDmg}");

            //Power Attack
            int powerDgm = Math.Max(0, (heroAtk * 2) - monDef); // ใส่วงเล็บบังคับให้ทำก่อนได้
            Console.WriteLine($"Hero would deals power attack: {powerDgm}");

            // Random Critical Attack
            Random rng = new Random();
            int critRoll = rng.Next(1, 101); // อยากสุ่มโอกาสจาก 100%
            bool isCrit = critRoll <= 25; // 25% chance of crit

            int critDmg = normalDmg + Convert.ToInt32(isCrit) * normalDmg; //ถ้าอยากได้ x2
            Console.WriteLine($"Crit roll {critRoll}. Critical Hit: {isCrit}");
            Console.WriteLine($"If critical hit player would deal {critDmg} DGM!!");
        }
    }
}
