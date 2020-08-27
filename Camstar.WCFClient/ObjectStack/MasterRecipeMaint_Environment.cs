// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.MasterRecipeMaint_Environment
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
  public class MasterRecipeMaint_Environment : ProductionProcessMaint_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "MasterRecipeMaint_Environment_ObjectToChange")]
    [Metadata("Provides the framework for executing a series of Instructions part of a Recipe. Defines a set of instructions (a checklist for performing a set of Recipe Items), and is compose of one ore more Recipe Lists.", "MasterRecipe", false, false, false, "RevisionedObjectRef", 1048682, false, false, true, null)]
    protected new Environment _ObjectToChange;
    [Metadata("Master Recipe", "MasterRecipeBase", false, false, false, "RevisionedObjectRef", 1049292, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "MasterRecipeMaint_Environment_BaseToChange")]
    protected new Environment _BaseToChange;
    [DataMember(EmitDefaultValue = false, Name = "MasterRecipeMaint_Environment_ObjectChanges")]
    [Metadata("Master Recipe", "MasterRecipeChanges", false, false, false, "MasterRecipeChanges", 1048873, true, false, false, null)]
    protected MasterRecipeChanges_Environment _ObjectChanges;
    [Metadata("Master Recipe", "MasterRecipeBase", false, false, true, "RevisionedObjectRef", 1048874, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "MasterRecipeMaint_Environment_ObjectListInquiry")]
    protected new Environment _ObjectListInquiry;

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

    public new Environment BaseToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (BaseToChange), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (BaseToChange));
      }
    }

    public MasterRecipeChanges_Environment ObjectChanges
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectChanges), (object) value);
      }
      get
      {
        return (MasterRecipeChanges_Environment) this.PropertyGet(nameof (ObjectChanges));
      }
    }

    public new Environment ObjectListInquiry
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectListInquiry), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ObjectListInquiry));
      }
    }
  }
}
