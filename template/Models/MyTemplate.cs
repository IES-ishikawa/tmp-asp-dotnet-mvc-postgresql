using System.ComponentModel.DataAnnotations.Schema;

namespace Template.Models;

public class MyTemplate
{
    [Column("id")]
    public int Id { get; set; }

    [Column("name")]
    public string? Name { get; set; }
}
