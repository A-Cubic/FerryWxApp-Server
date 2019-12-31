//------------------------------------------------------------------------------
// <自动生成>
//     此代码由工具生成。
//     //
//     对此文件的更改可能导致不正确的行为，并在以下条件下丢失:
//     代码重新生成。
// </自动生成>
//------------------------------------------------------------------------------

namespace pts
{
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="pts.PtsServiceTJSoap")]
    public interface PtsServiceTJSoap
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/getPort", ReplyAction="*")]
        System.Threading.Tasks.Task<pts.getPortResponse> getPortAsync(pts.getPortRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/getIfSuspend", ReplyAction="*")]
        System.Threading.Tasks.Task<pts.getIfSuspendResponse> getIfSuspendAsync(pts.getIfSuspendRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/getShipListByPort", ReplyAction="*")]
        System.Threading.Tasks.Task<pts.getShipListByPortResponse> getShipListByPortAsync(pts.getShipListByPortRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/getSearoute", ReplyAction="*")]
        System.Threading.Tasks.Task<pts.getSearouteResponse> getSearouteAsync(pts.getSearouteRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/getShipList", ReplyAction="*")]
        System.Threading.Tasks.Task<pts.getShipListResponse> getShipListAsync(pts.getShipListRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/getGradePriceListAllAgio", ReplyAction="*")]
        System.Threading.Tasks.Task<pts.getGradePriceListAllAgioResponse> getGradePriceListAllAgioAsync(pts.getGradePriceListAllAgioRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/getBookBillIdUser", ReplyAction="*")]
        System.Threading.Tasks.Task<pts.getBookBillIdUserResponse> getBookBillIdUserAsync(pts.getBookBillIdUserRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/getBookBillIdUserTag1", ReplyAction="*")]
        System.Threading.Tasks.Task<pts.getBookBillIdUserTag1Response> getBookBillIdUserTag1Async(pts.getBookBillIdUserTag1Request request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/bookTicketAutoAgio", ReplyAction="*")]
        System.Threading.Tasks.Task<pts.bookTicketAutoAgioResponse> bookTicketAutoAgioAsync(pts.bookTicketAutoAgioRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/bookTicketAuto", ReplyAction="*")]
        System.Threading.Tasks.Task<pts.bookTicketAutoResponse> bookTicketAutoAsync(pts.bookTicketAutoRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/bookTicketAutoByTicketType", ReplyAction="*")]
        System.Threading.Tasks.Task<pts.bookTicketAutoByTicketTypeResponse> bookTicketAutoByTicketTypeAsync(pts.bookTicketAutoByTicketTypeRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/getBookBillState", ReplyAction="*")]
        System.Threading.Tasks.Task<pts.getBookBillStateResponse> getBookBillStateAsync(pts.getBookBillStateRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/getBookBillStateNew", ReplyAction="*")]
        System.Threading.Tasks.Task<pts.getBookBillStateNewResponse> getBookBillStateNewAsync(pts.getBookBillStateNewRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/getBookBillStateByGroup", ReplyAction="*")]
        System.Threading.Tasks.Task<pts.getBookBillStateByGroupResponse> getBookBillStateByGroupAsync(pts.getBookBillStateByGroupRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/addBookBillInfo", ReplyAction="*")]
        System.Threading.Tasks.Task<pts.addBookBillInfoResponse> addBookBillInfoAsync(pts.addBookBillInfoRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/addTicketInfo", ReplyAction="*")]
        System.Threading.Tasks.Task<pts.addTicketInfoResponse> addTicketInfoAsync(pts.addTicketInfoRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/cancelBookBill", ReplyAction="*")]
        System.Threading.Tasks.Task<pts.cancelBookBillResponse> cancelBookBillAsync(pts.cancelBookBillRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/getBillListUser", ReplyAction="*")]
        System.Threading.Tasks.Task<pts.getBillListUserResponse> getBillListUserAsync(pts.getBillListUserRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/getBillListTag1", ReplyAction="*")]
        System.Threading.Tasks.Task<pts.getBillListTag1Response> getBillListTag1Async(pts.getBillListTag1Request request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/getBillListUserTotal", ReplyAction="*")]
        System.Threading.Tasks.Task<pts.getBillListUserTotalResponse> getBillListUserTotalAsync(pts.getBillListUserTotalRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/getCarGradePriceListAllAgio", ReplyAction="*")]
        System.Threading.Tasks.Task<pts.getCarGradePriceListAllAgioResponse> getCarGradePriceListAllAgioAsync(pts.getCarGradePriceListAllAgioRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/bookCarTicketAgio", ReplyAction="*")]
        System.Threading.Tasks.Task<pts.bookCarTicketAgioResponse> bookCarTicketAgioAsync(pts.bookCarTicketAgioRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/returnBookTicket", ReplyAction="*")]
        System.Threading.Tasks.Task<pts.returnBookTicketResponse> returnBookTicketAsync(pts.returnBookTicketRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/returnBill", ReplyAction="*")]
        System.Threading.Tasks.Task<pts.returnBillResponse> returnBillAsync(pts.returnBillRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/checkReturnTicket", ReplyAction="*")]
        System.Threading.Tasks.Task<pts.checkReturnTicketResponse> checkReturnTicketAsync(pts.checkReturnTicketRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/checkReturnCarTicket", ReplyAction="*")]
        System.Threading.Tasks.Task<pts.checkReturnCarTicketResponse> checkReturnCarTicketAsync(pts.checkReturnCarTicketRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/setTag2", ReplyAction="*")]
        System.Threading.Tasks.Task<pts.setTag2Response> setTag2Async(pts.setTag2Request request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class getPortRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="getPort", Namespace="http://tempuri.org/", Order=0)]
        public pts.getPortRequestBody Body;
        
        public getPortRequest()
        {
        }
        
        public getPortRequest(pts.getPortRequestBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class getPortRequestBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string _posCode;
        
        public getPortRequestBody()
        {
        }
        
        public getPortRequestBody(string _posCode)
        {
            this._posCode = _posCode;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class getPortResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="getPortResponse", Namespace="http://tempuri.org/", Order=0)]
        public pts.getPortResponseBody Body;
        
        public getPortResponse()
        {
        }
        
        public getPortResponse(pts.getPortResponseBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class getPortResponseBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string getPortResult;
        
        public getPortResponseBody()
        {
        }
        
        public getPortResponseBody(string getPortResult)
        {
            this.getPortResult = getPortResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class getIfSuspendRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="getIfSuspend", Namespace="http://tempuri.org/", Order=0)]
        public pts.getIfSuspendRequestBody Body;
        
        public getIfSuspendRequest()
        {
        }
        
        public getIfSuspendRequest(pts.getIfSuspendRequestBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class getIfSuspendRequestBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string _posCode;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=1)]
        public int _time;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string _plan;
        
        public getIfSuspendRequestBody()
        {
        }
        
        public getIfSuspendRequestBody(string _posCode, int _time, string _plan)
        {
            this._posCode = _posCode;
            this._time = _time;
            this._plan = _plan;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class getIfSuspendResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="getIfSuspendResponse", Namespace="http://tempuri.org/", Order=0)]
        public pts.getIfSuspendResponseBody Body;
        
        public getIfSuspendResponse()
        {
        }
        
        public getIfSuspendResponse(pts.getIfSuspendResponseBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class getIfSuspendResponseBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string getIfSuspendResult;
        
        public getIfSuspendResponseBody()
        {
        }
        
        public getIfSuspendResponseBody(string getIfSuspendResult)
        {
            this.getIfSuspendResult = getIfSuspendResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class getShipListByPortRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="getShipListByPort", Namespace="http://tempuri.org/", Order=0)]
        public pts.getShipListByPortRequestBody Body;
        
        public getShipListByPortRequest()
        {
        }
        
        public getShipListByPortRequest(pts.getShipListByPortRequestBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class getShipListByPortRequestBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string _posCode;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string _dateFrom;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string _dateTo;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=3)]
        public string _port;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=4)]
        public string _allotType;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=5)]
        public bool _his;
        
        public getShipListByPortRequestBody()
        {
        }
        
        public getShipListByPortRequestBody(string _posCode, string _dateFrom, string _dateTo, string _port, string _allotType, bool _his)
        {
            this._posCode = _posCode;
            this._dateFrom = _dateFrom;
            this._dateTo = _dateTo;
            this._port = _port;
            this._allotType = _allotType;
            this._his = _his;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class getShipListByPortResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="getShipListByPortResponse", Namespace="http://tempuri.org/", Order=0)]
        public pts.getShipListByPortResponseBody Body;
        
        public getShipListByPortResponse()
        {
        }
        
        public getShipListByPortResponse(pts.getShipListByPortResponseBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class getShipListByPortResponseBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string getShipListByPortResult;
        
        public getShipListByPortResponseBody()
        {
        }
        
        public getShipListByPortResponseBody(string getShipListByPortResult)
        {
            this.getShipListByPortResult = getShipListByPortResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class getSearouteRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="getSearoute", Namespace="http://tempuri.org/", Order=0)]
        public pts.getSearouteRequestBody Body;
        
        public getSearouteRequest()
        {
        }
        
        public getSearouteRequest(pts.getSearouteRequestBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class getSearouteRequestBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string _posCode;
        
        public getSearouteRequestBody()
        {
        }
        
        public getSearouteRequestBody(string _posCode)
        {
            this._posCode = _posCode;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class getSearouteResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="getSearouteResponse", Namespace="http://tempuri.org/", Order=0)]
        public pts.getSearouteResponseBody Body;
        
        public getSearouteResponse()
        {
        }
        
        public getSearouteResponse(pts.getSearouteResponseBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class getSearouteResponseBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string getSearouteResult;
        
        public getSearouteResponseBody()
        {
        }
        
        public getSearouteResponseBody(string getSearouteResult)
        {
            this.getSearouteResult = getSearouteResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class getShipListRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="getShipList", Namespace="http://tempuri.org/", Order=0)]
        public pts.getShipListRequestBody Body;
        
        public getShipListRequest()
        {
        }
        
        public getShipListRequest(pts.getShipListRequestBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class getShipListRequestBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string _posCode;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string _dateFrom;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string _dateTo;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=3)]
        public bool _his;
        
        public getShipListRequestBody()
        {
        }
        
        public getShipListRequestBody(string _posCode, string _dateFrom, string _dateTo, bool _his)
        {
            this._posCode = _posCode;
            this._dateFrom = _dateFrom;
            this._dateTo = _dateTo;
            this._his = _his;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class getShipListResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="getShipListResponse", Namespace="http://tempuri.org/", Order=0)]
        public pts.getShipListResponseBody Body;
        
        public getShipListResponse()
        {
        }
        
        public getShipListResponse(pts.getShipListResponseBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class getShipListResponseBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string getShipListResult;
        
        public getShipListResponseBody()
        {
        }
        
        public getShipListResponseBody(string getShipListResult)
        {
            this.getShipListResult = getShipListResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class getGradePriceListAllAgioRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="getGradePriceListAllAgio", Namespace="http://tempuri.org/", Order=0)]
        public pts.getGradePriceListAllAgioRequestBody Body;
        
        public getGradePriceListAllAgioRequest()
        {
        }
        
        public getGradePriceListAllAgioRequest(pts.getGradePriceListAllAgioRequestBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class getGradePriceListAllAgioRequestBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string _posCode;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string _planId;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string _allotType;
        
        public getGradePriceListAllAgioRequestBody()
        {
        }
        
        public getGradePriceListAllAgioRequestBody(string _posCode, string _planId, string _allotType)
        {
            this._posCode = _posCode;
            this._planId = _planId;
            this._allotType = _allotType;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class getGradePriceListAllAgioResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="getGradePriceListAllAgioResponse", Namespace="http://tempuri.org/", Order=0)]
        public pts.getGradePriceListAllAgioResponseBody Body;
        
        public getGradePriceListAllAgioResponse()
        {
        }
        
        public getGradePriceListAllAgioResponse(pts.getGradePriceListAllAgioResponseBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class getGradePriceListAllAgioResponseBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string getGradePriceListAllAgioResult;
        
        public getGradePriceListAllAgioResponseBody()
        {
        }
        
        public getGradePriceListAllAgioResponseBody(string getGradePriceListAllAgioResult)
        {
            this.getGradePriceListAllAgioResult = getGradePriceListAllAgioResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class getBookBillIdUserRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="getBookBillIdUser", Namespace="http://tempuri.org/", Order=0)]
        public pts.getBookBillIdUserRequestBody Body;
        
        public getBookBillIdUserRequest()
        {
        }
        
        public getBookBillIdUserRequest(pts.getBookBillIdUserRequestBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class getBookBillIdUserRequestBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string _posCode;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string _getterName;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string _getterPhone;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=3)]
        public string _getterId;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=4)]
        public string _webUserId;
        
        public getBookBillIdUserRequestBody()
        {
        }
        
        public getBookBillIdUserRequestBody(string _posCode, string _getterName, string _getterPhone, string _getterId, string _webUserId)
        {
            this._posCode = _posCode;
            this._getterName = _getterName;
            this._getterPhone = _getterPhone;
            this._getterId = _getterId;
            this._webUserId = _webUserId;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class getBookBillIdUserResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="getBookBillIdUserResponse", Namespace="http://tempuri.org/", Order=0)]
        public pts.getBookBillIdUserResponseBody Body;
        
        public getBookBillIdUserResponse()
        {
        }
        
        public getBookBillIdUserResponse(pts.getBookBillIdUserResponseBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class getBookBillIdUserResponseBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string getBookBillIdUserResult;
        
        public getBookBillIdUserResponseBody()
        {
        }
        
        public getBookBillIdUserResponseBody(string getBookBillIdUserResult)
        {
            this.getBookBillIdUserResult = getBookBillIdUserResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class getBookBillIdUserTag1Request
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="getBookBillIdUserTag1", Namespace="http://tempuri.org/", Order=0)]
        public pts.getBookBillIdUserTag1RequestBody Body;
        
        public getBookBillIdUserTag1Request()
        {
        }
        
        public getBookBillIdUserTag1Request(pts.getBookBillIdUserTag1RequestBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class getBookBillIdUserTag1RequestBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string _posCode;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string _getterName;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string _getterPhone;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=3)]
        public string _getterId;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=4)]
        public string _webUserId;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=5)]
        public string _tag;
        
        public getBookBillIdUserTag1RequestBody()
        {
        }
        
        public getBookBillIdUserTag1RequestBody(string _posCode, string _getterName, string _getterPhone, string _getterId, string _webUserId, string _tag)
        {
            this._posCode = _posCode;
            this._getterName = _getterName;
            this._getterPhone = _getterPhone;
            this._getterId = _getterId;
            this._webUserId = _webUserId;
            this._tag = _tag;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class getBookBillIdUserTag1Response
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="getBookBillIdUserTag1Response", Namespace="http://tempuri.org/", Order=0)]
        public pts.getBookBillIdUserTag1ResponseBody Body;
        
        public getBookBillIdUserTag1Response()
        {
        }
        
        public getBookBillIdUserTag1Response(pts.getBookBillIdUserTag1ResponseBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class getBookBillIdUserTag1ResponseBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string getBookBillIdUserTag1Result;
        
        public getBookBillIdUserTag1ResponseBody()
        {
        }
        
        public getBookBillIdUserTag1ResponseBody(string getBookBillIdUserTag1Result)
        {
            this.getBookBillIdUserTag1Result = getBookBillIdUserTag1Result;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class bookTicketAutoAgioRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="bookTicketAutoAgio", Namespace="http://tempuri.org/", Order=0)]
        public pts.bookTicketAutoAgioRequestBody Body;
        
        public bookTicketAutoAgioRequest()
        {
        }
        
        public bookTicketAutoAgioRequest(pts.bookTicketAutoAgioRequestBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class bookTicketAutoAgioRequestBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string _posCode;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string _planId;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string _gradeId;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=3)]
        public string _allotType;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=4)]
        public int _bz;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=5)]
        public int _ticketNum;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=6)]
        public string _bookBillId;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=7)]
        public string _price;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=8)]
        public string _ifAz;
        
        public bookTicketAutoAgioRequestBody()
        {
        }
        
        public bookTicketAutoAgioRequestBody(string _posCode, string _planId, string _gradeId, string _allotType, int _bz, int _ticketNum, string _bookBillId, string _price, string _ifAz)
        {
            this._posCode = _posCode;
            this._planId = _planId;
            this._gradeId = _gradeId;
            this._allotType = _allotType;
            this._bz = _bz;
            this._ticketNum = _ticketNum;
            this._bookBillId = _bookBillId;
            this._price = _price;
            this._ifAz = _ifAz;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class bookTicketAutoAgioResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="bookTicketAutoAgioResponse", Namespace="http://tempuri.org/", Order=0)]
        public pts.bookTicketAutoAgioResponseBody Body;
        
        public bookTicketAutoAgioResponse()
        {
        }
        
        public bookTicketAutoAgioResponse(pts.bookTicketAutoAgioResponseBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class bookTicketAutoAgioResponseBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string bookTicketAutoAgioResult;
        
        public bookTicketAutoAgioResponseBody()
        {
        }
        
        public bookTicketAutoAgioResponseBody(string bookTicketAutoAgioResult)
        {
            this.bookTicketAutoAgioResult = bookTicketAutoAgioResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class bookTicketAutoRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="bookTicketAuto", Namespace="http://tempuri.org/", Order=0)]
        public pts.bookTicketAutoRequestBody Body;
        
        public bookTicketAutoRequest()
        {
        }
        
        public bookTicketAutoRequest(pts.bookTicketAutoRequestBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class bookTicketAutoRequestBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string _posCode;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string _planId;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string _gradeId;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=3)]
        public string _allotType;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=4)]
        public int _bz;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=5)]
        public int _ticketNum;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=6)]
        public string _bookBillId;
        
        public bookTicketAutoRequestBody()
        {
        }
        
        public bookTicketAutoRequestBody(string _posCode, string _planId, string _gradeId, string _allotType, int _bz, int _ticketNum, string _bookBillId)
        {
            this._posCode = _posCode;
            this._planId = _planId;
            this._gradeId = _gradeId;
            this._allotType = _allotType;
            this._bz = _bz;
            this._ticketNum = _ticketNum;
            this._bookBillId = _bookBillId;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class bookTicketAutoResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="bookTicketAutoResponse", Namespace="http://tempuri.org/", Order=0)]
        public pts.bookTicketAutoResponseBody Body;
        
        public bookTicketAutoResponse()
        {
        }
        
        public bookTicketAutoResponse(pts.bookTicketAutoResponseBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class bookTicketAutoResponseBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string bookTicketAutoResult;
        
        public bookTicketAutoResponseBody()
        {
        }
        
        public bookTicketAutoResponseBody(string bookTicketAutoResult)
        {
            this.bookTicketAutoResult = bookTicketAutoResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class bookTicketAutoByTicketTypeRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="bookTicketAutoByTicketType", Namespace="http://tempuri.org/", Order=0)]
        public pts.bookTicketAutoByTicketTypeRequestBody Body;
        
        public bookTicketAutoByTicketTypeRequest()
        {
        }
        
        public bookTicketAutoByTicketTypeRequest(pts.bookTicketAutoByTicketTypeRequestBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class bookTicketAutoByTicketTypeRequestBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string _posCode;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string _planId;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string _gradeId;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=3)]
        public string _allotType;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=4)]
        public int _bz;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=5)]
        public int _ticketNum;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=6)]
        public string _bookBillId;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=7)]
        public string _ticketType;
        
        public bookTicketAutoByTicketTypeRequestBody()
        {
        }
        
        public bookTicketAutoByTicketTypeRequestBody(string _posCode, string _planId, string _gradeId, string _allotType, int _bz, int _ticketNum, string _bookBillId, string _ticketType)
        {
            this._posCode = _posCode;
            this._planId = _planId;
            this._gradeId = _gradeId;
            this._allotType = _allotType;
            this._bz = _bz;
            this._ticketNum = _ticketNum;
            this._bookBillId = _bookBillId;
            this._ticketType = _ticketType;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class bookTicketAutoByTicketTypeResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="bookTicketAutoByTicketTypeResponse", Namespace="http://tempuri.org/", Order=0)]
        public pts.bookTicketAutoByTicketTypeResponseBody Body;
        
        public bookTicketAutoByTicketTypeResponse()
        {
        }
        
        public bookTicketAutoByTicketTypeResponse(pts.bookTicketAutoByTicketTypeResponseBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class bookTicketAutoByTicketTypeResponseBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string bookTicketAutoByTicketTypeResult;
        
        public bookTicketAutoByTicketTypeResponseBody()
        {
        }
        
        public bookTicketAutoByTicketTypeResponseBody(string bookTicketAutoByTicketTypeResult)
        {
            this.bookTicketAutoByTicketTypeResult = bookTicketAutoByTicketTypeResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class getBookBillStateRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="getBookBillState", Namespace="http://tempuri.org/", Order=0)]
        public pts.getBookBillStateRequestBody Body;
        
        public getBookBillStateRequest()
        {
        }
        
        public getBookBillStateRequest(pts.getBookBillStateRequestBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class getBookBillStateRequestBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string _posCode;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string _bookBillId;
        
        public getBookBillStateRequestBody()
        {
        }
        
        public getBookBillStateRequestBody(string _posCode, string _bookBillId)
        {
            this._posCode = _posCode;
            this._bookBillId = _bookBillId;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class getBookBillStateResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="getBookBillStateResponse", Namespace="http://tempuri.org/", Order=0)]
        public pts.getBookBillStateResponseBody Body;
        
        public getBookBillStateResponse()
        {
        }
        
        public getBookBillStateResponse(pts.getBookBillStateResponseBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class getBookBillStateResponseBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string getBookBillStateResult;
        
        public getBookBillStateResponseBody()
        {
        }
        
        public getBookBillStateResponseBody(string getBookBillStateResult)
        {
            this.getBookBillStateResult = getBookBillStateResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class getBookBillStateNewRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="getBookBillStateNew", Namespace="http://tempuri.org/", Order=0)]
        public pts.getBookBillStateNewRequestBody Body;
        
        public getBookBillStateNewRequest()
        {
        }
        
        public getBookBillStateNewRequest(pts.getBookBillStateNewRequestBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class getBookBillStateNewRequestBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string _posCode;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string _bookBillId;
        
        public getBookBillStateNewRequestBody()
        {
        }
        
        public getBookBillStateNewRequestBody(string _posCode, string _bookBillId)
        {
            this._posCode = _posCode;
            this._bookBillId = _bookBillId;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class getBookBillStateNewResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="getBookBillStateNewResponse", Namespace="http://tempuri.org/", Order=0)]
        public pts.getBookBillStateNewResponseBody Body;
        
        public getBookBillStateNewResponse()
        {
        }
        
        public getBookBillStateNewResponse(pts.getBookBillStateNewResponseBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class getBookBillStateNewResponseBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string getBookBillStateNewResult;
        
        public getBookBillStateNewResponseBody()
        {
        }
        
        public getBookBillStateNewResponseBody(string getBookBillStateNewResult)
        {
            this.getBookBillStateNewResult = getBookBillStateNewResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class getBookBillStateByGroupRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="getBookBillStateByGroup", Namespace="http://tempuri.org/", Order=0)]
        public pts.getBookBillStateByGroupRequestBody Body;
        
        public getBookBillStateByGroupRequest()
        {
        }
        
        public getBookBillStateByGroupRequest(pts.getBookBillStateByGroupRequestBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class getBookBillStateByGroupRequestBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string _posCode;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string _bookBillId;
        
        public getBookBillStateByGroupRequestBody()
        {
        }
        
        public getBookBillStateByGroupRequestBody(string _posCode, string _bookBillId)
        {
            this._posCode = _posCode;
            this._bookBillId = _bookBillId;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class getBookBillStateByGroupResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="getBookBillStateByGroupResponse", Namespace="http://tempuri.org/", Order=0)]
        public pts.getBookBillStateByGroupResponseBody Body;
        
        public getBookBillStateByGroupResponse()
        {
        }
        
        public getBookBillStateByGroupResponse(pts.getBookBillStateByGroupResponseBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class getBookBillStateByGroupResponseBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string getBookBillStateByGroupResult;
        
        public getBookBillStateByGroupResponseBody()
        {
        }
        
        public getBookBillStateByGroupResponseBody(string getBookBillStateByGroupResult)
        {
            this.getBookBillStateByGroupResult = getBookBillStateByGroupResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class addBookBillInfoRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="addBookBillInfo", Namespace="http://tempuri.org/", Order=0)]
        public pts.addBookBillInfoRequestBody Body;
        
        public addBookBillInfoRequest()
        {
        }
        
        public addBookBillInfoRequest(pts.addBookBillInfoRequestBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class addBookBillInfoRequestBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string _posCode;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string _getterName;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string _getterPhone;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=3)]
        public string _getterId;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=4)]
        public string _bookBillId;
        
        public addBookBillInfoRequestBody()
        {
        }
        
        public addBookBillInfoRequestBody(string _posCode, string _getterName, string _getterPhone, string _getterId, string _bookBillId)
        {
            this._posCode = _posCode;
            this._getterName = _getterName;
            this._getterPhone = _getterPhone;
            this._getterId = _getterId;
            this._bookBillId = _bookBillId;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class addBookBillInfoResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="addBookBillInfoResponse", Namespace="http://tempuri.org/", Order=0)]
        public pts.addBookBillInfoResponseBody Body;
        
        public addBookBillInfoResponse()
        {
        }
        
        public addBookBillInfoResponse(pts.addBookBillInfoResponseBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class addBookBillInfoResponseBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string addBookBillInfoResult;
        
        public addBookBillInfoResponseBody()
        {
        }
        
        public addBookBillInfoResponseBody(string addBookBillInfoResult)
        {
            this.addBookBillInfoResult = addBookBillInfoResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class addTicketInfoRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="addTicketInfo", Namespace="http://tempuri.org/", Order=0)]
        public pts.addTicketInfoRequestBody Body;
        
        public addTicketInfoRequest()
        {
        }
        
        public addTicketInfoRequest(pts.addTicketInfoRequestBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class addTicketInfoRequestBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string _posCode;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string _userName;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string _userId;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=3)]
        public string _bookBillId;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=4)]
        public string _ticketId;
        
        public addTicketInfoRequestBody()
        {
        }
        
        public addTicketInfoRequestBody(string _posCode, string _userName, string _userId, string _bookBillId, string _ticketId)
        {
            this._posCode = _posCode;
            this._userName = _userName;
            this._userId = _userId;
            this._bookBillId = _bookBillId;
            this._ticketId = _ticketId;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class addTicketInfoResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="addTicketInfoResponse", Namespace="http://tempuri.org/", Order=0)]
        public pts.addTicketInfoResponseBody Body;
        
        public addTicketInfoResponse()
        {
        }
        
        public addTicketInfoResponse(pts.addTicketInfoResponseBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class addTicketInfoResponseBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string addTicketInfoResult;
        
        public addTicketInfoResponseBody()
        {
        }
        
        public addTicketInfoResponseBody(string addTicketInfoResult)
        {
            this.addTicketInfoResult = addTicketInfoResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class cancelBookBillRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="cancelBookBill", Namespace="http://tempuri.org/", Order=0)]
        public pts.cancelBookBillRequestBody Body;
        
        public cancelBookBillRequest()
        {
        }
        
        public cancelBookBillRequest(pts.cancelBookBillRequestBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class cancelBookBillRequestBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string _posCode;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string _bookBillId;
        
        public cancelBookBillRequestBody()
        {
        }
        
        public cancelBookBillRequestBody(string _posCode, string _bookBillId)
        {
            this._posCode = _posCode;
            this._bookBillId = _bookBillId;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class cancelBookBillResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="cancelBookBillResponse", Namespace="http://tempuri.org/", Order=0)]
        public pts.cancelBookBillResponseBody Body;
        
        public cancelBookBillResponse()
        {
        }
        
        public cancelBookBillResponse(pts.cancelBookBillResponseBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class cancelBookBillResponseBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string cancelBookBillResult;
        
        public cancelBookBillResponseBody()
        {
        }
        
        public cancelBookBillResponseBody(string cancelBookBillResult)
        {
            this.cancelBookBillResult = cancelBookBillResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class getBillListUserRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="getBillListUser", Namespace="http://tempuri.org/", Order=0)]
        public pts.getBillListUserRequestBody Body;
        
        public getBillListUserRequest()
        {
        }
        
        public getBillListUserRequest(pts.getBillListUserRequestBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class getBillListUserRequestBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string _posCode;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string _timeFrom;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string _timeTo;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=3)]
        public string _billState;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=4)]
        public string _webUserId;
        
        public getBillListUserRequestBody()
        {
        }
        
        public getBillListUserRequestBody(string _posCode, string _timeFrom, string _timeTo, string _billState, string _webUserId)
        {
            this._posCode = _posCode;
            this._timeFrom = _timeFrom;
            this._timeTo = _timeTo;
            this._billState = _billState;
            this._webUserId = _webUserId;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class getBillListUserResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="getBillListUserResponse", Namespace="http://tempuri.org/", Order=0)]
        public pts.getBillListUserResponseBody Body;
        
        public getBillListUserResponse()
        {
        }
        
        public getBillListUserResponse(pts.getBillListUserResponseBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class getBillListUserResponseBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string getBillListUserResult;
        
        public getBillListUserResponseBody()
        {
        }
        
        public getBillListUserResponseBody(string getBillListUserResult)
        {
            this.getBillListUserResult = getBillListUserResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class getBillListTag1Request
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="getBillListTag1", Namespace="http://tempuri.org/", Order=0)]
        public pts.getBillListTag1RequestBody Body;
        
        public getBillListTag1Request()
        {
        }
        
        public getBillListTag1Request(pts.getBillListTag1RequestBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class getBillListTag1RequestBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string _posCode;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string _timeFrom;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string _timeTo;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=3)]
        public string _billState;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=4)]
        public string _tag;
        
        public getBillListTag1RequestBody()
        {
        }
        
        public getBillListTag1RequestBody(string _posCode, string _timeFrom, string _timeTo, string _billState, string _tag)
        {
            this._posCode = _posCode;
            this._timeFrom = _timeFrom;
            this._timeTo = _timeTo;
            this._billState = _billState;
            this._tag = _tag;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class getBillListTag1Response
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="getBillListTag1Response", Namespace="http://tempuri.org/", Order=0)]
        public pts.getBillListTag1ResponseBody Body;
        
        public getBillListTag1Response()
        {
        }
        
        public getBillListTag1Response(pts.getBillListTag1ResponseBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class getBillListTag1ResponseBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string getBillListTag1Result;
        
        public getBillListTag1ResponseBody()
        {
        }
        
        public getBillListTag1ResponseBody(string getBillListTag1Result)
        {
            this.getBillListTag1Result = getBillListTag1Result;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class getBillListUserTotalRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="getBillListUserTotal", Namespace="http://tempuri.org/", Order=0)]
        public pts.getBillListUserTotalRequestBody Body;
        
        public getBillListUserTotalRequest()
        {
        }
        
        public getBillListUserTotalRequest(pts.getBillListUserTotalRequestBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class getBillListUserTotalRequestBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string _posCode;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string _timeFrom;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string _timeTo;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=3)]
        public string _billState;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=4)]
        public string _webUserId;
        
        public getBillListUserTotalRequestBody()
        {
        }
        
        public getBillListUserTotalRequestBody(string _posCode, string _timeFrom, string _timeTo, string _billState, string _webUserId)
        {
            this._posCode = _posCode;
            this._timeFrom = _timeFrom;
            this._timeTo = _timeTo;
            this._billState = _billState;
            this._webUserId = _webUserId;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class getBillListUserTotalResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="getBillListUserTotalResponse", Namespace="http://tempuri.org/", Order=0)]
        public pts.getBillListUserTotalResponseBody Body;
        
        public getBillListUserTotalResponse()
        {
        }
        
        public getBillListUserTotalResponse(pts.getBillListUserTotalResponseBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class getBillListUserTotalResponseBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string getBillListUserTotalResult;
        
        public getBillListUserTotalResponseBody()
        {
        }
        
        public getBillListUserTotalResponseBody(string getBillListUserTotalResult)
        {
            this.getBillListUserTotalResult = getBillListUserTotalResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class getCarGradePriceListAllAgioRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="getCarGradePriceListAllAgio", Namespace="http://tempuri.org/", Order=0)]
        public pts.getCarGradePriceListAllAgioRequestBody Body;
        
        public getCarGradePriceListAllAgioRequest()
        {
        }
        
        public getCarGradePriceListAllAgioRequest(pts.getCarGradePriceListAllAgioRequestBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class getCarGradePriceListAllAgioRequestBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string _posCode;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string _planId;
        
        public getCarGradePriceListAllAgioRequestBody()
        {
        }
        
        public getCarGradePriceListAllAgioRequestBody(string _posCode, string _planId)
        {
            this._posCode = _posCode;
            this._planId = _planId;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class getCarGradePriceListAllAgioResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="getCarGradePriceListAllAgioResponse", Namespace="http://tempuri.org/", Order=0)]
        public pts.getCarGradePriceListAllAgioResponseBody Body;
        
        public getCarGradePriceListAllAgioResponse()
        {
        }
        
        public getCarGradePriceListAllAgioResponse(pts.getCarGradePriceListAllAgioResponseBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class getCarGradePriceListAllAgioResponseBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string getCarGradePriceListAllAgioResult;
        
        public getCarGradePriceListAllAgioResponseBody()
        {
        }
        
        public getCarGradePriceListAllAgioResponseBody(string getCarGradePriceListAllAgioResult)
        {
            this.getCarGradePriceListAllAgioResult = getCarGradePriceListAllAgioResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class bookCarTicketAgioRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="bookCarTicketAgio", Namespace="http://tempuri.org/", Order=0)]
        public pts.bookCarTicketAgioRequestBody Body;
        
        public bookCarTicketAgioRequest()
        {
        }
        
        public bookCarTicketAgioRequest(pts.bookCarTicketAgioRequestBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class bookCarTicketAgioRequestBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string _posCode;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string _planId;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string _carGradeId;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=3)]
        public string _carAllotType;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=4)]
        public string _carPriceId;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=5)]
        public string _cardProvinceId;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=6)]
        public string _carCardNumber;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=7)]
        public string _cargoId;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=8)]
        public string _ifEmpty;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=9)]
        public string _bookBillId;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=10)]
        public string _carPrice;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=11)]
        public string _ifAz;
        
        public bookCarTicketAgioRequestBody()
        {
        }
        
        public bookCarTicketAgioRequestBody(string _posCode, string _planId, string _carGradeId, string _carAllotType, string _carPriceId, string _cardProvinceId, string _carCardNumber, string _cargoId, string _ifEmpty, string _bookBillId, string _carPrice, string _ifAz)
        {
            this._posCode = _posCode;
            this._planId = _planId;
            this._carGradeId = _carGradeId;
            this._carAllotType = _carAllotType;
            this._carPriceId = _carPriceId;
            this._cardProvinceId = _cardProvinceId;
            this._carCardNumber = _carCardNumber;
            this._cargoId = _cargoId;
            this._ifEmpty = _ifEmpty;
            this._bookBillId = _bookBillId;
            this._carPrice = _carPrice;
            this._ifAz = _ifAz;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class bookCarTicketAgioResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="bookCarTicketAgioResponse", Namespace="http://tempuri.org/", Order=0)]
        public pts.bookCarTicketAgioResponseBody Body;
        
        public bookCarTicketAgioResponse()
        {
        }
        
        public bookCarTicketAgioResponse(pts.bookCarTicketAgioResponseBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class bookCarTicketAgioResponseBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string bookCarTicketAgioResult;
        
        public bookCarTicketAgioResponseBody()
        {
        }
        
        public bookCarTicketAgioResponseBody(string bookCarTicketAgioResult)
        {
            this.bookCarTicketAgioResult = bookCarTicketAgioResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class returnBookTicketRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="returnBookTicket", Namespace="http://tempuri.org/", Order=0)]
        public pts.returnBookTicketRequestBody Body;
        
        public returnBookTicketRequest()
        {
        }
        
        public returnBookTicketRequest(pts.returnBookTicketRequestBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class returnBookTicketRequestBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string _posCode;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string _ticketId;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string _bookBillId;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=3)]
        public string _returnType;
        
        public returnBookTicketRequestBody()
        {
        }
        
        public returnBookTicketRequestBody(string _posCode, string _ticketId, string _bookBillId, string _returnType)
        {
            this._posCode = _posCode;
            this._ticketId = _ticketId;
            this._bookBillId = _bookBillId;
            this._returnType = _returnType;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class returnBookTicketResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="returnBookTicketResponse", Namespace="http://tempuri.org/", Order=0)]
        public pts.returnBookTicketResponseBody Body;
        
        public returnBookTicketResponse()
        {
        }
        
        public returnBookTicketResponse(pts.returnBookTicketResponseBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class returnBookTicketResponseBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string returnBookTicketResult;
        
        public returnBookTicketResponseBody()
        {
        }
        
        public returnBookTicketResponseBody(string returnBookTicketResult)
        {
            this.returnBookTicketResult = returnBookTicketResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class returnBillRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="returnBill", Namespace="http://tempuri.org/", Order=0)]
        public pts.returnBillRequestBody Body;
        
        public returnBillRequest()
        {
        }
        
        public returnBillRequest(pts.returnBillRequestBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class returnBillRequestBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string _posCode;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string _bookBillId;
        
        public returnBillRequestBody()
        {
        }
        
        public returnBillRequestBody(string _posCode, string _bookBillId)
        {
            this._posCode = _posCode;
            this._bookBillId = _bookBillId;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class returnBillResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="returnBillResponse", Namespace="http://tempuri.org/", Order=0)]
        public pts.returnBillResponseBody Body;
        
        public returnBillResponse()
        {
        }
        
        public returnBillResponse(pts.returnBillResponseBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class returnBillResponseBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string returnBillResult;
        
        public returnBillResponseBody()
        {
        }
        
        public returnBillResponseBody(string returnBillResult)
        {
            this.returnBillResult = returnBillResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class checkReturnTicketRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="checkReturnTicket", Namespace="http://tempuri.org/", Order=0)]
        public pts.checkReturnTicketRequestBody Body;
        
        public checkReturnTicketRequest()
        {
        }
        
        public checkReturnTicketRequest(pts.checkReturnTicketRequestBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class checkReturnTicketRequestBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string _posCode;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string _ticketId;
        
        public checkReturnTicketRequestBody()
        {
        }
        
        public checkReturnTicketRequestBody(string _posCode, string _ticketId)
        {
            this._posCode = _posCode;
            this._ticketId = _ticketId;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class checkReturnTicketResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="checkReturnTicketResponse", Namespace="http://tempuri.org/", Order=0)]
        public pts.checkReturnTicketResponseBody Body;
        
        public checkReturnTicketResponse()
        {
        }
        
        public checkReturnTicketResponse(pts.checkReturnTicketResponseBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class checkReturnTicketResponseBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string checkReturnTicketResult;
        
        public checkReturnTicketResponseBody()
        {
        }
        
        public checkReturnTicketResponseBody(string checkReturnTicketResult)
        {
            this.checkReturnTicketResult = checkReturnTicketResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class checkReturnCarTicketRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="checkReturnCarTicket", Namespace="http://tempuri.org/", Order=0)]
        public pts.checkReturnCarTicketRequestBody Body;
        
        public checkReturnCarTicketRequest()
        {
        }
        
        public checkReturnCarTicketRequest(pts.checkReturnCarTicketRequestBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class checkReturnCarTicketRequestBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string _posCode;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string _ticketId;
        
        public checkReturnCarTicketRequestBody()
        {
        }
        
        public checkReturnCarTicketRequestBody(string _posCode, string _ticketId)
        {
            this._posCode = _posCode;
            this._ticketId = _ticketId;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class checkReturnCarTicketResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="checkReturnCarTicketResponse", Namespace="http://tempuri.org/", Order=0)]
        public pts.checkReturnCarTicketResponseBody Body;
        
        public checkReturnCarTicketResponse()
        {
        }
        
        public checkReturnCarTicketResponse(pts.checkReturnCarTicketResponseBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class checkReturnCarTicketResponseBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string checkReturnCarTicketResult;
        
        public checkReturnCarTicketResponseBody()
        {
        }
        
        public checkReturnCarTicketResponseBody(string checkReturnCarTicketResult)
        {
            this.checkReturnCarTicketResult = checkReturnCarTicketResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class setTag2Request
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="setTag2", Namespace="http://tempuri.org/", Order=0)]
        public pts.setTag2RequestBody Body;
        
        public setTag2Request()
        {
        }
        
        public setTag2Request(pts.setTag2RequestBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class setTag2RequestBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string _posCode;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string _bookBillId;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string _tag2;
        
        public setTag2RequestBody()
        {
        }
        
        public setTag2RequestBody(string _posCode, string _bookBillId, string _tag2)
        {
            this._posCode = _posCode;
            this._bookBillId = _bookBillId;
            this._tag2 = _tag2;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class setTag2Response
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="setTag2Response", Namespace="http://tempuri.org/", Order=0)]
        public pts.setTag2ResponseBody Body;
        
        public setTag2Response()
        {
        }
        
        public setTag2Response(pts.setTag2ResponseBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class setTag2ResponseBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string setTag2Result;
        
        public setTag2ResponseBody()
        {
        }
        
        public setTag2ResponseBody(string setTag2Result)
        {
            this.setTag2Result = setTag2Result;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    public interface PtsServiceTJSoapChannel : pts.PtsServiceTJSoap, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    public partial class PtsServiceTJSoapClient : System.ServiceModel.ClientBase<pts.PtsServiceTJSoap>, pts.PtsServiceTJSoap
    {
        
    /// <summary>
    /// 实现此分部方法，配置服务终结点。
    /// </summary>
    /// <param name="serviceEndpoint">要配置的终结点</param>
    /// <param name="clientCredentials">客户端凭据</param>
    static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public PtsServiceTJSoapClient(EndpointConfiguration endpointConfiguration) : 
                base(PtsServiceTJSoapClient.GetBindingForEndpoint(endpointConfiguration), PtsServiceTJSoapClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public PtsServiceTJSoapClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(PtsServiceTJSoapClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public PtsServiceTJSoapClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(PtsServiceTJSoapClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public PtsServiceTJSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<pts.getPortResponse> pts.PtsServiceTJSoap.getPortAsync(pts.getPortRequest request)
        {
            return base.Channel.getPortAsync(request);
        }
        
        public System.Threading.Tasks.Task<pts.getPortResponse> getPortAsync(string _posCode)
        {
            pts.getPortRequest inValue = new pts.getPortRequest();
            inValue.Body = new pts.getPortRequestBody();
            inValue.Body._posCode = _posCode;
            return ((pts.PtsServiceTJSoap)(this)).getPortAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<pts.getIfSuspendResponse> pts.PtsServiceTJSoap.getIfSuspendAsync(pts.getIfSuspendRequest request)
        {
            return base.Channel.getIfSuspendAsync(request);
        }
        
        public System.Threading.Tasks.Task<pts.getIfSuspendResponse> getIfSuspendAsync(string _posCode, int _time, string _plan)
        {
            pts.getIfSuspendRequest inValue = new pts.getIfSuspendRequest();
            inValue.Body = new pts.getIfSuspendRequestBody();
            inValue.Body._posCode = _posCode;
            inValue.Body._time = _time;
            inValue.Body._plan = _plan;
            return ((pts.PtsServiceTJSoap)(this)).getIfSuspendAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<pts.getShipListByPortResponse> pts.PtsServiceTJSoap.getShipListByPortAsync(pts.getShipListByPortRequest request)
        {
            return base.Channel.getShipListByPortAsync(request);
        }
        
        public System.Threading.Tasks.Task<pts.getShipListByPortResponse> getShipListByPortAsync(string _posCode, string _dateFrom, string _dateTo, string _port, string _allotType, bool _his)
        {
            pts.getShipListByPortRequest inValue = new pts.getShipListByPortRequest();
            inValue.Body = new pts.getShipListByPortRequestBody();
            inValue.Body._posCode = _posCode;
            inValue.Body._dateFrom = _dateFrom;
            inValue.Body._dateTo = _dateTo;
            inValue.Body._port = _port;
            inValue.Body._allotType = _allotType;
            inValue.Body._his = _his;
            return ((pts.PtsServiceTJSoap)(this)).getShipListByPortAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<pts.getSearouteResponse> pts.PtsServiceTJSoap.getSearouteAsync(pts.getSearouteRequest request)
        {
            return base.Channel.getSearouteAsync(request);
        }
        
        public System.Threading.Tasks.Task<pts.getSearouteResponse> getSearouteAsync(string _posCode)
        {
            pts.getSearouteRequest inValue = new pts.getSearouteRequest();
            inValue.Body = new pts.getSearouteRequestBody();
            inValue.Body._posCode = _posCode;
            return ((pts.PtsServiceTJSoap)(this)).getSearouteAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<pts.getShipListResponse> pts.PtsServiceTJSoap.getShipListAsync(pts.getShipListRequest request)
        {
            return base.Channel.getShipListAsync(request);
        }
        
        public System.Threading.Tasks.Task<pts.getShipListResponse> getShipListAsync(string _posCode, string _dateFrom, string _dateTo, bool _his)
        {
            pts.getShipListRequest inValue = new pts.getShipListRequest();
            inValue.Body = new pts.getShipListRequestBody();
            inValue.Body._posCode = _posCode;
            inValue.Body._dateFrom = _dateFrom;
            inValue.Body._dateTo = _dateTo;
            inValue.Body._his = _his;
            return ((pts.PtsServiceTJSoap)(this)).getShipListAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<pts.getGradePriceListAllAgioResponse> pts.PtsServiceTJSoap.getGradePriceListAllAgioAsync(pts.getGradePriceListAllAgioRequest request)
        {
            return base.Channel.getGradePriceListAllAgioAsync(request);
        }
        
        public System.Threading.Tasks.Task<pts.getGradePriceListAllAgioResponse> getGradePriceListAllAgioAsync(string _posCode, string _planId, string _allotType)
        {
            pts.getGradePriceListAllAgioRequest inValue = new pts.getGradePriceListAllAgioRequest();
            inValue.Body = new pts.getGradePriceListAllAgioRequestBody();
            inValue.Body._posCode = _posCode;
            inValue.Body._planId = _planId;
            inValue.Body._allotType = _allotType;
            return ((pts.PtsServiceTJSoap)(this)).getGradePriceListAllAgioAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<pts.getBookBillIdUserResponse> pts.PtsServiceTJSoap.getBookBillIdUserAsync(pts.getBookBillIdUserRequest request)
        {
            return base.Channel.getBookBillIdUserAsync(request);
        }
        
        public System.Threading.Tasks.Task<pts.getBookBillIdUserResponse> getBookBillIdUserAsync(string _posCode, string _getterName, string _getterPhone, string _getterId, string _webUserId)
        {
            pts.getBookBillIdUserRequest inValue = new pts.getBookBillIdUserRequest();
            inValue.Body = new pts.getBookBillIdUserRequestBody();
            inValue.Body._posCode = _posCode;
            inValue.Body._getterName = _getterName;
            inValue.Body._getterPhone = _getterPhone;
            inValue.Body._getterId = _getterId;
            inValue.Body._webUserId = _webUserId;
            return ((pts.PtsServiceTJSoap)(this)).getBookBillIdUserAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<pts.getBookBillIdUserTag1Response> pts.PtsServiceTJSoap.getBookBillIdUserTag1Async(pts.getBookBillIdUserTag1Request request)
        {
            return base.Channel.getBookBillIdUserTag1Async(request);
        }
        
        public System.Threading.Tasks.Task<pts.getBookBillIdUserTag1Response> getBookBillIdUserTag1Async(string _posCode, string _getterName, string _getterPhone, string _getterId, string _webUserId, string _tag)
        {
            pts.getBookBillIdUserTag1Request inValue = new pts.getBookBillIdUserTag1Request();
            inValue.Body = new pts.getBookBillIdUserTag1RequestBody();
            inValue.Body._posCode = _posCode;
            inValue.Body._getterName = _getterName;
            inValue.Body._getterPhone = _getterPhone;
            inValue.Body._getterId = _getterId;
            inValue.Body._webUserId = _webUserId;
            inValue.Body._tag = _tag;
            return ((pts.PtsServiceTJSoap)(this)).getBookBillIdUserTag1Async(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<pts.bookTicketAutoAgioResponse> pts.PtsServiceTJSoap.bookTicketAutoAgioAsync(pts.bookTicketAutoAgioRequest request)
        {
            return base.Channel.bookTicketAutoAgioAsync(request);
        }
        
        public System.Threading.Tasks.Task<pts.bookTicketAutoAgioResponse> bookTicketAutoAgioAsync(string _posCode, string _planId, string _gradeId, string _allotType, int _bz, int _ticketNum, string _bookBillId, string _price, string _ifAz)
        {
            pts.bookTicketAutoAgioRequest inValue = new pts.bookTicketAutoAgioRequest();
            inValue.Body = new pts.bookTicketAutoAgioRequestBody();
            inValue.Body._posCode = _posCode;
            inValue.Body._planId = _planId;
            inValue.Body._gradeId = _gradeId;
            inValue.Body._allotType = _allotType;
            inValue.Body._bz = _bz;
            inValue.Body._ticketNum = _ticketNum;
            inValue.Body._bookBillId = _bookBillId;
            inValue.Body._price = _price;
            inValue.Body._ifAz = _ifAz;
            return ((pts.PtsServiceTJSoap)(this)).bookTicketAutoAgioAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<pts.bookTicketAutoResponse> pts.PtsServiceTJSoap.bookTicketAutoAsync(pts.bookTicketAutoRequest request)
        {
            return base.Channel.bookTicketAutoAsync(request);
        }
        
        public System.Threading.Tasks.Task<pts.bookTicketAutoResponse> bookTicketAutoAsync(string _posCode, string _planId, string _gradeId, string _allotType, int _bz, int _ticketNum, string _bookBillId)
        {
            pts.bookTicketAutoRequest inValue = new pts.bookTicketAutoRequest();
            inValue.Body = new pts.bookTicketAutoRequestBody();
            inValue.Body._posCode = _posCode;
            inValue.Body._planId = _planId;
            inValue.Body._gradeId = _gradeId;
            inValue.Body._allotType = _allotType;
            inValue.Body._bz = _bz;
            inValue.Body._ticketNum = _ticketNum;
            inValue.Body._bookBillId = _bookBillId;
            return ((pts.PtsServiceTJSoap)(this)).bookTicketAutoAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<pts.bookTicketAutoByTicketTypeResponse> pts.PtsServiceTJSoap.bookTicketAutoByTicketTypeAsync(pts.bookTicketAutoByTicketTypeRequest request)
        {
            return base.Channel.bookTicketAutoByTicketTypeAsync(request);
        }
        
        public System.Threading.Tasks.Task<pts.bookTicketAutoByTicketTypeResponse> bookTicketAutoByTicketTypeAsync(string _posCode, string _planId, string _gradeId, string _allotType, int _bz, int _ticketNum, string _bookBillId, string _ticketType)
        {
            pts.bookTicketAutoByTicketTypeRequest inValue = new pts.bookTicketAutoByTicketTypeRequest();
            inValue.Body = new pts.bookTicketAutoByTicketTypeRequestBody();
            inValue.Body._posCode = _posCode;
            inValue.Body._planId = _planId;
            inValue.Body._gradeId = _gradeId;
            inValue.Body._allotType = _allotType;
            inValue.Body._bz = _bz;
            inValue.Body._ticketNum = _ticketNum;
            inValue.Body._bookBillId = _bookBillId;
            inValue.Body._ticketType = _ticketType;
            return ((pts.PtsServiceTJSoap)(this)).bookTicketAutoByTicketTypeAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<pts.getBookBillStateResponse> pts.PtsServiceTJSoap.getBookBillStateAsync(pts.getBookBillStateRequest request)
        {
            return base.Channel.getBookBillStateAsync(request);
        }
        
        public System.Threading.Tasks.Task<pts.getBookBillStateResponse> getBookBillStateAsync(string _posCode, string _bookBillId)
        {
            pts.getBookBillStateRequest inValue = new pts.getBookBillStateRequest();
            inValue.Body = new pts.getBookBillStateRequestBody();
            inValue.Body._posCode = _posCode;
            inValue.Body._bookBillId = _bookBillId;
            return ((pts.PtsServiceTJSoap)(this)).getBookBillStateAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<pts.getBookBillStateNewResponse> pts.PtsServiceTJSoap.getBookBillStateNewAsync(pts.getBookBillStateNewRequest request)
        {
            return base.Channel.getBookBillStateNewAsync(request);
        }
        
        public System.Threading.Tasks.Task<pts.getBookBillStateNewResponse> getBookBillStateNewAsync(string _posCode, string _bookBillId)
        {
            pts.getBookBillStateNewRequest inValue = new pts.getBookBillStateNewRequest();
            inValue.Body = new pts.getBookBillStateNewRequestBody();
            inValue.Body._posCode = _posCode;
            inValue.Body._bookBillId = _bookBillId;
            return ((pts.PtsServiceTJSoap)(this)).getBookBillStateNewAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<pts.getBookBillStateByGroupResponse> pts.PtsServiceTJSoap.getBookBillStateByGroupAsync(pts.getBookBillStateByGroupRequest request)
        {
            return base.Channel.getBookBillStateByGroupAsync(request);
        }
        
        public System.Threading.Tasks.Task<pts.getBookBillStateByGroupResponse> getBookBillStateByGroupAsync(string _posCode, string _bookBillId)
        {
            pts.getBookBillStateByGroupRequest inValue = new pts.getBookBillStateByGroupRequest();
            inValue.Body = new pts.getBookBillStateByGroupRequestBody();
            inValue.Body._posCode = _posCode;
            inValue.Body._bookBillId = _bookBillId;
            return ((pts.PtsServiceTJSoap)(this)).getBookBillStateByGroupAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<pts.addBookBillInfoResponse> pts.PtsServiceTJSoap.addBookBillInfoAsync(pts.addBookBillInfoRequest request)
        {
            return base.Channel.addBookBillInfoAsync(request);
        }
        
        public System.Threading.Tasks.Task<pts.addBookBillInfoResponse> addBookBillInfoAsync(string _posCode, string _getterName, string _getterPhone, string _getterId, string _bookBillId)
        {
            pts.addBookBillInfoRequest inValue = new pts.addBookBillInfoRequest();
            inValue.Body = new pts.addBookBillInfoRequestBody();
            inValue.Body._posCode = _posCode;
            inValue.Body._getterName = _getterName;
            inValue.Body._getterPhone = _getterPhone;
            inValue.Body._getterId = _getterId;
            inValue.Body._bookBillId = _bookBillId;
            return ((pts.PtsServiceTJSoap)(this)).addBookBillInfoAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<pts.addTicketInfoResponse> pts.PtsServiceTJSoap.addTicketInfoAsync(pts.addTicketInfoRequest request)
        {
            return base.Channel.addTicketInfoAsync(request);
        }
        
        public System.Threading.Tasks.Task<pts.addTicketInfoResponse> addTicketInfoAsync(string _posCode, string _userName, string _userId, string _bookBillId, string _ticketId)
        {
            pts.addTicketInfoRequest inValue = new pts.addTicketInfoRequest();
            inValue.Body = new pts.addTicketInfoRequestBody();
            inValue.Body._posCode = _posCode;
            inValue.Body._userName = _userName;
            inValue.Body._userId = _userId;
            inValue.Body._bookBillId = _bookBillId;
            inValue.Body._ticketId = _ticketId;
            return ((pts.PtsServiceTJSoap)(this)).addTicketInfoAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<pts.cancelBookBillResponse> pts.PtsServiceTJSoap.cancelBookBillAsync(pts.cancelBookBillRequest request)
        {
            return base.Channel.cancelBookBillAsync(request);
        }
        
        public System.Threading.Tasks.Task<pts.cancelBookBillResponse> cancelBookBillAsync(string _posCode, string _bookBillId)
        {
            pts.cancelBookBillRequest inValue = new pts.cancelBookBillRequest();
            inValue.Body = new pts.cancelBookBillRequestBody();
            inValue.Body._posCode = _posCode;
            inValue.Body._bookBillId = _bookBillId;
            return ((pts.PtsServiceTJSoap)(this)).cancelBookBillAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<pts.getBillListUserResponse> pts.PtsServiceTJSoap.getBillListUserAsync(pts.getBillListUserRequest request)
        {
            return base.Channel.getBillListUserAsync(request);
        }
        
        public System.Threading.Tasks.Task<pts.getBillListUserResponse> getBillListUserAsync(string _posCode, string _timeFrom, string _timeTo, string _billState, string _webUserId)
        {
            pts.getBillListUserRequest inValue = new pts.getBillListUserRequest();
            inValue.Body = new pts.getBillListUserRequestBody();
            inValue.Body._posCode = _posCode;
            inValue.Body._timeFrom = _timeFrom;
            inValue.Body._timeTo = _timeTo;
            inValue.Body._billState = _billState;
            inValue.Body._webUserId = _webUserId;
            return ((pts.PtsServiceTJSoap)(this)).getBillListUserAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<pts.getBillListTag1Response> pts.PtsServiceTJSoap.getBillListTag1Async(pts.getBillListTag1Request request)
        {
            return base.Channel.getBillListTag1Async(request);
        }
        
        public System.Threading.Tasks.Task<pts.getBillListTag1Response> getBillListTag1Async(string _posCode, string _timeFrom, string _timeTo, string _billState, string _tag)
        {
            pts.getBillListTag1Request inValue = new pts.getBillListTag1Request();
            inValue.Body = new pts.getBillListTag1RequestBody();
            inValue.Body._posCode = _posCode;
            inValue.Body._timeFrom = _timeFrom;
            inValue.Body._timeTo = _timeTo;
            inValue.Body._billState = _billState;
            inValue.Body._tag = _tag;
            return ((pts.PtsServiceTJSoap)(this)).getBillListTag1Async(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<pts.getBillListUserTotalResponse> pts.PtsServiceTJSoap.getBillListUserTotalAsync(pts.getBillListUserTotalRequest request)
        {
            return base.Channel.getBillListUserTotalAsync(request);
        }
        
        public System.Threading.Tasks.Task<pts.getBillListUserTotalResponse> getBillListUserTotalAsync(string _posCode, string _timeFrom, string _timeTo, string _billState, string _webUserId)
        {
            pts.getBillListUserTotalRequest inValue = new pts.getBillListUserTotalRequest();
            inValue.Body = new pts.getBillListUserTotalRequestBody();
            inValue.Body._posCode = _posCode;
            inValue.Body._timeFrom = _timeFrom;
            inValue.Body._timeTo = _timeTo;
            inValue.Body._billState = _billState;
            inValue.Body._webUserId = _webUserId;
            return ((pts.PtsServiceTJSoap)(this)).getBillListUserTotalAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<pts.getCarGradePriceListAllAgioResponse> pts.PtsServiceTJSoap.getCarGradePriceListAllAgioAsync(pts.getCarGradePriceListAllAgioRequest request)
        {
            return base.Channel.getCarGradePriceListAllAgioAsync(request);
        }
        
        public System.Threading.Tasks.Task<pts.getCarGradePriceListAllAgioResponse> getCarGradePriceListAllAgioAsync(string _posCode, string _planId)
        {
            pts.getCarGradePriceListAllAgioRequest inValue = new pts.getCarGradePriceListAllAgioRequest();
            inValue.Body = new pts.getCarGradePriceListAllAgioRequestBody();
            inValue.Body._posCode = _posCode;
            inValue.Body._planId = _planId;
            return ((pts.PtsServiceTJSoap)(this)).getCarGradePriceListAllAgioAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<pts.bookCarTicketAgioResponse> pts.PtsServiceTJSoap.bookCarTicketAgioAsync(pts.bookCarTicketAgioRequest request)
        {
            return base.Channel.bookCarTicketAgioAsync(request);
        }
        
        public System.Threading.Tasks.Task<pts.bookCarTicketAgioResponse> bookCarTicketAgioAsync(string _posCode, string _planId, string _carGradeId, string _carAllotType, string _carPriceId, string _cardProvinceId, string _carCardNumber, string _cargoId, string _ifEmpty, string _bookBillId, string _carPrice, string _ifAz)
        {
            pts.bookCarTicketAgioRequest inValue = new pts.bookCarTicketAgioRequest();
            inValue.Body = new pts.bookCarTicketAgioRequestBody();
            inValue.Body._posCode = _posCode;
            inValue.Body._planId = _planId;
            inValue.Body._carGradeId = _carGradeId;
            inValue.Body._carAllotType = _carAllotType;
            inValue.Body._carPriceId = _carPriceId;
            inValue.Body._cardProvinceId = _cardProvinceId;
            inValue.Body._carCardNumber = _carCardNumber;
            inValue.Body._cargoId = _cargoId;
            inValue.Body._ifEmpty = _ifEmpty;
            inValue.Body._bookBillId = _bookBillId;
            inValue.Body._carPrice = _carPrice;
            inValue.Body._ifAz = _ifAz;
            return ((pts.PtsServiceTJSoap)(this)).bookCarTicketAgioAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<pts.returnBookTicketResponse> pts.PtsServiceTJSoap.returnBookTicketAsync(pts.returnBookTicketRequest request)
        {
            return base.Channel.returnBookTicketAsync(request);
        }
        
        public System.Threading.Tasks.Task<pts.returnBookTicketResponse> returnBookTicketAsync(string _posCode, string _ticketId, string _bookBillId, string _returnType)
        {
            pts.returnBookTicketRequest inValue = new pts.returnBookTicketRequest();
            inValue.Body = new pts.returnBookTicketRequestBody();
            inValue.Body._posCode = _posCode;
            inValue.Body._ticketId = _ticketId;
            inValue.Body._bookBillId = _bookBillId;
            inValue.Body._returnType = _returnType;
            return ((pts.PtsServiceTJSoap)(this)).returnBookTicketAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<pts.returnBillResponse> pts.PtsServiceTJSoap.returnBillAsync(pts.returnBillRequest request)
        {
            return base.Channel.returnBillAsync(request);
        }
        
        public System.Threading.Tasks.Task<pts.returnBillResponse> returnBillAsync(string _posCode, string _bookBillId)
        {
            pts.returnBillRequest inValue = new pts.returnBillRequest();
            inValue.Body = new pts.returnBillRequestBody();
            inValue.Body._posCode = _posCode;
            inValue.Body._bookBillId = _bookBillId;
            return ((pts.PtsServiceTJSoap)(this)).returnBillAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<pts.checkReturnTicketResponse> pts.PtsServiceTJSoap.checkReturnTicketAsync(pts.checkReturnTicketRequest request)
        {
            return base.Channel.checkReturnTicketAsync(request);
        }
        
        public System.Threading.Tasks.Task<pts.checkReturnTicketResponse> checkReturnTicketAsync(string _posCode, string _ticketId)
        {
            pts.checkReturnTicketRequest inValue = new pts.checkReturnTicketRequest();
            inValue.Body = new pts.checkReturnTicketRequestBody();
            inValue.Body._posCode = _posCode;
            inValue.Body._ticketId = _ticketId;
            return ((pts.PtsServiceTJSoap)(this)).checkReturnTicketAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<pts.checkReturnCarTicketResponse> pts.PtsServiceTJSoap.checkReturnCarTicketAsync(pts.checkReturnCarTicketRequest request)
        {
            return base.Channel.checkReturnCarTicketAsync(request);
        }
        
        public System.Threading.Tasks.Task<pts.checkReturnCarTicketResponse> checkReturnCarTicketAsync(string _posCode, string _ticketId)
        {
            pts.checkReturnCarTicketRequest inValue = new pts.checkReturnCarTicketRequest();
            inValue.Body = new pts.checkReturnCarTicketRequestBody();
            inValue.Body._posCode = _posCode;
            inValue.Body._ticketId = _ticketId;
            return ((pts.PtsServiceTJSoap)(this)).checkReturnCarTicketAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<pts.setTag2Response> pts.PtsServiceTJSoap.setTag2Async(pts.setTag2Request request)
        {
            return base.Channel.setTag2Async(request);
        }
        
        public System.Threading.Tasks.Task<pts.setTag2Response> setTag2Async(string _posCode, string _bookBillId, string _tag2)
        {
            pts.setTag2Request inValue = new pts.setTag2Request();
            inValue.Body = new pts.setTag2RequestBody();
            inValue.Body._posCode = _posCode;
            inValue.Body._bookBillId = _bookBillId;
            inValue.Body._tag2 = _tag2;
            return ((pts.PtsServiceTJSoap)(this)).setTag2Async(inValue);
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
            if ((endpointConfiguration == EndpointConfiguration.PtsServiceTJSoap))
            {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                return result;
            }
            if ((endpointConfiguration == EndpointConfiguration.PtsServiceTJSoap12))
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
            if ((endpointConfiguration == EndpointConfiguration.PtsServiceTJSoap))
            {
                return new System.ServiceModel.EndpointAddress("http://39.100.237.7:9280/PtsServiceTJ.asmx");
            }
            if ((endpointConfiguration == EndpointConfiguration.PtsServiceTJSoap12))
            {
                return new System.ServiceModel.EndpointAddress("http://39.100.237.7:9280/PtsServiceTJ.asmx");
            }
            throw new System.InvalidOperationException(string.Format("找不到名称为“{0}”的终结点。", endpointConfiguration));
        }
        
        public enum EndpointConfiguration
        {
            
            PtsServiceTJSoap,
            
            PtsServiceTJSoap12,
        }
    }
}
