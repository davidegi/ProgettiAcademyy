using System;
using System.Collections.Generic;

namespace GestioneImpiegati.Models;

public partial class CittaResidenza
{
    public int CittaResidenzaId { get; set; }

    public string Citta { get; set; } = null!;

    public virtual ICollection<ProvinciaResidenza> ProvinciaResidenzas { get; set; } = new List<ProvinciaResidenza>();
}
