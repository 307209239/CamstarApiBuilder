// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.VendorItemChanges_Environment
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
  public class VendorItemChanges_Environment : NamedSubentityChanges_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "VendorItemChanges_Environment_ObjectToChange")]
    [Metadata("Vendor Items are the products the vendor sells.  This item is specified in the Product where, for purchased products, one can relate the product to a list of sources where the product can be purchased.  In addition, when issuing components to a container, one can specify the VendorItem used to fulfill the component requirement.", "VendorItem", false, false, false, "NamedSubentityRef", 1048682, false, false, true, null)]
    protected new Environment _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "VendorItemChanges_Environment_ListItemToChange")]
    [Metadata("Vendor Items are the products the vendor sells.  This item is specified in the Product where, for purchased products, one can relate the product to a list of sources where the product can be purchased.  In addition, when issuing components to a container, one can specify the VendorItem used to fulfill the component requirement.", "VendorItemChanges", false, false, false, "NamedSubentityRef", 1049321, false, false, false, null)]
    protected new Environment _ListItemToChange;
    [Metadata("Unique name for this instance", "", false, true, false, "String", 1050263, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "VendorItemChanges_Environment_Name")]
    protected new Environment _Name;
    [Metadata("Material quantity (individual)", "", false, false, false, "Fixed", 1049659, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "VendorItemChanges_Environment_MinOrderQty")]
    protected Environment _MinOrderQty;
    [DataMember(EmitDefaultValue = false, Name = "VendorItemChanges_Environment_Description")]
    [Metadata("Description of this entity. Defaults to the name of this entity if not specified", "", false, false, false, "String", 1048678, false, false, false, null)]
    protected Environment _Description;
    [Metadata("Unique name for this instance", "", false, false, false, "String", 1050263, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "VendorItemChanges_Environment_ItemName")]
    protected Environment _ItemName;
    [DataMember(EmitDefaultValue = false, Name = "VendorItemChanges_Environment_LeadTime")]
    [Metadata("Time as a duration", "", false, false, false, "Float", 1049423, false, false, false, null)]
    protected Environment _LeadTime;
    [Metadata("Cost per unit", "", false, false, false, "Fixed", 1049424, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "VendorItemChanges_Environment_Cost")]
    protected Environment _Cost;

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

    public Environment MinOrderQty
    {
      [param: In] set
      {
        this.PropertySet(nameof (MinOrderQty), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (MinOrderQty));
      }
    }

    public Environment Description
    {
      [param: In] set
      {
        this.PropertySet(nameof (Description), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Description));
      }
    }

    public Environment ItemName
    {
      [param: In] set
      {
        this.PropertySet(nameof (ItemName), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ItemName));
      }
    }

    public Environment LeadTime
    {
      [param: In] set
      {
        this.PropertySet(nameof (LeadTime), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (LeadTime));
      }
    }

    public Environment Cost
    {
      [param: In] set
      {
        this.PropertySet(nameof (Cost), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Cost));
      }
    }
  }
}
