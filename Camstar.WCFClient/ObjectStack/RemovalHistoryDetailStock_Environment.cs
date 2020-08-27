// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.RemovalHistoryDetailStock_Environment
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
  public class RemovalHistoryDetailStock_Environment : RemovalHistoryDetail_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "RemovalHistoryDetailStock_Environment_IssueActualsHistory")]
    [Metadata("Records the actual values issued to meet the BOM line item requirements for issue type stock.", "IssueActualsHistoryStock", false, false, true, "SubentityRef", 1049765, false, false, false, null)]
    protected new Environment _IssueActualsHistory;
    [DataMember(EmitDefaultValue = false, Name = "RemovalHistoryDetailStock_Environment_DestinationStockPoint")]
    [Metadata("Generic String", "", false, false, false, "String", 1049877, false, false, false, null)]
    protected Environment _DestinationStockPoint;

    public new Environment IssueActualsHistory
    {
      [param: In] set
      {
        this.PropertySet(nameof (IssueActualsHistory), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (IssueActualsHistory));
      }
    }

    public Environment DestinationStockPoint
    {
      [param: In] set
      {
        this.PropertySet(nameof (DestinationStockPoint), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (DestinationStockPoint));
      }
    }
  }
}
