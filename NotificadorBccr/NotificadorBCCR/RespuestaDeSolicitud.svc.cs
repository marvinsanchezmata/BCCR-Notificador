using NLog;
using NotificadorBCCR.SI.ResultadoFirma;
using System;
using System.Threading.Tasks;

namespace NotificadorBCCR
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "RespuestaDeSolicitud" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select RespuestaDeSolicitud.svc or RespuestaDeSolicitud.svc.cs at the Solution Explorer and start debugging.
    public class RespuestaDeSolicitud : IRespuestaDeSolicitud
    {
        private static Logger logger = LogManager.GetLogger("misReglas");
        public void NotifiqueLaRespuesta(SI.ResultadoFirma.ResultadoDeFirma elResultado)
        {
            try
            {
                logger.Info($"Se recibe la notificación.");
                logger.Info($"Hash: {elResultado.HashDocumentoFirmado}");
                logger.Info($"Id Alg: {elResultado.IDAlgoritmoHashDocumentoFirmado}");
                logger.Info($"Cód error: {elResultado.CodigoDeError}");
                logger.Info($"Fue Exitosa?: {elResultado.FueExitosa}");
                logger.Info($"Id soli: {elResultado.IdDeLaSolicitud}");
            }
            catch (Exception ex)
            {

                logger.Error($"{ex}. -- {DateTime.UtcNow}");
            }
            
        }

        public async Task NotifiqueLaRespuestaAsync(ResultadoDeFirma elResultado)
        {
            try
            {
                logger.Info($"Se recibe la notificación.");
                logger.Info($"Hash: {elResultado.HashDocumentoFirmado}");
                logger.Info($"Id Alg: {elResultado.IDAlgoritmoHashDocumentoFirmado}");
                logger.Info($"Cód error: {elResultado.CodigoDeError}");
                logger.Info($"Fue Exitosa?: {elResultado.FueExitosa}");
                logger.Info($"Id soli: {elResultado.IdDeLaSolicitud}");
                
            }
            catch (Exception ex)
            {

                logger.Error($"{ex}. -- {DateTime.UtcNow}");
            }
        }

        public bool ValideElServicio()
        {
            logger.Info($"Verifican que el servicio esté en línea.");
            return true;
        }

        public async Task<bool> ValideElServicioAsync()
        {
            return true;
        }
    }
}
