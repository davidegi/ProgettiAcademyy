using System;
using System.Collections.Generic;

namespace GestioneImpiegati.Models;

public partial class ProvinciaResidenza
{
    public int ProvinciaResidenzaId { get; set; }

    public string Provincia { get; set; } = null!;

    public int CittaRif { get; set; }

    public virtual CittaResidenza CittaRifNavigation { get; set; } = null!;
}
