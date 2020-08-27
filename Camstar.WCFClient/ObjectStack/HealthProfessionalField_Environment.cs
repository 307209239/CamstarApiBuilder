// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.HealthProfessionalField_Environment
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
  public class HealthProfessionalField_Environment : UserResponseYesNoField_Environment
  {
    [Metadata("A list of jobs available for selection in the MedWatch report.", "Occupation", false, false, false, "NamedObjectRef", 1051269, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "HealthProfessionalField_Environment_Occupation")]
    protected Environment _Occupation;

    public Environment Occupation
    {
      [param: In] set
      {
        this.PropertySet(nameof (Occupation), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Occupation));
      }
    }
  }
}
