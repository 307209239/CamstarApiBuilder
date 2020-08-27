// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.CategoryMapChanges
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
  public class CategoryMapChanges : SubentityChanges
  {
    [DataMember(EmitDefaultValue = false, Name = "CategoryMapChanges_Role")]
    protected NamedObjectRef _Role;
    [DataMember(EmitDefaultValue = false, Name = "CategoryMapChanges_Category")]
    protected Enumeration<CategoryEnum, int> _Category;
    [DataMember(EmitDefaultValue = false, Name = "CategoryMapChanges_ObjectToChange")]
    protected new SubentityRef _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "CategoryMapChanges_TriageSpec")]
    protected NamedObjectRef _TriageSpec;
    [DataMember(EmitDefaultValue = false, Name = "CategoryMapChanges_ApprovalSheetMap")]
    protected ApprovalSheetMapChanges[] _ApprovalSheetMap;
    [DataMember(EmitDefaultValue = false, Name = "CategoryMapChanges_ListItemToChange")]
    protected new SubentityRef _ListItemToChange;
    [DataMember(EmitDefaultValue = false, Name = "CategoryMapChanges_IsFrozen")]
    protected Primitive<bool> _IsFrozen;
    [DataMember(EmitDefaultValue = false, Name = "CategoryMapChanges_Owner")]
    protected NamedObjectRef _Owner;

    public override bool Equals(object obj)
    {
      return obj is CategoryMapChanges && object.Equals((object) this._Role, (object) ((CategoryMapChanges) obj)._Role) && (object.Equals((object) this._Category, (object) ((CategoryMapChanges) obj)._Category) && object.Equals((object) this._ObjectToChange, (object) ((CategoryMapChanges) obj)._ObjectToChange)) && (object.Equals((object) this._TriageSpec, (object) ((CategoryMapChanges) obj)._TriageSpec) && this.CompareArrays((Array) this._ApprovalSheetMap, (Array) ((CategoryMapChanges) obj)._ApprovalSheetMap) && (object.Equals((object) this._ListItemToChange, (object) ((CategoryMapChanges) obj)._ListItemToChange) && object.Equals((object) this._IsFrozen, (object) ((CategoryMapChanges) obj)._IsFrozen))) && object.Equals((object) this._Owner, (object) ((CategoryMapChanges) obj)._Owner) && base.Equals(obj);
    }

    public NamedObjectRef Role
    {
      [param: In] set
      {
        this.PropertySet(nameof (Role), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (Role));
      }
    }

    public Enumeration<CategoryEnum, int> Category
    {
      [param: In] set
      {
        this.PropertySet(nameof (Category), (object) value);
      }
      get
      {
        return (Enumeration<CategoryEnum, int>) this.PropertyGet(nameof (Category));
      }
    }

    public new SubentityRef ObjectToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectToChange), (object) value);
      }
      get
      {
        return (SubentityRef) this.PropertyGet(nameof (ObjectToChange));
      }
    }

    public NamedObjectRef TriageSpec
    {
      [param: In] set
      {
        this.PropertySet(nameof (TriageSpec), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (TriageSpec));
      }
    }

    public ApprovalSheetMapChanges[] ApprovalSheetMap
    {
      [param: In] set
      {
        this.PropertySet(nameof (ApprovalSheetMap), (object) value);
      }
      get
      {
        return (ApprovalSheetMapChanges[]) this.PropertyGet(nameof (ApprovalSheetMap));
      }
    }

    public new SubentityRef ListItemToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ListItemToChange), (object) value);
      }
      get
      {
        return (SubentityRef) this.PropertyGet(nameof (ListItemToChange));
      }
    }

    public Primitive<bool> IsFrozen
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsFrozen), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (IsFrozen));
      }
    }

    public NamedObjectRef Owner
    {
      [param: In] set
      {
        this.PropertySet(nameof (Owner), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (Owner));
      }
    }
  }
}
