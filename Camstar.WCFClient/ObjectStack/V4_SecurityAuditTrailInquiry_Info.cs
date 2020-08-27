// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.V4_SecurityAuditTrailInquiry_Info
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
  public class V4_SecurityAuditTrailInquiry_Info : AuditTrailInquiry_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "V4_SecurityAuditTrailInquiry_Info_Headers")]
    protected V4_SecurityAuditTrailHeader_Info _Headers;
    [DataMember(EmitDefaultValue = false, Name = "V4_SecurityAuditTrailInquiry_Info_AuditTrailDetail")]
    protected V4_SecurityAuditTrail_Info _AuditTrailDetail;
    [DataMember(EmitDefaultValue = false, Name = "V4_SecurityAuditTrailInquiry_Info_ServiceName")]
    protected Info _ServiceName;
    [DataMember(EmitDefaultValue = false, Name = "V4_SecurityAuditTrailInquiry_Info_SelectedHeader")]
    protected new Info _SelectedHeader;
    [DataMember(EmitDefaultValue = false, Name = "V4_SecurityAuditTrailInquiry_Info_ServiceType")]
    protected Info _ServiceType;
    [DataMember(EmitDefaultValue = false, Name = "V4_SecurityAuditTrailInquiry_Info_SecurityUserName")]
    protected Info _SecurityUserName;

    public V4_SecurityAuditTrailHeader_Info Headers
    {
      [param: In] set
      {
        this.PropertySet(nameof (Headers), (object) value);
      }
      get
      {
        return (V4_SecurityAuditTrailHeader_Info) this.PropertyGet(nameof (Headers));
      }
    }

    public V4_SecurityAuditTrail_Info AuditTrailDetail
    {
      [param: In] set
      {
        this.PropertySet(nameof (AuditTrailDetail), (object) value);
      }
      get
      {
        return (V4_SecurityAuditTrail_Info) this.PropertyGet(nameof (AuditTrailDetail));
      }
    }

    public Info ServiceName
    {
      [param: In] set
      {
        this.PropertySet(nameof (ServiceName), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ServiceName));
      }
    }

    public new Info SelectedHeader
    {
      [param: In] set
      {
        this.PropertySet(nameof (SelectedHeader), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (SelectedHeader));
      }
    }

    public Info ServiceType
    {
      [param: In] set
      {
        this.PropertySet(nameof (ServiceType), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ServiceType));
      }
    }

    public Info SecurityUserName
    {
      [param: In] set
      {
        this.PropertySet(nameof (SecurityUserName), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (SecurityUserName));
      }
    }
  }
}
