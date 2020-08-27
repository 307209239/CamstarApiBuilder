// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.IssueActualsHistoryStock_Info
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
  public class IssueActualsHistoryStock_Info : IssueActualsHistory_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "IssueActualsHistoryStock_Info_IssuedFrom")]
    protected new Info _IssuedFrom;
    [DataMember(EmitDefaultValue = false, Name = "IssueActualsHistoryStock_Info_FromStockPoint")]
    protected Info _FromStockPoint;

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
  }
}
