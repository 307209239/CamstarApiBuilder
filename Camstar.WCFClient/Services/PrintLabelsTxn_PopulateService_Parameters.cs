// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.PrintLabelsTxn_PopulateService_Parameters
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
  public class PrintLabelsTxn_PopulateService_Parameters : PrintLabelsTxn_Parameters
  {
    [DataMember(EmitDefaultValue = false, Name = "ServiceDetail")]
    protected string _ServiceDetail;
    [DataMember(EmitDefaultValue = false, Name = "Service")]
    protected string _Service;

    public string ServiceDetail
    {
      [param: In] set
      {
        this.PropertySet(nameof (ServiceDetail), (object) value);
      }
      get
      {
        return (string) this.PropertyGet(nameof (ServiceDetail));
      }
    }

    public string Service
    {
      [param: In] set
      {
        this.PropertySet(nameof (Service), (object) value);
      }
      get
      {
        return (string) this.PropertyGet(nameof (Service));
      }
    }
  }
}
