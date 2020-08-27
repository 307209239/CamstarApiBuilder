// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ResourceAuditTrailInquiry
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
  public class ResourceAuditTrailInquiry : MfgAuditTrailInquiry
  {
    [DataMember(EmitDefaultValue = false, Name = "ResourceAuditTrailInquiry_ResourceGroup")]
    protected NamedObjectRef _ResourceGroup;
    [DataMember(EmitDefaultValue = false, Name = "ResourceAuditTrailInquiry_ResourceFamily")]
    protected NamedObjectRef _ResourceFamily;
    [DataMember(EmitDefaultValue = false, Name = "ResourceAuditTrailInquiry_RecordType")]
    protected new Enumeration<HistoryRecordTypeEnum, int> _RecordType;
    [DataMember(EmitDefaultValue = false, Name = "ResourceAuditTrailInquiry_TransactionFilter")]
    protected Enumeration<ResourceAuditTrailTypeEnum, int> _TransactionFilter;
    [DataMember(EmitDefaultValue = false, Name = "ResourceAuditTrailInquiry_ResourceType")]
    protected NamedObjectRef _ResourceType;
    [DataMember(EmitDefaultValue = false, Name = "ResourceAuditTrailInquiry_ShowAllTxnTypes")]
    protected new Primitive<bool> _ShowAllTxnTypes;
    [DataMember(EmitDefaultValue = false, Name = "ResourceAuditTrailInquiry_Resource")]
    protected new NamedObjectRef _Resource;
    [DataMember(EmitDefaultValue = false, Name = "ResourceAuditTrailInquiry_ResourceStatusReasonFilter")]
    protected new NamedObjectRef _ResourceStatusReasonFilter;
    [DataMember(EmitDefaultValue = false, Name = "ResourceAuditTrailInquiry_AvailabilityFilter")]
    protected new Enumeration<ResourceAvailabilityEnum, int> _AvailabilityFilter;
    [DataMember(EmitDefaultValue = false, Name = "ResourceAuditTrailInquiry_ResourceStatusCodeFilter")]
    protected new NamedObjectRef _ResourceStatusCodeFilter;

    public override bool Equals(object obj)
    {
      return obj is ResourceAuditTrailInquiry && object.Equals((object) this._ResourceGroup, (object) ((ResourceAuditTrailInquiry) obj)._ResourceGroup) && (object.Equals((object) this._ResourceFamily, (object) ((ResourceAuditTrailInquiry) obj)._ResourceFamily) && object.Equals((object) this._RecordType, (object) ((ResourceAuditTrailInquiry) obj)._RecordType)) && (object.Equals((object) this._TransactionFilter, (object) ((ResourceAuditTrailInquiry) obj)._TransactionFilter) && object.Equals((object) this._ResourceType, (object) ((ResourceAuditTrailInquiry) obj)._ResourceType) && (object.Equals((object) this._ShowAllTxnTypes, (object) ((ResourceAuditTrailInquiry) obj)._ShowAllTxnTypes) && object.Equals((object) this._Resource, (object) ((ResourceAuditTrailInquiry) obj)._Resource))) && (object.Equals((object) this._ResourceStatusReasonFilter, (object) ((ResourceAuditTrailInquiry) obj)._ResourceStatusReasonFilter) && object.Equals((object) this._AvailabilityFilter, (object) ((ResourceAuditTrailInquiry) obj)._AvailabilityFilter) && object.Equals((object) this._ResourceStatusCodeFilter, (object) ((ResourceAuditTrailInquiry) obj)._ResourceStatusCodeFilter)) && base.Equals(obj);
    }

    public NamedObjectRef ResourceGroup
    {
      [param: In] set
      {
        this.PropertySet(nameof (ResourceGroup), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (ResourceGroup));
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

    public new Enumeration<HistoryRecordTypeEnum, int> RecordType
    {
      [param: In] set
      {
        this.PropertySet(nameof (RecordType), (object) value);
      }
      get
      {
        return (Enumeration<HistoryRecordTypeEnum, int>) this.PropertyGet(nameof (RecordType));
      }
    }

    public Enumeration<ResourceAuditTrailTypeEnum, int> TransactionFilter
    {
      [param: In] set
      {
        this.PropertySet(nameof (TransactionFilter), (object) value);
      }
      get
      {
        return (Enumeration<ResourceAuditTrailTypeEnum, int>) this.PropertyGet(nameof (TransactionFilter));
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

    public new Primitive<bool> ShowAllTxnTypes
    {
      [param: In] set
      {
        this.PropertySet(nameof (ShowAllTxnTypes), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (ShowAllTxnTypes));
      }
    }

    public new NamedObjectRef Resource
    {
      [param: In] set
      {
        this.PropertySet(nameof (Resource), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (Resource));
      }
    }

    public new NamedObjectRef ResourceStatusReasonFilter
    {
      [param: In] set
      {
        this.PropertySet(nameof (ResourceStatusReasonFilter), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (ResourceStatusReasonFilter));
      }
    }

    public new Enumeration<ResourceAvailabilityEnum, int> AvailabilityFilter
    {
      [param: In] set
      {
        this.PropertySet(nameof (AvailabilityFilter), (object) value);
      }
      get
      {
        return (Enumeration<ResourceAvailabilityEnum, int>) this.PropertyGet(nameof (AvailabilityFilter));
      }
    }

    public new NamedObjectRef ResourceStatusCodeFilter
    {
      [param: In] set
      {
        this.PropertySet(nameof (ResourceStatusCodeFilter), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (ResourceStatusCodeFilter));
      }
    }
  }
}
