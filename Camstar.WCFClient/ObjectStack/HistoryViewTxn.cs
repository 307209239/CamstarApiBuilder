// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.HistoryViewTxn
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
  public class HistoryViewTxn : ShopFloor
  {
    [DataMember(EmitDefaultValue = false, Name = "HistoryViewTxn_HistoryObjectFields")]
    protected Primitive<string>[] _HistoryObjectFields;
    [DataMember(EmitDefaultValue = false, Name = "HistoryViewTxn_HistoryView")]
    protected NamedObjectRef _HistoryView;
    [DataMember(EmitDefaultValue = false, Name = "HistoryViewTxn_HistoryMainlineFields")]
    protected Primitive<string>[] _HistoryMainlineFields;
    [DataMember(EmitDefaultValue = false, Name = "HistoryViewTxn_HistoryObject")]
    protected Primitive<string> _HistoryObject;

    public override bool Equals(object obj)
    {
      return obj is HistoryViewTxn && this.CompareArrays((Array) this._HistoryObjectFields, (Array) ((HistoryViewTxn) obj)._HistoryObjectFields) && (object.Equals((object) this._HistoryView, (object) ((HistoryViewTxn) obj)._HistoryView) && this.CompareArrays((Array) this._HistoryMainlineFields, (Array) ((HistoryViewTxn) obj)._HistoryMainlineFields)) && object.Equals((object) this._HistoryObject, (object) ((HistoryViewTxn) obj)._HistoryObject) && base.Equals(obj);
    }

    public Primitive<string>[] HistoryObjectFields
    {
      [param: In] set
      {
        this.PropertySet(nameof (HistoryObjectFields), (object) value);
      }
      get
      {
        return (Primitive<string>[]) this.PropertyGet(nameof (HistoryObjectFields));
      }
    }

    public NamedObjectRef HistoryView
    {
      [param: In] set
      {
        this.PropertySet(nameof (HistoryView), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (HistoryView));
      }
    }

    public Primitive<string>[] HistoryMainlineFields
    {
      [param: In] set
      {
        this.PropertySet(nameof (HistoryMainlineFields), (object) value);
      }
      get
      {
        return (Primitive<string>[]) this.PropertyGet(nameof (HistoryMainlineFields));
      }
    }

    public Primitive<string> HistoryObject
    {
      [param: In] set
      {
        this.PropertySet(nameof (HistoryObject), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (HistoryObject));
      }
    }
  }
}
