﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Front_End.ServiceReferenceDetalle {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.CollectionDataContractAttribute(Name="ArrayOfString", Namespace="http://tempuri.org/", ItemName="string")]
    [System.SerializableAttribute()]
    public class ArrayOfString : System.Collections.Generic.List<string> {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReferenceDetalle.wsDetalleSoap")]
    public interface wsDetalleSoap {
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de elemento NroBoleta del espacio de nombres http://tempuri.org/ no está marcado para aceptar valores nil.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Agregar", ReplyAction="*")]
        Front_End.ServiceReferenceDetalle.AgregarResponse Agregar(Front_End.ServiceReferenceDetalle.AgregarRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Agregar", ReplyAction="*")]
        System.Threading.Tasks.Task<Front_End.ServiceReferenceDetalle.AgregarResponse> AgregarAsync(Front_End.ServiceReferenceDetalle.AgregarRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class AgregarRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="Agregar", Namespace="http://tempuri.org/", Order=0)]
        public Front_End.ServiceReferenceDetalle.AgregarRequestBody Body;
        
        public AgregarRequest() {
        }
        
        public AgregarRequest(Front_End.ServiceReferenceDetalle.AgregarRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class AgregarRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string NroBoleta;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string CodProducto;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string cantidad;
        
        public AgregarRequestBody() {
        }
        
        public AgregarRequestBody(string NroBoleta, string CodProducto, string cantidad) {
            this.NroBoleta = NroBoleta;
            this.CodProducto = CodProducto;
            this.cantidad = cantidad;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class AgregarResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="AgregarResponse", Namespace="http://tempuri.org/", Order=0)]
        public Front_End.ServiceReferenceDetalle.AgregarResponseBody Body;
        
        public AgregarResponse() {
        }
        
        public AgregarResponse(Front_End.ServiceReferenceDetalle.AgregarResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class AgregarResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public Front_End.ServiceReferenceDetalle.ArrayOfString AgregarResult;
        
        public AgregarResponseBody() {
        }
        
        public AgregarResponseBody(Front_End.ServiceReferenceDetalle.ArrayOfString AgregarResult) {
            this.AgregarResult = AgregarResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface wsDetalleSoapChannel : Front_End.ServiceReferenceDetalle.wsDetalleSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class wsDetalleSoapClient : System.ServiceModel.ClientBase<Front_End.ServiceReferenceDetalle.wsDetalleSoap>, Front_End.ServiceReferenceDetalle.wsDetalleSoap {
        
        public wsDetalleSoapClient() {
        }
        
        public wsDetalleSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public wsDetalleSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public wsDetalleSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public wsDetalleSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Front_End.ServiceReferenceDetalle.AgregarResponse Front_End.ServiceReferenceDetalle.wsDetalleSoap.Agregar(Front_End.ServiceReferenceDetalle.AgregarRequest request) {
            return base.Channel.Agregar(request);
        }
        
        public Front_End.ServiceReferenceDetalle.ArrayOfString Agregar(string NroBoleta, string CodProducto, string cantidad) {
            Front_End.ServiceReferenceDetalle.AgregarRequest inValue = new Front_End.ServiceReferenceDetalle.AgregarRequest();
            inValue.Body = new Front_End.ServiceReferenceDetalle.AgregarRequestBody();
            inValue.Body.NroBoleta = NroBoleta;
            inValue.Body.CodProducto = CodProducto;
            inValue.Body.cantidad = cantidad;
            Front_End.ServiceReferenceDetalle.AgregarResponse retVal = ((Front_End.ServiceReferenceDetalle.wsDetalleSoap)(this)).Agregar(inValue);
            return retVal.Body.AgregarResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Front_End.ServiceReferenceDetalle.AgregarResponse> Front_End.ServiceReferenceDetalle.wsDetalleSoap.AgregarAsync(Front_End.ServiceReferenceDetalle.AgregarRequest request) {
            return base.Channel.AgregarAsync(request);
        }
        
        public System.Threading.Tasks.Task<Front_End.ServiceReferenceDetalle.AgregarResponse> AgregarAsync(string NroBoleta, string CodProducto, string cantidad) {
            Front_End.ServiceReferenceDetalle.AgregarRequest inValue = new Front_End.ServiceReferenceDetalle.AgregarRequest();
            inValue.Body = new Front_End.ServiceReferenceDetalle.AgregarRequestBody();
            inValue.Body.NroBoleta = NroBoleta;
            inValue.Body.CodProducto = CodProducto;
            inValue.Body.cantidad = cantidad;
            return ((Front_End.ServiceReferenceDetalle.wsDetalleSoap)(this)).AgregarAsync(inValue);
        }
    }
}
