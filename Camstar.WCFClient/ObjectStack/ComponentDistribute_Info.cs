// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ComponentDistribute_Info
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
  public class ComponentDistribute_Info : ContainerTxn_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "ComponentDistribute_Info_Qty2Left")]
    protected Info _Qty2Left;
    [DataMember(EmitDefaultValue = false, Name = "ComponentDistribute_Info_ActualQty2Issued")]
    protected Info _ActualQty2Issued;
    [DataMember(EmitDefaultValue = false, Name = "ComponentDistribute_Info_ServiceDetails")]
    protected ComponentDistributeDestination_Info _ServiceDetails;
    [DataMember(EmitDefaultValue = false, Name = "ComponentDistribute_Info_IssueControl")]
    protected Info _IssueControl;
    [DataMember(EmitDefaultValue = false, Name = "ComponentDistribute_Info_AllowZeroQtys")]
    protected Info _AllowZeroQtys;
    [DataMember(EmitDefaultValue = false, Name = "ComponentDistribute_Info_BillControl")]
    protected Info _BillControl;
    [DataMember(EmitDefaultValue = false, Name = "ComponentDistribute_Info_QtyLeft")]
    protected Info _QtyLeft;
    [DataMember(EmitDefaultValue = false, Name = "ComponentDistribute_Info_ActualQtyIssued")]
    protected Info _ActualQtyIssued;

    public Info Qty2Left
    {
      [param: In] set
      {
        this.PropertySet(nameof (Qty2Left), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Qty2Left));
      }
    }

    public Info ActualQty2Issued
    {
      [param: In] set
      {
        this.PropertySet(nameof (ActualQty2Issued), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ActualQty2Issued));
      }
    }

    public ComponentDistributeDestination_Info ServiceDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (ServiceDetails), (object) value);
      }
      get
      {
        return (ComponentDistributeDestination_Info) this.PropertyGet(nameof (ServiceDetails));
      }
    }

    public Info IssueControl
    {
      [param: In] set
      {
        this.PropertySet(nameof (IssueControl), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (IssueControl));
      }
    }

    public Info AllowZeroQtys
    {
      [param: In] set
      {
        this.PropertySet(nameof (AllowZeroQtys), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (AllowZeroQtys));
      }
    }

    public Info BillControl
    {
      [param: In] set
      {
        this.PropertySet(nameof (BillControl), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (BillControl));
      }
    }

    public Info QtyLeft
    {
      [param: In] set
      {
        this.PropertySet(nameof (QtyLeft), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (QtyLeft));
      }
    }

    public Info ActualQtyIssued
    {
      [param: In] set
      {
        this.PropertySet(nameof (ActualQtyIssued), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ActualQtyIssued));
      }
    }
  }
}
