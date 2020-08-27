// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.TargetSystemDetail_Environment
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
  public class TargetSystemDetail_Environment : ServiceDetails_Environment
  {
    [Metadata("Identifies a system as a target for various purposes such as export.  ", "TargetSystem", false, false, false, "TargetSystem", 1053228, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "TargetSystemDetail_Environment_TargetSystem")]
    protected TargetSystem_Environment _TargetSystem;
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 16777295, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "TargetSystemDetail_Environment_IsTargetSelected")]
    protected Environment _IsTargetSelected;
    [DataMember(EmitDefaultValue = false, Name = "TargetSystemDetail_Environment_TargetSystemName")]
    [Metadata("Unique name for this instance", "", false, false, false, "String", 16777631, false, false, false, null)]
    protected Environment _TargetSystemName;

    public TargetSystem_Environment TargetSystem
    {
      [param: In] set
      {
        this.PropertySet(nameof (TargetSystem), (object) value);
      }
      get
      {
        return (TargetSystem_Environment) this.PropertyGet(nameof (TargetSystem));
      }
    }

    public Environment IsTargetSelected
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsTargetSelected), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (IsTargetSelected));
      }
    }

    public Environment TargetSystemName
    {
      [param: In] set
      {
        this.PropertySet(nameof (TargetSystemName), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (TargetSystemName));
      }
    }
  }
}
