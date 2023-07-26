using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestWCF.RespuestaSolicitudWCF;

namespace TestWCF
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RespuestaSolicitudWCF.RespuestaDeSolicitudClient resp = new RespuestaSolicitudWCF.RespuestaDeSolicitudClient();
            RespuestaSolicitudWCF.ResultadoDeFirma resFirma = new ResultadoDeFirma { CodigoDeError = 1000, FueExitosa = true, IdDeLaSolicitud = 69 };
            var isAlive = resp.ValideElServicio();
            resp.NotifiqueLaRespuesta(resFirma);
            var x = "hola123";
        }
    }
}
