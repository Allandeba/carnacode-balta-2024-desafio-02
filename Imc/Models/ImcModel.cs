using System.ComponentModel.DataAnnotations;
using Imc.Models.Enums;

namespace Imc.Models;

public class ImcModel
{
    private const string RequiredMessage = "Campo {0} é requerido";
    private const string RangeMessage = "{0} deve ser maior que {1} e menor que {2}";

    [Required(ErrorMessage = RequiredMessage)]
    [Range(0, 300, ErrorMessage = RangeMessage)]
    public int? Altura { get; set; } = null;
    [Required(ErrorMessage = RequiredMessage)]
    [Range(0, 300, ErrorMessage = RangeMessage)]
    public int? Peso { get; set; } = null;
    [Required(ErrorMessage = RequiredMessage)]
    public bool Idoso { get; set; } = false;
    [Required(ErrorMessage = RequiredMessage)]
    public EGenero Sexo { get; set; } = EGenero.NaoInformado;

    public EImcStatus Calcular() {
        return EImcStatus.Normal;
    }
}