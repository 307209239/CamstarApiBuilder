// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ResourceChanges
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
  public class ResourceChanges : NamedDataObjectChanges
  {
    [DataMember(EmitDefaultValue = false, Name = "ResourceChanges_PrintQueue")]
    protected NamedObjectRef _PrintQueue;
    [DataMember(EmitDefaultValue = false, Name = "ResourceChanges_PMStatusItem")]
    protected SubentityRef _PMStatusItem;
    [DataMember(EmitDefaultValue = false, Name = "ResourceChanges_WebServiceTransport")]
    protected NamedObjectRef _WebServiceTransport;
    [DataMember(EmitDefaultValue = false, Name = "ResourceChanges_Logs")]
    protected ResourceLogChanges[] _Logs;
    [DataMember(EmitDefaultValue = false, Name = "ResourceChanges_TrainingReqGroup")]
    protected NamedObjectRef _TrainingReqGroup;
    [DataMember(EmitDefaultValue = false, Name = "ResourceChanges_ClearanceLevel")]
    protected Enumeration<ClearanceLevelEnum, int> _ClearanceLevel;
    [DataMember(EmitDefaultValue = false, Name = "ResourceChanges_WIPMsgDefMgr")]
    protected WIPMsgDefMgrChanges _WIPMsgDefMgr;
    [DataMember(EmitDefaultValue = false, Name = "ResourceChanges_LogItem")]
    protected SubentityRef _LogItem;
    [DataMember(EmitDefaultValue = false, Name = "ResourceChanges_PMStatus")]
    protected PMStatusChanges[] _PMStatus;
    [DataMember(EmitDefaultValue = false, Name = "ResourceChanges_Vendor")]
    protected NamedObjectRef _Vendor;
    [DataMember(EmitDefaultValue = false, Name = "ResourceChanges_MaintenanceClass")]
    protected NamedObjectRef _MaintenanceClass;
    [DataMember(EmitDefaultValue = false, Name = "ResourceChanges_ResourceFamily")]
    protected NamedObjectRef _ResourceFamily;
    [DataMember(EmitDefaultValue = false, Name = "ResourceChanges_ResourceStatusModel")]
    protected NamedObjectRef _ResourceStatusModel;
    [DataMember(EmitDefaultValue = false, Name = "ResourceChanges_FullyQualifiedName")]
    protected Primitive<string> _FullyQualifiedName;
    [DataMember(EmitDefaultValue = false, Name = "ResourceChanges_ResourceType")]
    protected NamedObjectRef _ResourceType;
    [DataMember(EmitDefaultValue = false, Name = "ResourceChanges_VendorSerialNumber")]
    protected Primitive<string> _VendorSerialNumber;
    [DataMember(EmitDefaultValue = false, Name = "ResourceChanges_VendorModel")]
    protected Primitive<string> _VendorModel;
    [DataMember(EmitDefaultValue = false, Name = "ResourceChanges_CurrentSetup")]
    protected RevisionedObjectRef _CurrentSetup;
    [DataMember(EmitDefaultValue = false, Name = "ResourceChanges_Factory")]
    protected NamedObjectRef _Factory;
    [DataMember(EmitDefaultValue = false, Name = "ResourceChanges_ObjectToChange")]
    protected new NamedObjectRef _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "ResourceChanges_Name")]
    protected new Primitive<string> _Name;
    [DataMember(EmitDefaultValue = false, Name = "ResourceChanges_Availability")]
    protected Enumeration<ResourceAvailabilityEnum, int> _Availability;
    [DataMember(EmitDefaultValue = false, Name = "ResourceChanges_ChildResources")]
    protected NamedObjectRef[] _ChildResources;
    [DataMember(EmitDefaultValue = false, Name = "ResourceChanges_ParentResource")]
    protected NamedObjectRef _ParentResource;
    [DataMember(EmitDefaultValue = false, Name = "ResourceChanges_Location")]
    protected NamedSubentityRef _Location;

    public override bool Equals(object obj)
    {
      return obj is ResourceChanges && object.Equals((object) this._PrintQueue, (object) ((ResourceChanges) obj)._PrintQueue) && (object.Equals((object) this._PMStatusItem, (object) ((ResourceChanges) obj)._PMStatusItem) && object.Equals((object) this._WebServiceTransport, (object) ((ResourceChanges) obj)._WebServiceTransport)) && (this.CompareArrays((Array) this._Logs, (Array) ((ResourceChanges) obj)._Logs) && object.Equals((object) this._TrainingReqGroup, (object) ((ResourceChanges) obj)._TrainingReqGroup) && (object.Equals((object) this._ClearanceLevel, (object) ((ResourceChanges) obj)._ClearanceLevel) && object.Equals((object) this._WIPMsgDefMgr, (object) ((ResourceChanges) obj)._WIPMsgDefMgr))) && (object.Equals((object) this._LogItem, (object) ((ResourceChanges) obj)._LogItem) && this.CompareArrays((Array) this._PMStatus, (Array) ((ResourceChanges) obj)._PMStatus) && (object.Equals((object) this._Vendor, (object) ((ResourceChanges) obj)._Vendor) && object.Equals((object) this._MaintenanceClass, (object) ((ResourceChanges) obj)._MaintenanceClass)) && (object.Equals((object) this._ResourceFamily, (object) ((ResourceChanges) obj)._ResourceFamily) && object.Equals((object) this._ResourceStatusModel, (object) ((ResourceChanges) obj)._ResourceStatusModel) && (object.Equals((object) this._FullyQualifiedName, (object) ((ResourceChanges) obj)._FullyQualifiedName) && object.Equals((object) this._ResourceType, (object) ((ResourceChanges) obj)._ResourceType)))) && (object.Equals((object) this._VendorSerialNumber, (object) ((ResourceChanges) obj)._VendorSerialNumber) && object.Equals((object) this._VendorModel, (object) ((ResourceChanges) obj)._VendorModel) && (object.Equals((object) this._CurrentSetup, (object) ((ResourceChanges) obj)._CurrentSetup) && object.Equals((object) this._Factory, (object) ((ResourceChanges) obj)._Factory)) && (object.Equals((object) this._ObjectToChange, (object) ((ResourceChanges) obj)._ObjectToChange) && object.Equals((object) this._Name, (object) ((ResourceChanges) obj)._Name) && (object.Equals((object) this._Availability, (object) ((ResourceChanges) obj)._Availability) && this.CompareArrays((Array) this._ChildResources, (Array) ((ResourceChanges) obj)._ChildResources))) && (object.Equals((object) this._ParentResource, (object) ((ResourceChanges) obj)._ParentResource) && object.Equals((object) this._Location, (object) ((ResourceChanges) obj)._Location))) && base.Equals(obj);
    }

    public NamedObjectRef PrintQueue
    {
      [param: In] set
      {
        this.PropertySet(nameof (PrintQueue), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (PrintQueue));
      }
    }

    public SubentityRef PMStatusItem
    {
      [param: In] set
      {
        this.PropertySet(nameof (PMStatusItem), (object) value);
      }
      get
      {
        return (SubentityRef) this.PropertyGet(nameof (PMStatusItem));
      }
    }

    public NamedObjectRef WebServiceTransport
    {
      [param: In] set
      {
        this.PropertySet(nameof (WebServiceTransport), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (WebServiceTransport));
      }
    }

    public ResourceLogChanges[] Logs
    {
      [param: In] set
      {
        this.PropertySet(nameof (Logs), (object) value);
      }
      get
      {
        return (ResourceLogChanges[]) this.PropertyGet(nameof (Logs));
      }
    }

    public NamedObjectRef TrainingReqGroup
    {
      [param: In] set
      {
        this.PropertySet(nameof (TrainingReqGroup), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (TrainingReqGroup));
      }
    }

    public Enumeration<ClearanceLevelEnum, int> ClearanceLevel
    {
      [param: In] set
      {
        this.PropertySet(nameof (ClearanceLevel), (object) value);
      }
      get
      {
        return (Enumeration<ClearanceLevelEnum, int>) this.PropertyGet(nameof (ClearanceLevel));
      }
    }

    public WIPMsgDefMgrChanges WIPMsgDefMgr
    {
      [param: In] set
      {
        this.PropertySet(nameof (WIPMsgDefMgr), (object) value);
      }
      get
      {
        return (WIPMsgDefMgrChanges) this.PropertyGet(nameof (WIPMsgDefMgr));
      }
    }

    public SubentityRef LogItem
    {
      [param: In] set
      {
        this.PropertySet(nameof (LogItem), (object) value);
      }
      get
      {
        return (SubentityRef) this.PropertyGet(nameof (LogItem));
      }
    }

    public PMStatusChanges[] PMStatus
    {
      [param: In] set
      {
        this.PropertySet(nameof (PMStatus), (object) value);
      }
      get
      {
        return (PMStatusChanges[]) this.PropertyGet(nameof (PMStatus));
      }
    }

    public NamedObjectRef Vendor
    {
      [param: In] set
      {
        this.PropertySet(nameof (Vendor), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (Vendor));
      }
    }

    public NamedObjectRef MaintenanceClass
    {
      [param: In] set
      {
        this.PropertySet(nameof (MaintenanceClass), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (MaintenanceClass));
      }
    }

    public NamedObjectRef ResourceFamily
    {
      [param: In] set
      {
        this.PropertySet(nameof (ResourceFamily), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (ResourceFamily));
      }
    }

    public NamedObjectRef ResourceStatusModel
    {
      [param: In] set
      {
        this.PropertySet(nameof (ResourceStatusModel), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (ResourceStatusModel));
      }
    }

    public Primitive<string> FullyQualifiedName
    {
      [param: In] set
      {
        this.PropertySet(nameof (FullyQualifiedName), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (FullyQualifiedName));
      }
    }

    public NamedObjectRef ResourceType
    {
      [param: In] set
      {
        this.PropertySet(nameof (ResourceType), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (ResourceType));
      }
    }

    public Primitive<string> VendorSerialNumber
    {
      [param: In] set
      {
        this.PropertySet(nameof (VendorSerialNumber), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (VendorSerialNumber));
      }
    }

    public Primitive<string> VendorModel
    {
      [param: In] set
      {
        this.PropertySet(nameof (VendorModel), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (VendorModel));
      }
    }

    public RevisionedObjectRef CurrentSetup
    {
      [param: In] set
      {
        this.PropertySet(nameof (CurrentSetup), (object) value);
      }
      get
      {
        return (RevisionedObjectRef) this.PropertyGet(nameof (CurrentSetup));
      }
    }

    public NamedObjectRef Factory
    {
      [param: In] set
      {
        this.PropertySet(nameof (Factory), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (Factory));
      }
    }

    public new NamedObjectRef ObjectToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectToChange), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (ObjectToChange));
      }
    }

    public new Primitive<string> Name
    {
      [param: In] set
      {
        this.PropertySet(nameof (Name), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (Name));
      }
    }

    public Enumeration<ResourceAvailabilityEnum, int> Availability
    {
      [param: In] set
      {
        this.PropertySet(nameof (Availability), (object) value);
      }
      get
      {
        return (Enumeration<ResourceAvailabilityEnum, int>) this.PropertyGet(nameof (Availability));
      }
    }

    public NamedObjectRef[] ChildResources
    {
      [param: In] set
      {
        this.PropertySet(nameof (ChildResources), (object) value);
      }
      get
      {
        return (NamedObjectRef[]) this.PropertyGet(nameof (ChildResources));
      }
    }

    public NamedObjectRef ParentResource
    {
      [param: In] set
      {
        this.PropertySet(nameof (ParentResource), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (ParentResource));
      }
    }

    public NamedSubentityRef Location
    {
      [param: In] set
      {
        this.PropertySet(nameof (Location), (object) value);
      }
      get
      {
        return (NamedSubentityRef) this.PropertyGet(nameof (Location));
      }
    }
  }
}
