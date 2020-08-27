// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.AssignedMaintReqMaint
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
  public class AssignedMaintReqMaint : SubentityMaintenance
  {
    [DataMember(EmitDefaultValue = false, Name = "AssignedMaintReqMaint_MaintenanceReq")]
    protected RevisionedObjectRef _MaintenanceReq;
    [DataMember(EmitDefaultValue = false, Name = "AssignedMaintReqMaint_ObjectToChange")]
    protected new SubentityRef _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "AssignedMaintReqMaint_ObjectChanges")]
    protected AssignedMaintReqChanges _ObjectChanges;
    [DataMember(EmitDefaultValue = false, Name = "AssignedMaintReqMaint_ParentDataObject")]
    protected new BaseObjectRef _ParentDataObject;

    public override bool Equals(object obj)
    {
      return obj is AssignedMaintReqMaint && object.Equals((object) this._MaintenanceReq, (object) ((AssignedMaintReqMaint) obj)._MaintenanceReq) && (object.Equals((object) this._ObjectToChange, (object) ((AssignedMaintReqMaint) obj)._ObjectToChange) && object.Equals((object) this._ObjectChanges, (object) ((AssignedMaintReqMaint) obj)._ObjectChanges)) && object.Equals((object) this._ParentDataObject, (object) ((AssignedMaintReqMaint) obj)._ParentDataObject) && base.Equals(obj);
    }

    public RevisionedObjectRef MaintenanceReq
    {
      [param: In] set
      {
        this.PropertySet(nameof (MaintenanceReq), (object) value);
      }
      get
      {
        return (RevisionedObjectRef) this.PropertyGet(nameof (MaintenanceReq));
      }
    }

    public new SubentityRef ObjectToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectToChange), (object) value);
      }
      get
      {
        return (SubentityRef) this.PropertyGet(nameof (ObjectToChange));
      }
    }

    public AssignedMaintReqChanges ObjectChanges
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectChanges), (object) value);
      }
      get
      {
        return (AssignedMaintReqChanges) this.PropertyGet(nameof (ObjectChanges));
      }
    }

    public new BaseObjectRef ParentDataObject
    {
      [param: In] set
      {
        this.PropertySet(nameof (ParentDataObject), (object) value);
      }
      get
      {
        return (BaseObjectRef) this.PropertyGet(nameof (ParentDataObject));
      }
    }
  }
}
