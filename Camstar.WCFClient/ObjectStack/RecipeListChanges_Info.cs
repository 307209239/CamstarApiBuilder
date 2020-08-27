// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.RecipeListChanges_Info
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
  public class RecipeListChanges_Info : ProcessListChanges_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "RecipeListChanges_Info_TargetContainerUOM")]
    protected Info _TargetContainerUOM;
    [DataMember(EmitDefaultValue = false, Name = "RecipeListChanges_Info_TargetContainerPlannedQty")]
    protected Info _TargetContainerPlannedQty;
    [DataMember(EmitDefaultValue = false, Name = "RecipeListChanges_Info_Carriers")]
    protected Info _Carriers;
    [DataMember(EmitDefaultValue = false, Name = "RecipeListChanges_Info_PrerequisiteTaskList")]
    protected new Info _PrerequisiteTaskList;
    [DataMember(EmitDefaultValue = false, Name = "RecipeListChanges_Info_ObjectToChange")]
    protected new Info _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "RecipeListChanges_Info_Scales")]
    protected Info _Scales;
    [DataMember(EmitDefaultValue = false, Name = "RecipeListChanges_Info_Base")]
    protected new Info _Base;
    [DataMember(EmitDefaultValue = false, Name = "RecipeListChanges_Info_Tasks")]
    protected new ProcessItemChanges_Info _Tasks;
    [DataMember(EmitDefaultValue = false, Name = "RecipeListChanges_Info_LabelTxnMap")]
    protected RecipeLabelMapChanges_Info _LabelTxnMap;
    [DataMember(EmitDefaultValue = false, Name = "RecipeListChanges_Info_TargetContainerProduct")]
    protected Info _TargetContainerProduct;
    [DataMember(EmitDefaultValue = false, Name = "RecipeListChanges_Info_Name")]
    protected new Info _Name;
    [DataMember(EmitDefaultValue = false, Name = "RecipeListChanges_Info_TargetContainerLevel")]
    protected Info _TargetContainerLevel;

    public Info TargetContainerUOM
    {
      [param: In] set
      {
        this.PropertySet(nameof (TargetContainerUOM), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (TargetContainerUOM));
      }
    }

    public Info TargetContainerPlannedQty
    {
      [param: In] set
      {
        this.PropertySet(nameof (TargetContainerPlannedQty), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (TargetContainerPlannedQty));
      }
    }

    public Info Carriers
    {
      [param: In] set
      {
        this.PropertySet(nameof (Carriers), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Carriers));
      }
    }

    public new Info PrerequisiteTaskList
    {
      [param: In] set
      {
        this.PropertySet(nameof (PrerequisiteTaskList), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (PrerequisiteTaskList));
      }
    }

    public new Info ObjectToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectToChange), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ObjectToChange));
      }
    }

    public Info Scales
    {
      [param: In] set
      {
        this.PropertySet(nameof (Scales), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Scales));
      }
    }

    public new Info Base
    {
      [param: In] set
      {
        this.PropertySet(nameof (Base), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Base));
      }
    }

    public new ProcessItemChanges_Info Tasks
    {
      [param: In] set
      {
        this.PropertySet(nameof (Tasks), (object) value);
      }
      get
      {
        return (ProcessItemChanges_Info) this.PropertyGet(nameof (Tasks));
      }
    }

    public RecipeLabelMapChanges_Info LabelTxnMap
    {
      [param: In] set
      {
        this.PropertySet(nameof (LabelTxnMap), (object) value);
      }
      get
      {
        return (RecipeLabelMapChanges_Info) this.PropertyGet(nameof (LabelTxnMap));
      }
    }

    public Info TargetContainerProduct
    {
      [param: In] set
      {
        this.PropertySet(nameof (TargetContainerProduct), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (TargetContainerProduct));
      }
    }

    public new Info Name
    {
      [param: In] set
      {
        this.PropertySet(nameof (Name), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Name));
      }
    }

    public Info TargetContainerLevel
    {
      [param: In] set
      {
        this.PropertySet(nameof (TargetContainerLevel), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (TargetContainerLevel));
      }
    }
  }
}
