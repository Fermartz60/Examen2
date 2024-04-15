using System.ComponentModel.DataAnnotations;

namespace BlazorApp1.Data
{
    public class Persona
    {
        [Required(ErrorMessage = "El número de inventario es Requerido")]
        [MaxLength(100, ErrorMessage = "Debe ser un valor positivo y único Valido")]
        public string? Inventario { get; set; }

        [Required(ErrorMessage = "Requiere nombre de Producto")]
        [MaxLength(10, ErrorMessage = "Máximo 10 letras")]
        public string? Nombre { get; set; }

        public enum Departamento
        {
            Frutas,
            Verduras,
            Lacteos
        }
        public Departamento SelectedDepartamento { get; set; }
    }
}
