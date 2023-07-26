using System.ServiceModel;
using System.Threading.Tasks;

namespace NotificadorBCCR
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IRespuestaDeSolicitud" in both code and config file together.
    [ServiceContract]
    public interface IRespuestaDeSolicitud
    {
        [OperationContract]
        void NotifiqueLaRespuesta(SI.ResultadoFirma.ResultadoDeFirma elResultado);

        [OperationContract]
        bool ValideElServicio();

        [OperationContract]
        Task NotifiqueLaRespuestaAsync(SI.ResultadoFirma.ResultadoDeFirma elResultado);

        [OperationContract]
        Task<bool> ValideElServicioAsync();
    }
}


