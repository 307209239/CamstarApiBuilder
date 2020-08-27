// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.DelegationTaskInquiryDetail_Info
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
  public class DelegationTaskInquiryDetail_Info : ServiceData_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "DelegationTaskInquiryDetail_Info_ApplicationType")]
    protected Info _ApplicationType;
    [DataMember(EmitDefaultValue = false, Name = "DelegationTaskInquiryDetail_Info_DelegationReason")]
    protected Info _DelegationReason;
    [DataMember(EmitDefaultValue = false, Name = "DelegationTaskInquiryDetail_Info_DelegationTask")]
    protected Info _DelegationTask;
    [DataMember(EmitDefaultValue = false, Name = "DelegationTaskInquiryDetail_Info_DelegationStatus")]
    protected Info _DelegationStatus;
    [DataMember(EmitDefaultValue = false, Name = "DelegationTaskInquiryDetail_Info_StartDateGMT")]
    protected Info _StartDateGMT;
    [DataMember(EmitDefaultValue = false, Name = "DelegationTaskInquiryDetail_Info_DelegationForwarding")]
    protected Info _DelegationForwarding;
    [DataMember(EmitDefaultValue = false, Name = "DelegationTaskInquiryDetail_Info_EndDateGMT")]
    protected Info _EndDateGMT;
    [DataMember(EmitDefaultValue = false, Name = "DelegationTaskInquiryDetail_Info_TasksDelegated")]
    protected Info _TasksDelegated;
    [DataMember(EmitDefaultValue = false, Name = "DelegationTaskInquiryDetail_Info_DelegatedBy")]
    protected Info _DelegatedBy;
    [DataMember(EmitDefaultValue = false, Name = "DelegationTaskInquiryDetail_Info_AssignedEmployee")]
    protected Info _AssignedEmployee;
    [DataMember(EmitDefaultValue = false, Name = "DelegationTaskInquiryDetail_Info_TargetEmployee")]
    protected Info _TargetEmployee;

    public Info ApplicationType
    {
      [param: In] set
      {
        this.PropertySet(nameof (ApplicationType), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ApplicationType));
      }
    }

    public Info DelegationReason
    {
      [param: In] set
      {
        this.PropertySet(nameof (DelegationReason), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (DelegationReason));
      }
    }

    public Info DelegationTask
    {
      [param: In] set
      {
        this.PropertySet(nameof (DelegationTask), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (DelegationTask));
      }
    }

    public Info DelegationStatus
    {
      [param: In] set
      {
        this.PropertySet(nameof (DelegationStatus), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (DelegationStatus));
      }
    }

    public Info StartDateGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (StartDateGMT), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (StartDateGMT));
      }
    }

    public Info DelegationForwarding
    {
      [param: In] set
      {
        this.PropertySet(nameof (DelegationForwarding), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (DelegationForwarding));
      }
    }

    public Info EndDateGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (EndDateGMT), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (EndDateGMT));
      }
    }

    public Info TasksDelegated
    {
      [param: In] set
      {
        this.PropertySet(nameof (TasksDelegated), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (TasksDelegated));
      }
    }

    public Info DelegatedBy
    {
      [param: In] set
      {
        this.PropertySet(nameof (DelegatedBy), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (DelegatedBy));
      }
    }

    public Info AssignedEmployee
    {
      [param: In] set
      {
        this.PropertySet(nameof (AssignedEmployee), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (AssignedEmployee));
      }
    }

    public Info TargetEmployee
    {
      [param: In] set
      {
        this.PropertySet(nameof (TargetEmployee), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (TargetEmployee));
      }
    }
  }
}
