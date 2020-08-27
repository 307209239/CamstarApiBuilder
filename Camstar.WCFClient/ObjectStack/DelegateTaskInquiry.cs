// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.DelegateTaskInquiry
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
  public class DelegateTaskInquiry : Inquiry
  {
    [DataMember(EmitDefaultValue = false, Name = "DelegateTaskInquiry_DelegationTaskType")]
    protected Enumeration<DelegationTaskTypeEnum, int> _DelegationTaskType;
    [DataMember(EmitDefaultValue = false, Name = "DelegateTaskInquiry_ApplicationType")]
    protected Enumeration<ApplicationTypeEnum, int> _ApplicationType;
    [DataMember(EmitDefaultValue = false, Name = "DelegateTaskInquiry_DelegationTarget")]
    protected BaseObjectRef _DelegationTarget;
    [DataMember(EmitDefaultValue = false, Name = "DelegateTaskInquiry_DueDateEnd")]
    protected Primitive<DateTime> _DueDateEnd;
    [DataMember(EmitDefaultValue = false, Name = "DelegateTaskInquiry_TaskIsDue")]
    protected Primitive<bool> _TaskIsDue;
    [DataMember(EmitDefaultValue = false, Name = "DelegateTaskInquiry_DueDateBegin")]
    protected Primitive<DateTime> _DueDateBegin;
    [DataMember(EmitDefaultValue = false, Name = "DelegateTaskInquiry_AssignedEmployee")]
    protected NamedObjectRef _AssignedEmployee;
    [DataMember(EmitDefaultValue = false, Name = "DelegateTaskInquiry_InstanceName")]
    protected Primitive<string> _InstanceName;

    public override bool Equals(object obj)
    {
      return obj is DelegateTaskInquiry && object.Equals((object) this._DelegationTaskType, (object) ((DelegateTaskInquiry) obj)._DelegationTaskType) && (object.Equals((object) this._ApplicationType, (object) ((DelegateTaskInquiry) obj)._ApplicationType) && object.Equals((object) this._DelegationTarget, (object) ((DelegateTaskInquiry) obj)._DelegationTarget)) && (object.Equals((object) this._DueDateEnd, (object) ((DelegateTaskInquiry) obj)._DueDateEnd) && object.Equals((object) this._TaskIsDue, (object) ((DelegateTaskInquiry) obj)._TaskIsDue) && (object.Equals((object) this._DueDateBegin, (object) ((DelegateTaskInquiry) obj)._DueDateBegin) && object.Equals((object) this._AssignedEmployee, (object) ((DelegateTaskInquiry) obj)._AssignedEmployee))) && object.Equals((object) this._InstanceName, (object) ((DelegateTaskInquiry) obj)._InstanceName) && base.Equals(obj);
    }

    public Enumeration<DelegationTaskTypeEnum, int> DelegationTaskType
    {
      [param: In] set
      {
        this.PropertySet(nameof (DelegationTaskType), (object) value);
      }
      get
      {
        return (Enumeration<DelegationTaskTypeEnum, int>) this.PropertyGet(nameof (DelegationTaskType));
      }
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

    public BaseObjectRef DelegationTarget
    {
      [param: In] set
      {
        this.PropertySet(nameof (DelegationTarget), (object) value);
      }
      get
      {
        return (BaseObjectRef) this.PropertyGet(nameof (DelegationTarget));
      }
    }

    public Primitive<DateTime> DueDateEnd
    {
      [param: In] set
      {
        this.PropertySet(nameof (DueDateEnd), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (DueDateEnd));
      }
    }

    public Primitive<bool> TaskIsDue
    {
      [param: In] set
      {
        this.PropertySet(nameof (TaskIsDue), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (TaskIsDue));
      }
    }

    public Primitive<DateTime> DueDateBegin
    {
      [param: In] set
      {
        this.PropertySet(nameof (DueDateBegin), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (DueDateBegin));
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

    public Primitive<string> InstanceName
    {
      [param: In] set
      {
        this.PropertySet(nameof (InstanceName), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (InstanceName));
      }
    }
  }
}
