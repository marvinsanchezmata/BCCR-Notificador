﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NotificadorBCCR.SI.ResultadoFirma {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ResultadoDeFirma", Namespace="http://schemas.datacontract.org/2004/07/Bccr.Firma.Fva.Entidad.Contenedores")]
    [System.SerializableAttribute()]
    public partial class ResultadoDeFirma : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int CodigoDeErrorField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private byte[] DocumentoFirmadoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool FueExitosaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private byte[] HashDelDocumentoFirmadoEnBytesField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string HashDocumentoFirmadoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IDAlgoritmoHashDocumentoFirmadoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdDeLaSolicitudField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int CodigoDeError {
            get {
                return this.CodigoDeErrorField;
            }
            set {
                if ((this.CodigoDeErrorField.Equals(value) != true)) {
                    this.CodigoDeErrorField = value;
                    this.RaisePropertyChanged("CodigoDeError");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public byte[] DocumentoFirmado {
            get {
                return this.DocumentoFirmadoField;
            }
            set {
                if ((object.ReferenceEquals(this.DocumentoFirmadoField, value) != true)) {
                    this.DocumentoFirmadoField = value;
                    this.RaisePropertyChanged("DocumentoFirmado");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool FueExitosa {
            get {
                return this.FueExitosaField;
            }
            set {
                if ((this.FueExitosaField.Equals(value) != true)) {
                    this.FueExitosaField = value;
                    this.RaisePropertyChanged("FueExitosa");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public byte[] HashDelDocumentoFirmadoEnBytes {
            get {
                return this.HashDelDocumentoFirmadoEnBytesField;
            }
            set {
                if ((object.ReferenceEquals(this.HashDelDocumentoFirmadoEnBytesField, value) != true)) {
                    this.HashDelDocumentoFirmadoEnBytesField = value;
                    this.RaisePropertyChanged("HashDelDocumentoFirmadoEnBytes");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string HashDocumentoFirmado {
            get {
                return this.HashDocumentoFirmadoField;
            }
            set {
                if ((object.ReferenceEquals(this.HashDocumentoFirmadoField, value) != true)) {
                    this.HashDocumentoFirmadoField = value;
                    this.RaisePropertyChanged("HashDocumentoFirmado");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int IDAlgoritmoHashDocumentoFirmado {
            get {
                return this.IDAlgoritmoHashDocumentoFirmadoField;
            }
            set {
                if ((this.IDAlgoritmoHashDocumentoFirmadoField.Equals(value) != true)) {
                    this.IDAlgoritmoHashDocumentoFirmadoField = value;
                    this.RaisePropertyChanged("IDAlgoritmoHashDocumentoFirmado");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int IdDeLaSolicitud {
            get {
                return this.IdDeLaSolicitudField;
            }
            set {
                if ((this.IdDeLaSolicitudField.Equals(value) != true)) {
                    this.IdDeLaSolicitudField = value;
                    this.RaisePropertyChanged("IdDeLaSolicitud");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="SI.ResultadoFirma.ResultadoDeSolicitud")]
    public interface ResultadoDeSolicitud {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ResultadoDeSolicitud/NotifiqueLaRespuesta", ReplyAction="http://tempuri.org/ResultadoDeSolicitud/NotifiqueLaRespuestaResponse")]
        void NotifiqueLaRespuesta(NotificadorBCCR.SI.ResultadoFirma.ResultadoDeFirma elResultado);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ResultadoDeSolicitud/NotifiqueLaRespuesta", ReplyAction="http://tempuri.org/ResultadoDeSolicitud/NotifiqueLaRespuestaResponse")]
        System.Threading.Tasks.Task NotifiqueLaRespuestaAsync(NotificadorBCCR.SI.ResultadoFirma.ResultadoDeFirma elResultado);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ResultadoDeSolicitud/ValideElServicio", ReplyAction="http://tempuri.org/ResultadoDeSolicitud/ValideElServicioResponse")]
        bool ValideElServicio();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ResultadoDeSolicitud/ValideElServicio", ReplyAction="http://tempuri.org/ResultadoDeSolicitud/ValideElServicioResponse")]
        System.Threading.Tasks.Task<bool> ValideElServicioAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ResultadoDeSolicitudChannel : NotificadorBCCR.SI.ResultadoFirma.ResultadoDeSolicitud, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ResultadoDeSolicitudClient : System.ServiceModel.ClientBase<NotificadorBCCR.SI.ResultadoFirma.ResultadoDeSolicitud>, NotificadorBCCR.SI.ResultadoFirma.ResultadoDeSolicitud {
        
        public ResultadoDeSolicitudClient() {
        }
        
        public ResultadoDeSolicitudClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ResultadoDeSolicitudClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ResultadoDeSolicitudClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ResultadoDeSolicitudClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void NotifiqueLaRespuesta(NotificadorBCCR.SI.ResultadoFirma.ResultadoDeFirma elResultado) {
            base.Channel.NotifiqueLaRespuesta(elResultado);
        }
        
        public System.Threading.Tasks.Task NotifiqueLaRespuestaAsync(NotificadorBCCR.SI.ResultadoFirma.ResultadoDeFirma elResultado) {
            return base.Channel.NotifiqueLaRespuestaAsync(elResultado);
        }
        
        public bool ValideElServicio() {
            return base.Channel.ValideElServicio();
        }
        
        public System.Threading.Tasks.Task<bool> ValideElServicioAsync() {
            return base.Channel.ValideElServicioAsync();
        }
    }
}