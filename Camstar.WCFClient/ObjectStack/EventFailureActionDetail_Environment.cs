// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.EventFailureActionDetail_Environment
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
  public class EventFailureActionDetail_Environment : ServiceDetails_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "EventFailureActionDetail_Environment_ActionRole")]
    [Metadata("A role is a definition of a job function, for example the role of Regulatory Affairs Manager.\r\nA role that must be assigned to an Employee using an ESig role group in order to sign off for an Electronic Signature requirement.", "Role", false, false, false, "NamedObjectRef", 1053014, false, false, true, null)]
    protected Environment _ActionRole;
    [Metadata("Comments", "", false, false, false, "String", 1052948, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "EventFailureActionDetail_Environment_Comments")]
    protected Environment _Comments;
    [Metadata("Identifies a failure action for an Event or Cause.", "EventFailureAction", false, false, false, "SubentityRef", 1052957, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "EventFailureActionDetail_Environment_EventFailureAction")]
    protected Environment _EventFailureAction;
    [DataMember(EmitDefaultValue = false, Name = "EventFailureActionDetail_Environment_ActionTypeGroup")]
    [Metadata("Grouping mechanism for the FailureActionTypes.  Identifies the possible FailureActionTypes that can be assigned to an Event or Cause.", "FailureActionTypeGroup", false, false, false, "NamedObjectRef", 1052946, false, false, true, null)]
    protected Environment _ActionTypeGroup;
    [Metadata("Identifies a Action Type for an Event or Cause.", "FailureActionType", false, false, false, "NamedObjectRef", 1052690, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "EventFailureActionDetail_Environment_ActionType")]
    protected Environment _ActionType;
    [Metadata("Generic TimeStamp", "", false, false, false, "TimeStamp", 1051796, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "EventFailureActionDetail_Environment_CompletionDate")]
    protected Environment _CompletionDate;
    [DataMember(EmitDefaultValue = false, Name = "EventFailureActionDetail_Environment_ActionOwner")]
    [Metadata("An Employee is a person that can login to InSite, perform transactions, and/or be credited with work.  The Employees must have a Windows NT account. Once defined, the user will then appear in the user list within the Modeler Security window. In this way the Employee definition feeds directly into the Modeler Security.\r\n\r\nThe Employee definitions also allow for other options for each user such as the factory associate with the user and the language that will be used.  Persons that will get credited with work by being entered in the employee field on a transaction, must exist as InSite employees, but are not required to exist as Windows user accounts.", "Employee", false, false, false, "NamedObjectRef", 1052947, false, false, true, null)]
    protected Environment _ActionOwner;

    public Environment ActionRole
    {
      [param: In] set
      {
        this.PropertySet(nameof (ActionRole), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ActionRole));
      }
    }

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

    public Environment EventFailureAction
    {
      [param: In] set
      {
        this.PropertySet(nameof (EventFailureAction), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (EventFailureAction));
      }
    }

    public Environment ActionTypeGroup
    {
      [param: In] set
      {
        this.PropertySet(nameof (ActionTypeGroup), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ActionTypeGroup));
      }
    }

    public Environment ActionType
    {
      [param: In] set
      {
        this.PropertySet(nameof (ActionType), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ActionType));
      }
    }

    public Environment CompletionDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (CompletionDate), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (CompletionDate));
      }
    }

    public Environment ActionOwner
    {
      [param: In] set
      {
        this.PropertySet(nameof (ActionOwner), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ActionOwner));
      }
    }
  }
}
