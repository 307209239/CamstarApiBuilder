// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.SystemInfoDetail_Info
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
  public class SystemInfoDetail_Info : ServiceData_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "SystemInfoDetail_Info_InfoName")]
    protected Info _InfoName;
    [DataMember(EmitDefaultValue = false, Name = "SystemInfoDetail_Info_InfoSource")]
    protected Info _InfoSource;
    [DataMember(EmitDefaultValue = false, Name = "SystemInfoDetail_Info_InfoValue")]
    protected Info _InfoValue;

    public Info InfoName
    {
      [param: In] set
      {
        this.PropertySet(nameof (InfoName), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (InfoName));
      }
    }

    public Info InfoSource
    {
      [param: In] set
      {
        this.PropertySet(nameof (InfoSource), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (InfoSource));
      }
    }

    public Info InfoValue
    {
      [param: In] set
      {
        this.PropertySet(nameof (InfoValue), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (InfoValue));
      }
    }
  }
}
