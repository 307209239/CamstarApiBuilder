// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.Maintenance_Environment
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
  public class Maintenance_Environment : Update_Environment
  {
    [Metadata("This is used to implement data concurrency", "", false, false, false, "Integer", 1049897, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "Maintenance_Environment_DataVersion")]
    protected Environment _DataVersion;
    [DataMember(EmitDefaultValue = false, Name = "Maintenance_Environment_ESigRequirement")]
    [Metadata("Contains the list of signatures that should be collected in a single transaction.", "ESigRequirement", false, false, true, "NamedObjectRef", 1050915, false, false, false, null)]
    protected Environment _ESigRequirement;
    [DataMember(EmitDefaultValue = false, Name = "Maintenance_Environment_WhereUsed")]
    [Metadata("A list of this type is returned by the Where-used functionality of a maintenance service.  An instance of this CDO will specify one of the objects using the object to change.  The fields in this CDO are used to populate a tree view displayed while maintaining a modeling object.", "WhereUsed", false, false, false, "SubentityRef", 1049803, false, true, false, null)]
    protected Environment _WhereUsed;
    [Metadata("The WIPMsgMgr is the object attached to the service that controls the WIP Message processing.  It is called upon to Get, Validate and Process the WIP Messages.", "WIPMsgMgr", false, false, false, "WIPMsgMgr", 1048865, true, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "Maintenance_Environment_WIPMsgMgr")]
    protected new WIPMsgMgr_Environment _WIPMsgMgr;
    [DataMember(EmitDefaultValue = false, Name = "Maintenance_Environment_ESigDetails")]
    [Metadata("The ESigReqDetail used to fulfill all or part of an ESigRequirement.", "ESigServiceDetail", false, false, false, "ESigServiceDetail", 1050389, false, true, false, null)]
    protected ESigServiceDetail_Environment _ESigDetails;
    [Metadata("A change package is used to manage what is delivered to a target system for consumption.", "ChangePackage", false, false, false, "NamedObjectRef", 16778000, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "Maintenance_Environment_ChangePackagesToRemove")]
    protected Environment _ChangePackagesToRemove;
    [Metadata("Assigns content/modeling instance to a ChangePackage.", "AssignSingleCPContent", false, false, false, "AssignSingleCPContent", 16778052, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "Maintenance_Environment_AssignSingleCPContent")]
    protected AssignSingleCPContent_Environment _AssignSingleCPContent;
    [Metadata("Detach content/modeling instance to a ChangePackage.", "DetachSingleCPContent", false, false, false, "DetachSingleCPContent", 16778053, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "Maintenance_Environment_DetachSingleCPContent")]
    protected DetachSingleCPContent_Environment _DetachSingleCPContent;
    [Metadata("Change Package Modeling Instance Detail", "CPModelingInstanceDtl", false, false, false, "CPModelingInstanceDtl", 16778051, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "Maintenance_Environment_CPModelingInstanceDtl")]
    protected CPModelingInstanceDtl_Environment _CPModelingInstanceDtl;
    [DataMember(EmitDefaultValue = false, Name = "Maintenance_Environment_WhereUsedConfig")]
    [Metadata("Configuration object used in object upward dependency search.", "WhereUsedConfig", false, false, false, "NamedObjectRef", 16778022, false, false, false, null)]
    protected Environment _WhereUsedConfig;
    [Metadata("A change package is used to manage what is delivered to a target system for consumption.", "ChangePackage", false, false, false, "NamedObjectRef", 16778000, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "Maintenance_Environment_ChangePackageToAssign")]
    protected Environment _ChangePackageToAssign;
    [Metadata("Generic String", "", false, false, false, "String", 1050975, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "Maintenance_Environment_SyncName")]
    protected Environment _SyncName;
    [Metadata("BaseObject", "BaseObject", false, false, false, "BaseObject", 1048873, true, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "Maintenance_Environment_ObjectChanges")]
    protected BaseObject_Environment _ObjectChanges;
    [DataMember(EmitDefaultValue = false, Name = "Maintenance_Environment_ObjectListInquiry")]
    [Metadata("BaseObject", "BaseObject", false, false, true, "BaseObjectRef", 1048874, false, true, false, null)]
    protected Environment _ObjectListInquiry;
    [Metadata("BaseObject", "BaseObject", false, false, false, "BaseObjectRef", 1048682, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "Maintenance_Environment_ObjectToChange")]
    protected Environment _ObjectToChange;

    public Environment DataVersion
    {
      [param: In] set
      {
        this.PropertySet(nameof (DataVersion), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (DataVersion));
      }
    }

    public Environment ESigRequirement
    {
      [param: In] set
      {
        this.PropertySet(nameof (ESigRequirement), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ESigRequirement));
      }
    }

    public Environment WhereUsed
    {
      [param: In] set
      {
        this.PropertySet(nameof (WhereUsed), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (WhereUsed));
      }
    }

    public new WIPMsgMgr_Environment WIPMsgMgr
    {
      [param: In] set
      {
        this.PropertySet(nameof (WIPMsgMgr), (object) value);
      }
      get
      {
        return (WIPMsgMgr_Environment) this.PropertyGet(nameof (WIPMsgMgr));
      }
    }

    public ESigServiceDetail_Environment ESigDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (ESigDetails), (object) value);
      }
      get
      {
        return (ESigServiceDetail_Environment) this.PropertyGet(nameof (ESigDetails));
      }
    }

    public Environment ChangePackagesToRemove
    {
      [param: In] set
      {
        this.PropertySet(nameof (ChangePackagesToRemove), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ChangePackagesToRemove));
      }
    }

    public AssignSingleCPContent_Environment AssignSingleCPContent
    {
      [param: In] set
      {
        this.PropertySet(nameof (AssignSingleCPContent), (object) value);
      }
      get
      {
        return (AssignSingleCPContent_Environment) this.PropertyGet(nameof (AssignSingleCPContent));
      }
    }

    public DetachSingleCPContent_Environment DetachSingleCPContent
    {
      [param: In] set
      {
        this.PropertySet(nameof (DetachSingleCPContent), (object) value);
      }
      get
      {
        return (DetachSingleCPContent_Environment) this.PropertyGet(nameof (DetachSingleCPContent));
      }
    }

    public CPModelingInstanceDtl_Environment CPModelingInstanceDtl
    {
      [param: In] set
      {
        this.PropertySet(nameof (CPModelingInstanceDtl), (object) value);
      }
      get
      {
        return (CPModelingInstanceDtl_Environment) this.PropertyGet(nameof (CPModelingInstanceDtl));
      }
    }

    public Environment WhereUsedConfig
    {
      [param: In] set
      {
        this.PropertySet(nameof (WhereUsedConfig), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (WhereUsedConfig));
      }
    }

    public Environment ChangePackageToAssign
    {
      [param: In] set
      {
        this.PropertySet(nameof (ChangePackageToAssign), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ChangePackageToAssign));
      }
    }

    public Environment SyncName
    {
      [param: In] set
      {
        this.PropertySet(nameof (SyncName), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (SyncName));
      }
    }

    public BaseObject_Environment ObjectChanges
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectChanges), (object) value);
      }
      get
      {
        return (BaseObject_Environment) this.PropertyGet(nameof (ObjectChanges));
      }
    }

    public Environment ObjectListInquiry
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

    public Environment ObjectToChange
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
