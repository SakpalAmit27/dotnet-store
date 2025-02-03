namespace store.Dtos;

public record class StoreDto(int Id,
  string AlbumName, 
  string Genre,
  string? Streams, 
  string Artist,
  DateOnly ReleaseDate){

}
