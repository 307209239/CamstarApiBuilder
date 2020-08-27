// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.RecipeMaterialListItemChanges
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
  public class RecipeMaterialListItemChanges : MaterialListItemChanges
  {
    [DataMember(EmitDefaultValue = false, Name = "RecipeMaterialListItemChanges_QtyRequiredUpperLimit")]
    protected Primitive<string> _QtyRequiredUpperLimit;
    [DataMember(EmitDefaultValue = false, Name = "RecipeMaterialListItemChanges_QtyRequiredLowerLimit")]
    protected Primitive<string> _QtyRequiredLowerLimit;
    [DataMember(EmitDefaultValue = false, Name = "RecipeMaterialListItemChanges_IssueControl")]
    protected new Enumeration<IssueControlEnum, int> _IssueControl;
    [DataMember(EmitDefaultValue = false, Name = "RecipeMaterialListItemChanges_QtyRequiredNominal")]
    protected Primitive<string> _QtyRequiredNominal;
    [DataMember(EmitDefaultValue = false, Name = "RecipeMaterialListItemChanges_FEFOOverrideESigRequirement")]
    protected NamedObjectRef _FEFOOverrideESigRequirement;
    [DataMember(EmitDefaultValue = false, Name = "RecipeMaterialListItemChanges_ListItemToChange")]
    protected new NamedSubentityRef _ListItemToChange;
    [DataMember(EmitDefaultValue = false, Name = "RecipeMaterialListItemChanges_FEFOEnforce")]
    protected Enumeration<FEFOEnum, int> _FEFOEnforce;
    [DataMember(EmitDefaultValue = false, Name = "RecipeMaterialListItemChanges_ObjectToChange")]
    protected new NamedSubentityRef _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "RecipeMaterialListItemChanges_QtyAdditive")]
    protected Primitive<bool> _QtyAdditive;

    public override bool Equals(object obj)
    {
      return obj is RecipeMaterialListItemChanges && object.Equals((object) this._QtyRequiredUpperLimit, (object) ((RecipeMaterialListItemChanges) obj)._QtyRequiredUpperLimit) && (object.Equals((object) this._QtyRequiredLowerLimit, (object) ((RecipeMaterialListItemChanges) obj)._QtyRequiredLowerLimit) && object.Equals((object) this._IssueControl, (object) ((RecipeMaterialListItemChanges) obj)._IssueControl)) && (object.Equals((object) this._QtyRequiredNominal, (object) ((RecipeMaterialListItemChanges) obj)._QtyRequiredNominal) && object.Equals((object) this._FEFOOverrideESigRequirement, (object) ((RecipeMaterialListItemChanges) obj)._FEFOOverrideESigRequirement) && (object.Equals((object) this._ListItemToChange, (object) ((RecipeMaterialListItemChanges) obj)._ListItemToChange) && object.Equals((object) this._FEFOEnforce, (object) ((RecipeMaterialListItemChanges) obj)._FEFOEnforce))) && (object.Equals((object) this._ObjectToChange, (object) ((RecipeMaterialListItemChanges) obj)._ObjectToChange) && object.Equals((object) this._QtyAdditive, (object) ((RecipeMaterialListItemChanges) obj)._QtyAdditive)) && base.Equals(obj);
    }

    public Primitive<string> QtyRequiredUpperLimit
    {
      [param: In] set
      {
        this.PropertySet(nameof (QtyRequiredUpperLimit), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (QtyRequiredUpperLimit));
      }
    }

    public Primitive<string> QtyRequiredLowerLimit
    {
      [param: In] set
      {
        this.PropertySet(nameof (QtyRequiredLowerLimit), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (QtyRequiredLowerLimit));
      }
    }

    public new Enumeration<IssueControlEnum, int> IssueControl
    {
      [param: In] set
      {
        this.PropertySet(nameof (IssueControl), (object) value);
      }
      get
      {
        return (Enumeration<IssueControlEnum, int>) this.PropertyGet(nameof (IssueControl));
      }
    }

    public Primitive<string> QtyRequiredNominal
    {
      [param: In] set
      {
        this.PropertySet(nameof (QtyRequiredNominal), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (QtyRequiredNominal));
      }
    }

    public NamedObjectRef FEFOOverrideESigRequirement
    {
      [param: In] set
      {
        this.PropertySet(nameof (FEFOOverrideESigRequirement), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (FEFOOverrideESigRequirement));
      }
    }

    public new NamedSubentityRef ListItemToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ListItemToChange), (object) value);
      }
      get
      {
        return (NamedSubentityRef) this.PropertyGet(nameof (ListItemToChange));
      }
    }

    public Enumeration<FEFOEnum, int> FEFOEnforce
    {
      [param: In] set
      {
        this.PropertySet(nameof (FEFOEnforce), (object) value);
      }
      get
      {
        return (Enumeration<FEFOEnum, int>) this.PropertyGet(nameof (FEFOEnforce));
      }
    }

    public new NamedSubentityRef ObjectToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectToChange), (object) value);
      }
      get
      {
        return (NamedSubentityRef) this.PropertyGet(nameof (ObjectToChange));
      }
    }

    public Primitive<bool> QtyAdditive
    {
      [param: In] set
      {
        this.PropertySet(nameof (QtyAdditive), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (QtyAdditive));
      }
    }
  }
}
