// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.PrintLabelTxn_Info
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
  public class PrintLabelTxn_Info : ShopFloor_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "PrintLabelTxn_Info_PrinterLabelDefinition")]
    protected Info _PrinterLabelDefinition;
    [DataMember(EmitDefaultValue = false, Name = "PrintLabelTxn_Info_LabelSummaries")]
    protected new LabelSummary_Info _LabelSummaries;
    [DataMember(EmitDefaultValue = false, Name = "PrintLabelTxn_Info_PrintQueue")]
    protected new Info _PrintQueue;
    [DataMember(EmitDefaultValue = false, Name = "PrintLabelTxn_Info_HistoryId")]
    protected Info _HistoryId;
    [DataMember(EmitDefaultValue = false, Name = "PrintLabelTxn_Info_LabelCount")]
    protected Info _LabelCount;
    [DataMember(EmitDefaultValue = false, Name = "PrintLabelTxn_Info_Factory")]
    protected new Info _Factory;

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

    public new LabelSummary_Info LabelSummaries
    {
      [param: In] set
      {
        this.PropertySet(nameof (LabelSummaries), (object) value);
      }
      get
      {
        return (LabelSummary_Info) this.PropertyGet(nameof (LabelSummaries));
      }
    }

    public new Info PrintQueue
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

    public Info HistoryId
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

    public new Info Factory
    {
      [param: In] set
      {
        this.PropertySet(nameof (Factory), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Factory));
      }
    }
  }
}
