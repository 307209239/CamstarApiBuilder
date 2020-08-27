// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.VendorChanges
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
  public class VendorChanges : NamedDataObjectChanges
  {
    [DataMember(EmitDefaultValue = false, Name = "VendorChanges_VendorItemItem")]
    protected VendorItemChanges _VendorItemItem;
    [DataMember(EmitDefaultValue = false, Name = "VendorChanges_VendorItems")]
    protected VendorItemChanges[] _VendorItems;
    [DataMember(EmitDefaultValue = false, Name = "VendorChanges_ObjectToChange")]
    protected new NamedObjectRef _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "VendorChanges_Name")]
    protected new Primitive<string> _Name;

    public override bool Equals(object obj)
    {
      return obj is VendorChanges && object.Equals((object) this._VendorItemItem, (object) ((VendorChanges) obj)._VendorItemItem) && (this.CompareArrays((Array) this._VendorItems, (Array) ((VendorChanges) obj)._VendorItems) && object.Equals((object) this._ObjectToChange, (object) ((VendorChanges) obj)._ObjectToChange)) && object.Equals((object) this._Name, (object) ((VendorChanges) obj)._Name) && base.Equals(obj);
    }

    public VendorItemChanges VendorItemItem
    {
      [param: In] set
      {
        this.PropertySet(nameof (VendorItemItem), (object) value);
      }
      get
      {
        return (VendorItemChanges) this.PropertyGet(nameof (VendorItemItem));
      }
    }

    public VendorItemChanges[] VendorItems
    {
      [param: In] set
      {
        this.PropertySet(nameof (VendorItems), (object) value);
      }
      get
      {
        return (VendorItemChanges[]) this.PropertyGet(nameof (VendorItems));
      }
    }

    public new NamedObjectRef ObjectToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectToChange), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (ObjectToChange));
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
  }
}
