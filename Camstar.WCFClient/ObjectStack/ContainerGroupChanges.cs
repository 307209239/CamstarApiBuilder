// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ContainerGroupChanges
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
  public class ContainerGroupChanges : ObjectGroupChanges
  {
    [DataMember(EmitDefaultValue = false, Name = "ContainerGroupChanges_ObjectToChange")]
    protected new NamedObjectRef _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "ContainerGroupChanges_NewGroup")]
    protected new NamedObjectRef _NewGroup;
    [DataMember(EmitDefaultValue = false, Name = "ContainerGroupChanges_Groups")]
    protected new NamedObjectRef[] _Groups;
    [DataMember(EmitDefaultValue = false, Name = "ContainerGroupChanges_NewEntry")]
    protected ContainerRef _NewEntry;
    [DataMember(EmitDefaultValue = false, Name = "ContainerGroupChanges_Entries")]
    protected ContainerRef[] _Entries;
    [DataMember(EmitDefaultValue = false, Name = "ContainerGroupChanges_ResolvedEntries")]
    protected ContainerRef[] _ResolvedEntries;
    [DataMember(EmitDefaultValue = false, Name = "ContainerGroupChanges_EntryType")]
    protected new Primitive<string> _EntryType;
    [DataMember(EmitDefaultValue = false, Name = "ContainerGroupChanges_Name")]
    protected new Primitive<string> _Name;

    public override bool Equals(object obj)
    {
      return obj is ContainerGroupChanges && object.Equals((object) this._ObjectToChange, (object) ((ContainerGroupChanges) obj)._ObjectToChange) && (object.Equals((object) this._NewGroup, (object) ((ContainerGroupChanges) obj)._NewGroup) && this.CompareArrays((Array) this._Groups, (Array) ((ContainerGroupChanges) obj)._Groups)) && (object.Equals((object) this._NewEntry, (object) ((ContainerGroupChanges) obj)._NewEntry) && this.CompareArrays((Array) this._Entries, (Array) ((ContainerGroupChanges) obj)._Entries) && (this.CompareArrays((Array) this._ResolvedEntries, (Array) ((ContainerGroupChanges) obj)._ResolvedEntries) && object.Equals((object) this._EntryType, (object) ((ContainerGroupChanges) obj)._EntryType))) && object.Equals((object) this._Name, (object) ((ContainerGroupChanges) obj)._Name) && base.Equals(obj);
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

    public ContainerRef NewEntry
    {
      [param: In] set
      {
        this.PropertySet(nameof (NewEntry), (object) value);
      }
      get
      {
        return (ContainerRef) this.PropertyGet(nameof (NewEntry));
      }
    }

    public ContainerRef[] Entries
    {
      [param: In] set
      {
        this.PropertySet(nameof (Entries), (object) value);
      }
      get
      {
        return (ContainerRef[]) this.PropertyGet(nameof (Entries));
      }
    }

    public ContainerRef[] ResolvedEntries
    {
      [param: In] set
      {
        this.PropertySet(nameof (ResolvedEntries), (object) value);
      }
      get
      {
        return (ContainerRef[]) this.PropertyGet(nameof (ResolvedEntries));
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
