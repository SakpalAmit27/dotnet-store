using store.Dtos;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");

List<StoreDto> store = [

     new StoreDto(1, "Master of Puppets", "Thrash Metal",7.5M, "Metallica", new DateOnly(1986, 7, 1)),
    new StoreDto(7, "Led Zeppelin IV", "Hard Rock", 37.2M, "Led Zeppelin", new DateOnly(1971, 11, 8)),
    new StoreDto(8, "Slayer", "Thrash Metal",5.5M, "Reign in Blood", new DateOnly(1992, 8, 12)),
    new StoreDto(9, "Ride the Lightning", "Thrash Metal",4.2M, "Metallica", new DateOnly(1984, 11, 21)),
    new StoreDto(10, "Purpose", "Pop", 26.2M, "Justin Beiber", new DateOnly(2015, 9, 21))

];


// this is a minimal api // 
app.MapGet("store", () => store);


app.Run();
