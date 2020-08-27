// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.OpenCPStatuses
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
  public class OpenCPStatuses : ChangeStatusTxns
  {
    [DataMember(EmitDefaultValue = false, Name = "OpenCPStatuses_Services")]
    protected OpenCPStatus[] _Services;

    public override bool Equals(object obj)
    {
      return obj is OpenCPStatuses && this.CompareArrays((Array) this._Services, (Array) ((OpenCPStatuses) obj)._Services) && base.Equals(obj);
    }

    public OpenCPStatus[] Services
    {
      [param: In] set
      {
        this.PropertySet(nameof (Services), (object) value);
      }
      get
      {
        return (OpenCPStatus[]) this.PropertyGet(nameof (Services));
      }
    }
  }
}
