﻿using EAgenda.Dominio.Compartilhado;
using EAgenda.Dominio.ModuloContato;

namespace EAgenda.Dominio.Modulo_Compromissos;

public class Compromisso : EntidadeBase<Compromisso>
{
    public string Assunto { get; set; }
    public DateOnly DataDeOcorrencia { get; set; }
    public TimeSpan HoraDeInicio { get; set; }
    public TimeSpan HoraDeTermino { get; set; }
    public string TipoDeCompromisso { get; set; }
    public string Local { get; set; }
    public string Link { get; set; }

    public List<Contato> Contatos { get; set; } = new List<Contato>();

    public Compromisso() { }

    public Compromisso(
        string assunto,
        DateOnly dataDeOcorrencia,
        TimeSpan horaDeInicio,
        TimeSpan horaDeTermino,
        string tipoDeCompromisso,
        string local,
        string link,
        List<Contato> contatos)
    {
        Assunto = assunto;
        DataDeOcorrencia = dataDeOcorrencia;
        HoraDeInicio = horaDeInicio;
        HoraDeTermino = horaDeTermino;
        TipoDeCompromisso = tipoDeCompromisso;
        Local = local;
        Link = link;
        Contatos = contatos ?? new List<Contato>();
    }

    public Compromisso(
        Guid id,
        string assunto,
        DateOnly dataDeOcorrencia,
        TimeSpan horaDeInicio,
        TimeSpan horaDeTermino,
        string tipoDeCompromisso,
        string local,
        string link,
        List<Contato> contatos)
        : this(assunto, dataDeOcorrencia, horaDeInicio, horaDeTermino, tipoDeCompromisso, local, link, contatos)
    {
        Id = id;
    }

    public override void AtualizarRegistro(Compromisso registroEditado)
    {
        Assunto = registroEditado.Assunto;
        DataDeOcorrencia = registroEditado.DataDeOcorrencia;
        HoraDeInicio = registroEditado.HoraDeInicio;
        HoraDeTermino = registroEditado.HoraDeTermino;
        TipoDeCompromisso = registroEditado.TipoDeCompromisso;
        Local = registroEditado.Local;
        Link = registroEditado.Link;
        Contatos = registroEditado.Contatos ?? new List<Contato>();
    }
}
