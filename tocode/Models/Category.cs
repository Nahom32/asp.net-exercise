using System.ComponentModel.DataAnnotations;
namespace tocode.Models;

public class Category
{
    [Key]
    public int Id { get; set; }
    [Required]
    public string? Name { get; set; }
    
    public int displayOrder{ get; set; }
    
    public DateTime CreatedDateTime { get; set; } = DateTime.Now;

}