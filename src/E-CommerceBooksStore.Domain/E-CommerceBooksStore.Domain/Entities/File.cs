using E_CommerceBooksStore.Domain.Common;

namespace E_CommerceBooksStore.Domain.Entities
{
    public class File : BaseAuditableEntity
    {
        public string FileName { get; set; } = null!;
        public string Path { get; set; } = null!;
        public string Storage { get; set; } = null!;
    }
}
