// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.NamedObjectGroup
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
  public class NamedObjectGroup : ObjectGroup
  {
    [DataMember(EmitDefaultValue = false, Name = "NamedObjectGroup_Groups")]
    protected new NamedObjectRef[] _Groups;
    [DataMember(EmitDefaultValue = false, Name = "NamedObjectGroup_WhereUsed")]
    protected new SubentityRef[] _WhereUsed;
    [DataMember(EmitDefaultValue = false, Name = "NamedObjectGroup_DisplayName")]
    protected new Primitive<string> _DisplayName;
    [DataMember(EmitDefaultValue = false, Name = "NamedObjectGroup_ModelingInstanceLocks")]
    protected new SubentityRef[] _ModelingInstanceLocks;
    [DataMember(EmitDefaultValue = false, Name = "NamedObjectGroup_FilterTags")]
    protected new Primitive<string> _FilterTags;
    [DataMember(EmitDefaultValue = false, Name = "NamedObjectGroup_ResolvedEntries")]
    protected new BaseObjectRef[] _ResolvedEntries;
    [DataMember(EmitDefaultValue = false, Name = "NamedObjectGroup_AssociatedPackages")]
    protected new Primitive<int> _AssociatedPackages;
    [DataMember(EmitDefaultValue = false, Name = "NamedObjectGroup_Entries")]
    protected NamedObjectRef[] _Entries;
    [DataMember(EmitDefaultValue = false, Name = "NamedObjectGroup_InstanceLocked")]
    protected new Primitive<bool> _InstanceLocked;
    [DataMember(EmitDefaultValue = false, Name = "NamedObjectGroup_DefaultForObjectTypes")]
    protected new Primitive<int>[] _DefaultForObjectTypes;
    [DataMember(EmitDefaultValue = false, Name = "NamedObjectGroup_Name")]
    protected new Primitive<string> _Name;
    [DataMember(EmitDefaultValue = false, Name = "NamedObjectGroup_Description")]
    protected new Primitive<string> _Description;
    [DataMember(EmitDefaultValue = false, Name = "NamedObjectGroup_EntryType")]
    protected new Primitive<string> _EntryType;
    [DataMember(EmitDefaultValue = false, Name = "NamedObjectGroup_Notes")]
    protected new Primitive<string> _Notes;
    [DataMember(EmitDefaultValue = false, Name = "NamedObjectGroup_IconId")]
    protected new Primitive<int> _IconId;
    [DataMember(EmitDefaultValue = false, Name = "NamedObjectGroup_ChangeHistory")]
    protected new ChangeHistory _ChangeHistory;
    [DataMember(EmitDefaultValue = false, Name = "NamedObjectGroup_IsFrozen")]
    protected new Primitive<bool> _IsFrozen;

    public override bool Equals(object obj)
    {
      return obj is NamedObjectGroup && this.CompareArrays((Array) this._Groups, (Array) ((NamedObjectGroup) obj)._Groups) && (this.CompareArrays((Array) this._WhereUsed, (Array) ((NamedObjectGroup) obj)._WhereUsed) && object.Equals((object) this._DisplayName, (object) ((NamedObjectGroup) obj)._DisplayName)) && (this.CompareArrays((Array) this._ModelingInstanceLocks, (Array) ((NamedObjectGroup) obj)._ModelingInstanceLocks) && object.Equals((object) this._FilterTags, (object) ((NamedObjectGroup) obj)._FilterTags) && (this.CompareArrays((Array) this._ResolvedEntries, (Array) ((NamedObjectGroup) obj)._ResolvedEntries) && object.Equals((object) this._AssociatedPackages, (object) ((NamedObjectGroup) obj)._AssociatedPackages))) && (this.CompareArrays((Array) this._Entries, (Array) ((NamedObjectGroup) obj)._Entries) && object.Equals((object) this._InstanceLocked, (object) ((NamedObjectGroup) obj)._InstanceLocked) && (this.CompareArrays((Array) this._DefaultForObjectTypes, (Array) ((NamedObjectGroup) obj)._DefaultForObjectTypes) && object.Equals((object) this._Name, (object) ((NamedObjectGroup) obj)._Name)) && (object.Equals((object) this._Description, (object) ((NamedObjectGroup) obj)._Description) && object.Equals((object) this._EntryType, (object) ((NamedObjectGroup) obj)._EntryType) && (object.Equals((object) this._Notes, (object) ((NamedObjectGroup) obj)._Notes) && object.Equals((object) this._IconId, (object) ((NamedObjectGroup) obj)._IconId)))) && (object.Equals((object) this._ChangeHistory, (object) ((NamedObjectGroup) obj)._ChangeHistory) && object.Equals((object) this._IsFrozen, (object) ((NamedObjectGroup) obj)._IsFrozen)) && base.Equals(obj);
    }

    public new NamedObjectRef[] Groups
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

    public new BaseObjectRef[] ResolvedEntries
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

    public NamedObjectRef[] Entries
    {
      [param: In] set
      {
        this.PropertySet(nameof (Entries), (object) value);
      }
      get
      {
        return (NamedObjectRef[]) this.PropertyGet(nameof (Entries));
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

    public new Primitive<int>[] DefaultForObjectTypes
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

    public new Primitive<string> EntryType
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
  }
}
