// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.AssignPermissions_Environment
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
  public class AssignPermissions_Environment : ShopFloor_Environment
  {
    [Metadata("A role is a definition of a job function, for example the role of Regulatory Affairs Manager.\r\nA role that must be assigned to an Employee using an ESig role group in order to sign off for an Electronic Signature requirement.", "Role", false, false, true, "NamedObjectRef", 1050342, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "AssignPermissions_Environment_Role")]
    protected Environment _Role;
    [Metadata("Base class for the UI Personalization Persistence Provider components.", "UIProviderComponent", false, true, false, "NamedObjectRef", 1052438, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "AssignPermissions_Environment_ObjectInstanceId")]
    protected Environment _ObjectInstanceId;
    [DataMember(EmitDefaultValue = false, Name = "AssignPermissions_Environment_ServiceDetails")]
    [Metadata("Used to add/update permission for a role to the securable object.", "PermissionDetail", false, false, false, "PermissionDetail", 1052439, false, true, false, null)]
    protected PermissionDetail_Environment _ServiceDetails;

    public Environment Role
    {
      [param: In] set
      {
        this.PropertySet(nameof (Role), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Role));
      }
    }

    public Environment ObjectInstanceId
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectInstanceId), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ObjectInstanceId));
      }
    }

    public PermissionDetail_Environment ServiceDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (ServiceDetails), (object) value);
      }
      get
      {
        return (PermissionDetail_Environment) this.PropertyGet(nameof (ServiceDetails));
      }
    }
  }
}
