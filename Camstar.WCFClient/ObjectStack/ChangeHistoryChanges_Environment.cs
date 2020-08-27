// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ChangeHistoryChanges_Environment
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
  public class ChangeHistoryChanges_Environment : SubentityChanges_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "ChangeHistoryChanges_Environment_ListItemToChange")]
    [Metadata("Changes CDO for ChangeHistory.", "ChangeHistoryChanges", false, false, false, "SubentityRef", 1049321, false, false, false, null)]
    protected new Environment _ListItemToChange;
    [DataMember(EmitDefaultValue = false, Name = "ChangeHistoryChanges_Environment_LastChangeDateGMT")]
    [Metadata("Generic TimeStamp", "", false, false, true, "TimeStamp", 1048883, false, false, false, null)]
    protected Environment _LastChangeDateGMT;
    [Metadata("Generic TimeStamp", "", false, false, true, "TimeStamp", 1048763, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ChangeHistoryChanges_Environment_LastChangeDate")]
    protected Environment _LastChangeDate;
    [DataMember(EmitDefaultValue = false, Name = "ChangeHistoryChanges_Environment_CurrentStatus")]
    [Metadata("Current status for maintenance of the associated modeling entity.\r\n\r\n0 = Nothing in progress (\"Checked-in\")\r\n1 = Maintenance active (\"Checked-out\")", "", false, false, false, "Integer", 1048786, false, false, false, null)]
    protected Environment _CurrentStatus;
    [Metadata("Determines if changes are allowed to this instance (or any of its revisions)", "", false, false, false, "Boolean", 1048680, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "ChangeHistoryChanges_Environment_IsFrozen")]
    protected Environment _IsFrozen;
    [Metadata("Every modeling entity includes a Change Status. It is used to record the current Change (Maintenance) Status (i.e., maintenance is currently in progress for a specific Product Definition) and to track who made the last change and when. This should be extendible to a complete history over time.", "ChangeHistory", false, false, false, "SubentityRef", 1048682, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ChangeHistoryChanges_Environment_ObjectToChange")]
    protected new Environment _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "ChangeHistoryChanges_Environment_User")]
    [Metadata("An Employee is a person that can login to InSite, perform transactions, and/or be credited with work.  The Employees must have a Windows NT account. Once defined, the user will then appear in the user list within the Modeler Security window. In this way the Employee definition feeds directly into the Modeler Security.\r\n\r\nThe Employee definitions also allow for other options for each user such as the factory associate with the user and the language that will be used.  Persons that will get credited with work by being entered in the employee field on a transaction, must exist as InSite employees, but are not required to exist as Windows user accounts.", "Employee", false, false, true, "NamedObjectRef", 1048864, false, false, true, null)]
    protected Environment _User;
    [DataMember(EmitDefaultValue = false, Name = "ChangeHistoryChanges_Environment_Control")]
    [Metadata("Counter, incremented each time a change is completed", "", false, false, false, "Integer", 1048882, false, false, false, null)]
    protected Environment _Control;
    [Metadata("Notes/Comments", "", false, false, false, "String", 1048624, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ChangeHistoryChanges_Environment_Notes")]
    protected Environment _Notes;

    public new Environment ListItemToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ListItemToChange), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ListItemToChange));
      }
    }

    public Environment LastChangeDateGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (LastChangeDateGMT), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (LastChangeDateGMT));
      }
    }

    public Environment LastChangeDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (LastChangeDate), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (LastChangeDate));
      }
    }

    public Environment CurrentStatus
    {
      [param: In] set
      {
        this.PropertySet(nameof (CurrentStatus), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (CurrentStatus));
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

    public new Environment ObjectToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectToChange), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ObjectToChange));
      }
    }

    public Environment User
    {
      [param: In] set
      {
        this.PropertySet(nameof (User), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (User));
      }
    }

    public Environment Control
    {
      [param: In] set
      {
        this.PropertySet(nameof (Control), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Control));
      }
    }

    public Environment Notes
    {
      [param: In] set
      {
        this.PropertySet(nameof (Notes), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Notes));
      }
    }
  }
}
