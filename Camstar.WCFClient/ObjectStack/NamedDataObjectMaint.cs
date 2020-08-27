// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.NamedDataObjectMaint
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
  public class NamedDataObjectMaint : Maintenance
  {
    [DataMember(EmitDefaultValue = false, Name = "NamedDataObjectMaint_ObjectChanges")]
    protected NamedDataObjectChanges _ObjectChanges;
    [DataMember(EmitDefaultValue = false, Name = "NamedDataObjectMaint_ObjectListInquiry")]
    protected NamedObjectRef[] _ObjectListInquiry;
    [DataMember(EmitDefaultValue = false, Name = "NamedDataObjectMaint_SyncName")]
    protected new Primitive<string> _SyncName;
    [DataMember(EmitDefaultValue = false, Name = "NamedDataObjectMaint_ObjectToChange")]
    protected NamedObjectRef _ObjectToChange;

    public override bool Equals(object obj)
    {
      return obj is NamedDataObjectMaint && object.Equals((object) this._ObjectChanges, (object) ((NamedDataObjectMaint) obj)._ObjectChanges) && (this.CompareArrays((Array) this._ObjectListInquiry, (Array) ((NamedDataObjectMaint) obj)._ObjectListInquiry) && object.Equals((object) this._SyncName, (object) ((NamedDataObjectMaint) obj)._SyncName)) && object.Equals((object) this._ObjectToChange, (object) ((NamedDataObjectMaint) obj)._ObjectToChange) && base.Equals(obj);
    }

    public NamedDataObjectChanges ObjectChanges
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectChanges), (object) value);
      }
      get
      {
        return (NamedDataObjectChanges) this.PropertyGet(nameof (ObjectChanges));
      }
    }

    public NamedObjectRef[] ObjectListInquiry
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectListInquiry), (object) value);
      }
      get
      {
        return (NamedObjectRef[]) this.PropertyGet(nameof (ObjectListInquiry));
      }
    }

    public new Primitive<string> SyncName
    {
      [param: In] set
      {
        this.PropertySet(nameof (SyncName), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (SyncName));
      }
    }

    public NamedObjectRef ObjectToChange
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
  }
}
