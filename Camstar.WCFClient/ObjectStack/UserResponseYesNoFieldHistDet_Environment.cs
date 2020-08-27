// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.UserResponseYesNoFieldHistDet_Environment
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [KnownType(typeof (HealthProfessionalHistDetail_Environment))]
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [KnownType(typeof (DeviceEvaluatedHistDetail_Environment))]
  [KnownType(typeof (DeviceReturnedHistoryDetail_Environment))]
  [KnownType(typeof (DeviceAvailableHistoryDetail_Environment))]
  [KnownType(typeof (ProductProblemHistoryDetail_Environment))]
  [KnownType(typeof (ReportFiledWithFDAHistDetail_Environment))]
  [KnownType(typeof (AdverseEventHistoryDetail_Environment))]
  [Serializable]
  public class UserResponseYesNoFieldHistDet_Environment : EventCheckBoxFieldHistDetail_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "UserResponseYesNoFieldHistDet_Environment_No")]
    [Metadata("Generic Boolean", "", false, false, true, "Boolean", 1051303, false, false, false, "0")]
    protected Environment _No;
    [Metadata("Generic Boolean", "", false, false, true, "Boolean", 1051304, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "UserResponseYesNoFieldHistDet_Environment_Yes")]
    protected Environment _Yes;

    public Environment No
    {
      [param: In] set
      {
        this.PropertySet(nameof (No), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (No));
      }
    }

    public Environment Yes
    {
      [param: In] set
      {
        this.PropertySet(nameof (Yes), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Yes));
      }
    }
  }
}
