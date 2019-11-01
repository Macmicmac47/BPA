namespace GDM.Biztalk.Schemas {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Microsoft.XLANGs.BaseTypes.PropertyAttribute(typeof(global::GDM.Biztalk.Schemas.CaseRequestSwitch), XPath = @"/*[local-name()='SalesOrder' and namespace-uri()='http://OM.BizTalk.AzureFeeds.Schemas.Canonicals_V1']/*[local-name()='Key' and namespace-uri()='']/*[local-name()='CaseRequestSwitch' and namespace-uri()='']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.PropertyAttribute(typeof(global::GDM.Biztalk.Schemas.Source_ProcessingMode), XPath = @"/*[local-name()='SalesOrder' and namespace-uri()='http://OM.BizTalk.AzureFeeds.Schemas.Canonicals_V1']/*[local-name()='Key' and namespace-uri()='']/*[local-name()='ProcessMode' and namespace-uri()='']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.PropertyAttribute(typeof(global::GDM.Biztalk.Schemas.OrderStatus), XPath = @"/*[local-name()='SalesOrder' and namespace-uri()='http://OM.BizTalk.AzureFeeds.Schemas.Canonicals_V1']/*[local-name()='Header' and namespace-uri()='']/*[local-name()='OrderStatus' and namespace-uri()='']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.PropertyAttribute(typeof(global::GDM.Biztalk.Schemas.SalesOrderNumber), XPath = @"/*[local-name()='SalesOrder' and namespace-uri()='http://OM.BizTalk.AzureFeeds.Schemas.Canonicals_V1']/*[local-name()='Key' and namespace-uri()='']/*[local-name()='SONumber' and namespace-uri()='']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.PropertyAttribute(typeof(global::GDM.Biztalk.Schemas.AccountNumber), XPath = @"/*[local-name()='SalesOrder' and namespace-uri()='http://OM.BizTalk.AzureFeeds.Schemas.Canonicals_V1']/*[local-name()='Header' and namespace-uri()='']/*[local-name()='AccountNumber' and namespace-uri()='']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.PropertyAttribute(typeof(global::GDM.Biztalk.Schemas.Source_TriggerMode), XPath = @"/*[local-name()='SalesOrder' and namespace-uri()='http://OM.BizTalk.AzureFeeds.Schemas.Canonicals_V1']/*[local-name()='Key' and namespace-uri()='']/*[local-name()='TriggerMode' and namespace-uri()='']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.PropertyAttribute(typeof(global::GDM.Biztalk.Schemas.Source_ProcessingMode), XPath = @"/*[local-name()='InventoryStatus' and namespace-uri()='http://OM.BizTalk.AzureFeeds.Schemas.Canonicals_V1']/*[local-name()='ProcessMode' and namespace-uri()='']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.PropertyAttribute(typeof(global::GDM.Biztalk.Schemas.Source_ProcessingMode), XPath = @"/*[local-name()='InventoryStatusPONote' and namespace-uri()='http://OM.BizTalk.AzureFeeds.Schemas.Canonicals_V1']/*[local-name()='ProcessMode' and namespace-uri()='']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.PropertyAttribute(typeof(global::GDM.Biztalk.Schemas.RawMessageType), XPath = @"/*[local-name()='RawContent' and namespace-uri()='http://OM.BizTalk.AzureFeeds.Schemas.Canonicals_V1']/@*[local-name()='MessageType' and namespace-uri()='']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.PropertyAttribute(typeof(global::GDM.Biztalk.Schemas.Source_ProcessingMode), XPath = @"/*[local-name()='InventoryStatusPO' and namespace-uri()='http://OM.BizTalk.AzureFeeds.Schemas.Canonicals_V1']/*[local-name()='ProcessMode' and namespace-uri()='']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.PropertyAttribute(typeof(global::GDM.Biztalk.Schemas.AzureMessageType), XPath = @"/*[local-name()='AzureMessageOut' and namespace-uri()='http://OM.BizTalk.AzureFeeds.Schemas.Canonicals_V1']/*[local-name()='MessageType' and namespace-uri()='']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.PropertyAttribute(typeof(global::GDM.Biztalk.Schemas.Source_ProcessingMode), XPath = @"/*[local-name()='InventoryPO' and namespace-uri()='http://OM.BizTalk.AzureFeeds.Schemas.Canonicals_V1']/*[local-name()='ProcessMode' and namespace-uri()='']", XsdType = @"string")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"SalesOrder", @"InventoryStatus", @"FeedBase", @"InventoryStatusPONote", @"RawContent", @"InventoryStatusPO", @"PendingSalesOrderCaseResult", @"BackorderLineNotes", @"AzureMessageOut", @"DCProductNotes", @"SalesOrdeLineComments", @"CustomerSubstitution", @"InventoryPO", @"AccountSets", @"AccountSetsLookup"})]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"GDM.Biztalk.Schemas.Properties", typeof(global::GDM.Biztalk.Schemas.Properties))]
    public sealed class Canonicals_V1 : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""http://OM.BizTalk.AzureFeeds.Schemas.Canonicals_V1"" xmlns:ns1=""https://OM.BizTalk.AzureFeeds.Schemas.PropertySchema"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" xmlns:ns0=""https://OM.BizTalk.AzureFeeds.Schemas.Properties"" targetNamespace=""http://OM.BizTalk.AzureFeeds.Schemas.Canonicals_V1"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:annotation>
    <xs:appinfo>
      <b:imports>
        <b:namespace prefix=""ns0"" uri=""https://OM.BizTalk.AzureFeeds.Schemas.Properties"" location=""GDM.Biztalk.Schemas.Properties"" />
      </b:imports>
    </xs:appinfo>
  </xs:annotation>
  <xs:element name=""SalesOrder"" type=""SalesOrderType"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo rootTypeName=""SalesOrder"" />
        <b:properties>
          <b:property name=""ns0:CaseRequestSwitch"" xpath=""/*[local-name()='SalesOrder' and namespace-uri()='http://OM.BizTalk.AzureFeeds.Schemas.Canonicals_V1']/*[local-name()='Key' and namespace-uri()='']/*[local-name()='CaseRequestSwitch' and namespace-uri()='']"" />
          <b:property name=""ns0:Source_ProcessingMode"" xpath=""/*[local-name()='SalesOrder' and namespace-uri()='http://OM.BizTalk.AzureFeeds.Schemas.Canonicals_V1']/*[local-name()='Key' and namespace-uri()='']/*[local-name()='ProcessMode' and namespace-uri()='']"" />
          <b:property name=""ns0:OrderStatus"" xpath=""/*[local-name()='SalesOrder' and namespace-uri()='http://OM.BizTalk.AzureFeeds.Schemas.Canonicals_V1']/*[local-name()='Header' and namespace-uri()='']/*[local-name()='OrderStatus' and namespace-uri()='']"" />
          <b:property name=""ns0:SalesOrderNumber"" xpath=""/*[local-name()='SalesOrder' and namespace-uri()='http://OM.BizTalk.AzureFeeds.Schemas.Canonicals_V1']/*[local-name()='Key' and namespace-uri()='']/*[local-name()='SONumber' and namespace-uri()='']"" />
          <b:property name=""ns0:AccountNumber"" xpath=""/*[local-name()='SalesOrder' and namespace-uri()='http://OM.BizTalk.AzureFeeds.Schemas.Canonicals_V1']/*[local-name()='Header' and namespace-uri()='']/*[local-name()='AccountNumber' and namespace-uri()='']"" />
          <b:property name=""ns0:Source_TriggerMode"" xpath=""/*[local-name()='SalesOrder' and namespace-uri()='http://OM.BizTalk.AzureFeeds.Schemas.Canonicals_V1']/*[local-name()='Key' and namespace-uri()='']/*[local-name()='TriggerMode' and namespace-uri()='']"" />
        </b:properties>
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:complexType name=""FeedBaseType"">
    <xs:sequence>
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""PrimaryCorrelationId"" type=""xs:string"">
        <xs:annotation>
          <xs:appinfo>
            <b:fieldInfo notes=""Used for integration tracability"" />
          </xs:appinfo>
        </xs:annotation>
      </xs:element>
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""SourceActionDateTimeUTC"" type=""xs:dateTime"">
        <xs:annotation>
          <xs:appinfo>
            <b:fieldInfo notes=""The UTC datetime the action occured within the source system"" />
          </xs:appinfo>
        </xs:annotation>
      </xs:element>
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""SourceCRUDIntention"">
        <xs:annotation>
          <xs:appinfo>
            <b:fieldInfo notes=""Indicates the CRUD intention of the data from the source system."" />
          </xs:appinfo>
        </xs:annotation>
        <xs:simpleType>
          <xs:restriction base=""xs:string"">
            <xs:enumeration value=""Insert"" />
            <xs:enumeration value=""Update"" />
            <xs:enumeration value=""Upsert"" />
            <xs:enumeration value=""Delete"" />
            <xs:enumeration value=""Deactivate"" />
            <xs:enumeration value=""Unknown"" />
          </xs:restriction>
        </xs:simpleType>
      </xs:element>
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""SourceSystemName"" type=""xs:string"">
        <xs:annotation>
          <xs:appinfo>
            <b:fieldInfo notes=""The name of the system the data sourced from"" />
          </xs:appinfo>
        </xs:annotation>
      </xs:element>
      <xs:element name=""SourceSystemDataId"" type=""xs:string"">
        <xs:annotation>
          <xs:appinfo>
            <b:fieldInfo notes=""A meaningful id for tracability back to the source system"" />
          </xs:appinfo>
        </xs:annotation>
      </xs:element>
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""SalesOrderHeaderType"">
    <xs:sequence>
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""Send810"" type=""xs:string"" />
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""AllowBackOrder"" type=""xs:string"" />
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""Attention"" type=""xs:string"" />
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""AccountNumber"" type=""xs:string"" />
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""IsCreditMemo"" type=""xs:boolean"" />
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""CreditReasonCode"" type=""xs:string"" />
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""CreditType"" type=""xs:string"" />
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""Currency"" type=""xs:string"" />
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""CustomerPONumber"" type=""xs:string"" />
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""DC"" type=""xs:string"" />
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""DeliveryDescription"" type=""xs:string"" />
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""OrderStatus"" type=""xs:string"" />
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""DeliveryRoute"" type=""xs:string"" />
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""DropShipIBTReasonCode"" type=""xs:string"" />
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""EntryDate"" type=""xs:dateTime"" />
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""EntryMethod"" type=""xs:string"" />
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""ExtendedType"" type=""xs:string"" />
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""FreightCode"" type=""xs:string"" />
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""FreightAmount"" type=""xs:decimal"" />
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""FromDC"" type=""xs:string"" />
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""HandlingFee"" type=""xs:string"" />
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""InvoiceNumber"" type=""xs:string"" />
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""ISN"" type=""xs:string"" />
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""MasterSONumber"" type=""xs:string"" />
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""MinOrderFee"" type=""xs:decimal"" />
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""NewOrderFlag"" type=""xs:string"" />
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""NumberOfLines"" type=""xs:string"" />
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""CompanyID"" type=""xs:string"" />
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""OrderMethod"" type=""xs:string"" />
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""OMOrderSubmitSource"" type=""xs:string"" />
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""OrderType"" type=""xs:string"" />
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""PaymentTerms"" type=""xs:string"" />
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""Priority"" type=""xs:string"" />
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""PromiseDate"" type=""xs:dateTime"" />
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""ReleaseDate"" type=""xs:dateTime"" />
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""ReqDate"" type=""xs:dateTime"" />
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""ReqNumber"" type=""xs:string"" />
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""SONumber"" type=""xs:string"" />
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""SalesTaxAmount"" type=""xs:decimal"" />
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""SalesTaxPercent"" type=""xs:decimal"" />
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""ShipDate"" type=""xs:dateTime"" />
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""ShipNumber"" type=""xs:string"" />
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""ShipVia"" type=""xs:string"" />
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""SpecialInstructions"" type=""xs:string"" />
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""TotalSales"" type=""xs:decimal"" />
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""DistNumber"" type=""xs:string"" />
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""ShipTo"" type=""xs:string"" />
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""ErrorCodes"" type=""xs:string"" />
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""CustId"" type=""xs:string"" />
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""BillTo"" type=""xs:string"" />
      <xs:element name=""ContractPricing"" type=""xs:boolean"" />
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""InvoiceDate"" type=""xs:dateTime"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""SalesOrderLinesType"">
    <xs:sequence>
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""Line"" type=""SalesOrderLineType"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""SalesOrderType"">
    <xs:complexContent mixed=""false"">
      <xs:extension base=""FeedBaseType"">
        <xs:sequence>
          <xs:element minOccurs=""1"" maxOccurs=""1"" name=""Key"" type=""SalesOrderKeyType"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""Header"" type=""SalesOrderHeaderType"">
            <xs:annotation>
              <xs:appinfo>
                <b:recordInfo notes=""The header portion of the Sales Order"" />
              </xs:appinfo>
            </xs:annotation>
          </xs:element>
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""Lines"" type=""SalesOrderLinesType"" />
          <xs:element name=""SpecialInstructions"" type=""SalesOrderInstructionsType"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""DeliveryInstructions"" type=""SalesOrderInstructionsType"" />
          <xs:element name=""Errors"" type=""SalesOrderLineErrorsType"" />
        </xs:sequence>
      </xs:extension>
    </xs:complexContent>
  </xs:complexType>
  <xs:complexType name=""SalesOrderLineType"">
    <xs:sequence>
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""ApplyFee"" type=""xs:decimal"" />
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""QtyBOBase"" type=""xs:int"" />
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""UOMBaseFull"" type=""xs:string"" />
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""QtyOrderBase"" type=""xs:int"" />
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""QtyShippedBase"" type=""xs:int"" />
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""UnitCostBase"" type=""xs:decimal"" />
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""UnitPriceBase"" type=""xs:decimal"" />
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""BreakBulkUOM"" type=""xs:string"" />
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""BreakFee"" type=""xs:decimal"" />
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""CatalogNumber"" type=""xs:string"" />
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""CommentText"" type=""xs:string"" />
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""Currency"" type=""xs:string"" />
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""QtyBOCust"" type=""xs:string"" />
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""UOMCustFull"" type=""xs:string"" />
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""LineNumberCust"" type=""xs:string"" />
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""QtyOrderCust"" type=""xs:string"" />
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""CustomerProductNumber"" type=""xs:string"" />
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""QtyShippedCust"" type=""xs:int"" />
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""CustTotalPrice"" type=""xs:decimal"" />
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""UnitPriceCust"" type=""xs:decimal"" />
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""UOMCust"" type=""xs:string"" />
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""DC"" type=""xs:string"" />
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""ETA"" type=""xs:dateTime"" />
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""DropShipIBTPORtdQty"" type=""xs:int"" />
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""DropShipIBTPOLineNumber"" type=""xs:string"" />
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""DropShipIBTPONumber"" type=""xs:string"" />
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""DropShipIBTPOStatus"" type=""xs:string"" />
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""ItemType"" type=""xs:string"" />
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""LabelFee"" type=""xs:decimal"" />
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""LineComments"" type=""xs:string"" />
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""LineEntryDate"" type=""xs:dateTime"" />
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""LineSource"" type=""xs:string"" />
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""LineStatus"" type=""xs:string"" />
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""LineType"" type=""xs:string"" />
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""LineNumberOM"" type=""xs:string"" />
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""ProductNumber"" type=""xs:string"" />
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""PriceFromCustomer"" type=""xs:decimal"" />
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""ProductDescription"" type=""xs:string"" />
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""PromiseDate"" type=""xs:dateTime"" />
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""RejectReason"" type=""xs:string"" />
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""RequiredDate"" type=""xs:dateTime"" />
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""SalesOrderNumber"" type=""xs:string"" />
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""ServiceFee"" type=""xs:decimal"" />
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""ShipQuantity"" type=""xs:string"" />
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""Status"" type=""xs:string"" />
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""TradeDiscount"" type=""xs:decimal"" />
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""VendorNumber"" type=""xs:string"" />
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""InventoryIndicator"" type=""xs:string"" />
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""SlowMovingInventorySw"" type=""xs:string"" />
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""DropShipOrigOrderQty"" type=""xs:int"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""SalesOrderKeyType"">
    <xs:sequence>
      <xs:element minOccurs=""1"" maxOccurs=""1"" name=""EntryDate"" type=""xs:dateTime"" />
      <xs:element minOccurs=""1"" maxOccurs=""1"" name=""SONumber"" type=""xs:string"" />
      <xs:element minOccurs=""1"" maxOccurs=""1"" name=""ShipNumber"" type=""xs:string"" />
      <xs:element minOccurs=""1"" maxOccurs=""1"" name=""DistNumber"" type=""xs:string"" />
      <xs:element minOccurs=""1"" maxOccurs=""1"" name=""DC"" type=""xs:string"" />
      <xs:element minOccurs=""1"" maxOccurs=""1"" name=""TriggerType"" type=""xs:string"" />
      <xs:element minOccurs=""1"" maxOccurs=""1"" name=""TriggerMode"" type=""xs:string"" />
      <xs:element minOccurs=""1"" maxOccurs=""1"" name=""CaseRequestSwitch"" type=""xs:string"" />
      <xs:element name=""ProcessMode"" type=""xs:string"">
        <xs:annotation>
          <xs:appinfo>
            <b:fieldInfo notes=""“B” for batch, “O” for online – for Sales order"" />
          </xs:appinfo>
        </xs:annotation>
      </xs:element>
      <xs:element name=""OpenOrderSwitch"" type=""xs:string"">
        <xs:annotation>
          <xs:appinfo>
            <b:fieldInfo notes=""Open order = if OrdAccount Number found in AccountFilter.tzt file plus OrderSatus !=Billed/Payed "" />
          </xs:appinfo>
        </xs:annotation>
      </xs:element>
    </xs:sequence>
    <xs:attribute name=""Hashkey"" type=""xs:string"" />
  </xs:complexType>
  <xs:element name=""InventoryStatus"" type=""InventoryStatusEventType"">
    <xs:annotation>
      <xs:appinfo>
        <b:properties>
          <b:property name=""ns0:Source_ProcessingMode"" xpath=""/*[local-name()='InventoryStatus' and namespace-uri()='http://OM.BizTalk.AzureFeeds.Schemas.Canonicals_V1']/*[local-name()='ProcessMode' and namespace-uri()='']"" />
        </b:properties>
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""FeedBase"" type=""FeedBaseType"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo rootTypeName=""FeedBase"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" />
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:complexType name=""SalesOrderInstructionsType"">
    <xs:sequence>
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""Instruction"" type=""SalesOrderInstructionType"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""SalesOrderInstructionType"">
    <xs:sequence>
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""ReferenceId"" type=""xs:string"" />
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""Text"" type=""xs:string"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""SalesOrderLineErrorType"">
    <xs:sequence>
      <xs:element name=""LineNumberOM"" type=""xs:string"" />
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""ErrorCode"" type=""xs:string"" />
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""ErrorText"" type=""xs:string"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""SalesOrderLineErrorsType"">
    <xs:sequence>
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""Error"" type=""SalesOrderLineErrorType"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""InventoryStatusEventType"">
    <xs:complexContent mixed=""false"">
      <xs:extension base=""FeedBaseType"">
        <xs:sequence>
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""ProductNumber"" type=""xs:string"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""DC"" type=""xs:string"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""SubProductNumber"" type=""xs:string"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""Status"" type=""xs:string"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""NonStock"" type=""xs:boolean"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""QtyAvailable"" type=""xs:int"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""QtyOnHand"" type=""xs:int"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""QtyOnOrder"" type=""xs:int"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""QtyInExcess"" type=""xs:int"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""QtyInReserve"" type=""xs:int"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""LastReceiptDate"" type=""xs:dateTime"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""BranchDefaultUOM"" type=""xs:string"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""HandStackUOM"" type=""xs:string"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""BreakBulkUOM"" type=""xs:string"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""Company"" type=""xs:string"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""QtyCommitted"" type=""xs:string"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""QtyOnHold"" type=""xs:string"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""SalesHistory1"" type=""xs:string"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""SalesHistory2"" type=""xs:string"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""SalesHistory3"" type=""xs:string"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""BuyerName"" type=""xs:string"" />
          <xs:element name=""ProcessMode"" type=""xs:string"">
            <xs:annotation>
              <xs:appinfo>
                <b:fieldInfo notes=""“B” for batch, “O” for online – for Inventory"" />
              </xs:appinfo>
            </xs:annotation>
          </xs:element>
        </xs:sequence>
      </xs:extension>
    </xs:complexContent>
  </xs:complexType>
  <xs:complexType name=""InventoryStatusPOEventType"">
    <xs:complexContent mixed=""false"">
      <xs:extension base=""FeedBaseType"">
        <xs:sequence>
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""Company"" type=""xs:string"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""DC"" type=""xs:string"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""ProductNumber"" type=""xs:string"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""POOrderCreateDate"" type=""xs:dateTime"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""POLineNbr"" type=""xs:string"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""POQtyOpen"" type=""xs:string"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""POUOM"" type=""xs:string"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""PurchaseAnalyst"" type=""xs:string"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""POPromiseDate"" type=""xs:string"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""POLinePromiseDate"" type=""xs:string"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""POLineStatus"" type=""xs:string"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""PONumber"" type=""xs:string"" />
          <xs:element name=""ProcessMode"" type=""xs:string"">
            <xs:annotation>
              <xs:appinfo>
                <b:fieldInfo notes=""“B” for batch, “O” for online – for Inventory"" />
              </xs:appinfo>
            </xs:annotation>
          </xs:element>
        </xs:sequence>
      </xs:extension>
    </xs:complexContent>
  </xs:complexType>
  <xs:complexType name=""InventoryStatusPONoteType"">
    <xs:complexContent mixed=""false"">
      <xs:extension base=""FeedBaseType"">
        <xs:sequence>
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""Company"" type=""xs:string"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""DC"" type=""xs:string"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""ProductNumber"" type=""xs:string"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""PONumber"" type=""xs:string"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""POLineNbr"" type=""xs:string"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""POLineDescription"" type=""xs:string"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""POLineDescriptionNbr"" type=""xs:string"" />
          <xs:element name=""ProcessMode"" type=""xs:string"">
            <xs:annotation>
              <xs:appinfo>
                <b:fieldInfo notes=""“B” for batch, “O” for online – for Inventory"" />
              </xs:appinfo>
            </xs:annotation>
          </xs:element>
        </xs:sequence>
      </xs:extension>
    </xs:complexContent>
  </xs:complexType>
  <xs:element name=""InventoryStatusPONote"" type=""InventoryStatusPONoteType"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo rootTypeName=""InventoryStatusPONote"" />
        <b:properties>
          <b:property name=""ns0:Source_ProcessingMode"" xpath=""/*[local-name()='InventoryStatusPONote' and namespace-uri()='http://OM.BizTalk.AzureFeeds.Schemas.Canonicals_V1']/*[local-name()='ProcessMode' and namespace-uri()='']"" />
        </b:properties>
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""RawContent"">
    <xs:annotation>
      <xs:appinfo>
        <b:properties>
          <b:property name=""ns0:RawMessageType"" xpath=""/*[local-name()='RawContent' and namespace-uri()='http://OM.BizTalk.AzureFeeds.Schemas.Canonicals_V1']/@*[local-name()='MessageType' and namespace-uri()='']"" />
        </b:properties>
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:attribute name=""MessageType"" type=""xs:string"" />
    </xs:complexType>
  </xs:element>
  <xs:element name=""InventoryStatusPO"" type=""InventoryStatusPOEventType"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo rootTypeName=""InventoryStatusPO"" />
        <b:properties>
          <b:property name=""ns0:Source_ProcessingMode"" xpath=""/*[local-name()='InventoryStatusPO' and namespace-uri()='http://OM.BizTalk.AzureFeeds.Schemas.Canonicals_V1']/*[local-name()='ProcessMode' and namespace-uri()='']"" />
        </b:properties>
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""PendingSalesOrderCaseResult"">
    <xs:complexType>
      <xs:complexContent mixed=""false"">
        <xs:extension base=""FeedBaseType"">
          <xs:sequence>
            <xs:element name=""CaseReference"" type=""xs:string"" />
            <xs:element name=""CaseCreationDetails"" type=""xs:string"" />
            <xs:element ref=""SalesOrder"" />
          </xs:sequence>
        </xs:extension>
      </xs:complexContent>
    </xs:complexType>
  </xs:element>
  <xs:element name=""BackorderLineNotes"" type=""BackorderLineNotes"" />
  <xs:complexType name=""BackorderLineNotes"">
    <xs:complexContent mixed=""false"">
      <xs:extension base=""FeedBaseType"">
        <xs:sequence>
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""DC"" type=""xs:string"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""CustId"" type=""xs:string"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""ShipTo"" type=""xs:string"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""ProductNumber"" type=""xs:string"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""OrderDate"" type=""xs:string"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""SONumber"" type=""xs:string"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""OMLineNumber"" type=""xs:string"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""BOLineNote"" type=""xs:string"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""ETA"" type=""xs:string"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""UpdateDate"" type=""xs:string"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""CustLineNumber"" type=""xs:string"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""UpdateUser"" type=""xs:string"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""UpdateSystem"" type=""xs:string"" />
          <xs:element name=""CompanyId"" type=""xs:string"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""CustomerETA"" type=""xs:string"" />
        </xs:sequence>
      </xs:extension>
    </xs:complexContent>
  </xs:complexType>
  <xs:element name=""AzureMessageOut"" type=""AzureMessageOut"">
    <xs:annotation>
      <xs:appinfo>
        <b:properties>
          <b:property name=""ns0:AzureMessageType"" xpath=""/*[local-name()='AzureMessageOut' and namespace-uri()='http://OM.BizTalk.AzureFeeds.Schemas.Canonicals_V1']/*[local-name()='MessageType' and namespace-uri()='']"" />
        </b:properties>
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:complexType name=""AzureMessageOut"">
    <xs:complexContent mixed=""false"">
      <xs:extension base=""FeedBaseType"">
        <xs:sequence>
          <xs:element minOccurs=""1"" maxOccurs=""1"" name=""MessageType"" type=""xs:string"" />
          <xs:element minOccurs=""1"" maxOccurs=""1"" name=""MessageContent"" type=""xs:string"" />
        </xs:sequence>
      </xs:extension>
    </xs:complexContent>
  </xs:complexType>
  <xs:element name=""DCProductNotes"" type=""DCProductNotes"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo rootTypeName=""DCProductNotes"" />
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:complexType name=""DCProductNotes"">
    <xs:complexContent mixed=""false"">
      <xs:extension base=""FeedBaseType"">
        <xs:sequence>
          <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""Records"" type=""DCProductNotesRecords"" />
        </xs:sequence>
      </xs:extension>
    </xs:complexContent>
  </xs:complexType>
  <xs:complexType name=""DCProductNotesRecords"">
    <xs:sequence>
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""DC"" type=""xs:string"" />
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""ProductNumber"" type=""xs:string"" />
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""Note"" type=""xs:string"" />
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""AdditionalComment"" type=""xs:string"" />
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""ManufactureNote"" type=""xs:string"" />
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""ManufactureDate"" type=""xs:dateTime"" />
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""SalesOrdeLineComments"" type=""SalesOrdeLineCommentsType"" />
  <xs:complexType name=""SalesOrdeLineCommentsType"">
    <xs:sequence>
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""LineComments"" type=""SalesOrdeLineCommentType"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""SalesOrdeLineCommentType"">
    <xs:sequence>
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""LineNumber"" type=""xs:string"" />
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""LineDescNbr"" type=""xs:string"" />
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""LineDescription"" type=""xs:string"" />
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""CustomerSubstitution"" type=""CustomerSubstitution"" />
  <xs:complexType name=""CustomerSubstitution"">
    <xs:complexContent mixed=""false"">
      <xs:extension base=""FeedBaseType"">
        <xs:sequence>
          <xs:element minOccurs=""1"" maxOccurs=""1"" default=""OM"" name=""CompanyID"" type=""xs:string"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""DC"" type=""xs:string"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""AccountNumber"" type=""xs:string"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""ProductNumber"" type=""xs:string"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""SubstittutionProductID"" type=""xs:string"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""SubstitutionNote"" type=""xs:string"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""LastUpdateDate"" type=""xs:string"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""LastUpdateUserID"" type=""xs:string"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""LastUpdateSystem"" type=""xs:string"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""Action"" type=""xs:string"" />
        </xs:sequence>
      </xs:extension>
    </xs:complexContent>
  </xs:complexType>
  <xs:element name=""InventoryPO"" type=""InventoryPO"">
    <xs:annotation>
      <xs:appinfo>
        <b:properties>
          <b:property name=""ns0:Source_ProcessingMode"" xpath=""/*[local-name()='InventoryPO' and namespace-uri()='http://OM.BizTalk.AzureFeeds.Schemas.Canonicals_V1']/*[local-name()='ProcessMode' and namespace-uri()='']"" />
        </b:properties>
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:complexType name=""InventoryPO"">
    <xs:complexContent mixed=""false"">
      <xs:extension base=""FeedBaseType"">
        <xs:sequence>
          <xs:element minOccurs=""1"" maxOccurs=""2"" name=""Company"" type=""xs:string"" />
          <xs:element minOccurs=""1"" maxOccurs=""1"" name=""DC"" type=""xs:string"" />
          <xs:element minOccurs=""1"" maxOccurs=""1"" name=""PONumber"" type=""xs:string"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""POLineNumber"" type=""xs:string"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""ProductNumber"" type=""xs:string"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""POStatus"" type=""xs:string"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""POCreateDate"" type=""xs:dateTime"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""POPromiseDate"" type=""xs:dateTime"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""POLineStatus"" type=""xs:string"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""POLinePromiseDate"" type=""xs:dateTime"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""POLineQty"" type=""xs:int"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""POLineUOM"" type=""xs:string"" />
          <xs:element name=""ProcessMode"" type=""xs:string"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""PurchaseAnalyst"" type=""xs:string"" />
          <xs:element minOccurs=""0"" maxOccurs=""1"" name=""PurchaseOrderType"" type=""xs:string"" />
        </xs:sequence>
      </xs:extension>
    </xs:complexContent>
  </xs:complexType>
  <xs:element name=""AccountSets"" type=""AccountSetsType"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo notes=""A type used to convey groups of account lookups between processes and systems."" rootTypeName=""AccountSets"" />
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:complexType name=""AccountSetsType"">
    <xs:sequence>
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""AccountSet"" type=""AccountSetType"">
        <xs:annotation>
          <xs:appinfo>
            <b:recordInfo notes=""Represents a single account lookup."" />
          </xs:appinfo>
        </xs:annotation>
      </xs:element>
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""AccountSetType"">
    <xs:sequence>
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""Identifier_OMNI"" type=""xs:string"" />
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""Identifier_SalesForce"" type=""xs:string"" />
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""Name"" type=""xs:string"" />
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""TypeName"" type=""xs:string"" />
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""CET"" type=""xs:string"" />
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""LookupDateTimeUTC"" type=""xs:dateTime"" />
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""AccountSetsLookup"" type=""AccountSetsLookupType"" />
  <xs:complexType name=""AccountSetsLookupType"">
    <xs:sequence>
      <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""AccountSetLookup"" type=""AccountSetLookupType"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""AccountSetLookupType"">
    <xs:sequence>
      <xs:element minOccurs=""1"" maxOccurs=""1"" name=""Identifier_OMNI"" type=""xs:string"" />
    </xs:sequence>
  </xs:complexType>
</xs:schema>";
        
        public Canonicals_V1() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [15];
                _RootElements[0] = "SalesOrder";
                _RootElements[1] = "InventoryStatus";
                _RootElements[2] = "FeedBase";
                _RootElements[3] = "InventoryStatusPONote";
                _RootElements[4] = "RawContent";
                _RootElements[5] = "InventoryStatusPO";
                _RootElements[6] = "PendingSalesOrderCaseResult";
                _RootElements[7] = "BackorderLineNotes";
                _RootElements[8] = "AzureMessageOut";
                _RootElements[9] = "DCProductNotes";
                _RootElements[10] = "SalesOrdeLineComments";
                _RootElements[11] = "CustomerSubstitution";
                _RootElements[12] = "InventoryPO";
                _RootElements[13] = "AccountSets";
                _RootElements[14] = "AccountSetsLookup";
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
        
        [Schema(@"http://OM.BizTalk.AzureFeeds.Schemas.Canonicals_V1",@"SalesOrder")]
        [Microsoft.XLANGs.BaseTypes.PropertyAttribute(typeof(global::GDM.Biztalk.Schemas.CaseRequestSwitch), XPath = @"/*[local-name()='SalesOrder' and namespace-uri()='http://OM.BizTalk.AzureFeeds.Schemas.Canonicals_V1']/*[local-name()='Key' and namespace-uri()='']/*[local-name()='CaseRequestSwitch' and namespace-uri()='']", XsdType = @"string")]
        [Microsoft.XLANGs.BaseTypes.PropertyAttribute(typeof(global::GDM.Biztalk.Schemas.Source_ProcessingMode), XPath = @"/*[local-name()='SalesOrder' and namespace-uri()='http://OM.BizTalk.AzureFeeds.Schemas.Canonicals_V1']/*[local-name()='Key' and namespace-uri()='']/*[local-name()='ProcessMode' and namespace-uri()='']", XsdType = @"string")]
        [Microsoft.XLANGs.BaseTypes.PropertyAttribute(typeof(global::GDM.Biztalk.Schemas.OrderStatus), XPath = @"/*[local-name()='SalesOrder' and namespace-uri()='http://OM.BizTalk.AzureFeeds.Schemas.Canonicals_V1']/*[local-name()='Header' and namespace-uri()='']/*[local-name()='OrderStatus' and namespace-uri()='']", XsdType = @"string")]
        [Microsoft.XLANGs.BaseTypes.PropertyAttribute(typeof(global::GDM.Biztalk.Schemas.SalesOrderNumber), XPath = @"/*[local-name()='SalesOrder' and namespace-uri()='http://OM.BizTalk.AzureFeeds.Schemas.Canonicals_V1']/*[local-name()='Key' and namespace-uri()='']/*[local-name()='SONumber' and namespace-uri()='']", XsdType = @"string")]
        [Microsoft.XLANGs.BaseTypes.PropertyAttribute(typeof(global::GDM.Biztalk.Schemas.AccountNumber), XPath = @"/*[local-name()='SalesOrder' and namespace-uri()='http://OM.BizTalk.AzureFeeds.Schemas.Canonicals_V1']/*[local-name()='Header' and namespace-uri()='']/*[local-name()='AccountNumber' and namespace-uri()='']", XsdType = @"string")]
        [Microsoft.XLANGs.BaseTypes.PropertyAttribute(typeof(global::GDM.Biztalk.Schemas.Source_TriggerMode), XPath = @"/*[local-name()='SalesOrder' and namespace-uri()='http://OM.BizTalk.AzureFeeds.Schemas.Canonicals_V1']/*[local-name()='Key' and namespace-uri()='']/*[local-name()='TriggerMode' and namespace-uri()='']", XsdType = @"string")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"SalesOrder"})]
        public sealed class SalesOrder : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public SalesOrder() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "SalesOrder";
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
        
        [Schema(@"http://OM.BizTalk.AzureFeeds.Schemas.Canonicals_V1",@"InventoryStatus")]
        [Microsoft.XLANGs.BaseTypes.PropertyAttribute(typeof(global::GDM.Biztalk.Schemas.Source_ProcessingMode), XPath = @"/*[local-name()='InventoryStatus' and namespace-uri()='http://OM.BizTalk.AzureFeeds.Schemas.Canonicals_V1']/*[local-name()='ProcessMode' and namespace-uri()='']", XsdType = @"string")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"InventoryStatus"})]
        public sealed class InventoryStatus : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public InventoryStatus() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "InventoryStatus";
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
        
        [Schema(@"http://OM.BizTalk.AzureFeeds.Schemas.Canonicals_V1",@"FeedBase")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"FeedBase"})]
        public sealed class FeedBase : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public FeedBase() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "FeedBase";
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
        
        [Schema(@"http://OM.BizTalk.AzureFeeds.Schemas.Canonicals_V1",@"InventoryStatusPONote")]
        [Microsoft.XLANGs.BaseTypes.PropertyAttribute(typeof(global::GDM.Biztalk.Schemas.Source_ProcessingMode), XPath = @"/*[local-name()='InventoryStatusPONote' and namespace-uri()='http://OM.BizTalk.AzureFeeds.Schemas.Canonicals_V1']/*[local-name()='ProcessMode' and namespace-uri()='']", XsdType = @"string")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"InventoryStatusPONote"})]
        public sealed class InventoryStatusPONote : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public InventoryStatusPONote() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "InventoryStatusPONote";
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
        
        [Schema(@"http://OM.BizTalk.AzureFeeds.Schemas.Canonicals_V1",@"RawContent")]
        [Microsoft.XLANGs.BaseTypes.PropertyAttribute(typeof(global::GDM.Biztalk.Schemas.RawMessageType), XPath = @"/*[local-name()='RawContent' and namespace-uri()='http://OM.BizTalk.AzureFeeds.Schemas.Canonicals_V1']/@*[local-name()='MessageType' and namespace-uri()='']", XsdType = @"string")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"RawContent"})]
        public sealed class RawContent : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public RawContent() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "RawContent";
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
        
        [Schema(@"http://OM.BizTalk.AzureFeeds.Schemas.Canonicals_V1",@"InventoryStatusPO")]
        [Microsoft.XLANGs.BaseTypes.PropertyAttribute(typeof(global::GDM.Biztalk.Schemas.Source_ProcessingMode), XPath = @"/*[local-name()='InventoryStatusPO' and namespace-uri()='http://OM.BizTalk.AzureFeeds.Schemas.Canonicals_V1']/*[local-name()='ProcessMode' and namespace-uri()='']", XsdType = @"string")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"InventoryStatusPO"})]
        public sealed class InventoryStatusPO : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public InventoryStatusPO() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "InventoryStatusPO";
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
        
        [Schema(@"http://OM.BizTalk.AzureFeeds.Schemas.Canonicals_V1",@"PendingSalesOrderCaseResult")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"PendingSalesOrderCaseResult"})]
        public sealed class PendingSalesOrderCaseResult : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public PendingSalesOrderCaseResult() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "PendingSalesOrderCaseResult";
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
        
        [Schema(@"http://OM.BizTalk.AzureFeeds.Schemas.Canonicals_V1",@"BackorderLineNotes")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"BackorderLineNotes"})]
        public sealed class BackorderLineNotes : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public BackorderLineNotes() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "BackorderLineNotes";
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
        
        [Schema(@"http://OM.BizTalk.AzureFeeds.Schemas.Canonicals_V1",@"AzureMessageOut")]
        [Microsoft.XLANGs.BaseTypes.PropertyAttribute(typeof(global::GDM.Biztalk.Schemas.AzureMessageType), XPath = @"/*[local-name()='AzureMessageOut' and namespace-uri()='http://OM.BizTalk.AzureFeeds.Schemas.Canonicals_V1']/*[local-name()='MessageType' and namespace-uri()='']", XsdType = @"string")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"AzureMessageOut"})]
        public sealed class AzureMessageOut : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public AzureMessageOut() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "AzureMessageOut";
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
        
        [Schema(@"http://OM.BizTalk.AzureFeeds.Schemas.Canonicals_V1",@"DCProductNotes")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"DCProductNotes"})]
        public sealed class DCProductNotes : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public DCProductNotes() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "DCProductNotes";
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
        
        [Schema(@"http://OM.BizTalk.AzureFeeds.Schemas.Canonicals_V1",@"SalesOrdeLineComments")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"SalesOrdeLineComments"})]
        public sealed class SalesOrdeLineComments : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public SalesOrdeLineComments() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "SalesOrdeLineComments";
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
        
        [Schema(@"http://OM.BizTalk.AzureFeeds.Schemas.Canonicals_V1",@"CustomerSubstitution")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"CustomerSubstitution"})]
        public sealed class CustomerSubstitution : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public CustomerSubstitution() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "CustomerSubstitution";
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
        
        [Schema(@"http://OM.BizTalk.AzureFeeds.Schemas.Canonicals_V1",@"InventoryPO")]
        [Microsoft.XLANGs.BaseTypes.PropertyAttribute(typeof(global::GDM.Biztalk.Schemas.Source_ProcessingMode), XPath = @"/*[local-name()='InventoryPO' and namespace-uri()='http://OM.BizTalk.AzureFeeds.Schemas.Canonicals_V1']/*[local-name()='ProcessMode' and namespace-uri()='']", XsdType = @"string")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"InventoryPO"})]
        public sealed class InventoryPO : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public InventoryPO() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "InventoryPO";
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
        
        [Schema(@"http://OM.BizTalk.AzureFeeds.Schemas.Canonicals_V1",@"AccountSets")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"AccountSets"})]
        public sealed class AccountSets : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public AccountSets() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "AccountSets";
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
        
        [Schema(@"http://OM.BizTalk.AzureFeeds.Schemas.Canonicals_V1",@"AccountSetsLookup")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"AccountSetsLookup"})]
        public sealed class AccountSetsLookup : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public AccountSetsLookup() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "AccountSetsLookup";
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
    }
}
