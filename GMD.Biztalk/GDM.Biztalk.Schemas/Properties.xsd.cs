namespace GDM.Biztalk.Schemas {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Property)]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"ProcessingState", @"ParentPCID", @"CaseRequestSwitch", @"RawMessageType", @"AzureMessageType", @"OpenOrderSwitch", @"OrderStatus", @"PriorityContext", @"SalesOrderNumber", @"AccountNumber", @"Source_TriggerMode", @"Source_ProcessingMode", @"Source_Channel", @"MessageType", @"IsResubmission"})]
    public sealed class Properties : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""http://OM.BizTalk.AzureFeeds.Schemas.Properties"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" targetNamespace=""https://OM.BizTalk.AzureFeeds.Schemas.Properties"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:annotation>
    <xs:appinfo>
      <b:schemaInfo schema_type=""property"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" />
    </xs:appinfo>
  </xs:annotation>
  <xs:element name=""ProcessingState"" type=""xs:string"">
    <xs:annotation>
      <xs:appinfo>
        <b:fieldInfo propertyGuid=""ed622d03-2cb4-4b44-92f5-82f64609bf3c"" rootTypeName=""ProcessingState"" propSchFieldBase=""MessageContextPropertyBase"" notes=""This is used to determine the state of the message"" />
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""ParentPCID"" type=""xs:string"">
    <xs:annotation>
      <xs:appinfo>
        <b:fieldInfo propertyGuid=""020aef1b-0b2a-4051-bbf6-23965a5b28bc"" propSchFieldBase=""MessageContextPropertyBase"" notes=""For source messages which are debatched this is used to store the original pcid prior to debatching."" />
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""CaseRequestSwitch"" type=""xs:string"">
    <xs:annotation>
      <xs:appinfo>
        <b:fieldInfo propertyGuid=""f4fce505-f0f7-4166-8f63-2d5a9b4a5ab6"" propSchFieldBase=""MessageContextPropertyBase"" notes=""Status of the Order Pending for case creation in SalesForce"" />
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""RawMessageType"" type=""xs:string"">
    <xs:annotation>
      <xs:appinfo>
        <b:fieldInfo propertyGuid=""1bf33b60-ba0d-4bdb-8ed0-6f9d4a1d250b"" propSchFieldBase=""MessageContextPropertyBase"" notes=""The message type &quot;RawContent&quot; is a dumb container. This property allows inner content type to be promoted."" />
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""AzureMessageType"" type=""xs:string"">
    <xs:annotation>
      <xs:appinfo>
        <b:fieldInfo propertyGuid=""7df33a03-4016-4023-8789-5baf86d25d69"" propSchFieldBase=""MessageContextPropertyBase"" />
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""OpenOrderSwitch"" type=""xs:string"">
    <xs:annotation>
      <xs:appinfo>
        <b:fieldInfo propertyGuid=""a6689716-94ac-4177-9ce1-fc411e7eb985"" notes=""Open order = if OrdAccount Number found in AccountFilter.txt file plus OrderSatus !=Billed/Payed "" propSchFieldBase=""MessageContextPropertyBase"" />
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""OrderStatus"" type=""xs:string"">
    <xs:annotation>
      <xs:appinfo>
        <b:fieldInfo propertyGuid=""a93083b4-46ef-4608-92b3-f2643a7765b8"" propSchFieldBase=""MessageContextPropertyBase"" />
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""PriorityContext"" type=""xs:string"">
    <xs:annotation>
      <xs:appinfo>
        <b:fieldInfo propertyGuid=""8aa466ae-5d81-4a2e-9990-6eb910721e28"" propSchFieldBase=""MessageContextPropertyBase"" notes=""This property is used to distinguish source messages that are deemed &quot;Online&quot; vs. &quot;Historical&quot; traffic so that it may be routed\prioritized accordingly."" />
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element default=""UNKNOWN"" name=""SalesOrderNumber"" type=""xs:string"">
    <xs:annotation>
      <xs:appinfo>
        <b:fieldInfo propertyGuid=""47c77860-a963-49f0-a7ea-939842ac2443"" propSchFieldBase=""MessageContextPropertyBase"" notes=""This is the sales order number originating from business data."" />
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""AccountNumber"" type=""xs:string"">
    <xs:annotation>
      <xs:appinfo>
        <b:fieldInfo propertyGuid=""3f3e6490-8785-4b0a-b1dc-53083d0dfca7"" propSchFieldBase=""MessageContextPropertyBase"" notes=""This is the account number originating from business data."" />
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""Source_TriggerMode"" type=""xs:string"">
    <xs:annotation>
      <xs:appinfo>
        <b:fieldInfo propertyGuid=""08d5e5fb-a127-448d-aa3c-333225a14f27"" propSchFieldBase=""MessageContextPropertyBase"" rootTypeName=""Source_TriggerMode"" notes=""This is used to indicate the intention of the source system as it pertains to the CRUD action of the data."" />
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""Source_ProcessingMode"" type=""xs:string"">
    <xs:annotation>
      <xs:appinfo>
        <b:fieldInfo propertyGuid=""a0fe1c84-0805-477f-8953-94b31f665718"" notes=""“B” for batch, “O” for online. This is processing context the source system produced the message, allowing for upstream to prioritize the traffic."" propSchFieldBase=""MessageContextPropertyBase"" />
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""Source_Channel"" type=""xs:string"">
    <xs:annotation>
      <xs:appinfo>
        <b:fieldInfo propertyGuid=""0b36b756-41ac-43fb-afd9-a67c192ff197"" propSchFieldBase=""MessageContextPropertyBase"" notes=""&quot;Online&quot; or &quot;Historical&quot;. Source system can provide messages through an online or a history channel. This is to track the origin of that message."" />
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""MessageType"" type=""xs:string"">
    <xs:annotation>
      <xs:appinfo>
        <b:fieldInfo propertyGuid=""16b593d2-9863-4fa5-ab6d-a4499e557d9b"" propSchFieldBase=""MessageContextPropertyBase"" notes=""This property is used to call out the logical message type. Since some BTS message types might be used in other contexts, this supercedes that."" />
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""IsResubmission"" type=""xs:string"">
    <xs:annotation>
      <xs:appinfo>
        <b:fieldInfo propertyGuid=""7b7f1e25-73f3-4050-a4af-78f03024ac97"" propSchFieldBase=""MessageContextPropertyBase"" />
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
</xs:schema>";
        
        public Properties() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [15];
                _RootElements[0] = "ProcessingState";
                _RootElements[1] = "ParentPCID";
                _RootElements[2] = "CaseRequestSwitch";
                _RootElements[3] = "RawMessageType";
                _RootElements[4] = "AzureMessageType";
                _RootElements[5] = "OpenOrderSwitch";
                _RootElements[6] = "OrderStatus";
                _RootElements[7] = "PriorityContext";
                _RootElements[8] = "SalesOrderNumber";
                _RootElements[9] = "AccountNumber";
                _RootElements[10] = "Source_TriggerMode";
                _RootElements[11] = "Source_ProcessingMode";
                _RootElements[12] = "Source_Channel";
                _RootElements[13] = "MessageType";
                _RootElements[14] = "IsResubmission";
                return _RootElements;
            }
        }
        
        protected override object RawSchema {
            get {
                return _rawSchema;
            }
            set {
                _rawSchema = value;
            }
        }
    }
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [System.SerializableAttribute()]
    [PropertyType(@"ProcessingState",@"https://OM.BizTalk.AzureFeeds.Schemas.Properties","string","System.String")]
    [PropertyGuidAttribute(@"ed622d03-2cb4-4b44-92f5-82f64609bf3c")]
    public sealed class ProcessingState : Microsoft.XLANGs.BaseTypes.MessageContextPropertyBase {
        
        [System.NonSerializedAttribute()]
        private static System.Xml.XmlQualifiedName _QName = new System.Xml.XmlQualifiedName(@"ProcessingState", @"https://OM.BizTalk.AzureFeeds.Schemas.Properties");
        
        private static string PropertyValueType {
            get {
                throw new System.NotSupportedException();
            }
        }
        
        public override System.Xml.XmlQualifiedName Name {
            get {
                return _QName;
            }
        }
        
        public override System.Type Type {
            get {
                return typeof(string);
            }
        }
    }
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [System.SerializableAttribute()]
    [PropertyType(@"ParentPCID",@"https://OM.BizTalk.AzureFeeds.Schemas.Properties","string","System.String")]
    [PropertyGuidAttribute(@"020aef1b-0b2a-4051-bbf6-23965a5b28bc")]
    public sealed class ParentPCID : Microsoft.XLANGs.BaseTypes.MessageContextPropertyBase {
        
        [System.NonSerializedAttribute()]
        private static System.Xml.XmlQualifiedName _QName = new System.Xml.XmlQualifiedName(@"ParentPCID", @"https://OM.BizTalk.AzureFeeds.Schemas.Properties");
        
        private static string PropertyValueType {
            get {
                throw new System.NotSupportedException();
            }
        }
        
        public override System.Xml.XmlQualifiedName Name {
            get {
                return _QName;
            }
        }
        
        public override System.Type Type {
            get {
                return typeof(string);
            }
        }
    }
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [System.SerializableAttribute()]
    [PropertyType(@"CaseRequestSwitch",@"https://OM.BizTalk.AzureFeeds.Schemas.Properties","string","System.String")]
    [PropertyGuidAttribute(@"f4fce505-f0f7-4166-8f63-2d5a9b4a5ab6")]
    public sealed class CaseRequestSwitch : Microsoft.XLANGs.BaseTypes.MessageContextPropertyBase {
        
        [System.NonSerializedAttribute()]
        private static System.Xml.XmlQualifiedName _QName = new System.Xml.XmlQualifiedName(@"CaseRequestSwitch", @"https://OM.BizTalk.AzureFeeds.Schemas.Properties");
        
        private static string PropertyValueType {
            get {
                throw new System.NotSupportedException();
            }
        }
        
        public override System.Xml.XmlQualifiedName Name {
            get {
                return _QName;
            }
        }
        
        public override System.Type Type {
            get {
                return typeof(string);
            }
        }
    }
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [System.SerializableAttribute()]
    [PropertyType(@"RawMessageType",@"https://OM.BizTalk.AzureFeeds.Schemas.Properties","string","System.String")]
    [PropertyGuidAttribute(@"1bf33b60-ba0d-4bdb-8ed0-6f9d4a1d250b")]
    public sealed class RawMessageType : Microsoft.XLANGs.BaseTypes.MessageContextPropertyBase {
        
        [System.NonSerializedAttribute()]
        private static System.Xml.XmlQualifiedName _QName = new System.Xml.XmlQualifiedName(@"RawMessageType", @"https://OM.BizTalk.AzureFeeds.Schemas.Properties");
        
        private static string PropertyValueType {
            get {
                throw new System.NotSupportedException();
            }
        }
        
        public override System.Xml.XmlQualifiedName Name {
            get {
                return _QName;
            }
        }
        
        public override System.Type Type {
            get {
                return typeof(string);
            }
        }
    }
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [System.SerializableAttribute()]
    [PropertyType(@"AzureMessageType",@"https://OM.BizTalk.AzureFeeds.Schemas.Properties","string","System.String")]
    [PropertyGuidAttribute(@"7df33a03-4016-4023-8789-5baf86d25d69")]
    public sealed class AzureMessageType : Microsoft.XLANGs.BaseTypes.MessageContextPropertyBase {
        
        [System.NonSerializedAttribute()]
        private static System.Xml.XmlQualifiedName _QName = new System.Xml.XmlQualifiedName(@"AzureMessageType", @"https://OM.BizTalk.AzureFeeds.Schemas.Properties");
        
        private static string PropertyValueType {
            get {
                throw new System.NotSupportedException();
            }
        }
        
        public override System.Xml.XmlQualifiedName Name {
            get {
                return _QName;
            }
        }
        
        public override System.Type Type {
            get {
                return typeof(string);
            }
        }
    }
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [System.SerializableAttribute()]
    [PropertyType(@"OpenOrderSwitch",@"https://OM.BizTalk.AzureFeeds.Schemas.Properties","string","System.String")]
    [PropertyGuidAttribute(@"a6689716-94ac-4177-9ce1-fc411e7eb985")]
    public sealed class OpenOrderSwitch : Microsoft.XLANGs.BaseTypes.MessageContextPropertyBase {
        
        [System.NonSerializedAttribute()]
        private static System.Xml.XmlQualifiedName _QName = new System.Xml.XmlQualifiedName(@"OpenOrderSwitch", @"https://OM.BizTalk.AzureFeeds.Schemas.Properties");
        
        private static string PropertyValueType {
            get {
                throw new System.NotSupportedException();
            }
        }
        
        public override System.Xml.XmlQualifiedName Name {
            get {
                return _QName;
            }
        }
        
        public override System.Type Type {
            get {
                return typeof(string);
            }
        }
    }
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [System.SerializableAttribute()]
    [PropertyType(@"OrderStatus",@"https://OM.BizTalk.AzureFeeds.Schemas.Properties","string","System.String")]
    [PropertyGuidAttribute(@"a93083b4-46ef-4608-92b3-f2643a7765b8")]
    public sealed class OrderStatus : Microsoft.XLANGs.BaseTypes.MessageContextPropertyBase {
        
        [System.NonSerializedAttribute()]
        private static System.Xml.XmlQualifiedName _QName = new System.Xml.XmlQualifiedName(@"OrderStatus", @"https://OM.BizTalk.AzureFeeds.Schemas.Properties");
        
        private static string PropertyValueType {
            get {
                throw new System.NotSupportedException();
            }
        }
        
        public override System.Xml.XmlQualifiedName Name {
            get {
                return _QName;
            }
        }
        
        public override System.Type Type {
            get {
                return typeof(string);
            }
        }
    }
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [System.SerializableAttribute()]
    [PropertyType(@"PriorityContext",@"https://OM.BizTalk.AzureFeeds.Schemas.Properties","string","System.String")]
    [PropertyGuidAttribute(@"8aa466ae-5d81-4a2e-9990-6eb910721e28")]
    public sealed class PriorityContext : Microsoft.XLANGs.BaseTypes.MessageContextPropertyBase {
        
        [System.NonSerializedAttribute()]
        private static System.Xml.XmlQualifiedName _QName = new System.Xml.XmlQualifiedName(@"PriorityContext", @"https://OM.BizTalk.AzureFeeds.Schemas.Properties");
        
        private static string PropertyValueType {
            get {
                throw new System.NotSupportedException();
            }
        }
        
        public override System.Xml.XmlQualifiedName Name {
            get {
                return _QName;
            }
        }
        
        public override System.Type Type {
            get {
                return typeof(string);
            }
        }
    }
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [System.SerializableAttribute()]
    [PropertyType(@"SalesOrderNumber",@"https://OM.BizTalk.AzureFeeds.Schemas.Properties","string","System.String")]
    [PropertyGuidAttribute(@"47c77860-a963-49f0-a7ea-939842ac2443")]
    public sealed class SalesOrderNumber : Microsoft.XLANGs.BaseTypes.MessageContextPropertyBase {
        
        [System.NonSerializedAttribute()]
        private static System.Xml.XmlQualifiedName _QName = new System.Xml.XmlQualifiedName(@"SalesOrderNumber", @"https://OM.BizTalk.AzureFeeds.Schemas.Properties");
        
        private static string PropertyValueType {
            get {
                throw new System.NotSupportedException();
            }
        }
        
        public override System.Xml.XmlQualifiedName Name {
            get {
                return _QName;
            }
        }
        
        public override System.Type Type {
            get {
                return typeof(string);
            }
        }
    }
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [System.SerializableAttribute()]
    [PropertyType(@"AccountNumber",@"https://OM.BizTalk.AzureFeeds.Schemas.Properties","string","System.String")]
    [PropertyGuidAttribute(@"3f3e6490-8785-4b0a-b1dc-53083d0dfca7")]
    public sealed class AccountNumber : Microsoft.XLANGs.BaseTypes.MessageContextPropertyBase {
        
        [System.NonSerializedAttribute()]
        private static System.Xml.XmlQualifiedName _QName = new System.Xml.XmlQualifiedName(@"AccountNumber", @"https://OM.BizTalk.AzureFeeds.Schemas.Properties");
        
        private static string PropertyValueType {
            get {
                throw new System.NotSupportedException();
            }
        }
        
        public override System.Xml.XmlQualifiedName Name {
            get {
                return _QName;
            }
        }
        
        public override System.Type Type {
            get {
                return typeof(string);
            }
        }
    }
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [System.SerializableAttribute()]
    [PropertyType(@"Source_TriggerMode",@"https://OM.BizTalk.AzureFeeds.Schemas.Properties","string","System.String")]
    [PropertyGuidAttribute(@"08d5e5fb-a127-448d-aa3c-333225a14f27")]
    public sealed class Source_TriggerMode : Microsoft.XLANGs.BaseTypes.MessageContextPropertyBase {
        
        [System.NonSerializedAttribute()]
        private static System.Xml.XmlQualifiedName _QName = new System.Xml.XmlQualifiedName(@"Source_TriggerMode", @"https://OM.BizTalk.AzureFeeds.Schemas.Properties");
        
        private static string PropertyValueType {
            get {
                throw new System.NotSupportedException();
            }
        }
        
        public override System.Xml.XmlQualifiedName Name {
            get {
                return _QName;
            }
        }
        
        public override System.Type Type {
            get {
                return typeof(string);
            }
        }
    }
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [System.SerializableAttribute()]
    [PropertyType(@"Source_ProcessingMode",@"https://OM.BizTalk.AzureFeeds.Schemas.Properties","string","System.String")]
    [PropertyGuidAttribute(@"a0fe1c84-0805-477f-8953-94b31f665718")]
    public sealed class Source_ProcessingMode : Microsoft.XLANGs.BaseTypes.MessageContextPropertyBase {
        
        [System.NonSerializedAttribute()]
        private static System.Xml.XmlQualifiedName _QName = new System.Xml.XmlQualifiedName(@"Source_ProcessingMode", @"https://OM.BizTalk.AzureFeeds.Schemas.Properties");
        
        private static string PropertyValueType {
            get {
                throw new System.NotSupportedException();
            }
        }
        
        public override System.Xml.XmlQualifiedName Name {
            get {
                return _QName;
            }
        }
        
        public override System.Type Type {
            get {
                return typeof(string);
            }
        }
    }
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [System.SerializableAttribute()]
    [PropertyType(@"Source_Channel",@"https://OM.BizTalk.AzureFeeds.Schemas.Properties","string","System.String")]
    [PropertyGuidAttribute(@"0b36b756-41ac-43fb-afd9-a67c192ff197")]
    public sealed class Source_Channel : Microsoft.XLANGs.BaseTypes.MessageContextPropertyBase {
        
        [System.NonSerializedAttribute()]
        private static System.Xml.XmlQualifiedName _QName = new System.Xml.XmlQualifiedName(@"Source_Channel", @"https://OM.BizTalk.AzureFeeds.Schemas.Properties");
        
        private static string PropertyValueType {
            get {
                throw new System.NotSupportedException();
            }
        }
        
        public override System.Xml.XmlQualifiedName Name {
            get {
                return _QName;
            }
        }
        
        public override System.Type Type {
            get {
                return typeof(string);
            }
        }
    }
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [System.SerializableAttribute()]
    [PropertyType(@"MessageType",@"https://OM.BizTalk.AzureFeeds.Schemas.Properties","string","System.String")]
    [PropertyGuidAttribute(@"16b593d2-9863-4fa5-ab6d-a4499e557d9b")]
    public sealed class MessageType : Microsoft.XLANGs.BaseTypes.MessageContextPropertyBase {
        
        [System.NonSerializedAttribute()]
        private static System.Xml.XmlQualifiedName _QName = new System.Xml.XmlQualifiedName(@"MessageType", @"https://OM.BizTalk.AzureFeeds.Schemas.Properties");
        
        private static string PropertyValueType {
            get {
                throw new System.NotSupportedException();
            }
        }
        
        public override System.Xml.XmlQualifiedName Name {
            get {
                return _QName;
            }
        }
        
        public override System.Type Type {
            get {
                return typeof(string);
            }
        }
    }
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [System.SerializableAttribute()]
    [PropertyType(@"IsResubmission",@"https://OM.BizTalk.AzureFeeds.Schemas.Properties","string","System.String")]
    [PropertyGuidAttribute(@"7b7f1e25-73f3-4050-a4af-78f03024ac97")]
    public sealed class IsResubmission : Microsoft.XLANGs.BaseTypes.MessageContextPropertyBase {
        
        [System.NonSerializedAttribute()]
        private static System.Xml.XmlQualifiedName _QName = new System.Xml.XmlQualifiedName(@"IsResubmission", @"https://OM.BizTalk.AzureFeeds.Schemas.Properties");
        
        private static string PropertyValueType {
            get {
                throw new System.NotSupportedException();
            }
        }
        
        public override System.Xml.XmlQualifiedName Name {
            get {
                return _QName;
            }
        }
        
        public override System.Type Type {
            get {
                return typeof(string);
            }
        }
    }
}
