// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.UserQueryParameterValues_Environment
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
  public class UserQueryParameterValues_Environment : ServiceDetails_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "UserQueryParameterValues_Environment_ParameterValue")]
    [Metadata("LongString", "", false, false, false, "String", 1051233, false, false, false, null)]
    protected Environment _ParameterValue;
    [Metadata("Unique name for this instance", "", false, false, false, "String", 1048681, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "UserQueryParameterValues_Environment_Name")]
    protected Environment _Name;

    public Environment ParameterValue
    {
      [param: In] set
      {
        this.PropertySet(nameof (ParameterValue), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ParameterValue));
      }
    }

    public Environment Name
    {
      [param: In] set
      {
        this.PropertySet(nameof (Name), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Name));
      }
    }
  }
}
