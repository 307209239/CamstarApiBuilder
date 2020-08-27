// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.V4_SystemSecurityGroupChanges_Environment
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
  public class V4_SystemSecurityGroupChanges_Environment : NamedDataObjectChanges_Environment
  {
    [Metadata("Name for user security group.", "", false, true, false, "String", 1050092, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "V4_SystemSecurityGroupChanges_Environment_Name")]
    protected new Environment _Name;
    [Metadata("SystemSecurityGroups are NT/Windows 2000 user groups that will be used in InSite for defining security permissions to InSite services.  Before you can grant or deny permissions to a group, you must have it defined both as an InSite SystemSecurityGroup and also as an NT/Windows 2000 user group.\r\n\r\nA system security group provides the ability to grant security permissions for the system security group, rather than individual employees. This saves setup and maintenance time as well as ensuring consistency of security permissions among members of the same group", "V4_SystemSecurityGroup", false, false, false, "NamedObjectRef", 1048682, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "V4_SystemSecurityGroupChanges_Environment_ObjectToChange")]
    protected new Environment _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "V4_SystemSecurityGroupChanges_Environment_FullName")]
    [Metadata("User Name", "", false, false, false, "String", 1048617, false, false, false, null)]
    protected Environment _FullName;
    [DataMember(EmitDefaultValue = false, Name = "V4_SystemSecurityGroupChanges_Environment_DomainName")]
    [Metadata("Unique name for this instance", "", false, false, false, "String", 1049713, false, false, false, null)]
    protected Environment _DomainName;

    public new Environment Name
    {
      [param: In] set
      {
        this.PropertySet(nameof (Name), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Name));
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

    public Environment FullName
    {
      [param: In] set
      {
        this.PropertySet(nameof (FullName), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (FullName));
      }
    }

    public Environment DomainName
    {
      [param: In] set
      {
        this.PropertySet(nameof (DomainName), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (DomainName));
      }
    }
  }
}
