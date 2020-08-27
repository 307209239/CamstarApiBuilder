// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.DelegationTaskChanges_Environment
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
  public class DelegationTaskChanges_Environment : SubentityChanges_Environment
  {
    [Metadata("Comments", "", false, false, false, "String", 1048866, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "DelegationTaskChanges_Environment_Comments")]
    protected Environment _Comments;
    [Metadata("Changes CDO for ChangeHistory.", "ChangeHistoryChanges", false, false, false, "ChangeHistoryChanges", 1048765, true, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "DelegationTaskChanges_Environment_ChangeHistory")]
    protected ChangeHistoryChanges_Environment _ChangeHistory;
    [DataMember(EmitDefaultValue = false, Name = "DelegationTaskChanges_Environment_ApplicationType")]
    [Metadata("Enumeration for Application Type", "ApplicationTypeEnum", false, true, false, "Integer", 1048875, false, false, true, null)]
    protected Environment _ApplicationType;
    [Metadata("Various reasons for creating a delegation reassignment.", "DelegationReasonCode", false, true, false, "NamedObjectRef", 16778612, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "DelegationTaskChanges_Environment_DelegationReason")]
    protected Environment _DelegationReason;
    [Metadata("Generic TimeStamp", "", false, true, false, "TimeStamp", 1049310, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "DelegationTaskChanges_Environment_EndDateGMT")]
    protected Environment _EndDateGMT;
    [Metadata("Generic TimeStamp", "", false, true, false, "TimeStamp", 1049313, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "DelegationTaskChanges_Environment_StartDateGMT")]
    protected Environment _StartDateGMT;
    [DataMember(EmitDefaultValue = false, Name = "DelegationTaskChanges_Environment_DelegationForwarding")]
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 16778755, false, false, false, "0")]
    protected Environment _DelegationForwarding;
    [DataMember(EmitDefaultValue = false, Name = "DelegationTaskChanges_Environment_AssignedEmployee")]
    [Metadata("An Employee is a person that can login to InSite, perform transactions, and/or be credited with work.  The Employees must have a Windows NT account. Once defined, the user will then appear in the user list within the Modeler Security window. In this way the Employee definition feeds directly into the Modeler Security.\r\n\r\nThe Employee definitions also allow for other options for each user such as the factory associate with the user and the language that will be used.  Persons that will get credited with work by being entered in the employee field on a transaction, must exist as InSite employees, but are not required to exist as Windows user accounts.", "Employee", false, true, false, "NamedObjectRef", 16778646, false, false, true, null)]
    protected Environment _AssignedEmployee;
    [DataMember(EmitDefaultValue = false, Name = "DelegationTaskChanges_Environment_DelegatedBy")]
    [Metadata("An Employee is a person that can login to InSite, perform transactions, and/or be credited with work.  The Employees must have a Windows NT account. Once defined, the user will then appear in the user list within the Modeler Security window. In this way the Employee definition feeds directly into the Modeler Security.\r\n\r\nThe Employee definitions also allow for other options for each user such as the factory associate with the user and the language that will be used.  Persons that will get credited with work by being entered in the employee field on a transaction, must exist as InSite employees, but are not required to exist as Windows user accounts.", "Employee", false, false, true, "NamedObjectRef", 16778754, false, false, true, null)]
    protected Environment _DelegatedBy;
    [Metadata("An Employee is a person that can login to InSite, perform transactions, and/or be credited with work.  The Employees must have a Windows NT account. Once defined, the user will then appear in the user list within the Modeler Security window. In this way the Employee definition feeds directly into the Modeler Security.\r\n\r\nThe Employee definitions also allow for other options for each user such as the factory associate with the user and the language that will be used.  Persons that will get credited with work by being entered in the employee field on a transaction, must exist as InSite employees, but are not required to exist as Windows user accounts.", "Employee", false, true, false, "NamedObjectRef", 16778654, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "DelegationTaskChanges_Environment_TargetEmployee")]
    protected Environment _TargetEmployee;
    [DataMember(EmitDefaultValue = false, Name = "DelegationTaskChanges_Environment_IsFrozen")]
    [Metadata("Determines if changes are allowed to this instance (or any of its revisions)", "", false, false, false, "Boolean", 1048680, false, false, false, "0")]
    protected Environment _IsFrozen;

    public Environment Comments
    {
      [param: In] set
      {
        this.PropertySet(nameof (Comments), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Comments));
      }
    }

    public ChangeHistoryChanges_Environment ChangeHistory
    {
      [param: In] set
      {
        this.PropertySet(nameof (ChangeHistory), (object) value);
      }
      get
      {
        return (ChangeHistoryChanges_Environment) this.PropertyGet(nameof (ChangeHistory));
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

    public Environment DelegationReason
    {
      [param: In] set
      {
        this.PropertySet(nameof (DelegationReason), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (DelegationReason));
      }
    }

    public Environment EndDateGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (EndDateGMT), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (EndDateGMT));
      }
    }

    public Environment StartDateGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (StartDateGMT), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (StartDateGMT));
      }
    }

    public Environment DelegationForwarding
    {
      [param: In] set
      {
        this.PropertySet(nameof (DelegationForwarding), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (DelegationForwarding));
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

    public Environment DelegatedBy
    {
      [param: In] set
      {
        this.PropertySet(nameof (DelegatedBy), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (DelegatedBy));
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

    public Environment IsFrozen
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsFrozen), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (IsFrozen));
      }
    }
  }
}
