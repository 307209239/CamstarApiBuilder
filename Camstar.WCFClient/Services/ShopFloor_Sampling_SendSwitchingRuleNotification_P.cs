// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.ShopFloor_Sampling_SendSwitchingRuleNotification_Parameters
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
  public class ShopFloor_Sampling_SendSwitchingRuleNotification_Parameters : ShopFloor_Parameters
  {
    [DataMember(EmitDefaultValue = false, Name = "EMailDistribution")]
    protected string _EMailDistribution;
    [DataMember(EmitDefaultValue = false, Name = "EMailMessage")]
    protected string _EMailMessage;

    public string EMailDistribution
    {
      [param: In] set
      {
        this.PropertySet(nameof (EMailDistribution), (object) value);
      }
      get
      {
        return (string) this.PropertyGet(nameof (EMailDistribution));
      }
    }

    public string EMailMessage
    {
      [param: In] set
      {
        this.PropertySet(nameof (EMailMessage), (object) value);
      }
      get
      {
        return (string) this.PropertyGet(nameof (EMailMessage));
      }
    }
  }
}
