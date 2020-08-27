// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.DelegationTaskInquiryDetail
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
  public class DelegationTaskInquiryDetail : ServiceData
  {
    [DataMember(EmitDefaultValue = false, Name = "DelegationTaskInquiryDetail_ApplicationType")]
    protected Enumeration<ApplicationTypeEnum, int> _ApplicationType;
    [DataMember(EmitDefaultValue = false, Name = "DelegationTaskInquiryDetail_DelegationReason")]
    protected NamedObjectRef _DelegationReason;
    [DataMember(EmitDefaultValue = false, Name = "DelegationTaskInquiryDetail_DelegationTask")]
    protected SubentityRef _DelegationTask;
    [DataMember(EmitDefaultValue = false, Name = "DelegationTaskInquiryDetail_DelegationStatus")]
    protected Enumeration<DelegationStatusEnum, int> _DelegationStatus;
    [DataMember(EmitDefaultValue = false, Name = "DelegationTaskInquiryDetail_StartDateGMT")]
    protected Primitive<DateTime> _StartDateGMT;
    [DataMember(EmitDefaultValue = false, Name = "DelegationTaskInquiryDetail_DelegationForwarding")]
    protected Primitive<bool> _DelegationForwarding;
    [DataMember(EmitDefaultValue = false, Name = "DelegationTaskInquiryDetail_EndDateGMT")]
    protected Primitive<DateTime> _EndDateGMT;
    [DataMember(EmitDefaultValue = false, Name = "DelegationTaskInquiryDetail_TasksDelegated")]
    protected Primitive<int> _TasksDelegated;
    [DataMember(EmitDefaultValue = false, Name = "DelegationTaskInquiryDetail_DelegatedBy")]
    protected NamedObjectRef _DelegatedBy;
    [DataMember(EmitDefaultValue = false, Name = "DelegationTaskInquiryDetail_AssignedEmployee")]
    protected NamedObjectRef _AssignedEmployee;
    [DataMember(EmitDefaultValue = false, Name = "DelegationTaskInquiryDetail_TargetEmployee")]
    protected NamedObjectRef _TargetEmployee;

    public override bool Equals(object obj)
    {
      return obj is DelegationTaskInquiryDetail && object.Equals((object) this._ApplicationType, (object) ((DelegationTaskInquiryDetail) obj)._ApplicationType) && (object.Equals((object) this._DelegationReason, (object) ((DelegationTaskInquiryDetail) obj)._DelegationReason) && object.Equals((object) this._DelegationTask, (object) ((DelegationTaskInquiryDetail) obj)._DelegationTask)) && (object.Equals((object) this._DelegationStatus, (object) ((DelegationTaskInquiryDetail) obj)._DelegationStatus) && object.Equals((object) this._StartDateGMT, (object) ((DelegationTaskInquiryDetail) obj)._StartDateGMT) && (object.Equals((object) this._DelegationForwarding, (object) ((DelegationTaskInquiryDetail) obj)._DelegationForwarding) && object.Equals((object) this._EndDateGMT, (object) ((DelegationTaskInquiryDetail) obj)._EndDateGMT))) && (object.Equals((object) this._TasksDelegated, (object) ((DelegationTaskInquiryDetail) obj)._TasksDelegated) && object.Equals((object) this._DelegatedBy, (object) ((DelegationTaskInquiryDetail) obj)._DelegatedBy) && (object.Equals((object) this._AssignedEmployee, (object) ((DelegationTaskInquiryDetail) obj)._AssignedEmployee) && object.Equals((object) this._TargetEmployee, (object) ((DelegationTaskInquiryDetail) obj)._TargetEmployee))) && base.Equals(obj);
    }

    public Enumeration<ApplicationTypeEnum, int> ApplicationType
    {
      [param: In] set
      {
        this.PropertySet(nameof (ApplicationType), (object) value);
      }
      get
      {
        return (Enumeration<ApplicationTypeEnum, int>) this.PropertyGet(nameof (ApplicationType));
      }
    }

    public NamedObjectRef DelegationReason
    {
      [param: In] set
      {
        this.PropertySet(nameof (DelegationReason), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (DelegationReason));
      }
    }

    public SubentityRef DelegationTask
    {
      [param: In] set
      {
        this.PropertySet(nameof (DelegationTask), (object) value);
      }
      get
      {
        return (SubentityRef) this.PropertyGet(nameof (DelegationTask));
      }
    }

    public Enumeration<DelegationStatusEnum, int> DelegationStatus
    {
      [param: In] set
      {
        this.PropertySet(nameof (DelegationStatus), (object) value);
      }
      get
      {
        return (Enumeration<DelegationStatusEnum, int>) this.PropertyGet(nameof (DelegationStatus));
      }
    }

    public Primitive<DateTime> StartDateGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (StartDateGMT), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (StartDateGMT));
      }
    }

    public Primitive<bool> DelegationForwarding
    {
      [param: In] set
      {
        this.PropertySet(nameof (DelegationForwarding), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (DelegationForwarding));
      }
    }

    public Primitive<DateTime> EndDateGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (EndDateGMT), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (EndDateGMT));
      }
    }

    public Primitive<int> TasksDelegated
    {
      [param: In] set
      {
        this.PropertySet(nameof (TasksDelegated), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (TasksDelegated));
      }
    }

    public NamedObjectRef DelegatedBy
    {
      [param: In] set
      {
        this.PropertySet(nameof (DelegatedBy), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (DelegatedBy));
      }
    }

    public NamedObjectRef AssignedEmployee
    {
      [param: In] set
      {
        this.PropertySet(nameof (AssignedEmployee), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (AssignedEmployee));
      }
    }

    public NamedObjectRef TargetEmployee
    {
      [param: In] set
      {
        this.PropertySet(nameof (TargetEmployee), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (TargetEmployee));
      }
    }
  }
}
