<?xml version="1.0" encoding="utf-16"?>
<xsl:stylesheet xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
                xmlns:msxsl="urn:schemas-microsoft-com:xslt"
                exclude-result-prefixes="msxsl s0 userCSharp mappingUtil"
                version="1.0"
                xmlns:ns0="http://OM.BizTalk.AzureFeeds.Schemas.Canonicals_V1"
                xmlns:s0="http://OM.BizTalk.AzureFeeds.OMNI.Schemas.SalesOrder"
                xmlns:userCSharp="http://inlines"
                xmlns:mappingUtil="http://OM.BizTalk.AzureFeeds.OMNI.Maps/Ext">

	<xsl:output omit-xml-declaration="yes" method="xml" version="1.0" />

	<msxsl:script language="C#" implements-prefix="userCSharp">
		<![CDATA[
     System.Collections.Specialized.StringDictionary lineComments = new  System.Collections.Specialized.StringDictionary();
     
     public void AppendLineComments(string lineNumber, string comment)
     {
        string currentContent = comment;

        if(lineComments.ContainsKey(lineNumber))
        {
	        currentContent = lineComments[lineNumber] + " " + currentContent;
        }

        lineComments[lineNumber] = currentContent;
     }
     
     public string GetCombinedComment(string lineNumber)
     {
        if(lineComments.ContainsKey(lineNumber))
        {
	        return lineComments[lineNumber];
        }
        
        return System.String.Empty;
     }
     
     public string FormatCustId(string asIsCustId)
     {
        if(!System.String.IsNullOrWhiteSpace(asIsCustId) && asIsCustId.Length == 8)
        {
	        asIsCustId = asIsCustId.Substring(0,2) + "-" + asIsCustId.Substring(2);
        }
        
        return asIsCustId;
     }
         public string getguid()
    {
       return Guid.NewGuid().ToString();
    }
     ]]>
	</msxsl:script>

	<xsl:template match="/">
		<xsl:apply-templates select="/s0:Message" />
	</xsl:template>

	<xsl:template match="/s0:Message">
		<ns0:SalesOrder>
			<PrimaryCorrelationId xmlns="">00000000-0000-0000-0000-000000000000</PrimaryCorrelationId>
			<SourceActionDateTimeUTC xmlns="">
				<xsl:value-of select="mappingUtil:DefaultUTCDateTime()"/>
			</SourceActionDateTimeUTC>
			<SourceSystemDataId xmlns="">-1</SourceSystemDataId>
			<Key xmlns="">
				<EntryDate>
					<xsl:value-of select="mappingUtil:GetDateTimeFromOMNIDateTime(ORHDR-RECORD/ORHDR-ENTRY-DT/text())"/>
				</EntryDate>
				<SONumber>
					<xsl:value-of select="ORHDR-RECORD/ORHDR-ORDER-NBR/text()" />
				</SONumber>
				<ShipNumber>
					<xsl:value-of select="ORHDR-RECORD/ORHDR-SHIP-NBR/text()" />
				</ShipNumber>
				<DistNumber>
					<xsl:value-of select="ORHDR-RECORD/ORHDR-DIST-NBR/text()" />
				</DistNumber>
				<DC>
					<xsl:value-of select="ORHDR-RECORD/ORHDR-BR-NBR/text()" />
				</DC>
				<TriggerType>
					<xsl:value-of select="ORHDR-RECORD/ORHDR-TRIG-TYPE/text()" />
				</TriggerType>
				<TriggerMode>
					<xsl:value-of select="ORHDR-RECORD/ORHDR-TRIG-MODE/text()" />
				</TriggerMode>        
				<CaseRequestSwitch>
					<xsl:value-of select="ORHDR-RECORD/ORHDR-CASE-CREATE-SW/text()" />
				</CaseRequestSwitch>
				<ProcessMode>
					<xsl:value-of select="ORHDR-RECORD/ORHDR-PROCESS-SW/text()" />
				</ProcessMode>
			</Key>
			<xsl:if   test = "ORHDR-RECORD/ORHDR-TRIG-MODE/text()!='D'"> 
				<Header xmlns="">
					<Send810>
						<xsl:value-of select="mappingUtil:ConvertLowerCase(ORHDR-RECORD/ORHDR-SEND-810-FLAG/text())" />
					</Send810>
					<!-- ensure case "true "-->
					<AllowBackOrder>
						<xsl:value-of select="ORHDR-RECORD/ORHDR-BO-STATUS/text()" />
					</AllowBackOrder>
					<Attention>
						<xsl:value-of select="ORHDR-RECORD/ORHDR-ATTENTION/text()" />
					</Attention>
					<AccountNumber>
						<xsl:value-of select="ORHDR-RECORD/ORHDR-CUST-NBR/text()" />
					</AccountNumber>
					<!-- Is credit Memo tag added only if it has true value-->
					<xsl:if   test = "ORHDR-RECORD/ORHDR-CR-MEMO-SW/text()='true'"> 
						<IsCreditMemo>
							<xsl:value-of select="ORHDR-RECORD/ORHDR-CR-MEMO-SW/text()" />
						</IsCreditMemo>
					</xsl:if>
					<CreditReasonCode>
						<xsl:value-of select="ORHDR-RECORD/ORHDR-CR-MEMO-REASON/text()" />
					</CreditReasonCode>
					<CreditType>
						<xsl:value-of select="ORHDR-RECORD/ORHDR-CREDIT-TYPE/text()" />
					</CreditType>
					<Currency>
						<xsl:value-of select="ORHDR-RECORD/ORHDR-CURRENCY/text()" />
					</Currency>
					<CustomerPONumber>
						<xsl:value-of select="ORHDR-RECORD/ORHDR-CUST-PO-NBR/text()" />
					</CustomerPONumber>
					<OrderStatus>
            <xsl:value-of select="mappingUtil:ReplaceWhenEmpty(ORHDR-RECORD/ORHDR-ORDER-STATUS/text(),'OpenOrder')"/>
					</OrderStatus>
					<DeliveryRoute >
						<xsl:value-of select="ORHDR-RECORD/ORHDR-DEL-ROUTE/text()" />
					</DeliveryRoute>
					<EntryMethod>
						<xsl:value-of select="ORHDR-RECORD/ORHDR-ENTRY-METHOD/text()" />
					</EntryMethod>
					<ExtendedType>
						<xsl:value-of select="ORHDR-RECORD/ORHDR-EXT-TYPE/text()" />
					</ExtendedType>
					<FreightCode>
						<xsl:value-of select="ORHDR-RECORD/ORHDR-FRT-CODE/text()" />
					</FreightCode>
					<FreightAmount>
						<xsl:value-of select="mappingUtil:GetDecimalFromSignedString(ORHDR-RECORD/ORHDR-FRT-AMT/text())"/>
					</FreightAmount>
					<FromDC>
						<xsl:value-of select="ORHDR-RECORD/ORHDR-FROM-DC/text()" />
					</FromDC>
					<HandlingFee>
						<xsl:value-of select="mappingUtil:GetDecimalFromSignedString(ORHDR-RECORD/ORHDR-HANDLING-FEE/text())"/>
					</HandlingFee>
					<InvoiceNumber>
						<xsl:value-of select="ORHDR-RECORD/ORHDR-INVOICE-NBR/text()" />
					</InvoiceNumber>
					<ISN>
						<xsl:value-of select="ORHDR-RECORD/ORHDR-ISN/text()" />
					</ISN>
					<MasterSONumber>
						<xsl:value-of select="mappingUtil:GetNumberFromSignedString(ORHDR-RECORD/ORHDR-MASTER-SO-NBR/text())"/>
					</MasterSONumber>
					<MinOrderFee>
						<xsl:value-of select="mappingUtil:GetDecimalFromSignedString(ORHDR-RECORD/ORHDR-MIN-ORDER-FEE/text())"/>
					</MinOrderFee>
					<NewOrderFlag>
						<xsl:value-of select="ORHDR-RECORD/ORHDR-NEW-ORDER-FLAG/text()" />
					</NewOrderFlag>
					<NumberOfLines>
						<xsl:value-of select="mappingUtil:GetNumberFromSignedString(ORHDR-RECORD/ORHDR-NBR-OF-LINES/text())"/>
					</NumberOfLines>
					<CompanyID>
						<xsl:value-of select="ORHDR-RECORD/ORHDR-COMPANY/text()" />
					</CompanyID>
					<OrderMethod>
						<xsl:value-of select="ORHDR-RECORD/ORHDR-ORDER-METHOD/text()" />
					</OrderMethod>
					<OMOrderSubmitSource>OMNI</OMOrderSubmitSource>
					<OrderType>
						<xsl:value-of select="ORHDR-RECORD/ORHDR-ORDER-TYPE/text()" />
					</OrderType>
					<PaymentTerms>
						<xsl:value-of select="mappingUtil:GetNumberFromSignedString(ORHDR-RECORD/ORHDR-PAY-TERMS/text())"/>
					</PaymentTerms>
					<Priority>
						<xsl:value-of select="ORHDR-RECORD/ORHDR-PRIORITY/text()" />
					</Priority>
					<PromiseDate>
						<xsl:value-of select="mappingUtil:GetDateTimeFromOMNIDateTime(ORHDR-RECORD/ORHDR-PROMISE-DT/text())"/>
					</PromiseDate>
					<ReqDate>
						<xsl:value-of select="mappingUtil:GetDateTimeFromOMNIDateTime(ORHDR-RECORD/ORHDR-REQUIRED-DT/text())"/>
					</ReqDate>
					<ReleaseDate>
						<xsl:value-of select="mappingUtil:GetDateTimeFromOMNIDateTime(ORHDR-RECORD/ORHDR-RELEASE-DT/text())"/>
					</ReleaseDate>
					<ReqNumber>
						<xsl:value-of select="ORHDR-RECORD/ORHDR-REQ-NBR/text()" />
					</ReqNumber>
					<SalesTaxAmount>
						<xsl:value-of select="mappingUtil:GetDecimalFromSignedString(ORHDR-RECORD/ORHDR-SALES-TAX-AMT/text())"/>
					</SalesTaxAmount>
					<SalesTaxPercent>
						<xsl:value-of select="mappingUtil:GetDecimalFromSignedString(ORHDR-RECORD/ORHDR-SALES-TAX-PCT/text())"/>
					</SalesTaxPercent>
					<ShipDate>
						<xsl:value-of select="mappingUtil:GetDateTimeFromOMNIDateTime(ORHDR-RECORD/ORHDR-SHIP-DT/text())"/>
					</ShipDate>
					<ShipNumber>
						<xsl:value-of select="ORHDR-RECORD/ORHDR-SHIP-NBR/text()" />
					</ShipNumber>
					<ShipVia>
						<xsl:value-of select="ORHDR-RECORD/ORHDR-SHIP-VIA/text()" />
					</ShipVia>
					<TotalSales>
						<xsl:value-of select="mappingUtil:GetDecimalFromSignedString(ORHDR-RECORD/ORHDR-TOTAL-SALES/text())"/>
					</TotalSales>
					<ShipTo>
						<xsl:value-of select="ORHDR-RECORD/ORHDR-SHIP-TO-SUFFIX/text()" />
					</ShipTo>
					<CustId>
						<xsl:variable name="CurrentCustId" select="ORHDR-RECORD/ORHDR-CUST-ID/text()" />
						<xsl:value-of select="userCSharp:FormatCustId($CurrentCustId)"/>
					</CustId>
					<BillTo>
						<xsl:value-of select="ORHDR-RECORD/ORHDR-BILL-TO-SUFFIX/text()" />
					</BillTo>
					<ContractPricing>
						<xsl:value-of select="mappingUtil:ConvertLowerCase(ORHDR-RECORD/ORHDR-CONTRACT-PRICE-FLAG/text())" />
					</ContractPricing>
					<!-- ensure case "true "-->
					<InvoiceDate>
						<xsl:value-of select="mappingUtil:GetDateTimeFromOMNIDateTime(ORHDR-RECORD/ORHDR-INVOICE-DT/text())"/>
					</InvoiceDate>
				</Header>

				<!-- Before processing line, build up the line comment list -->
				<xsl:for-each select="/s0:Message/ORLXD-RECORD">
					<xsl:variable name="CurrentCommentLineNumber" select="ORLXD-LINE-DESC-NBR/text()" />
					<xsl:variable name="CurrentComment" select="ORLXD-LINE-DESCRIPTION/text()" />
					<xsl:value-of select="userCSharp:AppendLineComments($CurrentCommentLineNumber, $CurrentComment)"/>
				</xsl:for-each>          

				<Lines xmlns="">
					<xsl:for-each select="/s0:Message/ORLNE-RECORD">
						<xsl:variable name="CurrentLineNumber" select="ORLNE-LINE-NBR/text()" />
						<Line>
							<ApplyFee>
								<xsl:value-of select="mappingUtil:GetDecimalFromSignedString(ORLNE-APPLY-FEE/text())"/>
							</ApplyFee>
							<QtyBOBase>
								<xsl:value-of select="mappingUtil:GetNumberFromSignedString(ORLNE-BASE-BO-QTY/text())"/>
							</QtyBOBase>
							<UOMBaseFull>
								<xsl:value-of select="ORLNE-BASE-UM/text()" />
							</UOMBaseFull>
							<QtyOrderBase>
								<xsl:value-of select="mappingUtil:GetNumberFromSignedString(ORLNE-BASE-ORDER-QTY/text())"/>
							</QtyOrderBase>
							<QtyShippedBase>
								<xsl:value-of select="mappingUtil:GetNumberFromSignedString(ORLNE-BASE-SHIP-QTY/text())"/>              
							</QtyShippedBase>
							<UnitCostBase>
								<xsl:value-of select="mappingUtil:GetDecimalFromSignedString(ORLNE-UNIT-COST/text())"/>
							</UnitCostBase>
							<UnitPriceBase>
								<xsl:value-of select="mappingUtil:GetDecimalFromSignedString(ORLNE-UNIT-PRICE/text())"/>
							</UnitPriceBase>
							<BreakBulkUOM>
								<xsl:value-of select="ORLNE-BREAK-BULK-SW/text()" />
							</BreakBulkUOM>
							<BreakFee>
								<xsl:value-of select="mappingUtil:GetDecimalFromSignedString(ORLNE-BREAK-FEE/text())"/>
							</BreakFee>
							<CatalogNumber>
								<xsl:value-of select="ORLNE-CATALOG-NBR/text()" />
							</CatalogNumber>
							<Currency>USD</Currency>
							<QtyBOCust>
								<xsl:value-of select="mappingUtil:GetNumberFromSignedString(ORLNE-CUST-BO-QTY/text())"/>
							</QtyBOCust>
							<LineNumberCust>
								<xsl:value-of select="mappingUtil:GetNumberFromSignedString(ORLNE-CUST-LINE-NBR/text())"/>
							</LineNumberCust>
							<QtyOrderCust>
								<xsl:value-of select="mappingUtil:GetNumberFromSignedString(ORLNE-CUST-ORDER-QTY/text())"/>
							</QtyOrderCust>
							<CustomerProductNumber>
								<xsl:value-of select="ORLNE-CUST-PART-NBR/text()" />
							</CustomerProductNumber>
							<QtyShippedCust>
								<xsl:value-of select="mappingUtil:GetNumberFromSignedString(ORLNE-CUST-SHIP-QTY/text())"/>
							</QtyShippedCust>
							<CustTotalPrice>
								<xsl:value-of select="mappingUtil:GetDecimalFromSignedString(ORLNE-CUST-PRICE/text())"/>
							</CustTotalPrice>
							<UnitPriceCust>
								<xsl:value-of select="mappingUtil:GetDecimalFromSignedString(ORLNE-CUST-UNIT-PRICE/text())"/>
							</UnitPriceCust>
							<UOMCust>
								<xsl:value-of select="ORLNE-CUST-UM/text()" />
							</UOMCust>
							<DC>
								<xsl:value-of select="ORLNE-BR-NBR/text()" />
							</DC>
							<DropShipIBTPORtdQty>
								<xsl:value-of select="mappingUtil:GetNumberFromSignedString(ORLNE-DS-IBTPO-RCV-QTY/text())"/>
							</DropShipIBTPORtdQty>
							<DropShipIBTPOLineNumber>
								<xsl:value-of select="mappingUtil:GetNumberFromSignedString(ORLNE-DS-IBTPO-LINE-NBR/text())"/>       
							</DropShipIBTPOLineNumber>
							<DropShipIBTPONumber>
								<xsl:value-of select="mappingUtil:GetNumberFromSignedString(ORLNE-DS-IBT-PO-NBR/text())"/>       
							</DropShipIBTPONumber>
							<DropShipIBTPOStatus>
								<xsl:value-of select="ORLNE-DS-IBT-PO-STATUS/text()"/>       
							</DropShipIBTPOStatus>
							<ItemType>
								<xsl:value-of select="ORLNE-ITEM-TYPE/text()" />
							</ItemType>
							<LabelFee>
								<xsl:value-of select="mappingUtil:GetDecimalFromSignedString(ORLNE-LABEL-FEE/text())"/>              
							</LabelFee>
							<LineComments>
								<xsl:value-of select="userCSharp:GetCombinedComment($CurrentLineNumber)"/>
							</LineComments>
							<LineEntryDate>
								<xsl:value-of select="mappingUtil:GetDateTimeFromOMNIDateTime(ORLNE-LINE-ENTRY-DT/text())"/>
							</LineEntryDate>
							<LineSource>OM</LineSource>
							<LineStatus>
								<xsl:value-of select="ORLNE-LINE-STATUS/text()" />
							</LineStatus>
							<LineType>
								<xsl:value-of select="ORLNE-LINE-TYPE/text()" />
							</LineType>
							<LineNumberOM>
								<xsl:value-of select="mappingUtil:GetNumberFromSignedString(ORLNE-LINE-NBR/text())"/>
							</LineNumberOM>
							<ProductNumber>
								<xsl:value-of select="ORLNE-PRODUCT-NBR/text()" />
							</ProductNumber>
							<ProductDescription>
								<xsl:value-of select="ORLNE-PRODUCT-DESC/text()" />
							</ProductDescription>
							<PromiseDate>
								<xsl:value-of select="mappingUtil:GetDateTimeFromOMNIDateTime(ORLNE-PROMISE-DT/text())" />
							</PromiseDate>
							<RejectReason>
								<xsl:value-of select="mappingUtil:GetDateTimeFromOMNIDateTime(ORLNE-REJECT-REASON/text())" />
							</RejectReason>
							<RequiredDate>
								<xsl:value-of select="mappingUtil:GetDateTimeFromOMNIDateTimeDefaultMin(ORLNE-LINE-REQ-DT/text())"/>
							</RequiredDate>
							<ServiceFee>
								<xsl:value-of select="mappingUtil:GetDecimalFromSignedString(ORLNE-JIT-SERVICE-FEE/text())"/>
							</ServiceFee>
							<Status>
								<xsl:value-of select="ORLNE-LINE-STATUS/text()" />
							</Status>
							<TradeDiscount>
								<xsl:value-of select="mappingUtil:GetDecimalFromSignedString(ORLNE-TRADE-PCT/text())"/>             
							</TradeDiscount>
							<VendorNumber>
								<xsl:value-of select="ORLNE-VEND-NBR/text()" />
							</VendorNumber>
							<InventoryIndicator>
								<xsl:value-of select="ORLNE-INV-IND-CD/text()" />
							</InventoryIndicator>
							<SlowMovingInventorySw>
								<xsl:value-of select="ORLNE-SLOW-MOVE-INV-SW/text()" />
							</SlowMovingInventorySw>
							<DropShipOrigOrderQty>
								<xsl:value-of select="mappingUtil:GetNumberFromSignedString(ORLNE-DS-ORG-ORD-QTY/text())"/>   
							</DropShipOrigOrderQty>
						</Line>
					</xsl:for-each>
				</Lines>
				<SpecialInstructions xmlns="">
					<xsl:for-each select="/s0:Message/ORSPCL-RECORD">
						<Instruction>
							<ReferenceId>
								<xsl:value-of select="ORSPCL-SEQ/text()" />
							</ReferenceId>
							<Text>
								<xsl:value-of select="ORSPCL-INSTRUCTIONS/text()" />
							</Text>
						</Instruction>
					</xsl:for-each>
				</SpecialInstructions>
				<DeliveryInstructions xmlns="">
					<xsl:for-each select="/s0:Message/ORDLVR-RECORD">
						<Instruction>
							<ReferenceId>
								<xsl:value-of select="ORDLVR-SEQ/text()" />
							</ReferenceId>
							<Text>
								<xsl:value-of select="ORDLVR-INSTRUCTIONS/text()" />
							</Text>
						</Instruction>
					</xsl:for-each>
				</DeliveryInstructions>
				<Errors xmlns="">
					<xsl:for-each select="/s0:Message/ORERR-RECORD-Header">
						<Error>
							<LineNumberOM>
								<xsl:value-of select="mappingUtil:GetNumberFromSignedString(ORERR-LINE-NBR/text())" />
							</LineNumberOM>
							<ErrorCode>
								<xsl:value-of select="ORERR-ERROR-CODE/text()" />
							</ErrorCode>
							<ErrorText>
								<xsl:value-of select="ORERR-ERROR-TEXT/text()" />
							</ErrorText>
						</Error>
					</xsl:for-each>
					<xsl:for-each select="/s0:Message/ORERR-RECORD-Line">
						<Error>
							<LineNumberOM>
								<xsl:value-of select="mappingUtil:GetNumberFromSignedString(ORERR-LINE-NBR/text())" />
							</LineNumberOM>
							<ErrorCode>
								<xsl:value-of select="ORERR-ERROR-CODE/text()" />
							</ErrorCode>
							<ErrorText>
								<xsl:value-of select="ORERR-ERROR-TEXT/text()" />
							</ErrorText>
						</Error>
					</xsl:for-each>
				</Errors>
			</xsl:if> 
		</ns0:SalesOrder>
	</xsl:template>
</xsl:stylesheet>