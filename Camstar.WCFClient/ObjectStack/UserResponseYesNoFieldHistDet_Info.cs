// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.UserResponseYesNoFieldHistDet_Info
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [KnownType(typeof (ReportFiledWithFDAHistDetail_Info))]
  [KnownType(typeof (DeviceEvaluatedHistDetail_Info))]
  [KnownType(typeof (DeviceReturnedHistoryDetail_Info))]
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [KnownType(typeof (DeviceAvailableHistoryDetail_Info))]
  [KnownType(typeof (HealthProfessionalHistDetail_Info))]
  [KnownType(typeof (ProductProblemHistoryDetail_Info))]
  [KnownType(typeof (AdverseEventHistoryDetail_Info))]
  [Serializable]
  public class UserResponseYesNoFieldHistDet_Info : EventCheckBoxFieldHistDetail_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "UserResponseYesNoFieldHistDet_Info_No")]
    protected Info _No;
    [DataMember(EmitDefaultValue = false, Name = "UserResponseYesNoFieldHistDet_Info_Yes")]
    protected Info _Yes;

    public Info No
    {
      [param: In] set
      {
        this.PropertySet(nameof (No), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (No));
      }
    }

    public Info Yes
    {
      [param: In] set
      {
        this.PropertySet(nameof (Yes), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Yes));
      }
    }
  }
}
