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

  