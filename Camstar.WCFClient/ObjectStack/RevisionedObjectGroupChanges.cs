// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.RevisionedObjectGroupChanges
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
  public class RevisionedObjectGroupChanges : ObjectGroupChanges
  {
    [DataMember(EmitDefaultValue = false, Name = "RevisionedObjectGroupChanges_ObjectToChange")]
    protected new NamedObjectRef _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "RevisionedObjectGroupChanges_Groups")]
    protected new NamedObjectRef[] _Groups;
    [DataMember(EmitDefaultValue = false, Name = "RevisionedObjectGroupChanges_NewGroup")]
    protected new NamedObjectRef _NewGroup;
    [DataMember(EmitDefaultValue = false, Name = "RevisionedObjectGroupChanges_ResolvedEntries")]
    protected RevisionedObjectRef[] _ResolvedEntries;
    [DataMember(EmitDefaultValue = false, Name = "RevisionedObjectGroupChanges_NewEntry")]
    protected RevisionedObjectRef _NewEntry;
    [DataMember(EmitDefaultValue = false, Name = "RevisionedObjectGroupChanges_Entries")]
    protected RevisionedObjectRef[] _Entries;
    [DataMember(EmitDefaultValue = false, Name = "RevisionedObjectGroupChanges_Name")]
    protected new Primitive<string> _Name;
    [DataMember(EmitDefaultValue = false, Name = "RevisionedObjectGroupChanges_EntryType")]
    protected new Primitive<string> _EntryType;

    public override bool Equals(object obj)
    {
      return obj is RevisionedObjectGroupChanges && object.Equals((object) this._ObjectToChange, (object) ((RevisionedObjectGroupChanges) obj)._ObjectToChange) && (this.CompareArrays((Array) this._Groups, (Array) ((RevisionedObjectGroupChanges) obj)._Groups) && object.Equals((object) this._NewGroup, (object) ((RevisionedObjectGroupChanges) obj)._NewGroup)) && (this.CompareArrays((Array) this._ResolvedEntries, (Array) ((RevisionedObjectGroupChanges) obj)._ResolvedEntries) && object.Equals((object) this._NewEntry, (object) ((RevisionedObjectGroupChanges) obj)._NewEntry) && (this.CompareArrays((Array) this._Entries, (Array) ((RevisionedObjectGroupChanges) obj)._Entries) && object.Equals((object) this._Name, (object) ((RevisionedObjectGroupChanges) obj)._Name))) && object.Equals((object) this._EntryType, (object) ((RevisionedObjectGroupChanges) obj)._EntryType) && base.Equals(obj);
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

    public RevisionedObjectRef[] ResolvedEntries
    {
      [param: In] set
      {
        this.PropertySet(nameof (ResolvedEntries), (object) value);
      }
      get
      {
        return (RevisionedObjectRef[]) this.PropertyGet(nameof (ResolvedEntries));
      }
    }

    public RevisionedObjectRef NewEntry
    {
      [param: In] set
      {
        this.PropertySet(nameof (NewEntry), (object) value);
      }
      get
      {
        return (RevisionedObjectRef) this.PropertyGet(nameof (NewEntry));
      }
    }

    public RevisionedObjectRef[] Entries
    {
      [param: In] set
      {
        this.PropertySet(nameof (Entries), (object) value);
      }
      get
      {
        return (RevisionedObjectRef[]) this.PropertyGet(nameof (Entries));
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
