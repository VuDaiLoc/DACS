using Microsoft.AspNetCore.Identity;

public class ApplicationUser : IdentityUser
{
    // Thêm thuộc tính bổ sung nếu cần, ví dụ: Tên đầy đủ
    public string FullName { get; set; } = string.Empty;
}
