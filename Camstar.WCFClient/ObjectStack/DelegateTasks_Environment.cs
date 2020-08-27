// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.DelegateTasks_Environment
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
  public class DelegateTasks_Environment : GenericTxns_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "DelegateTasks_Environment_DelegationReasonCode")]
    [Metadata("Various reasons for creating a delegation reassignment.", "DelegationReasonCode", false, true, false, "NamedObjectRef", 16778612, false, false, true, null)]
    protected Environment _DelegationReasonCode;
    [Metadata("Delegate Task", "DelegateTask", false, false, false, "DelegateTask", 1052702, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "DelegateTasks_Environment_Services")]
    protected DelegateTask_Environment _Services;
    [Metadata("An Employee is a person that can login to InSite, perform transactions, and/or be credited with work.  The Employees must have a Windows NT account. Once defined, the user will then appear in the user list within the Modeler Security window. In this way the Employee definition feeds directly into the Modeler Security.\r\n\r\nThe Employee definitions also allow for other options for each user such as the factory associate with the user and the language that will be used.  Persons that will get credited with work by being entered in the employee field on a transaction, must exist as InSite employees, but are not required to exist as Windows user accounts.", "Employee", false, true, false, "NamedObjectRef", 16778654, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "DelegateTasks_Environment_TargetEmployee")]
    protected Environment _TargetEmployee;

    public Environment DelegationReasonCode
    {
      [param: In] set
      {
        this.PropertySet(nameof (DelegationReasonCode), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (DelegationReasonCode));
      }
    }

    public DelegateTask_Environment Services
    {
      [param: In] set
      {
        this.PropertySet(nameof (Services), (object) value);
      }
      get
      {
        return (DelegateTask_Environment) this.PropertyGet(nameof (Services));
      }
    }

    public Environment TargetEmployee
    {
      [param: In] set
      {
        this.PropertySet(nameof (TargetEmployee), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (TargetEmployee));
      }
    }
  }
}
