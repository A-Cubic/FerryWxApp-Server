//------------------------------------------------------------------------------
// <自动生成>
//     此代码由工具生成。
//     //
//     对此文件的更改可能导致不正确的行为，并在以下条件下丢失:
//     代码重新生成。
// </自动生成>
//------------------------------------------------------------------------------

namespace pay
{
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="pay.PayTJSoap")]
    public interface PayTJSoap
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/getBill", ReplyAction="*")]
        System.Threading.Tasks.Task<pay.getBillResponse> getBillAsync(pay.getBillRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/setPayId", ReplyAction="*")]
        System.Threading.Tasks.Task<pay.setPayIdResponse> setPayIdAsync(pay.setPayIdRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/payTicketDone", ReplyAction="*")]
        System.Threading.Tasks.Task<pay.payTicketDoneResponse> payTicketDoneAsync(pay.payTicketDoneRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class getBillRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="getBill", Namespace="http://tempuri.org/", Order=0)]
        public pay.getBillRequestBody Body;
        
        public getBillRequest()
        {
        }
        
        public getBillRequest(pay.getBillRequestBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class getBillRequestBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string _posCode;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string _billId;
        
        public getBillRequestBody()
        {
        }
        
        public getBillRequestBody(string _posCode, string _billId)
        {
            this._posCode = _posCode;
            this._billId = _billId;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class getBillResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="getBillResponse", Namespace="http://tempuri.org/", Order=0)]
        public pay.getBillResponseBody Body;
        
        public getBillResponse()
        {
        }
        
        public getBillResponse(pay.getBillResponseBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class getBillResponseBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string getBillResult;
        
        public getBillResponseBody()
        {
        }
        
        public getBillResponseBody(string getBillResult)
        {
            this.getBillResult = getBillResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class setPayIdRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="setPayId", Namespace="http://tempuri.org/", Order=0)]
        public pay.setPayIdRequestBody Body;
        
        public setPayIdRequest()
        {
        }
        
        public setPayIdRequest(pay.setPayIdRequestBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class setPayIdRequestBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string _posCode;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string _billId;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string _payId;
        
        public setPayIdRequestBody()
        {
        }
        
        public setPayIdRequestBody(string _posCode, string _billId, string _payId)
        {
            this._posCode = _posCode;
            this._billId = _billId;
            this._payId = _payId;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class setPayIdResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="setPayIdResponse", Namespace="http://tempuri.org/", Order=0)]
        public pay.setPayIdResponseBody Body;
        
        public setPayIdResponse()
        {
        }
        
        public setPayIdResponse(pay.setPayIdResponseBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class setPayIdResponseBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string setPayIdResult;
        
        public setPayIdResponseBody()
        {
        }
        
        public setPayIdResponseBody(string setPayIdResult)
        {
            this.setPayIdResult = setPayIdResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class payTicketDoneRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="payTicketDone", Namespace="http://tempuri.org/", Order=0)]
        public pay.payTicketDoneRequestBody Body;
        
        public payTicketDoneRequest()
        {
        }
        
        public payTicketDoneRequest(pay.payTicketDoneRequestBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class payTicketDoneRequestBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string _posCode;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string _billId;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string _payId;
        
        public payTicketDoneRequestBody()
        {
        }
        
        public payTicketDoneRequestBody(string _posCode, string _billId, string _payId)
        {
            this._posCode = _posCode;
            this._billId = _billId;
            this._payId = _payId;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class payTicketDoneResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="payTicketDoneResponse", Namespace="http://tempuri.org/", Order=0)]
        public pay.payTicketDoneResponseBody Body;
        
        public payTicketDoneResponse()
        {
        }
        
        public payTicketDoneResponse(pay.payTicketDoneResponseBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class payTicketDoneResponseBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string payTicketDoneResult;
        
        public payTicketDoneResponseBody()
        {
        }
        
        public payTicketDoneResponseBody(string payTicketDoneResult)
        {
            this.payTicketDoneResult = payTicketDoneResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    public interface PayTJSoapChannel : pay.PayTJSoap, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    public partial class PayTJSoapClient : System.ServiceModel.ClientBase<pay.PayTJSoap>, pay.PayTJSoap
    {
        
    /// <summary>
    /// 实现此分部方法，配置服务终结点。
    /// </summary>
    /// <param name="serviceEndpoint">要配置的终结点</param>
    /// <param name="clientCredentials">客户端凭据</param>
    static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public PayTJSoapClient(EndpointConfiguration endpointConfiguration) : 
                base(PayTJSoapClient.GetBindingForEndpoint(endpointConfiguration), PayTJSoapClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public PayTJSoapClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(PayTJSoapClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public PayTJSoapClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(PayTJSoapClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public PayTJSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<pay.getBillResponse> pay.PayTJSoap.getBillAsync(pay.getBillRequest request)
        {
            return base.Channel.getBillAsync(request);
        }
        
        public System.Threading.Tasks.Task<pay.getBillResponse> getBillAsync(string _posCode, string _billId)
        {
            pay.getBillRequest inValue = new pay.getBillRequest();
            inValue.Body = new pay.getBillRequestBody();
            inValue.Body._posCode = _posCode;
            inValue.Body._billId = _billId;
            return ((pay.PayTJSoap)(this)).getBillAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<pay.setPayIdResponse> pay.PayTJSoap.setPayIdAsync(pay.setPayIdRequest request)
        {
            return base.Channel.setPayIdAsync(request);
        }
        
        public System.Threading.Tasks.Task<pay.setPayIdResponse> setPayIdAsync(string _posCode, string _billId, string _payId)
        {
            pay.setPayIdRequest inValue = new pay.setPayIdRequest();
            inValue.Body = new pay.setPayIdRequestBody();
            inValue.Body._posCode = _posCode;
            inValue.Body._billId = _billId;
            inValue.Body._payId = _payId;
            return ((pay.PayTJSoap)(this)).setPayIdAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<pay.payTicketDoneResponse> pay.PayTJSoap.payTicketDoneAsync(pay.payTicketDoneRequest request)
        {
            return base.Channel.payTicketDoneAsync(request);
        }
        
        public System.Threading.Tasks.Task<pay.payTicketDoneResponse> payTicketDoneAsync(string _posCode, string _billId, string _payId)
        {
            pay.payTicketDoneRequest inValue = new pay.payTicketDoneRequest();
            inValue.Body = new pay.payTicketDoneRequestBody();
            inValue.Body._posCode = _posCode;
            inValue.Body._billId = _billId;
            inValue.Body._payId = _payId;
            return ((pay.PayTJSoap)(this)).payTicketDoneAsync(inValue);
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
            if ((endpointConfiguration == EndpointConfiguration.PayTJSoap))
            {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                return result;
            }
            if ((endpointConfiguration == EndpointConfiguration.PayTJSoap12))
            {
                System.ServiceModel.Channels.CustomBinding result = new System.ServiceModel.Channels.CustomBinding();
                System.ServiceModel.Channels.TextMessageEncodingBindingElement textBindingElement = new System.ServiceModel.Channels.TextMessageEncodingBindingElement();
                textBindingElement.MessageVersion = System.ServiceModel.Channels.MessageVersion.CreateVersion(System.ServiceModel.EnvelopeVersion.Soap12, System.ServiceModel.Channels.AddressingVersion.None);
                result.Elements.Add(textBindingElement);
                System.ServiceModel.Channels.HttpTransportBindingElement httpBindingElement = new System.ServiceModel.Channels.HttpTransportBindingElement();
                httpBindingElement.AllowCookies = true;
                httpBindingElement.MaxBufferSize = int.MaxValue;
                httpBindingElement.MaxReceivedMessageSize = int.MaxValue;
                result.Elements.Add(httpBindingElement);
                return result;
            }
            throw new System.InvalidOperationException(string.Format("找不到名称为“{0}”的终结点。", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.PayTJSoap))
            {
                return new System.ServiceModel.EndpointAddress("http://112.126.92.32:9181/PayTJ.asmx");
            }
            if ((endpointConfiguration == EndpointConfiguration.PayTJSoap12))
            {
                return new System.ServiceModel.EndpointAddress("http://112.126.92.32:9181/PayTJ.asmx");
            }
            throw new System.InvalidOperationException(string.Format("找不到名称为“{0}”的终结点。", endpointConfiguration));
        }
        
        public enum EndpointConfiguration
        {
            
            PayTJSoap,
            
            PayTJSoap12,
        }
    }
}
