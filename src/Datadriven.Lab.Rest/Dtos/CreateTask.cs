using System.ComponentModel.DataAnnotations;

namespace Datadriven.Lab.Rest.Dtos;

// DO NOT CHANGE ANYTHING
// NE VALTOZTASS MEG SEMMIT
public record CreateTask([Required] string Title, [Required] string Status);
