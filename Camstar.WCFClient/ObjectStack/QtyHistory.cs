// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.QtyHistory
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [KnownType(typeof (EmptyCarrierHistory))]
  [Serializable]
  public class QtyHistory : ServiceHistorySummary
  {
    [DataMember(EmitDefaultValue = false, Name = "QtyHistory_RollupReason")]
    protected NamedObjectRef _RollupReason;
    [DataMember(EmitDefaultValue = false, Name = "QtyHistory_ExportImportKey")]
    protected new Primitive<string> _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "QtyHistory_Qty2")]
    protected Primitive<double> _Qty2;
    [DataMember(EmitDefaultValue = false, Name = "QtyHistory_HistoryDetails")]
    protected QtyHistoryDetails[] _HistoryDetails;
    [DataMember(EmitDefaultValue = false, Name = "QtyHistory_ThruputSummary")]
    protected Primitive<bool> _ThruputSummary;
    [DataMember(EmitDefaultValue = false, Name = "QtyHistory_HistoryId")]
    protected new BaseObjectRef _HistoryId;
    [DataMember(EmitDefaultValue = false, Name = "QtyHistory_UnitsLost")]
    protected Primitive<int> _UnitsLost;
    [DataMember(EmitDefaultValue = false, Name = "QtyHistory_CloseWhenZero")]
    protected Primitive<bool> _CloseWhenZero;
    [DataMember(EmitDefaultValue = false, Name = "QtyHistory_Qty")]
    protected Primitive<double> _Qty;
    [DataMember(EmitDefaultValue = false, Name = "QtyHistory_ThruputReportingLevel")]
    protected NamedObjectRef _ThruputReportingLevel;
    [DataMember(EmitDefaultValue = false, Name = "QtyHistory_Resource")]
    protected NamedObjectRef _Resource;

    public override bool Equals(object obj)
    {
      return obj is QtyHistory && object.Equals((object) this._RollupReason, (object) ((QtyHistory) obj)._RollupReason) && (object.Equals((object) this._ExportImportKey, (object) ((QtyHistory) obj)._ExportImportKey) && object.Equals((object) this._Qty2, (object) ((QtyHistory) obj)._Qty2)) && (this.CompareArrays((Array) this._HistoryDetails, (Array) ((QtyHistory) obj)._HistoryDetails) && object.Equals((object) this._ThruputSummary, (object) ((QtyHistory) obj)._ThruputSummary) && (object.Equals((object) this._HistoryId, (object) ((QtyHistory) obj)._HistoryId) && object.Equals((object) this._UnitsLost, (object) ((QtyHistory) obj)._UnitsLost))) && (object.Equals((object) this._CloseWhenZero, (object) ((QtyHistory) obj)._CloseWhenZero) && object.Equals((object) this._Qty, (object) ((QtyHistory) obj)._Qty) && (object.Equals((object) this._ThruputReportingLevel, (object) ((QtyHistory) obj)._ThruputReportingLevel) && object.Equals((object) this._Resource, (object) ((QtyHistory) obj)._Resource))) && base.Equals(obj);
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

    public new Primitive<string> ExportImportKey
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExportImportKey), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (ExportImportKey));
      }
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

    public QtyHistoryDetails[] HistoryDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (HistoryDetails), (object) value);
      }
      get
      {
        return (QtyHistoryDetails[]) this.PropertyGet(nameof (HistoryDetails));
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

    public new BaseObjectRef HistoryId
    {
      [param: In] set
      {
        this.PropertySet(nameof (HistoryId), (object) value);
      }
      get
      {
        return (BaseObjectRef) this.PropertyGet(nameof (HistoryId));
      }
    }

    public Primitive<int> UnitsLost
    {
      [param: In] set
      {
        this.PropertySet(nameof (UnitsLost), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (UnitsLost));
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
  }
}
