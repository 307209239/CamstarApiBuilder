// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ContainerTxnRev_Environment
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
  public class ContainerTxnRev_Environment : ContainerTxn_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "ContainerTxnRev_Environment_TransactionSummaries")]
    [Metadata("ContainerHistoryInquiryDetail is used to produce more detailed history report for selected history record.", "ContainerHistoryInquiryDetail", false, false, false, "SubentityRef", 1049314, false, true, false, null)]
    protected Environment _TransactionSummaries;
    [DataMember(EmitDefaultValue = false, Name = "ContainerTxnRev_Environment_ReversalCDOs")]
    [Metadata("History information  that is common to most or all shop floor transaction services is stored in the HistoryMainline.  Typically there is one HistoryMainline entry for each Shop floor transaction, although compound transactions can be configured to generate multiple HistoryMainlines when appropriate.  The HistoryMainline is the primary source of History information.", "HistoryMainline", false, false, false, "HistoryMainline", 1049396, false, true, false, null)]
    protected HistoryMainline_Environment _ReversalCDOs;
    [DataMember(EmitDefaultValue = false, Name = "ContainerTxnRev_Environment_HistoryCDOs")]
    [Metadata("History information  that is common to most or all shop floor transaction services is stored in the HistoryMainline.  Typically there is one HistoryMainline entry for each Shop floor transaction, although compound transactions can be configured to generate multiple HistoryMainlines when appropriate.  The HistoryMainline is the primary source of History information.", "HistoryMainline", false, false, false, "HistoryMainline", 1049311, false, true, false, null)]
    protected HistoryMainline_Environment _HistoryCDOs;

    public Environment TransactionSummaries
    {
      [param: In] set
      {
        this.PropertySet(nameof (TransactionSummaries), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (TransactionSummaries));
      }
    }

    public HistoryMainline_Environment ReversalCDOs
    {
      [param: In] set
      {
        this.PropertySet(nameof (ReversalCDOs), (object) value);
      }
      get
      {
        return (HistoryMainline_Environment) this.PropertyGet(nameof (ReversalCDOs));
      }
    }

    public HistoryMainline_Environment HistoryCDOs
    {
      [param: In] set
      {
        this.PropertySet(nameof (HistoryCDOs), (object) value);
      }
      get
      {
        return (HistoryMainline_Environment) this.PropertyGet(nameof (HistoryCDOs));
      }
    }
  }
}
