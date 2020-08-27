// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ObjectGroupChanges
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
  public class ObjectGroupChanges : NamedDataObjectChanges
  {
    [DataMember(EmitDefaultValue = false, Name = "ObjectGroupChanges_DefaultForObjectTypes")]
    protected Primitive<int>[] _DefaultForObjectTypes;
    [DataMember(EmitDefaultValue = false, Name = "ObjectGroupChanges_NewEntry")]
    protected BaseObjectRef _NewEntry;
    [DataMember(EmitDefaultValue = false, Name = "ObjectGroupChanges_ResolvedEntries")]
    protected BaseObjectRef[] _ResolvedEntries;
    [DataMember(EmitDefaultValue = false, Name = "ObjectGroupChanges_Entries")]
    protected BaseObjectRef[] _Entries;
    [DataMember(EmitDefaultValue = false, Name = "ObjectGroupChanges_ObjectToChange")]
    protected new NamedObjectRef _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "ObjectGroupChanges_NewGroup")]
    protected NamedObjectRef _NewGroup;
    [DataMember(EmitDefaultValue = false, Name = "ObjectGroupChanges_EntryType")]
    protected Primitive<string> _EntryType;
    [DataMember(EmitDefaultValue = false, Name = "ObjectGroupChanges_Groups")]
    protected NamedObjectRef[] _Groups;
    [DataMember(EmitDefaultValue = false, Name = "ObjectGroupChanges_Name")]
    protected new Primitive<string> _Name;

    public override bool Equals(object obj)
    {
      return obj is ObjectGroupChanges && this.CompareArrays((Array) this._DefaultForObjectTypes, (Array) ((ObjectGroupChanges) obj)._DefaultForObjectTypes) && (object.Equals((object) this._NewEntry, (object) ((ObjectGroupChanges) obj)._NewEntry) && this.CompareArrays((Array) this._ResolvedEntries, (Array) ((ObjectGroupChanges) obj)._ResolvedEntries)) && (this.CompareArrays((Array) this._Entries, (Array) ((ObjectGroupChanges) obj)._Entries) && object.Equals((object) this._ObjectToChange, (object) ((ObjectGroupChanges) obj)._ObjectToChange) && (object.Equals((object) this._NewGroup, (object) ((ObjectGroupChanges) obj)._NewGroup) && object.Equals((object) this._EntryType, (object) ((ObjectGroupChanges) obj)._EntryType))) && (this.CompareArrays((Array) this._Groups, (Array) ((ObjectGroupChanges) obj)._Groups) && object.Equals((object) this._Name, (object) ((ObjectGroupChanges) obj)._Name)) && base.Equals(obj);
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

    public BaseObjectRef NewEntry
    {
      [param: In] set
      {
        this.PropertySet(nameof (NewEntry), (object) value);
      }
      get
      {
        return (BaseObjectRef) this.PropertyGet(nameof (NewEntry));
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

    public NamedObjectRef NewGroup
    {
      [param: In] set
      {
        this.PropertySet(nameof (NewGroup), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (NewGroup));
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
