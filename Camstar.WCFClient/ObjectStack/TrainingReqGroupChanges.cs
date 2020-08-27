// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.TrainingReqGroupChanges
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
  public class TrainingReqGroupChanges : RevisionedObjectGroupChanges
  {
    [DataMember(EmitDefaultValue = false, Name = "TrainingReqGroupChanges_Entries")]
    protected new RevisionedObjectRef[] _Entries;
    [DataMember(EmitDefaultValue = false, Name = "TrainingReqGroupChanges_ObjectToChange")]
    protected new NamedObjectRef _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "TrainingReqGroupChanges_ResolvedEntries")]
    protected new RevisionedObjectRef[] _ResolvedEntries;
    [DataMember(EmitDefaultValue = false, Name = "TrainingReqGroupChanges_Groups")]
    protected new NamedObjectRef[] _Groups;
    [DataMember(EmitDefaultValue = false, Name = "TrainingReqGroupChanges_EntryType")]
    protected new Primitive<string> _EntryType;
    [DataMember(EmitDefaultValue = false, Name = "TrainingReqGroupChanges_Name")]
    protected new Primitive<string> _Name;

    public override bool Equals(object obj)
    {
      return obj is TrainingReqGroupChanges && this.CompareArrays((Array) this._Entries, (Array) ((TrainingReqGroupChanges) obj)._Entries) && (object.Equals((object) this._ObjectToChange, (object) ((TrainingReqGroupChanges) obj)._ObjectToChange) && this.CompareArrays((Array) this._ResolvedEntries, (Array) ((TrainingReqGroupChanges) obj)._ResolvedEntries)) && (this.CompareArrays((Array) this._Groups, (Array) ((TrainingReqGroupChanges) obj)._Groups) && object.Equals((object) this._EntryType, (object) ((TrainingReqGroupChanges) obj)._EntryType) && object.Equals((object) this._Name, (object) ((TrainingReqGroupChanges) obj)._Name)) && base.Equals(obj);
    }

    public new RevisionedObjectRef[] Entries
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

    public new RevisionedObjectRef[] ResolvedEntries
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
