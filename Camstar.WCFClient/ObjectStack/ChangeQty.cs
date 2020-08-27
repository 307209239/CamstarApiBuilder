// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ChangeQty
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
  public class ChangeQty : ContainerTxn
  {
    [DataMember(EmitDefaultValue = false, Name = "ChangeQty_RollupReason")]
    protected NamedObjectRef _RollupReason;
    [DataMember(EmitDefaultValue = false, Name = "ChangeQty_ServiceDetails")]
    protected ChangeQtyDetails[] _ServiceDetails;
    [DataMember(EmitDefaultValue = false, Name = "ChangeQty_Carrier")]
    protected new NamedObjectRef _Carrier;
    [DataMember(EmitDefaultValue = false, Name = "ChangeQty_RecordAllQtySummaryOnly")]
    protected Primitive<bool> _RecordAllQtySummaryOnly;
    [DataMember(EmitDefaultValue = false, Name = "ChangeQty_Container")]
    protected new ContainerRef _Container;
    [DataMember(EmitDefaultValue = false, Name = "ChangeQty_GenerateRollups")]
    protected Primitive<bool> _GenerateRollups;
    [DataMember(EmitDefaultValue = false, Name = "ChangeQty_ThruputSummary")]
    protected Primitive<bool> _ThruputSummary;
    [DataMember(EmitDefaultValue = false, Name = "ChangeQty_ProcessESignatures")]
    protected new Primitive<bool> _ProcessESignatures;
    [DataMember(EmitDefaultValue = false, Name = "ChangeQty_DisassociateWhenClosed")]
    protected Primitive<bool> _DisassociateWhenClosed;
    [DataMember(EmitDefaultValue = false, Name = "ChangeQty_CloseWhenZero")]
    protected Primitive<bool> _CloseWhenZero;
    [DataMember(EmitDefaultValue = false, Name = "ChangeQty_Resource")]
    protected NamedObjectRef _Resource;
    [DataMember(EmitDefaultValue = false, Name = "ChangeQty_ThruputReportingLevel")]
    protected NamedObjectRef _ThruputReportingLevel;

    public override bool Equals(object obj)
    {
      return obj is ChangeQty && object.Equals((object) this._RollupReason, (object) ((ChangeQty) obj)._RollupReason) && (this.CompareArrays((Array) this._ServiceDetails, (Array) ((ChangeQty) obj)._ServiceDetails) && object.Equals((object) this._Carrier, (object) ((ChangeQty) obj)._Carrier)) && (object.Equals((object) this._RecordAllQtySummaryOnly, (object) ((ChangeQty) obj)._RecordAllQtySummaryOnly) && object.Equals((object) this._Container, (object) ((ChangeQty) obj)._Container) && (object.Equals((object) this._GenerateRollups, (object) ((ChangeQty) obj)._GenerateRollups) && object.Equals((object) this._ThruputSummary, (object) ((ChangeQty) obj)._ThruputSummary))) && (object.Equals((object) this._ProcessESignatures, (object) ((ChangeQty) obj)._ProcessESignatures) && object.Equals((object) this._DisassociateWhenClosed, (object) ((ChangeQty) obj)._DisassociateWhenClosed) && (object.Equals((object) this._CloseWhenZero, (object) ((ChangeQty) obj)._CloseWhenZero) && object.Equals((object) this._Resource, (object) ((ChangeQty) obj)._Resource)) && object.Equals((object) this._ThruputReportingLevel, (object) ((ChangeQty) obj)._ThruputReportingLevel)) && base.Equals(obj);
    }

    public NamedObjectRef RollupReason
    {
      [param: In] set
      {
        this.PropertySet(nameof (RollupReason), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (RollupReason));
      }
    }

    public ChangeQtyDetails[] ServiceDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (ServiceDetails), (object) value);
      }
      get
      {
        return (ChangeQtyDetails[]) this.PropertyGet(nameof (ServiceDetails));
      }
    }

    public new NamedObjectRef Carrier
    {
      [param: In] set
      {
        this.PropertySet(nameof (Carrier), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (Carrier));
      }
    }

    public Primitive<bool> RecordAllQtySummaryOnly
    {
      [param: In] set
      {
        this.PropertySet(nameof (RecordAllQtySummaryOnly), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (RecordAllQtySummaryOnly));
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

    public Primitive<bool> GenerateRollups
    {
      [param: In] set
      {
        this.PropertySet(nameof (GenerateRollups), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (GenerateRollups));
      }
    }

    public Primitive<bool> ThruputSummary
    {
      [param: In] set
      {
        this.PropertySet(nameof (ThruputSummary), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (ThruputSummary));
      }
    }

    public new Primitive<bool> ProcessESignatures
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProcessESignatures), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (ProcessESignatures));
      }
    }

    public Primitive<bool> DisassociateWhenClosed
    {
      [param: In] set
      {
        this.PropertySet(nameof (DisassociateWhenClosed), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (DisassociateWhenClosed));
      }
    }

    public Primitive<bool> CloseWhenZero
    {
      [param: In] set
      {
        this.PropertySet(nameof (CloseWhenZero), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (CloseWhenZero));
      }
    }

    public NamedObjectRef Resource
    {
      [param: In] set
      {
        this.PropertySet(nameof (Resource), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (Resource));
      }
    }

    public NamedObjectRef ThruputReportingLevel
    {
      [param: In] set
      {
        this.PropertySet(nameof (ThruputReportingLevel), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (ThruputReportingLevel));
      }
    }
  }
}
