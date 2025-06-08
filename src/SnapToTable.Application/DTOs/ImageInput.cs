namespace SnapToTable.Application.DTOs;

public record ImageInput(
    Stream Content,
    string ContentType
);