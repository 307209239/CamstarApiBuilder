// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ResourceTxnRev_Environment
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
  public class ResourceTxnRev_Environment : ResourceTxn_Environment
  {
    [Metadata("History information  that is common to most or all shop floor transaction services is stored in the HistoryMainline.  Typically there is one HistoryMainline entry for each Shop floor transaction, although compound transactions can be configured to generate multiple HistoryMainlines when appropriate.  The HistoryMainline is the primary source of History information.", "HistoryMainline", false, false, false, "BaseObjectRef", 1049903, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ResourceTxnRev_Environment_HistoryCDOs")]
    protected Environment _HistoryCDOs;

    public Environment HistoryCDOs
    {
      [param: In] set
      {
        this.PropertySet(nameof (HistoryCDOs), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (HistoryCDOs));
      }
    }
  }
}
