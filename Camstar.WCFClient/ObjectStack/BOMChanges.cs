// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.BOMChanges
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
  public class BOMChanges : BillChanges
  {
    [DataMember(EmitDefaultValue = false, Name = "BOMChanges_MaterialList")]
    protected ProductMaterialListItemChanges[] _MaterialList;
    [DataMember(EmitDefaultValue = false, Name = "BOMChanges_MaterialListItem")]
    protected ProductMaterialListItemChanges _MaterialListItem;
    [DataMember(EmitDefaultValue = false, Name = "BOMChanges_Base")]
    protected new RevisionedObjectRef _Base;
    [DataMember(EmitDefaultValue = false, Name = "BOMChanges_ObjectToChange")]
    protected new RevisionedObjectRef _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "BOMChanges_Name")]
    protected new Primitive<string> _Name;
    [DataMember(EmitDefaultValue = false, Name = "BOMChanges_IsRevOfRcd")]
    protected new Primitive<bool> _IsRevOfRcd;

    public override bool Equals(object obj)
    {
      return obj is BOMChanges && this.CompareArrays((Array) this._MaterialList, (Array) ((BOMChanges) obj)._MaterialList) && (object.Equals((object) this._MaterialListItem, (object) ((BOMChanges) obj)._MaterialListItem) && object.Equals((object) this._Base, (object) ((BOMChanges) obj)._Base)) && (object.Equals((object) this._ObjectToChange, (object) ((BOMChanges) obj)._ObjectToChange) && object.Equals((object) this._Name, (object) ((BOMChanges) obj)._Name) && object.Equals((object) this._IsRevOfRcd, (object) ((BOMChanges) obj)._IsRevOfRcd)) && base.Equals(obj);
    }

    public ProductMaterialListItemChanges[] MaterialList
    {
      [param: In] set
      {
        this.PropertySet(nameof (MaterialList), (object) value);
      }
      get
      {
        return (ProductMaterialListItemChanges[]) this.PropertyGet(nameof (MaterialList));
      }
    }

    public ProductMaterialListItemChanges MaterialListItem
    {
      [param: In] set
      {
        this.PropertySet(nameof (MaterialListItem), (object) value);
      }
      get
      {
        return (ProductMaterialListItemChanges) this.PropertyGet(nameof (MaterialListItem));
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

    public new Primitive<bool> IsRevOfRcd
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsRevOfRcd), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (IsRevOfRcd));
      }
    }
  }
}
