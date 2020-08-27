// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.RecipeMaterialListItemChanges_Environment
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
  public class RecipeMaterialListItemChanges_Environment : MaterialListItemChanges_Environment
  {
    [Metadata("Field Expression.", "", false, false, false, "String", 1051831, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "RecipeMaterialListItemChanges_Environment_QtyRequiredUpperLimit")]
    protected Environment _QtyRequiredUpperLimit;
    [Metadata("Field Expression.", "", false, false, false, "String", 1051830, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "RecipeMaterialListItemChanges_Environment_QtyRequiredLowerLimit")]
    protected Environment _QtyRequiredLowerLimit;
    [DataMember(EmitDefaultValue = false, Name = "RecipeMaterialListItemChanges_Environment_IssueControl")]
    [Metadata("1 - Container is tracked in InSite at the serial level\r\n2 - Container is tracked in InSite at the bulk level\r\n3 - Container is not tracked in InSite ... quantity and lot is recorded\r\n4 - non lot controlled ( floor stock ) location is recorded no container\r\n5 - recording quantities but not container or location\r\n6 - issue quantities are displayed but not recorded\r\n", "IssueControlEnum", false, true, false, "Integer", 1049491, false, false, true, null)]
    protected new Environment _IssueControl;
    [Metadata("Field Expression.", "", false, true, false, "String", 1051829, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "RecipeMaterialListItemChanges_Environment_QtyRequiredNominal")]
    protected Environment _QtyRequiredNominal;
    [DataMember(EmitDefaultValue = false, Name = "RecipeMaterialListItemChanges_Environment_FEFOOverrideESigRequirement")]
    [Metadata("Contains the list of signatures that should be collected in a single transaction.", "ESigRequirement", false, false, false, "NamedObjectRef", 1051827, false, false, true, null)]
    protected Environment _FEFOOverrideESigRequirement;
    [Metadata("A single entry MaterialListItem of type RecipeMaterialListItem.", "RecipeMaterialListItemChanges", false, false, false, "NamedSubentityRef", 1049321, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "RecipeMaterialListItemChanges_Environment_ListItemToChange")]
    protected new Environment _ListItemToChange;
    [DataMember(EmitDefaultValue = false, Name = "RecipeMaterialListItemChanges_Environment_FEFOEnforce")]
    [Metadata("An enumeration of FEFOEnforceType. 0=Not Enforced, 1=Enforced, 2=Warn, 3=WarnWithESig", "FEFOEnum", false, false, false, "Integer", 1051826, false, false, true, null)]
    protected Environment _FEFOEnforce;
    [Metadata("A single entry MaterialListItem of type RecipeMaterialListItem.", "RecipeMaterialListItem", false, false, false, "NamedSubentityRef", 1048682, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "RecipeMaterialListItemChanges_Environment_ObjectToChange")]
    protected new Environment _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "RecipeMaterialListItemChanges_Environment_QtyAdditive")]
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1051828, false, false, false, "0")]
    protected Environment _QtyAdditive;

    public Environment QtyRequiredUpperLimit
    {
      [param: In] set
      {
        this.PropertySet(nameof (QtyRequiredUpperLimit), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (QtyRequiredUpperLimit));
      }
    }

    public Environment QtyRequiredLowerLimit
    {
      [param: In] set
      {
        this.PropertySet(nameof (QtyRequiredLowerLimit), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (QtyRequiredLowerLimit));
      }
    }

    public new Environment IssueControl
    {
      [param: In] set
      {
        this.PropertySet(nameof (IssueControl), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (IssueControl));
      }
    }

    public Environment QtyRequiredNominal
    {
      [param: In] set
      {
        this.PropertySet(nameof (QtyRequiredNominal), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (QtyRequiredNominal));
      }
    }

    public Environment FEFOOverrideESigRequirement
    {
      [param: In] set
      {
        this.PropertySet(nameof (FEFOOverrideESigRequirement), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (FEFOOverrideESigRequirement));
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

    public Environment FEFOEnforce
    {
      [param: In] set
      {
        this.PropertySet(nameof (FEFOEnforce), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (FEFOEnforce));
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

    public Environment QtyAdditive
    {
      [param: In] set
      {
        this.PropertySet(nameof (QtyAdditive), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (QtyAdditive));
      }
    }
  }
}
