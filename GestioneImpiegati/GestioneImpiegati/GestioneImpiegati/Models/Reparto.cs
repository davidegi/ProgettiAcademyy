using System;
using System.Collections.Generic;

namespace GestioneImpiegati.Models;

public partial class Reparto
{
    public int RepartoId { get; set; }

    public string TipoReparto { get; set; } = null!;
}
