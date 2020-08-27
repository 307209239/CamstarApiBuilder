// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.DeviceOperatorField_Environment
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
  public class DeviceOperatorField_Environment : OtherCheckBoxField_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "DeviceOperatorField_Environment_HealthProfessional")]
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1051305, false, false, false, "0")]
    protected Environment _HealthProfessional;
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1051306, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "DeviceOperatorField_Environment_LayUserPatient")]
    protected Environment _LayUserPatient;
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1052239, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "DeviceOperatorField_Environment_Unknown")]
    protected Environment _Unknown;

    public Environment HealthProfessional
    {
      [param: In] set
      {
        this.PropertySet(nameof (HealthProfessional), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (HealthProfessional));
      }
    }

    public Environment LayUserPatient
    {
      [param: In] set
      {
        this.PropertySet(nameof (LayUserPatient), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (LayUserPatient));
      }
    }

    public Environment Unknown
    {
      [param: In] set
      {
        this.PropertySet(nameof (Unknown), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Unknown));
      }
    }
  }
}
