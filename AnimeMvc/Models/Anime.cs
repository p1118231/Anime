using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Contracts;

namespace AnimeMvc.Models;

public class Anime{
    public int Id {get;set ;}

    public string? Title {get;set;}

    public string? Description {get; set;}
    
}