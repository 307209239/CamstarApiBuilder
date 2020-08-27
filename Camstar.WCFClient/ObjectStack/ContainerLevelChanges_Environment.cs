// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ContainerLevelChanges_Environment
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
  public class ContainerLevelChanges_Environment : NamedDataObjectChanges_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "ContainerLevelChanges_Environment_UIPreference")]
    [Metadata("The UI (User Interface) Preference object is used to store a user configured set of fields for a container.  This set of fields is displayed in the \"current\" information section for a container by the Live Manufacturing Audit Trail application.", "UIPreference", false, false, false, "NamedObjectRef", 1050042, false, false, true, null)]
    protected Environment _UIPreference;
    [Metadata("Allows maintenance of the WIP Messages for a modeling entity.", "WIPMsgDefMgrChanges", false, false, false, "WIPMsgDefMgrChanges", 1048768, true, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ContainerLevelChanges_Environment_WIPMsgDefMgr")]
    protected WIPMsgDefMgrChanges_Environment _WIPMsgDefMgr;
    [DataMember(EmitDefaultValue = false, Name = "ContainerLevelChanges_Environment_WIPMsgConfig")]
    [Metadata("Changes CDO for WIPMsgConfig.", "WIPMsgConfigChanges", false, false, false, "WIPMsgConfigChanges", 1048907, true, false, false, null)]
    protected WIPMsgConfigChanges_Environment _WIPMsgConfig;
    [DataMember(EmitDefaultValue = false, Name = "ContainerLevelChanges_Environment_Attributes")]
    [Metadata("A user attribute is used to record a single value, identified by a unique name and attached to an object as a list.  This is different from a set of single fields because the attributes can be different based on many factors, such as product or factory.", "UserAttributeChanges", false, false, false, "UserAttributeChanges", 1051932, false, true, false, null)]
    protected UserAttributeChanges_Environment _Attributes;
    [DataMember(EmitDefaultValue = false, Name = "ContainerLevelChanges_Environment_ContainerNumberingRule")]
    [Metadata("This service is used to maintain properties that will be used to auto generate names.", "NumberingRule", false, false, false, "NamedObjectRef", 1051905, false, false, true, null)]
    protected Environment _ContainerNumberingRule;
    [DataMember(EmitDefaultValue = false, Name = "ContainerLevelChanges_Environment_IsNameUnique")]
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1048704, false, false, false, "0")]
    protected Environment _IsNameUnique;
    [Metadata("Generic Boolean", "", false, false, false, "Boolean", 1048703, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "ContainerLevelChanges_Environment_AllowMove")]
    protected Environment _AllowMove;
    [Metadata("Unique name for this instance", "", false, true, false, "String", 1050055, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ContainerLevelChanges_Environment_Name")]
    protected new Environment _Name;
    [Metadata("A Container Level is the tracking designation assigned to a container. The level identifies the position of the container within a container structure. A container is defined within InSite as a discrete collection of products produced in a factory. \r\n\r\nEach container has a unique identifier used for traceability and performance of shop floor transactions. Commonly used level names are batch and lot. Container Levels are defined to meet the specific requirements of each company. Examples of some industry-specific levels are roll, bin, and cassette. \r\nMany companies also track smaller levels within the larger, parent container. With InSite, this is accomplished through multi-level tracking. Parent and child level containers are associated using the Associate, Combine or Group Start transactions. For example, a group of containers can have a parent with a batch level and associated child containers with tray levels. Container groups can also have more than two levels.", "ContainerLevel", false, false, false, "NamedObjectRef", 1048682, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "ContainerLevelChanges_Environment_ObjectToChange")]
    protected new Environment _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "ContainerLevelChanges_Environment_ChildLevels")]
    [Metadata("A Container Level is the tracking designation assigned to a container. The level identifies the position of the container within a container structure. A container is defined within InSite as a discrete collection of products produced in a factory. \r\n\r\nEach container has a unique identifier used for traceability and performance of shop floor transactions. Commonly used level names are batch and lot. Container Levels are defined to meet the specific requirements of each company. Examples of some industry-specific levels are roll, bin, and cassette. \r\nMany companies also track smaller levels within the larger, parent container. With InSite, this is accomplished through multi-level tracking. Parent and child level containers are associated using the Associate, Combine or Group Start transactions. For example, a group of containers can have a parent with a batch level and associated child containers with tray levels. Container groups can also have more than two levels.", "ContainerLevel", false, false, false, "NamedObjectRef", 1048905, false, true, true, null)]
    protected Environment _ChildLevels;
    [Metadata("A Container Level is the tracking designation assigned to a container. The level identifies the position of the container within a container structure. A container is defined within InSite as a discrete collection of products produced in a factory. \r\n\r\nEach container has a unique identifier used for traceability and performance of shop floor transactions. Commonly used level names are batch and lot. Container Levels are defined to meet the specific requirements of each company. Examples of some industry-specific levels are roll, bin, and cassette. \r\nMany companies also track smaller levels within the larger, parent container. With InSite, this is accomplished through multi-level tracking. Parent and child level containers are associated using the Associate, Combine or Group Start transactions. For example, a group of containers can have a parent with a batch level and associated child containers with tray levels. Container groups can also have more than two levels.", "ContainerLevel", false, false, false, "NamedObjectRef", 1048906, false, true, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "ContainerLevelChanges_Environment_ParentLevels")]
    protected Environment _ParentLevels;

    public Environment UIPreference
    {
      [param: In] set
      {
        this.PropertySet(nameof (UIPreference), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (UIPreference));
      }
    }

    public WIPMsgDefMgrChanges_Environment WIPMsgDefMgr
    {
      [param: In] set
      {
        this.PropertySet(nameof (WIPMsgDefMgr), (object) value);
      }
      get
      {
        return (WIPMsgDefMgrChanges_Environment) this.PropertyGet(nameof (WIPMsgDefMgr));
      }
    }

    public WIPMsgConfigChanges_Environment WIPMsgConfig
    {
      [param: In] set
      {
        this.PropertySet(nameof (WIPMsgConfig), (object) value);
      }
      get
      {
        return (WIPMsgConfigChanges_Environment) this.PropertyGet(nameof (WIPMsgConfig));
      }
    }

    public UserAttributeChanges_Environment Attributes
    {
      [param: In] set
      {
        this.PropertySet(nameof (Attributes), (object) value);
      }
      get
      {
        return (UserAttributeChanges_Environment) this.PropertyGet(nameof (Attributes));
      }
    }

    public Environment ContainerNumberingRule
    {
      [param: In] set
      {
        this.PropertySet(nameof (ContainerNumberingRule), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ContainerNumberingRule));
      }
    }

    public Environment IsNameUnique
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsNameUnique), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (IsNameUnique));
      }
    }

    public Environment AllowMove
    {
      [param: In] set
      {
        this.PropertySet(nameof (AllowMove), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (AllowMove));
      }
    }

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

    public Environment ChildLevels
    {
      [param: In] set
      {
        this.PropertySet(nameof (ChildLevels), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ChildLevels));
      }
    }

    public Environment ParentLevels
    {
      [param: In] set
      {
        this.PropertySet(nameof (ParentLevels), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ParentLevels));
      }
    }
  }
}
