// Classe Oggetto
var Oggetto = /** @class */ (function () {
    function Oggetto() {
    }
    Oggetto.prototype.setNome = function (varNome) {
        this.nome = varNome;
    };
    Oggetto.prototype.getNome = function () {
        return this.nome;
    };
    Oggetto.prototype.setCodice = function (varCodice) {
        this.codice = varCodice;
    };
    Oggetto.prototype.getCodice = function () {
        return this.codice;
    };
    Oggetto.prototype.setDescrizione = function (varDescrizione) {
        this.descrizione = varDescrizione;
    };
    Oggetto.prototype.getDescrizione = function () {
        return this.descrizione;
    };
    return Oggetto;
}());
// Classe Persona
var Persona = /** @class */ (function () {
    function Persona() {
    }
    Persona.prototype.setNominativo = function (varNominativo) {
        this.nominativo = varNominativo;
    };
    Persona.prototype.getNominativo = function () {
        return this.nominativo;
    };
    Persona.prototype.setCodiceAuto = function (varCodiceAuto) {
        this.codiceAuto = varCodiceAuto;
    };
    Persona.prototype.getCodiceAuto = function () {
        return this.codiceAuto;
    };
    return Persona;
}());
// Classe Proposta
var Proposta = /** @class */ (function () {
    function Proposta() {
    }
    Proposta.prototype.setCodice = function (varCodice) {
        this.codice = varCodice;
    };
    Proposta.prototype.getCodice = function () {
        return this.codice;
    };
    Proposta.prototype.setMittente = function (varMittente) {
        this.mittente = varMittente;
    };
    Proposta.prototype.getMittente = function () {
        return this.mittente;
    };
    Proposta.prototype.setDestinatario = function (varDestinatario) {
        this.destinatario = varDestinatario;
    };
    Proposta.prototype.getDestinatario = function () {
        return this.destinatario;
    };
    return Proposta;
}());
