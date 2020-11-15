﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Front_End.ServiceReferenceCliente {
    using System.Data;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReferenceCliente.wsClienteSoap")]
    public interface wsClienteSoap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Login", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string[] Login(string CodCliente, string Contrasena);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Login", ReplyAction="*")]
        System.Threading.Tasks.Task<string[]> LoginAsync(string CodCliente, string Contrasena);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/CambiarContrasena", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string[] CambiarContrasena(string Usuario, string NuevaContrasena);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/CambiarContrasena", ReplyAction="*")]
        System.Threading.Tasks.Task<string[]> CambiarContrasenaAsync(string Usuario, string NuevaContrasena);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Listar", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet Listar();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Listar", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataSet> ListarAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ListarClientes", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet ListarClientes();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ListarClientes", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataSet> ListarClientesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Agregar", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        bool Agregar(string Apellidos, string Nombres, string Direccion, string Usuario, string Contrasena);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Agregar", ReplyAction="*")]
        System.Threading.Tasks.Task<bool> AgregarAsync(string Apellidos, string Nombres, string Direccion, string Usuario, string Contrasena);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Modificar", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        bool Modificar(string CodCliente, string Apellidos, string Nombres, string direccion, string Usuario);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Modificar", ReplyAction="*")]
        System.Threading.Tasks.Task<bool> ModificarAsync(string CodCliente, string Apellidos, string Nombres, string direccion, string Usuario);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Eliminar", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        bool Eliminar(string CodCliente);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Eliminar", ReplyAction="*")]
        System.Threading.Tasks.Task<bool> EliminarAsync(string CodCliente);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Buscar", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet Buscar(string texto, string criterio);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Buscar", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataSet> BuscarAsync(string texto, string criterio);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface wsClienteSoapChannel : Front_End.ServiceReferenceCliente.wsClienteSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class wsClienteSoapClient : System.ServiceModel.ClientBase<Front_End.ServiceReferenceCliente.wsClienteSoap>, Front_End.ServiceReferenceCliente.wsClienteSoap {
        
        public wsClienteSoapClient() {
        }
        
        public wsClienteSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public wsClienteSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public wsClienteSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public wsClienteSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string[] Login(string CodCliente, string Contrasena) {
            return base.Channel.Login(CodCliente, Contrasena);
        }
        
        public System.Threading.Tasks.Task<string[]> LoginAsync(string CodCliente, string Contrasena) {
            return base.Channel.LoginAsync(CodCliente, Contrasena);
        }
        
        public string[] CambiarContrasena(string Usuario, string NuevaContrasena) {
            return base.Channel.CambiarContrasena(Usuario, NuevaContrasena);
        }
        
        public System.Threading.Tasks.Task<string[]> CambiarContrasenaAsync(string Usuario, string NuevaContrasena) {
            return base.Channel.CambiarContrasenaAsync(Usuario, NuevaContrasena);
        }
        
        public System.Data.DataSet Listar() {
            return base.Channel.Listar();
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> ListarAsync() {
            return base.Channel.ListarAsync();
        }
        
        public System.Data.DataSet ListarClientes() {
            return base.Channel.ListarClientes();
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> ListarClientesAsync() {
            return base.Channel.ListarClientesAsync();
        }
        
        public bool Agregar(string Apellidos, string Nombres, string Direccion, string Usuario, string Contrasena) {
            return base.Channel.Agregar(Apellidos, Nombres, Direccion, Usuario, Contrasena);
        }
        
        public System.Threading.Tasks.Task<bool> AgregarAsync(string Apellidos, string Nombres, string Direccion, string Usuario, string Contrasena) {
            return base.Channel.AgregarAsync(Apellidos, Nombres, Direccion, Usuario, Contrasena);
        }
        
        public bool Modificar(string CodCliente, string Apellidos, string Nombres, string direccion, string Usuario) {
            return base.Channel.Modificar(CodCliente, Apellidos, Nombres, direccion, Usuario);
        }
        
        public System.Threading.Tasks.Task<bool> ModificarAsync(string CodCliente, string Apellidos, string Nombres, string direccion, string Usuario) {
            return base.Channel.ModificarAsync(CodCliente, Apellidos, Nombres, direccion, Usuario);
        }
        
        public bool Eliminar(string CodCliente) {
            return base.Channel.Eliminar(CodCliente);
        }
        
        public System.Threading.Tasks.Task<bool> EliminarAsync(string CodCliente) {
            return base.Channel.EliminarAsync(CodCliente);
        }
        
        public System.Data.DataSet Buscar(string texto, string criterio) {
            return base.Channel.Buscar(texto, criterio);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> BuscarAsync(string texto, string criterio) {
            return base.Channel.BuscarAsync(texto, criterio);
        }
    }
}
