using Microsoft.AspNetCore.Mvc;

namespace WebApplication2.Controllers
{
    public class HomeController : Controller
    {
        [Route("")]
        public IActionResult Index()
        {
            return View();
        }
        [Route("/Programming/Info/{lang}/{color?}")]
        public IActionResult ProgrammingLangInfo(string lang, string color="black")
        {
            ViewBag.color = color;
            ViewBag.lang = lang;
            if (lang == "CSharp")
            {
                ViewBag.info = "С# – это объектно-ориентированный язык программирования. Он был создан в период с 1998 по 2002 год командой инженеров Microsoft под руководством Андерса Хейлсберга и Скотта Вильтаумота. \r\n\r\nЯзык входит в семью С-подобных языков. Синтаксис приближен к Java и C++.";
            }
            else if (lang =="Java")
            {
                ViewBag.info = "Java – это многоплатформенный, объектно-ориентированный и сетецентрический язык, который сам по себе может использоваться как платформа. Это быстрый, безопасный и надежный язык программирования для всего: от мобильных приложений и корпоративного ПО до приложений для работы с большими данными и серверных технологий.";
            }
            else if (lang == "Pascal")
            {
                ViewBag.info = "Pascal — это универсальный язык программирования, отличающийся строгой структурой и типизацией переменных, а также интуитивно понятным синтаксисом. Был разработан швейцарским ученым Никлаусом Виртом в 1970 году на базе языка Алгол-68 для обучения студентов структурному программированию.";
            }
            else
            {
                ViewBag.info = "Нету информации о этом языке программирования";
            }
            return View();
        }
        [Route("/Programming/Example/{lang}")]
        public IActionResult ExampleLang(string lang)
        {
            ViewBag.lang = lang;
            if (lang == "CSharp")
            {
                ViewBag.example = "using System;\r\n\r\n    namespace Calculator\r\n    {\r\n        class Program\r\n        {\r\n            static void Main(string[] args)\r\n            {\r\n                // Declare variables and then initialize to zero.\r\n                int num1 = 0; int num2 = 0;\r\n\r\n                // Display title as the C# console calculator app.\r\n                Console.WriteLine(\"Console Calculator in C#\\r\");\r\n                Console.WriteLine(\"------------------------\\n\");\r\n\r\n                // Ask the user to type the first number.\r\n                Console.WriteLine(\"Type a number, and then press Enter\");\r\n                num1 = Convert.ToInt32(Console.ReadLine());\r\n\r\n                // Ask the user to type the second number.\r\n                Console.WriteLine(\"Type another number, and then press Enter\");\r\n                num2 = Convert.ToInt32(Console.ReadLine());\r\n\r\n                // Ask the user to choose an option.\r\n                Console.WriteLine(\"Choose an option from the following list:\");\r\n                Console.WriteLine(\"\\ta - Add\");\r\n                Console.WriteLine(\"\\ts - Subtract\");\r\n                Console.WriteLine(\"\\tm - Multiply\");\r\n                Console.WriteLine(\"\\td - Divide\");\r\n                Console.Write(\"Your option? \");\r\n\r\n                // Use a switch statement to do the math.\r\n                switch (Console.ReadLine())\r\n                {\r\n                    case \"a\":\r\n                        Console.WriteLine($\"Your result: {num1} + {num2} = \" + (num1 + num2));\r\n                        break;\r\n                    case \"s\":\r\n                        Console.WriteLine($\"Your result: {num1} - {num2} = \" + (num1 - num2));\r\n                        break;\r\n                    case \"m\":\r\n                        Console.WriteLine($\"Your result: {num1} * {num2} = \" + (num1 * num2));\r\n                        break;\r\n                    case \"d\":\r\n                        Console.WriteLine($\"Your result: {num1} / {num2} = \" + (num1 / num2));\r\n                        break;\r\n                }\r\n                // Wait for the user to respond before closing.\r\n                Console.Write(\"Press any key to close the Calculator console app...\");\r\n                Console.ReadKey();\r\n            }\r\n        }\r\n    }\r\n";
            }
            else if (lang == "Java")
            {
                ViewBag.example = "class HelloJava {\r\n   public static void main(String[] args) {\r\n       System.out.println(\"Hello, Java!\");\r\n   }\r\n}";
            }
            else if (lang == "Pascal")
            {
                ViewBag.example = "program n_2;\r\n\r\nvar i: integer;\r\n    a: array[1..10] of integer;\r\n\r\nbegin\r\n  randomize;\r\n\r\n  for i:=1 to 10 do\r\n    a[i]:=random(100);\r\n\r\n  for i:=1 to 10 do\r\n    write(a[i],' ');\r\nend.";
            }
            else
            {
                ViewBag.info = "Нету информации о этом языке программирования";
            }
            return View();
        }

    }
}
