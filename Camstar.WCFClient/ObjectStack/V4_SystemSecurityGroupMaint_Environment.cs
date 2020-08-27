// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.V4_SystemSecurityGroupMaint_Environment
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
  public class V4_SystemSecurityGroupMaint_Environment : NamedDataObjectMaint_Environment
  {
    [Metadata("SystemSecurityGroups are NT/Windows 2000 user groups that will be used in InSite for defining security permissions to InSite services.  Before you can grant or deny permissions to a group, you must have it defined both as an InSite SystemSecurityGroup and also as an NT/Windows 2000 user group.\r\n\r\nA system security group provides the ability to grant security permissions for the system security group, rather than individual employees. This saves setup and maintenance time as well as ensuring consistency of security permissions among members of the same group", "V4_SystemSecurityGroup", false, false, true, "NamedObjectRef", 1048874, false, true, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "V4_SystemSecurityGroupMaint_Environment_ObjectListInquiry")]
    protected new Environment _ObjectListInquiry;
    [Metadata("Changes CDO for maintaining user groups", "V4_SystemSecurityGroupChanges", false, false, false, "V4_SystemSecurityGroupChanges", 1048873, true, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "V4_SystemSecurityGroupMaint_Environment_ObjectChanges")]
    protected V4_SystemSecurityGroupChanges_Environment _ObjectChanges;
    [Metadata("SystemSecurityGroups are NT/Windows 2000 user groups that will be used in InSite for defining security permissions to InSite services.  Before you can grant or deny permissions to a group, you must have it defined both as an InSite SystemSecurityGroup and also as an NT/Windows 2000 user group.\r\n\r\nA system security group provides the ability to grant security permissions for the system security group, rather than individual employees. This saves setup and maintenance time as well as ensuring consistency of security permissions among members of the same group", "V4_SystemSecurityGroup", false, false, false, "NamedObjectRef", 1048682, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "V4_SystemSecurityGroupMaint_Environment_ObjectToChange")]
    protected new Environment _ObjectToChange;

    public new Environment ObjectListInquiry
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectListInquiry), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ObjectListInquiry));
      }
    }

    public V4_SystemSecurityGroupChanges_Environment ObjectChanges
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectChanges), (object) value);
      }
      get
      {
        return (V4_SystemSecurityGroupChanges_Environment) this.PropertyGet(nameof (ObjectChanges));
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
  }
}
