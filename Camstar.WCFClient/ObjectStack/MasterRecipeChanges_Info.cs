// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.MasterRecipeChanges_Info
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
  public class MasterRecipeChanges_Info : ProductionProcessChanges_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "MasterRecipeChanges_Info_RecipeQtyNominal")]
    protected Info _RecipeQtyNominal;
    [DataMember(EmitDefaultValue = false, Name = "MasterRecipeChanges_Info_RecipeQtyUpperLimit")]
    protected Info _RecipeQtyUpperLimit;
    [DataMember(EmitDefaultValue = false, Name = "MasterRecipeChanges_Info_PrinterLabelDefinition")]
    protected Info _PrinterLabelDefinition;
    [DataMember(EmitDefaultValue = false, Name = "MasterRecipeChanges_Info_RecipeUOM")]
    protected Info _RecipeUOM;
    [DataMember(EmitDefaultValue = false, Name = "MasterRecipeChanges_Info_RecipeQtyLowerLimit")]
    protected Info _RecipeQtyLowerLimit;
    [DataMember(EmitDefaultValue = false, Name = "MasterRecipeChanges_Info_ObjectToChange")]
    protected new Info _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "MasterRecipeChanges_Info_EProcedureDetails")]
    protected MasterRecipeDetailChanges_Info _EProcedureDetails;
    [DataMember(EmitDefaultValue = false, Name = "MasterRecipeChanges_Info_Base")]
    protected new Info _Base;
    [DataMember(EmitDefaultValue = false, Name = "MasterRecipeChanges_Info_Workflow")]
    protected Info _Workflow;
    [DataMember(EmitDefaultValue = false, Name = "MasterRecipeChanges_Info_Name")]
    protected new Info _Name;
    [DataMember(EmitDefaultValue = false, Name = "MasterRecipeChanges_Info_RecipeProduct")]
    protected Info _RecipeProduct;

    public Info RecipeQtyNominal
    {
      [param: In] set
      {
        this.PropertySet(nameof (RecipeQtyNominal), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (RecipeQtyNominal));
      }
    }

    public Info RecipeQtyUpperLimit
    {
      [param: In] set
      {
        this.PropertySet(nameof (RecipeQtyUpperLimit), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (RecipeQtyUpperLimit));
      }
    }

    public Info PrinterLabelDefinition
    {
      [param: In] set
      {
        this.PropertySet(nameof (PrinterLabelDefinition), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (PrinterLabelDefinition));
      }
    }

    public Info RecipeUOM
    {
      [param: In] set
      {
        this.PropertySet(nameof (RecipeUOM), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (RecipeUOM));
      }
    }

    public Info RecipeQtyLowerLimit
    {
      [param: In] set
      {
        this.PropertySet(nameof (RecipeQtyLowerLimit), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (RecipeQtyLowerLimit));
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

    public MasterRecipeDetailChanges_Info EProcedureDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (EProcedureDetails), (object) value);
      }
      get
      {
        return (MasterRecipeDetailChanges_Info) this.PropertyGet(nameof (EProcedureDetails));
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

    public Info Workflow
    {
      [param: In] set
      {
        this.PropertySet(nameof (Workflow), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Workflow));
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

    public Info RecipeProduct
    {
      [param: In] set
      {
        this.PropertySet(nameof (RecipeProduct), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (RecipeProduct));
      }
    }
  }
}
