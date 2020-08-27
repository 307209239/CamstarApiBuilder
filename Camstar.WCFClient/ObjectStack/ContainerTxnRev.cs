// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ContainerTxnRev
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
  public class ContainerTxnRev : ContainerTxn
  {
    [DataMember(EmitDefaultValue = false, Name = "ContainerTxnRev_TransactionSummaries")]
    protected SubentityRef[] _TransactionSummaries;
    [DataMember(EmitDefaultValue = false, Name = "ContainerTxnRev_ReversalCDOs")]
    protected HistoryMainline[] _ReversalCDOs;
    [DataMember(EmitDefaultValue = false, Name = "ContainerTxnRev_HistoryCDOs")]
    protected HistoryMainline[] _HistoryCDOs;

    public override bool Equals(object obj)
    {
      return obj is ContainerTxnRev && this.CompareArrays((Array) this._TransactionSummaries, (Array) ((ContainerTxnRev) obj)._TransactionSummaries) && (this.CompareArrays((Array) this._ReversalCDOs, (Array) ((ContainerTxnRev) obj)._ReversalCDOs) && this.CompareArrays((Array) this._HistoryCDOs, (Array) ((ContainerTxnRev) obj)._HistoryCDOs)) && base.Equals(obj);
    }

    public SubentityRef[] TransactionSummaries
    {
      [param: In] set
      {
        this.PropertySet(nameof (TransactionSummaries), (object) value);
      }
      get
      {
        return (SubentityRef[]) this.PropertyGet(nameof (TransactionSummaries));
      }
    }

    public HistoryMainline[] ReversalCDOs
    {
      [param: In] set
      {
        this.PropertySet(nameof (ReversalCDOs), (object) value);
      }
      get
      {
        return (HistoryMainline[]) this.PropertyGet(nameof (ReversalCDOs));
      }
    }

    public HistoryMainline[] HistoryCDOs
    {
      [param: In] set
      {
        this.PropertySet(nameof (HistoryCDOs), (object) value);
      }
      get
      {
        return (HistoryMainline[]) this.PropertyGet(nameof (HistoryCDOs));
      }
    }
  }
}
