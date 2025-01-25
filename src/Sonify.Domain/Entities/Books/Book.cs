using Sonify.Domain.Commons;
using Sonify.Domain.Entities.Commons;
using Sonify.Domain.Enums;

namespace Sonify.Domain.Entities.Books;

public class Book : Auditable
{
    public string Name { get; set; }
    public string Author { get; set; }
    public Genre Genre { get; set; }
    public string Language { get; set; }
    public long? PictureId {  get; set; }
    public Asset Picture { get; set; }
    public long FilePathId {  get; set; }
    public Asset FilePath { get; set; }
}
