// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.Maintenance
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
  public class Maintenance : Update
  {
    [DataMember(EmitDefaultValue = false, Name = "Maintenance_DataVersion")]
    protected Primitive<int> _DataVersion;
    [DataMember(EmitDefaultValue = false, Name = "Maintenance_ESigRequirement")]
    protected NamedObjectRef _ESigRequirement;
    [DataMember(EmitDefaultValue = false, Name = "Maintenance_WhereUsed")]
    protected SubentityRef[] _WhereUsed;
    [DataMember(EmitDefaultValue = false, Name = "Maintenance_WIPMsgMgr")]
    protected new WIPMsgMgr _WIPMsgMgr;
    [DataMember(EmitDefaultValue = false, Name = "Maintenance_ESigDetails")]
    protected ESigServiceDetail[] _ESigDetails;
    [DataMember(EmitDefaultValue = false, Name = "Maintenance_ChangePackagesToRemove")]
    protected NamedObjectRef[] _ChangePackagesToRemove;
    [DataMember(EmitDefaultValue = false, Name = "Maintenance_AssignSingleCPContent")]
    protected AssignSingleCPContent _AssignSingleCPContent;
    [DataMember(EmitDefaultValue = false, Name = "Maintenance_DetachSingleCPContent")]
    protected DetachSingleCPContent _DetachSingleCPContent;
    [DataMember(EmitDefaultValue = false, Name = "Maintenance_CPModelingInstanceDtl")]
    protected CPModelingInstanceDtl _CPModelingInstanceDtl;
    [DataMember(EmitDefaultValue = false, Name = "Maintenance_WhereUsedConfig")]
    protected NamedObjectRef _WhereUsedConfig;
    [DataMember(EmitDefaultValue = false, Name = "Maintenance_ChangePackageToAssign")]
    protected NamedObjectRef _ChangePackageToAssign;
    [DataMember(EmitDefaultValue = false, Name = "Maintenance_SyncName")]
    protected Primitive<string> _SyncName;
    [DataMember(EmitDefaultValue = false, Name = "Maintenance_ObjectChanges")]
    protected BaseObject _ObjectChanges;
    [DataMember(EmitDefaultValue = false, Name = "Maintenance_ObjectListInquiry")]
    protected BaseObjectRef[] _ObjectListInquiry;
    [DataMember(EmitDefaultValue = false, Name = "Maintenance_ObjectToChange")]
    protected BaseObjectRef _ObjectToChange;

    public override bool Equals(object obj)
    {
      return obj is Maintenance && object.Equals((object) this._DataVersion, (object) ((Maintenance) obj)._DataVersion) && (object.Equals((object) this._ESigRequirement, (object) ((Maintenance) obj)._ESigRequirement) && this.CompareArrays((Array) this._WhereUsed, (Array) ((Maintenance) obj)._WhereUsed)) && (object.Equals((object) this._WIPMsgMgr, (object) ((Maintenance) obj)._WIPMsgMgr) && this.CompareArrays((Array) this._ESigDetails, (Array) ((Maintenance) obj)._ESigDetails) && (this.CompareArrays((Array) this._ChangePackagesToRemove, (Array) ((Maintenance) obj)._ChangePackagesToRemove) && object.Equals((object) this._AssignSingleCPContent, (object) ((Maintenance) obj)._AssignSingleCPContent))) && (object.Equals((object) this._DetachSingleCPContent, (object) ((Maintenance) obj)._DetachSingleCPContent) && object.Equals((object) this._CPModelingInstanceDtl, (object) ((Maintenance) obj)._CPModelingInstanceDtl) && (object.Equals((object) this._WhereUsedConfig, (object) ((Maintenance) obj)._WhereUsedConfig) && object.Equals((object) this._ChangePackageToAssign, (object) ((Maintenance) obj)._ChangePackageToAssign)) && (object.Equals((object) this._SyncName, (object) ((Maintenance) obj)._SyncName) && object.Equals((object) this._ObjectChanges, (object) ((Maintenance) obj)._ObjectChanges) && (this.CompareArrays((Array) this._ObjectListInquiry, (Array) ((Maintenance) obj)._ObjectListInquiry) && object.Equals((object) this._ObjectToChange, (object) ((Maintenance) obj)._ObjectToChange)))) && base.Equals(obj);
    }

    public Primitive<int> DataVersion
    {
      [param: In] set
      {
        this.PropertySet(nameof (DataVersion), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (DataVersion));
      }
    }

    public NamedObjectRef ESigRequirement
    {
      [param: In] set
      {
        this.PropertySet(nameof (ESigRequirement), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (ESigRequirement));
      }
    }

    public SubentityRef[] WhereUsed
    {
      [param: In] set
      {
        this.PropertySet(nameof (WhereUsed), (object) value);
      }
      get
      {
        return (SubentityRef[]) this.PropertyGet(nameof (WhereUsed));
      }
    }

    public new WIPMsgMgr WIPMsgMgr
    {
      [param: In] set
      {
        this.PropertySet(nameof (WIPMsgMgr), (object) value);
      }
      get
      {
        return (WIPMsgMgr) this.PropertyGet(nameof (WIPMsgMgr));
      }
    }

    public ESigServiceDetail[] ESigDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (ESigDetails), (object) value);
      }
      get
      {
        return (ESigServiceDetail[]) this.PropertyGet(nameof (ESigDetails));
      }
    }

    public NamedObjectRef[] ChangePackagesToRemove
    {
      [param: In] set
      {
        this.PropertySet(nameof (ChangePackagesToRemove), (object) value);
      }
      get
      {
        return (NamedObjectRef[]) this.PropertyGet(nameof (ChangePackagesToRemove));
      }
    }

    public AssignSingleCPContent AssignSingleCPContent
    {
      [param: In] set
      {
        this.PropertySet(nameof (AssignSingleCPContent), (object) value);
      }
      get
      {
        return (AssignSingleCPContent) this.PropertyGet(nameof (AssignSingleCPContent));
      }
    }

    public DetachSingleCPContent DetachSingleCPContent
    {
      [param: In] set
      {
        this.PropertySet(nameof (DetachSingleCPContent), (object) value);
      }
      get
      {
        return (DetachSingleCPContent) this.PropertyGet(nameof (DetachSingleCPContent));
      }
    }

    public CPModelingInstanceDtl CPModelingInstanceDtl
    {
      [param: In] set
      {
        this.PropertySet(nameof (CPModelingInstanceDtl), (object) value);
      }
      get
      {
        return (CPModelingInstanceDtl) this.PropertyGet(nameof (CPModelingInstanceDtl));
      }
    }

    public NamedObjectRef WhereUsedConfig
    {
      [param: In] set
      {
        this.PropertySet(nameof (WhereUsedConfig), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (WhereUsedConfig));
      }
    }

    public NamedObjectRef ChangePackageToAssign
    {
      [param: In] set
      {
        this.PropertySet(nameof (ChangePackageToAssign), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (ChangePackageToAssign));
      }
    }

    public Primitive<string> SyncName
    {
      [param: In] set
      {
        this.PropertySet(nameof (SyncName), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (SyncName));
      }
    }

    public BaseObject ObjectChanges
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectChanges), (object) value);
      }
      get
      {
        return (BaseObject) this.PropertyGet(nameof (ObjectChanges));
      }
    }

    public BaseObjectRef[] ObjectListInquiry
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectListInquiry), (object) value);
      }
      get
      {
        return (BaseObjectRef[]) this.PropertyGet(nameof (ObjectListInquiry));
      }
    }

    public BaseObjectRef ObjectToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectToChange), (object) value);
      }
      get
      {
        return (BaseObjectRef) this.PropertyGet(nameof (ObjectToChange));
      }
    }
  }
}
