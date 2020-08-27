// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.Combine
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
  public class Combine : ContainerTxn
  {
    [DataMember(EmitDefaultValue = false, Name = "Combine_FromContainerDetails")]
    protected CombineFromDetail[] _FromContainerDetails;
    [DataMember(EmitDefaultValue = false, Name = "Combine_EligibleContainersInquiry")]
    protected EligibleContainersInquiry _EligibleContainersInquiry;
    [DataMember(EmitDefaultValue = false, Name = "Combine_CloseWhenEmpty")]
    protected Primitive<bool> _CloseWhenEmpty;
    [DataMember(EmitDefaultValue = false, Name = "Combine_CombineType")]
    protected Primitive<int> _CombineType;
    [DataMember(EmitDefaultValue = false, Name = "Combine_AllowZeroQtys")]
    protected Primitive<bool> _AllowZeroQtys;
    [DataMember(EmitDefaultValue = false, Name = "Combine_Container")]
    protected new ContainerRef _Container;

    public override bool Equals(object obj)
    {
      return obj is Combine && this.CompareArrays((Array) this._FromContainerDetails, (Array) ((Combine) obj)._FromContainerDetails) && (object.Equals((object) this._EligibleContainersInquiry, (object) ((Combine) obj)._EligibleContainersInquiry) && object.Equals((object) this._CloseWhenEmpty, (object) ((Combine) obj)._CloseWhenEmpty)) && (object.Equals((object) this._CombineType, (object) ((Combine) obj)._CombineType) && object.Equals((object) this._AllowZeroQtys, (object) ((Combine) obj)._AllowZeroQtys) && object.Equals((object) this._Container, (object) ((Combine) obj)._Container)) && base.Equals(obj);
    }

    public CombineFromDetail[] FromContainerDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (FromContainerDetails), (object) value);
      }
      get
      {
        return (CombineFromDetail[]) this.PropertyGet(nameof (FromContainerDetails));
      }
    }

    public EligibleContainersInquiry EligibleContainersInquiry
    {
      [param: In] set
      {
        this.PropertySet(nameof (EligibleContainersInquiry), (object) value);
      }
      get
      {
        return (EligibleContainersInquiry) this.PropertyGet(nameof (EligibleContainersInquiry));
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

    public Primitive<int> CombineType
    {
      [param: In] set
      {
        this.PropertySet(nameof (CombineType), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (CombineType));
      }
    }

    public Primitive<bool> AllowZeroQtys
    {
      [param: In] set
      {
        this.PropertySet(nameof (AllowZeroQtys), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (AllowZeroQtys));
      }
    }

    public new ContainerRef Container
    {
      [param: In] set
      {
        this.PropertySet(nameof (Container), (object) value);
      }
      get
      {
        return (ContainerRef) this.PropertyGet(nameof (Container));
      }
    }
  }
}
