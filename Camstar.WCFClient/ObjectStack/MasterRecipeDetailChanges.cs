// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.MasterRecipeDetailChanges
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
  public class MasterRecipeDetailChanges : ProductionProcessDetailChanges
  {
    [DataMember(EmitDefaultValue = false, Name = "MasterRecipeDetailChanges_SubSequence")]
    protected Primitive<int> _SubSequence;
    [DataMember(EmitDefaultValue = false, Name = "MasterRecipeDetailChanges_Spec")]
    protected RevisionedObjectRef _Spec;
    [DataMember(EmitDefaultValue = false, Name = "MasterRecipeDetailChanges_TaskList")]
    protected new RevisionedObjectRef _TaskList;
    [DataMember(EmitDefaultValue = false, Name = "MasterRecipeDetailChanges_ListItemToChange")]
    protected new SubentityRef _ListItemToChange;
    [DataMember(EmitDefaultValue = false, Name = "MasterRecipeDetailChanges_ObjectToChange")]
    protected new SubentityRef _ObjectToChange;

    public override bool Equals(object obj)
    {
      return obj is MasterRecipeDetailChanges && object.Equals((object) this._SubSequence, (object) ((MasterRecipeDetailChanges) obj)._SubSequence) && (object.Equals((object) this._Spec, (object) ((MasterRecipeDetailChanges) obj)._Spec) && object.Equals((object) this._TaskList, (object) ((MasterRecipeDetailChanges) obj)._TaskList)) && (object.Equals((object) this._ListItemToChange, (object) ((MasterRecipeDetailChanges) obj)._ListItemToChange) && object.Equals((object) this._ObjectToChange, (object) ((MasterRecipeDetailChanges) obj)._ObjectToChange)) && base.Equals(obj);
    }

    public Primitive<int> SubSequence
    {
      [param: In] set
      {
        this.PropertySet(nameof (SubSequence), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (SubSequence));
      }
    }

    public RevisionedObjectRef Spec
    {
      [param: In] set
      {
        this.PropertySet(nameof (Spec), (object) value);
      }
      get
      {
        return (RevisionedObjectRef) this.PropertyGet(nameof (Spec));
      }
    }

    public new RevisionedObjectRef TaskList
    {
      [param: In] set
      {
        this.PropertySet(nameof (TaskList), (object) value);
      }
      get
      {
        return (RevisionedObjectRef) this.PropertyGet(nameof (TaskList));
      }
    }

    public new SubentityRef ListItemToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ListItemToChange), (object) value);
      }
      get
      {
        return (SubentityRef) this.PropertyGet(nameof (ListItemToChange));
      }
    }

    public new SubentityRef ObjectToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectToChange), (object) value);
      }
      get
      {
        return (SubentityRef) this.PropertyGet(nameof (ObjectToChange));
      }
    }
  }
}
