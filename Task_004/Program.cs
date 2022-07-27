using Task_004;

ColorSettings cs = new ColorSettings();

var consoleForegroundColor =
    (ConsoleColor)Enum.Parse(typeof(ConsoleColor), cs.config["MyColor"]);
Console.ForegroundColor = consoleForegroundColor;

string? userColor = cs.UserChoice();
cs.Changer(userColor);

Console.WriteLine($"The color has been installed. " +
    $"Restart the app to check it!");

Console.ReadKey();