﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.Xml.Serialization;

// 
// This source code was auto-generated by xsd, Version=4.6.1055.0.
// 


/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn://www.fsc.org.au/DDO/Dealings/1.0")]
[System.Xml.Serialization.XmlRootAttribute("DealingsReport", Namespace="urn://www.fsc.org.au/DDO/Dealings/1.0", IsNullable=false)]
public partial class DealingsReportType {
    
    private ReportHeaderType headerField;
    
    private ReportBodyType bodyField;
    
    private DealingsReportFooterType footerField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=0)]
    public ReportHeaderType Header {
        get {
            return this.headerField;
        }
        set {
            this.headerField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=1)]
    public ReportBodyType Body {
        get {
            return this.bodyField;
        }
        set {
            this.bodyField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=2)]
    public DealingsReportFooterType Footer {
        get {
            return this.footerField;
        }
        set {
            this.footerField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn://www.fsc.org.au/DDO/Dealings/1.0")]
public partial class ReportHeaderType {
    
    private string reportIdentifierField;
    
    private System.DateTime reportExtractionDateTimeField;
    
    private ReportSelectionRangeType reportSelectionRangeField;
    
    private CurrentStandardVersion standardVersionField;
    
    private DealingsSelectionType reportTypeField;
    
    private bool reportTypeFieldSpecified;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=0)]
    public string ReportIdentifier {
        get {
            return this.reportIdentifierField;
        }
        set {
            this.reportIdentifierField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=1)]
    public System.DateTime ReportExtractionDateTime {
        get {
            return this.reportExtractionDateTimeField;
        }
        set {
            this.reportExtractionDateTimeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=2)]
    public ReportSelectionRangeType ReportSelectionRange {
        get {
            return this.reportSelectionRangeField;
        }
        set {
            this.reportSelectionRangeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(Form=System.Xml.Schema.XmlSchemaForm.Qualified, Namespace="urn://www.fsc.org.au/DDO/Common/1.0")]
    public CurrentStandardVersion StandardVersion {
        get {
            return this.standardVersionField;
        }
        set {
            this.standardVersionField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public DealingsSelectionType ReportType {
        get {
            return this.reportTypeField;
        }
        set {
            this.reportTypeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool ReportTypeSpecified {
        get {
            return this.reportTypeFieldSpecified;
        }
        set {
            this.reportTypeFieldSpecified = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn://www.fsc.org.au/DDO/Common/1.0")]
public partial class ReportSelectionRangeType {
    
    private System.DateTime selectionStartField;
    
    private System.DateTime selectionEndField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="date", Order=0)]
    public System.DateTime SelectionStart {
        get {
            return this.selectionStartField;
        }
        set {
            this.selectionStartField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="date", Order=1)]
    public System.DateTime SelectionEnd {
        get {
            return this.selectionEndField;
        }
        set {
            this.selectionEndField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn://www.fsc.org.au/DDO/Dealings/1.0")]
public partial class DealingsReportFooterType {
    
    private string countOfDealingsField;
    
    private decimal totalDealingsValueField;
    
    private bool totalDealingsValueFieldSpecified;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(DataType="integer")]
    public string CountOfDealings {
        get {
            return this.countOfDealingsField;
        }
        set {
            this.countOfDealingsField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal TotalDealingsValue {
        get {
            return this.totalDealingsValueField;
        }
        set {
            this.totalDealingsValueField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool TotalDealingsValueSpecified {
        get {
            return this.totalDealingsValueFieldSpecified;
        }
        set {
            this.totalDealingsValueFieldSpecified = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn://www.fsc.org.au/DDO/Dealings/1.0")]
public partial class TMDCharacteristicAssessmentType {
    
    private TMDCharacteristicEnum tMDCharacteristicField;
    
    private TMDIndicatorReasonEnum assessedValueField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=0)]
    public TMDCharacteristicEnum TMDCharacteristic {
        get {
            return this.tMDCharacteristicField;
        }
        set {
            this.tMDCharacteristicField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=1)]
    public TMDIndicatorReasonEnum AssessedValue {
        get {
            return this.assessedValueField;
        }
        set {
            this.assessedValueField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn://www.fsc.org.au/DDO/Common/1.0")]
public enum TMDCharacteristicEnum {
    
    /// <remarks/>
    InvestmentObjective_CapitalGrowth,
    
    /// <remarks/>
    InvestmentObjective_CapitalPreservation,
    
    /// <remarks/>
    InvestmentObjective_CapitalGuaranteed,
    
    /// <remarks/>
    InvestmentObjective_RegularIncome,
    
    /// <remarks/>
    InvestmentObjective_Specialist,
    
    /// <remarks/>
    ProductUse_SolutionStandalone,
    
    /// <remarks/>
    ProductUse_CoreComponent,
    
    /// <remarks/>
    ProductUse_Satellite,
    
    /// <remarks/>
    InvestmentTimeframe_Short,
    
    /// <remarks/>
    InvestmentTimeframe_Medium,
    
    /// <remarks/>
    InvestmentTimeframe_Long,
    
    /// <remarks/>
    RiskAndReturn_VeryHigh,
    
    /// <remarks/>
    RiskAndReturn_High,
    
    /// <remarks/>
    RiskAndReturn_Medium,
    
    /// <remarks/>
    RiskAndReturn_Low,
    
    /// <remarks/>
    RiskAndReturn_CapitalGuaranteed,
    
    /// <remarks/>
    RedemptionFrequency_Daily,
    
    /// <remarks/>
    RedemptionFrequency_Weekly,
    
    /// <remarks/>
    RedemptionFrequency_Monthly,
    
    /// <remarks/>
    RedemptionFrequency_Quarterly,
    
    /// <remarks/>
    RedemptionFrequency_AnnuallyPlus,
    
    /// <remarks/>
    Liquidity_Low,
    
    /// <remarks/>
    Liquidity_Moderate,
    
    /// <remarks/>
    Liquidity_High,
    
    /// <remarks/>
    Liquidity_VeryHigh,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn://www.fsc.org.au/DDO/Dealings/1.0")]
public enum TMDIndicatorReasonEnum {
    
    /// <remarks/>
    InTargetMarket,
    
    /// <remarks/>
    PotentiallyInTargetMarket,
    
    /// <remarks/>
    NotConsideredInTargetMarket,
    
    /// <remarks/>
    NoAssessment,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn://www.fsc.org.au/DDO/Common/1.0")]
public partial class ProductIdentifierType {
    
    private ProductIdentifierTypeEnum identifierTypeField;
    
    private string identifierValueField;
    
    private string disambiguationField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=0)]
    public ProductIdentifierTypeEnum IdentifierType {
        get {
            return this.identifierTypeField;
        }
        set {
            this.identifierTypeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=1)]
    public string IdentifierValue {
        get {
            return this.identifierValueField;
        }
        set {
            this.identifierValueField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=2)]
    public string Disambiguation {
        get {
            return this.disambiguationField;
        }
        set {
            this.disambiguationField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn://www.fsc.org.au/DDO/Common/1.0")]
public enum ProductIdentifierTypeEnum {
    
    /// <remarks/>
    ISIN,
    
    /// <remarks/>
    SPIN,
    
    /// <remarks/>
    APIR,
    
    /// <remarks/>
    ExchangeId,
    
    /// <remarks/>
    IssuerProvided,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn://www.fsc.org.au/DDO/Dealings/1.0")]
public partial class DealingDetailType {
    
    private DistributorTypeEnum distributorTypeField;
    
    private EntityIdentifierType distributorIdentifierField;
    
    private bool isDealingInsideTMDField;
    
    private bool isPersonalAdviceField;
    
    private string outsideTMDReasonField;
    
    private System.DateTime dateOfDealingField;
    
    private decimal sizeOfDealingField;
    
    private decimal unitsOfDealingField;
    
    private ProductIdentifierType productIdentifierField;
    
    private string tMDVersionField;
    
    private TMDProductTypeEnum dataStandardTypeField;
    
    private DataStandardVersionEnum dataStandardVersionUsedField;
    
    private TMDCharacteristicAssessmentType[] assessmentsField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=0)]
    public DistributorTypeEnum DistributorType {
        get {
            return this.distributorTypeField;
        }
        set {
            this.distributorTypeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=1)]
    public EntityIdentifierType DistributorIdentifier {
        get {
            return this.distributorIdentifierField;
        }
        set {
            this.distributorIdentifierField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=2)]
    public bool IsDealingInsideTMD {
        get {
            return this.isDealingInsideTMDField;
        }
        set {
            this.isDealingInsideTMDField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=3)]
    public bool IsPersonalAdvice {
        get {
            return this.isPersonalAdviceField;
        }
        set {
            this.isPersonalAdviceField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=4)]
    public string OutsideTMDReason {
        get {
            return this.outsideTMDReasonField;
        }
        set {
            this.outsideTMDReasonField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="date", Order=5)]
    public System.DateTime DateOfDealing {
        get {
            return this.dateOfDealingField;
        }
        set {
            this.dateOfDealingField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=6)]
    public decimal SizeOfDealing {
        get {
            return this.sizeOfDealingField;
        }
        set {
            this.sizeOfDealingField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=7)]
    public decimal UnitsOfDealing {
        get {
            return this.unitsOfDealingField;
        }
        set {
            this.unitsOfDealingField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=8)]
    public ProductIdentifierType ProductIdentifier {
        get {
            return this.productIdentifierField;
        }
        set {
            this.productIdentifierField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="integer", Order=9)]
    public string TMDVersion {
        get {
            return this.tMDVersionField;
        }
        set {
            this.tMDVersionField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=10)]
    public TMDProductTypeEnum DataStandardType {
        get {
            return this.dataStandardTypeField;
        }
        set {
            this.dataStandardTypeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=11)]
    public DataStandardVersionEnum DataStandardVersionUsed {
        get {
            return this.dataStandardVersionUsedField;
        }
        set {
            this.dataStandardVersionUsedField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlArrayAttribute(Order=12)]
    [System.Xml.Serialization.XmlArrayItemAttribute("Assessment", IsNullable=false)]
    public TMDCharacteristicAssessmentType[] Assessments {
        get {
            return this.assessmentsField;
        }
        set {
            this.assessmentsField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn://www.fsc.org.au/DDO/Common/1.0")]
public enum DistributorTypeEnum {
    
    /// <remarks/>
    Adviser,
    
    /// <remarks/>
    Platform,
    
    /// <remarks/>
    Aggregator,
    
    /// <remarks/>
    Promoter,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn://www.fsc.org.au/DDO/Common/1.0")]
public partial class EntityIdentifierType {
    
    private EntityIdentifierTypeEnum entityIdentifierType1Field;
    
    private string entityIdentifierValueField;
    
    private string subUnitField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("EntityIdentifierType", Order=0)]
    public EntityIdentifierTypeEnum EntityIdentifierType1 {
        get {
            return this.entityIdentifierType1Field;
        }
        set {
            this.entityIdentifierType1Field = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=1)]
    public string EntityIdentifierValue {
        get {
            return this.entityIdentifierValueField;
        }
        set {
            this.entityIdentifierValueField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=2)]
    public string SubUnit {
        get {
            return this.subUnitField;
        }
        set {
            this.subUnitField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn://www.fsc.org.au/DDO/Common/1.0")]
public enum EntityIdentifierTypeEnum {
    
    /// <remarks/>
    FAR,
    
    /// <remarks/>
    ABN,
    
    /// <remarks/>
    ASAL,
    
    /// <remarks/>
    ACL,
    
    /// <remarks/>
    Bespoke,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn://www.fsc.org.au/DDO/Common/1.0")]
public enum TMDProductTypeEnum {
    
    /// <remarks/>
    FundsManagement,
    
    /// <remarks/>
    Superannuation,
    
    /// <remarks/>
    LifeInsurance,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn://www.fsc.org.au/DDO/Common/1.0")]
public enum DataStandardVersionEnum {
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("1.0")]
    Item10,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn://www.fsc.org.au/DDO/Common/1.0")]
public partial class EntityRelationshipType {
    
    private EntityIdentifierType issuerEntityField;
    
    private EntityIdentifierType distributorEntityField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=0)]
    public EntityIdentifierType IssuerEntity {
        get {
            return this.issuerEntityField;
        }
        set {
            this.issuerEntityField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=1)]
    public EntityIdentifierType DistributorEntity {
        get {
            return this.distributorEntityField;
        }
        set {
            this.distributorEntityField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn://www.fsc.org.au/DDO/Common/1.0")]
public partial class ContactDetailsType {
    
    private string nameField;
    
    private string titleField;
    
    private string phoneField;
    
    private string emailField;
    
    private string addressField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=0)]
    public string Name {
        get {
            return this.nameField;
        }
        set {
            this.nameField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=1)]
    public string Title {
        get {
            return this.titleField;
        }
        set {
            this.titleField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=2)]
    public string Phone {
        get {
            return this.phoneField;
        }
        set {
            this.phoneField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=3)]
    public string Email {
        get {
            return this.emailField;
        }
        set {
            this.emailField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=4)]
    public string Address {
        get {
            return this.addressField;
        }
        set {
            this.addressField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn://www.fsc.org.au/DDO/Common/1.0")]
public partial class EntityDetailType {
    
    private EntityIdentifierType primaryIdField;
    
    private EntityIdentifierType[] alternativeIdsField;
    
    private string entityNameField;
    
    private EntityTypeEnum entityTypeField;
    
    private ContactDetailsType contactField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=0)]
    public EntityIdentifierType PrimaryId {
        get {
            return this.primaryIdField;
        }
        set {
            this.primaryIdField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlArrayAttribute(Order=1)]
    [System.Xml.Serialization.XmlArrayItemAttribute("Identifier", IsNullable=false)]
    public EntityIdentifierType[] AlternativeIds {
        get {
            return this.alternativeIdsField;
        }
        set {
            this.alternativeIdsField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=2)]
    public string EntityName {
        get {
            return this.entityNameField;
        }
        set {
            this.entityNameField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=3)]
    public EntityTypeEnum EntityType {
        get {
            return this.entityTypeField;
        }
        set {
            this.entityTypeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(Order=4)]
    public ContactDetailsType Contact {
        get {
            return this.contactField;
        }
        set {
            this.contactField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn://www.fsc.org.au/DDO/Common/1.0")]
public enum EntityTypeEnum {
    
    /// <remarks/>
    AdviceAFSL,
    
    /// <remarks/>
    Platform,
    
    /// <remarks/>
    NonAdviceAFSL,
    
    /// <remarks/>
    CreditLicensee,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn://www.fsc.org.au/DDO/Dealings/1.0")]
public partial class ReportBodyType {
    
    private EntityDetailType[] dealingEntitiesField;
    
    private EntityRelationshipType[] entityRelationshipsField;
    
    private DealingDetailType[] dealingsField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlArrayAttribute(Order=0)]
    [System.Xml.Serialization.XmlArrayItemAttribute("Entity", Namespace="urn://www.fsc.org.au/DDO/Common/1.0", IsNullable=false)]
    public EntityDetailType[] DealingEntities {
        get {
            return this.dealingEntitiesField;
        }
        set {
            this.dealingEntitiesField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlArrayAttribute(Order=1)]
    [System.Xml.Serialization.XmlArrayItemAttribute("EntityRelationship", Namespace="urn://www.fsc.org.au/DDO/Common/1.0", IsNullable=false)]
    public EntityRelationshipType[] EntityRelationships {
        get {
            return this.entityRelationshipsField;
        }
        set {
            this.entityRelationshipsField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlArrayAttribute(Order=2)]
    [System.Xml.Serialization.XmlArrayItemAttribute("TransactionDetail", IsNullable=false)]
    public DealingDetailType[] Dealings {
        get {
            return this.dealingsField;
        }
        set {
            this.dealingsField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn://www.fsc.org.au/DDO/Common/1.0")]
public enum CurrentStandardVersion {
    
    /// <remarks/>
    [System.Xml.Serialization.XmlEnumAttribute("1.0")]
    Item10,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn://www.fsc.org.au/DDO/Dealings/1.0")]
public enum DealingsSelectionType {
    
    /// <remarks/>
    ByDate,
    
    /// <remarks/>
    ById,
}
