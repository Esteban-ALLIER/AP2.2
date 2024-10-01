using System;

namespace ASPBookProject.Models;

public class Patient
{
 public int PatientId  {get; set;}
 public string? Nom {get; set;}
 public string? Prenom {get; set;}
 public int Age {get; set;}
 public string? Sexe {get; set;}
 public string? Antecedents  {get; set;}
 public string? Allergies  {get; set;}
}
