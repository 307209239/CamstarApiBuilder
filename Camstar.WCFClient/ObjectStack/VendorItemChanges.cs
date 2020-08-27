// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.VendorItemChanges
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
  public class VendorItemChanges : NamedSubentityChanges
  {
    [DataMember(EmitDefaultValue = false, Name = "VendorItemChanges_ObjectToChange")]
    protected NamedSubentityRef _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "VendorItemChanges_ListItemToChange")]
    protected NamedSubentityRef _ListItemToChange;
    [DataMember(EmitDefaultValue = false, Name = "VendorItemChanges_Name")]
    protected new Primitive<string> _Name;
    [DataMember(EmitDefaultValue = false, Name = "VendorItemChanges_MinOrderQty")]
    protected Primitive<double> _MinOrderQty;
    [DataMember(EmitDefaultValue = false, Name = "VendorItemChanges_Description")]
    protected Primitive<string> _Description;
    [DataMember(EmitDefaultValue = false, Name = "VendorItemChanges_ItemName")]
    protected Primitive<string> _ItemName;
    [DataMember(EmitDefaultValue = false, Name = "VendorItemChanges_LeadTime")]
    protected Primitive<double> _LeadTime;
    [DataMember(EmitDefaultValue = false, Name = "VendorItemChanges_Cost")]
    protected Primitive<double> _Cost;

    public override bool Equals(object obj)
    {
      return obj is VendorItemChanges && object.Equals((object) this._ObjectToChange, (object) ((VendorItemChanges) obj)._ObjectToChange) && (object.Equals((object) this._ListItemToChange, (object) ((VendorItemChanges) obj)._ListItemToChange) && object.Equals((object) this._Name, (object) ((VendorItemChanges) obj)._Name)) && (object.Equals((object) this._MinOrderQty, (object) ((VendorItemChanges) obj)._MinOrderQty) && object.Equals((object) this._Description, (object) ((VendorItemChanges) obj)._Description) && (object.Equals((object) this._ItemName, (object) ((VendorItemChanges) obj)._ItemName) && object.Equals((object) this._LeadTime, (object) ((VendorItemChanges) obj)._LeadTime))) && object.Equals((object) this._Cost, (object) ((VendorItemChanges) obj)._Cost) && base.Equals(obj);
    }

    public NamedSubentityRef ObjectToChange
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

    public NamedSubentityRef ListItemToChange
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

    public Primitive<double> MinOrderQty
    {
      [param: In] set
      {
        this.PropertySet(nameof (MinOrderQty), (object) value);
      }
      get
      {
        return (Primitive<double>) this.PropertyGet(nameof (MinOrderQty));
      }
    }

    public Primitive<string> Description
    {
      [param: In] set
      {
        this.PropertySet(nameof (Description), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (Description));
      }
    }

    public Primitive<string> ItemName
    {
      [param: In] set
      {
        this.PropertySet(nameof (ItemName), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (ItemName));
      }
    }

    public Primitive<double> LeadTime
    {
      [param: In] set
      {
        this.PropertySet(nameof (LeadTime), (object) value);
      }
      get
      {
        return (Primitive<double>) this.PropertyGet(nameof (LeadTime));
      }
    }

    public Primitive<double> Cost
    {
      [param: In] set
      {
        this.PropertySet(nameof (Cost), (object) value);
      }
      get
      {
        return (Primitive<double>) this.PropertyGet(nameof (Cost));
      }
    }
  }
}
