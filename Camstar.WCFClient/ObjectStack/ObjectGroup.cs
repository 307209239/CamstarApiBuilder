// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ObjectGroup
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
  public class ObjectGroup : NamedDataObject
  {
    [DataMember(EmitDefaultValue = false, Name = "ObjectGroup_DisplayName")]
    protected new Primitive<string> _DisplayName;
    [DataMember(EmitDefaultValue = false, Name = "ObjectGroup_WhereUsed")]
    protected new SubentityRef[] _WhereUsed;
    [DataMember(EmitDefaultValue = false, Name = "ObjectGroup_ModelingInstanceLocks")]
    protected new SubentityRef[] _ModelingInstanceLocks;
    [DataMember(EmitDefaultValue = false, Name = "ObjectGroup_FilterTags")]
    protected new Primitive<string> _FilterTags;
    [DataMember(EmitDefaultValue = false, Name = "ObjectGroup_Entries")]
    protected BaseObjectRef[] _Entries;
    [DataMember(EmitDefaultValue = false, Name = "ObjectGroup_InstanceLocked")]
    protected new Primitive<bool> _InstanceLocked;
    [DataMember(EmitDefaultValue = false, Name = "ObjectGroup_AssociatedPackages")]
    protected new Primitive<int> _AssociatedPackages;
    [DataMember(EmitDefaultValue = false, Name = "ObjectGroup_DefaultForObjectTypes")]
    protected Primitive<int>[] _DefaultForObjectTypes;
    [DataMember(EmitDefaultValue = false, Name = "ObjectGroup_ResolvedEntries")]
    protected BaseObjectRef[] _ResolvedEntries;
    [DataMember(EmitDefaultValue = false, Name = "ObjectGroup_ChangeHistory")]
    protected new ChangeHistory _ChangeHistory;
    [DataMember(EmitDefaultValue = false, Name = "ObjectGroup_IsFrozen")]
    protected new Primitive<bool> _IsFrozen;
    [DataMember(EmitDefaultValue = false, Name = "ObjectGroup_EntryType")]
    protected Primitive<string> _EntryType;
    [DataMember(EmitDefaultValue = false, Name = "ObjectGroup_Description")]
    protected new Primitive<string> _Description;
    [DataMember(EmitDefaultValue = false, Name = "ObjectGroup_Notes")]
    protected new Primitive<string> _Notes;
    [DataMember(EmitDefaultValue = false, Name = "ObjectGroup_IconId")]
    protected new Primitive<int> _IconId;
    [DataMember(EmitDefaultValue = false, Name = "ObjectGroup_Groups")]
    protected NamedObjectRef[] _Groups;
    [DataMember(EmitDefaultValue = false, Name = "ObjectGroup_Name")]
    protected new Primitive<string> _Name;

    public override bool Equals(object obj)
    {
      return obj is ObjectGroup && object.Equals((object) this._DisplayName, (object) ((ObjectGroup) obj)._DisplayName) && (this.CompareArrays((Array) this._WhereUsed, (Array) ((ObjectGroup) obj)._WhereUsed) && this.CompareArrays((Array) this._ModelingInstanceLocks, (Array) ((ObjectGroup) obj)._ModelingInstanceLocks)) && (object.Equals((object) this._FilterTags, (object) ((ObjectGroup) obj)._FilterTags) && this.CompareArrays((Array) this._Entries, (Array) ((ObjectGroup) obj)._Entries) && (object.Equals((object) this._InstanceLocked, (object) ((ObjectGroup) obj)._InstanceLocked) && object.Equals((object) this._AssociatedPackages, (object) ((ObjectGroup) obj)._AssociatedPackages))) && (this.CompareArrays((Array) this._DefaultForObjectTypes, (Array) ((ObjectGroup) obj)._DefaultForObjectTypes) && this.CompareArrays((Array) this._ResolvedEntries, (Array) ((ObjectGroup) obj)._ResolvedEntries) && (object.Equals((object) this._ChangeHistory, (object) ((ObjectGroup) obj)._ChangeHistory) && object.Equals((object) this._IsFrozen, (object) ((ObjectGroup) obj)._IsFrozen)) && (object.Equals((object) this._EntryType, (object) ((ObjectGroup) obj)._EntryType) && object.Equals((object) this._Description, (object) ((ObjectGroup) obj)._Description) && (object.Equals((object) this._Notes, (object) ((ObjectGroup) obj)._Notes) && object.Equals((object) this._IconId, (object) ((ObjectGroup) obj)._IconId)))) && (this.CompareArrays((Array) this._Groups, (Array) ((ObjectGroup) obj)._Groups) && object.Equals((object) this._Name, (object) ((ObjectGroup) obj)._Name)) && base.Equals(obj);
    }

    public new Primitive<string> DisplayName
    {
      [param: In] set
      {
        this.PropertySet(nameof (DisplayName), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (DisplayName));
      }
    }

    public new SubentityRef[] WhereUsed
    {
      [param: In] set
      {
        this.PropertySet(nameof (WhereUsed), (object) value);
      }
      get
      {
        return (SubentityRef[]) this.PropertyGet(nameof (WhereUsed));
      }
    }

    public new SubentityRef[] ModelingInstanceLocks
    {
      [param: In] set
      {
        this.PropertySet(nameof (ModelingInstanceLocks), (object) value);
      }
      get
      {
        return (SubentityRef[]) this.PropertyGet(nameof (ModelingInstanceLocks));
      }
    }

    public new Primitive<string> FilterTags
    {
      [param: In] set
      {
        this.PropertySet(nameof (FilterTags), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (FilterTags));
      }
    }

    public BaseObjectRef[] Entries
    {
      [param: In] set
      {
        this.PropertySet(nameof (Entries), (object) value);
      }
      get
      {
        return (BaseObjectRef[]) this.PropertyGet(nameof (Entries));
      }
    }

    public new Primitive<bool> InstanceLocked
    {
      [param: In] set
      {
        this.PropertySet(nameof (InstanceLocked), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (InstanceLocked));
      }
    }

    public new Primitive<int> AssociatedPackages
    {
      [param: In] set
      {
        this.PropertySet(nameof (AssociatedPackages), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (AssociatedPackages));
      }
    }

    public Primitive<int>[] DefaultForObjectTypes
    {
      [param: In] set
      {
        this.PropertySet(nameof (DefaultForObjectTypes), (object) value);
      }
      get
      {
        return (Primitive<int>[]) this.PropertyGet(nameof (DefaultForObjectTypes));
      }
    }

    public BaseObjectRef[] ResolvedEntries
    {
      [param: In] set
      {
        this.PropertySet(nameof (ResolvedEntries), (object) value);
      }
      get
      {
        return (BaseObjectRef[]) this.PropertyGet(nameof (ResolvedEntries));
      }
    }

    public new ChangeHistory ChangeHistory
    {
      [param: In] set
      {
        this.PropertySet(nameof (ChangeHistory), (object) value);
      }
      get
      {
        return (ChangeHistory) this.PropertyGet(nameof (ChangeHistory));
      }
    }

    public new Primitive<bool> IsFrozen
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

    public Primitive<string> EntryType
    {
      [param: In] set
      {
        this.PropertySet(nameof (EntryType), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (EntryType));
      }
    }

    public new Primitive<string> Description
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

    public new Primitive<string> Notes
    {
      [param: In] set
      {
        this.PropertySet(nameof (Notes), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (Notes));
      }
    }

    public new Primitive<int> IconId
    {
      [param: In] set
      {
        this.PropertySet(nameof (IconId), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (IconId));
      }
    }

    public NamedObjectRef[] Groups
    {
      [param: In] set
      {
        this.PropertySet(nameof (Groups), (object) value);
      }
      get
      {
        return (NamedObjectRef[]) this.PropertyGet(nameof (Groups));
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
