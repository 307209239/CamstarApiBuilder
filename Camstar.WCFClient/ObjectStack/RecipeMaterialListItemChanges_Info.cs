// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.RecipeMaterialListItemChanges_Info
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
  public class RecipeMaterialListItemChanges_Info : MaterialListItemChanges_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "RecipeMaterialListItemChanges_Info_QtyRequiredUpperLimit")]
    protected Info _QtyRequiredUpperLimit;
    [DataMember(EmitDefaultValue = false, Name = "RecipeMaterialListItemChanges_Info_QtyRequiredLowerLimit")]
    protected Info _QtyRequiredLowerLimit;
    [DataMember(EmitDefaultValue = false, Name = "RecipeMaterialListItemChanges_Info_IssueControl")]
    protected new Info _IssueControl;
    [DataMember(EmitDefaultValue = false, Name = "RecipeMaterialListItemChanges_Info_QtyRequiredNominal")]
    protected Info _QtyRequiredNominal;
    [DataMember(EmitDefaultValue = false, Name = "RecipeMaterialListItemChanges_Info_FEFOOverrideESigRequirement")]
    protected Info _FEFOOverrideESigRequirement;
    [DataMember(EmitDefaultValue = false, Name = "RecipeMaterialListItemChanges_Info_ListItemToChange")]
    protected new Info _ListItemToChange;
    [DataMember(EmitDefaultValue = false, Name = "RecipeMaterialListItemChanges_Info_FEFOEnforce")]
    protected Info _FEFOEnforce;
    [DataMember(EmitDefaultValue = false, Name = "RecipeMaterialListItemChanges_Info_ObjectToChange")]
    protected new Info _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "RecipeMaterialListItemChanges_Info_QtyAdditive")]
    protected Info _QtyAdditive;

    public Info QtyRequiredUpperLimit
    {
      [param: In] set
      {
        this.PropertySet(nameof (QtyRequiredUpperLimit), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (QtyRequiredUpperLimit));
      }
    }

    public Info QtyRequiredLowerLimit
    {
      [param: In] set
      {
        this.PropertySet(nameof (QtyRequiredLowerLimit), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (QtyRequiredLowerLimit));
      }
    }

    public new Info IssueControl
    {
      [param: In] set
      {
        this.PropertySet(nameof (IssueControl), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (IssueControl));
      }
    }

    public Info QtyRequiredNominal
    {
      [param: In] set
      {
        this.PropertySet(nameof (QtyRequiredNominal), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (QtyRequiredNominal));
      }
    }

    public Info FEFOOverrideESigRequirement
    {
      [param: In] set
      {
        this.PropertySet(nameof (FEFOOverrideESigRequirement), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (FEFOOverrideESigRequirement));
      }
    }

    public new Info ListItemToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ListItemToChange), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ListItemToChange));
      }
    }

    public Info FEFOEnforce
    {
      [param: In] set
      {
        this.PropertySet(nameof (FEFOEnforce), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (FEFOEnforce));
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

    public Info QtyAdditive
    {
      [param: In] set
      {
        this.PropertySet(nameof (QtyAdditive), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (QtyAdditive));
      }
    }
  }
}
