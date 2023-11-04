using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccess
{
    public class Cliente
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Nombre { get; set; }

        [Required]
        [StringLength(11)]
        public string Cedula { get; set; }
    }

    public class Inmueble
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Categoria { get; set; }

        public decimal? MetrosContruccion { get; set; }

        [Required]
        [StringLength(50)]
        public string Nombre { get; set; }

        [StringLength(50)]
        public string Zona { get; set; }

        [StringLength(50)]
        public string Parcela { get; set; }

        [StringLength(50)]
        public string Urbanizacion { get; set; }

        [Required]
        [StringLength(150)]
        public string Caracteristicas { get; set; }

        [Required]
        [StringLength(150)]
        public string Direccion { get; set; }

        [StringLength(150)]
        public string Referencias { get; set; }

        [Required]
        [StringLength(50)]
        public string TipoOperacion { get; set; }

        [StringLength(50)]
        public string Oficina { get; set; }

        [Required]
        public bool TieneLlaves { get; set; }

        [Required]
        public decimal PrecioAlquiler { get; set; }

        [Required]
        public decimal PrecioVenta { get; set; }

        [StringLength(50)]
        public string Piso { get; set; }

        [ForeignKey("PropietarioId")]
        public int PropietarioId { get; set; }

        public Propietario Propietario { get; set; }
    }

    public class Propietario
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Nombre { get; set; }

        [Required]
        [StringLength(50)]
        public string Telefono { get; set; }

        [Required]
        [StringLength(11)]
        public string Cedula { get; set; }
    }

    public class InmuebleVisita
    {
        public int Id { get; set; }

        public int ClienteId { get; set; }

        public int InmuebleId { get; set; }

        [Required]
        [StringLength(50)]
        public string Comentario { get; set; }

        [Required]
        public DateTime Fecha { get; set; }

        public Cliente Cliente { get; set; }

        public Inmueble Inmueble { get; set; }
    }
}