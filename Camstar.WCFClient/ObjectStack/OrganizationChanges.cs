// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.OrganizationChanges
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
  public class OrganizationChanges : NamedDataObjectChanges
  {
    [DataMember(EmitDefaultValue = false, Name = "OrganizationChanges_PrintQueue")]
    protected NamedObjectRef _PrintQueue;
    [DataMember(EmitDefaultValue = false, Name = "OrganizationChanges_SMTPTransport")]
    protected NamedObjectRef _SMTPTransport;
    [DataMember(EmitDefaultValue = false, Name = "OrganizationChanges_ObjectToChange")]
    protected new NamedObjectRef _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "OrganizationChanges_UIPreferenceMap")]
    protected UIPreferenceMapChanges[] _UIPreferenceMap;
    [DataMember(EmitDefaultValue = false, Name = "OrganizationChanges_EventClassificationSpecMaps")]
    protected EventClassSpecMapChanges[] _EventClassificationSpecMaps;
    [DataMember(EmitDefaultValue = false, Name = "OrganizationChanges_QualityProcessingMap")]
    protected QualityProcessingMapChanges[] _QualityProcessingMap;
    [DataMember(EmitDefaultValue = false, Name = "OrganizationChanges_ParentOrganization")]
    protected NamedObjectRef _ParentOrganization;
    [DataMember(EmitDefaultValue = false, Name = "OrganizationChanges_QualityReportConfigs")]
    protected QualityReportConfigChanges[] _QualityReportConfigs;
    [DataMember(EmitDefaultValue = false, Name = "OrganizationChanges_PortalHomePage")]
    protected NamedObjectRef _PortalHomePage;
    [DataMember(EmitDefaultValue = false, Name = "OrganizationChanges_NotificationEvents")]
    protected NotificationEventChanges[] _NotificationEvents;
    [DataMember(EmitDefaultValue = false, Name = "OrganizationChanges_CategoryMap")]
    protected CategoryMapChanges[] _CategoryMap;
    [DataMember(EmitDefaultValue = false, Name = "OrganizationChanges_NumberingRuleMap")]
    protected NumberingRuleMapChanges[] _NumberingRuleMap;
    [DataMember(EmitDefaultValue = false, Name = "OrganizationChanges_GEDisallowedTxns")]
    protected Primitive<int>[] _GEDisallowedTxns;
    [DataMember(EmitDefaultValue = false, Name = "OrganizationChanges_UserRequiredForEsig")]
    protected Primitive<bool> _UserRequiredForEsig;
    [DataMember(EmitDefaultValue = false, Name = "OrganizationChanges_OrganizationNumber")]
    protected Primitive<string> _OrganizationNumber;
    [DataMember(EmitDefaultValue = false, Name = "OrganizationChanges_AffectedContainersTxns")]
    protected Primitive<int>[] _AffectedContainersTxns;
    [DataMember(EmitDefaultValue = false, Name = "OrganizationChanges_CollectESigForAllQualityTxns")]
    protected Primitive<bool> _CollectESigForAllQualityTxns;
    [DataMember(EmitDefaultValue = false, Name = "OrganizationChanges_QualityESigTxns")]
    protected Primitive<int>[] _QualityESigTxns;
    [DataMember(EmitDefaultValue = false, Name = "OrganizationChanges_PEDisallowedTxns")]
    protected Primitive<int>[] _PEDisallowedTxns;
    [DataMember(EmitDefaultValue = false, Name = "OrganizationChanges_Name")]
    protected new Primitive<string> _Name;

    public override bool Equals(object obj)
    {
      return obj is OrganizationChanges && object.Equals((object) this._PrintQueue, (object) ((OrganizationChanges) obj)._PrintQueue) && (object.Equals((object) this._SMTPTransport, (object) ((OrganizationChanges) obj)._SMTPTransport) && object.Equals((object) this._ObjectToChange, (object) ((OrganizationChanges) obj)._ObjectToChange)) && (this.CompareArrays((Array) this._UIPreferenceMap, (Array) ((OrganizationChanges) obj)._UIPreferenceMap) && this.CompareArrays((Array) this._EventClassificationSpecMaps, (Array) ((OrganizationChanges) obj)._EventClassificationSpecMaps) && (this.CompareArrays((Array) this._QualityProcessingMap, (Array) ((OrganizationChanges) obj)._QualityProcessingMap) && object.Equals((object) this._ParentOrganization, (object) ((OrganizationChanges) obj)._ParentOrganization))) && (this.CompareArrays((Array) this._QualityReportConfigs, (Array) ((OrganizationChanges) obj)._QualityReportConfigs) && object.Equals((object) this._PortalHomePage, (object) ((OrganizationChanges) obj)._PortalHomePage) && (this.CompareArrays((Array) this._NotificationEvents, (Array) ((OrganizationChanges) obj)._NotificationEvents) && this.CompareArrays((Array) this._CategoryMap, (Array) ((OrganizationChanges) obj)._CategoryMap)) && (this.CompareArrays((Array) this._NumberingRuleMap, (Array) ((OrganizationChanges) obj)._NumberingRuleMap) && this.CompareArrays((Array) this._GEDisallowedTxns, (Array) ((OrganizationChanges) obj)._GEDisallowedTxns) && (object.Equals((object) this._UserRequiredForEsig, (object) ((OrganizationChanges) obj)._UserRequiredForEsig) && object.Equals((object) this._OrganizationNumber, (object) ((OrganizationChanges) obj)._OrganizationNumber)))) && (this.CompareArrays((Array) this._AffectedContainersTxns, (Array) ((OrganizationChanges) obj)._AffectedContainersTxns) && object.Equals((object) this._CollectESigForAllQualityTxns, (object) ((OrganizationChanges) obj)._CollectESigForAllQualityTxns) && (this.CompareArrays((Array) this._QualityESigTxns, (Array) ((OrganizationChanges) obj)._QualityESigTxns) && this.CompareArrays((Array) this._PEDisallowedTxns, (Array) ((OrganizationChanges) obj)._PEDisallowedTxns)) && object.Equals((object) this._Name, (object) ((OrganizationChanges) obj)._Name)) && base.Equals(obj);
    }

    public NamedObjectRef PrintQueue
    {
      [param: In] set
      {
        this.PropertySet(nameof (PrintQueue), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (PrintQueue));
      }
    }

    public NamedObjectRef SMTPTransport
    {
      [param: In] set
      {
        this.PropertySet(nameof (SMTPTransport), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (SMTPTransport));
      }
    }

    public new NamedObjectRef ObjectToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectToChange), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (ObjectToChange));
      }
    }

    public UIPreferenceMapChanges[] UIPreferenceMap
    {
      [param: In] set
      {
        this.PropertySet(nameof (UIPreferenceMap), (object) value);
      }
      get
      {
        return (UIPreferenceMapChanges[]) this.PropertyGet(nameof (UIPreferenceMap));
      }
    }

    public EventClassSpecMapChanges[] EventClassificationSpecMaps
    {
      [param: In] set
      {
        this.PropertySet(nameof (EventClassificationSpecMaps), (object) value);
      }
      get
      {
        return (EventClassSpecMapChanges[]) this.PropertyGet(nameof (EventClassificationSpecMaps));
      }
    }

    public QualityProcessingMapChanges[] QualityProcessingMap
    {
      [param: In] set
      {
        this.PropertySet(nameof (QualityProcessingMap), (object) value);
      }
      get
      {
        return (QualityProcessingMapChanges[]) this.PropertyGet(nameof (QualityProcessingMap));
      }
    }

    public NamedObjectRef ParentOrganization
    {
      [param: In] set
      {
        this.PropertySet(nameof (ParentOrganization), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (ParentOrganization));
      }
    }

    public QualityReportConfigChanges[] QualityReportConfigs
    {
      [param: In] set
      {
        this.PropertySet(nameof (QualityReportConfigs), (object) value);
      }
      get
      {
        return (QualityReportConfigChanges[]) this.PropertyGet(nameof (QualityReportConfigs));
      }
    }

    public NamedObjectRef PortalHomePage
    {
      [param: In] set
      {
        this.PropertySet(nameof (PortalHomePage), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (PortalHomePage));
      }
    }

    public NotificationEventChanges[] NotificationEvents
    {
      [param: In] set
      {
        this.PropertySet(nameof (NotificationEvents), (object) value);
      }
      get
      {
        return (NotificationEventChanges[]) this.PropertyGet(nameof (NotificationEvents));
      }
    }

    public CategoryMapChanges[] CategoryMap
    {
      [param: In] set
      {
        this.PropertySet(nameof (CategoryMap), (object) value);
      }
      get
      {
        return (CategoryMapChanges[]) this.PropertyGet(nameof (CategoryMap));
      }
    }

    public NumberingRuleMapChanges[] NumberingRuleMap
    {
      [param: In] set
      {
        this.PropertySet(nameof (NumberingRuleMap), (object) value);
      }
      get
      {
        return (NumberingRuleMapChanges[]) this.PropertyGet(nameof (NumberingRuleMap));
      }
    }

    public Primitive<int>[] GEDisallowedTxns
    {
      [param: In] set
      {
        this.PropertySet(nameof (GEDisallowedTxns), (object) value);
      }
      get
      {
        return (Primitive<int>[]) this.PropertyGet(nameof (GEDisallowedTxns));
      }
    }

    public Primitive<bool> UserRequiredForEsig
    {
      [param: In] set
      {
        this.PropertySet(nameof (UserRequiredForEsig), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (UserRequiredForEsig));
      }
    }

    public Primitive<string> OrganizationNumber
    {
      [param: In] set
      {
        this.PropertySet(nameof (OrganizationNumber), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (OrganizationNumber));
      }
    }

    public Primitive<int>[] AffectedContainersTxns
    {
      [param: In] set
      {
        this.PropertySet(nameof (AffectedContainersTxns), (object) value);
      }
      get
      {
        return (Primitive<int>[]) this.PropertyGet(nameof (AffectedContainersTxns));
      }
    }

    public Primitive<bool> CollectESigForAllQualityTxns
    {
      [param: In] set
      {
        this.PropertySet(nameof (CollectESigForAllQualityTxns), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (CollectESigForAllQualityTxns));
      }
    }

    public Primitive<int>[] QualityESigTxns
    {
      [param: In] set
      {
        this.PropertySet(nameof (QualityESigTxns), (object) value);
      }
      get
      {
        return (Primitive<int>[]) this.PropertyGet(nameof (QualityESigTxns));
      }
    }

    public Primitive<int>[] PEDisallowedTxns
    {
      [param: In] set
      {
        this.PropertySet(nameof (PEDisallowedTxns), (object) value);
      }
      get
      {
        return (Primitive<int>[]) this.PropertyGet(nameof (PEDisallowedTxns));
      }
    }

    public new Primitive<string> Name
    {
      [param: In] set
      {
        this.PropertySet(nameof (Name), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (Name));
      }
    }
  }
}
