// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.BOMChanges_Environment
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
  public class BOMChanges_Environment : BillChanges_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "BOMChanges_Environment_MaterialList")]
    [Metadata("Represents, depending on context, an item or product that is required to complete a given manufacturing or assembly operation. The necessary quantities or proportions of the item are specified as are the appropriate units of measure.", "ProductMaterialListItemChanges", false, false, false, "ProductMaterialListItemChanges", 1049427, false, true, false, null)]
    protected ProductMaterialListItemChanges_Environment _MaterialList;
    [DataMember(EmitDefaultValue = false, Name = "BOMChanges_Environment_MaterialListItem")]
    [Metadata("Represents, depending on context, an item or product that is required to complete a given manufacturing or assembly operation. The necessary quantities or proportions of the item are specified as are the appropriate units of measure.", "ProductMaterialListItemChanges", false, false, false, "ProductMaterialListItemChanges", 1049721, true, false, false, null)]
    protected ProductMaterialListItemChanges_Environment _MaterialListItem;
    [DataMember(EmitDefaultValue = false, Name = "BOMChanges_Environment_Base")]
    [Metadata("A bill of material(BOM) defines the materials (raw materials, sub-assemblies, instructions, etc.) needed to produce a container.  BOMs are most often defined per product, but can be defined per order, per container, etc.", "BOMBase", false, false, false, "RevisionedObjectRef", 1048857, false, false, false, null)]
    protected new Environment _Base;
    [DataMember(EmitDefaultValue = false, Name = "BOMChanges_Environment_ObjectToChange")]
    [Metadata("A bill of material defines the materials needed to produce a specific product.", "BOM", false, false, false, "RevisionedObjectRef", 1048682, false, false, true, null)]
    protected new Environment _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "BOMChanges_Environment_Name")]
    [Metadata("Unique name for this instance", "", false, true, false, "String", 1050225, false, false, false, null)]
    protected new Environment _Name;
    [DataMember(EmitDefaultValue = false, Name = "BOMChanges_Environment_IsRevOfRcd")]
    [Metadata("Determines if this instance is the current Revision of Record (by comparing ID to BaseEntity.RevisionOfRecord)", "", false, false, false, "Boolean", 1048708, false, false, false, "0")]
    protected new Environment _IsRevOfRcd;

    public ProductMaterialListItemChanges_Environment MaterialList
    {
      [param: In] set
      {
        this.PropertySet(nameof (MaterialList), (object) value);
      }
      get
      {
        return (ProductMaterialListItemChanges_Environment) this.PropertyGet(nameof (MaterialList));
      }
    }

    public ProductMaterialListItemChanges_Environment MaterialListItem
    {
      [param: In] set
      {
        this.PropertySet(nameof (MaterialListItem), (object) value);
      }
      get
      {
        return (ProductMaterialListItemChanges_Environment) this.PropertyGet(nameof (MaterialListItem));
      }
    }

    public new Environment Base
    {
      [param: In] set
      {
        this.PropertySet(nameof (Base), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Base));
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

    public new Environment Name
    {
      [param: In] set
      {
        this.PropertySet(nameof (Name), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Name));
      }
    }

    public new Environment IsRevOfRcd
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsRevOfRcd), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (IsRevOfRcd));
      }
    }
  }
}
