using System;
using System.Collections.Generic;

namespace GestioneFerramenta.Models;

public partial class Ferramentum
{
    public int FerramentaId { get; set; }

    public string? Codice { get; set; }

    public string Nome { get; set; } = null!;

    public string? Descrizione { get; set; }

    public decimal Prezzo { get; set; }

    public int Quantita { get; set; }

    public string Categoria { get; set; } = null!;

    public DateOnly? Creazione { get; set; }
}
