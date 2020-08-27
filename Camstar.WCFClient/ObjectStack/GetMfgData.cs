// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.GetMfgData
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
  public class GetMfgData : Inquiry
  {
    [DataMember(EmitDefaultValue = false, Name = "GetMfgData_MfgDataDetails")]
    protected MfgDataDetail[] _MfgDataDetails;

    public override bool Equals(object obj)
    {
      return obj is GetMfgData && this.CompareArrays((Array) this._MfgDataDetails, (Array) ((GetMfgData) obj)._MfgDataDetails) && base.Equals(obj);
    }

    public MfgDataDetail[] MfgDataDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (MfgDataDetails), (object) value);
      }
      get
      {
        return (MfgDataDetail[]) this.PropertyGet(nameof (MfgDataDetails));
      }
    }
  }
}
