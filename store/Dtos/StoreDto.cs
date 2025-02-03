namespace store.Dtos;

public record class StoreDto(int Id,
  string AlbumName, 
  string Genre,
  decimal Streams, 
  string Artist,
  DateOnly ReleaseDate){

}
