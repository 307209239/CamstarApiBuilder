// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ResourceAuditTrailInquiry_Info
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
  public class ResourceAuditTrailInquiry_Info : MfgAuditTrailInquiry_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "ResourceAuditTrailInquiry_Info_ResourceGroup")]
    protected Info _ResourceGroup;
    [DataMember(EmitDefaultValue = false, Name = "ResourceAuditTrailInquiry_Info_ResourceFamily")]
    protected Info _ResourceFamily;
    [DataMember(EmitDefaultValue = false, Name = "ResourceAuditTrailInquiry_Info_RecordType")]
    protected new Info _RecordType;
    [DataMember(EmitDefaultValue = false, Name = "ResourceAuditTrailInquiry_Info_TransactionFilter")]
    protected new Info _TransactionFilter;
    [DataMember(EmitDefaultValue = false, Name = "ResourceAuditTrailInquiry_Info_ResourceType")]
    protected Info _ResourceType;
    [DataMember(EmitDefaultValue = false, Name = "ResourceAuditTrailInquiry_Info_ShowAllTxnTypes")]
    protected new Info _ShowAllTxnTypes;
    [DataMember(EmitDefaultValue = false, Name = "ResourceAuditTrailInquiry_Info_Resource")]
    protected new Info _Resource;
    [DataMember(EmitDefaultValue = false, Name = "ResourceAuditTrailInquiry_Info_ResourceStatusReasonFilter")]
    protected new Info _ResourceStatusReasonFilter;
    [DataMember(EmitDefaultValue = false, Name = "ResourceAuditTrailInquiry_Info_AvailabilityFilter")]
    protected new Info _AvailabilityFilter;
    [DataMember(EmitDefaultValue = false, Name = "ResourceAuditTrailInquiry_Info_ResourceStatusCodeFilter")]
    protected new Info _ResourceStatusCodeFilter;

    public Info ResourceGroup
    {
      [param: In] set
      {
        this.PropertySet(nameof (ResourceGroup), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ResourceGroup));
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

    public new Info RecordType
    {
      [param: In] set
      {
        this.PropertySet(nameof (RecordType), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (RecordType));
      }
    }

    public new Info TransactionFilter
    {
      [param: In] set
      {
        this.PropertySet(nameof (TransactionFilter), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (TransactionFilter));
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

    public new Info ShowAllTxnTypes
    {
      [param: In] set
      {
        this.PropertySet(nameof (ShowAllTxnTypes), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ShowAllTxnTypes));
      }
    }

    public new Info Resource
    {
      [param: In] set
      {
        this.PropertySet(nameof (Resource), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Resource));
      }
    }

    public new Info ResourceStatusReasonFilter
    {
      [param: In] set
      {
        this.PropertySet(nameof (ResourceStatusReasonFilter), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ResourceStatusReasonFilter));
      }
    }

    public new Info AvailabilityFilter
    {
      [param: In] set
      {
        this.PropertySet(nameof (AvailabilityFilter), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (AvailabilityFilter));
      }
    }

    public new Info ResourceStatusCodeFilter
    {
      [param: In] set
      {
        this.PropertySet(nameof (ResourceStatusCodeFilter), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ResourceStatusCodeFilter));
      }
    }
  }
}
