// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.DeviceOperatorField_Info
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
  public class DeviceOperatorField_Info : OtherCheckBoxField_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "DeviceOperatorField_Info_HealthProfessional")]
    protected Info _HealthProfessional;
    [DataMember(EmitDefaultValue = false, Name = "DeviceOperatorField_Info_LayUserPatient")]
    protected Info _LayUserPatient;
    [DataMember(EmitDefaultValue = false, Name = "DeviceOperatorField_Info_Unknown")]
    protected Info _Unknown;

    public Info HealthProfessional
    {
      [param: In] set
      {
        this.PropertySet(nameof (HealthProfessional), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (HealthProfessional));
      }
    }

    public Info LayUserPatient
    {
      [param: In] set
      {
        this.PropertySet(nameof (LayUserPatient), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (LayUserPatient));
      }
    }

    public Info Unknown
    {
      [param: In] set
      {
        this.PropertySet(nameof (Unknown), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Unknown));
      }
    }
  }
}
