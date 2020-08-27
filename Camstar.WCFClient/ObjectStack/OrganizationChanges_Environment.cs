// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.OrganizationChanges_Environment
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [Serializable]
  public class OrganizationChanges_Environment : NamedDataObjectChanges_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "OrganizationChanges_Environment_PrintQueue")]
    [Metadata("Printers InSite can use to print labels.", "PrintQueue", false, false, false, "NamedObjectRef", 1050609, false, false, true, null)]
    protected Environment _PrintQueue;
    [Metadata("SMTP Transport", "SMTPTransport", false, false, false, "NamedObjectRef", 1051749, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "OrganizationChanges_Environment_SMTPTransport")]
    protected Environment _SMTPTransport;
    [DataMember(EmitDefaultValue = false, Name = "OrganizationChanges_Environment_ObjectToChange")]
    [Metadata("Identifies the scope of organizational information that a user has access to", "Organization", false, false, false, "NamedObjectRef", 1048682, false, false, true, null)]
    protected new Environment _ObjectToChange;
    [Metadata("UI Preference Map", "UIPreferenceMapChanges", false, false, false, "UIPreferenceMapChanges", 1051579, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "OrganizationChanges_Environment_UIPreferenceMap")]
    protected UIPreferenceMapChanges_Environment _UIPreferenceMap;
    [Metadata("This subentity defines the valid classification/subclassification combinations for the organization.", "EventClassSpecMapChanges", false, false, false, "EventClassSpecMapChanges", 1051998, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "OrganizationChanges_Environment_EventClassificationSpecMaps")]
    protected EventClassSpecMapChanges_Environment _EventClassificationSpecMaps;
    [Metadata("Quality Processing Map", "QualityProcessingMapChanges", false, false, false, "QualityProcessingMapChanges", 1050618, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "OrganizationChanges_Environment_QualityProcessingMap")]
    protected QualityProcessingMapChanges_Environment _QualityProcessingMap;
    [DataMember(EmitDefaultValue = false, Name = "OrganizationChanges_Environment_ParentOrganization")]
    [Metadata("Identifies the scope of organizational information that a user has access to", "Organization", false, false, false, "NamedObjectRef", 1051422, false, false, true, null)]
    protected Environment _ParentOrganization;
    [Metadata("A Quality Report Configuration specifies what report page is displayed for each Action/Category/Classification/SubClassification combination.\r\n", "QualityReportConfigChanges", false, false, false, "QualityReportConfigChanges", 1052136, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "OrganizationChanges_Environment_QualityReportConfigs")]
    protected QualityReportConfigChanges_Environment _QualityReportConfigs;
    [Metadata("Virtual Page component for the UI Personalization Persistence Provider.", "UIVirtualPage", false, false, false, "NamedObjectRef", 1051760, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "OrganizationChanges_Environment_PortalHomePage")]
    protected Environment _PortalHomePage;
    [DataMember(EmitDefaultValue = false, Name = "OrganizationChanges_Environment_NotificationEvents")]
    [Metadata("Details for an Organization that is used to determine if an email will be sent.", "NotificationEventChanges", false, false, false, "NotificationEventChanges", 1051748, false, true, false, null)]
    protected NotificationEventChanges_Environment _NotificationEvents;
    [DataMember(EmitDefaultValue = false, Name = "OrganizationChanges_Environment_CategoryMap")]
    [Metadata("The CategoryMap sets up that relationship of the QualityObject's Category to a particular TriageSpec.", "CategoryMapChanges", false, false, false, "CategoryMapChanges", 1051648, false, true, false, null)]
    protected CategoryMapChanges_Environment _CategoryMap;
    [Metadata("Changes for mapping from a QualityObject (Category) to a numbering rule that will be used to auto generate names.", "NumberingRuleMapChanges", false, false, false, "NumberingRuleMapChanges", 1051466, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "OrganizationChanges_Environment_NumberingRuleMap")]
    protected NumberingRuleMapChanges_Environment _NumberingRuleMap;
    [DataMember(EmitDefaultValue = false, Name = "OrganizationChanges_Environment_GEDisallowedTxns")]
    [Metadata("CDO Definition Id", "", false, false, false, "Integer", 16779199, false, true, true, null)]
    protected Environment _GEDisallowedTxns;
    [DataMember(EmitDefaultValue = false, Name = "OrganizationChanges_Environment_UserRequiredForEsig")]
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1051790, false, false, false, "0")]
    protected Environment _UserRequiredForEsig;
    [DataMember(EmitDefaultValue = false, Name = "OrganizationChanges_Environment_OrganizationNumber")]
    [Metadata("Generic String", "", false, false, false, "String", 1051468, false, false, false, null)]
    protected Environment _OrganizationNumber;
    [DataMember(EmitDefaultValue = false, Name = "OrganizationChanges_Environment_AffectedContainersTxns")]
    [Metadata("CDO Definition Id", "", false, false, false, "Integer", 16779244, false, true, true, null)]
    protected Environment _AffectedContainersTxns;
    [DataMember(EmitDefaultValue = false, Name = "OrganizationChanges_Environment_CollectESigForAllQualityTxns")]
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1051789, false, false, false, "0")]
    protected Environment _CollectESigForAllQualityTxns;
    [Metadata("CDO Definition Id", "", false, false, false, "Integer", 1051693, false, true, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "OrganizationChanges_Environment_QualityESigTxns")]
    protected Environment _QualityESigTxns;
    [Metadata("CDO Definition Id", "", false, false, false, "Integer", 16779200, false, true, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "OrganizationChanges_Environment_PEDisallowedTxns")]
    protected Environment _PEDisallowedTxns;
    [DataMember(EmitDefaultValue = false, Name = "OrganizationChanges_Environment_Name")]
    [Metadata("Unique name for this instance", "", false, true, false, "String", 1051159, false, false, false, null)]
    protected new Environment _Name;

    public Environment PrintQueue
    {
      [param: In] set
      {
        this.PropertySet(nameof (PrintQueue), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (PrintQueue));
      }
    }

    public Environment SMTPTransport
    {
      [param: In] set
      {
        this.PropertySet(nameof (SMTPTransport), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (SMTPTransport));
      }
    }

    public new Environment ObjectToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectToChange), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ObjectToChange));
      }
    }

    public UIPreferenceMapChanges_Environment UIPreferenceMap
    {
      [param: In] set
      {
        this.PropertySet(nameof (UIPreferenceMap), (object) value);
      }
      get
      {
        return (UIPreferenceMapChanges_Environment) this.PropertyGet(nameof (UIPreferenceMap));
      }
    }

    public EventClassSpecMapChanges_Environment EventClassificationSpecMaps
    {
      [param: In] set
      {
        this.PropertySet(nameof (EventClassificationSpecMaps), (object) value);
      }
      get
      {
        return (EventClassSpecMapChanges_Environment) this.PropertyGet(nameof (EventClassificationSpecMaps));
      }
    }

    public QualityProcessingMapChanges_Environment QualityProcessingMap
    {
      [param: In] set
      {
        this.PropertySet(nameof (QualityProcessingMap), (object) value);
      }
      get
      {
        return (QualityProcessingMapChanges_Environment) this.PropertyGet(nameof (QualityProcessingMap));
      }
    }

    public Environment ParentOrganization
    {
      [param: In] set
      {
        this.PropertySet(nameof (ParentOrganization), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ParentOrganization));
      }
    }

    public QualityReportConfigChanges_Environment QualityReportConfigs
    {
      [param: In] set
      {
        this.PropertySet(nameof (QualityReportConfigs), (object) value);
      }
      get
      {
        return (QualityReportConfigChanges_Environment) this.PropertyGet(nameof (QualityReportConfigs));
      }
    }

    public Environment PortalHomePage
    {
      [param: In] set
      {
        this.PropertySet(nameof (PortalHomePage), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (PortalHomePage));
      }
    }

    public NotificationEventChanges_Environment NotificationEvents
    {
      [param: In] set
      {
        this.PropertySet(nameof (NotificationEvents), (object) value);
      }
      get
      {
        return (NotificationEventChanges_Environment) this.PropertyGet(nameof (NotificationEvents));
      }
    }

    public CategoryMapChanges_Environment CategoryMap
    {
      [param: In] set
      {
        this.PropertySet(nameof (CategoryMap), (object) value);
      }
      get
      {
        return (CategoryMapChanges_Environment) this.PropertyGet(nameof (CategoryMap));
      }
    }

    public NumberingRuleMapChanges_Environment NumberingRuleMap
    {
      [param: In] set
      {
        this.PropertySet(nameof (NumberingRuleMap), (object) value);
      }
      get
      {
        return (NumberingRuleMapChanges_Environment) this.PropertyGet(nameof (NumberingRuleMap));
      }
    }

    public Environment GEDisallowedTxns
    {
      [param: In] set
      {
        this.PropertySet(nameof (GEDisallowedTxns), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (GEDisallowedTxns));
      }
    }

    public Environment UserRequiredForEsig
    {
      [param: In] set
      {
        this.PropertySet(nameof (UserRequiredForEsig), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (UserRequiredForEsig));
      }
    }

    public Environment OrganizationNumber
    {
      [param: In] set
      {
        this.PropertySet(nameof (OrganizationNumber), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (OrganizationNumber));
      }
    }

    public Environment AffectedContainersTxns
    {
      [param: In] set
      {
        this.PropertySet(nameof (AffectedContainersTxns), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (AffectedContainersTxns));
      }
    }

    public Environment CollectESigForAllQualityTxns
    {
      [param: In] set
      {
        this.PropertySet(nameof (CollectESigForAllQualityTxns), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (CollectESigForAllQualityTxns));
      }
    }

    public Environment QualityESigTxns
    {
      [param: In] set
      {
        this.PropertySet(nameof (QualityESigTxns), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (QualityESigTxns));
      }
    }

    public Environment PEDisallowedTxns
    {
      [param: In] set
      {
        this.PropertySet(nameof (PEDisallowedTxns), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (PEDisallowedTxns));
      }
    }

    public new Environment Name
    {
      [param: In] set
      {
        this.PropertySet(nameof (Name), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Name));
      }
    }
  }
}
