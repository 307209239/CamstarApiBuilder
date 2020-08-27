// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.EmployeeLoginInfoChanges_Environment
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
  public class EmployeeLoginInfoChanges_Environment : SubentityChanges_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "EmployeeLoginInfoChanges_Environment_ChangeHistory")]
    [Metadata("Changes CDO for ChangeHistory.", "ChangeHistoryChanges", false, false, false, "ChangeHistoryChanges", 1048765, false, false, false, null)]
    protected ChangeHistoryChanges_Environment _ChangeHistory;
    [DataMember(EmitDefaultValue = false, Name = "EmployeeLoginInfoChanges_Environment_ObjectToChange")]
    [Metadata("Contains details about the employee's log in", "EmployeeLoginInfo", false, false, false, "SubentityRef", 1048682, false, false, false, null)]
    protected new Environment _ObjectToChange;
    [Metadata("Login information for an employee", "EmployeeLoginInfoChanges", false, false, false, "SubentityRef", 1049321, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "EmployeeLoginInfoChanges_Environment_ListItemToChange")]
    protected new Environment _ListItemToChange;
    [DataMember(EmitDefaultValue = false, Name = "EmployeeLoginInfoChanges_Environment_LastLoginDateGMT")]
    [Metadata("Generic TimeStamp", "", false, false, false, "TimeStamp", 16779419, false, false, false, null)]
    protected Environment _LastLoginDateGMT;
    [DataMember(EmitDefaultValue = false, Name = "EmployeeLoginInfoChanges_Environment_IsFrozen")]
    [Metadata("Determines if changes are allowed to this instance (or any of its revisions)", "", false, false, false, "Boolean", 1048680, false, false, false, "0")]
    protected Environment _IsFrozen;

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

    public Environment LastLoginDateGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (LastLoginDateGMT), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (LastLoginDateGMT));
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
