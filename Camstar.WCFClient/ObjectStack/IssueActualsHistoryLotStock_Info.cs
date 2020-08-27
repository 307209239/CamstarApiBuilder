// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.IssueActualsHistoryLotStock_Info
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
  public class IssueActualsHistoryLotStock_Info : IssueActualsHistory_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "IssueActualsHistoryLotStock_Info_FromLot")]
    protected Info _FromLot;
    [DataMember(EmitDefaultValue = false, Name = "IssueActualsHistoryLotStock_Info_FromStockPoint")]
    protected Info _FromStockPoint;
    [DataMember(EmitDefaultValue = false, Name = "IssueActualsHistoryLotStock_Info_IssuedFrom")]
    protected new Info _IssuedFrom;

    public Info FromLot
    {
      [param: In] set
      {
        this.PropertySet(nameof (FromLot), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (FromLot));
      }
    }

    public Info FromStockPoint
    {
      [param: In] set
      {
        this.PropertySet(nameof (FromStockPoint), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (FromStockPoint));
      }
    }

    public new Info IssuedFrom
    {
      [param: In] set
      {
        this.PropertySet(nameof (IssuedFrom), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (IssuedFrom));
      }
    }
  }
}
