﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WorkoutMVC.Tests.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetData", ReplyAction="http://tempuri.org/IService1/GetDataResponse")]
        string GetData(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetData", ReplyAction="http://tempuri.org/IService1/GetDataResponse")]
        System.Threading.Tasks.Task<string> GetDataAsync(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetDataUsingDataContract", ReplyAction="http://tempuri.org/IService1/GetDataUsingDataContractResponse")]
        WorkoutMVC.ServiceReference1.CompositeType GetDataUsingDataContract(WorkoutMVC.ServiceReference1.CompositeType composite);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetDataUsingDataContract", ReplyAction="http://tempuri.org/IService1/GetDataUsingDataContractResponse")]
        System.Threading.Tasks.Task<WorkoutMVC.ServiceReference1.CompositeType> GetDataUsingDataContractAsync(WorkoutMVC.ServiceReference1.CompositeType composite);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/getUser", ReplyAction="http://tempuri.org/IService1/getUserResponse")]
        LibMyWorkout.Domain.User getUser(string userName, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/getUser", ReplyAction="http://tempuri.org/IService1/getUserResponse")]
        System.Threading.Tasks.Task<LibMyWorkout.Domain.User> getUserAsync(string userName, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/createUser", ReplyAction="http://tempuri.org/IService1/createUserResponse")]
        LibMyWorkout.Domain.User createUser();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/createUser", ReplyAction="http://tempuri.org/IService1/createUserResponse")]
        System.Threading.Tasks.Task<LibMyWorkout.Domain.User> createUserAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/saveNewUser", ReplyAction="http://tempuri.org/IService1/saveNewUserResponse")]
        LibMyWorkout.Domain.User saveNewUser(LibMyWorkout.Domain.User u);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/saveNewUser", ReplyAction="http://tempuri.org/IService1/saveNewUserResponse")]
        System.Threading.Tasks.Task<LibMyWorkout.Domain.User> saveNewUserAsync(LibMyWorkout.Domain.User u);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Hello", ReplyAction="http://tempuri.org/IService1/HelloResponse")]
        string Hello(string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Hello", ReplyAction="http://tempuri.org/IService1/HelloResponse")]
        System.Threading.Tasks.Task<string> HelloAsync(string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/isUserNameTaken", ReplyAction="http://tempuri.org/IService1/isUserNameTakenResponse")]
        bool isUserNameTaken(string userName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/isUserNameTaken", ReplyAction="http://tempuri.org/IService1/isUserNameTakenResponse")]
        System.Threading.Tasks.Task<bool> isUserNameTakenAsync(string userName);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : WorkoutMVC.Tests.ServiceReference1.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<WorkoutMVC.Tests.ServiceReference1.IService1>, WorkoutMVC.Tests.ServiceReference1.IService1 {
        
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
        
        public string GetData(int value) {
            return base.Channel.GetData(value);
        }
        
        public System.Threading.Tasks.Task<string> GetDataAsync(int value) {
            return base.Channel.GetDataAsync(value);
        }
        
        public WorkoutMVC.ServiceReference1.CompositeType GetDataUsingDataContract(WorkoutMVC.ServiceReference1.CompositeType composite) {
            return base.Channel.GetDataUsingDataContract(composite);
        }
        
        public System.Threading.Tasks.Task<WorkoutMVC.ServiceReference1.CompositeType> GetDataUsingDataContractAsync(WorkoutMVC.ServiceReference1.CompositeType composite) {
            return base.Channel.GetDataUsingDataContractAsync(composite);
        }
        
        public LibMyWorkout.Domain.User getUser(string userName, string password) {
            return base.Channel.getUser(userName, password);
        }
        
        public System.Threading.Tasks.Task<LibMyWorkout.Domain.User> getUserAsync(string userName, string password) {
            return base.Channel.getUserAsync(userName, password);
        }
        
        public LibMyWorkout.Domain.User createUser() {
            return base.Channel.createUser();
        }
        
        public System.Threading.Tasks.Task<LibMyWorkout.Domain.User> createUserAsync() {
            return base.Channel.createUserAsync();
        }
        
        public LibMyWorkout.Domain.User saveNewUser(LibMyWorkout.Domain.User u) {
            return base.Channel.saveNewUser(u);
        }
        
        public System.Threading.Tasks.Task<LibMyWorkout.Domain.User> saveNewUserAsync(LibMyWorkout.Domain.User u) {
            return base.Channel.saveNewUserAsync(u);
        }
        
        public string Hello(string name) {
            return base.Channel.Hello(name);
        }
        
        public System.Threading.Tasks.Task<string> HelloAsync(string name) {
            return base.Channel.HelloAsync(name);
        }
        
        public bool isUserNameTaken(string userName) {
            return base.Channel.isUserNameTaken(userName);
        }
        
        public System.Threading.Tasks.Task<bool> isUserNameTakenAsync(string userName) {
            return base.Channel.isUserNameTakenAsync(userName);
        }
    }
}
