// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.DelegateTask_Environment
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
  public class DelegateTask_Environment : GenericTxn_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "DelegateTask_Environment_ChangePackage")]
    [Metadata("A change package is used to manage what is delivered to a target system for consumption.", "ChangePackage", false, false, false, "NamedObjectRef", 1053240, false, false, false, null)]
    protected Environment _ChangePackage;
    [Metadata("Various reasons for creating a delegation reassignment.", "DelegationReasonCode", false, true, false, "NamedObjectRef", 16778655, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "DelegateTask_Environment_DelegationReasonCode")]
    protected Environment _DelegationReasonCode;
    [DataMember(EmitDefaultValue = false, Name = "DelegateTask_Environment_DelegationTarget")]
    [Metadata("BaseObject", "BaseObject", false, false, false, "BaseObjectRef", 16778652, false, false, false, null)]
    protected Environment _DelegationTarget;
    [Metadata("BaseObject", "BaseObject", false, true, false, "BaseObjectRef", 1051446, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "DelegateTask_Environment_TrackableObject")]
    protected new Environment _TrackableObject;
    [DataMember(EmitDefaultValue = false, Name = "DelegateTask_Environment_SourceEmployee")]
    [Metadata("An Employee is a person that can login to InSite, perform transactions, and/or be credited with work.  The Employees must have a Windows NT account. Once defined, the user will then appear in the user list within the Modeler Security window. In this way the Employee definition feeds directly into the Modeler Security.\r\n\r\nThe Employee definitions also allow for other options for each user such as the factory associate with the user and the language that will be used.  Persons that will get credited with work by being entered in the employee field on a transaction, must exist as InSite employees, but are not required to exist as Windows user accounts.", "Employee", false, false, false, "NamedObjectRef", 16778732, false, false, true, null)]
    protected Environment _SourceEmployee;
    [DataMember(EmitDefaultValue = false, Name = "DelegateTask_Environment_TargetEmployee")]
    [Metadata("An Employee is a person that can login to InSite, perform transactions, and/or be credited with work.  The Employees must have a Windows NT account. Once defined, the user will then appear in the user list within the Modeler Security window. In this way the Employee definition feeds directly into the Modeler Security.\r\n\r\nThe Employee definitions also allow for other options for each user such as the factory associate with the user and the language that will be used.  Persons that will get credited with work by being entered in the employee field on a transaction, must exist as InSite employees, but are not required to exist as Windows user accounts.", "Employee", false, true, false, "NamedObjectRef", 16778654, false, false, true, null)]
    protected Environment _TargetEmployee;

    public Environment ChangePackage
    {
      [param: In] set
      {
        this.PropertySet(nameof (ChangePackage), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ChangePackage));
      }
    }

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

    public new Environment TrackableObject
    {
      [param: In] set
      {
        this.PropertySet(nameof (TrackableObject), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (TrackableObject));
      }
    }

    public Environment SourceEmployee
    {
      [param: In] set
      {
        this.PropertySet(nameof (SourceEmployee), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (SourceEmployee));
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
