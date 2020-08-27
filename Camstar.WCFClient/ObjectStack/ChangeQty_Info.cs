// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ChangeQty_Info
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
  public class ChangeQty_Info : ContainerTxn_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "ChangeQty_Info_RollupReason")]
    protected Info _RollupReason;
    [DataMember(EmitDefaultValue = false, Name = "ChangeQty_Info_ServiceDetails")]
    protected ChangeQtyDetails_Info _ServiceDetails;
    [DataMember(EmitDefaultValue = false, Name = "ChangeQty_Info_Carrier")]
    protected new Info _Carrier;
    [DataMember(EmitDefaultValue = false, Name = "ChangeQty_Info_RecordAllQtySummaryOnly")]
    protected Info _RecordAllQtySummaryOnly;
    [DataMember(EmitDefaultValue = false, Name = "ChangeQty_Info_Container")]
    protected new Info _Container;
    [DataMember(EmitDefaultValue = false, Name = "ChangeQty_Info_GenerateRollups")]
    protected Info _GenerateRollups;
    [DataMember(EmitDefaultValue = false, Name = "ChangeQty_Info_ThruputSummary")]
    protected Info _ThruputSummary;
    [DataMember(EmitDefaultValue = false, Name = "ChangeQty_Info_ProcessESignatures")]
    protected new Info _ProcessESignatures;
    [DataMember(EmitDefaultValue = false, Name = "ChangeQty_Info_DisassociateWhenClosed")]
    protected Info _DisassociateWhenClosed;
    [DataMember(EmitDefaultValue = false, Name = "ChangeQty_Info_CloseWhenZero")]
    protected Info _CloseWhenZero;
    [DataMember(EmitDefaultValue = false, Name = "ChangeQty_Info_Resource")]
    protected Info _Resource;
    [DataMember(EmitDefaultValue = false, Name = "ChangeQty_Info_ThruputReportingLevel")]
    protected Info _ThruputReportingLevel;

    public Info RollupReason
    {
      [param: In] set
      {
        this.PropertySet(nameof (RollupReason), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (RollupReason));
      }
    }

    public ChangeQtyDetails_Info ServiceDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (ServiceDetails), (object) value);
      }
      get
      {
        return (ChangeQtyDetails_Info) this.PropertyGet(nameof (ServiceDetails));
      }
    }

    public new Info Carrier
    {
      [param: In] set
      {
        this.PropertySet(nameof (Carrier), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Carrier));
      }
    }

    public Info RecordAllQtySummaryOnly
    {
      [param: In] set
      {
        this.PropertySet(nameof (RecordAllQtySummaryOnly), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (RecordAllQtySummaryOnly));
      }
    }

    public new Info Container
    {
      [param: In] set
      {
        this.PropertySet(nameof (Container), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Container));
      }
    }

    public Info GenerateRollups
    {
      [param: In] set
      {
        this.PropertySet(nameof (GenerateRollups), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (GenerateRollups));
      }
    }

    public Info ThruputSummary
    {
      [param: In] set
      {
        this.PropertySet(nameof (ThruputSummary), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ThruputSummary));
      }
    }

    public new Info ProcessESignatures
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProcessESignatures), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ProcessESignatures));
      }
    }

    public Info DisassociateWhenClosed
    {
      [param: In] set
      {
        this.PropertySet(nameof (DisassociateWhenClosed), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (DisassociateWhenClosed));
      }
    }

    public Info CloseWhenZero
    {
      [param: In] set
      {
        this.PropertySet(nameof (CloseWhenZero), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (CloseWhenZero));
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
  }
}
