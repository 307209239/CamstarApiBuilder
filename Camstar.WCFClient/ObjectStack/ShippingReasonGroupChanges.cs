﻿// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ShippingReasonGroupChanges
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
  public class ShippingReasonGroupChanges : UserCodeGroupChanges
  {
    [DataMember(EmitDefaultValue = false, Name = "ShippingReasonGroupChanges_NewGroup")]
    protected new NamedObjectRef _NewGroup;
    [DataMember(EmitDefaultValue = false, Name = "ShippingReasonGroupChanges_ObjectToChange")]
    protected new NamedObjectRef _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "ShippingReasonGroupChanges_NewEntry")]
    protected new NamedObjectRef _NewEntry;
    [DataMember(EmitDefaultValue = false, Name = "ShippingReasonGroupChanges_ResolvedEntries")]
    protected new NamedObjectRef[] _ResolvedEntries;
    [DataMember(EmitDefaultValue = false, Name = "ShippingReasonGroupChanges_Groups")]
    protected new NamedObjectRef[] _Groups;
    [DataMember(EmitDefaultValue = false, Name = "ShippingReasonGroupChanges_Entries")]
    protected new NamedObjectRef[] _Entries;
    [DataMember(EmitDefaultValue = false, Name = "ShippingReasonGroupChanges_EntryType")]
    protected new Primitive<string> _EntryType;
    [DataMember(EmitDefaultValue = false, Name = "ShippingReasonGroupChanges_Name")]
    protected new Primitive<string> _Name;

    public override bool Equals(object obj)
    {
      return obj is ShippingReasonGroupChanges && object.Equals((object) this._NewGroup, (object) ((ShippingReasonGroupChanges) obj)._NewGroup) && (object.Equals((object) this._ObjectToChange, (object) ((ShippingReasonGroupChanges) obj)._ObjectToChange) && object.Equals((object) this._NewEntry, (object) ((ShippingReasonGroupChanges) obj)._NewEntry)) && (this.CompareArrays((Array) this._ResolvedEntries, (Array) ((ShippingReasonGroupChanges) obj)._ResolvedEntries) && this.CompareArrays((Array) this._Groups, (Array) ((ShippingReasonGroupChanges) obj)._Groups) && (this.CompareArrays((Array) this._Entries, (Array) ((ShippingReasonGroupChanges) obj)._Entries) && object.Equals((object) this._EntryType, (object) ((ShippingReasonGroupChanges) obj)._EntryType))) && object.Equals((object) this._Name, (object) ((ShippingReasonGroupChanges) obj)._Name) && base.Equals(obj);
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
