// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.CompDistributeDetailsBulk
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
  public class CompDistributeDetailsBulk : IssueDetailsBulk
  {
    [DataMember(EmitDefaultValue = false, Name = "CompDistributeDetailsBulk_Actuals")]
    protected CompDistributeActualBulk[] _Actuals;

    public override bool Equals(object obj)
    {
      return obj is CompDistributeDetailsBulk && this.CompareArrays((Array) this._Actuals, (Array) ((CompDistributeDetailsBulk) obj)._Actuals) && base.Equals(obj);
    }

    public CompDistributeActualBulk[] Actuals
    {
      [param: In] set
      {
        this.PropertySet(nameof (Actuals), (object) value);
      }
      get
      {
        return (CompDistributeActualBulk[]) this.PropertyGet(nameof (Actuals));
      }
    }
  }
}
