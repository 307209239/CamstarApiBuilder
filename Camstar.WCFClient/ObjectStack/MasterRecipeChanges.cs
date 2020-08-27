// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.MasterRecipeChanges
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
  public class MasterRecipeChanges : ProductionProcessChanges
  {
    [DataMember(EmitDefaultValue = false, Name = "MasterRecipeChanges_RecipeQtyNominal")]
    protected Primitive<string> _RecipeQtyNominal;
    [DataMember(EmitDefaultValue = false, Name = "MasterRecipeChanges_RecipeQtyUpperLimit")]
    protected Primitive<string> _RecipeQtyUpperLimit;
    [DataMember(EmitDefaultValue = false, Name = "MasterRecipeChanges_PrinterLabelDefinition")]
    protected RevisionedObjectRef _PrinterLabelDefinition;
    [DataMember(EmitDefaultValue = false, Name = "MasterRecipeChanges_RecipeUOM")]
    protected NamedObjectRef _RecipeUOM;
    [DataMember(EmitDefaultValue = false, Name = "MasterRecipeChanges_RecipeQtyLowerLimit")]
    protected Primitive<string> _RecipeQtyLowerLimit;
    [DataMember(EmitDefaultValue = false, Name = "MasterRecipeChanges_ObjectToChange")]
    protected new RevisionedObjectRef _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "MasterRecipeChanges_EProcedureDetails")]
    protected MasterRecipeDetailChanges[] _EProcedureDetails;
    [DataMember(EmitDefaultValue = false, Name = "MasterRecipeChanges_Base")]
    protected new RevisionedObjectRef _Base;
    [DataMember(EmitDefaultValue = false, Name = "MasterRecipeChanges_Workflow")]
    protected RevisionedObjectRef _Workflow;
    [DataMember(EmitDefaultValue = false, Name = "MasterRecipeChanges_Name")]
    protected new Primitive<string> _Name;
    [DataMember(EmitDefaultValue = false, Name = "MasterRecipeChanges_RecipeProduct")]
    protected RevisionedObjectRef _RecipeProduct;

    public override bool Equals(object obj)
    {
      return obj is MasterRecipeChanges && object.Equals((object) this._RecipeQtyNominal, (object) ((MasterRecipeChanges) obj)._RecipeQtyNominal) && (object.Equals((object) this._RecipeQtyUpperLimit, (object) ((MasterRecipeChanges) obj)._RecipeQtyUpperLimit) && object.Equals((object) this._PrinterLabelDefinition, (object) ((MasterRecipeChanges) obj)._PrinterLabelDefinition)) && (object.Equals((object) this._RecipeUOM, (object) ((MasterRecipeChanges) obj)._RecipeUOM) && object.Equals((object) this._RecipeQtyLowerLimit, (object) ((MasterRecipeChanges) obj)._RecipeQtyLowerLimit) && (object.Equals((object) this._ObjectToChange, (object) ((MasterRecipeChanges) obj)._ObjectToChange) && this.CompareArrays((Array) this._EProcedureDetails, (Array) ((MasterRecipeChanges) obj)._EProcedureDetails))) && (object.Equals((object) this._Base, (object) ((MasterRecipeChanges) obj)._Base) && object.Equals((object) this._Workflow, (object) ((MasterRecipeChanges) obj)._Workflow) && (object.Equals((object) this._Name, (object) ((MasterRecipeChanges) obj)._Name) && object.Equals((object) this._RecipeProduct, (object) ((MasterRecipeChanges) obj)._RecipeProduct))) && base.Equals(obj);
    }

    public Primitive<string> RecipeQtyNominal
    {
      [param: In] set
      {
        this.PropertySet(nameof (RecipeQtyNominal), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (RecipeQtyNominal));
      }
    }

    public Primitive<string> RecipeQtyUpperLimit
    {
      [param: In] set
      {
        this.PropertySet(nameof (RecipeQtyUpperLimit), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (RecipeQtyUpperLimit));
      }
    }

    public RevisionedObjectRef PrinterLabelDefinition
    {
      [param: In] set
      {
        this.PropertySet(nameof (PrinterLabelDefinition), (object) value);
      }
      get
      {
        return (RevisionedObjectRef) this.PropertyGet(nameof (PrinterLabelDefinition));
      }
    }

    public NamedObjectRef RecipeUOM
    {
      [param: In] set
      {
        this.PropertySet(nameof (RecipeUOM), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (RecipeUOM));
      }
    }

    public Primitive<string> RecipeQtyLowerLimit
    {
      [param: In] set
      {
        this.PropertySet(nameof (RecipeQtyLowerLimit), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (RecipeQtyLowerLimit));
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

    public MasterRecipeDetailChanges[] EProcedureDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (EProcedureDetails), (object) value);
      }
      get
      {
        return (MasterRecipeDetailChanges[]) this.PropertyGet(nameof (EProcedureDetails));
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

    public RevisionedObjectRef Workflow
    {
      [param: In] set
      {
        this.PropertySet(nameof (Workflow), (object) value);
      }
      get
      {
        return (RevisionedObjectRef) this.PropertyGet(nameof (Workflow));
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

    public RevisionedObjectRef RecipeProduct
    {
      [param: In] set
      {
        this.PropertySet(nameof (RecipeProduct), (object) value);
      }
      get
      {
        return (RevisionedObjectRef) this.PropertyGet(nameof (RecipeProduct));
      }
    }
  }
}
