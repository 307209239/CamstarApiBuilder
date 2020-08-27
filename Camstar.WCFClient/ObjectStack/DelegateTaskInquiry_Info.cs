// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.DelegateTaskInquiry_Info
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
  public class DelegateTaskInquiry_Info : Inquiry_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "DelegateTaskInquiry_Info_DelegationTaskType")]
    protected Info _DelegationTaskType;
    [DataMember(EmitDefaultValue = false, Name = "DelegateTaskInquiry_Info_ApplicationType")]
    protected Info _ApplicationType;
    [DataMember(EmitDefaultValue = false, Name = "DelegateTaskInquiry_Info_DelegationTarget")]
    protected Info _DelegationTarget;
    [DataMember(EmitDefaultValue = false, Name = "DelegateTaskInquiry_Info_DueDateEnd")]
    protected Info _DueDateEnd;
    [DataMember(EmitDefaultValue = false, Name = "DelegateTaskInquiry_Info_TaskIsDue")]
    protected Info _TaskIsDue;
    [DataMember(EmitDefaultValue = false, Name = "DelegateTaskInquiry_Info_DueDateBegin")]
    protected Info _DueDateBegin;
    [DataMember(EmitDefaultValue = false, Name = "DelegateTaskInquiry_Info_AssignedEmployee")]
    protected Info _AssignedEmployee;
    [DataMember(EmitDefaultValue = false, Name = "DelegateTaskInquiry_Info_InstanceName")]
    protected Info _InstanceName;

    public Info DelegationTaskType
    {
      [param: In] set
      {
        this.PropertySet(nameof (DelegationTaskType), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (DelegationTaskType));
      }
    }

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

    public Info DelegationTarget
    {
      [param: In] set
      {
        this.PropertySet(nameof (DelegationTarget), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (DelegationTarget));
      }
    }

    public Info DueDateEnd
    {
      [param: In] set
      {
        this.PropertySet(nameof (DueDateEnd), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (DueDateEnd));
      }
    }

    public Info TaskIsDue
    {
      [param: In] set
      {
        this.PropertySet(nameof (TaskIsDue), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (TaskIsDue));
      }
    }

    public Info DueDateBegin
    {
      [param: In] set
      {
        this.PropertySet(nameof (DueDateBegin), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (DueDateBegin));
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

    public Info InstanceName
    {
      [param: In] set
      {
        this.PropertySet(nameof (InstanceName), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (InstanceName));
      }
    }
  }
}
