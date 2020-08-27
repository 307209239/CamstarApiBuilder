// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ProductMaterialListItemChanges
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
  public class ProductMaterialListItemChanges : MaterialListItemChanges
  {
    [DataMember(EmitDefaultValue = false, Name = "ProductMaterialListItemChanges_ListItemToChange")]
    protected new NamedSubentityRef _ListItemToChange;
    [DataMember(EmitDefaultValue = false, Name = "ProductMaterialListItemChanges_IssueControl")]
    protected new Enumeration<IssueControlEnum, int> _IssueControl;
    [DataMember(EmitDefaultValue = false, Name = "ProductMaterialListItemChanges_Spec")]
    protected RevisionedObjectRef _Spec;
    [DataMember(EmitDefaultValue = false, Name = "ProductMaterialListItemChanges_ObjectToChange")]
    protected new NamedSubentityRef _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "ProductMaterialListItemChanges_PhantomBill")]
    protected new RevisionedObjectRef _PhantomBill;
    [DataMember(EmitDefaultValue = false, Name = "ProductMaterialListItemChanges_IssuePoint")]
    protected new BaseObjectRef _IssuePoint;
    [DataMember(EmitDefaultValue = false, Name = "ProductMaterialListItemChanges_Name")]
    protected new Primitive<string> _Name;

    public override bool Equals(object obj)
    {
      return obj is ProductMaterialListItemChanges && object.Equals((object) this._ListItemToChange, (object) ((ProductMaterialListItemChanges) obj)._ListItemToChange) && (object.Equals((object) this._IssueControl, (object) ((ProductMaterialListItemChanges) obj)._IssueControl) && object.Equals((object) this._Spec, (object) ((ProductMaterialListItemChanges) obj)._Spec)) && (object.Equals((object) this._ObjectToChange, (object) ((ProductMaterialListItemChanges) obj)._ObjectToChange) && object.Equals((object) this._PhantomBill, (object) ((ProductMaterialListItemChanges) obj)._PhantomBill) && (object.Equals((object) this._IssuePoint, (object) ((ProductMaterialListItemChanges) obj)._IssuePoint) && object.Equals((object) this._Name, (object) ((ProductMaterialListItemChanges) obj)._Name))) && base.Equals(obj);
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

    public RevisionedObjectRef Spec
    {
      [param: In] set
      {
        this.PropertySet(nameof (Spec), (object) value);
      }
      get
      {
        return (RevisionedObjectRef) this.PropertyGet(nameof (Spec));
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

    public new RevisionedObjectRef PhantomBill
    {
      [param: In] set
      {
        this.PropertySet(nameof (PhantomBill), (object) value);
      }
      get
      {
        return (RevisionedObjectRef) this.PropertyGet(nameof (PhantomBill));
      }
    }

    public new BaseObjectRef IssuePoint
    {
      [param: In] set
      {
        this.PropertySet(nameof (IssuePoint), (object) value);
      }
      get
      {
        return (BaseObjectRef) this.PropertyGet(nameof (IssuePoint));
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
