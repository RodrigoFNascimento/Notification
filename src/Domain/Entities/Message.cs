namespace Domain.Entities;
public class Message
{
    public int CdNotificacao { get; set; } // CD_NOTIFICACAO (Primary key)
    public string DsNotificacao { get; set; } = ""; // DS_NOTIFICACAO
    public DateTime DtCadastro { get; set; } // DT_CADASTRO
    public decimal NrMatriculaUsuario { get; set; } // NR_MATRICULA_USUARIO
    public int CdTipoEnvioNotificacao { get; set; } // CD_TIPO_ENVIO_NOTIFICACAO
    public string DsTituloNotificacao { get; set; } = ""; // DS_TITULO_NOTIFICACAO
}
