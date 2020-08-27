// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.CombineFromDetail
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
  public class CombineFromDetail : ServiceDetails
  {
    [DataMember(EmitDefaultValue = false, Name = "CombineFromDetail_Qty2")]
    protected Primitive<double> _Qty2;
    [DataMember(EmitDefaultValue = false, Name = "CombineFromDetail_CloseWhenEmpty")]
    protected Primitive<bool> _CloseWhenEmpty;
    [DataMember(EmitDefaultValue = false, Name = "CombineFromDetail_CombineAllQty")]
    protected Primitive<bool> _CombineAllQty;
    [DataMember(EmitDefaultValue = false, Name = "CombineFromDetail_ChildContainers")]
    protected ContainerRef[] _ChildContainers;
    [DataMember(EmitDefaultValue = false, Name = "CombineFromDetail_FromContainer")]
    protected ContainerRef _FromContainer;
    [DataMember(EmitDefaultValue = false, Name = "CombineFromDetail_UOMName")]
    protected Primitive<string> _UOMName;
    [DataMember(EmitDefaultValue = false, Name = "CombineFromDetail_Qty")]
    protected Primitive<double> _Qty;

    public override bool Equals(object obj)
    {
      return obj is CombineFromDetail && object.Equals((object) this._Qty2, (object) ((CombineFromDetail) obj)._Qty2) && (object.Equals((object) this._CloseWhenEmpty, (object) ((CombineFromDetail) obj)._CloseWhenEmpty) && object.Equals((object) this._CombineAllQty, (object) ((CombineFromDetail) obj)._CombineAllQty)) && (this.CompareArrays((Array) this._ChildContainers, (Array) ((CombineFromDetail) obj)._ChildContainers) && object.Equals((object) this._FromContainer, (object) ((CombineFromDetail) obj)._FromContainer) && (object.Equals((object) this._UOMName, (object) ((CombineFromDetail) obj)._UOMName) && object.Equals((object) this._Qty, (object) ((CombineFromDetail) obj)._Qty))) && base.Equals(obj);
    }

    public Primitive<double> Qty2
    {
      [param: In] set
      {
        this.PropertySet(nameof (Qty2), (object) value);
      }
      get
      {
        return (Primitive<double>) this.PropertyGet(nameof (Qty2));
      }
    }

    public Primitive<bool> CloseWhenEmpty
    {
      [param: In] set
      {
        this.PropertySet(nameof (CloseWhenEmpty), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (CloseWhenEmpty));
      }
    }

    public Primitive<bool> CombineAllQty
    {
      [param: In] set
      {
        this.PropertySet(nameof (CombineAllQty), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (CombineAllQty));
      }
    }

    public ContainerRef[] ChildContainers
    {
      [param: In] set
      {
        this.PropertySet(nameof (ChildContainers), (object) value);
      }
      get
      {
        return (ContainerRef[]) this.PropertyGet(nameof (ChildContainers));
      }
    }

    public ContainerRef FromContainer
    {
      [param: In] set
      {
        this.PropertySet(nameof (FromContainer), (object) value);
      }
      get
      {
        return (ContainerRef) this.PropertyGet(nameof (FromContainer));
      }
    }

    public Primitive<string> UOMName
    {
      [param: In] set
      {
        this.PropertySet(nameof (UOMName), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (UOMName));
      }
    }

    public Primitive<double> Qty
    {
      [param: In] set
      {
        this.PropertySet(nameof (Qty), (object) value);
      }
      get
      {
        return (Primitive<double>) this.PropertyGet(nameof (Qty));
      }
    }
  }
}
