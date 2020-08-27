// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.UserResponseYesNoField_Environment
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [KnownType(typeof (DeviceReturnedField_Environment))]
  [KnownType(typeof (ReportFiledWithFDAField_Environment))]
  [KnownType(typeof (DeviceEvaluatedField_Environment))]
  [KnownType(typeof (DeviceAvailableField_Environment))]
  [KnownType(typeof (ProductProblemField_Environment))]
  [KnownType(typeof (HealthProfessionalField_Environment))]
  [KnownType(typeof (AdverseEventField_Environment))]
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [Serializable]
  public class UserResponseYesNoField_Environment : EventCheckBoxField_Environment
  {
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1051303, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "UserResponseYesNoField_Environment_No")]
    protected Environment _No;
    [DataMember(EmitDefaultValue = false, Name = "UserResponseYesNoField_Environment_Yes")]
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1051304, false, false, false, "0")]
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
