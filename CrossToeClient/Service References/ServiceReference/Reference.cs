﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.34014
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CrossToeClient.ServiceReference {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference.IManagerGame")]
    public interface IManagerGame {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IManagerGame/SetPosition", ReplyAction="http://tempuri.org/IManagerGame/SetPositionResponse")]
        void SetPosition(int userID, int posMove);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IManagerGame/SetPosition", ReplyAction="http://tempuri.org/IManagerGame/SetPositionResponse")]
        System.Threading.Tasks.Task SetPositionAsync(int userID, int posMove);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IManagerGameChannel : CrossToeClient.ServiceReference.IManagerGame, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ManagerGameClient : System.ServiceModel.ClientBase<CrossToeClient.ServiceReference.IManagerGame>, CrossToeClient.ServiceReference.IManagerGame {
        
        public ManagerGameClient() {
        }
        
        public ManagerGameClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ManagerGameClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ManagerGameClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ManagerGameClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void SetPosition(int userID, int posMove) {
            base.Channel.SetPosition(userID, posMove);
        }
        
        public System.Threading.Tasks.Task SetPositionAsync(int userID, int posMove) {
            return base.Channel.SetPositionAsync(userID, posMove);
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference.IDuplexService", CallbackContract=typeof(CrossToeClient.ServiceReference.IDuplexServiceCallback))]
    public interface IDuplexService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDuplexService/AddNewUser", ReplyAction="http://tempuri.org/IDuplexService/AddNewUserResponse")]
        int AddNewUser(string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDuplexService/AddNewUser", ReplyAction="http://tempuri.org/IDuplexService/AddNewUserResponse")]
        System.Threading.Tasks.Task<int> AddNewUserAsync(string name);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IDuplexServiceCallback {
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IDuplexService/GetUpdate")]
        void GetUpdate(int posMove, string message, int lineWin);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IDuplexServiceChannel : CrossToeClient.ServiceReference.IDuplexService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class DuplexServiceClient : System.ServiceModel.DuplexClientBase<CrossToeClient.ServiceReference.IDuplexService>, CrossToeClient.ServiceReference.IDuplexService {
        
        public DuplexServiceClient(System.ServiceModel.InstanceContext callbackInstance) : 
                base(callbackInstance) {
        }
        
        public DuplexServiceClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName) : 
                base(callbackInstance, endpointConfigurationName) {
        }
        
        public DuplexServiceClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, string remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress) {
        }
        
        public DuplexServiceClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress) {
        }
        
        public DuplexServiceClient(System.ServiceModel.InstanceContext callbackInstance, System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, binding, remoteAddress) {
        }
        
        public int AddNewUser(string name) {
            return base.Channel.AddNewUser(name);
        }
        
        public System.Threading.Tasks.Task<int> AddNewUserAsync(string name) {
            return base.Channel.AddNewUserAsync(name);
        }
    }
}
