namespace TImeSheetsSample.Models.Entities;

public class Service
{
    public Guid Id { get; set; }
    public string Name { get; set; }

    public ICollection<Sheet> Sheets { get; set; }
}