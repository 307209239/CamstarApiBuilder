// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.IssueActualsHistoryLotStock_Environment
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
  public class IssueActualsHistoryLotStock_Environment : IssueActualsHistory_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "IssueActualsHistoryLotStock_Environment_FromLot")]
    [Metadata("Generic String", "", false, false, false, "String", 1049458, false, false, false, null)]
    protected Environment _FromLot;
    [Metadata("Generic String", "", false, false, false, "String", 1049457, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "IssueActualsHistoryLotStock_Environment_FromStockPoint")]
    protected Environment _FromStockPoint;
    [Metadata("Generic String", "", false, false, true, "String", 1050419, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "IssueActualsHistoryLotStock_Environment_IssuedFrom")]
    protected new Environment _IssuedFrom;

    public Environment FromLot
    {
      [param: In] set
      {
        this.PropertySet(nameof (FromLot), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (FromLot));
      }
    }

    public Environment FromStockPoint
    {
      [param: In] set
      {
        this.PropertySet(nameof (FromStockPoint), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (FromStockPoint));
      }
    }

    public new Environment IssuedFrom
    {
      [param: In] set
      {
        this.PropertySet(nameof (IssuedFrom), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (IssuedFrom));
      }
    }
  }
}
