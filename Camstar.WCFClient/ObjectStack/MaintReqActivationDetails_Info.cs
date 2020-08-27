// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.MaintReqActivationDetails_Info
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [KnownType(typeof (ResourceActivationDetails_Info))]
  [KnownType(typeof (MaintClassActivationDetails_Info))]
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [Serializable]
  public class MaintReqActivationDetails_Info : ServiceDetails_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "MaintReqActivationDetails_Info_MaintenanceClass")]
    protected Info _MaintenanceClass;
    [DataMember(EmitDefaultValue = false, Name = "MaintReqActivationDetails_Info_OriginalActivated")]
    protected Info _OriginalActivated;
    [DataMember(EmitDefaultValue = false, Name = "MaintReqActivationDetails_Info_Activated")]
    protected Info _Activated;
    [DataMember(EmitDefaultValue = false, Name = "MaintReqActivationDetails_Info_MaintenanceClassName")]
    protected Info _MaintenanceClassName;

    public Info MaintenanceClass
    {
      [param: In] set
      {
        this.PropertySet(nameof (MaintenanceClass), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (MaintenanceClass));
      }
    }

    public Info OriginalActivated
    {
      [param: In] set
      {
        this.PropertySet(nameof (OriginalActivated), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (OriginalActivated));
      }
    }

    public Info Activated
    {
      [param: In] set
      {
        this.PropertySet(nameof (Activated), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Activated));
      }
    }

    public Info MaintenanceClassName
    {
      [param: In] set
      {
        this.PropertySet(nameof (MaintenanceClassName), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (MaintenanceClassName));
      }
    }
  }
}
