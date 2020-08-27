// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ChangeHistory_Environment
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
  public class ChangeHistory_Environment : Subentity_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "ChangeHistory_Environment_ExportImportKey")]
    [Metadata("Hexadecimal representation of GUID ( e.g. BDE4B634-153E-4A31-A453-EEA85FE80532)", "", false, false, true, "String", 0, false, false, false, null)]
    protected new Environment _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "ChangeHistory_Environment_LastChangeDate")]
    [Metadata("Generic TimeStamp", "", false, false, true, "TimeStamp", 1048763, false, false, false, null)]
    protected Environment _LastChangeDate;
    [DataMember(EmitDefaultValue = false, Name = "ChangeHistory_Environment_LastChangeDateGMT")]
    [Metadata("Generic TimeStamp", "", false, false, true, "TimeStamp", 1048883, false, false, false, null)]
    protected Environment _LastChangeDateGMT;
    [DataMember(EmitDefaultValue = false, Name = "ChangeHistory_Environment_User")]
    [Metadata("An Employee is a person that can login to InSite, perform transactions, and/or be credited with work.  The Employees must have a Windows NT account. Once defined, the user will then appear in the user list within the Modeler Security window. In this way the Employee definition feeds directly into the Modeler Security.\r\n\r\nThe Employee definitions also allow for other options for each user such as the factory associate with the user and the language that will be used.  Persons that will get credited with work by being entered in the employee field on a transaction, must exist as InSite employees, but are not required to exist as Windows user accounts.", "Employee", false, false, true, "NamedObjectRef", 1048864, false, false, false, null)]
    protected Environment _User;
    [DataMember(EmitDefaultValue = false, Name = "ChangeHistory_Environment_Notes")]
    [Metadata("Notes/Comments", "", false, false, true, "String", 1048624, false, false, false, null)]
    protected Environment _Notes;
    [Metadata("Counter, incremented each time a change is completed", "", false, false, true, "Integer", 1048882, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ChangeHistory_Environment_Control")]
    protected Environment _Control;
    [DataMember(EmitDefaultValue = false, Name = "ChangeHistory_Environment_IsFrozen")]
    [Metadata("Determines if changes are allowed to this instance (or any of its revisions)", "", false, false, true, "Boolean", 1048680, false, false, false, "0")]
    protected Environment _IsFrozen;
    [Metadata("Current status for maintenance of the associated modeling entity.\r\n\r\n0 = Nothing in progress (\"Checked-in\")\r\n1 = Maintenance active (\"Checked-out\")", "", false, false, true, "Integer", 1048786, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ChangeHistory_Environment_CurrentStatus")]
    protected Environment _CurrentStatus;

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
  }
}
