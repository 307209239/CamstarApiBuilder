// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.ShopFloor_GetLabelInformationFromPrinterLabel_Parameters
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.Services
{
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [Serializable]
  public class ShopFloor_GetLabelInformationFromPrinterLabel_Parameters : ShopFloor_Parameters
  {
    [DataMember(EmitDefaultValue = false, Name = "LabelCount")]
    protected string _LabelCount;
    [DataMember(EmitDefaultValue = false, Name = "PrinterLabelDefinition")]
    protected string _PrinterLabelDefinition;

    public string LabelCount
    {
      [param: In] set
      {
        this.PropertySet(nameof (LabelCount), (object) value);
      }
      get
      {
        return (string) this.PropertyGet(nameof (LabelCount));
      }
    }

    public string PrinterLabelDefinition
    {
      [param: In] set
      {
        this.PropertySet(nameof (PrinterLabelDefinition), (object) value);
      }
      get
      {
        return (string) this.PropertyGet(nameof (PrinterLabelDefinition));
      }
    }
  }
}
