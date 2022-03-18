public class person
{
    public int ID { get; set; }    
    public string Name { get; set; }
    public string Family { get; set; }
    public int Height { get; set; }
    public string PhoneNumber { get; set; }
    public string FatherName { get; set; }
    public int Weight { get; set; }
    public int Brithday { get; set; }
    public string Adres { get; set; }
    public override string? ToString()
    {
        return $"{ID},{Name},{Family},{Height},{PhoneNumber},{FatherName},{Weight},{Brithday},{Adres}\n";
    }

}

