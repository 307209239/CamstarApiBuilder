// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.IssueDetailsBulk
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [KnownType(typeof (CompDistributeDetailsBulk))]
  [Serializable]
  public class IssueDetailsBulk : IssueDetails
  {
    [DataMember(EmitDefaultValue = false, Name = "IssueDetailsBulk_Actuals")]
    protected ActualsBulk[] _Actuals;
    [DataMember(EmitDefaultValue = false, Name = "IssueDetailsBulk_IssueControl")]
    protected new Enumeration<IssueControlEnum, int> _IssueControl;

    public override bool Equals(object obj)
    {
      return obj is IssueDetailsBulk && this.CompareArrays((Array) this._Actuals, (Array) ((IssueDetailsBulk) obj)._Actuals) && object.Equals((object) this._IssueControl, (object) ((IssueDetailsBulk) obj)._IssueControl) && base.Equals(obj);
    }

    public ActualsBulk[] Actuals
    {
      [param: In] set
      {
        this.PropertySet(nameof (Actuals), (object) value);
      }
      get
      {
        return (ActualsBulk[]) this.PropertyGet(nameof (Actuals));
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
