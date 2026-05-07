using ShelterudlejningssystemetLib;

Console.WriteLine("Hello, World!");

List<FDF_Shelter> shelters = new List<FDF_Shelter>();

shelters.Add(new FDF_Shelter(1, "numero uno", "Ganløse", 5, 3660, true));
shelters.Add(new FDF_Shelter(2, "numero dos", "Ganløse", 5, 3660, false));

