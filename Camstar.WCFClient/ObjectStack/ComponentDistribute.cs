// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ComponentDistribute
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
  public class ComponentDistribute : ContainerTxn
  {
    [DataMember(EmitDefaultValue = false, Name = "ComponentDistribute_Qty2Left")]
    protected Primitive<double> _Qty2Left;
    [DataMember(EmitDefaultValue = false, Name = "ComponentDistribute_ActualQty2Issued")]
    protected Primitive<double> _ActualQty2Issued;
    [DataMember(EmitDefaultValue = false, Name = "ComponentDistribute_ServiceDetails")]
    protected ComponentDistributeDestination[] _ServiceDetails;
    [DataMember(EmitDefaultValue = false, Name = "ComponentDistribute_IssueControl")]
    protected Primitive<int> _IssueControl;
    [DataMember(EmitDefaultValue = false, Name = "ComponentDistribute_AllowZeroQtys")]
    protected Primitive<bool> _AllowZeroQtys;
    [DataMember(EmitDefaultValue = false, Name = "ComponentDistribute_BillControl")]
    protected Primitive<bool> _BillControl;
    [DataMember(EmitDefaultValue = false, Name = "ComponentDistribute_QtyLeft")]
    protected Primitive<double> _QtyLeft;
    [DataMember(EmitDefaultValue = false, Name = "ComponentDistribute_ActualQtyIssued")]
    protected Primitive<double> _ActualQtyIssued;

    public override bool Equals(object obj)
    {
      return obj is ComponentDistribute && object.Equals((object) this._Qty2Left, (object) ((ComponentDistribute) obj)._Qty2Left) && (object.Equals((object) this._ActualQty2Issued, (object) ((ComponentDistribute) obj)._ActualQty2Issued) && this.CompareArrays((Array) this._ServiceDetails, (Array) ((ComponentDistribute) obj)._ServiceDetails)) && (object.Equals((object) this._IssueControl, (object) ((ComponentDistribute) obj)._IssueControl) && object.Equals((object) this._AllowZeroQtys, (object) ((ComponentDistribute) obj)._AllowZeroQtys) && (object.Equals((object) this._BillControl, (object) ((ComponentDistribute) obj)._BillControl) && object.Equals((object) this._QtyLeft, (object) ((ComponentDistribute) obj)._QtyLeft))) && object.Equals((object) this._ActualQtyIssued, (object) ((ComponentDistribute) obj)._ActualQtyIssued) && base.Equals(obj);
    }

    public Primitive<double> Qty2Left
    {
      [param: In] set
      {
        this.PropertySet(nameof (Qty2Left), (object) value);
      }
      get
      {
        return (Primitive<double>) this.PropertyGet(nameof (Qty2Left));
      }
    }

    public Primitive<double> ActualQty2Issued
    {
      [param: In] set
      {
        this.PropertySet(nameof (ActualQty2Issued), (object) value);
      }
      get
      {
        return (Primitive<double>) this.PropertyGet(nameof (ActualQty2Issued));
      }
    }

    public ComponentDistributeDestination[] ServiceDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (ServiceDetails), (object) value);
      }
      get
      {
        return (ComponentDistributeDestination[]) this.PropertyGet(nameof (ServiceDetails));
      }
    }

    public Primitive<int> IssueControl
    {
      [param: In] set
      {
        this.PropertySet(nameof (IssueControl), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (IssueControl));
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

    public Primitive<bool> BillControl
    {
      [param: In] set
      {
        this.PropertySet(nameof (BillControl), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (BillControl));
      }
    }

    public Primitive<double> QtyLeft
    {
      [param: In] set
      {
        this.PropertySet(nameof (QtyLeft), (object) value);
      }
      get
      {
        return (Primitive<double>) this.PropertyGet(nameof (QtyLeft));
      }
    }

    public Primitive<double> ActualQtyIssued
    {
      [param: In] set
      {
        this.PropertySet(nameof (ActualQtyIssued), (object) value);
      }
      get
      {
        return (Primitive<double>) this.PropertyGet(nameof (ActualQtyIssued));
      }
    }
  }
}
