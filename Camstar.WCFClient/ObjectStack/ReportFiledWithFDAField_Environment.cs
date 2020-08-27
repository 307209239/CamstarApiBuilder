// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ReportFiledWithFDAField_Environment
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
  public class ReportFiledWithFDAField_Environment : UserResponseYesNoField_Environment
  {
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1052239, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "ReportFiledWithFDAField_Environment_Unknown")]
    protected Environment _Unknown;

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
