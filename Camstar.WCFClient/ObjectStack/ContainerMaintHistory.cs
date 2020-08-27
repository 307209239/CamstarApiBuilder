// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ContainerMaintHistory
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
  public class ContainerMaintHistory : ChgContainerAttrHistory
  {
    [DataMember(EmitDefaultValue = false, Name = "ContainerMaintHistory_HistoryDetails")]
    protected ContainerMaintHistDetail[] _HistoryDetails;
    [DataMember(EmitDefaultValue = false, Name = "ContainerMaintHistory_ChildProcessingMode")]
    protected new Enumeration<ChildProcessingEnum, int> _ChildProcessingMode;
    [DataMember(EmitDefaultValue = false, Name = "ContainerMaintHistory_ExportImportKey")]
    protected new Primitive<string> _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "ContainerMaintHistory_RecordDetailPostHistory")]
    protected new Primitive<bool> _RecordDetailPostHistory;
    [DataMember(EmitDefaultValue = false, Name = "ContainerMaintHistory_RecordDetailPreHistory")]
    protected new Primitive<bool> _RecordDetailPreHistory;
    [DataMember(EmitDefaultValue = false, Name = "ContainerMaintHistory_HistoryId")]
    protected new BaseObjectRef _HistoryId;

    public override bool Equals(object obj)
    {
      return obj is ContainerMaintHistory && this.CompareArrays((Array) this._HistoryDetails, (Array) ((ContainerMaintHistory) obj)._HistoryDetails) && (object.Equals((object) this._ChildProcessingMode, (object) ((ContainerMaintHistory) obj)._ChildProcessingMode) && object.Equals((object) this._ExportImportKey, (object) ((ContainerMaintHistory) obj)._ExportImportKey)) && (object.Equals((object) this._RecordDetailPostHistory, (object) ((ContainerMaintHistory) obj)._RecordDetailPostHistory) && object.Equals((object) this._RecordDetailPreHistory, (object) ((ContainerMaintHistory) obj)._RecordDetailPreHistory) && object.Equals((object) this._HistoryId, (object) ((ContainerMaintHistory) obj)._HistoryId)) && base.Equals(obj);
    }

    public ContainerMaintHistDetail[] HistoryDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (HistoryDetails), (object) value);
      }
      get
      {
        return (ContainerMaintHistDetail[]) this.PropertyGet(nameof (HistoryDetails));
      }
    }

    public new Enumeration<ChildProcessingEnum, int> ChildProcessingMode
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

    public new Primitive<bool> RecordDetailPostHistory
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

    public new Primitive<bool> RecordDetailPreHistory
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
  }
}
