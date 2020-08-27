// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ResourceStatusModelChanges_Environment
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
  public class ResourceStatusModelChanges_Environment : NamedDataObjectChanges_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "ResourceStatusModelChanges_Environment_InitStatusCodes")]
    [Metadata("A User Code Object Group that represents a group of Resource Status Codes.", "ResourceStatusCodeGroup", false, true, false, "NamedObjectRef", 1052850, false, false, true, null)]
    protected Environment _InitStatusCodes;
    [Metadata("A Mapping of \"From Status\" and possible \"To Statuses\" for a Resource.  One or more Resource Status Diagrams may be part of a Resource Status Model assigned to one or more Resources and/or Equipment Types.", "ResourceStatusDiagramChgs", false, false, false, "ResourceStatusDiagramChgs", 1052851, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ResourceStatusModelChanges_Environment_ResourceStatusDiagram")]
    protected ResourceStatusDiagramChgs_Environment _ResourceStatusDiagram;
    [Metadata("Defines a Resource Status Model which includes:\r\n1. Available initialization Resource Status Codes\r\n2. A Mapping of available \"From Status\" and \"To Statuses\"", "ResourceStatusModel", false, false, false, "NamedObjectRef", 1048682, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "ResourceStatusModelChanges_Environment_ObjectToChange")]
    protected new Environment _ObjectToChange;
    [Metadata("Unique name for this instance", "", false, true, false, "String", 1052852, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ResourceStatusModelChanges_Environment_Name")]
    protected new Environment _Name;

    public Environment InitStatusCodes
    {
      [param: In] set
      {
        this.PropertySet(nameof (InitStatusCodes), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (InitStatusCodes));
      }
    }

    public ResourceStatusDiagramChgs_Environment ResourceStatusDiagram
    {
      [param: In] set
      {
        this.PropertySet(nameof (ResourceStatusDiagram), (object) value);
      }
      get
      {
        return (ResourceStatusDiagramChgs_Environment) this.PropertyGet(nameof (ResourceStatusDiagram));
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
  }
}
