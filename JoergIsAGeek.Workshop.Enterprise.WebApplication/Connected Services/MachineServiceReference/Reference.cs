﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     //
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MachineServiceReference
{
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="MachineDto", Namespace="http://schemas.datacontract.org/2004/07/JoergIsAGeek.Workshop.Enterprise.DataTransfer" +
        "Objects")]
    public partial class MachineDto : object
    {
        
        private bool HasDevicesField;
        
        private int IdField;
        
        private string LocationField;
        
        private string NameField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool HasDevices
        {
            get
            {
                return this.HasDevicesField;
            }
            set
            {
                this.HasDevicesField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id
        {
            get
            {
                return this.IdField;
            }
            set
            {
                this.IdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Location
        {
            get
            {
                return this.LocationField;
            }
            set
            {
                this.LocationField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name
        {
            get
            {
                return this.NameField;
            }
            set
            {
                this.NameField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://JoergIsAGeek.com/srv", ConfigurationName="MachineServiceReference.MachineSrv")]
    public interface MachineSrv
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="GetMachines", ReplyAction="http://JoergIsAGeek.com/srv/MachineSrv/GetAllMachinesResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<MachineServiceReference.MachineDto>> GetAllMachinesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="Add", ReplyAction="http://JoergIsAGeek.com/srv/MachineSrv/AddMachineResponse")]
        System.Threading.Tasks.Task<bool> AddMachineAsync(MachineServiceReference.MachineDto machine);
        
        [System.ServiceModel.OperationContractAttribute(Action="Get", ReplyAction="http://JoergIsAGeek.com/srv/MachineSrv/GetMachineByIdResponse")]
        System.Threading.Tasks.Task<MachineServiceReference.MachineDto> GetMachineByIdAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="GetForData", ReplyAction="http://JoergIsAGeek.com/srv/MachineSrv/GetMachineForDataValueResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<MachineServiceReference.MachineDto>> GetMachineForDataValueAsync(double value);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    public interface MachineSrvChannel : MachineServiceReference.MachineSrv, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "0.5.0.0")]
    public partial class MachineSrvClient : System.ServiceModel.ClientBase<MachineServiceReference.MachineSrv>, MachineServiceReference.MachineSrv
    {
        
    /// <summary>
    /// Implement this partial method to configure the service endpoint.
    /// </summary>
    /// <param name="serviceEndpoint">The endpoint to configure</param>
    /// <param name="clientCredentials">The client credentials</param>
    static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public MachineSrvClient() : 
                base(MachineSrvClient.GetDefaultBinding(), MachineSrvClient.GetDefaultEndpointAddress())
        {
            this.Endpoint.Name = EndpointConfiguration.BasicHttpBinding_MachineSrv.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public MachineSrvClient(EndpointConfiguration endpointConfiguration) : 
                base(MachineSrvClient.GetBindingForEndpoint(endpointConfiguration), MachineSrvClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public MachineSrvClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(MachineSrvClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public MachineSrvClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(MachineSrvClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public MachineSrvClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<MachineServiceReference.MachineDto>> GetAllMachinesAsync()
        {
            return base.Channel.GetAllMachinesAsync();
        }
        
        public System.Threading.Tasks.Task<bool> AddMachineAsync(MachineServiceReference.MachineDto machine)
        {
            return base.Channel.AddMachineAsync(machine);
        }
        
        public System.Threading.Tasks.Task<MachineServiceReference.MachineDto> GetMachineByIdAsync(int id)
        {
            return base.Channel.GetMachineByIdAsync(id);
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<MachineServiceReference.MachineDto>> GetMachineForDataValueAsync(double value)
        {
            return base.Channel.GetMachineForDataValueAsync(value);
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        public virtual System.Threading.Tasks.Task CloseAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginClose(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndClose));
        }
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_MachineSrv))
            {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                return result;
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_MachineSrv))
            {
                return new System.ServiceModel.EndpointAddress("http://localhost:52499/MachineService.svc");
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding()
        {
            return MachineSrvClient.GetBindingForEndpoint(EndpointConfiguration.BasicHttpBinding_MachineSrv);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress()
        {
            return MachineSrvClient.GetEndpointAddress(EndpointConfiguration.BasicHttpBinding_MachineSrv);
        }
        
        public enum EndpointConfiguration
        {
            
            BasicHttpBinding_MachineSrv,
        }
    }
}
