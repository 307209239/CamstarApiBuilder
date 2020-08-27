// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.TargetSystemDetail_Info
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
  public class TargetSystemDetail_Info : ServiceDetails_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "TargetSystemDetail_Info_TargetSystem")]
    protected TargetSystem_Info _TargetSystem;
    [DataMember(EmitDefaultValue = false, Name = "TargetSystemDetail_Info_IsTargetSelected")]
    protected Info _IsTargetSelected;
    [DataMember(EmitDefaultValue = false, Name = "TargetSystemDetail_Info_TargetSystemName")]
    protected Info _TargetSystemName;

    public TargetSystem_Info TargetSystem
    {
      [param: In] set
      {
        this.PropertySet(nameof (TargetSystem), (object) value);
      }
      get
      {
        return (TargetSystem_Info) this.PropertyGet(nameof (TargetSystem));
      }
    }

    public Info IsTargetSelected
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsTargetSelected), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (IsTargetSelected));
      }
    }

    public Info TargetSystemName
    {
      [param: In] set
      {
        this.PropertySet(nameof (TargetSystemName), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (TargetSystemName));
      }
    }
  }
}
