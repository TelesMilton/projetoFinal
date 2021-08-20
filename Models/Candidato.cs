using System;

namespace projetoFinal.Models
{

  public class Candidato
  {

    public int Id_Candidato { get;set; }

    public string Nome { get;set; }

    public string Nascimento { get;set; }

    public string Cep {get; set; }

    public string Logradouro {get; set; }

    public string Numero {get; set; }

    public string Bairro {get; set; }

    public string Cidade {get; set; }

    public string UF {get; set; }

    public string Telefone {get; set; }
    
    public string Email {get; set; }

    public int ProfissaoID {get;set;}
    
  }
}