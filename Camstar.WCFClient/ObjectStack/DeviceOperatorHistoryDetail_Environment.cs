// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.DeviceOperatorHistoryDetail_Environment
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
  public class DeviceOperatorHistoryDetail_Environment : OtherCheckBoxFieldHistDetail_Environment
  {
    [Metadata("Generic Boolean", "", false, false, true, "Boolean", 1051305, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "DeviceOperatorHistoryDetail_Environment_HealthProfessional")]
    protected Environment _HealthProfessional;
    [DataMember(EmitDefaultValue = false, Name = "DeviceOperatorHistoryDetail_Environment_LayUserPatient")]
    [Metadata("Generic Boolean", "", false, false, true, "Boolean", 1051306, false, false, false, "0")]
    protected Environment _LayUserPatient;
    [DataMember(EmitDefaultValue = false, Name = "DeviceOperatorHistoryDetail_Environment_Unknown")]
    [Metadata("Generic Boolean", "", false, false, true, "Boolean", 1052239, false, false, false, "0")]
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
