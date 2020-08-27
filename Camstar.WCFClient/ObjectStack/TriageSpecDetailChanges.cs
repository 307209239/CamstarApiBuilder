// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.TriageSpecDetailChanges
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
  public class TriageSpecDetailChanges : NamedSubentityChanges
  {
    [DataMember(EmitDefaultValue = false, Name = "TriageSpecDetailChanges_Role")]
    protected NamedObjectRef _Role;
    [DataMember(EmitDefaultValue = false, Name = "TriageSpecDetailChanges_ToCategory")]
    protected Enumeration<CategoryEnum, int> _ToCategory;
    [DataMember(EmitDefaultValue = false, Name = "TriageSpecDetailChanges_ListItemToChange")]
    protected NamedSubentityRef _ListItemToChange;
    [DataMember(EmitDefaultValue = false, Name = "TriageSpecDetailChanges_ChecklistTemplate")]
    protected RevisionedObjectRef _ChecklistTemplate;
    [DataMember(EmitDefaultValue = false, Name = "TriageSpecDetailChanges_ObjectToChange")]
    protected NamedSubentityRef _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "TriageSpecDetailChanges_Name")]
    protected new Primitive<string> _Name;
    [DataMember(EmitDefaultValue = false, Name = "TriageSpecDetailChanges_Owner")]
    protected NamedObjectRef _Owner;

    public override bool Equals(object obj)
    {
      return obj is TriageSpecDetailChanges && object.Equals((object) this._Role, (object) ((TriageSpecDetailChanges) obj)._Role) && (object.Equals((object) this._ToCategory, (object) ((TriageSpecDetailChanges) obj)._ToCategory) && object.Equals((object) this._ListItemToChange, (object) ((TriageSpecDetailChanges) obj)._ListItemToChange)) && (object.Equals((object) this._ChecklistTemplate, (object) ((TriageSpecDetailChanges) obj)._ChecklistTemplate) && object.Equals((object) this._ObjectToChange, (object) ((TriageSpecDetailChanges) obj)._ObjectToChange) && (object.Equals((object) this._Name, (object) ((TriageSpecDetailChanges) obj)._Name) && object.Equals((object) this._Owner, (object) ((TriageSpecDetailChanges) obj)._Owner))) && base.Equals(obj);
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

    public Enumeration<CategoryEnum, int> ToCategory
    {
      [param: In] set
      {
        this.PropertySet(nameof (ToCategory), (object) value);
      }
      get
      {
        return (Enumeration<CategoryEnum, int>) this.PropertyGet(nameof (ToCategory));
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

    public RevisionedObjectRef ChecklistTemplate
    {
      [param: In] set
      {
        this.PropertySet(nameof (ChecklistTemplate), (object) value);
      }
      get
      {
        return (RevisionedObjectRef) this.PropertyGet(nameof (ChecklistTemplate));
      }
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
