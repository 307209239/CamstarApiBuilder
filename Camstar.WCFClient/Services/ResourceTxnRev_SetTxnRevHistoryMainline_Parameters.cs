// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.ResourceTxnRev_SetTxnRevHistoryMainline_Parameters
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
  public class ResourceTxnRev_SetTxnRevHistoryMainline_Parameters : ResourceTxnRev_Parameters
  {
    [DataMember(EmitDefaultValue = false, Name = "RevHistoryMainline")]
    protected string _RevHistoryMainline;

    public string RevHistoryMainline
    {
      [param: In] set
      {
        this.PropertySet(nameof (RevHistoryMainline), (object) value);
      }
      get
      {
        return (string) this.PropertyGet(nameof (RevHistoryMainline));
      }
    }
  }
}
