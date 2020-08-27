// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ResStatusCodeGroupChanges
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
  public class ResStatusCodeGroupChanges : UserCodeGroupChanges
  {
    [DataMember(EmitDefaultValue = false, Name = "ResStatusCodeGroupChanges_Groups")]
    protected new NamedObjectRef[] _Groups;
    [DataMember(EmitDefaultValue = false, Name = "ResStatusCodeGroupChanges_NewGroup")]
    protected new NamedObjectRef _NewGroup;
    [DataMember(EmitDefaultValue = false, Name = "ResStatusCodeGroupChanges_ObjectToChange")]
    protected new NamedObjectRef _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "ResStatusCodeGroupChanges_Name")]
    protected new Primitive<string> _Name;
    [DataMember(EmitDefaultValue = false, Name = "ResStatusCodeGroupChanges_EntryType")]
    protected new Primitive<string> _EntryType;
    [DataMember(EmitDefaultValue = false, Name = "ResStatusCodeGroupChanges_Entries")]
    protected new NamedObjectRef[] _Entries;
    [DataMember(EmitDefaultValue = false, Name = "ResStatusCodeGroupChanges_NewEntry")]
    protected new NamedObjectRef _NewEntry;
    [DataMember(EmitDefaultValue = false, Name = "ResStatusCodeGroupChanges_ResolvedEntries")]
    protected new NamedObjectRef[] _ResolvedEntries;

    public override bool Equals(object obj)
    {
      return obj is ResStatusCodeGroupChanges && this.CompareArrays((Array) this._Groups, (Array) ((ResStatusCodeGroupChanges) obj)._Groups) && (object.Equals((object) this._NewGroup, (object) ((ResStatusCodeGroupChanges) obj)._NewGroup) && object.Equals((object) this._ObjectToChange, (object) ((ResStatusCodeGroupChanges) obj)._ObjectToChange)) && (object.Equals((object) this._Name, (object) ((ResStatusCodeGroupChanges) obj)._Name) && object.Equals((object) this._EntryType, (object) ((ResStatusCodeGroupChanges) obj)._EntryType) && (this.CompareArrays((Array) this._Entries, (Array) ((ResStatusCodeGroupChanges) obj)._Entries) && object.Equals((object) this._NewEntry, (object) ((ResStatusCodeGroupChanges) obj)._NewEntry))) && this.CompareArrays((Array) this._ResolvedEntries, (Array) ((ResStatusCodeGroupChanges) obj)._ResolvedEntries) && base.Equals(obj);
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

    public new NamedObjectRef[] Entries
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

    public new NamedObjectRef NewEntry
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

    public new NamedObjectRef[] ResolvedEntries
    {
      [param: In] set
      {
        this.PropertySet(nameof (ResolvedEntries), (object) value);
      }
      get
      {
        return (NamedObjectRef[]) this.PropertyGet(nameof (ResolvedEntries));
      }
    }
  }
}
