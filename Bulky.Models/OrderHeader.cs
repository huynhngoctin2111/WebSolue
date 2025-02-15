using BulkyBook.Models;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

public class OrderHeader
{
    public int Id { get; set; }
    public string ApplicationUserId { get; set; }
    [ForeignKey("ApplicationUserId")]
    [ValidateNever]
    public ApplicationUser ApplicationUser { get; set; }

    // Gán OrderDate là thời gian hiện tại (bao gồm giờ, phút, giây) khi đơn hàng được tạo
    public DateTime OrderDate { get; set; } = DateTime.Now;

    // Gán ShippingDate là thời gian hiện tại cộng thêm 2 ngày (bao gồm giờ, phút, giây)
    public DateTime ShippingDate { get; set; } = DateTime.Now.AddDays(2);

    public double OrderTotal { get; set; }

    public string? OrderStatus { get; set; }
    public string? PaymentStatus { get; set; }
    public string? TrackingNumber { get; set; }
    public string? Carrier { get; set; }

    public DateTime PaymentDate { get; set; }
    public DateTime PaymentDueDate { get; set; }

    public string? SessionId { get; set; }
    public string? PaymentIntentId { get; set; }

    [Required]
    public string PhoneNumber { get; set; }
    [Required]
    public string StreetAddress { get; set; }
    [Required]
    public string City { get; set; }
    [Required]
    public string State { get; set; }
    [Required]
    public string PostalCode { get; set; }
    [Required]
    public string Name { get; set; }
}
