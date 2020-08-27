// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.FactoryChanges_Info
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
  public class FactoryChanges_Info : NamedDataObjectChanges_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "FactoryChanges_Info_LocationItem")]
    protected LocationChanges_Info _LocationItem;
    [DataMember(EmitDefaultValue = false, Name = "FactoryChanges_Info_WIPMsgDefMgr")]
    protected WIPMsgDefMgrChanges_Info _WIPMsgDefMgr;
    [DataMember(EmitDefaultValue = false, Name = "FactoryChanges_Info_NCRLabelTxnMap")]
    protected NCRLabelMapChanges_Info _NCRLabelTxnMap;
    [DataMember(EmitDefaultValue = false, Name = "FactoryChanges_Info_GeneralMessage")]
    protected Info _GeneralMessage;
    [DataMember(EmitDefaultValue = false, Name = "FactoryChanges_Info_MfgCalendar")]
    protected Info _MfgCalendar;
    [DataMember(EmitDefaultValue = false, Name = "FactoryChanges_Info_Locations")]
    protected LocationChanges_Info _Locations;
    [DataMember(EmitDefaultValue = false, Name = "FactoryChanges_Info_PrintQueue")]
    protected Info _PrintQueue;
    [DataMember(EmitDefaultValue = false, Name = "FactoryChanges_Info_TrainingReqGroup")]
    protected Info _TrainingReqGroup;
    [DataMember(EmitDefaultValue = false, Name = "FactoryChanges_Info_ESigTxnMap")]
    protected NCRESigTxnMapChanges_Info _ESigTxnMap;
    [DataMember(EmitDefaultValue = false, Name = "FactoryChanges_Info_SMTPTransport")]
    protected Info _SMTPTransport;
    [DataMember(EmitDefaultValue = false, Name = "FactoryChanges_Info_DispatchRule")]
    protected Info _DispatchRule;
    [DataMember(EmitDefaultValue = false, Name = "FactoryChanges_Info_ModelingObjsToExclude")]
    protected ModelingObjsToExcludeChanges_Info _ModelingObjsToExclude;
    [DataMember(EmitDefaultValue = false, Name = "FactoryChanges_Info_PELabelTxnMap")]
    protected PELabelMapChanges_Info _PELabelTxnMap;
    [DataMember(EmitDefaultValue = false, Name = "FactoryChanges_Info_ChangeMgtApplication")]
    protected Info _ChangeMgtApplication;
    [DataMember(EmitDefaultValue = false, Name = "FactoryChanges_Info_Organization")]
    protected Info _Organization;
    [DataMember(EmitDefaultValue = false, Name = "FactoryChanges_Info_ContainerNumberingRule")]
    protected Info _ContainerNumberingRule;
    [DataMember(EmitDefaultValue = false, Name = "FactoryChanges_Info_RequireLocation")]
    protected Info _RequireLocation;
    [DataMember(EmitDefaultValue = false, Name = "FactoryChanges_Info_DisplayGeneralMessage")]
    protected Info _DisplayGeneralMessage;
    [DataMember(EmitDefaultValue = false, Name = "FactoryChanges_Info_Enterprise")]
    protected Info _Enterprise;
    [DataMember(EmitDefaultValue = false, Name = "FactoryChanges_Info_RetentionDays")]
    protected Info _RetentionDays;
    [DataMember(EmitDefaultValue = false, Name = "FactoryChanges_Info_ReportHeading")]
    protected Info _ReportHeading;
    [DataMember(EmitDefaultValue = false, Name = "FactoryChanges_Info_MaxTimeSinceMsgsRetrieved")]
    protected Info _MaxTimeSinceMsgsRetrieved;
    [DataMember(EmitDefaultValue = false, Name = "FactoryChanges_Info_ObjectToChange")]
    protected new Info _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "FactoryChanges_Info_Name")]
    protected new Info _Name;

    public LocationChanges_Info LocationItem
    {
      [param: In] set
      {
        this.PropertySet(nameof (LocationItem), (object) value);
      }
      get
      {
        return (LocationChanges_Info) this.PropertyGet(nameof (LocationItem));
      }
    }

    public WIPMsgDefMgrChanges_Info WIPMsgDefMgr
    {
      [param: In] set
      {
        this.PropertySet(nameof (WIPMsgDefMgr), (object) value);
      }
      get
      {
        return (WIPMsgDefMgrChanges_Info) this.PropertyGet(nameof (WIPMsgDefMgr));
      }
    }

    public NCRLabelMapChanges_Info NCRLabelTxnMap
    {
      [param: In] set
      {
        this.PropertySet(nameof (NCRLabelTxnMap), (object) value);
      }
      get
      {
        return (NCRLabelMapChanges_Info) this.PropertyGet(nameof (NCRLabelTxnMap));
      }
    }

    public Info GeneralMessage
    {
      [param: In] set
      {
        this.PropertySet(nameof (GeneralMessage), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (GeneralMessage));
      }
    }

    public Info MfgCalendar
    {
      [param: In] set
      {
        this.PropertySet(nameof (MfgCalendar), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (MfgCalendar));
      }
    }

    public LocationChanges_Info Locations
    {
      [param: In] set
      {
        this.PropertySet(nameof (Locations), (object) value);
      }
      get
      {
        return (LocationChanges_Info) this.PropertyGet(nameof (Locations));
      }
    }

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

    public Info TrainingReqGroup
    {
      [param: In] set
      {
        this.PropertySet(nameof (TrainingReqGroup), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (TrainingReqGroup));
      }
    }

    public NCRESigTxnMapChanges_Info ESigTxnMap
    {
      [param: In] set
      {
        this.PropertySet(nameof (ESigTxnMap), (object) value);
      }
      get
      {
        return (NCRESigTxnMapChanges_Info) this.PropertyGet(nameof (ESigTxnMap));
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

    public Info DispatchRule
    {
      [param: In] set
      {
        this.PropertySet(nameof (DispatchRule), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (DispatchRule));
      }
    }

    public ModelingObjsToExcludeChanges_Info ModelingObjsToExclude
    {
      [param: In] set
      {
        this.PropertySet(nameof (ModelingObjsToExclude), (object) value);
      }
      get
      {
        return (ModelingObjsToExcludeChanges_Info) this.PropertyGet(nameof (ModelingObjsToExclude));
      }
    }

    public PELabelMapChanges_Info PELabelTxnMap
    {
      [param: In] set
      {
        this.PropertySet(nameof (PELabelTxnMap), (object) value);
      }
      get
      {
        return (PELabelMapChanges_Info) this.PropertyGet(nameof (PELabelTxnMap));
      }
    }

    public Info ChangeMgtApplication
    {
      [param: In] set
      {
        this.PropertySet(nameof (ChangeMgtApplication), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ChangeMgtApplication));
      }
    }

    public Info Organization
    {
      [param: In] set
      {
        this.PropertySet(nameof (Organization), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Organization));
      }
    }

    public Info ContainerNumberingRule
    {
      [param: In] set
      {
        this.PropertySet(nameof (ContainerNumberingRule), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ContainerNumberingRule));
      }
    }

    public Info RequireLocation
    {
      [param: In] set
      {
        this.PropertySet(nameof (RequireLocation), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (RequireLocation));
      }
    }

    public Info DisplayGeneralMessage
    {
      [param: In] set
      {
        this.PropertySet(nameof (DisplayGeneralMessage), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (DisplayGeneralMessage));
      }
    }

    public Info Enterprise
    {
      [param: In] set
      {
        this.PropertySet(nameof (Enterprise), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Enterprise));
      }
    }

    public Info RetentionDays
    {
      [param: In] set
      {
        this.PropertySet(nameof (RetentionDays), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (RetentionDays));
      }
    }

    public Info ReportHeading
    {
      [param: In] set
      {
        this.PropertySet(nameof (ReportHeading), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ReportHeading));
      }
    }

    public Info MaxTimeSinceMsgsRetrieved
    {
      [param: In] set
      {
        this.PropertySet(nameof (MaxTimeSinceMsgsRetrieved), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (MaxTimeSinceMsgsRetrieved));
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
