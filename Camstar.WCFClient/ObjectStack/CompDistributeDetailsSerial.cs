// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.CompDistributeDetailsSerial
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
  public class CompDistributeDetailsSerial : IssueDetailsSerial
  {
    [DataMember(EmitDefaultValue = false, Name = "CompDistributeDetailsSerial_Actuals")]
    protected CompDistributeActualSerial[] _Actuals;

    public override bool Equals(object obj)
    {
      return obj is CompDistributeDetailsSerial && this.CompareArrays((Array) this._Actuals, (Array) ((CompDistributeDetailsSerial) obj)._Actuals) && base.Equals(obj);
    }

    public CompDistributeActualSerial[] Actuals
    {
      [param: In] set
      {
        this.PropertySet(nameof (Actuals), (object) value);
      }
      get
      {
        return (CompDistributeActualSerial[]) this.PropertyGet(nameof (Actuals));
      }
    }
  }
}
