// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.SplitHistory
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
  public class SplitHistory : ServiceHistorySummary
  {
    [DataMember(EmitDefaultValue = false, Name = "SplitHistory_HistoryDetails")]
    protected SplitHistoryDetails[] _HistoryDetails;
    [DataMember(EmitDefaultValue = false, Name = "SplitHistory_ExportImportKey")]
    protected new Primitive<string> _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "SplitHistory_Qty2")]
    protected Primitive<double> _Qty2;
    [DataMember(EmitDefaultValue = false, Name = "SplitHistory_UnitCount")]
    protected Primitive<int> _UnitCount;
    [DataMember(EmitDefaultValue = false, Name = "SplitHistory_ChildCount")]
    protected Primitive<int> _ChildCount;
    [DataMember(EmitDefaultValue = false, Name = "SplitHistory_FromContainer")]
    protected ContainerRef _FromContainer;
    [DataMember(EmitDefaultValue = false, Name = "SplitHistory_Closed")]
    protected Primitive<bool> _Closed;
    [DataMember(EmitDefaultValue = false, Name = "SplitHistory_HistoryId")]
    protected new BaseObjectRef _HistoryId;
    [DataMember(EmitDefaultValue = false, Name = "SplitHistory_Qty")]
    protected Primitive<double> _Qty;

    public override bool Equals(object obj)
    {
      return obj is SplitHistory && this.CompareArrays((Array) this._HistoryDetails, (Array) ((SplitHistory) obj)._HistoryDetails) && (object.Equals((object) this._ExportImportKey, (object) ((SplitHistory) obj)._ExportImportKey) && object.Equals((object) this._Qty2, (object) ((SplitHistory) obj)._Qty2)) && (object.Equals((object) this._UnitCount, (object) ((SplitHistory) obj)._UnitCount) && object.Equals((object) this._ChildCount, (object) ((SplitHistory) obj)._ChildCount) && (object.Equals((object) this._FromContainer, (object) ((SplitHistory) obj)._FromContainer) && object.Equals((object) this._Closed, (object) ((SplitHistory) obj)._Closed))) && (object.Equals((object) this._HistoryId, (object) ((SplitHistory) obj)._HistoryId) && object.Equals((object) this._Qty, (object) ((SplitHistory) obj)._Qty)) && base.Equals(obj);
    }

    public SplitHistoryDetails[] HistoryDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (HistoryDetails), (object) value);
      }
      get
      {
        return (SplitHistoryDetails[]) this.PropertyGet(nameof (HistoryDetails));
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

    public Primitive<int> UnitCount
    {
      [param: In] set
      {
        this.PropertySet(nameof (UnitCount), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (UnitCount));
      }
    }

    public Primitive<int> ChildCount
    {
      [param: In] set
      {
        this.PropertySet(nameof (ChildCount), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (ChildCount));
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

    public Primitive<bool> Closed
    {
      [param: In] set
      {
        this.PropertySet(nameof (Closed), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (Closed));
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
