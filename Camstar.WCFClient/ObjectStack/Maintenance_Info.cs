// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.Maintenance_Info
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
  public class Maintenance_Info : Update_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "Maintenance_Info_DataVersion")]
    protected Info _DataVersion;
    [DataMember(EmitDefaultValue = false, Name = "Maintenance_Info_ESigRequirement")]
    protected Info _ESigRequirement;
    [DataMember(EmitDefaultValue = false, Name = "Maintenance_Info_WhereUsed")]
    protected Info _WhereUsed;
    [DataMember(EmitDefaultValue = false, Name = "Maintenance_Info_WIPMsgMgr")]
    protected new WIPMsgMgr_Info _WIPMsgMgr;
    [DataMember(EmitDefaultValue = false, Name = "Maintenance_Info_ESigDetails")]
    protected ESigServiceDetail_Info _ESigDetails;
    [DataMember(EmitDefaultValue = false, Name = "Maintenance_Info_ChangePackagesToRemove")]
    protected Info _ChangePackagesToRemove;
    [DataMember(EmitDefaultValue = false, Name = "Maintenance_Info_AssignSingleCPContent")]
    protected AssignSingleCPContent_Info _AssignSingleCPContent;
    [DataMember(EmitDefaultValue = false, Name = "Maintenance_Info_DetachSingleCPContent")]
    protected DetachSingleCPContent_Info _DetachSingleCPContent;
    [DataMember(EmitDefaultValue = false, Name = "Maintenance_Info_CPModelingInstanceDtl")]
    protected CPModelingInstanceDtl_Info _CPModelingInstanceDtl;
    [DataMember(EmitDefaultValue = false, Name = "Maintenance_Info_WhereUsedConfig")]
    protected Info _WhereUsedConfig;
    [DataMember(EmitDefaultValue = false, Name = "Maintenance_Info_ChangePackageToAssign")]
    protected Info _ChangePackageToAssign;
    [DataMember(EmitDefaultValue = false, Name = "Maintenance_Info_SyncName")]
    protected Info _SyncName;
    [DataMember(EmitDefaultValue = false, Name = "Maintenance_Info_ObjectChanges")]
    protected BaseObject_Info _ObjectChanges;
    [DataMember(EmitDefaultValue = false, Name = "Maintenance_Info_ObjectListInquiry")]
    protected Info _ObjectListInquiry;
    [DataMember(EmitDefaultValue = false, Name = "Maintenance_Info_ObjectToChange")]
    protected Info _ObjectToChange;

    public Info DataVersion
    {
      [param: In] set
      {
        this.PropertySet(nameof (DataVersion), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (DataVersion));
      }
    }

    public Info ESigRequirement
    {
      [param: In] set
      {
        this.PropertySet(nameof (ESigRequirement), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ESigRequirement));
      }
    }

    public Info WhereUsed
    {
      [param: In] set
      {
        this.PropertySet(nameof (WhereUsed), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (WhereUsed));
      }
    }

    public new WIPMsgMgr_Info WIPMsgMgr
    {
      [param: In] set
      {
        this.PropertySet(nameof (WIPMsgMgr), (object) value);
      }
      get
      {
        return (WIPMsgMgr_Info) this.PropertyGet(nameof (WIPMsgMgr));
      }
    }

    public ESigServiceDetail_Info ESigDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (ESigDetails), (object) value);
      }
      get
      {
        return (ESigServiceDetail_Info) this.PropertyGet(nameof (ESigDetails));
      }
    }

    public Info ChangePackagesToRemove
    {
      [param: In] set
      {
        this.PropertySet(nameof (ChangePackagesToRemove), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ChangePackagesToRemove));
      }
    }

    public AssignSingleCPContent_Info AssignSingleCPContent
    {
      [param: In] set
      {
        this.PropertySet(nameof (AssignSingleCPContent), (object) value);
      }
      get
      {
        return (AssignSingleCPContent_Info) this.PropertyGet(nameof (AssignSingleCPContent));
      }
    }

    public DetachSingleCPContent_Info DetachSingleCPContent
    {
      [param: In] set
      {
        this.PropertySet(nameof (DetachSingleCPContent), (object) value);
      }
      get
      {
        return (DetachSingleCPContent_Info) this.PropertyGet(nameof (DetachSingleCPContent));
      }
    }

    public CPModelingInstanceDtl_Info CPModelingInstanceDtl
    {
      [param: In] set
      {
        this.PropertySet(nameof (CPModelingInstanceDtl), (object) value);
      }
      get
      {
        return (CPModelingInstanceDtl_Info) this.PropertyGet(nameof (CPModelingInstanceDtl));
      }
    }

    public Info WhereUsedConfig
    {
      [param: In] set
      {
        this.PropertySet(nameof (WhereUsedConfig), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (WhereUsedConfig));
      }
    }

    public Info ChangePackageToAssign
    {
      [param: In] set
      {
        this.PropertySet(nameof (ChangePackageToAssign), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ChangePackageToAssign));
      }
    }

    public Info SyncName
    {
      [param: In] set
      {
        this.PropertySet(nameof (SyncName), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (SyncName));
      }
    }

    public BaseObject_Info ObjectChanges
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectChanges), (object) value);
      }
      get
      {
        return (BaseObject_Info) this.PropertyGet(nameof (ObjectChanges));
      }
    }

    public Info ObjectListInquiry
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectListInquiry), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ObjectListInquiry));
      }
    }

    public Info ObjectToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectToChange), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ObjectToChange));
      }
    }
  }
}
