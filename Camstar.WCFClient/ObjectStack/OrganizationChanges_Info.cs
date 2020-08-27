// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.OrganizationChanges_Info
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
  public class OrganizationChanges_Info : NamedDataObjectChanges_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "OrganizationChanges_Info_PrintQueue")]
    protected Info _PrintQueue;
    [DataMember(EmitDefaultValue = false, Name = "OrganizationChanges_Info_SMTPTransport")]
    protected Info _SMTPTransport;
    [DataMember(EmitDefaultValue = false, Name = "OrganizationChanges_Info_ObjectToChange")]
    protected new Info _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "OrganizationChanges_Info_UIPreferenceMap")]
    protected UIPreferenceMapChanges_Info _UIPreferenceMap;
    [DataMember(EmitDefaultValue = false, Name = "OrganizationChanges_Info_EventClassificationSpecMaps")]
    protected EventClassSpecMapChanges_Info _EventClassificationSpecMaps;
    [DataMember(EmitDefaultValue = false, Name = "OrganizationChanges_Info_QualityProcessingMap")]
    protected QualityProcessingMapChanges_Info _QualityProcessingMap;
    [DataMember(EmitDefaultValue = false, Name = "OrganizationChanges_Info_ParentOrganization")]
    protected Info _ParentOrganization;
    [DataMember(EmitDefaultValue = false, Name = "OrganizationChanges_Info_QualityReportConfigs")]
    protected QualityReportConfigChanges_Info _QualityReportConfigs;
    [DataMember(EmitDefaultValue = false, Name = "OrganizationChanges_Info_PortalHomePage")]
    protected Info _PortalHomePage;
    [DataMember(EmitDefaultValue = false, Name = "OrganizationChanges_Info_NotificationEvents")]
    protected NotificationEventChanges_Info _NotificationEvents;
    [DataMember(EmitDefaultValue = false, Name = "OrganizationChanges_Info_CategoryMap")]
    protected CategoryMapChanges_Info _CategoryMap;
    [DataMember(EmitDefaultValue = false, Name = "OrganizationChanges_Info_NumberingRuleMap")]
    protected NumberingRuleMapChanges_Info _NumberingRuleMap;
    [DataMember(EmitDefaultValue = false, Name = "OrganizationChanges_Info_GEDisallowedTxns")]
    protected Info _GEDisallowedTxns;
    [DataMember(EmitDefaultValue = false, Name = "OrganizationChanges_Info_UserRequiredForEsig")]
    protected Info _UserRequiredForEsig;
    [DataMember(EmitDefaultValue = false, Name = "OrganizationChanges_Info_OrganizationNumber")]
    protected Info _OrganizationNumber;
    [DataMember(EmitDefaultValue = false, Name = "OrganizationChanges_Info_AffectedContainersTxns")]
    protected Info _AffectedContainersTxns;
    [DataMember(EmitDefaultValue = false, Name = "OrganizationChanges_Info_CollectESigForAllQualityTxns")]
    protected Info _CollectESigForAllQualityTxns;
    [DataMember(EmitDefaultValue = false, Name = "OrganizationChanges_Info_QualityESigTxns")]
    protected Info _QualityESigTxns;
    [DataMember(EmitDefaultValue = false, Name = "OrganizationChanges_Info_PEDisallowedTxns")]
    protected Info _PEDisallowedTxns;
    [DataMember(EmitDefaultValue = false, Name = "OrganizationChanges_Info_Name")]
    protected new Info _Name;

    public Info PrintQueue
    {
      [param: In] set
      {
        this.PropertySet(nameof (PrintQueue), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (PrintQueue));
      }
    }

    public Info SMTPTransport
    {
      [param: In] set
      {
        this.PropertySet(nameof (SMTPTransport), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (SMTPTransport));
      }
    }

    public new Info ObjectToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectToChange), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ObjectToChange));
      }
    }

    public UIPreferenceMapChanges_Info UIPreferenceMap
    {
      [param: In] set
      {
        this.PropertySet(nameof (UIPreferenceMap), (object) value);
      }
      get
      {
        return (UIPreferenceMapChanges_Info) this.PropertyGet(nameof (UIPreferenceMap));
      }
    }

    public EventClassSpecMapChanges_Info EventClassificationSpecMaps
    {
      [param: In] set
      {
        this.PropertySet(nameof (EventClassificationSpecMaps), (object) value);
      }
      get
      {
        return (EventClassSpecMapChanges_Info) this.PropertyGet(nameof (EventClassificationSpecMaps));
      }
    }

    public QualityProcessingMapChanges_Info QualityProcessingMap
    {
      [param: In] set
      {
        this.PropertySet(nameof (QualityProcessingMap), (object) value);
      }
      get
      {
        return (QualityProcessingMapChanges_Info) this.PropertyGet(nameof (QualityProcessingMap));
      }
    }

    public Info ParentOrganization
    {
      [param: In] set
      {
        this.PropertySet(nameof (ParentOrganization), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ParentOrganization));
      }
    }

    public QualityReportConfigChanges_Info QualityReportConfigs
    {
      [param: In] set
      {
        this.PropertySet(nameof (QualityReportConfigs), (object) value);
      }
      get
      {
        return (QualityReportConfigChanges_Info) this.PropertyGet(nameof (QualityReportConfigs));
      }
    }

    public Info PortalHomePage
    {
      [param: In] set
      {
        this.PropertySet(nameof (PortalHomePage), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (PortalHomePage));
      }
    }

    public NotificationEventChanges_Info NotificationEvents
    {
      [param: In] set
      {
        this.PropertySet(nameof (NotificationEvents), (object) value);
      }
      get
      {
        return (NotificationEventChanges_Info) this.PropertyGet(nameof (NotificationEvents));
      }
    }

    public CategoryMapChanges_Info CategoryMap
    {
      [param: In] set
      {
        this.PropertySet(nameof (CategoryMap), (object) value);
      }
      get
      {
        return (CategoryMapChanges_Info) this.PropertyGet(nameof (CategoryMap));
      }
    }

    public NumberingRuleMapChanges_Info NumberingRuleMap
    {
      [param: In] set
      {
        this.PropertySet(nameof (NumberingRuleMap), (object) value);
      }
      get
      {
        return (NumberingRuleMapChanges_Info) this.PropertyGet(nameof (NumberingRuleMap));
      }
    }

    public Info GEDisallowedTxns
    {
      [param: In] set
      {
        this.PropertySet(nameof (GEDisallowedTxns), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (GEDisallowedTxns));
      }
    }

    public Info UserRequiredForEsig
    {
      [param: In] set
      {
        this.PropertySet(nameof (UserRequiredForEsig), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (UserRequiredForEsig));
      }
    }

    public Info OrganizationNumber
    {
      [param: In] set
      {
        this.PropertySet(nameof (OrganizationNumber), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (OrganizationNumber));
      }
    }

    public Info AffectedContainersTxns
    {
      [param: In] set
      {
        this.PropertySet(nameof (AffectedContainersTxns), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (AffectedContainersTxns));
      }
    }

    public Info CollectESigForAllQualityTxns
    {
      [param: In] set
      {
        this.PropertySet(nameof (CollectESigForAllQualityTxns), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (CollectESigForAllQualityTxns));
      }
    }

    public Info QualityESigTxns
    {
      [param: In] set
      {
        this.PropertySet(nameof (QualityESigTxns), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (QualityESigTxns));
      }
    }

    public Info PEDisallowedTxns
    {
      [param: In] set
      {
        this.PropertySet(nameof (PEDisallowedTxns), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (PEDisallowedTxns));
      }
    }

    public new Info Name
    {
      [param: In] set
      {
        this.PropertySet(nameof (Name), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Name));
      }
    }
  }
}
