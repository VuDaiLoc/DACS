using System.ComponentModel.DataAnnotations;

namespace DACS.Models
{
    public class Vehicle
    {
        public int Id { get; set; }

        [Required]
        public string CardCode { get; set; } = string.Empty;

        [Required]
        public string CustomerName { get; set; } = string.Empty;

        [Required]
        public string Type { get; set; } = string.Empty;  // Ví dụ: Xe máy, Ô tô

        [Required]
        public string Brand { get; set; } = string.Empty; // Ví dụ: Honda, Toyota

        [Required]
        public string Color { get; set; } = string.Empty;

        [Required]
        public string LicensePlate { get; set; } = string.Empty;

        [Required]
        public string ParkingSlot { get; set; } = string.Empty;

        public DateTime TimeIn { get; set; } = DateTime.Now;

        public string Status { get; set; } = "Đang gửi";
    }
}
