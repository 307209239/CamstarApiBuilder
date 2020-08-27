// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.RemovalDetailStock
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
  public class RemovalDetailStock : RemovalDetail
  {
    [DataMember(EmitDefaultValue = false, Name = "RemovalDetailStock_IssueControl")]
    protected new Enumeration<IssueControlEnum, int> _IssueControl;
    [DataMember(EmitDefaultValue = false, Name = "RemovalDetailStock_IssueActualHistory")]
    protected new SubentityRef _IssueActualHistory;
    [DataMember(EmitDefaultValue = false, Name = "RemovalDetailStock_DestinationStockPoint")]
    protected Primitive<string> _DestinationStockPoint;

    public override bool Equals(object obj)
    {
      return obj is RemovalDetailStock && object.Equals((object) this._IssueControl, (object) ((RemovalDetailStock) obj)._IssueControl) && (object.Equals((object) this._IssueActualHistory, (object) ((RemovalDetailStock) obj)._IssueActualHistory) && object.Equals((object) this._DestinationStockPoint, (object) ((RemovalDetailStock) obj)._DestinationStockPoint)) && base.Equals(obj);
    }

    public new Enumeration<IssueControlEnum, int> IssueControl
    {
      [param: In] set
      {
        this.PropertySet(nameof (IssueControl), (object) value);
      }
      get
      {
        return (Enumeration<IssueControlEnum, int>) this.PropertyGet(nameof (IssueControl));
      }
    }

    public new SubentityRef IssueActualHistory
    {
      [param: In] set
      {
        this.PropertySet(nameof (IssueActualHistory), (object) value);
      }
      get
      {
        return (SubentityRef) this.PropertyGet(nameof (IssueActualHistory));
      }
    }

    public Primitive<string> DestinationStockPoint
    {
      [param: In] set
      {
        this.PropertySet(nameof (DestinationStockPoint), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (DestinationStockPoint));
      }
    }
  }
}
