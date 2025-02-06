using System.Net.Sockets;
using store;
using store.Dtos;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

        // providing the id to the flagstore , which 
const string GetFlagEndpointName = "getFlag";

List<StoreDto> store = [

     new StoreDto(1, "Master of Puppets", "Thrash Metal",7.5M, "Metallica", new DateOnly(1986, 7, 1)),
    new StoreDto(7, "Led Zeppelin IV", "Hard Rock", 37.2M, "Led Zeppelin", new DateOnly(1971, 11, 8)),
    new StoreDto(8, "Slayer", "Thrash Metal",5.5M, "Reign in Blood", new DateOnly(1992, 8, 12)),
    new StoreDto(9, "Ride the Lightning", "Thrash Metal",4.2M, "Metallica", new DateOnly(1984, 11, 21)),
    new StoreDto(10, "Purpose", "Pop", 26.2M, "Justin Beiber", new DateOnly(2015, 9, 21))

];


// this is a minimal api // 
app.MapGet("flagstore", () => store);

// GET // store // 1

app.MapGet("flagstore/{id}", (int id) => store.Find(store => store.Id == id)).WithName(GetFlagEndpointName);

// post (put) create  // 

app.MapPost("flagstore",(CreateStoreDto newFlag) => {

    StoreDto flag = new(
        store.Count + 1, // increments the space here to add newFlags // 
        newFlag.Name,
        newFlag.Genre,
        newFlag.Streams,
        newFlag.Artist,
        newFlag.ReleaseDate);

        store.Add(flag); // adds the new flag // 


        // providing the id to the flagstore , which consits of withName .// 
        return Results.CreatedAtRoute(GetFlagEndpointName, new {id = flag.Id} , flag);

});


// PUT REQUEST'S // 

app.MapPut("flagstore/{id}", (int id, UpdateStoreDto updatedStoreDto) =>
 {
    
});

app.Run();
  