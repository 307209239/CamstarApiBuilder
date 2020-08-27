// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.WorkCenterChanges
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
  public class WorkCenterChanges : NamedDataObjectChanges
  {
    [DataMember(EmitDefaultValue = false, Name = "WorkCenterChanges_ResourceGroup")]
    protected NamedObjectRef _ResourceGroup;
    [DataMember(EmitDefaultValue = false, Name = "WorkCenterChanges_MfgCalendar")]
    protected NamedObjectRef _MfgCalendar;
    [DataMember(EmitDefaultValue = false, Name = "WorkCenterChanges_Image")]
    protected Primitive<string> _Image;
    [DataMember(EmitDefaultValue = false, Name = "WorkCenterChanges_WIPMsgDefMgr")]
    protected WIPMsgDefMgrChanges _WIPMsgDefMgr;
    [DataMember(EmitDefaultValue = false, Name = "WorkCenterChanges_DispatchRule")]
    protected NamedObjectRef _DispatchRule;
    [DataMember(EmitDefaultValue = false, Name = "WorkCenterChanges_TrainingReqGroup")]
    protected NamedObjectRef _TrainingReqGroup;
    [DataMember(EmitDefaultValue = false, Name = "WorkCenterChanges_FastQueueTime")]
    protected Primitive<double> _FastQueueTime;
    [DataMember(EmitDefaultValue = false, Name = "WorkCenterChanges_NormalQueueTime")]
    protected Primitive<double> _NormalQueueTime;
    [DataMember(EmitDefaultValue = false, Name = "WorkCenterChanges_Name")]
    protected new Primitive<string> _Name;
    [DataMember(EmitDefaultValue = false, Name = "WorkCenterChanges_ObjectToChange")]
    protected new NamedObjectRef _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "WorkCenterChanges_DispatchMethod")]
    protected Primitive<int> _DispatchMethod;
    [DataMember(EmitDefaultValue = false, Name = "WorkCenterChanges_WorkSchedule")]
    protected NamedObjectRef _WorkSchedule;

    public override bool Equals(object obj)
    {
      return obj is WorkCenterChanges && object.Equals((object) this._ResourceGroup, (object) ((WorkCenterChanges) obj)._ResourceGroup) && (object.Equals((object) this._MfgCalendar, (object) ((WorkCenterChanges) obj)._MfgCalendar) && object.Equals((object) this._Image, (object) ((WorkCenterChanges) obj)._Image)) && (object.Equals((object) this._WIPMsgDefMgr, (object) ((WorkCenterChanges) obj)._WIPMsgDefMgr) && object.Equals((object) this._DispatchRule, (object) ((WorkCenterChanges) obj)._DispatchRule) && (object.Equals((object) this._TrainingReqGroup, (object) ((WorkCenterChanges) obj)._TrainingReqGroup) && object.Equals((object) this._FastQueueTime, (object) ((WorkCenterChanges) obj)._FastQueueTime))) && (object.Equals((object) this._NormalQueueTime, (object) ((WorkCenterChanges) obj)._NormalQueueTime) && object.Equals((object) this._Name, (object) ((WorkCenterChanges) obj)._Name) && (object.Equals((object) this._ObjectToChange, (object) ((WorkCenterChanges) obj)._ObjectToChange) && object.Equals((object) this._DispatchMethod, (object) ((WorkCenterChanges) obj)._DispatchMethod)) && object.Equals((object) this._WorkSchedule, (object) ((WorkCenterChanges) obj)._WorkSchedule)) && base.Equals(obj);
    }

    public NamedObjectRef ResourceGroup
    {
      [param: In] set
      {
        this.PropertySet(nameof (ResourceGroup), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (ResourceGroup));
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

    public Primitive<string> Image
    {
      [param: In] set
      {
        this.PropertySet(nameof (Image), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (Image));
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

    public Primitive<double> FastQueueTime
    {
      [param: In] set
      {
        this.PropertySet(nameof (FastQueueTime), (object) value);
      }
      get
      {
        return (Primitive<double>) this.PropertyGet(nameof (FastQueueTime));
      }
    }

    public Primitive<double> NormalQueueTime
    {
      [param: In] set
      {
        this.PropertySet(nameof (NormalQueueTime), (object) value);
      }
      get
      {
        return (Primitive<double>) this.PropertyGet(nameof (NormalQueueTime));
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

    public Primitive<int> DispatchMethod
    {
      [param: In] set
      {
        this.PropertySet(nameof (DispatchMethod), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (DispatchMethod));
      }
    }

    public NamedObjectRef WorkSchedule
    {
      [param: In] set
      {
        this.PropertySet(nameof (WorkSchedule), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (WorkSchedule));
      }
    }
  }
}
