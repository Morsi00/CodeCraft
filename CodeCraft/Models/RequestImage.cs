namespace CodeCraft.Models
{

// صور العميل المرفقة مع الطلب
public class RequestImage
{
    public int Id { get; set; }

    public int RequestId { get; set; }
    public ProjectRequest Request { get; set; } = null!;

    public string FileName { get; set; } = null!;   // الاسم الأصلي للعرض
    public string FilePath { get; set; } = null!;   // المسار (اسم عشوائي GUID)
    public DateTime UploadedAt { get; set; } = DateTime.UtcNow;
}
}
