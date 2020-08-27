// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.HistoryViewChanges
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
  public class HistoryViewChanges : NamedDataObjectChanges
  {
    [DataMember(EmitDefaultValue = false, Name = "HistoryViewChanges_HistViewDtls")]
    protected HistViewDtlChanges[] _HistViewDtls;
    [DataMember(EmitDefaultValue = false, Name = "HistoryViewChanges_HistViewHistMainlineDtl")]
    protected HistViewHistMainlineDtlChanges _HistViewHistMainlineDtl;
    [DataMember(EmitDefaultValue = false, Name = "HistoryViewChanges_ObjectToChange")]
    protected new NamedObjectRef _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "HistoryViewChanges_LookupObject")]
    protected BaseObjectRef _LookupObject;
    [DataMember(EmitDefaultValue = false, Name = "HistoryViewChanges_HistoryObjects")]
    protected Primitive<string> _HistoryObjects;
    [DataMember(EmitDefaultValue = false, Name = "HistoryViewChanges_Name")]
    protected new Primitive<string> _Name;

    public override bool Equals(object obj)
    {
      return obj is HistoryViewChanges && this.CompareArrays((Array) this._HistViewDtls, (Array) ((HistoryViewChanges) obj)._HistViewDtls) && (object.Equals((object) this._HistViewHistMainlineDtl, (object) ((HistoryViewChanges) obj)._HistViewHistMainlineDtl) && object.Equals((object) this._ObjectToChange, (object) ((HistoryViewChanges) obj)._ObjectToChange)) && (object.Equals((object) this._LookupObject, (object) ((HistoryViewChanges) obj)._LookupObject) && object.Equals((object) this._HistoryObjects, (object) ((HistoryViewChanges) obj)._HistoryObjects) && object.Equals((object) this._Name, (object) ((HistoryViewChanges) obj)._Name)) && base.Equals(obj);
    }

    public HistViewDtlChanges[] HistViewDtls
    {
      [param: In] set
      {
        this.PropertySet(nameof (HistViewDtls), (object) value);
      }
      get
      {
        return (HistViewDtlChanges[]) this.PropertyGet(nameof (HistViewDtls));
      }
    }

    public HistViewHistMainlineDtlChanges HistViewHistMainlineDtl
    {
      [param: In] set
      {
        this.PropertySet(nameof (HistViewHistMainlineDtl), (object) value);
      }
      get
      {
        return (HistViewHistMainlineDtlChanges) this.PropertyGet(nameof (HistViewHistMainlineDtl));
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

    public BaseObjectRef LookupObject
    {
      [param: In] set
      {
        this.PropertySet(nameof (LookupObject), (object) value);
      }
      get
      {
        return (BaseObjectRef) this.PropertyGet(nameof (LookupObject));
      }
    }

    public Primitive<string> HistoryObjects
    {
      [param: In] set
      {
        this.PropertySet(nameof (HistoryObjects), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (HistoryObjects));
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
