// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.MaintReqActivationDetails
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [KnownType(typeof (ResourceActivationDetails))]
  [KnownType(typeof (MaintClassActivationDetails))]
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [Serializable]
  public class MaintReqActivationDetails : ServiceDetails
  {
    [DataMember(EmitDefaultValue = false, Name = "MaintReqActivationDetails_MaintenanceClass")]
    protected NamedObjectRef _MaintenanceClass;
    [DataMember(EmitDefaultValue = false, Name = "MaintReqActivationDetails_OriginalActivated")]
    protected Primitive<bool> _OriginalActivated;
    [DataMember(EmitDefaultValue = false, Name = "MaintReqActivationDetails_Activated")]
    protected Primitive<bool> _Activated;
    [DataMember(EmitDefaultValue = false, Name = "MaintReqActivationDetails_MaintenanceClassName")]
    protected Primitive<string> _MaintenanceClassName;

    public override bool Equals(object obj)
    {
      return obj is MaintReqActivationDetails && object.Equals((object) this._MaintenanceClass, (object) ((MaintReqActivationDetails) obj)._MaintenanceClass) && (object.Equals((object) this._OriginalActivated, (object) ((MaintReqActivationDetails) obj)._OriginalActivated) && object.Equals((object) this._Activated, (object) ((MaintReqActivationDetails) obj)._Activated)) && object.Equals((object) this._MaintenanceClassName, (object) ((MaintReqActivationDetails) obj)._MaintenanceClassName) && base.Equals(obj);
    }

    public NamedObjectRef MaintenanceClass
    {
      [param: In] set
      {
        this.PropertySet(nameof (MaintenanceClass), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (MaintenanceClass));
      }
    }

    public Primitive<bool> OriginalActivated
    {
      [param: In] set
      {
        this.PropertySet(nameof (OriginalActivated), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (OriginalActivated));
      }
    }

    public Primitive<bool> Activated
    {
      [param: In] set
      {
        this.PropertySet(nameof (Activated), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (Activated));
      }
    }

    public Primitive<string> MaintenanceClassName
    {
      [param: In] set
      {
        this.PropertySet(nameof (MaintenanceClassName), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (MaintenanceClassName));
      }
    }
  }
}
