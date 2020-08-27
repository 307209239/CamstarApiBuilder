// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.EventFailureAction_Environment
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
  public class EventFailureAction_Environment : Subentity_Environment
  {
    [Metadata("Hexadecimal representation of GUID ( e.g. BDE4B634-153E-4A31-A453-EEA85FE80532)", "", false, false, true, "String", 0, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "EventFailureAction_Environment_ExportImportKey")]
    protected new Environment _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "EventFailureAction_Environment_Comments")]
    [Metadata("Comments", "", false, false, true, "String", 1052948, false, false, false, null)]
    protected Environment _Comments;
    [Metadata("Identifies a Action Type for an Event or Cause.", "FailureActionType", false, false, true, "NamedObjectRef", 1052690, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "EventFailureAction_Environment_ActionType")]
    protected Environment _ActionType;
    [Metadata("Generic TimeStamp", "", false, false, true, "TimeStamp", 1051796, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "EventFailureAction_Environment_CompletionDate")]
    protected Environment _CompletionDate;
    [DataMember(EmitDefaultValue = false, Name = "EventFailureAction_Environment_ActionOwner")]
    [Metadata("An Employee is a person that can login to InSite, perform transactions, and/or be credited with work.  The Employees must have a Windows NT account. Once defined, the user will then appear in the user list within the Modeler Security window. In this way the Employee definition feeds directly into the Modeler Security.\r\n\r\nThe Employee definitions also allow for other options for each user such as the factory associate with the user and the language that will be used.  Persons that will get credited with work by being entered in the employee field on a transaction, must exist as InSite employees, but are not required to exist as Windows user accounts.", "Employee", false, false, true, "NamedObjectRef", 1052947, false, false, false, null)]
    protected Environment _ActionOwner;

    public new Environment ExportImportKey
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExportImportKey), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ExportImportKey));
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
