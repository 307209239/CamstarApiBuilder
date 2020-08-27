// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.FactoryChanges
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
  public class FactoryChanges : NamedDataObjectChanges
  {
    [DataMember(EmitDefaultValue = false, Name = "FactoryChanges_LocationItem")]
    protected LocationChanges _LocationItem;
    [DataMember(EmitDefaultValue = false, Name = "FactoryChanges_WIPMsgDefMgr")]
    protected WIPMsgDefMgrChanges _WIPMsgDefMgr;
    [DataMember(EmitDefaultValue = false, Name = "FactoryChanges_NCRLabelTxnMap")]
    protected NCRLabelMapChanges[] _NCRLabelTxnMap;
    [DataMember(EmitDefaultValue = false, Name = "FactoryChanges_GeneralMessage")]
    protected Primitive<string> _GeneralMessage;
    [DataMember(EmitDefaultValue = false, Name = "FactoryChanges_MfgCalendar")]
    protected NamedObjectRef _MfgCalendar;
    [DataMember(EmitDefaultValue = false, Name = "FactoryChanges_Locations")]
    protected LocationChanges[] _Locations;
    [DataMember(EmitDefaultValue = false, Name = "FactoryChanges_PrintQueue")]
    protected NamedObjectRef _PrintQueue;
    [DataMember(EmitDefaultValue = false, Name = "FactoryChanges_TrainingReqGroup")]
    protected NamedObjectRef _TrainingReqGroup;
    [DataMember(EmitDefaultValue = false, Name = "FactoryChanges_ESigTxnMap")]
    protected NCRESigTxnMapChanges[] _ESigTxnMap;
    [DataMember(EmitDefaultValue = false, Name = "FactoryChanges_SMTPTransport")]
    protected NamedObjectRef _SMTPTransport;
    [DataMember(EmitDefaultValue = false, Name = "FactoryChanges_DispatchRule")]
    protected NamedObjectRef _DispatchRule;
    [DataMember(EmitDefaultValue = false, Name = "FactoryChanges_ModelingObjsToExclude")]
    protected ModelingObjsToExcludeChanges[] _ModelingObjsToExclude;
    [DataMember(EmitDefaultValue = false, Name = "FactoryChanges_PELabelTxnMap")]
    protected PELabelMapChanges[] _PELabelTxnMap;
    [DataMember(EmitDefaultValue = false, Name = "FactoryChanges_ChangeMgtApplication")]
    protected NamedObjectRef _ChangeMgtApplication;
    [DataMember(EmitDefaultValue = false, Name = "FactoryChanges_Organization")]
    protected NamedObjectRef _Organization;
    [DataMember(EmitDefaultValue = false, Name = "FactoryChanges_ContainerNumberingRule")]
    protected NamedObjectRef _ContainerNumberingRule;
    [DataMember(EmitDefaultValue = false, Name = "FactoryChanges_RequireLocation")]
    protected Primitive<bool> _RequireLocation;
    [DataMember(EmitDefaultValue = false, Name = "FactoryChanges_DisplayGeneralMessage")]
    protected Primitive<bool> _DisplayGeneralMessage;
    [DataMember(EmitDefaultValue = false, Name = "FactoryChanges_Enterprise")]
    protected NamedObjectRef _Enterprise;
    [DataMember(EmitDefaultValue = false, Name = "FactoryChanges_RetentionDays")]
    protected Primitive<int> _RetentionDays;
    [DataMember(EmitDefaultValue = false, Name = "FactoryChanges_ReportHeading")]
    protected Primitive<string> _ReportHeading;
    [DataMember(EmitDefaultValue = false, Name = "FactoryChanges_MaxTimeSinceMsgsRetrieved")]
    protected Primitive<double> _MaxTimeSinceMsgsRetrieved;
    [DataMember(EmitDefaultValue = false, Name = "FactoryChanges_ObjectToChange")]
    protected new NamedObjectRef _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "FactoryChanges_Name")]
    protected new Primitive<string> _Name;

    public override bool Equals(object obj)
    {
      return obj is FactoryChanges && object.Equals((object) this._LocationItem, (object) ((FactoryChanges) obj)._LocationItem) && (object.Equals((object) this._WIPMsgDefMgr, (object) ((FactoryChanges) obj)._WIPMsgDefMgr) && this.CompareArrays((Array) this._NCRLabelTxnMap, (Array) ((FactoryChanges) obj)._NCRLabelTxnMap)) && (object.Equals((object) this._GeneralMessage, (object) ((FactoryChanges) obj)._GeneralMessage) && object.Equals((object) this._MfgCalendar, (object) ((FactoryChanges) obj)._MfgCalendar) && (this.CompareArrays((Array) this._Locations, (Array) ((FactoryChanges) obj)._Locations) && object.Equals((object) this._PrintQueue, (object) ((FactoryChanges) obj)._PrintQueue))) && (object.Equals((object) this._TrainingReqGroup, (object) ((FactoryChanges) obj)._TrainingReqGroup) && this.CompareArrays((Array) this._ESigTxnMap, (Array) ((FactoryChanges) obj)._ESigTxnMap) && (object.Equals((object) this._SMTPTransport, (object) ((FactoryChanges) obj)._SMTPTransport) && object.Equals((object) this._DispatchRule, (object) ((FactoryChanges) obj)._DispatchRule)) && (this.CompareArrays((Array) this._ModelingObjsToExclude, (Array) ((FactoryChanges) obj)._ModelingObjsToExclude) && this.CompareArrays((Array) this._PELabelTxnMap, (Array) ((FactoryChanges) obj)._PELabelTxnMap) && (object.Equals((object) this._ChangeMgtApplication, (object) ((FactoryChanges) obj)._ChangeMgtApplication) && object.Equals((object) this._Organization, (object) ((FactoryChanges) obj)._Organization)))) && (object.Equals((object) this._ContainerNumberingRule, (object) ((FactoryChanges) obj)._ContainerNumberingRule) && object.Equals((object) this._RequireLocation, (object) ((FactoryChanges) obj)._RequireLocation) && (object.Equals((object) this._DisplayGeneralMessage, (object) ((FactoryChanges) obj)._DisplayGeneralMessage) && object.Equals((object) this._Enterprise, (object) ((FactoryChanges) obj)._Enterprise)) && (object.Equals((object) this._RetentionDays, (object) ((FactoryChanges) obj)._RetentionDays) && object.Equals((object) this._ReportHeading, (object) ((FactoryChanges) obj)._ReportHeading) && (object.Equals((object) this._MaxTimeSinceMsgsRetrieved, (object) ((FactoryChanges) obj)._MaxTimeSinceMsgsRetrieved) && object.Equals((object) this._ObjectToChange, (object) ((FactoryChanges) obj)._ObjectToChange))) && object.Equals((object) this._Name, (object) ((FactoryChanges) obj)._Name)) && base.Equals(obj);
    }

    public LocationChanges LocationItem
    {
      [param: In] set
      {
        this.PropertySet(nameof (LocationItem), (object) value);
      }
      get
      {
        return (LocationChanges) this.PropertyGet(nameof (LocationItem));
      }
    }

    public WIPMsgDefMgrChanges WIPMsgDefMgr
    {
      [param: In] set
      {
        this.PropertySet(nameof (WIPMsgDefMgr), (object) value);
      }
      get
      {
        return (WIPMsgDefMgrChanges) this.PropertyGet(nameof (WIPMsgDefMgr));
      }
    }

    public NCRLabelMapChanges[] NCRLabelTxnMap
    {
      [param: In] set
      {
        this.PropertySet(nameof (NCRLabelTxnMap), (object) value);
      }
      get
      {
        return (NCRLabelMapChanges[]) this.PropertyGet(nameof (NCRLabelTxnMap));
      }
    }

    public Primitive<string> GeneralMessage
    {
      [param: In] set
      {
        this.PropertySet(nameof (GeneralMessage), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (GeneralMessage));
      }
    }

    public NamedObjectRef MfgCalendar
    {
      [param: In] set
      {
        this.PropertySet(nameof (MfgCalendar), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (MfgCalendar));
      }
    }

    public LocationChanges[] Locations
    {
      [param: In] set
      {
        this.PropertySet(nameof (Locations), (object) value);
      }
      get
      {
        return (LocationChanges[]) this.PropertyGet(nameof (Locations));
      }
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

    public NamedObjectRef TrainingReqGroup
    {
      [param: In] set
      {
        this.PropertySet(nameof (TrainingReqGroup), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (TrainingReqGroup));
      }
    }

    public NCRESigTxnMapChanges[] ESigTxnMap
    {
      [param: In] set
      {
        this.PropertySet(nameof (ESigTxnMap), (object) value);
      }
      get
      {
        return (NCRESigTxnMapChanges[]) this.PropertyGet(nameof (ESigTxnMap));
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

    public NamedObjectRef DispatchRule
    {
      [param: In] set
      {
        this.PropertySet(nameof (DispatchRule), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (DispatchRule));
      }
    }

    public ModelingObjsToExcludeChanges[] ModelingObjsToExclude
    {
      [param: In] set
      {
        this.PropertySet(nameof (ModelingObjsToExclude), (object) value);
      }
      get
      {
        return (ModelingObjsToExcludeChanges[]) this.PropertyGet(nameof (ModelingObjsToExclude));
      }
    }

    public PELabelMapChanges[] PELabelTxnMap
    {
      [param: In] set
      {
        this.PropertySet(nameof (PELabelTxnMap), (object) value);
      }
      get
      {
        return (PELabelMapChanges[]) this.PropertyGet(nameof (PELabelTxnMap));
      }
    }

    public NamedObjectRef ChangeMgtApplication
    {
      [param: In] set
      {
        this.PropertySet(nameof (ChangeMgtApplication), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (ChangeMgtApplication));
      }
    }

    public NamedObjectRef Organization
    {
      [param: In] set
      {
        this.PropertySet(nameof (Organization), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (Organization));
      }
    }

    public NamedObjectRef ContainerNumberingRule
    {
      [param: In] set
      {
        this.PropertySet(nameof (ContainerNumberingRule), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (ContainerNumberingRule));
      }
    }

    public Primitive<bool> RequireLocation
    {
      [param: In] set
      {
        this.PropertySet(nameof (RequireLocation), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (RequireLocation));
      }
    }

    public Primitive<bool> DisplayGeneralMessage
    {
      [param: In] set
      {
        this.PropertySet(nameof (DisplayGeneralMessage), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (DisplayGeneralMessage));
      }
    }

    public NamedObjectRef Enterprise
    {
      [param: In] set
      {
        this.PropertySet(nameof (Enterprise), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (Enterprise));
      }
    }

    public Primitive<int> RetentionDays
    {
      [param: In] set
      {
        this.PropertySet(nameof (RetentionDays), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (RetentionDays));
      }
    }

    public Primitive<string> ReportHeading
    {
      [param: In] set
      {
        this.PropertySet(nameof (ReportHeading), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (ReportHeading));
      }
    }

    public Primitive<double> MaxTimeSinceMsgsRetrieved
    {
      [param: In] set
      {
        this.PropertySet(nameof (MaxTimeSinceMsgsRetrieved), (object) value);
      }
      get
      {
        return (Primitive<double>) this.PropertyGet(nameof (MaxTimeSinceMsgsRetrieved));
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
