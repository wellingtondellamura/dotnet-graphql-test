namespace GraphQLCourses.Models
{
   using System;

public class Course
{
    public int ID { get; set; }
    public string Descricao { get; set; }
    public string DescricaoHistorico { get; set; }
    public string CodigoCensup { get; set; }
    public string CodigoEmec { get; set; }
    public string CodigoSistec { get; set; }
    public string CodigoEducacenso { get; set; }
    public int AnoLetivo { get; set; }
    public int PeriodoLetivo { get; set; }
    public string DataInicio { get; set; }
    public string DataFim { get; set; }
    public bool Ativo { get; set; }
    public bool PossuiAlunoCursando { get; set; }
    public int Codigo { get; set; }
    public string NaturezaParticipacao { get; set; }
    public string Modalidade { get; set; }
    public string Area { get; set; }
    public string Eixo { get; set; }
    public string AreaCapes { get; set; }
    public string Periodicidade { get; set; }
    public bool ExigeEnade { get; set; }
    public bool ExigeColacaoGrau { get; set; }
    public bool EmiteDiploma { get; set; }
    public string AreaConcentracao { get; set; }
    public string Programa { get; set; }
    public string Diretoria { get; set; }
    public string Extensao { get; set; }
    public string Coordenador { get; set; }
    public string NumeroPortariaCoordenador { get; set; }
    public string TituloCertificadoMasculino { get; set; }
    public string TituloCertificadoFeminino { get; set; }
    public string Matrizes { get; set; }
}

}
