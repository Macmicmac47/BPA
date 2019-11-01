namespace GDM.Biztalk.Schemas {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://OM.BizTalk.AzureFeeds.OMNI.Schemas.SalesOrder",@"Message")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"Message"})]
    public sealed class SalesOrder : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""http://OM.BizTalk.AzureFeeds.OMNI.Schemas.SalesOrder"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" targetNamespace=""http://OM.BizTalk.AzureFeeds.OMNI.Schemas.SalesOrder"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:annotation>
    <xs:appinfo>
      <b:schemaInfo standard=""Flat File"" root_reference=""Message"" default_pad_char="" "" pad_char_type=""char"" count_positions_by_byte=""false"" parser_optimization=""complexity"" lookahead_depth=""0"" suppress_empty_nodes=""false"" generate_empty_nodes=""true"" allow_early_termination=""true"" early_terminate_optional_fields=""true"" allow_message_breakup_of_infix_root=""false"" compile_parse_tables=""false"" />
      <schemaEditorExtension:schemaInfo namespaceAlias=""b"" extensionClass=""Microsoft.BizTalk.FlatFileExtension.FlatFileExtension"" standardName=""Flat File"" xmlns:schemaEditorExtension=""http://schemas.microsoft.com/BizTalk/2003/SchemaEditorExtensions"" />
    </xs:appinfo>
  </xs:annotation>
  <xs:element name=""Message"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo structure=""delimited"" preserve_delimiter_for_empty_data=""true"" suppress_trailing_delimiters=""false"" sequence_number=""1"" child_delimiter_type=""hex"" child_delimiter=""0xD 0xA"" child_order=""postfix"" />
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:annotation>
          <xs:appinfo>
            <b:groupInfo sequence_number=""0"" />
          </xs:appinfo>
        </xs:annotation>
        <xs:element minOccurs=""1"" maxOccurs=""1"" name=""ORHDR-RECORD"" type=""ORHDR-RECORDType"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""positional"" preserve_delimiter_for_empty_data=""true"" suppress_trailing_delimiters=""false"" tag_name=""H01"" tag_offset=""39"" sequence_number=""1"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""ORDLVR-RECORD"" type=""ORDLVR-RECORDType"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""positional"" preserve_delimiter_for_empty_data=""true"" suppress_trailing_delimiters=""false"" tag_name=""H02"" tag_offset=""39"" sequence_number=""2"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""ORSPCL-RECORD"" type=""ORSPCL-RECORDType"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""positional"" preserve_delimiter_for_empty_data=""true"" suppress_trailing_delimiters=""false"" tag_name=""H03"" tag_offset=""39"" sequence_number=""3"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""ORLNE-RECORD"" type=""ORLNE-RECORDType"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""positional"" preserve_delimiter_for_empty_data=""true"" suppress_trailing_delimiters=""false"" tag_name=""L01"" tag_offset=""39"" sequence_number=""4"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""ORLXD-RECORD"" type=""ORLXD-RECORDType"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""positional"" preserve_delimiter_for_empty_data=""true"" suppress_trailing_delimiters=""false"" tag_name=""L02"" tag_offset=""39"" sequence_number=""5"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""ORERR-RECORD-Header"" type=""ORERR-RECORDType"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""positional"" preserve_delimiter_for_empty_data=""true"" suppress_trailing_delimiters=""false"" tag_name=""N01"" tag_offset=""39"" sequence_number=""6"" notes=""Header Error Section"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""ORERR-RECORD-Line"" type=""ORERR-RECORDType"">
          <xs:annotation>
            <xs:appinfo>
              <b:recordInfo structure=""positional"" preserve_delimiter_for_empty_data=""true"" suppress_trailing_delimiters=""false"" tag_name=""N02"" tag_offset=""39"" sequence_number=""7"" notes=""Line Error Section"" />
            </xs:appinfo>
          </xs:annotation>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
  <xs:complexType name=""ORHDR-RECORDType"">
    <xs:sequence>
      <xs:annotation>
        <xs:appinfo>
          <b:groupInfo sequence_number=""0"" />
        </xs:appinfo>
      </xs:annotation>
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""ORHDR-COMPANY"" type=""xs:string"">
        <xs:annotation>
          <xs:appinfo>
            <b:fieldInfo sequence_number=""1"" justification=""left"" pos_length=""2"" />
          </xs:appinfo>
        </xs:annotation>
      </xs:element>
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""ORHDR-BR-NBR"" type=""xs:string"">
        <xs:annotation>
          <xs:appinfo>
            <b:fieldInfo sequence_number=""2"" justification=""left"" pos_length=""2"" />
          </xs:appinfo>
        </xs:annotation>
      </xs:element>
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""ORHDR-ORDER-NBR"" type=""xs:string"">
        <xs:annotation>
          <xs:appinfo>
            <b:fieldInfo sequence_number=""3"" justification=""left"" pos_length=""5"" />
          </xs:appinfo>
        </xs:annotation>
      </xs:element>
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""ORHDR-DIST-NBR"" type=""xs:string"">
        <xs:annotation>
          <xs:appinfo>
            <b:fieldInfo sequence_number=""4"" justification=""left"" pos_length=""1"" />
          </xs:appinfo>
        </xs:annotation>
      </xs:element>
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""ORHDR-SHIP-NBR"" type=""xs:string"">
        <xs:annotation>
          <xs:appinfo>
            <b:fieldInfo sequence_number=""5"" justification=""left"" pos_length=""1"" />
          </xs:appinfo>
        </xs:annotation>
      </xs:element>
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""ORHDR-ENTRY-DT"" type=""xs:string"">
        <xs:annotation>
          <xs:appinfo>
            <b:fieldInfo sequence_number=""6"" justification=""left"" pos_length=""23"" />
          </xs:appinfo>
        </xs:annotation>
      </xs:element>
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""ORHDR-LINE-NBR"" type=""xs:string"">
        <xs:annotation>
          <xs:appinfo>
            <b:fieldInfo sequence_number=""7"" justification=""left"" pos_length=""5"" />
          </xs:appinfo>
        </xs:annotation>
      </xs:element>
      <xs:element minOccurs=""1"" maxOccurs=""1"" default=""H"" name=""ORHDR-RECORD-TYPE"" type=""xs:string"">
        <xs:annotation>
          <xs:appinfo>
            <b:fieldInfo sequence_number=""8"" justification=""left"" pos_length=""3"" />
          </xs:appinfo>
        </xs:annotation>
      </xs:element>
      <xs:element minOccurs=""1"" maxOccurs=""1"" name=""ORHDR-TRIG-IDENTITY"" type=""xs:string"">
        <xs:annotation>
          <xs:appinfo>
            <b:fieldInfo sequence_number=""9"" justification=""left"" pos_length=""18"" />
          </xs:appinfo>
        </xs:annotation>
      </xs:element>
      <xs:element minOccurs=""1"" maxOccurs=""1"" name=""ORHDR-PROCESS-SW"" type=""xs:string"">
        <xs:annotation>
          <xs:appinfo>
            <b:fieldInfo sequence_number=""10"" justification=""left"" pos_length=""1"" />
          </xs:appinfo>
        </xs:annotation>
      </xs:element>
      <xs:element minOccurs=""1"" maxOccurs=""1"" name=""ORHDR-CASE-CREATE-SW"" type=""xs:string"">
        <xs:annotation>
          <xs:appinfo>
            <b:fieldInfo sequence_number=""11"" justification=""left"" pos_length=""1"" />
          </xs:appinfo>
        </xs:annotation>
      </xs:element>
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""ORHDR-TRIG-MODE"" type=""xs:string"">
        <xs:annotation>
          <xs:appinfo>
            <b:fieldInfo sequence_number=""12"" justification=""left"" pos_length=""1"" />
          </xs:appinfo>
        </xs:annotation>
      </xs:element>
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""ORHDR-TRIG-TYPE"" type=""xs:string"">
        <xs:annotation>
          <xs:appinfo>
            <b:fieldInfo justification=""left"" sequence_number=""13"" pos_length=""1"" />
          </xs:appinfo>
        </xs:annotation>
      </xs:element>
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""ORHDR-CUST-NBR"" type=""xs:string"">
        <xs:annotation>
          <xs:appinfo>
            <b:fieldInfo sequence_number=""14"" justification=""left"" pos_length=""6"" />
          </xs:appinfo>
        </xs:annotation>
      </xs:element>
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""ORHDR-CUST-ID"" type=""xs:string"">
        <xs:annotation>
          <xs:appinfo>
            <b:fieldInfo sequence_number=""15"" justification=""left"" pos_length=""8"" />
          </xs:appinfo>
        </xs:annotation>
      </xs:element>
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""ORHDR-ENTRY-METHOD"" type=""xs:string"">
        <xs:annotation>
          <xs:appinfo>
            <b:fieldInfo sequence_number=""16"" justification=""left"" pos_length=""1"" />
          </xs:appinfo>
        </xs:annotation>
      </xs:element>
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""ORHDR-CONTRACT-PRICE-FLAG"" type=""xs:string"">
        <xs:annotation>
          <xs:appinfo>
            <b:fieldInfo sequence_number=""17"" justification=""left"" pos_length=""5"" />
          </xs:appinfo>
        </xs:annotation>
      </xs:element>
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""ORHDR-SHIP-TO-SUFFIX"" type=""xs:string"">
        <xs:annotation>
          <xs:appinfo>
            <b:fieldInfo sequence_number=""18"" justification=""left"" pos_length=""4"" />
          </xs:appinfo>
        </xs:annotation>
      </xs:element>
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""ORHDR-BILL-TO-SUFFIX"" type=""xs:string"">
        <xs:annotation>
          <xs:appinfo>
            <b:fieldInfo sequence_number=""19"" justification=""left"" pos_length=""4"" />
          </xs:appinfo>
        </xs:annotation>
      </xs:element>
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""ORHDR-CUST-PO-NBR"" type=""xs:string"">
        <xs:annotation>
          <xs:appinfo>
            <b:fieldInfo sequence_number=""20"" justification=""left"" pos_length=""18"" />
          </xs:appinfo>
        </xs:annotation>
      </xs:element>
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""ORHDR-DEL-ROUTE"" type=""xs:string"">
        <xs:annotation>
          <xs:appinfo>
            <b:fieldInfo sequence_number=""21"" justification=""left"" pos_length=""2"" />
          </xs:appinfo>
        </xs:annotation>
      </xs:element>
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""ORHDR-PAY-TERMS"" type=""xs:string"">
        <xs:annotation>
          <xs:appinfo>
            <b:fieldInfo sequence_number=""22"" justification=""left"" pos_length=""3"" />
          </xs:appinfo>
        </xs:annotation>
      </xs:element>
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""ORHDR-PRIORITY"" type=""xs:string"">
        <xs:annotation>
          <xs:appinfo>
            <b:fieldInfo sequence_number=""23"" justification=""left"" pos_length=""1"" />
          </xs:appinfo>
        </xs:annotation>
      </xs:element>
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""ORHDR-REQ-NBR"" type=""xs:string"">
        <xs:annotation>
          <xs:appinfo>
            <b:fieldInfo sequence_number=""24"" justification=""left"" pos_length=""10"" />
          </xs:appinfo>
        </xs:annotation>
      </xs:element>
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""ORHDR-EXT-TYPE"" type=""xs:string"">
        <xs:annotation>
          <xs:appinfo>
            <b:fieldInfo sequence_number=""25"" justification=""left"" pos_length=""1"" />
          </xs:appinfo>
        </xs:annotation>
      </xs:element>
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""ORHDR-ISN"" type=""xs:string"">
        <xs:annotation>
          <xs:appinfo>
            <b:fieldInfo sequence_number=""26"" justification=""left"" pos_length=""4"" />
          </xs:appinfo>
        </xs:annotation>
      </xs:element>
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""ORHDR-ORDER-METHOD"" type=""xs:string"">
        <xs:annotation>
          <xs:appinfo>
            <b:fieldInfo sequence_number=""27"" justification=""left"" pos_length=""1"" />
          </xs:appinfo>
        </xs:annotation>
      </xs:element>
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""ORHDR-SEND-810-FLAG"" type=""xs:string"">
        <xs:annotation>
          <xs:appinfo>
            <b:fieldInfo sequence_number=""28"" justification=""left"" pos_length=""5"" />
          </xs:appinfo>
        </xs:annotation>
      </xs:element>
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""ORHDR-BO-STATUS"" type=""xs:string"">
        <xs:annotation>
          <xs:appinfo>
            <b:fieldInfo sequence_number=""29"" justification=""left"" pos_length=""1"" />
          </xs:appinfo>
        </xs:annotation>
      </xs:element>
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""ORHDR-CR-MEMO-SW"" type=""xs:string"">
        <xs:annotation>
          <xs:appinfo>
            <b:fieldInfo sequence_number=""30"" justification=""left"" pos_length=""5"" />
          </xs:appinfo>
        </xs:annotation>
      </xs:element>
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""ORHDR-CR-MEMO-REASON"" type=""xs:string"">
        <xs:annotation>
          <xs:appinfo>
            <b:fieldInfo sequence_number=""31"" justification=""left"" pos_length=""2"" />
          </xs:appinfo>
        </xs:annotation>
      </xs:element>
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""ORHDR-CREDIT-TYPE"" type=""xs:string"">
        <xs:annotation>
          <xs:appinfo>
            <b:fieldInfo sequence_number=""32"" justification=""left"" pos_length=""256"" />
          </xs:appinfo>
        </xs:annotation>
      </xs:element>
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""ORHDR-CURRENCY"" type=""xs:string"">
        <xs:annotation>
          <xs:appinfo>
            <b:fieldInfo sequence_number=""33"" justification=""left"" pos_length=""3"" />
          </xs:appinfo>
        </xs:annotation>
      </xs:element>
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""ORHDR-FRT-CODE"" type=""xs:string"">
        <xs:annotation>
          <xs:appinfo>
            <b:fieldInfo sequence_number=""34"" justification=""left"" pos_length=""1"" />
          </xs:appinfo>
        </xs:annotation>
      </xs:element>
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""ORHDR-FRT-AMT"" type=""xs:string"">
        <xs:annotation>
          <xs:appinfo>
            <b:fieldInfo sequence_number=""35"" justification=""left"" pos_length=""9"" />
          </xs:appinfo>
        </xs:annotation>
      </xs:element>
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""ORHDR-FROM-DC"" type=""xs:string"">
        <xs:annotation>
          <xs:appinfo>
            <b:fieldInfo sequence_number=""36"" justification=""left"" pos_length=""2"" />
          </xs:appinfo>
        </xs:annotation>
      </xs:element>
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""ORHDR-HANDLING-FEE"" type=""xs:string"">
        <xs:annotation>
          <xs:appinfo>
            <b:fieldInfo sequence_number=""37"" justification=""left"" pos_length=""9"" />
          </xs:appinfo>
        </xs:annotation>
      </xs:element>
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""ORHDR-INVOICE-DT"" type=""xs:string"">
        <xs:annotation>
          <xs:appinfo>
            <b:fieldInfo sequence_number=""38"" justification=""left"" pos_length=""23"" />
          </xs:appinfo>
        </xs:annotation>
      </xs:element>
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""ORHDR-INVOICE-NBR"" type=""xs:string"">
        <xs:annotation>
          <xs:appinfo>
            <b:fieldInfo sequence_number=""39"" justification=""left"" pos_length=""10"" />
          </xs:appinfo>
        </xs:annotation>
      </xs:element>
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""ORHDR-MASTER-SO-NBR"" type=""xs:string"">
        <xs:annotation>
          <xs:appinfo>
            <b:fieldInfo sequence_number=""40"" justification=""left"" pos_length=""12"" />
          </xs:appinfo>
        </xs:annotation>
      </xs:element>
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""ORHDR-MIN-ORDER-FEE"" type=""xs:string"">
        <xs:annotation>
          <xs:appinfo>
            <b:fieldInfo sequence_number=""41"" justification=""left"" pos_length=""7"" />
          </xs:appinfo>
        </xs:annotation>
      </xs:element>
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""ORHDR-NEW-ORDER-FLAG"" type=""xs:string"">
        <xs:annotation>
          <xs:appinfo>
            <b:fieldInfo sequence_number=""42"" justification=""left"" pos_length=""1"" />
          </xs:appinfo>
        </xs:annotation>
      </xs:element>
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""ORHDR-NBR-OF-LINES"" type=""xs:string"">
        <xs:annotation>
          <xs:appinfo>
            <b:fieldInfo sequence_number=""43"" justification=""left"" pos_length=""5"" />
          </xs:appinfo>
        </xs:annotation>
      </xs:element>
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""ORHDR-ORDER-STATUS"" type=""xs:string"">
        <xs:annotation>
          <xs:appinfo>
            <b:fieldInfo sequence_number=""44"" justification=""left"" pos_length=""1"" />
          </xs:appinfo>
        </xs:annotation>
      </xs:element>
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""ORHDR-ORDER-TYPE"" type=""xs:string"">
        <xs:annotation>
          <xs:appinfo>
            <b:fieldInfo sequence_number=""45"" justification=""left"" pos_length=""1"" />
          </xs:appinfo>
        </xs:annotation>
      </xs:element>
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""ORHDR-PROMISE-DT"" type=""xs:string"">
        <xs:annotation>
          <xs:appinfo>
            <b:fieldInfo sequence_number=""46"" justification=""left"" pos_length=""23"" />
          </xs:appinfo>
        </xs:annotation>
      </xs:element>
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""ORHDR-RELEASE-DT"" type=""xs:string"">
        <xs:annotation>
          <xs:appinfo>
            <b:fieldInfo sequence_number=""47"" justification=""left"" pos_length=""23"" />
          </xs:appinfo>
        </xs:annotation>
      </xs:element>
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""ORHDR-REQUIRED-DT"" type=""xs:string"">
        <xs:annotation>
          <xs:appinfo>
            <b:fieldInfo sequence_number=""48"" justification=""left"" pos_length=""23"" />
          </xs:appinfo>
        </xs:annotation>
      </xs:element>
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""ORHDR-SHIP-DT"" type=""xs:string"">
        <xs:annotation>
          <xs:appinfo>
            <b:fieldInfo sequence_number=""49"" justification=""left"" pos_length=""23"" />
          </xs:appinfo>
        </xs:annotation>
      </xs:element>
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""ORHDR-SHIP-VIA"" type=""xs:string"">
        <xs:annotation>
          <xs:appinfo>
            <b:fieldInfo sequence_number=""50"" justification=""left"" pos_length=""12"" />
          </xs:appinfo>
        </xs:annotation>
      </xs:element>
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""ORHDR-TOTAL-SALES"" type=""xs:string"">
        <xs:annotation>
          <xs:appinfo>
            <b:fieldInfo sequence_number=""51"" justification=""left"" pos_length=""13"" />
          </xs:appinfo>
        </xs:annotation>
      </xs:element>
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""ORHDR-SALES-TAX-AMT"" type=""xs:string"">
        <xs:annotation>
          <xs:appinfo>
            <b:fieldInfo sequence_number=""52"" justification=""left"" pos_length=""9"" />
          </xs:appinfo>
        </xs:annotation>
      </xs:element>
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""ORHDR-SALES-TAX-PCT"" type=""xs:string"">
        <xs:annotation>
          <xs:appinfo>
            <b:fieldInfo sequence_number=""53"" justification=""left"" pos_length=""8"" />
          </xs:appinfo>
        </xs:annotation>
      </xs:element>
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""ORHDR-ATTENTION"" type=""xs:string"">
        <xs:annotation>
          <xs:appinfo>
            <b:fieldInfo sequence_number=""54"" justification=""left"" pos_length=""35"" />
          </xs:appinfo>
        </xs:annotation>
      </xs:element>
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""ORHDR-FILLER"" type=""xs:string"">
        <xs:annotation>
          <xs:appinfo>
            <b:fieldInfo sequence_number=""55"" justification=""left"" pos_length=""26"" />
          </xs:appinfo>
        </xs:annotation>
      </xs:element>
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""ORLNE-RECORDType"">
    <xs:sequence>
      <xs:annotation>
        <xs:appinfo>
          <b:groupInfo sequence_number=""0"" />
        </xs:appinfo>
      </xs:annotation>
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""ORLNE-COMPANY"" type=""xs:string"">
        <xs:annotation>
          <xs:appinfo>
            <b:fieldInfo sequence_number=""1"" justification=""left"" pos_length=""2"" />
          </xs:appinfo>
        </xs:annotation>
      </xs:element>
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""ORLNE-BR-NBR"" type=""xs:string"">
        <xs:annotation>
          <xs:appinfo>
            <b:fieldInfo sequence_number=""2"" justification=""left"" pos_length=""2"" />
          </xs:appinfo>
        </xs:annotation>
      </xs:element>
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""ORLNE-ORDER-NBR"" type=""xs:string"">
        <xs:annotation>
          <xs:appinfo>
            <b:fieldInfo sequence_number=""3"" justification=""left"" pos_length=""5"" />
          </xs:appinfo>
        </xs:annotation>
      </xs:element>
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""ORLNE-DIST-NBR"" type=""xs:string"">
        <xs:annotation>
          <xs:appinfo>
            <b:fieldInfo sequence_number=""4"" justification=""left"" pos_length=""1"" />
          </xs:appinfo>
        </xs:annotation>
      </xs:element>
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""ORLNE-SHIP-NBR"" type=""xs:string"">
        <xs:annotation>
          <xs:appinfo>
            <b:fieldInfo sequence_number=""5"" justification=""left"" pos_length=""1"" />
          </xs:appinfo>
        </xs:annotation>
      </xs:element>
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""ORLNE-ENTRY-DT"" type=""xs:string"">
        <xs:annotation>
          <xs:appinfo>
            <b:fieldInfo sequence_number=""6"" justification=""left"" pos_length=""23"" />
          </xs:appinfo>
        </xs:annotation>
      </xs:element>
      <xs:element minOccurs=""0"" name=""ORLNE-LINE-NBR"" type=""xs:string"">
        <xs:annotation>
          <xs:appinfo>
            <b:fieldInfo sequence_number=""7"" justification=""left"" pos_length=""5"" />
          </xs:appinfo>
        </xs:annotation>
      </xs:element>
      <xs:element default=""L"" name=""ORLNE-RECORD-TYPE"" type=""xs:string"">
        <xs:annotation>
          <xs:appinfo>
            <b:fieldInfo sequence_number=""8"" justification=""left"" pos_length=""3"" />
          </xs:appinfo>
        </xs:annotation>
      </xs:element>
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""ORLNE-APPLY-FEE"" type=""xs:string"">
        <xs:annotation>
          <xs:appinfo>
            <b:fieldInfo sequence_number=""9"" justification=""left"" pos_length=""11"" />
          </xs:appinfo>
        </xs:annotation>
      </xs:element>
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""ORLNE-BASE-UM"" type=""xs:string"">
        <xs:annotation>
          <xs:appinfo>
            <b:fieldInfo sequence_number=""10"" justification=""left"" pos_length=""3"" />
          </xs:appinfo>
        </xs:annotation>
      </xs:element>
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""ORLNE-BASE-BO-QTY"" type=""xs:string"">
        <xs:annotation>
          <xs:appinfo>
            <b:fieldInfo sequence_number=""11"" justification=""left"" pos_length=""8"" />
          </xs:appinfo>
        </xs:annotation>
      </xs:element>
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""ORLNE-BASE-ORDER-QTY"" type=""xs:string"">
        <xs:annotation>
          <xs:appinfo>
            <b:fieldInfo sequence_number=""12"" justification=""left"" pos_length=""8"" />
          </xs:appinfo>
        </xs:annotation>
      </xs:element>
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""ORLNE-BASE-SHIP-QTY"" type=""xs:string"">
        <xs:annotation>
          <xs:appinfo>
            <b:fieldInfo sequence_number=""13"" justification=""left"" pos_length=""8"" />
          </xs:appinfo>
        </xs:annotation>
      </xs:element>
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""ORLNE-CUST-UM"" type=""xs:string"">
        <xs:annotation>
          <xs:appinfo>
            <b:fieldInfo sequence_number=""14"" justification=""left"" pos_length=""3"" />
          </xs:appinfo>
        </xs:annotation>
      </xs:element>
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""ORLNE-CUST-BO-QTY"" type=""xs:string"">
        <xs:annotation>
          <xs:appinfo>
            <b:fieldInfo sequence_number=""15"" justification=""left"" pos_length=""8"" />
          </xs:appinfo>
        </xs:annotation>
      </xs:element>
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""ORLNE-CUST-ORDER-QTY"" type=""xs:string"">
        <xs:annotation>
          <xs:appinfo>
            <b:fieldInfo sequence_number=""16"" justification=""left"" pos_length=""8"" />
          </xs:appinfo>
        </xs:annotation>
      </xs:element>
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""ORLNE-CUST-SHIP-QTY"" type=""xs:string"">
        <xs:annotation>
          <xs:appinfo>
            <b:fieldInfo sequence_number=""17"" justification=""left"" pos_length=""8"" />
          </xs:appinfo>
        </xs:annotation>
      </xs:element>
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""ORLNE-UNIT-COST"" type=""xs:string"">
        <xs:annotation>
          <xs:appinfo>
            <b:fieldInfo sequence_number=""18"" justification=""left"" pos_length=""13"" />
          </xs:appinfo>
        </xs:annotation>
      </xs:element>
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""ORLNE-UNIT-PRICE"" type=""xs:string"">
        <xs:annotation>
          <xs:appinfo>
            <b:fieldInfo sequence_number=""19"" justification=""left"" pos_length=""13"" />
          </xs:appinfo>
        </xs:annotation>
      </xs:element>
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""ORLNE-BREAK-BULK-SW"" type=""xs:string"">
        <xs:annotation>
          <xs:appinfo>
            <b:fieldInfo sequence_number=""20"" justification=""left"" pos_length=""1"" />
          </xs:appinfo>
        </xs:annotation>
      </xs:element>
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""ORLNE-BREAK-FEE"" type=""xs:string"">
        <xs:annotation>
          <xs:appinfo>
            <b:fieldInfo sequence_number=""21"" justification=""left"" pos_length=""11"" />
          </xs:appinfo>
        </xs:annotation>
      </xs:element>
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""ORLNE-CATALOG-NBR"" type=""xs:string"">
        <xs:annotation>
          <xs:appinfo>
            <b:fieldInfo sequence_number=""22"" justification=""left"" pos_length=""12"" />
          </xs:appinfo>
        </xs:annotation>
      </xs:element>
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""ORLNE-COMMENT-TXT"" type=""xs:string"">
        <xs:annotation>
          <xs:appinfo>
            <b:fieldInfo sequence_number=""23"" justification=""left"" pos_length=""256"" />
          </xs:appinfo>
        </xs:annotation>
      </xs:element>
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""ORLNE-CUST-PART-NBR"" type=""xs:string"">
        <xs:annotation>
          <xs:appinfo>
            <b:fieldInfo sequence_number=""24"" justification=""left"" pos_length=""12"" />
          </xs:appinfo>
        </xs:annotation>
      </xs:element>
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""ORLNE-CUST-LINE-NBR"" type=""xs:string"">
        <xs:annotation>
          <xs:appinfo>
            <b:fieldInfo sequence_number=""25"" justification=""left"" pos_length=""5"" />
          </xs:appinfo>
        </xs:annotation>
      </xs:element>
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""ORLNE-CUST-PRICE"" type=""xs:string"">
        <xs:annotation>
          <xs:appinfo>
            <b:fieldInfo sequence_number=""26"" justification=""left"" pos_length=""13"" />
          </xs:appinfo>
        </xs:annotation>
      </xs:element>
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""ORLNE-CUST-UNIT-PRICE"" type=""xs:string"">
        <xs:annotation>
          <xs:appinfo>
            <b:fieldInfo sequence_number=""27"" justification=""left"" pos_length=""11"" />
          </xs:appinfo>
        </xs:annotation>
      </xs:element>
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""ORLNE-PROMISE-DT"" type=""xs:string"">
        <xs:annotation>
          <xs:appinfo>
            <b:fieldInfo sequence_number=""28"" justification=""left"" pos_length=""23"" />
          </xs:appinfo>
        </xs:annotation>
      </xs:element>
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""ORLNE-ITEM-TYPE"" type=""xs:string"">
        <xs:annotation>
          <xs:appinfo>
            <b:fieldInfo sequence_number=""29"" justification=""left"" pos_length=""1"" />
          </xs:appinfo>
        </xs:annotation>
      </xs:element>
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""ORLNE-LABEL-FEE"" type=""xs:string"">
        <xs:annotation>
          <xs:appinfo>
            <b:fieldInfo sequence_number=""30"" justification=""left"" pos_length=""11"" />
          </xs:appinfo>
        </xs:annotation>
      </xs:element>
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""ORLNE-LINE-ENTRY-DT"" type=""xs:string"">
        <xs:annotation>
          <xs:appinfo>
            <b:fieldInfo sequence_number=""31"" justification=""left"" pos_length=""23"" />
          </xs:appinfo>
        </xs:annotation>
      </xs:element>
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""ORLNE-LINE-STATUS"" type=""xs:string"">
        <xs:annotation>
          <xs:appinfo>
            <b:fieldInfo sequence_number=""32"" justification=""left"" pos_length=""1"" />
          </xs:appinfo>
        </xs:annotation>
      </xs:element>
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""ORLNE-LINE-TYPE"" type=""xs:string"">
        <xs:annotation>
          <xs:appinfo>
            <b:fieldInfo sequence_number=""33"" justification=""left"" pos_length=""1"" />
          </xs:appinfo>
        </xs:annotation>
      </xs:element>
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""ORLNE-DS-ORG-ORD-QTY"" type=""xs:string"">
        <xs:annotation>
          <xs:appinfo>
            <b:fieldInfo sequence_number=""34"" justification=""left"" pos_length=""8"" />
          </xs:appinfo>
        </xs:annotation>
      </xs:element>
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""ORLNE-DS-IBTPO-RCV-QTY"" type=""xs:string"">
        <xs:annotation>
          <xs:appinfo>
            <b:fieldInfo sequence_number=""35"" justification=""left"" pos_length=""8"" />
          </xs:appinfo>
        </xs:annotation>
      </xs:element>
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""ORLNE-DS-IBTPO-LINE-NBR"" type=""xs:string"">
        <xs:annotation>
          <xs:appinfo>
            <b:fieldInfo sequence_number=""36"" justification=""left"" pos_length=""5"" />
          </xs:appinfo>
        </xs:annotation>
      </xs:element>
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""ORLNE-DS-IBT-PO-NBR"" type=""xs:string"">
        <xs:annotation>
          <xs:appinfo>
            <b:fieldInfo sequence_number=""37"" justification=""left"" pos_length=""5"" />
          </xs:appinfo>
        </xs:annotation>
      </xs:element>
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""ORLNE-DS-IBT-PO-STATUS"" type=""xs:string"">
        <xs:annotation>
          <xs:appinfo>
            <b:fieldInfo sequence_number=""38"" justification=""left"" pos_length=""1"" />
          </xs:appinfo>
        </xs:annotation>
      </xs:element>
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""ORLNE-PRODUCT-NBR"" type=""xs:string"">
        <xs:annotation>
          <xs:appinfo>
            <b:fieldInfo sequence_number=""39"" justification=""left"" pos_length=""12"" />
          </xs:appinfo>
        </xs:annotation>
      </xs:element>
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""ORLNE-PRODUCT-DESC"" type=""xs:string"">
        <xs:annotation>
          <xs:appinfo>
            <b:fieldInfo sequence_number=""40"" justification=""left"" pos_length=""35"" />
          </xs:appinfo>
        </xs:annotation>
      </xs:element>
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""ORLNE-REJECT-REASON"" type=""xs:string"">
        <xs:annotation>
          <xs:appinfo>
            <b:fieldInfo sequence_number=""41"" justification=""left"" pos_length=""2"" />
          </xs:appinfo>
        </xs:annotation>
      </xs:element>
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""ORLNE-LINE-REQ-DT"" type=""xs:string"">
        <xs:annotation>
          <xs:appinfo>
            <b:fieldInfo sequence_number=""42"" justification=""left"" pos_length=""23"" />
          </xs:appinfo>
        </xs:annotation>
      </xs:element>
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""ORLNE-JIT-SERVICE-FEE"" type=""xs:string"">
        <xs:annotation>
          <xs:appinfo>
            <b:fieldInfo sequence_number=""43"" justification=""left"" pos_length=""11"" />
          </xs:appinfo>
        </xs:annotation>
      </xs:element>
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""ORLNE-TRADE-PCT"" type=""xs:string"">
        <xs:annotation>
          <xs:appinfo>
            <b:fieldInfo sequence_number=""44"" justification=""left"" pos_length=""6"" />
          </xs:appinfo>
        </xs:annotation>
      </xs:element>
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""ORLNE-VEND-NBR"" type=""xs:string"">
        <xs:annotation>
          <xs:appinfo>
            <b:fieldInfo sequence_number=""45"" justification=""left"" pos_length=""4"" />
          </xs:appinfo>
        </xs:annotation>
      </xs:element>
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""ORLNE-SLOW-MOVE-INV-SW"" type=""xs:string"">
        <xs:annotation>
          <xs:appinfo>
            <b:fieldInfo sequence_number=""46"" justification=""left"" pos_length=""1"" />
          </xs:appinfo>
        </xs:annotation>
      </xs:element>
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""ORLNE-INV-IND-CD"" type=""xs:string"">
        <xs:annotation>
          <xs:appinfo>
            <b:fieldInfo sequence_number=""47"" justification=""left"" pos_length=""1"" />
          </xs:appinfo>
        </xs:annotation>
      </xs:element>
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""ORLNE-FILLER"" type=""xs:string"">
        <xs:annotation>
          <xs:appinfo>
            <b:fieldInfo sequence_number=""48"" justification=""left"" pos_length=""46"" />
          </xs:appinfo>
        </xs:annotation>
      </xs:element>
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""ORDLVR-RECORDType"">
    <xs:sequence>
      <xs:annotation>
        <xs:appinfo>
          <b:groupInfo sequence_number=""0"" />
        </xs:appinfo>
      </xs:annotation>
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""ORDLVR-COMPANY"" type=""xs:string"">
        <xs:annotation>
          <xs:appinfo>
            <b:fieldInfo sequence_number=""1"" justification=""left"" pos_length=""2"" />
          </xs:appinfo>
        </xs:annotation>
      </xs:element>
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""ORDLVR-BR-NBR"" type=""xs:string"">
        <xs:annotation>
          <xs:appinfo>
            <b:fieldInfo sequence_number=""2"" justification=""left"" pos_length=""2"" />
          </xs:appinfo>
        </xs:annotation>
      </xs:element>
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""ORDLVR-ORDER-NBR"" type=""xs:string"">
        <xs:annotation>
          <xs:appinfo>
            <b:fieldInfo sequence_number=""3"" justification=""left"" pos_length=""5"" />
          </xs:appinfo>
        </xs:annotation>
      </xs:element>
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""ORDLVR-DIST-NBR"" type=""xs:string"">
        <xs:annotation>
          <xs:appinfo>
            <b:fieldInfo sequence_number=""4"" justification=""left"" pos_length=""1"" />
          </xs:appinfo>
        </xs:annotation>
      </xs:element>
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""ORDLVR-SHIP-NBR"" type=""xs:string"">
        <xs:annotation>
          <xs:appinfo>
            <b:fieldInfo sequence_number=""5"" justification=""left"" pos_length=""1"" />
          </xs:appinfo>
        </xs:annotation>
      </xs:element>
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""ORDLVR-ENTRY-DT"" type=""xs:string"">
        <xs:annotation>
          <xs:appinfo>
            <b:fieldInfo sequence_number=""6"" justification=""left"" pos_length=""23"" />
          </xs:appinfo>
        </xs:annotation>
      </xs:element>
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""ORDLVR-LINE-NBR"" type=""xs:string"">
        <xs:annotation>
          <xs:appinfo>
            <b:fieldInfo sequence_number=""7"" justification=""left"" pos_length=""5"" />
          </xs:appinfo>
        </xs:annotation>
      </xs:element>
      <xs:element minOccurs=""1"" maxOccurs=""1"" default=""O"" name=""ORDLVR-RECORD-TYPE"" type=""xs:string"">
        <xs:annotation>
          <xs:appinfo>
            <b:fieldInfo sequence_number=""8"" justification=""left"" pos_length=""3"" />
          </xs:appinfo>
        </xs:annotation>
      </xs:element>
      <xs:element minOccurs=""1"" maxOccurs=""1"" name=""ORDLVR-SEQ"" type=""xs:string"">
        <xs:annotation>
          <xs:appinfo>
            <b:fieldInfo sequence_number=""9"" justification=""left"" pos_length=""1"" />
          </xs:appinfo>
        </xs:annotation>
      </xs:element>
      <xs:element minOccurs=""1"" maxOccurs=""1"" name=""ORDLVR-INSTRUCTIONS"" type=""xs:string"">
        <xs:annotation>
          <xs:appinfo>
            <b:fieldInfo sequence_number=""10"" justification=""left"" pos_length=""35"" />
          </xs:appinfo>
        </xs:annotation>
      </xs:element>
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""ORDLVR-FILLER"" type=""xs:string"">
        <xs:annotation>
          <xs:appinfo>
            <b:fieldInfo sequence_number=""11"" justification=""left"" pos_length=""602"" />
          </xs:appinfo>
        </xs:annotation>
      </xs:element>
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""ORSPCL-RECORDType"">
    <xs:sequence>
      <xs:annotation>
        <xs:appinfo>
          <b:groupInfo sequence_number=""0"" />
        </xs:appinfo>
      </xs:annotation>
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""ORSPCL-COMPANY"" type=""xs:string"">
        <xs:annotation>
          <xs:appinfo>
            <b:fieldInfo sequence_number=""1"" justification=""left"" pos_length=""2"" />
          </xs:appinfo>
        </xs:annotation>
      </xs:element>
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""ORSPCL-BR-NBR"" type=""xs:string"">
        <xs:annotation>
          <xs:appinfo>
            <b:fieldInfo sequence_number=""2"" justification=""left"" pos_length=""2"" />
          </xs:appinfo>
        </xs:annotation>
      </xs:element>
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""ORSPCL-ORDER-NBR"" type=""xs:string"">
        <xs:annotation>
          <xs:appinfo>
            <b:fieldInfo sequence_number=""3"" justification=""left"" pos_length=""5"" />
          </xs:appinfo>
        </xs:annotation>
      </xs:element>
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""ORSPCL-DIST-NBR"" type=""xs:string"">
        <xs:annotation>
          <xs:appinfo>
            <b:fieldInfo sequence_number=""4"" justification=""left"" pos_length=""1"" />
          </xs:appinfo>
        </xs:annotation>
      </xs:element>
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""ORSPCL-SHIP-NBR"" type=""xs:string"">
        <xs:annotation>
          <xs:appinfo>
            <b:fieldInfo sequence_number=""5"" justification=""left"" pos_length=""1"" />
          </xs:appinfo>
        </xs:annotation>
      </xs:element>
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""ORSPCL-ENTRY-DT"" type=""xs:string"">
        <xs:annotation>
          <xs:appinfo>
            <b:fieldInfo sequence_number=""6"" justification=""left"" pos_length=""23"" />
          </xs:appinfo>
        </xs:annotation>
      </xs:element>
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""ORSPCL-LINE-NBR"" type=""xs:string"">
        <xs:annotation>
          <xs:appinfo>
            <b:fieldInfo sequence_number=""7"" justification=""left"" pos_length=""5"" />
          </xs:appinfo>
        </xs:annotation>
      </xs:element>
      <xs:element minOccurs=""1"" maxOccurs=""1"" default=""O"" name=""ORSPCL-RECORD-TYPE"" type=""xs:string"">
        <xs:annotation>
          <xs:appinfo>
            <b:fieldInfo sequence_number=""8"" justification=""left"" pos_length=""3"" />
          </xs:appinfo>
        </xs:annotation>
      </xs:element>
      <xs:element minOccurs=""1"" maxOccurs=""1"" name=""ORSPCL-SEQ"" type=""xs:string"">
        <xs:annotation>
          <xs:appinfo>
            <b:fieldInfo sequence_number=""9"" justification=""left"" pos_length=""1"" />
          </xs:appinfo>
        </xs:annotation>
      </xs:element>
      <xs:element minOccurs=""1"" maxOccurs=""1"" name=""ORSPCL-INSTRUCTIONS"" type=""xs:string"">
        <xs:annotation>
          <xs:appinfo>
            <b:fieldInfo sequence_number=""10"" justification=""left"" pos_length=""35"" />
          </xs:appinfo>
        </xs:annotation>
      </xs:element>
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""ORSPCL-FILLER"" type=""xs:string"">
        <xs:annotation>
          <xs:appinfo>
            <b:fieldInfo sequence_number=""11"" justification=""left"" pos_length=""602"" />
          </xs:appinfo>
        </xs:annotation>
      </xs:element>
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""ORLXD-RECORDType"">
    <xs:sequence>
      <xs:annotation>
        <xs:appinfo>
          <b:groupInfo sequence_number=""0"" />
        </xs:appinfo>
      </xs:annotation>
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""ORLXD-COMPANY"" type=""xs:string"">
        <xs:annotation>
          <xs:appinfo>
            <b:fieldInfo sequence_number=""1"" justification=""left"" pos_length=""2"" />
          </xs:appinfo>
        </xs:annotation>
      </xs:element>
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""ORLXD-BR-NBR"" type=""xs:string"">
        <xs:annotation>
          <xs:appinfo>
            <b:fieldInfo sequence_number=""2"" justification=""left"" pos_length=""2"" />
          </xs:appinfo>
        </xs:annotation>
      </xs:element>
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""ORLXD-ORDER-NBR"" type=""xs:string"">
        <xs:annotation>
          <xs:appinfo>
            <b:fieldInfo sequence_number=""3"" justification=""left"" pos_length=""5"" />
          </xs:appinfo>
        </xs:annotation>
      </xs:element>
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""ORLXD-DIST-NBR"" type=""xs:string"">
        <xs:annotation>
          <xs:appinfo>
            <b:fieldInfo sequence_number=""4"" justification=""left"" pos_length=""1"" />
          </xs:appinfo>
        </xs:annotation>
      </xs:element>
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""ORLXD-SHIP-NBR"" type=""xs:string"">
        <xs:annotation>
          <xs:appinfo>
            <b:fieldInfo sequence_number=""5"" justification=""left"" pos_length=""1"" />
          </xs:appinfo>
        </xs:annotation>
      </xs:element>
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""ORLXD-ENTRY-DT"" type=""xs:string"">
        <xs:annotation>
          <xs:appinfo>
            <b:fieldInfo sequence_number=""6"" justification=""left"" pos_length=""23"" />
          </xs:appinfo>
        </xs:annotation>
      </xs:element>
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""ORLXD-LINE-NBR"" type=""xs:string"">
        <xs:annotation>
          <xs:appinfo>
            <b:fieldInfo sequence_number=""7"" justification=""left"" pos_length=""5"" />
          </xs:appinfo>
        </xs:annotation>
      </xs:element>
      <xs:element minOccurs=""1"" maxOccurs=""1"" default=""O"" name=""ORLXD-RECORD-TYPE"" type=""xs:string"">
        <xs:annotation>
          <xs:appinfo>
            <b:fieldInfo sequence_number=""8"" justification=""left"" pos_length=""3"" />
          </xs:appinfo>
        </xs:annotation>
      </xs:element>
      <xs:element minOccurs=""1"" maxOccurs=""1"" name=""ORLXD-LINE-DESC-NBR"" type=""xs:string"">
        <xs:annotation>
          <xs:appinfo>
            <b:fieldInfo sequence_number=""9"" justification=""left"" pos_length=""4"" />
          </xs:appinfo>
        </xs:annotation>
      </xs:element>
      <xs:element minOccurs=""1"" maxOccurs=""1"" name=""ORLXD-LINE-DESCRIPTION"" type=""xs:string"">
        <xs:annotation>
          <xs:appinfo>
            <b:fieldInfo sequence_number=""10"" justification=""left"" pos_length=""35"" />
          </xs:appinfo>
        </xs:annotation>
      </xs:element>
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""ORLXD-FILLER"" type=""xs:string"">
        <xs:annotation>
          <xs:appinfo>
            <b:fieldInfo sequence_number=""11"" justification=""left"" pos_length=""598"" />
          </xs:appinfo>
        </xs:annotation>
      </xs:element>
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""ORERR-RECORDType"">
    <xs:sequence>
      <xs:annotation>
        <xs:appinfo>
          <b:groupInfo sequence_number=""0"" />
        </xs:appinfo>
      </xs:annotation>
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""ORERR-COMPANY"" type=""xs:string"">
        <xs:annotation>
          <xs:appinfo>
            <b:fieldInfo sequence_number=""1"" justification=""left"" pos_length=""2"" />
          </xs:appinfo>
        </xs:annotation>
      </xs:element>
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""ORERR-BR-NBR"" type=""xs:string"">
        <xs:annotation>
          <xs:appinfo>
            <b:fieldInfo sequence_number=""2"" justification=""left"" pos_length=""2"" />
          </xs:appinfo>
        </xs:annotation>
      </xs:element>
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""ORERR-ORDER-NBR"" type=""xs:string"">
        <xs:annotation>
          <xs:appinfo>
            <b:fieldInfo sequence_number=""3"" justification=""left"" pos_length=""5"" />
          </xs:appinfo>
        </xs:annotation>
      </xs:element>
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""ORERR-DIST-NBR"" type=""xs:string"">
        <xs:annotation>
          <xs:appinfo>
            <b:fieldInfo sequence_number=""4"" justification=""left"" pos_length=""1"" />
          </xs:appinfo>
        </xs:annotation>
      </xs:element>
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""ORERR-SHIP-NBR"" type=""xs:string"">
        <xs:annotation>
          <xs:appinfo>
            <b:fieldInfo sequence_number=""5"" justification=""left"" pos_length=""1"" />
          </xs:appinfo>
        </xs:annotation>
      </xs:element>
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""ORERR-ENTRY-DT"" type=""xs:string"">
        <xs:annotation>
          <xs:appinfo>
            <b:fieldInfo sequence_number=""6"" justification=""left"" pos_length=""23"" />
          </xs:appinfo>
        </xs:annotation>
      </xs:element>
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""ORERR-LINE-NBR"" type=""xs:string"">
        <xs:annotation>
          <xs:appinfo>
            <b:fieldInfo sequence_number=""7"" justification=""left"" pos_length=""5"" />
          </xs:appinfo>
        </xs:annotation>
      </xs:element>
      <xs:element minOccurs=""1"" maxOccurs=""1"" default=""O"" name=""ORERR-RECORD-TYPE"" type=""xs:string"">
        <xs:annotation>
          <xs:appinfo>
            <b:fieldInfo sequence_number=""8"" justification=""left"" pos_length=""3"" />
          </xs:appinfo>
        </xs:annotation>
      </xs:element>
      <xs:element minOccurs=""1"" maxOccurs=""1"" name=""ORERR-ERROR-COUNT"" type=""xs:string"">
        <xs:annotation>
          <xs:appinfo>
            <b:fieldInfo sequence_number=""9"" justification=""left"" pos_length=""2"" />
          </xs:appinfo>
        </xs:annotation>
      </xs:element>
      <xs:element minOccurs=""1"" maxOccurs=""1"" name=""ORERR-ERROR-SEQ"" type=""xs:string"">
        <xs:annotation>
          <xs:appinfo>
            <b:fieldInfo sequence_number=""10"" justification=""left"" pos_length=""2"" />
          </xs:appinfo>
        </xs:annotation>
      </xs:element>
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""ORERR-ERROR-CODE"" type=""xs:string"">
        <xs:annotation>
          <xs:appinfo>
            <b:fieldInfo sequence_number=""11"" justification=""left"" pos_length=""2"" />
          </xs:appinfo>
        </xs:annotation>
      </xs:element>
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""ORERR-ERROR-TEXT"" type=""xs:string"">
        <xs:annotation>
          <xs:appinfo>
            <b:fieldInfo sequence_number=""12"" justification=""left"" pos_length=""251"" />
          </xs:appinfo>
        </xs:annotation>
      </xs:element>
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""ORERR-FILLER"" type=""xs:string"">
        <xs:annotation>
          <xs:appinfo>
            <b:fieldInfo sequence_number=""13"" justification=""left"" pos_length=""381"" />
          </xs:appinfo>
        </xs:annotation>
      </xs:element>
    </xs:sequence>
  </xs:complexType>
</xs:schema>";
        
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
                _RootElements[0] = "Message";
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
