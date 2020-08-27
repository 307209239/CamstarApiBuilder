// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ResourceChanges_Info
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
  public class ResourceChanges_Info : NamedDataObjectChanges_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "ResourceChanges_Info_PrintQueue")]
    protected Info _PrintQueue;
    [DataMember(EmitDefaultValue = false, Name = "ResourceChanges_Info_PMStatusItem")]
    protected Info _PMStatusItem;
    [DataMember(EmitDefaultValue = false, Name = "ResourceChanges_Info_WebServiceTransport")]
    protected Info _WebServiceTransport;
    [DataMember(EmitDefaultValue = false, Name = "ResourceChanges_Info_Logs")]
    protected ResourceLogChanges_Info _Logs;
    [DataMember(EmitDefaultValue = false, Name = "ResourceChanges_Info_TrainingReqGroup")]
    protected Info _TrainingReqGroup;
    [DataMember(EmitDefaultValue = false, Name = "ResourceChanges_Info_ClearanceLevel")]
    protected Info _ClearanceLevel;
    [DataMember(EmitDefaultValue = false, Name = "ResourceChanges_Info_WIPMsgDefMgr")]
    protected WIPMsgDefMgrChanges_Info _WIPMsgDefMgr;
    [DataMember(EmitDefaultValue = false, Name = "ResourceChanges_Info_LogItem")]
    protected Info _LogItem;
    [DataMember(EmitDefaultValue = false, Name = "ResourceChanges_Info_PMStatus")]
    protected PMStatusChanges_Info _PMStatus;
    [DataMember(EmitDefaultValue = false, Name = "ResourceChanges_Info_Vendor")]
    protected Info _Vendor;
    [DataMember(EmitDefaultValue = false, Name = "ResourceChanges_Info_MaintenanceClass")]
    protected Info _MaintenanceClass;
    [DataMember(EmitDefaultValue = false, Name = "ResourceChanges_Info_ResourceFamily")]
    protected Info _ResourceFamily;
    [DataMember(EmitDefaultValue = false, Name = "ResourceChanges_Info_ResourceStatusModel")]
    protected Info _ResourceStatusModel;
    [DataMember(EmitDefaultValue = false, Name = "ResourceChanges_Info_FullyQualifiedName")]
    protected Info _FullyQualifiedName;
    [DataMember(EmitDefaultValue = false, Name = "ResourceChanges_Info_ResourceType")]
    protected Info _ResourceType;
    [DataMember(EmitDefaultValue = false, Name = "ResourceChanges_Info_VendorSerialNumber")]
    protected Info _VendorSerialNumber;
    [DataMember(EmitDefaultValue = false, Name = "ResourceChanges_Info_VendorModel")]
    protected Info _VendorModel;
    [DataMember(EmitDefaultValue = false, Name = "ResourceChanges_Info_CurrentSetup")]
    protected Info _CurrentSetup;
    [DataMember(EmitDefaultValue = false, Name = "ResourceChanges_Info_Factory")]
    protected Info _Factory;
    [DataMember(EmitDefaultValue = false, Name = "ResourceChanges_Info_ObjectToChange")]
    protected new Info _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "ResourceChanges_Info_Name")]
    protected new Info _Name;
    [DataMember(EmitDefaultValue = false, Name = "ResourceChanges_Info_Availability")]
    protected Info _Availability;
    [DataMember(EmitDefaultValue = false, Name = "ResourceChanges_Info_ChildResources")]
    protected Info _ChildResources;
    [DataMember(EmitDefaultValue = false, Name = "ResourceChanges_Info_ParentResource")]
    protected Info _ParentResource;
    [DataMember(EmitDefaultValue = false, Name = "ResourceChanges_Info_Location")]
    protected Info _Location;

    public Info PrintQueue
    {
      [param: In] set
      {
        this.PropertySet(nameof (PrintQueue), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (PrintQueue));
      }
    }

    public Info PMStatusItem
    {
      [param: In] set
      {
        this.PropertySet(nameof (PMStatusItem), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (PMStatusItem));
      }
    }

    public Info WebServiceTransport
    {
      [param: In] set
      {
        this.PropertySet(nameof (WebServiceTransport), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (WebServiceTransport));
      }
    }

    public ResourceLogChanges_Info Logs
    {
      [param: In] set
      {
        this.PropertySet(nameof (Logs), (object) value);
      }
      get
      {
        return (ResourceLogChanges_Info) this.PropertyGet(nameof (Logs));
      }
    }

    public Info TrainingReqGroup
    {
      [param: In] set
      {
        this.PropertySet(nameof (TrainingReqGroup), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (TrainingReqGroup));
      }
    }

    public Info ClearanceLevel
    {
      [param: In] set
      {
        this.PropertySet(nameof (ClearanceLevel), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ClearanceLevel));
      }
    }

    public WIPMsgDefMgrChanges_Info WIPMsgDefMgr
    {
      [param: In] set
      {
        this.PropertySet(nameof (WIPMsgDefMgr), (object) value);
      }
      get
      {
        return (WIPMsgDefMgrChanges_Info) this.PropertyGet(nameof (WIPMsgDefMgr));
      }
    }

    public Info LogItem
    {
      [param: In] set
      {
        this.PropertySet(nameof (LogItem), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (LogItem));
      }
    }

    public PMStatusChanges_Info PMStatus
    {
      [param: In] set
      {
        this.PropertySet(nameof (PMStatus), (object) value);
      }
      get
      {
        return (PMStatusChanges_Info) this.PropertyGet(nameof (PMStatus));
      }
    }

    public Info Vendor
    {
      [param: In] set
      {
        this.PropertySet(nameof (Vendor), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Vendor));
      }
    }

    public Info MaintenanceClass
    {
      [param: In] set
      {
        this.PropertySet(nameof (MaintenanceClass), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (MaintenanceClass));
      }
    }

    public Info ResourceFamily
    {
      [param: In] set
      {
        this.PropertySet(nameof (ResourceFamily), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ResourceFamily));
      }
    }

    public Info ResourceStatusModel
    {
      [param: In] set
      {
        this.PropertySet(nameof (ResourceStatusModel), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ResourceStatusModel));
      }
    }

    public Info FullyQualifiedName
    {
      [param: In] set
      {
        this.PropertySet(nameof (FullyQualifiedName), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (FullyQualifiedName));
      }
    }

    public Info ResourceType
    {
      [param: In] set
      {
        this.PropertySet(nameof (ResourceType), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ResourceType));
      }
    }

    public Info VendorSerialNumber
    {
      [param: In] set
      {
        this.PropertySet(nameof (VendorSerialNumber), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (VendorSerialNumber));
      }
    }

    public Info VendorModel
    {
      [param: In] set
      {
        this.PropertySet(nameof (VendorModel), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (VendorModel));
      }
    }

    public Info CurrentSetup
    {
      [param: In] set
      {
        this.PropertySet(nameof (CurrentSetup), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (CurrentSetup));
      }
    }

    public Info Factory
    {
      [param: In] set
      {
        this.PropertySet(nameof (Factory), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Factory));
      }
    }

    public new Info ObjectToChange
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

    public new Info Name
    {
      [param: In] set
      {
        this.PropertySet(nameof (Name), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Name));
      }
    }

    public Info Availability
    {
      [param: In] set
      {
        this.PropertySet(nameof (Availability), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Availability));
      }
    }

    public Info ChildResources
    {
      [param: In] set
      {
        this.PropertySet(nameof (ChildResources), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ChildResources));
      }
    }

    public Info ParentResource
    {
      [param: In] set
      {
        this.PropertySet(nameof (ParentResource), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ParentResource));
      }
    }

    public Info Location
    {
      [param: In] set
      {
        this.PropertySet(nameof (Location), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Location));
      }
    }
  }
}
