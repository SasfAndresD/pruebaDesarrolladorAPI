using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace pruebaDesarrollador.Entity
{
    public class Cotizador
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int tazaId { get; set; }
        public float valorRendimiento { get; set; }
        public float MontoRecibir { get; set; }

    }   
}
