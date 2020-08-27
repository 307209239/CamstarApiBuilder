// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.MaintReqActivationDetails_Environment
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [KnownType(typeof (ResourceActivationDetails_Environment))]
  [KnownType(typeof (MaintClassActivationDetails_Environment))]
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [Serializable]
  public class MaintReqActivationDetails_Environment : ServiceDetails_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "MaintReqActivationDetails_Environment_MaintenanceClass")]
    [Metadata("Defines the relationship between a Maintenance Requirement and a group of Resources.", "MaintenanceClass", false, false, false, "NamedObjectRef", 1050702, false, false, false, null)]
    protected Environment _MaintenanceClass;
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1052728, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "MaintReqActivationDetails_Environment_OriginalActivated")]
    protected Environment _OriginalActivated;
    [DataMember(EmitDefaultValue = false, Name = "MaintReqActivationDetails_Environment_Activated")]
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1052728, false, false, false, "0")]
    protected Environment _Activated;
    [Metadata("Unique name for this instance", "", false, false, false, "String", 1050700, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "MaintReqActivationDetails_Environment_MaintenanceClassName")]
    protected Environment _MaintenanceClassName;

    public Environment MaintenanceClass
    {
      [param: In] set
      {
        this.PropertySet(nameof (MaintenanceClass), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (MaintenanceClass));
      }
    }

    public Environment OriginalActivated
    {
      [param: In] set
      {
        this.PropertySet(nameof (OriginalActivated), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (OriginalActivated));
      }
    }

    public Environment Activated
    {
      [param: In] set
      {
        this.PropertySet(nameof (Activated), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Activated));
      }
    }

    public Environment MaintenanceClassName
    {
      [param: In] set
      {
        this.PropertySet(nameof (MaintenanceClassName), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (MaintenanceClassName));
      }
    }
  }
}
