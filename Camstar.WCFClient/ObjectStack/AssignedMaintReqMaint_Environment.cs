// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.AssignedMaintReqMaint_Environment
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
  public class AssignedMaintReqMaint_Environment : SubentityMaintenance_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "AssignedMaintReqMaint_Environment_MaintenanceReq")]
    [Metadata("Defines maintenance requirements for a Resource or MaintenanceClass.", "MaintenanceReq", false, true, false, "RevisionedObjectRef", 1050704, false, false, true, null)]
    protected Environment _MaintenanceReq;
    [DataMember(EmitDefaultValue = false, Name = "AssignedMaintReqMaint_Environment_ObjectToChange")]
    [Metadata("Contains the maintenance statuses created for a requirement.  Once created, activates the requirements, and when deleted deactivates the requirement.", "AssignedMaintReq", false, false, false, "SubentityRef", 1048682, false, false, false, null)]
    protected new Environment _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "AssignedMaintReqMaint_Environment_ObjectChanges")]
    [Metadata("AssignedMaintReqChanges", "AssignedMaintReqChanges", false, false, false, "AssignedMaintReqChanges", 1048873, true, false, false, null)]
    protected AssignedMaintReqChanges_Environment _ObjectChanges;
    [Metadata("BaseObject", "BaseObject", false, false, false, "BaseObjectRef", 1050488, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "AssignedMaintReqMaint_Environment_ParentDataObject")]
    protected new Environment _ParentDataObject;

    public Environment MaintenanceReq
    {
      [param: In] set
      {
        this.PropertySet(nameof (MaintenanceReq), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (MaintenanceReq));
      }
    }

    public new Environment ObjectToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectToChange), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ObjectToChange));
      }
    }

    public AssignedMaintReqChanges_Environment ObjectChanges
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectChanges), (object) value);
      }
      get
      {
        return (AssignedMaintReqChanges_Environment) this.PropertyGet(nameof (ObjectChanges));
      }
    }

    public new Environment ParentDataObject
    {
      [param: In] set
      {
        this.PropertySet(nameof (ParentDataObject), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ParentDataObject));
      }
    }
  }
}
