// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.NamedObjectGroupChanges
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
  public class NamedObjectGroupChanges : ObjectGroupChanges
  {
    [DataMember(EmitDefaultValue = false, Name = "NamedObjectGroupChanges_NewGroup")]
    protected new NamedObjectRef _NewGroup;
    [DataMember(EmitDefaultValue = false, Name = "NamedObjectGroupChanges_ObjectToChange")]
    protected new NamedObjectRef _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "NamedObjectGroupChanges_Groups")]
    protected new NamedObjectRef[] _Groups;
    [DataMember(EmitDefaultValue = false, Name = "NamedObjectGroupChanges_ResolvedEntries")]
    protected new BaseObjectRef[] _ResolvedEntries;
    [DataMember(EmitDefaultValue = false, Name = "NamedObjectGroupChanges_Entries")]
    protected NamedObjectRef[] _Entries;
    [DataMember(EmitDefaultValue = false, Name = "NamedObjectGroupChanges_NewEntry")]
    protected NamedObjectRef _NewEntry;
    [DataMember(EmitDefaultValue = false, Name = "NamedObjectGroupChanges_Name")]
    protected new Primitive<string> _Name;
    [DataMember(EmitDefaultValue = false, Name = "NamedObjectGroupChanges_EntryType")]
    protected new Primitive<string> _EntryType;

    public override bool Equals(object obj)
    {
      return obj is NamedObjectGroupChanges && object.Equals((object) this._NewGroup, (object) ((NamedObjectGroupChanges) obj)._NewGroup) && (object.Equals((object) this._ObjectToChange, (object) ((NamedObjectGroupChanges) obj)._ObjectToChange) && this.CompareArrays((Array) this._Groups, (Array) ((NamedObjectGroupChanges) obj)._Groups)) && (this.CompareArrays((Array) this._ResolvedEntries, (Array) ((NamedObjectGroupChanges) obj)._ResolvedEntries) && this.CompareArrays((Array) this._Entries, (Array) ((NamedObjectGroupChanges) obj)._Entries) && (object.Equals((object) this._NewEntry, (object) ((NamedObjectGroupChanges) obj)._NewEntry) && object.Equals((object) this._Name, (object) ((NamedObjectGroupChanges) obj)._Name))) && object.Equals((object) this._EntryType, (object) ((NamedObjectGroupChanges) obj)._EntryType) && base.Equals(obj);
    }

    public new NamedObjectRef NewGroup
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

    public NamedObjectRef NewEntry
    {
      [param: In] set
      {
        this.PropertySet(nameof (NewEntry), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (NewEntry));
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
  }
}
