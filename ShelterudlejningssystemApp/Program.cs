using ShelterudlejningssystemetLib;

Console.WriteLine("Hello, World!");

List<FDF_Shelter> shelters = new List<FDF_Shelter>();

shelters.Add(new FDF_Shelter(1, "numero uno", "Ganløse", 5, 3660, false));
shelters.Add(new FDF_Shelter(2, "numero dos", "Ganløse", 5, 3660, true));

foreach  (FDF_Shelter shelter in shelters)
{
    if (shelter.ErLedig == true)
    {
        Console.WriteLine(" Ledig: " + shelter.ShelterNavn); 
    }
    if (shelter.ErLedig == false)
    {
        Console.WriteLine(" Optaget: " + shelter.ShelterNavn);
    }
}
    