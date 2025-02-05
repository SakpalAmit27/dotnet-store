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
