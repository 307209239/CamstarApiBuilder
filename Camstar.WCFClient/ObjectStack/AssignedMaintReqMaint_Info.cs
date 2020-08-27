// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.AssignedMaintReqMaint_Info
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
  public class AssignedMaintReqMaint_Info : SubentityMaintenance_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "AssignedMaintReqMaint_Info_MaintenanceReq")]
    protected Info _MaintenanceReq;
    [DataMember(EmitDefaultValue = false, Name = "AssignedMaintReqMaint_Info_ObjectToChange")]
    protected new Info _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "AssignedMaintReqMaint_Info_ObjectChanges")]
    protected AssignedMaintReqChanges_Info _ObjectChanges;
    [DataMember(EmitDefaultValue = false, Name = "AssignedMaintReqMaint_Info_ParentDataObject")]
    protected new Info _ParentDataObject;

    public Info MaintenanceReq
    {
      [param: In] set
      {
        this.PropertySet(nameof (MaintenanceReq), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (MaintenanceReq));
      }
    }

    public new Info ObjectToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectToChange), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ObjectToChange));
      }
    }

    public AssignedMaintReqChanges_Info ObjectChanges
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectChanges), (object) value);
      }
      get
      {
        return (AssignedMaintReqChanges_Info) this.PropertyGet(nameof (ObjectChanges));
      }
    }

    public new Info ParentDataObject
    {
      [param: In] set
      {
        this.PropertySet(nameof (ParentDataObject), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ParentDataObject));
      }
    }
  }
}
