// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ReprintLabel_Info
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
  public class ReprintLabel_Info : PrintLabelTxn_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "ReprintLabel_Info_PrintQueue")]
    protected new Info _PrintQueue;
    [DataMember(EmitDefaultValue = false, Name = "ReprintLabel_Info_LabelHistorySummary")]
    protected Info _LabelHistorySummary;
    [DataMember(EmitDefaultValue = false, Name = "ReprintLabel_Info_SelectedHistoryMainline")]
    protected Info _SelectedHistoryMainline;
    [DataMember(EmitDefaultValue = false, Name = "ReprintLabel_Info_PrinterLabelDefinition")]
    protected new Info _PrinterLabelDefinition;
    [DataMember(EmitDefaultValue = false, Name = "ReprintLabel_Info_LabelCount")]
    protected new Info _LabelCount;
    [DataMember(EmitDefaultValue = false, Name = "ReprintLabel_Info_HistoryId")]
    protected new Info _HistoryId;
    [DataMember(EmitDefaultValue = false, Name = "ReprintLabel_Info_Factory")]
    protected new Info _Factory;

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

    public Info LabelHistorySummary
    {
      [param: In] set
      {
        this.PropertySet(nameof (LabelHistorySummary), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (LabelHistorySummary));
      }
    }

    public Info SelectedHistoryMainline
    {
      [param: In] set
      {
        this.PropertySet(nameof (SelectedHistoryMainline), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (SelectedHistoryMainline));
      }
    }

    public new Info PrinterLabelDefinition
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

    public new Info LabelCount
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
