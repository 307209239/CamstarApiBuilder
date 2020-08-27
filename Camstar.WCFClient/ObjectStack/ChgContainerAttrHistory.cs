// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ChgContainerAttrHistory
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [KnownType(typeof (ContainerMaintHistory))]
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [Serializable]
  public class ChgContainerAttrHistory : ServiceHistorySummary
  {
    [DataMember(EmitDefaultValue = false, Name = "ChgContainerAttrHistory_ChildProcessingMode")]
    protected Enumeration<ChildProcessingEnum, int> _ChildProcessingMode;
    [DataMember(EmitDefaultValue = false, Name = "ChgContainerAttrHistory_HistoryDetails")]
    protected ChgContainerAttrHistDetail[] _HistoryDetails;
    [DataMember(EmitDefaultValue = false, Name = "ChgContainerAttrHistory_ExportImportKey")]
    protected new Primitive<string> _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "ChgContainerAttrHistory_RecordDetailPostHistory")]
    protected Primitive<bool> _RecordDetailPostHistory;
    [DataMember(EmitDefaultValue = false, Name = "ChgContainerAttrHistory_HistoryId")]
    protected new BaseObjectRef _HistoryId;
    [DataMember(EmitDefaultValue = false, Name = "ChgContainerAttrHistory_RecordDetailPreHistory")]
    protected Primitive<bool> _RecordDetailPreHistory;

    public override bool Equals(object obj)
    {
      return obj is ChgContainerAttrHistory && object.Equals((object) this._ChildProcessingMode, (object) ((ChgContainerAttrHistory) obj)._ChildProcessingMode) && (this.CompareArrays((Array) this._HistoryDetails, (Array) ((ChgContainerAttrHistory) obj)._HistoryDetails) && object.Equals((object) this._ExportImportKey, (object) ((ChgContainerAttrHistory) obj)._ExportImportKey)) && (object.Equals((object) this._RecordDetailPostHistory, (object) ((ChgContainerAttrHistory) obj)._RecordDetailPostHistory) && object.Equals((object) this._HistoryId, (object) ((ChgContainerAttrHistory) obj)._HistoryId) && object.Equals((object) this._RecordDetailPreHistory, (object) ((ChgContainerAttrHistory) obj)._RecordDetailPreHistory)) && base.Equals(obj);
    }

    public Enumeration<ChildProcessingEnum, int> ChildProcessingMode
    {
      [param: In] set
      {
        this.PropertySet(nameof (ChildProcessingMode), (object) value);
      }
      get
      {
        return (Enumeration<ChildProcessingEnum, int>) this.PropertyGet(nameof (ChildProcessingMode));
      }
    }

    public ChgContainerAttrHistDetail[] HistoryDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (HistoryDetails), (object) value);
      }
      get
      {
        return (ChgContainerAttrHistDetail[]) this.PropertyGet(nameof (HistoryDetails));
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

    public Primitive<bool> RecordDetailPostHistory
    {
      [param: In] set
      {
        this.PropertySet(nameof (RecordDetailPostHistory), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (RecordDetailPostHistory));
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

    public Primitive<bool> RecordDetailPreHistory
    {
      [param: In] set
      {
        this.PropertySet(nameof (RecordDetailPreHistory), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (RecordDetailPreHistory));
      }
    }
  }
}
