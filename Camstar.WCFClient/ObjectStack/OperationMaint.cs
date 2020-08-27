// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.OperationMaint
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
  public class OperationMaint : NamedDataObjectMaint
  {
    [DataMember(EmitDefaultValue = false, Name = "OperationMaint_ObjectChanges")]
    protected OperationChanges _ObjectChanges;
    [DataMember(EmitDefaultValue = false, Name = "OperationMaint_AllTxns")]
    protected Primitive<int>[] _AllTxns;
    [DataMember(EmitDefaultValue = false, Name = "OperationMaint_ObjectListInquiry")]
    protected new NamedObjectRef[] _ObjectListInquiry;
    [DataMember(EmitDefaultValue = false, Name = "OperationMaint_ObjectToChange")]
    protected new NamedObjectRef _ObjectToChange;

    public override bool Equals(object obj)
    {
      return obj is OperationMaint && object.Equals((object) this._ObjectChanges, (object) ((OperationMaint) obj)._ObjectChanges) && (this.CompareArrays((Array) this._AllTxns, (Array) ((OperationMaint) obj)._AllTxns) && this.CompareArrays((Array) this._ObjectListInquiry, (Array) ((OperationMaint) obj)._ObjectListInquiry)) && object.Equals((object) this._ObjectToChange, (object) ((OperationMaint) obj)._ObjectToChange) && base.Equals(obj);
    }

    public OperationChanges ObjectChanges
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectChanges), (object) value);
      }
      get
      {
        return (OperationChanges) this.PropertyGet(nameof (ObjectChanges));
      }
    }

    public Primitive<int>[] AllTxns
    {
      [param: In] set
      {
        this.PropertySet(nameof (AllTxns), (object) value);
      }
      get
      {
        return (Primitive<int>[]) this.PropertyGet(nameof (AllTxns));
      }
    }

    public new NamedObjectRef[] ObjectListInquiry
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
  }
}
