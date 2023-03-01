using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
namespace tocode.Models;

public class Category
{
    [Key]
    public int Id { get; set; }
    [Required]
    public string? Name { get; set; }
    [DisplayName("Display Order")]
    [Range(1,100,ErrorMessage ="The number entered should be between one and hundred")]
    public int displayOrder{ get; set; }
    
    public DateTime CreatedDateTime { get; set; } = DateTime.Now;

}