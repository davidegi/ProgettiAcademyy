// Classe Guid per generare un numero automatico

class Guid {
    static newGuid() {
      return 'xxxxxxxx-xxxx-4xxx-yxxx-xxxxxxxxxxxx'.replace(/[xy]/g, function(c) {
        var r = Math.random() * 16 | 0,
          v = c == 'x' ? r : (r & 0x3 | 0x8);
        return v.toString(16);
      });
    }
  }

// Classe Oggetto
class Oggetto{
    private nome: String;
    private codice: Number;
    private descrizione: String;

    constructor(){}

    public setNome(varNome: String) : void{
        this.nome = varNome;
    }

    public getNome() : String{
        return this.nome
    }

    public setCodice(varCodice: Number) : void{
        this.codice = varCodice;
    }

    public getCodice() : Number{
        return this.codice
    }

    public setDescrizione(varDescrizione: String) : void{
        this.descrizione = varDescrizione;
    }

    public getDescrizione() : String{
        return this.descrizione
    }

}

// Classe Persona
class Persona{
    private nominativo: String;
    private codiceAuto: String = Guid.newGuid();
    public elencoOggetti: Oggetto[];

    constructor(){}



    public setNominativo(varNominativo: String) : void{
        this.nominativo = varNominativo;
    }
    public getNominativo() : String{
        return this.nominativo
    }

    public setCodiceAuto(varCodiceAuto: String) : void{
        this.codiceAuto = varCodiceAuto;
    }
    public getCodiceAuto() : String{
        return this.codiceAuto
    }
}

// Classe Proposta
class Proposta{
    private codice: String;
    private mittente: String;
    private destinatario: String;

    constructor(){}

    public setCodice(varCodice: String) : void{
        this.codice = varCodice;
    }
    public getCodice() : String{
        return this.codice
    }

    public setMittente(varMittente: String) : void{
        this.mittente = varMittente;
    }
    public getMittente() : String{
        return this.mittente
    }

    public setDestinatario(varDestinatario: String) : void{
        this.destinatario = varDestinatario;
    }
    public getDestinatario() : String{
        return this.destinatario
    }
}

// Classe Transazione
class Transazione{
    private codiceUnivoco: String;

    constructor(){}

    public setCodiceUnivoco(varCodiceUnivoco: String) : void{
        this.codiceUnivoco = varCodiceUnivoco;
    }
    public getCodiceUnivoco() : String{
        return this.codiceUnivoco
    }
}