// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.PrintLabelHistory_Info
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
  public class PrintLabelHistory_Info : ServiceHistorySummary_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "PrintLabelHistory_Info_PrintQueue")]
    protected Info _PrintQueue;
    [DataMember(EmitDefaultValue = false, Name = "PrintLabelHistory_Info_PrinterLabelDefinition")]
    protected Info _PrinterLabelDefinition;
    [DataMember(EmitDefaultValue = false, Name = "PrintLabelHistory_Info_ExportImportKey")]
    protected new Info _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "PrintLabelHistory_Info_LabelCount")]
    protected Info _LabelCount;
    [DataMember(EmitDefaultValue = false, Name = "PrintLabelHistory_Info_HistoryId")]
    protected new Info _HistoryId;

    public Info PrintQueue
    {
      [param: In] set
      {
        this.PropertySet(nameof (PrintQueue), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (PrintQueue));
      }
    }

    public Info PrinterLabelDefinition
    {
      [param: In] set
      {
        this.PropertySet(nameof (PrinterLabelDefinition), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (PrinterLabelDefinition));
      }
    }

    public new Info ExportImportKey
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExportImportKey), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ExportImportKey));
      }
    }

    public Info LabelCount
    {
      [param: In] set
      {
        this.PropertySet(nameof (LabelCount), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (LabelCount));
      }
    }

    public new Info HistoryId
    {
      [param: In] set
      {
        this.PropertySet(nameof (HistoryId), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (HistoryId));
      }
    }
  }
}
