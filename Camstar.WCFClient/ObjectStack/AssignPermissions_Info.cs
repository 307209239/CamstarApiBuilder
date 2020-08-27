// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.AssignPermissions_Info
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
  public class AssignPermissions_Info : ShopFloor_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "AssignPermissions_Info_Role")]
    protected Info _Role;
    [DataMember(EmitDefaultValue = false, Name = "AssignPermissions_Info_ObjectInstanceId")]
    protected Info _ObjectInstanceId;
    [DataMember(EmitDefaultValue = false, Name = "AssignPermissions_Info_ServiceDetails")]
    protected PermissionDetail_Info _ServiceDetails;

    public Info Role
    {
      [param: In] set
      {
        this.PropertySet(nameof (Role), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Role));
      }
    }

    public Info ObjectInstanceId
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectInstanceId), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ObjectInstanceId));
      }
    }

    public PermissionDetail_Info ServiceDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (ServiceDetails), (object) value);
      }
      get
      {
        return (PermissionDetail_Info) this.PropertyGet(nameof (ServiceDetails));
      }
    }
  }
}
