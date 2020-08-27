// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.UserQueryParameterValues_Info
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
  public class UserQueryParameterValues_Info : ServiceDetails_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "UserQueryParameterValues_Info_ParameterValue")]
    protected Info _ParameterValue;
    [DataMember(EmitDefaultValue = false, Name = "UserQueryParameterValues_Info_Name")]
    protected Info _Name;

    public Info ParameterValue
    {
      [param: In] set
      {
        this.PropertySet(nameof (ParameterValue), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ParameterValue));
      }
    }

    public Info Name
    {
      [param: In] set
      {
        this.PropertySet(nameof (Name), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Name));
      }
    }
  }
}
