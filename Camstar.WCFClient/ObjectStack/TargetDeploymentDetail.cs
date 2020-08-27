// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.TargetDeploymentDetail
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
  public class TargetDeploymentDetail : ServiceDetails
  {
    [DataMember(EmitDefaultValue = false, Name = "TargetDeploymentDetail_StatusName")]
    protected Primitive<string> _StatusName;
    [DataMember(EmitDefaultValue = false, Name = "TargetDeploymentDetail_Owner")]
    protected Primitive<string> _Owner;
    [DataMember(EmitDefaultValue = false, Name = "TargetDeploymentDetail_TargetDeployment")]
    protected SubentityRef _TargetDeployment;
    [DataMember(EmitDefaultValue = false, Name = "TargetDeploymentDetail_TrackableObject")]
    protected BaseObjectRef _TrackableObject;
    [DataMember(EmitDefaultValue = false, Name = "TargetDeploymentDetail_TargetSystem")]
    protected TargetSystem _TargetSystem;
    [DataMember(EmitDefaultValue = false, Name = "TargetDeploymentDetail_Status")]
    protected Enumeration<TargetDeliveryStatusEnum, int> _Status;
    [DataMember(EmitDefaultValue = false, Name = "TargetDeploymentDetail_ExportTargetId")]
    protected Primitive<int> _ExportTargetId;
    [DataMember(EmitDefaultValue = false, Name = "TargetDeploymentDetail_ExportHeaderId")]
    protected Primitive<int> _ExportHeaderId;
    [DataMember(EmitDefaultValue = false, Name = "TargetDeploymentDetail_LastUpdatedDate")]
    protected Primitive<DateTime> _LastUpdatedDate;
    [DataMember(EmitDefaultValue = false, Name = "TargetDeploymentDetail_LastUpdatedDateGMT")]
    protected Primitive<DateTime> _LastUpdatedDateGMT;
    [DataMember(EmitDefaultValue = false, Name = "TargetDeploymentDetail_ExportDateGMT")]
    protected Primitive<DateTime> _ExportDateGMT;
    [DataMember(EmitDefaultValue = false, Name = "TargetDeploymentDetail_ImportSequence")]
    protected Primitive<int> _ImportSequence;
    [DataMember(EmitDefaultValue = false, Name = "TargetDeploymentDetail_ExportDate")]
    protected Primitive<DateTime> _ExportDate;
    [DataMember(EmitDefaultValue = false, Name = "TargetDeploymentDetail_Message")]
    protected Primitive<string> _Message;
    [DataMember(EmitDefaultValue = false, Name = "TargetDeploymentDetail_TargetSystemName")]
    protected Primitive<string> _TargetSystemName;

    public override bool Equals(object obj)
    {
      return obj is TargetDeploymentDetail && object.Equals((object) this._StatusName, (object) ((TargetDeploymentDetail) obj)._StatusName) && (object.Equals((object) this._Owner, (object) ((TargetDeploymentDetail) obj)._Owner) && object.Equals((object) this._TargetDeployment, (object) ((TargetDeploymentDetail) obj)._TargetDeployment)) && (object.Equals((object) this._TrackableObject, (object) ((TargetDeploymentDetail) obj)._TrackableObject) && object.Equals((object) this._TargetSystem, (object) ((TargetDeploymentDetail) obj)._TargetSystem) && (object.Equals((object) this._Status, (object) ((TargetDeploymentDetail) obj)._Status) && object.Equals((object) this._ExportTargetId, (object) ((TargetDeploymentDetail) obj)._ExportTargetId))) && (object.Equals((object) this._ExportHeaderId, (object) ((TargetDeploymentDetail) obj)._ExportHeaderId) && object.Equals((object) this._LastUpdatedDate, (object) ((TargetDeploymentDetail) obj)._LastUpdatedDate) && (object.Equals((object) this._LastUpdatedDateGMT, (object) ((TargetDeploymentDetail) obj)._LastUpdatedDateGMT) && object.Equals((object) this._ExportDateGMT, (object) ((TargetDeploymentDetail) obj)._ExportDateGMT)) && (object.Equals((object) this._ImportSequence, (object) ((TargetDeploymentDetail) obj)._ImportSequence) && object.Equals((object) this._ExportDate, (object) ((TargetDeploymentDetail) obj)._ExportDate) && (object.Equals((object) this._Message, (object) ((TargetDeploymentDetail) obj)._Message) && object.Equals((object) this._TargetSystemName, (object) ((TargetDeploymentDetail) obj)._TargetSystemName)))) && base.Equals(obj);
    }

    public Primitive<string> StatusName
    {
      [param: In] set
      {
        this.PropertySet(nameof (StatusName), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (StatusName));
      }
    }

    public Primitive<string> Owner
    {
      [param: In] set
      {
        this.PropertySet(nameof (Owner), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (Owner));
      }
    }

    public SubentityRef TargetDeployment
    {
      [param: In] set
      {
        this.PropertySet(nameof (TargetDeployment), (object) value);
      }
      get
      {
        return (SubentityRef) this.PropertyGet(nameof (TargetDeployment));
      }
    }

    public BaseObjectRef TrackableObject
    {
      [param: In] set
      {
        this.PropertySet(nameof (TrackableObject), (object) value);
      }
      get
      {
        return (BaseObjectRef) this.PropertyGet(nameof (TrackableObject));
      }
    }

    public TargetSystem TargetSystem
    {
      [param: In] set
      {
        this.PropertySet(nameof (TargetSystem), (object) value);
      }
      get
      {
        return (TargetSystem) this.PropertyGet(nameof (TargetSystem));
      }
    }

    public Enumeration<TargetDeliveryStatusEnum, int> Status
    {
      [param: In] set
      {
        this.PropertySet(nameof (Status), (object) value);
      }
      get
      {
        return (Enumeration<TargetDeliveryStatusEnum, int>) this.PropertyGet(nameof (Status));
      }
    }

    public Primitive<int> ExportTargetId
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExportTargetId), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (ExportTargetId));
      }
    }

    public Primitive<int> ExportHeaderId
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExportHeaderId), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (ExportHeaderId));
      }
    }

    public Primitive<DateTime> LastUpdatedDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (LastUpdatedDate), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (LastUpdatedDate));
      }
    }

    public Primitive<DateTime> LastUpdatedDateGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (LastUpdatedDateGMT), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (LastUpdatedDateGMT));
      }
    }

    public Primitive<DateTime> ExportDateGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExportDateGMT), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (ExportDateGMT));
      }
    }

    public Primitive<int> ImportSequence
    {
      [param: In] set
      {
        this.PropertySet(nameof (ImportSequence), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (ImportSequence));
      }
    }

    public Primitive<DateTime> ExportDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExportDate), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (ExportDate));
      }
    }

    public Primitive<string> Message
    {
      [param: In] set
      {
        this.PropertySet(nameof (Message), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (Message));
      }
    }

    public Primitive<string> TargetSystemName
    {
      [param: In] set
      {
        this.PropertySet(nameof (TargetSystemName), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (TargetSystemName));
      }
    }
  }
}
