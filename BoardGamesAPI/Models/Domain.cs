using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BoardGamesAPI.Models;

[Table("Domains")]
public class Domain
{
    [Key]
    [Required]
    public int Id { get; set; }
    
    [Required]
    public string? Name { get; set; }

    [Required]
    public DateTime CreatedDate { get; set; }

    [Required]
    public DateTime LastModifiedDate { get; set; }
}
