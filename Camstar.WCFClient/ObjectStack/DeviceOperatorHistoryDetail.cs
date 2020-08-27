// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.DeviceOperatorHistoryDetail
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
  public class DeviceOperatorHistoryDetail : OtherCheckBoxFieldHistDetail
  {
    [DataMember(EmitDefaultValue = false, Name = "DeviceOperatorHistoryDetail_HealthProfessional")]
    protected Primitive<bool> _HealthProfessional;
    [DataMember(EmitDefaultValue = false, Name = "DeviceOperatorHistoryDetail_LayUserPatient")]
    protected Primitive<bool> _LayUserPatient;
    [DataMember(EmitDefaultValue = false, Name = "DeviceOperatorHistoryDetail_Unknown")]
    protected Primitive<bool> _Unknown;

    public override bool Equals(object obj)
    {
      return obj is DeviceOperatorHistoryDetail && object.Equals((object) this._HealthProfessional, (object) ((DeviceOperatorHistoryDetail) obj)._HealthProfessional) && (object.Equals((object) this._LayUserPatient, (object) ((DeviceOperatorHistoryDetail) obj)._LayUserPatient) && object.Equals((object) this._Unknown, (object) ((DeviceOperatorHistoryDetail) obj)._Unknown)) && base.Equals(obj);
    }

    public Primitive<bool> HealthProfessional
    {
      [param: In] set
      {
        this.PropertySet(nameof (HealthProfessional), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (HealthProfessional));
      }
    }

    public Primitive<bool> LayUserPatient
    {
      [param: In] set
      {
        this.PropertySet(nameof (LayUserPatient), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (LayUserPatient));
      }
    }

    public Primitive<bool> Unknown
    {
      [param: In] set
      {
        this.PropertySet(nameof (Unknown), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (Unknown));
      }
    }
  }
}
