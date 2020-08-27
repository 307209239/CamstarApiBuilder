// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.DelegateTaskInquiry_Environment
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
  public class DelegateTaskInquiry_Environment : Inquiry_Environment
  {
    [Metadata("Enumeration for Delegation Task Type", "DelegationTaskTypeEnum", false, false, false, "Integer", 1050503, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "DelegateTaskInquiry_Environment_DelegationTaskType")]
    protected Environment _DelegationTaskType;
    [DataMember(EmitDefaultValue = false, Name = "DelegateTaskInquiry_Environment_ApplicationType")]
    [Metadata("Enumeration for Application Type", "ApplicationTypeEnum", false, false, false, "Integer", 1048875, false, false, true, null)]
    protected Environment _ApplicationType;
    [Metadata("BaseObject", "BaseObject", false, false, false, "BaseObjectRef", 16778652, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "DelegateTaskInquiry_Environment_DelegationTarget")]
    protected Environment _DelegationTarget;
    [Metadata("Generic TimeStamp", "", false, false, false, "TimeStamp", 16778651, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "DelegateTaskInquiry_Environment_DueDateEnd")]
    protected Environment _DueDateEnd;
    [DataMember(EmitDefaultValue = false, Name = "DelegateTaskInquiry_Environment_TaskIsDue")]
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 16778647, false, false, false, "0")]
    protected Environment _TaskIsDue;
    [DataMember(EmitDefaultValue = false, Name = "DelegateTaskInquiry_Environment_DueDateBegin")]
    [Metadata("Generic TimeStamp", "", false, false, false, "TimeStamp", 16778650, false, false, false, null)]
    protected Environment _DueDateBegin;
    [DataMember(EmitDefaultValue = false, Name = "DelegateTaskInquiry_Environment_AssignedEmployee")]
    [Metadata("An Employee is a person that can login to InSite, perform transactions, and/or be credited with work.  The Employees must have a Windows NT account. Once defined, the user will then appear in the user list within the Modeler Security window. In this way the Employee definition feeds directly into the Modeler Security.\r\n\r\nThe Employee definitions also allow for other options for each user such as the factory associate with the user and the language that will be used.  Persons that will get credited with work by being entered in the employee field on a transaction, must exist as InSite employees, but are not required to exist as Windows user accounts.", "Employee", false, false, false, "NamedObjectRef", 16778646, false, false, true, null)]
    protected Environment _AssignedEmployee;
    [DataMember(EmitDefaultValue = false, Name = "DelegateTaskInquiry_Environment_InstanceName")]
    [Metadata("Unique name for this instance", "", false, false, false, "String", 1053067, false, false, false, null)]
    protected Environment _InstanceName;

    public Environment DelegationTaskType
    {
      [param: In] set
      {
        this.PropertySet(nameof (DelegationTaskType), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (DelegationTaskType));
      }
    }

    public Environment ApplicationType
    {
      [param: In] set
      {
        this.PropertySet(nameof (ApplicationType), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ApplicationType));
      }
    }

    public Environment DelegationTarget
    {
      [param: In] set
      {
        this.PropertySet(nameof (DelegationTarget), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (DelegationTarget));
      }
    }

    public Environment DueDateEnd
    {
      [param: In] set
      {
        this.PropertySet(nameof (DueDateEnd), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (DueDateEnd));
      }
    }

    public Environment TaskIsDue
    {
      [param: In] set
      {
        this.PropertySet(nameof (TaskIsDue), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (TaskIsDue));
      }
    }

    public Environment DueDateBegin
    {
      [param: In] set
      {
        this.PropertySet(nameof (DueDateBegin), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (DueDateBegin));
      }
    }

    public Environment AssignedEmployee
    {
      [param: In] set
      {
        this.PropertySet(nameof (AssignedEmployee), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (AssignedEmployee));
      }
    }

    public Environment InstanceName
    {
      [param: In] set
      {
        this.PropertySet(nameof (InstanceName), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (InstanceName));
      }
    }
  }
}
