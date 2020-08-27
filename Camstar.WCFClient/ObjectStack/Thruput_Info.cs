// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.Thruput_Info
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
  public class Thruput_Info : ContainerTxn_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "Thruput_Info_UOM2")]
    protected Info _UOM2;
    [DataMember(EmitDefaultValue = false, Name = "Thruput_Info_Qty2")]
    protected Info _Qty2;
    [DataMember(EmitDefaultValue = false, Name = "Thruput_Info_ServiceDetails")]
    protected ThruputDetail_Info _ServiceDetails;
    [DataMember(EmitDefaultValue = false, Name = "Thruput_Info_SummaryThruput")]
    protected Info _SummaryThruput;
    [DataMember(EmitDefaultValue = false, Name = "Thruput_Info_ThruputAllQty")]
    protected Info _ThruputAllQty;
    [DataMember(EmitDefaultValue = false, Name = "Thruput_Info_UnitCount")]
    protected Info _UnitCount;
    [DataMember(EmitDefaultValue = false, Name = "Thruput_Info_ChildCount")]
    protected Info _ChildCount;
    [DataMember(EmitDefaultValue = false, Name = "Thruput_Info_Resource")]
    protected Info _Resource;
    [DataMember(EmitDefaultValue = false, Name = "Thruput_Info_Qty")]
    protected Info _Qty;
    [DataMember(EmitDefaultValue = false, Name = "Thruput_Info_ThruputReportingLevel")]
    protected Info _ThruputReportingLevel;
    [DataMember(EmitDefaultValue = false, Name = "Thruput_Info_QtyRemaining")]
    protected Info _QtyRemaining;
    [DataMember(EmitDefaultValue = false, Name = "Thruput_Info_ContainerLevel")]
    protected Info _ContainerLevel;
    [DataMember(EmitDefaultValue = false, Name = "Thruput_Info_Operation")]
    protected new Info _Operation;
    [DataMember(EmitDefaultValue = false, Name = "Thruput_Info_QtyProcessed")]
    protected Info _QtyProcessed;

    public Info UOM2
    {
      [param: In] set
      {
        this.PropertySet(nameof (UOM2), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (UOM2));
      }
    }

    public Info Qty2
    {
      [param: In] set
      {
        this.PropertySet(nameof (Qty2), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Qty2));
      }
    }

    public ThruputDetail_Info ServiceDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (ServiceDetails), (object) value);
      }
      get
      {
        return (ThruputDetail_Info) this.PropertyGet(nameof (ServiceDetails));
      }
    }

    public Info SummaryThruput
    {
      [param: In] set
      {
        this.PropertySet(nameof (SummaryThruput), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (SummaryThruput));
      }
    }

    public Info ThruputAllQty
    {
      [param: In] set
      {
        this.PropertySet(nameof (ThruputAllQty), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ThruputAllQty));
      }
    }

    public Info UnitCount
    {
      [param: In] set
      {
        this.PropertySet(nameof (UnitCount), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (UnitCount));
      }
    }

    public Info ChildCount
    {
      [param: In] set
      {
        this.PropertySet(nameof (ChildCount), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ChildCount));
      }
    }

    public Info Resource
    {
      [param: In] set
      {
        this.PropertySet(nameof (Resource), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Resource));
      }
    }

    public Info Qty
    {
      [param: In] set
      {
        this.PropertySet(nameof (Qty), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Qty));
      }
    }

    public Info ThruputReportingLevel
    {
      [param: In] set
      {
        this.PropertySet(nameof (ThruputReportingLevel), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ThruputReportingLevel));
      }
    }

    public Info QtyRemaining
    {
      [param: In] set
      {
        this.PropertySet(nameof (QtyRemaining), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (QtyRemaining));
      }
    }

    public Info ContainerLevel
    {
      [param: In] set
      {
        this.PropertySet(nameof (ContainerLevel), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ContainerLevel));
      }
    }

    public new Info Operation
    {
      [param: In] set
      {
        this.PropertySet(nameof (Operation), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Operation));
      }
    }

    public Info QtyProcessed
    {
      [param: In] set
      {
        this.PropertySet(nameof (QtyProcessed), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (QtyProcessed));
      }
    }
  }
}
