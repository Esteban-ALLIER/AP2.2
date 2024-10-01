using System;

namespace ASPBookProject.Models;

public class Ordonnance
{
    public int OrdonnanceId { get; set; }
    public int Duree { get; set; }
    public string? Instruction { get; set; }
    public string? Posologie { get; set; }
    public string? Allergies { get; set; }
    public  DateTime Date { get; set; }

}
