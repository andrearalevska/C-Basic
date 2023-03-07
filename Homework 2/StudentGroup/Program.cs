string[] studentsG1 = new string[] { "Zdravko", "Petko", "Stanko", "Branko", "Trajko" };
string[] studentsG2 = new string[] { "Ana", "Elena", "Ivana", "Marija", "Simona" };

Console.WriteLine("Enter student group ( there are 1 and 2 ):");
string studentsGroup = Console.ReadLine();

if(studentsGroup == "1")
{
    Console.WriteLine("Students in Group 1 are:");
    
    foreach (string student in studentsG1)
    {
        Console.WriteLine(student);
    }
}
else if (studentsGroup == "2")
{
    Console.WriteLine("Students in Group 2 are:");
    
    foreach (string student in studentsG2)
    {
        Console.WriteLine(student);
    }
}
else
{
    Console.WriteLine("Please choose 1 or 2!");
}