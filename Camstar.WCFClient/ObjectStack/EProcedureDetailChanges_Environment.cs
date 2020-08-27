// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.EProcedureDetailChanges_Environment
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
  public class EProcedureDetailChanges_Environment : ProductionProcessDetailChanges_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "EProcedureDetailChanges_Environment_ObjectToChange")]
    [Metadata("Allows a TaskList to be assigned to an ElectronicProcedure in a particular sequence.", "EProcedureDetail", false, false, false, "SubentityRef", 1048682, false, false, false, null)]
    protected new Environment _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "EProcedureDetailChanges_Environment_Sequence")]
    [Metadata("Relative sequence number", "", false, true, false, "Integer", 1048917, false, false, false, null)]
    protected new Environment _Sequence;
    [Metadata("Allows a TaskList to be assigned to an ElectronicProcedure in a particular sequence.", "EProcedureDetailChanges", false, false, false, "SubentityRef", 1049321, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "EProcedureDetailChanges_Environment_ListItemToChange")]
    protected new Environment _ListItemToChange;
    [DataMember(EmitDefaultValue = false, Name = "EProcedureDetailChanges_Environment_TaskList")]
    [Metadata("Identifies a group of Tasks to be executed for an ElectronicProcedure.", "TaskList", false, true, false, "RevisionedObjectRef", 1050520, false, false, true, null)]
    protected new Environment _TaskList;
    [Metadata("Determines if changes are allowed to this instance (or any of its revisions)", "", false, false, true, "Boolean", 1048680, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "EProcedureDetailChanges_Environment_IsFrozen")]
    protected new Environment _IsFrozen;

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

    public new Environment Sequence
    {
      [param: In] set
      {
        this.PropertySet(nameof (Sequence), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Sequence));
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

    public new Environment TaskList
    {
      [param: In] set
      {
        this.PropertySet(nameof (TaskList), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (TaskList));
      }
    }

    public new Environment IsFrozen
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
