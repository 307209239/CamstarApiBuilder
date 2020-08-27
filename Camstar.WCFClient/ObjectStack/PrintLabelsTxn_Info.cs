// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.PrintLabelsTxn_Info
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
  public class PrintLabelsTxn_Info : ShopFloor_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "PrintLabelsTxn_Info_Services")]
    protected PrintLabelTxn_Info _Services;
    [DataMember(EmitDefaultValue = false, Name = "PrintLabelsTxn_Info_PrintQueue")]
    protected new Info _PrintQueue;
    [DataMember(EmitDefaultValue = false, Name = "PrintLabelsTxn_Info_PrinterLabelDefinition")]
    protected Info _PrinterLabelDefinition;
    [DataMember(EmitDefaultValue = false, Name = "PrintLabelsTxn_Info_ServiceDetails")]
    protected PrintLabelDetails_Info _ServiceDetails;
    [DataMember(EmitDefaultValue = false, Name = "PrintLabelsTxn_Info_LabelCount")]
    protected Info _LabelCount;
    [DataMember(EmitDefaultValue = false, Name = "PrintLabelsTxn_Info_Factory")]
    protected new Info _Factory;

    public PrintLabelTxn_Info Services
    {
      [param: In] set
      {
        this.PropertySet(nameof (Services), (object) value);
      }
      get
      {
        return (PrintLabelTxn_Info) this.PropertyGet(nameof (Services));
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

    public PrintLabelDetails_Info ServiceDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (ServiceDetails), (object) value);
      }
      get
      {
        return (PrintLabelDetails_Info) this.PropertyGet(nameof (ServiceDetails));
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
