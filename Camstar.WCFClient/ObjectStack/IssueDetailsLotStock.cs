// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.IssueDetailsLotStock
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
  public class IssueDetailsLotStock : IssueDetails
  {
    [DataMember(EmitDefaultValue = false, Name = "IssueDetailsLotStock_IssueControl")]
    protected new Enumeration<IssueControlEnum, int> _IssueControl;
    [DataMember(EmitDefaultValue = false, Name = "IssueDetailsLotStock_Actuals")]
    protected ActualsLotStock[] _Actuals;

    public override bool Equals(object obj)
    {
      return obj is IssueDetailsLotStock && object.Equals((object) this._IssueControl, (object) ((IssueDetailsLotStock) obj)._IssueControl) && this.CompareArrays((Array) this._Actuals, (Array) ((IssueDetailsLotStock) obj)._Actuals) && base.Equals(obj);
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

    public ActualsLotStock[] Actuals
    {
      [param: In] set
      {
        this.PropertySet(nameof (Actuals), (object) value);
      }
      get
      {
        return (ActualsLotStock[]) this.PropertyGet(nameof (Actuals));
      }
    }
  }
}
