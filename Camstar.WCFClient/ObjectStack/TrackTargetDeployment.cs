// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.TrackTargetDeployment
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
  public class TrackTargetDeployment : ShopFloor
  {
    [DataMember(EmitDefaultValue = false, Name = "TrackTargetDeployment_Owner")]
    protected Primitive<string> _Owner;
    [DataMember(EmitDefaultValue = false, Name = "TrackTargetDeployment_ServiceDetails")]
    protected TargetDeploymentDetail[] _ServiceDetails;
    [DataMember(EmitDefaultValue = false, Name = "TrackTargetDeployment_Status")]
    protected Enumeration<TargetDeliveryStatusEnum, int> _Status;
    [DataMember(EmitDefaultValue = false, Name = "TrackTargetDeployment_TargetDeployments")]
    protected TargetDeploymentDetail[] _TargetDeployments;
    [DataMember(EmitDefaultValue = false, Name = "TrackTargetDeployment_ExportHeaderId")]
    protected Primitive<int> _ExportHeaderId;
    [DataMember(EmitDefaultValue = false, Name = "TrackTargetDeployment_ExportTargetId")]
    protected Primitive<int> _ExportTargetId;
    [DataMember(EmitDefaultValue = false, Name = "TrackTargetDeployment_LastUpdatedDateGMT")]
    protected Primitive<DateTime> _LastUpdatedDateGMT;
    [DataMember(EmitDefaultValue = false, Name = "TrackTargetDeployment_LastUpdatedDate")]
    protected Primitive<DateTime> _LastUpdatedDate;
    [DataMember(EmitDefaultValue = false, Name = "TrackTargetDeployment_Message")]
    protected Primitive<string> _Message;

    public override bool Equals(object obj)
    {
      return obj is TrackTargetDeployment && object.Equals((object) this._Owner, (object) ((TrackTargetDeployment) obj)._Owner) && (this.CompareArrays((Array) this._ServiceDetails, (Array) ((TrackTargetDeployment) obj)._ServiceDetails) && object.Equals((object) this._Status, (object) ((TrackTargetDeployment) obj)._Status)) && (this.CompareArrays((Array) this._TargetDeployments, (Array) ((TrackTargetDeployment) obj)._TargetDeployments) && object.Equals((object) this._ExportHeaderId, (object) ((TrackTargetDeployment) obj)._ExportHeaderId) && (object.Equals((object) this._ExportTargetId, (object) ((TrackTargetDeployment) obj)._ExportTargetId) && object.Equals((object) this._LastUpdatedDateGMT, (object) ((TrackTargetDeployment) obj)._LastUpdatedDateGMT))) && (object.Equals((object) this._LastUpdatedDate, (object) ((TrackTargetDeployment) obj)._LastUpdatedDate) && object.Equals((object) this._Message, (object) ((TrackTargetDeployment) obj)._Message)) && base.Equals(obj);
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

    public TargetDeploymentDetail[] ServiceDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (ServiceDetails), (object) value);
      }
      get
      {
        return (TargetDeploymentDetail[]) this.PropertyGet(nameof (ServiceDetails));
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

    public TargetDeploymentDetail[] TargetDeployments
    {
      [param: In] set
      {
        this.PropertySet(nameof (TargetDeployments), (object) value);
      }
      get
      {
        return (TargetDeploymentDetail[]) this.PropertyGet(nameof (TargetDeployments));
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
  }
}
