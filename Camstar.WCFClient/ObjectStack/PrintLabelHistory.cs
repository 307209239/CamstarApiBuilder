// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.PrintLabelHistory
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
  public class PrintLabelHistory : ServiceHistorySummary
  {
    [DataMember(EmitDefaultValue = false, Name = "PrintLabelHistory_PrintQueue")]
    protected NamedObjectRef _PrintQueue;
    [DataMember(EmitDefaultValue = false, Name = "PrintLabelHistory_PrinterLabelDefinition")]
    protected RevisionedObjectRef _PrinterLabelDefinition;
    [DataMember(EmitDefaultValue = false, Name = "PrintLabelHistory_ExportImportKey")]
    protected new Primitive<string> _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "PrintLabelHistory_LabelCount")]
    protected Primitive<int> _LabelCount;
    [DataMember(EmitDefaultValue = false, Name = "PrintLabelHistory_HistoryId")]
    protected new BaseObjectRef _HistoryId;

    public override bool Equals(object obj)
    {
      return obj is PrintLabelHistory && object.Equals((object) this._PrintQueue, (object) ((PrintLabelHistory) obj)._PrintQueue) && (object.Equals((object) this._PrinterLabelDefinition, (object) ((PrintLabelHistory) obj)._PrinterLabelDefinition) && object.Equals((object) this._ExportImportKey, (object) ((PrintLabelHistory) obj)._ExportImportKey)) && (object.Equals((object) this._LabelCount, (object) ((PrintLabelHistory) obj)._LabelCount) && object.Equals((object) this._HistoryId, (object) ((PrintLabelHistory) obj)._HistoryId)) && base.Equals(obj);
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

    public RevisionedObjectRef PrinterLabelDefinition
    {
      [param: In] set
      {
        this.PropertySet(nameof (PrinterLabelDefinition), (object) value);
      }
      get
      {
        return (RevisionedObjectRef) this.PropertyGet(nameof (PrinterLabelDefinition));
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
