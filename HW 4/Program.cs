var patch = "D:\\person_hw4.txt";
var importfile = File.Create(patch);
importfile.Close();
for (int i = 0; ; i++)
{
    person PR = new person();

    Console.WriteLine($"enter name {i + 1} ***** for end enter N ");
    string name = Console.ReadLine().ToLower();
    if (name == "n")
    {
        break;
    }
    PR.Name = name;
    Console.WriteLine($"enter Family");
    PR.Family = Console.ReadLine();

    Console.WriteLine($"enter Height ");
    PR.Height = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine($"enter PhoneNumber");
    PR.PhoneNumber = Console.ReadLine();

    Console.WriteLine($"enter FatherName");
    PR.FatherName = Console.ReadLine();

    Console.WriteLine($"enter Weight ");
    PR.Weight = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine($"enter Brithdayt");
    PR.BrithDate = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine($"enter Adres");
    PR.Adres = Console.ReadLine();

    string str = PR.ToString();
    File.AppendAllText(patch, str);

    Console.Clear();
}


var line = File.ReadAllLines(patch);
List<person> lists = new List<person>();

foreach (var item in line)
{
    var data = item.Split(",").ToList<string>();
    person oneperson = new person();
    oneperson.ID = Convert.ToInt32(data[0]);
    oneperson.Name = data[1];
    oneperson.Family = data[2];
    oneperson.Height = Convert.ToInt32(data[3]);
    oneperson.PhoneNumber = data[4];
    oneperson.FatherName = data[5];
    oneperson.Weight = Convert.ToInt32(data[6]);
    oneperson.BrithDate = Convert.ToInt32(data[7]);
    oneperson.Adres = data[8];
    lists.Add(oneperson);

    Console.WriteLine($"{oneperson.ID} - {oneperson.Name} - {oneperson.Family}");
}

File.WriteAllText(patch,"");

