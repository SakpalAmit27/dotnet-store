namespace store.Dtos;

public record class UpdateStoreDto(
    String Name,
    String Genre,
    decimal Streams,
    string Artist,
    DateOnly ReleaseDate
){

}
