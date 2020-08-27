// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ESigRoleGroupMaint_Environment
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
  public class ESigRoleGroupMaint_Environment : NamedObjectGroupMaint_Environment
  {
    [Metadata("The grouping mechanism used to assign multiple Roles  to an Employee.", "ESigRoleGroup", false, false, false, "NamedObjectRef", 1048682, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "ESigRoleGroupMaint_Environment_ObjectToChange")]
    protected new Environment _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "ESigRoleGroupMaint_Environment_ObjectListInquiry")]
    [Metadata("The grouping mechanism used to assign multiple Roles  to an Employee.", "ESigRoleGroup", false, false, true, "NamedObjectRef", 1048874, false, true, true, null)]
    protected new Environment _ObjectListInquiry;
    [Metadata("The grouping mechanism used to assign multiple Roles  to an Employee.", "ESigRoleGroupChanges", false, false, false, "ESigRoleGroupChanges", 1048873, true, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ESigRoleGroupMaint_Environment_ObjectChanges")]
    protected ESigRoleGroupChanges_Environment _ObjectChanges;

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

    public ESigRoleGroupChanges_Environment ObjectChanges
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectChanges), (object) value);
      }
      get
      {
        return (ESigRoleGroupChanges_Environment) this.PropertyGet(nameof (ObjectChanges));
      }
    }
  }
}
