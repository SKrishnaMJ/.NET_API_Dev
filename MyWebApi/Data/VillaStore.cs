namespace MyWebApi;

public static class VillaStore
{
    public static List<VillaDTO> villaList = new List<VillaDTO>{
                new VillaDTO{Id=1, Name="Pool View", Sqft=100, Occupancy="Engineer"},
                new VillaDTO{Id=2, Name="Beach View", Sqft=200, Occupancy="Pioneer"},
            };
}
