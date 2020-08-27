// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.RevisionedObjectMaint
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
  public class RevisionedObjectMaint : Maintenance
  {
    [DataMember(EmitDefaultValue = false, Name = "RevisionedObjectMaint_ObjectChanges")]
    protected RevisionedObjectChanges _ObjectChanges;
    [DataMember(EmitDefaultValue = false, Name = "RevisionedObjectMaint_ObjectToChange")]
    protected RevisionedObjectRef _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "RevisionedObjectMaint_BaseToChange")]
    protected RevisionedObjectRef _BaseToChange;
    [DataMember(EmitDefaultValue = false, Name = "RevisionedObjectMaint_ObjectListInquiry")]
    protected RevisionedObjectRef[] _ObjectListInquiry;
    [DataMember(EmitDefaultValue = false, Name = "RevisionedObjectMaint_SyncRevision")]
    protected Primitive<string> _SyncRevision;

    public override bool Equals(object obj)
    {
      return obj is RevisionedObjectMaint && object.Equals((object) this._ObjectChanges, (object) ((RevisionedObjectMaint) obj)._ObjectChanges) && (object.Equals((object) this._ObjectToChange, (object) ((RevisionedObjectMaint) obj)._ObjectToChange) && object.Equals((object) this._BaseToChange, (object) ((RevisionedObjectMaint) obj)._BaseToChange)) && (this.CompareArrays((Array) this._ObjectListInquiry, (Array) ((RevisionedObjectMaint) obj)._ObjectListInquiry) && object.Equals((object) this._SyncRevision, (object) ((RevisionedObjectMaint) obj)._SyncRevision)) && base.Equals(obj);
    }

    public RevisionedObjectChanges ObjectChanges
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectChanges), (object) value);
      }
      get
      {
        return (RevisionedObjectChanges) this.PropertyGet(nameof (ObjectChanges));
      }
    }

    public RevisionedObjectRef ObjectToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectToChange), (object) value);
      }
      get
      {
        return (RevisionedObjectRef) this.PropertyGet(nameof (ObjectToChange));
      }
    }

    public RevisionedObjectRef BaseToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (BaseToChange), (object) value);
      }
      get
      {
        return (RevisionedObjectRef) this.PropertyGet(nameof (BaseToChange));
      }
    }

    public RevisionedObjectRef[] ObjectListInquiry
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectListInquiry), (object) value);
      }
      get
      {
        return (RevisionedObjectRef[]) this.PropertyGet(nameof (ObjectListInquiry));
      }
    }

    public Primitive<string> SyncRevision
    {
      [param: In] set
      {
        this.PropertySet(nameof (SyncRevision), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (SyncRevision));
      }
    }
  }
}
