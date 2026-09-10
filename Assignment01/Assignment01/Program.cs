/*
 * Student ID : 1690704455
 * Name       : Kanokkorn Luesamut
 * Section    : 129D
 * No.        : 23
 * Course     : GI113 Computer Programming (GI)
 */
namespace Assignment01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"==================================================\n");
            const int MAXLEVEL = 99;
            var daimyoName = "Ichimoku Ren [Rento]";
            var daimyoGender = "Boy";
            var rank = "Demon Lord";
            int level = 99;
            int levelMax = 99;
            int hp = 9999;
            float attackPower = 999.99f;
            double criticalChance = 99.99;
            bool isPeerless = true;
            Console.WriteLine();
            Console.WriteLine("----- Welcome player to the World of Yokai -----");
            Console.WriteLine();
            Console.WriteLine("                 '\r\n            *          .\r\n                   *       '\r\n              *                *\r\n\r\n\r\n\r\n\r\n\r\n   *   '*\r\n           *\r\n                *\r\n                       *\r\n               *\r\n                     *\r\n\r\n         .                      .\r\n         .                      ;\r\n         :                  - --+- -\r\n         !           .          !\r\n         |        .             .\r\n         |_         +\r\n      ,  | `.\r\n--- --+-<#>-+- ---  --  -\r\n      `._|_,'\r\n         T\r\n         |\r\n         !\r\n         :         . : \r\n         .       *\r\n\r      Mission : Defeat the Demon Lord");
            Console.WriteLine();
            Console.WriteLine($"Daimyo           : {daimyoName}");
            Console.WriteLine($"Gender           : {daimyoGender}");
            Console.WriteLine("Height / Wt      : 6'0 / 117 lbs");
            Console.WriteLine($"Rank             : {rank}");
            Console.WriteLine($"Level            : {level}/{levelMax}");
            Console.WriteLine($"HP               : {hp} / {hp}");
            Console.WriteLine($"Attack Power     : {attackPower}");
            Console.WriteLine($"Critical Chance  : {criticalChance}%");
            Console.WriteLine($"Is Peerless      : {isPeerless}");

            int godSlayer = (int)(attackPower * 1.5);
            int absoluteMagic = (int)(attackPower * 2.0);

            Console.WriteLine($"\nGod Slayer : {godSlayer}");
            Console.WriteLine($"Absolute Magic : {absoluteMagic}");

            Console.WriteLine($"\n==================================================");

            Console.WriteLine("(¯`·._.·(¯`·._.· Demon Lord ·._.·´¯)·._.·´¯)");

            Console.WriteLine();
            Console.WriteLine("                \r\n                     _.-'.-'-.__\r\n                  .-'.       '-.'-._ __.--._\r\n           -..'\\,-,/..-  _         .'   \\   '----._\r\n            ). /_ _\\' ( ' '.         '-  '/'-----._'-.__\r\n            '..'     '-r   _      .-.       '-._ \\\r\n            '.\\. Y .).'       ( .'  .      .\\          '\\'.\r\n            .-')'|'/'-.        \\)    )      '',_      _.c_.\\\r\n              .<, ,>.          |   _/\\        . ',   :   : \\\\\r\n             .' \\_/ '.        /  .'   |          '.     .'  \\)\r\n                             / .-'    '-.        : \\   _;   ||\r\n                            / /    _     \\_      '.'\\ ' /   ||\r\n                           /.'   .'        \\_      .|   \\   \\|\r\n                          / /   /      __.---'      '._  ;  ||\r\n                         /.'  _:-.____< ,_           '.\\ \\  ||\r\n                        // .-'     '-.__  '-'-\\_      '.\\/_ \\|\r\n                       ( };====.===-==='        '.    .  \\\\: \\\r\n                        \\\\ '._        /          :   ,'   )\\_ \\\r\n                         \\\\   '------/            \\ .    /   )/\r\n                          \\|        _|             )Y    |   /\r\n                           \\\\      \\             .','   /  ,/\r\n                            \\\\    _/            /     _/\r\n                             \\\\   \\           .'    .'\r\n                              '| '1          /    .'\r\n                                '. \\        |:    /\r\n                                  \\ |       /', .'\r\n                                   \\(      ( ;z'\r\n                                    \\:      \\ '(_\r\n                                     \\_,     '._ '-.___\r\n                                              '-' -.\\");
            Console.WriteLine();
            Console.WriteLine("                                           ----- !! Fight !! -----       ");
            Console.WriteLine("  o        \\o/         o        \\o/\r\n /|\\        |         /|\\        |\r\n / \\       / \\        / \\       / \\\r\n");



        }
    }
}
