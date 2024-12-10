using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace InventoryData.Entity;

public class Inventory
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    [MaxLength(50)] public string Name { get; set; } = default!;
    
    [Precision(12, 6)]
    public decimal Count { get; set; }

    public DateTime UpdateTime { get; set; }
}