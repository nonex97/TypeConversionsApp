

Console.Write("What is your age: ");
string? ageText = Console.ReadLine();

//Console.WriteLine(ageText + 15); // this will give us a string concatenation, not a mathematical addition (e.g. 30+15 will be 3015)

//int age = int.Parse(ageText); // this will only work if the user gives a number, if it's anything else it will crash

bool isValidInt = int.TryParse(ageText, out int age); // this will try to parse the input, if it fails it will return age as 0 (default)

Console.WriteLine($"The input is valid : {isValidInt}. The number was {age}." );

Console.WriteLine(age + 15);


double testDouble = age; // we can put an integer into a double, because we are not losing any information
//decimal testDecimal = testDouble; // this will not work
decimal testDecimal = (decimal)testDouble; // this is called casting, and will work but not on all variables