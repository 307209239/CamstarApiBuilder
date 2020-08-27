// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ResourceStatusDiagramChgs_Environment
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
  public class ResourceStatusDiagramChgs_Environment : SubentityChanges_Environment
  {
    [Metadata("A Mapping of \"From Status\" and possible \"To Statuses\" for a Resource.  One or more Resource Status Diagrams may be part of a Resource Status Model assigned to one or more Resources and/or Equipment Types.", "ResourceStatusDiagram", false, false, false, "SubentityRef", 1048682, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ResourceStatusDiagramChgs_Environment_ObjectToChange")]
    protected new Environment _ObjectToChange;
    [Metadata("A Mapping of \"From Status\" and possible \"To Statuses\" for a Resource.  One or more Resource Status Diagrams may be part of a Resource Status Model assigned to one or more Resources and/or Equipment Types.", "ResourceStatusDiagramChgs", false, false, false, "SubentityRef", 1049321, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ResourceStatusDiagramChgs_Environment_ListItemToChange")]
    protected new Environment _ListItemToChange;
    [DataMember(EmitDefaultValue = false, Name = "ResourceStatusDiagramChgs_Environment_ToStatusCodes")]
    [Metadata("A User Code Object Group that represents a group of Resource Status Codes.", "ResourceStatusCodeGroup", false, false, false, "NamedObjectRef", 1052860, false, false, true, null)]
    protected Environment _ToStatusCodes;
    [Metadata("Determines the current status (Active, In-Active) of this instance. Valid values and their meanings are:\r\n\r\n1 = Active\r\n2 = Inactive\r\n", "StatusEnum", false, false, false, "Integer", 1048671, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ResourceStatusDiagramChgs_Environment_Status")]
    protected Environment _Status;
    [Metadata("A Resource Status Code is provides a description of the current availability for a Resource. This value is used for inquiry and in reporting. (Mean Time Between Failure, Mean Time to Repair, Time at Status, etc.).\r\n\r\nAdditionally, a Resource Status code identifies the default “Next” (Production) Transaction for a Resource. This is intended to be a simple implementation of a Resource Status Flow (Resource Workflow).", "ResourceStatusCode", false, false, false, "NamedObjectRef", 1052859, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "ResourceStatusDiagramChgs_Environment_FromStatusCode")]
    protected Environment _FromStatusCode;
    [Metadata("Determines if changes are allowed to this instance (or any of its revisions)", "", false, false, false, "Boolean", 1048680, false, false, false, "0")]
    [DataMember(EmitDefaultValue = false, Name = "ResourceStatusDiagramChgs_Environment_IsFrozen")]
    protected Environment _IsFrozen;

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

    public new Environment ListItemToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ListItemToChange), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ListItemToChange));
      }
    }

    public Environment ToStatusCodes
    {
      [param: In] set
      {
        this.PropertySet(nameof (ToStatusCodes), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ToStatusCodes));
      }
    }

    public Environment Status
    {
      [param: In] set
      {
        this.PropertySet(nameof (Status), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Status));
      }
    }

    public Environment FromStatusCode
    {
      [param: In] set
      {
        this.PropertySet(nameof (FromStatusCode), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (FromStatusCode));
      }
    }

    public Environment IsFrozen
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsFrozen), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (IsFrozen));
      }
    }
  }
}
