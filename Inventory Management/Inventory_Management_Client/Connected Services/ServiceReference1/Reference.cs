﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Inventory_Management_Client.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Product", Namespace="http://schemas.datacontract.org/2004/07/Inventory_Management")]
    [System.SerializableAttribute()]
    public partial class Product : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string BrandField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CheckByField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime DateOfArrivalField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double PriceField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int QuantityField;
        
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
        public string Brand {
            get {
                return this.BrandField;
            }
            set {
                if ((object.ReferenceEquals(this.BrandField, value) != true)) {
                    this.BrandField = value;
                    this.RaisePropertyChanged("Brand");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string CheckBy {
            get {
                return this.CheckByField;
            }
            set {
                if ((object.ReferenceEquals(this.CheckByField, value) != true)) {
                    this.CheckByField = value;
                    this.RaisePropertyChanged("CheckBy");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime DateOfArrival {
            get {
                return this.DateOfArrivalField;
            }
            set {
                if ((this.DateOfArrivalField.Equals(value) != true)) {
                    this.DateOfArrivalField = value;
                    this.RaisePropertyChanged("DateOfArrival");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ID {
            get {
                return this.IDField;
            }
            set {
                if ((this.IDField.Equals(value) != true)) {
                    this.IDField = value;
                    this.RaisePropertyChanged("ID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double Price {
            get {
                return this.PriceField;
            }
            set {
                if ((this.PriceField.Equals(value) != true)) {
                    this.PriceField = value;
                    this.RaisePropertyChanged("Price");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Quantity {
            get {
                return this.QuantityField;
            }
            set {
                if ((this.QuantityField.Equals(value) != true)) {
                    this.QuantityField = value;
                    this.RaisePropertyChanged("Quantity");
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="NotFoundFolt", Namespace="http://schemas.datacontract.org/2004/07/Inventory_Management")]
    [System.SerializableAttribute()]
    public partial class NotFoundFolt : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ExceptionField;
        
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
        public string Exception {
            get {
                return this.ExceptionField;
            }
            set {
                if ((object.ReferenceEquals(this.ExceptionField, value) != true)) {
                    this.ExceptionField = value;
                    this.RaisePropertyChanged("Exception");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/AddProduct", ReplyAction="http://tempuri.org/IService1/AddProductResponse")]
        bool AddProduct(Inventory_Management_Client.ServiceReference1.Product p);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/AddProduct", ReplyAction="http://tempuri.org/IService1/AddProductResponse")]
        System.Threading.Tasks.Task<bool> AddProductAsync(Inventory_Management_Client.ServiceReference1.Product p);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/UpdateProduct", ReplyAction="http://tempuri.org/IService1/UpdateProductResponse")]
        Inventory_Management_Client.ServiceReference1.Product UpdateProduct(Inventory_Management_Client.ServiceReference1.Product p);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/UpdateProduct", ReplyAction="http://tempuri.org/IService1/UpdateProductResponse")]
        System.Threading.Tasks.Task<Inventory_Management_Client.ServiceReference1.Product> UpdateProductAsync(Inventory_Management_Client.ServiceReference1.Product p);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DeleteProduct", ReplyAction="http://tempuri.org/IService1/DeleteProductResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(Inventory_Management_Client.ServiceReference1.NotFoundFolt), Action="http://tempuri.org/IService1/DeleteProductNotFoundFoltFault", Name="NotFoundFolt", Namespace="http://schemas.datacontract.org/2004/07/Inventory_Management")]
        bool DeleteProduct(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DeleteProduct", ReplyAction="http://tempuri.org/IService1/DeleteProductResponse")]
        System.Threading.Tasks.Task<bool> DeleteProductAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetProduct", ReplyAction="http://tempuri.org/IService1/GetProductResponse")]
        Inventory_Management_Client.ServiceReference1.Product GetProduct(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetProduct", ReplyAction="http://tempuri.org/IService1/GetProductResponse")]
        System.Threading.Tasks.Task<Inventory_Management_Client.ServiceReference1.Product> GetProductAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetAllProduct", ReplyAction="http://tempuri.org/IService1/GetAllProductResponse")]
        System.Data.DataSet GetAllProduct();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetAllProduct", ReplyAction="http://tempuri.org/IService1/GetAllProductResponse")]
        System.Threading.Tasks.Task<System.Data.DataSet> GetAllProductAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : Inventory_Management_Client.ServiceReference1.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<Inventory_Management_Client.ServiceReference1.IService1>, Inventory_Management_Client.ServiceReference1.IService1 {
        
        public Service1Client() {
        }
        
        public Service1Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Service1Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public bool AddProduct(Inventory_Management_Client.ServiceReference1.Product p) {
            return base.Channel.AddProduct(p);
        }
        
        public System.Threading.Tasks.Task<bool> AddProductAsync(Inventory_Management_Client.ServiceReference1.Product p) {
            return base.Channel.AddProductAsync(p);
        }
        
        public Inventory_Management_Client.ServiceReference1.Product UpdateProduct(Inventory_Management_Client.ServiceReference1.Product p) {
            return base.Channel.UpdateProduct(p);
        }
        
        public System.Threading.Tasks.Task<Inventory_Management_Client.ServiceReference1.Product> UpdateProductAsync(Inventory_Management_Client.ServiceReference1.Product p) {
            return base.Channel.UpdateProductAsync(p);
        }
        
        public bool DeleteProduct(int id) {
            return base.Channel.DeleteProduct(id);
        }
        
        public System.Threading.Tasks.Task<bool> DeleteProductAsync(int id) {
            return base.Channel.DeleteProductAsync(id);
        }
        
        public Inventory_Management_Client.ServiceReference1.Product GetProduct(int id) {
            return base.Channel.GetProduct(id);
        }
        
        public System.Threading.Tasks.Task<Inventory_Management_Client.ServiceReference1.Product> GetProductAsync(int id) {
            return base.Channel.GetProductAsync(id);
        }
        
        public System.Data.DataSet GetAllProduct() {
            return base.Channel.GetAllProduct();
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> GetAllProductAsync() {
            return base.Channel.GetAllProductAsync();
        }
    }
}