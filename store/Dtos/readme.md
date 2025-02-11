// preparing to add PUT requests . for updating the current requests // 

-- so far added -- 

// PUT REQUEST'S // 

app.MapPut("flagstore/{id}", (int id, UpdateStoreDto updatedStoreDto) =>
 {
    
});

app.Run();

// prewritten steps // 

namespace store.Dtos;

public record class StoreDto(int Id,
  string AlbumName, 
  string Genre,
  decimal Streams, 
  string Artist,
  DateOnly ReleaseDate){

}

first dto created , concludes first schema // 


// second schema Dto's Model / 

namespace store.Dtos;

public record class CreateStoreDto(
    String Name,
    String Genre,
    decimal Streams,
    string Artist,
    DateOnly ReleaseDate
)
{

}


// added the GET AND POST REQUEST'S // 


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



10/2/25

have to implement update store dto's

go through to the commit history once again // 

/// ---------------- /// 

implement complete PUT request's , include some readme's for the steps so far takin /

implemented the PUT request's , however the DEL is pending 