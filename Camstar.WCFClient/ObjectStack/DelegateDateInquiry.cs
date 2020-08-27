// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.DelegateDateInquiry
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
  public class DelegateDateInquiry : Inquiry
  {
    [DataMember(EmitDefaultValue = false, Name = "DelegateDateInquiry_ApplicationFilter")]
    protected Enumeration<ApplicationTypeEnum, int> _ApplicationFilter;
    [DataMember(EmitDefaultValue = false, Name = "DelegateDateInquiry_DelegationTasks")]
    protected DelegationTaskInquiryDetail[] _DelegationTasks;
    [DataMember(EmitDefaultValue = false, Name = "DelegateDateInquiry_DelegationReasonFilter")]
    protected NamedObjectRef _DelegationReasonFilter;
    [DataMember(EmitDefaultValue = false, Name = "DelegateDateInquiry_IsFuture")]
    protected Primitive<bool> _IsFuture;
    [DataMember(EmitDefaultValue = false, Name = "DelegateDateInquiry_IsActive")]
    protected Primitive<bool> _IsActive;
    [DataMember(EmitDefaultValue = false, Name = "DelegateDateInquiry_IsExpired")]
    protected Primitive<bool> _IsExpired;
    [DataMember(EmitDefaultValue = false, Name = "DelegateDateInquiry_DelegatedByFilter")]
    protected NamedObjectRef _DelegatedByFilter;
    [DataMember(EmitDefaultValue = false, Name = "DelegateDateInquiry_TargetEmployeeFilter")]
    protected NamedObjectRef _TargetEmployeeFilter;
    [DataMember(EmitDefaultValue = false, Name = "DelegateDateInquiry_AssignedEmployeeFilter")]
    protected NamedObjectRef _AssignedEmployeeFilter;

    public override bool Equals(object obj)
    {
      return obj is DelegateDateInquiry && object.Equals((object) this._ApplicationFilter, (object) ((DelegateDateInquiry) obj)._ApplicationFilter) && (this.CompareArrays((Array) this._DelegationTasks, (Array) ((DelegateDateInquiry) obj)._DelegationTasks) && object.Equals((object) this._DelegationReasonFilter, (object) ((DelegateDateInquiry) obj)._DelegationReasonFilter)) && (object.Equals((object) this._IsFuture, (object) ((DelegateDateInquiry) obj)._IsFuture) && object.Equals((object) this._IsActive, (object) ((DelegateDateInquiry) obj)._IsActive) && (object.Equals((object) this._IsExpired, (object) ((DelegateDateInquiry) obj)._IsExpired) && object.Equals((object) this._DelegatedByFilter, (object) ((DelegateDateInquiry) obj)._DelegatedByFilter))) && (object.Equals((object) this._TargetEmployeeFilter, (object) ((DelegateDateInquiry) obj)._TargetEmployeeFilter) && object.Equals((object) this._AssignedEmployeeFilter, (object) ((DelegateDateInquiry) obj)._AssignedEmployeeFilter)) && base.Equals(obj);
    }

    public Enumeration<ApplicationTypeEnum, int> ApplicationFilter
    {
      [param: In] set
      {
        this.PropertySet(nameof (ApplicationFilter), (object) value);
      }
      get
      {
        return (Enumeration<ApplicationTypeEnum, int>) this.PropertyGet(nameof (ApplicationFilter));
      }
    }

    public DelegationTaskInquiryDetail[] DelegationTasks
    {
      [param: In] set
      {
        this.PropertySet(nameof (DelegationTasks), (object) value);
      }
      get
      {
        return (DelegationTaskInquiryDetail[]) this.PropertyGet(nameof (DelegationTasks));
      }
    }

    public NamedObjectRef DelegationReasonFilter
    {
      [param: In] set
      {
        this.PropertySet(nameof (DelegationReasonFilter), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (DelegationReasonFilter));
      }
    }

    public Primitive<bool> IsFuture
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsFuture), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (IsFuture));
      }
    }

    public Primitive<bool> IsActive
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsActive), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (IsActive));
      }
    }

    public Primitive<bool> IsExpired
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsExpired), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (IsExpired));
      }
    }

    public NamedObjectRef DelegatedByFilter
    {
      [param: In] set
      {
        this.PropertySet(nameof (DelegatedByFilter), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (DelegatedByFilter));
      }
    }

    public NamedObjectRef TargetEmployeeFilter
    {
      [param: In] set
      {
        this.PropertySet(nameof (TargetEmployeeFilter), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (TargetEmployeeFilter));
      }
    }

    public NamedObjectRef AssignedEmployeeFilter
    {
      [param: In] set
      {
        this.PropertySet(nameof (AssignedEmployeeFilter), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (AssignedEmployeeFilter));
      }
    }
  }
}
