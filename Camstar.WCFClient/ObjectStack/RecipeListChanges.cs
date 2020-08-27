// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.RecipeListChanges
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
  public class RecipeListChanges : ProcessListChanges
  {
    [DataMember(EmitDefaultValue = false, Name = "RecipeListChanges_TargetContainerUOM")]
    protected NamedObjectRef _TargetContainerUOM;
    [DataMember(EmitDefaultValue = false, Name = "RecipeListChanges_TargetContainerPlannedQty")]
    protected Primitive<string> _TargetContainerPlannedQty;
    [DataMember(EmitDefaultValue = false, Name = "RecipeListChanges_Carriers")]
    protected NamedObjectRef _Carriers;
    [DataMember(EmitDefaultValue = false, Name = "RecipeListChanges_PrerequisiteTaskList")]
    protected new RevisionedObjectRef _PrerequisiteTaskList;
    [DataMember(EmitDefaultValue = false, Name = "RecipeListChanges_ObjectToChange")]
    protected new RevisionedObjectRef _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "RecipeListChanges_Scales")]
    protected NamedObjectRef _Scales;
    [DataMember(EmitDefaultValue = false, Name = "RecipeListChanges_Base")]
    protected new RevisionedObjectRef _Base;
    [DataMember(EmitDefaultValue = false, Name = "RecipeListChanges_Tasks")]
    protected new ProcessItemChanges[] _Tasks;
    [DataMember(EmitDefaultValue = false, Name = "RecipeListChanges_LabelTxnMap")]
    protected RecipeLabelMapChanges[] _LabelTxnMap;
    [DataMember(EmitDefaultValue = false, Name = "RecipeListChanges_TargetContainerProduct")]
    protected RevisionedObjectRef _TargetContainerProduct;
    [DataMember(EmitDefaultValue = false, Name = "RecipeListChanges_Name")]
    protected new Primitive<string> _Name;
    [DataMember(EmitDefaultValue = false, Name = "RecipeListChanges_TargetContainerLevel")]
    protected NamedObjectRef _TargetContainerLevel;

    public override bool Equals(object obj)
    {
      return obj is RecipeListChanges && object.Equals((object) this._TargetContainerUOM, (object) ((RecipeListChanges) obj)._TargetContainerUOM) && (object.Equals((object) this._TargetContainerPlannedQty, (object) ((RecipeListChanges) obj)._TargetContainerPlannedQty) && object.Equals((object) this._Carriers, (object) ((RecipeListChanges) obj)._Carriers)) && (object.Equals((object) this._PrerequisiteTaskList, (object) ((RecipeListChanges) obj)._PrerequisiteTaskList) && object.Equals((object) this._ObjectToChange, (object) ((RecipeListChanges) obj)._ObjectToChange) && (object.Equals((object) this._Scales, (object) ((RecipeListChanges) obj)._Scales) && object.Equals((object) this._Base, (object) ((RecipeListChanges) obj)._Base))) && (this.CompareArrays((Array) this._Tasks, (Array) ((RecipeListChanges) obj)._Tasks) && this.CompareArrays((Array) this._LabelTxnMap, (Array) ((RecipeListChanges) obj)._LabelTxnMap) && (object.Equals((object) this._TargetContainerProduct, (object) ((RecipeListChanges) obj)._TargetContainerProduct) && object.Equals((object) this._Name, (object) ((RecipeListChanges) obj)._Name)) && object.Equals((object) this._TargetContainerLevel, (object) ((RecipeListChanges) obj)._TargetContainerLevel)) && base.Equals(obj);
    }

    public NamedObjectRef TargetContainerUOM
    {
      [param: In] set
      {
        this.PropertySet(nameof (TargetContainerUOM), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (TargetContainerUOM));
      }
    }

    public Primitive<string> TargetContainerPlannedQty
    {
      [param: In] set
      {
        this.PropertySet(nameof (TargetContainerPlannedQty), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (TargetContainerPlannedQty));
      }
    }

    public NamedObjectRef Carriers
    {
      [param: In] set
      {
        this.PropertySet(nameof (Carriers), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (Carriers));
      }
    }

    public new RevisionedObjectRef PrerequisiteTaskList
    {
      [param: In] set
      {
        this.PropertySet(nameof (PrerequisiteTaskList), (object) value);
      }
      get
      {
        return (RevisionedObjectRef) this.PropertyGet(nameof (PrerequisiteTaskList));
      }
    }

    public new RevisionedObjectRef ObjectToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectToChange), (object) value);
      }
      get
      {
        return (RevisionedObjectRef) this.PropertyGet(nameof (ObjectToChange));
      }
    }

    public NamedObjectRef Scales
    {
      [param: In] set
      {
        this.PropertySet(nameof (Scales), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (Scales));
      }
    }

    public new RevisionedObjectRef Base
    {
      [param: In] set
      {
        this.PropertySet(nameof (Base), (object) value);
      }
      get
      {
        return (RevisionedObjectRef) this.PropertyGet(nameof (Base));
      }
    }

    public new ProcessItemChanges[] Tasks
    {
      [param: In] set
      {
        this.PropertySet(nameof (Tasks), (object) value);
      }
      get
      {
        return (ProcessItemChanges[]) this.PropertyGet(nameof (Tasks));
      }
    }

    public RecipeLabelMapChanges[] LabelTxnMap
    {
      [param: In] set
      {
        this.PropertySet(nameof (LabelTxnMap), (object) value);
      }
      get
      {
        return (RecipeLabelMapChanges[]) this.PropertyGet(nameof (LabelTxnMap));
      }
    }

    public RevisionedObjectRef TargetContainerProduct
    {
      [param: In] set
      {
        this.PropertySet(nameof (TargetContainerProduct), (object) value);
      }
      get
      {
        return (RevisionedObjectRef) this.PropertyGet(nameof (TargetContainerProduct));
      }
    }

    public new Primitive<string> Name
    {
      [param: In] set
      {
        this.PropertySet(nameof (Name), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (Name));
      }
    }

    public NamedObjectRef TargetContainerLevel
    {
      [param: In] set
      {
        this.PropertySet(nameof (TargetContainerLevel), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (TargetContainerLevel));
      }
    }
  }
}
