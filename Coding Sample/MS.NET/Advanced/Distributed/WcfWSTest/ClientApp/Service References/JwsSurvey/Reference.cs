﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClientApp.JwsSurvey {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://survey/", ConfigurationName="JwsSurvey.Feedback")]
    public interface Feedback {
        
        // CODEGEN: Parameter 'return' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://survey/Feedback/ReadFeedbackRequest", ReplyAction="http://survey/Feedback/ReadFeedbackResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        ClientApp.JwsSurvey.ReadFeedbackResponse ReadFeedback(ClientApp.JwsSurvey.ReadFeedbackRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://survey/Feedback/ReadFeedbackRequest", ReplyAction="http://survey/Feedback/ReadFeedbackResponse")]
        System.Threading.Tasks.Task<ClientApp.JwsSurvey.ReadFeedbackResponse> ReadFeedbackAsync(ClientApp.JwsSurvey.ReadFeedbackRequest request);
        
        // CODEGEN: Parameter 'return' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://survey/Feedback/WriteFeedbackRequest", ReplyAction="http://survey/Feedback/WriteFeedbackResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        ClientApp.JwsSurvey.WriteFeedbackResponse WriteFeedback(ClientApp.JwsSurvey.WriteFeedbackRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://survey/Feedback/WriteFeedbackRequest", ReplyAction="http://survey/Feedback/WriteFeedbackResponse")]
        System.Threading.Tasks.Task<ClientApp.JwsSurvey.WriteFeedbackResponse> WriteFeedbackAsync(ClientApp.JwsSurvey.WriteFeedbackRequest request);
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.81.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://survey/")]
    public partial class FeedbackInfo : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string fromField;
        
        private string commentField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string From {
            get {
                return this.fromField;
            }
            set {
                this.fromField = value;
                this.RaisePropertyChanged("From");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public string Comment {
            get {
                return this.commentField;
            }
            set {
                this.commentField = value;
                this.RaisePropertyChanged("Comment");
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="ReadFeedback", WrapperNamespace="http://survey/", IsWrapped=true)]
    public partial class ReadFeedbackRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://survey/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string arg0;
        
        public ReadFeedbackRequest() {
        }
        
        public ReadFeedbackRequest(string arg0) {
            this.arg0 = arg0;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="ReadFeedbackResponse", WrapperNamespace="http://survey/", IsWrapped=true)]
    public partial class ReadFeedbackResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://survey/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public ClientApp.JwsSurvey.FeedbackInfo @return;
        
        public ReadFeedbackResponse() {
        }
        
        public ReadFeedbackResponse(ClientApp.JwsSurvey.FeedbackInfo @return) {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="WriteFeedback", WrapperNamespace="http://survey/", IsWrapped=true)]
    public partial class WriteFeedbackRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://survey/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public ClientApp.JwsSurvey.FeedbackInfo arg0;
        
        public WriteFeedbackRequest() {
        }
        
        public WriteFeedbackRequest(ClientApp.JwsSurvey.FeedbackInfo arg0) {
            this.arg0 = arg0;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="WriteFeedbackResponse", WrapperNamespace="http://survey/", IsWrapped=true)]
    public partial class WriteFeedbackResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://survey/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string @return;
        
        public WriteFeedbackResponse() {
        }
        
        public WriteFeedbackResponse(string @return) {
            this.@return = @return;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface FeedbackChannel : ClientApp.JwsSurvey.Feedback, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class FeedbackClient : System.ServiceModel.ClientBase<ClientApp.JwsSurvey.Feedback>, ClientApp.JwsSurvey.Feedback {
        
        public FeedbackClient() {
        }
        
        public FeedbackClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public FeedbackClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public FeedbackClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public FeedbackClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ClientApp.JwsSurvey.ReadFeedbackResponse ClientApp.JwsSurvey.Feedback.ReadFeedback(ClientApp.JwsSurvey.ReadFeedbackRequest request) {
            return base.Channel.ReadFeedback(request);
        }
        
        public ClientApp.JwsSurvey.FeedbackInfo ReadFeedback(string arg0) {
            ClientApp.JwsSurvey.ReadFeedbackRequest inValue = new ClientApp.JwsSurvey.ReadFeedbackRequest();
            inValue.arg0 = arg0;
            ClientApp.JwsSurvey.ReadFeedbackResponse retVal = ((ClientApp.JwsSurvey.Feedback)(this)).ReadFeedback(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ClientApp.JwsSurvey.ReadFeedbackResponse> ClientApp.JwsSurvey.Feedback.ReadFeedbackAsync(ClientApp.JwsSurvey.ReadFeedbackRequest request) {
            return base.Channel.ReadFeedbackAsync(request);
        }
        
        public System.Threading.Tasks.Task<ClientApp.JwsSurvey.ReadFeedbackResponse> ReadFeedbackAsync(string arg0) {
            ClientApp.JwsSurvey.ReadFeedbackRequest inValue = new ClientApp.JwsSurvey.ReadFeedbackRequest();
            inValue.arg0 = arg0;
            return ((ClientApp.JwsSurvey.Feedback)(this)).ReadFeedbackAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ClientApp.JwsSurvey.WriteFeedbackResponse ClientApp.JwsSurvey.Feedback.WriteFeedback(ClientApp.JwsSurvey.WriteFeedbackRequest request) {
            return base.Channel.WriteFeedback(request);
        }
        
        public string WriteFeedback(ClientApp.JwsSurvey.FeedbackInfo arg0) {
            ClientApp.JwsSurvey.WriteFeedbackRequest inValue = new ClientApp.JwsSurvey.WriteFeedbackRequest();
            inValue.arg0 = arg0;
            ClientApp.JwsSurvey.WriteFeedbackResponse retVal = ((ClientApp.JwsSurvey.Feedback)(this)).WriteFeedback(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ClientApp.JwsSurvey.WriteFeedbackResponse> ClientApp.JwsSurvey.Feedback.WriteFeedbackAsync(ClientApp.JwsSurvey.WriteFeedbackRequest request) {
            return base.Channel.WriteFeedbackAsync(request);
        }
        
        public System.Threading.Tasks.Task<ClientApp.JwsSurvey.WriteFeedbackResponse> WriteFeedbackAsync(ClientApp.JwsSurvey.FeedbackInfo arg0) {
            ClientApp.JwsSurvey.WriteFeedbackRequest inValue = new ClientApp.JwsSurvey.WriteFeedbackRequest();
            inValue.arg0 = arg0;
            return ((ClientApp.JwsSurvey.Feedback)(this)).WriteFeedbackAsync(inValue);
        }
    }
}
