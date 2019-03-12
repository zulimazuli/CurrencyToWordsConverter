﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CurrencyConverter.ConvertServiceReference {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ConvertServiceReference.IConvertService")]
    public interface IConvertService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IConvertService/ConvertNumberToCurrencyWords", ReplyAction="http://tempuri.org/IConvertService/ConvertNumberToCurrencyWordsResponse")]
        string ConvertNumberToCurrencyWords(string value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IConvertService/ConvertNumberToCurrencyWords", ReplyAction="http://tempuri.org/IConvertService/ConvertNumberToCurrencyWordsResponse")]
        System.Threading.Tasks.Task<string> ConvertNumberToCurrencyWordsAsync(string value);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IConvertServiceChannel : CurrencyConverter.ConvertServiceReference.IConvertService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ConvertServiceClient : System.ServiceModel.ClientBase<CurrencyConverter.ConvertServiceReference.IConvertService>, CurrencyConverter.ConvertServiceReference.IConvertService {
        
        public ConvertServiceClient() {
        }
        
        public ConvertServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ConvertServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ConvertServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ConvertServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string ConvertNumberToCurrencyWords(string value) {
            return base.Channel.ConvertNumberToCurrencyWords(value);
        }
        
        public System.Threading.Tasks.Task<string> ConvertNumberToCurrencyWordsAsync(string value) {
            return base.Channel.ConvertNumberToCurrencyWordsAsync(value);
        }
    }
}
