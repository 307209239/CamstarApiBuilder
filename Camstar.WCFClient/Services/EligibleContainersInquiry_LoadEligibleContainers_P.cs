// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.EligibleContainersInquiry_LoadEligibleContainers_Parameters
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
  public class EligibleContainersInquiry_LoadEligibleContainers_Parameters : EligibleContainersInquiry_Parameters
  {
    [DataMember(EmitDefaultValue = false, Name = "ResultsetStartRow")]
    protected string _ResultsetStartRow;
    [DataMember(EmitDefaultValue = false, Name = "ResultsetSizeLimit")]
    protected string _ResultsetSizeLimit;

    public string ResultsetStartRow
    {
      [param: In] set
      {
        this.PropertySet(nameof (ResultsetStartRow), (object) value);
      }
      get
      {
        return (string) this.PropertyGet(nameof (ResultsetStartRow));
      }
    }

    public string ResultsetSizeLimit
    {
      [param: In] set
      {
        this.PropertySet(nameof (ResultsetSizeLimit), (object) value);
      }
      get
      {
        return (string) this.PropertyGet(nameof (ResultsetSizeLimit));
      }
    }
  }
}
