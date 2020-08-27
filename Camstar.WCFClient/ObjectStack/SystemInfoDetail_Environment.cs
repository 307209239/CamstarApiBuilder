// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.SystemInfoDetail_Environment
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
  public class SystemInfoDetail_Environment : ServiceData_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "SystemInfoDetail_Environment_InfoName")]
    [Metadata("Generic String", "", false, false, false, "String", 16779293, false, false, false, null)]
    protected Environment _InfoName;
    [Metadata("Generic String", "", false, false, false, "String", 16779292, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "SystemInfoDetail_Environment_InfoSource")]
    protected Environment _InfoSource;
    [DataMember(EmitDefaultValue = false, Name = "SystemInfoDetail_Environment_InfoValue")]
    [Metadata("Generic String", "", false, false, false, "String", 16779294, false, false, false, null)]
    protected Environment _InfoValue;

    public Environment InfoName
    {
      [param: In] set
      {
        this.PropertySet(nameof (InfoName), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (InfoName));
      }
    }

    public Environment InfoSource
    {
      [param: In] set
      {
        this.PropertySet(nameof (InfoSource), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (InfoSource));
      }
    }

    public Environment InfoValue
    {
      [param: In] set
      {
        this.PropertySet(nameof (InfoValue), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (InfoValue));
      }
    }
  }
}
