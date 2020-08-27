// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.HealthProfessionalHistDetail_Info
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
  public class HealthProfessionalHistDetail_Info : UserResponseYesNoFieldHistDet_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "HealthProfessionalHistDetail_Info_Occupation")]
    protected Info _Occupation;

    public Info Occupation
    {
      [param: In] set
      {
        this.PropertySet(nameof (Occupation), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Occupation));
      }
    }
  }
}
