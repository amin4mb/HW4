var patch = "D:\\person_hw4.txt";
var importfile = File.Create(patch);
importfile.Close();
for (int i = 0; ; i++)
{

    Console.WriteLine($"enter name {i + 1}  for end enter N ");
    string name = Console.ReadLine().ToLower();
    if (name == "n")
    {
        break;
    }
    Console.WriteLine($"enter Family");
    string family = Console.ReadLine();

    Console.WriteLine($"enter Height ");
    int height = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine($"enter PhoneNumber");
    string phoneNumber = Console.ReadLine();

    Console.WriteLine($"enter FatherName");
    string fathername = Console.ReadLine();

    Console.WriteLine($"enter Weight ");
    int weight = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine($"enter Brithday");
    int brithday = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine($"enter Adres");
    string adres = Console.ReadLine();

    person PR = new person { ID = i + 100, Name = name, Family = family, Height = height, PhoneNumber = phoneNumber, FatherName = fathername, Weight = weight, Brithday = brithday, Adres = adres };

    string aaa = PR.ToString();
    File.AppendAllText(patch, aaa);
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
    oneperson.Brithday = Convert.ToInt32(data[7]);
    oneperson.Adres = data[8];
    lists.Add(oneperson);

    Console.WriteLine($"{oneperson.ID} - {oneperson.Name} - {oneperson.Family}");
}

File.WriteAllText(patch,"");

