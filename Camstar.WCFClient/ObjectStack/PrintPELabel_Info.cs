// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.PrintPELabel_Info
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
  public class PrintPELabel_Info : PrintLabelTxn_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "PrintPELabel_Info_HistoryId")]
    protected new Info _HistoryId;
    [DataMember(EmitDefaultValue = false, Name = "PrintPELabel_Info_ProductionEvent")]
    protected Info _ProductionEvent;
    [DataMember(EmitDefaultValue = false, Name = "PrintPELabel_Info_PrintQueue")]
    protected new Info _PrintQueue;
    [DataMember(EmitDefaultValue = false, Name = "PrintPELabel_Info_PrinterLabelDefinition")]
    protected new Info _PrinterLabelDefinition;
    [DataMember(EmitDefaultValue = false, Name = "PrintPELabel_Info_Container")]
    protected Info _Container;
    [DataMember(EmitDefaultValue = false, Name = "PrintPELabel_Info_LabelCount")]
    protected new Info _LabelCount;
    [DataMember(EmitDefaultValue = false, Name = "PrintPELabel_Info_PETxn")]
    protected Info _PETxn;
    [DataMember(EmitDefaultValue = false, Name = "PrintPELabel_Info_Factory")]
    protected new Info _Factory;

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

    public Info ProductionEvent
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProductionEvent), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ProductionEvent));
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

    public Info Container
    {
      [param: In] set
      {
        this.PropertySet(nameof (Container), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Container));
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

    public Info PETxn
    {
      [param: In] set
      {
        this.PropertySet(nameof (PETxn), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (PETxn));
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
