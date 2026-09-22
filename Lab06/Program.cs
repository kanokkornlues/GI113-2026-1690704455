namespace Lab06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int lives = 0;

            //// เรียก if เพื่อเช็กเงื่อนไข
            //if (lives <= 0) // ในวงเล็บคือเงื่อนไขที่เป็น bool
            //{
            //    // ในปีกกาเป็นโค้ดการทำงาน จะรันเมื่อได้ ture
            //    Console.WriteLine("Game Over");
            //}
            //else
            //{
            //    Console.WriteLine("Game is Playing");
            //}
            //// โค้กบรรทัดต่อไปจะทำงานเมื่อ if  ทำเสร้จ หรือ โดนข้าม (false)
            //Console.WriteLine("Continue Code");


            //int level = 10;
            //bool hasKey = true;
            //Console.WriteLine("Your level (1-99): ");
            //bool inputValid = int.TryParse(Console.ReadLine(),out int level);

            //if (!inputValid || level < 1 || level > 99) // เงื่อนไขที่ถือว่า error จาก input
            //{
            //    Console.WriteLine("Invalid level.");
            //}

            //else if (level >= 10 && hasKey) //เมื่อมีเงื่อนไขเป็นจำนวน ให้เรียงเช็คจำนวน มาก -> น้อย เสมอ
            //{
            //    Console.WriteLine("Boss floor unlocked"); 
            //}
            //else if (level >= 5)
            //{
            //    if (hasKey)
            //    {
            //        Console.WriteLine("The door opens.");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Locked. Find a key.");
            //    }


            //}
            //else
            //{
            //    Console.WriteLine("The door stays shut.");
            //}


            //bool isPoisoned = true;

            //if (isPoisoned)
            //{
            //    Console.WriteLine("Ypu died!");
            //}
            //else if (!isPoisoned == false) // ! คือตรงข้าม ture -> false, false -> ture
            //{
            //    Console.WriteLine("You Lives");
            //}

            int heroHealth = 50;
            int heroMana = 100;
            int heroAttack = 50;
            int heroDefense = 50;
            int heroPower = 25;
           
            Console.WriteLine("The Final Round: THE END");

            Console.WriteLine("Choose1 - Empower");
            Console.WriteLine("Choose2 - Attack");
            Console.WriteLine("Choose3 - Escape");
            Console.WriteLine("Choose4 - Decoy");

            Console.WriteLine("Choose (1-4):");
            bool inputValid = int.TryParse(Console.ReadLine(), out int choice);

            if (!inputValid || choice < 1 || choice > 4)
            {
                Console.WriteLine("pls choose 1-4");
            }
            else if (choice == 1)
            {
               Console.WriteLine($"Power up! Mana: {heroMana+heroPower}");
            }
            else if (choice == 2)
            {
                heroHealth -= heroAttack;
                if (heroHealth <= 0)
                {
                    Console.WriteLine($"Hero Attack Monster, took {heroAttack} DGM. Monster DIE!!");
                }
                else
                {
                    Console.WriteLine($"Hero Attack Monster, took {heroAttack} DGM.Hero has {heroHealth} HP. Monster still alive!!");
                }
            }
            else if (choice == 3)
            {
                Console.WriteLine("You escaped the battle!");
                Console.WriteLine("!!The Monster Win!!");
            }
            else
            {
                Console.WriteLine("The monster disoriented!");
            }
            // ตั้งชื่อเกม ผู้เล่นเลือกอะไรได้บ้าง 1 2 3 รับข้อมูลจากผู้เล่น เช็คข้อมมูล error ไหม 1 เกิดอะไรขึ้น 2 เกิดอะไรขึ้น 3 เกิดอะไรขึ้น คิดที่ละส่วน
        }
    }
}
