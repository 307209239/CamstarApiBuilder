// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ContainerLevelMaint_Environment
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
  public class ContainerLevelMaint_Environment : NamedDataObjectMaint_Environment
  {
    [Metadata("Changes CDO for ContainerLevel.", "ContainerLevelChanges", false, false, false, "ContainerLevelChanges", 1048873, true, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ContainerLevelMaint_Environment_ObjectChanges")]
    protected ContainerLevelChanges_Environment _ObjectChanges;
    [DataMember(EmitDefaultValue = false, Name = "ContainerLevelMaint_Environment_WIPExpressionBaseTypeId")]
    [Metadata("CDO Definition Id", "", false, false, true, "Integer", 1049793, false, false, false, "1040")]
    protected Environment _WIPExpressionBaseTypeId;
    [DataMember(EmitDefaultValue = false, Name = "ContainerLevelMaint_Environment_ObjectListInquiry")]
    [Metadata("A Container Level is the tracking designation assigned to a container. The level identifies the position of the container within a container structure. A container is defined within InSite as a discrete collection of products produced in a factory. \r\n\r\nEach container has a unique identifier used for traceability and performance of shop floor transactions. Commonly used level names are batch and lot. Container Levels are defined to meet the specific requirements of each company. Examples of some industry-specific levels are roll, bin, and cassette. \r\nMany companies also track smaller levels within the larger, parent container. With InSite, this is accomplished through multi-level tracking. Parent and child level containers are associated using the Associate, Combine or Group Start transactions. For example, a group of containers can have a parent with a batch level and associated child containers with tray levels. Container groups can also have more than two levels.", "ContainerLevel", false, false, true, "NamedObjectRef", 1048874, false, true, true, null)]
    protected new Environment _ObjectListInquiry;
    [DataMember(EmitDefaultValue = false, Name = "ContainerLevelMaint_Environment_ObjectToChange")]
    [Metadata("A Container Level is the tracking designation assigned to a container. The level identifies the position of the container within a container structure. A container is defined within InSite as a discrete collection of products produced in a factory. \r\n\r\nEach container has a unique identifier used for traceability and performance of shop floor transactions. Commonly used level names are batch and lot. Container Levels are defined to meet the specific requirements of each company. Examples of some industry-specific levels are roll, bin, and cassette. \r\nMany companies also track smaller levels within the larger, parent container. With InSite, this is accomplished through multi-level tracking. Parent and child level containers are associated using the Associate, Combine or Group Start transactions. For example, a group of containers can have a parent with a batch level and associated child containers with tray levels. Container groups can also have more than two levels.", "ContainerLevel", false, false, false, "NamedObjectRef", 1048682, false, false, true, null)]
    protected new Environment _ObjectToChange;

    public ContainerLevelChanges_Environment ObjectChanges
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectChanges), (object) value);
      }
      get
      {
        return (ContainerLevelChanges_Environment) this.PropertyGet(nameof (ObjectChanges));
      }
    }

    public Environment WIPExpressionBaseTypeId
    {
      [param: In] set
      {
        this.PropertySet(nameof (WIPExpressionBaseTypeId), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (WIPExpressionBaseTypeId));
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
