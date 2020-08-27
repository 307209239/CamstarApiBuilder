// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.ShopFloor_EvaluateLabelTags_Parameters
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
  public class ShopFloor_EvaluateLabelTags_Parameters : ShopFloor_Parameters
  {
    [DataMember(EmitDefaultValue = false, Name = "LabelSummary")]
    protected string _LabelSummary;
    [DataMember(EmitDefaultValue = false, Name = "LabelTags")]
    protected string _LabelTags;

    public string LabelSummary
    {
      [param: In] set
      {
        this.PropertySet(nameof (LabelSummary), (object) value);
      }
      get
      {
        return (string) this.PropertyGet(nameof (LabelSummary));
      }
    }

    public string LabelTags
    {
      [param: In] set
      {
        this.PropertySet(nameof (LabelTags), (object) value);
      }
      get
      {
        return (string) this.PropertyGet(nameof (LabelTags));
      }
    }
  }
}
