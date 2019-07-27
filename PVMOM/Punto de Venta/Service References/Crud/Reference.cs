﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Punto_de_Venta.Crud {
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://Ws/")]
    public partial class Exception : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string messageField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string message {
            get {
                return this.messageField;
            }
            set {
                this.messageField = value;
                this.RaisePropertyChanged("message");
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
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://Ws/", ConfigurationName="Crud.WsPapeleria")]
    public interface WsPapeleria {
        
        // CODEGEN: Parameter 'codigo' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://Ws/WsPapeleria/AltaRequest", ReplyAction="http://Ws/WsPapeleria/AltaResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Punto_de_Venta.Crud.Exception), Action="http://Ws/WsPapeleria/Alta/Fault/Exception", Name="Exception")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        Punto_de_Venta.Crud.AltaResponse Alta(Punto_de_Venta.Crud.AltaRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://Ws/WsPapeleria/AltaRequest", ReplyAction="http://Ws/WsPapeleria/AltaResponse")]
        System.Threading.Tasks.Task<Punto_de_Venta.Crud.AltaResponse> AltaAsync(Punto_de_Venta.Crud.AltaRequest request);
        
        // CODEGEN: Parameter 'idProducto' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://Ws/WsPapeleria/BajaRequest", ReplyAction="http://Ws/WsPapeleria/BajaResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Punto_de_Venta.Crud.Exception), Action="http://Ws/WsPapeleria/Baja/Fault/Exception", Name="Exception")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        Punto_de_Venta.Crud.BajaResponse Baja(Punto_de_Venta.Crud.BajaRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://Ws/WsPapeleria/BajaRequest", ReplyAction="http://Ws/WsPapeleria/BajaResponse")]
        System.Threading.Tasks.Task<Punto_de_Venta.Crud.BajaResponse> BajaAsync(Punto_de_Venta.Crud.BajaRequest request);
        
        // CODEGEN: Parameter 'producto' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://Ws/WsPapeleria/ModificacionRequest", ReplyAction="http://Ws/WsPapeleria/ModificacionResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Punto_de_Venta.Crud.Exception), Action="http://Ws/WsPapeleria/Modificacion/Fault/Exception", Name="Exception")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        Punto_de_Venta.Crud.ModificacionResponse Modificacion(Punto_de_Venta.Crud.ModificacionRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://Ws/WsPapeleria/ModificacionRequest", ReplyAction="http://Ws/WsPapeleria/ModificacionResponse")]
        System.Threading.Tasks.Task<Punto_de_Venta.Crud.ModificacionResponse> ModificacionAsync(Punto_de_Venta.Crud.ModificacionRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="Alta", WrapperNamespace="http://Ws/", IsWrapped=true)]
    public partial class AltaRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://Ws/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string codigo;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://Ws/", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string producto;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://Ws/", Order=2)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int cantidad;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://Ws/", Order=3)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public double precio;
        
        public AltaRequest() {
        }
        
        public AltaRequest(string codigo, string producto, int cantidad, double precio) {
            this.codigo = codigo;
            this.producto = producto;
            this.cantidad = cantidad;
            this.precio = precio;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="AltaResponse", WrapperNamespace="http://Ws/", IsWrapped=true)]
    public partial class AltaResponse {
        
        public AltaResponse() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="Baja", WrapperNamespace="http://Ws/", IsWrapped=true)]
    public partial class BajaRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://Ws/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int idProducto;
        
        public BajaRequest() {
        }
        
        public BajaRequest(int idProducto) {
            this.idProducto = idProducto;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="BajaResponse", WrapperNamespace="http://Ws/", IsWrapped=true)]
    public partial class BajaResponse {
        
        public BajaResponse() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="Modificacion", WrapperNamespace="http://Ws/", IsWrapped=true)]
    public partial class ModificacionRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://Ws/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string producto;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://Ws/", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int cantidad;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://Ws/", Order=2)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public double precio;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://Ws/", Order=3)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int idProducto;
        
        public ModificacionRequest() {
        }
        
        public ModificacionRequest(string producto, int cantidad, double precio, int idProducto) {
            this.producto = producto;
            this.cantidad = cantidad;
            this.precio = precio;
            this.idProducto = idProducto;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="ModificacionResponse", WrapperNamespace="http://Ws/", IsWrapped=true)]
    public partial class ModificacionResponse {
        
        public ModificacionResponse() {
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface WsPapeleriaChannel : Punto_de_Venta.Crud.WsPapeleria, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WsPapeleriaClient : System.ServiceModel.ClientBase<Punto_de_Venta.Crud.WsPapeleria>, Punto_de_Venta.Crud.WsPapeleria {
        
        public WsPapeleriaClient() {
        }
        
        public WsPapeleriaClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WsPapeleriaClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WsPapeleriaClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WsPapeleriaClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Punto_de_Venta.Crud.AltaResponse Punto_de_Venta.Crud.WsPapeleria.Alta(Punto_de_Venta.Crud.AltaRequest request) {
            return base.Channel.Alta(request);
        }
        
        public void Alta(string codigo, string producto, int cantidad, double precio) {
            Punto_de_Venta.Crud.AltaRequest inValue = new Punto_de_Venta.Crud.AltaRequest();
            inValue.codigo = codigo;
            inValue.producto = producto;
            inValue.cantidad = cantidad;
            inValue.precio = precio;
            Punto_de_Venta.Crud.AltaResponse retVal = ((Punto_de_Venta.Crud.WsPapeleria)(this)).Alta(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Punto_de_Venta.Crud.AltaResponse> Punto_de_Venta.Crud.WsPapeleria.AltaAsync(Punto_de_Venta.Crud.AltaRequest request) {
            return base.Channel.AltaAsync(request);
        }
        
        public System.Threading.Tasks.Task<Punto_de_Venta.Crud.AltaResponse> AltaAsync(string codigo, string producto, int cantidad, double precio) {
            Punto_de_Venta.Crud.AltaRequest inValue = new Punto_de_Venta.Crud.AltaRequest();
            inValue.codigo = codigo;
            inValue.producto = producto;
            inValue.cantidad = cantidad;
            inValue.precio = precio;
            return ((Punto_de_Venta.Crud.WsPapeleria)(this)).AltaAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Punto_de_Venta.Crud.BajaResponse Punto_de_Venta.Crud.WsPapeleria.Baja(Punto_de_Venta.Crud.BajaRequest request) {
            return base.Channel.Baja(request);
        }
        
        public void Baja(int idProducto) {
            Punto_de_Venta.Crud.BajaRequest inValue = new Punto_de_Venta.Crud.BajaRequest();
            inValue.idProducto = idProducto;
            Punto_de_Venta.Crud.BajaResponse retVal = ((Punto_de_Venta.Crud.WsPapeleria)(this)).Baja(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Punto_de_Venta.Crud.BajaResponse> Punto_de_Venta.Crud.WsPapeleria.BajaAsync(Punto_de_Venta.Crud.BajaRequest request) {
            return base.Channel.BajaAsync(request);
        }
        
        public System.Threading.Tasks.Task<Punto_de_Venta.Crud.BajaResponse> BajaAsync(int idProducto) {
            Punto_de_Venta.Crud.BajaRequest inValue = new Punto_de_Venta.Crud.BajaRequest();
            inValue.idProducto = idProducto;
            return ((Punto_de_Venta.Crud.WsPapeleria)(this)).BajaAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Punto_de_Venta.Crud.ModificacionResponse Punto_de_Venta.Crud.WsPapeleria.Modificacion(Punto_de_Venta.Crud.ModificacionRequest request) {
            return base.Channel.Modificacion(request);
        }
        
        public void Modificacion(string producto, int cantidad, double precio, int idProducto) {
            Punto_de_Venta.Crud.ModificacionRequest inValue = new Punto_de_Venta.Crud.ModificacionRequest();
            inValue.producto = producto;
            inValue.cantidad = cantidad;
            inValue.precio = precio;
            inValue.idProducto = idProducto;
            Punto_de_Venta.Crud.ModificacionResponse retVal = ((Punto_de_Venta.Crud.WsPapeleria)(this)).Modificacion(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Punto_de_Venta.Crud.ModificacionResponse> Punto_de_Venta.Crud.WsPapeleria.ModificacionAsync(Punto_de_Venta.Crud.ModificacionRequest request) {
            return base.Channel.ModificacionAsync(request);
        }
        
        public System.Threading.Tasks.Task<Punto_de_Venta.Crud.ModificacionResponse> ModificacionAsync(string producto, int cantidad, double precio, int idProducto) {
            Punto_de_Venta.Crud.ModificacionRequest inValue = new Punto_de_Venta.Crud.ModificacionRequest();
            inValue.producto = producto;
            inValue.cantidad = cantidad;
            inValue.precio = precio;
            inValue.idProducto = idProducto;
            return ((Punto_de_Venta.Crud.WsPapeleria)(this)).ModificacionAsync(inValue);
        }
    }
}