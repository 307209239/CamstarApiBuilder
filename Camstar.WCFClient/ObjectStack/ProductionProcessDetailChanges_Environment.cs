// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ProductionProcessDetailChanges_Environment
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [KnownType(typeof (MasterRecipeDetailChanges_Environment))]
  [KnownType(typeof (EProcedureDetailChanges_Environment))]
  [Serializable]
  public class ProductionProcessDetailChanges_Environment : SubentityChanges_Environment
  {
    [Metadata("Relative sequence number", "", false, true, false, "Integer", 1048917, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ProductionProcessDetailChanges_Environment_Sequence")]
    protected Environment _Sequence;
    [Metadata("Identifies a group of Tasks to be executed for ProductionProcess.", "ProcessList", false, true, false, "RevisionedObjectRef", 1050520, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "ProductionProcessDetailChanges_Environment_TaskList")]
    protected Environment _TaskList;
    [DataMember(EmitDefaultValue = false, Name = "ProductionProcessDetailChanges_Environment_ListItemToChange")]
    [Metadata("Encapsulates various types of TaskList that are to be assigned to a ProductionProcess in a particular sequence.", "ProductionProcessDetailChanges", false, false, false, "SubentityRef", 1049321, false, false, false, null)]
    protected new Environment _ListItemToChange;
    [Metadata("Encapsulates various types of TaskList that are to be assigned to a ProductionProcess in a particular sequence.", "ProductionProcessDetail", false, false, false, "SubentityRef", 1048682, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ProductionProcessDetailChanges_Environment_ObjectToChange")]
    protected new Environment _ObjectToChange;
    [Metadata("Determines if changes are allowed to this instance (or any of its revisions)", "", false, false, true, "Boolean", 1048680, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "ProductionProcessDetailChanges_Environment_IsFrozen")]
    protected Environment _IsFrozen;

    public Environment Sequence
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

    public Environment TaskList
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
