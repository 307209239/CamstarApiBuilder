// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.IssueDetailsQuantity
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
  public class IssueDetailsQuantity : IssueDetails
  {
    [DataMember(EmitDefaultValue = false, Name = "IssueDetailsQuantity_Actuals")]
    protected ActualsQuantity[] _Actuals;
    [DataMember(EmitDefaultValue = false, Name = "IssueDetailsQuantity_IssueControl")]
    protected new Enumeration<IssueControlEnum, int> _IssueControl;

    public override bool Equals(object obj)
    {
      return obj is IssueDetailsQuantity && this.CompareArrays((Array) this._Actuals, (Array) ((IssueDetailsQuantity) obj)._Actuals) && object.Equals((object) this._IssueControl, (object) ((IssueDetailsQuantity) obj)._IssueControl) && base.Equals(obj);
    }

    public ActualsQuantity[] Actuals
    {
      [param: In] set
      {
        this.PropertySet(nameof (Actuals), (object) value);
      }
      get
      {
        return (ActualsQuantity[]) this.PropertyGet(nameof (Actuals));
      }
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
  }
}
