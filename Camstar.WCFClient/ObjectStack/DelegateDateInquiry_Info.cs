// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.DelegateDateInquiry_Info
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
  public class DelegateDateInquiry_Info : Inquiry_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "DelegateDateInquiry_Info_ApplicationFilter")]
    protected Info _ApplicationFilter;
    [DataMember(EmitDefaultValue = false, Name = "DelegateDateInquiry_Info_DelegationTasks")]
    protected DelegationTaskInquiryDetail_Info _DelegationTasks;
    [DataMember(EmitDefaultValue = false, Name = "DelegateDateInquiry_Info_DelegationReasonFilter")]
    protected Info _DelegationReasonFilter;
    [DataMember(EmitDefaultValue = false, Name = "DelegateDateInquiry_Info_IsFuture")]
    protected Info _IsFuture;
    [DataMember(EmitDefaultValue = false, Name = "DelegateDateInquiry_Info_IsActive")]
    protected Info _IsActive;
    [DataMember(EmitDefaultValue = false, Name = "DelegateDateInquiry_Info_IsExpired")]
    protected Info _IsExpired;
    [DataMember(EmitDefaultValue = false, Name = "DelegateDateInquiry_Info_DelegatedByFilter")]
    protected Info _DelegatedByFilter;
    [DataMember(EmitDefaultValue = false, Name = "DelegateDateInquiry_Info_TargetEmployeeFilter")]
    protected Info _TargetEmployeeFilter;
    [DataMember(EmitDefaultValue = false, Name = "DelegateDateInquiry_Info_AssignedEmployeeFilter")]
    protected Info _AssignedEmployeeFilter;

    public Info ApplicationFilter
    {
      [param: In] set
      {
        this.PropertySet(nameof (ApplicationFilter), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ApplicationFilter));
      }
    }

    public DelegationTaskInquiryDetail_Info DelegationTasks
    {
      [param: In] set
      {
        this.PropertySet(nameof (DelegationTasks), (object) value);
      }
      get
      {
        return (DelegationTaskInquiryDetail_Info) this.PropertyGet(nameof (DelegationTasks));
      }
    }

    public Info DelegationReasonFilter
    {
      [param: In] set
      {
        this.PropertySet(nameof (DelegationReasonFilter), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (DelegationReasonFilter));
      }
    }

    public Info IsFuture
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsFuture), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (IsFuture));
      }
    }

    public Info IsActive
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsActive), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (IsActive));
      }
    }

    public Info IsExpired
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsExpired), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (IsExpired));
      }
    }

    public Info DelegatedByFilter
    {
      [param: In] set
      {
        this.PropertySet(nameof (DelegatedByFilter), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (DelegatedByFilter));
      }
    }

    public Info TargetEmployeeFilter
    {
      [param: In] set
      {
        this.PropertySet(nameof (TargetEmployeeFilter), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (TargetEmployeeFilter));
      }
    }

    public Info AssignedEmployeeFilter
    {
      [param: In] set
      {
        this.PropertySet(nameof (AssignedEmployeeFilter), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (AssignedEmployeeFilter));
      }
    }
  }
}
