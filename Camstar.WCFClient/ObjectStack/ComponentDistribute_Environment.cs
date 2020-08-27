// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ComponentDistribute_Environment
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
  public class ComponentDistribute_Environment : ContainerTxn_Environment
  {
    [Metadata("Material quantity (individual)", "", false, false, false, "Fixed", 1049693, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ComponentDistribute_Environment_Qty2Left")]
    protected Environment _Qty2Left;
    [Metadata("Material quantity (individual)", "", false, false, false, "Fixed", 1049692, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ComponentDistribute_Environment_ActualQty2Issued")]
    protected Environment _ActualQty2Issued;
    [DataMember(EmitDefaultValue = false, Name = "ComponentDistribute_Environment_ServiceDetails")]
    [Metadata("The destination of ComponentDistribute transaction", "ComponentDistributeDestination", false, false, false, "ComponentDistributeDestination", 1049843, false, true, false, null)]
    protected ComponentDistributeDestination_Environment _ServiceDetails;
    [Metadata("Generic Integer", "", false, false, false, "Integer", 1049463, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ComponentDistribute_Environment_IssueControl")]
    protected Environment _IssueControl;
    [DataMember(EmitDefaultValue = false, Name = "ComponentDistribute_Environment_AllowZeroQtys")]
    [Metadata("Generic Boolean", "", false, false, true, "Boolean", 1051471, false, false, false, "1")]
    protected Environment _AllowZeroQtys;
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1049449, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "ComponentDistribute_Environment_BillControl")]
    protected Environment _BillControl;
    [DataMember(EmitDefaultValue = false, Name = "ComponentDistribute_Environment_QtyLeft")]
    [Metadata("Material quantity (individual)", "", false, false, false, "Fixed", 1049694, false, false, false, null)]
    protected Environment _QtyLeft;
    [Metadata("Material quantity (individual)", "", false, false, false, "Fixed", 1049691, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ComponentDistribute_Environment_ActualQtyIssued")]
    protected Environment _ActualQtyIssued;

    public Environment Qty2Left
    {
      [param: In] set
      {
        this.PropertySet(nameof (Qty2Left), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Qty2Left));
      }
    }

    public Environment ActualQty2Issued
    {
      [param: In] set
      {
        this.PropertySet(nameof (ActualQty2Issued), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ActualQty2Issued));
      }
    }

    public ComponentDistributeDestination_Environment ServiceDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (ServiceDetails), (object) value);
      }
      get
      {
        return (ComponentDistributeDestination_Environment) this.PropertyGet(nameof (ServiceDetails));
      }
    }

    public Environment IssueControl
    {
      [param: In] set
      {
        this.PropertySet(nameof (IssueControl), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (IssueControl));
      }
    }

    public Environment AllowZeroQtys
    {
      [param: In] set
      {
        this.PropertySet(nameof (AllowZeroQtys), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (AllowZeroQtys));
      }
    }

    public Environment BillControl
    {
      [param: In] set
      {
        this.PropertySet(nameof (BillControl), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (BillControl));
      }
    }

    public Environment QtyLeft
    {
      [param: In] set
      {
        this.PropertySet(nameof (QtyLeft), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (QtyLeft));
      }
    }

    public Environment ActualQtyIssued
    {
      [param: In] set
      {
        this.PropertySet(nameof (ActualQtyIssued), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ActualQtyIssued));
      }
    }
  }
}
