// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ReprintLabelHistory
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
  public class ReprintLabelHistory : ServiceHistorySummary
  {
    [DataMember(EmitDefaultValue = false, Name = "ReprintLabelHistory_PrintQueue")]
    protected NamedObjectRef _PrintQueue;
    [DataMember(EmitDefaultValue = false, Name = "ReprintLabelHistory_ExportImportKey")]
    protected new Primitive<string> _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "ReprintLabelHistory_HistoryId")]
    protected new BaseObjectRef _HistoryId;
    [DataMember(EmitDefaultValue = false, Name = "ReprintLabelHistory_LabelCount")]
    protected Primitive<int> _LabelCount;

    public override bool Equals(object obj)
    {
      return obj is ReprintLabelHistory && object.Equals((object) this._PrintQueue, (object) ((ReprintLabelHistory) obj)._PrintQueue) && (object.Equals((object) this._ExportImportKey, (object) ((ReprintLabelHistory) obj)._ExportImportKey) && object.Equals((object) this._HistoryId, (object) ((ReprintLabelHistory) obj)._HistoryId)) && object.Equals((object) this._LabelCount, (object) ((ReprintLabelHistory) obj)._LabelCount) && base.Equals(obj);
    }

    public NamedObjectRef PrintQueue
    {
      [param: In] set
      {
        this.PropertySet(nameof (PrintQueue), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (PrintQueue));
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

    public Primitive<int> LabelCount
    {
      [param: In] set
      {
        this.PropertySet(nameof (LabelCount), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (LabelCount));
      }
    }
  }
}
