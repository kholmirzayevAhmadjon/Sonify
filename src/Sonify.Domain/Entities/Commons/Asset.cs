using Sonify.Domain.Commons;

namespace Sonify.Domain.Entities.Commons;

public class Asset : Auditable
{
    public string Name { get; set; }
    public string Path { get; set; }
    public string FileType { get; set; }
}
