// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.IssueActualsHistoryStock
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
  public class IssueActualsHistoryStock : IssueActualsHistory
  {
    [DataMember(EmitDefaultValue = false, Name = "IssueActualsHistoryStock_IssuedFrom")]
    protected new Primitive<string> _IssuedFrom;
    [DataMember(EmitDefaultValue = false, Name = "IssueActualsHistoryStock_FromStockPoint")]
    protected Primitive<string> _FromStockPoint;

    public override bool Equals(object obj)
    {
      return obj is IssueActualsHistoryStock && object.Equals((object) this._IssuedFrom, (object) ((IssueActualsHistoryStock) obj)._IssuedFrom) && object.Equals((object) this._FromStockPoint, (object) ((IssueActualsHistoryStock) obj)._FromStockPoint) && base.Equals(obj);
    }

    public new Primitive<string> IssuedFrom
    {
      [param: In] set
      {
        this.PropertySet(nameof (IssuedFrom), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (IssuedFrom));
      }
    }

    public Primitive<string> FromStockPoint
    {
      [param: In] set
      {
        this.PropertySet(nameof (FromStockPoint), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (FromStockPoint));
      }
    }
  }
}
