// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.HealthProfessionalHistDetail
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
  public class HealthProfessionalHistDetail : UserResponseYesNoFieldHistDet
  {
    [DataMember(EmitDefaultValue = false, Name = "HealthProfessionalHistDetail_Occupation")]
    protected NamedObjectRef _Occupation;

    public override bool Equals(object obj)
    {
      return obj is HealthProfessionalHistDetail && object.Equals((object) this._Occupation, (object) ((HealthProfessionalHistDetail) obj)._Occupation) && base.Equals(obj);
    }

    public NamedObjectRef Occupation
    {
      [param: In] set
      {
        this.PropertySet(nameof (Occupation), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (Occupation));
      }
    }
  }
}
