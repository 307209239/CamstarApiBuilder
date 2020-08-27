// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ResStatusReasonGroupChanges
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
  public class ResStatusReasonGroupChanges : UserCodeGroupChanges
  {
    [DataMember(EmitDefaultValue = false, Name = "ResStatusReasonGroupChanges_ObjectToChange")]
    protected new NamedObjectRef _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "ResStatusReasonGroupChanges_NewGroup")]
    protected new NamedObjectRef _NewGroup;
    [DataMember(EmitDefaultValue = false, Name = "ResStatusReasonGroupChanges_Groups")]
    protected new NamedObjectRef[] _Groups;
    [DataMember(EmitDefaultValue = false, Name = "ResStatusReasonGroupChanges_EntryType")]
    protected new Primitive<string> _EntryType;
    [DataMember(EmitDefaultValue = false, Name = "ResStatusReasonGroupChanges_ResolvedEntries")]
    protected new NamedObjectRef[] _ResolvedEntries;
    [DataMember(EmitDefaultValue = false, Name = "ResStatusReasonGroupChanges_Name")]
    protected new Primitive<string> _Name;
    [DataMember(EmitDefaultValue = false, Name = "ResStatusReasonGroupChanges_Entries")]
    protected new NamedObjectRef[] _Entries;
    [DataMember(EmitDefaultValue = false, Name = "ResStatusReasonGroupChanges_NewEntry")]
    protected new NamedObjectRef _NewEntry;

    public override bool Equals(object obj)
    {
      return obj is ResStatusReasonGroupChanges && object.Equals((object) this._ObjectToChange, (object) ((ResStatusReasonGroupChanges) obj)._ObjectToChange) && (object.Equals((object) this._NewGroup, (object) ((ResStatusReasonGroupChanges) obj)._NewGroup) && this.CompareArrays((Array) this._Groups, (Array) ((ResStatusReasonGroupChanges) obj)._Groups)) && (object.Equals((object) this._EntryType, (object) ((ResStatusReasonGroupChanges) obj)._EntryType) && this.CompareArrays((Array) this._ResolvedEntries, (Array) ((ResStatusReasonGroupChanges) obj)._ResolvedEntries) && (object.Equals((object) this._Name, (object) ((ResStatusReasonGroupChanges) obj)._Name) && this.CompareArrays((Array) this._Entries, (Array) ((ResStatusReasonGroupChanges) obj)._Entries))) && object.Equals((object) this._NewEntry, (object) ((ResStatusReasonGroupChanges) obj)._NewEntry) && base.Equals(obj);
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
  }
}
