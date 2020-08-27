// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ContainerTxnRev_Info
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
  public class ContainerTxnRev_Info : ContainerTxn_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "ContainerTxnRev_Info_TransactionSummaries")]
    protected Info _TransactionSummaries;
    [DataMember(EmitDefaultValue = false, Name = "ContainerTxnRev_Info_ReversalCDOs")]
    protected HistoryMainline_Info _ReversalCDOs;
    [DataMember(EmitDefaultValue = false, Name = "ContainerTxnRev_Info_HistoryCDOs")]
    protected HistoryMainline_Info _HistoryCDOs;

    public Info TransactionSummaries
    {
      [param: In] set
      {
        this.PropertySet(nameof (TransactionSummaries), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (TransactionSummaries));
      }
    }

    public HistoryMainline_Info ReversalCDOs
    {
      [param: In] set
      {
        this.PropertySet(nameof (ReversalCDOs), (object) value);
      }
      get
      {
        return (HistoryMainline_Info) this.PropertyGet(nameof (ReversalCDOs));
      }
    }

    public HistoryMainline_Info HistoryCDOs
    {
      [param: In] set
      {
        this.PropertySet(nameof (HistoryCDOs), (object) value);
      }
      get
      {
        return (HistoryMainline_Info) this.PropertyGet(nameof (HistoryCDOs));
      }
    }
  }
}
