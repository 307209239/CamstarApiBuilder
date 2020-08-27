// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.CloseCPStatuses
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
  public class CloseCPStatuses : ChangeStatusTxns
  {
    [DataMember(EmitDefaultValue = false, Name = "CloseCPStatuses_Services")]
    protected CloseCPStatus[] _Services;

    public override bool Equals(object obj)
    {
      return obj is CloseCPStatuses && this.CompareArrays((Array) this._Services, (Array) ((CloseCPStatuses) obj)._Services) && base.Equals(obj);
    }

    public CloseCPStatus[] Services
    {
      [param: In] set
      {
        this.PropertySet(nameof (Services), (object) value);
      }
      get
      {
        return (CloseCPStatus[]) this.PropertyGet(nameof (Services));
      }
    }
  }
}
