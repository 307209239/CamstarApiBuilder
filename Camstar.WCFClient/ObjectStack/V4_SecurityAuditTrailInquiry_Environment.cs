// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.V4_SecurityAuditTrailInquiry_Environment
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
  public class V4_SecurityAuditTrailInquiry_Environment : AuditTrailInquiry_Environment
  {
    [Metadata("Security Audit Trail Header encapsulates the header information captured during security maintenance transactions", "V4_SecurityAuditTrailHeader", false, false, true, "V4_SecurityAuditTrailHeader", 1050770, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "V4_SecurityAuditTrailInquiry_Environment_Headers")]
    protected V4_SecurityAuditTrailHeader_Environment _Headers;
    [Metadata("Details of the Audit Trail information captured during maintenance of InSite Security", "V4_SecurityAuditTrail", false, false, true, "V4_SecurityAuditTrail", 1050769, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "V4_SecurityAuditTrailInquiry_Environment_AuditTrailDetail")]
    protected V4_SecurityAuditTrail_Environment _AuditTrailDetail;
    [DataMember(EmitDefaultValue = false, Name = "V4_SecurityAuditTrailInquiry_Environment_ServiceName")]
    [Metadata("ServiceName", "ServiceNameEnum", false, false, false, "String", 1049390, false, false, false, null)]
    protected Environment _ServiceName;
    [Metadata("Security Audit Trail Header encapsulates the header information captured during security maintenance transactions", "V4_SecurityAuditTrailHeader", false, false, false, "SubentityRef", 1050771, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "V4_SecurityAuditTrailInquiry_Environment_SelectedHeader")]
    protected new Environment _SelectedHeader;
    [Metadata("CDO Definition Id", "", false, false, false, "Integer", 1049606, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "V4_SecurityAuditTrailInquiry_Environment_ServiceType")]
    protected Environment _ServiceType;
    [Metadata("Unique name for this instance", "", false, true, false, "String", 1050781, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "V4_SecurityAuditTrailInquiry_Environment_SecurityUserName")]
    protected Environment _SecurityUserName;

    public V4_SecurityAuditTrailHeader_Environment Headers
    {
      [param: In] set
      {
        this.PropertySet(nameof (Headers), (object) value);
      }
      get
      {
        return (V4_SecurityAuditTrailHeader_Environment) this.PropertyGet(nameof (Headers));
      }
    }

    public V4_SecurityAuditTrail_Environment AuditTrailDetail
    {
      [param: In] set
      {
        this.PropertySet(nameof (AuditTrailDetail), (object) value);
      }
      get
      {
        return (V4_SecurityAuditTrail_Environment) this.PropertyGet(nameof (AuditTrailDetail));
      }
    }

    public Environment ServiceName
    {
      [param: In] set
      {
        this.PropertySet(nameof (ServiceName), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ServiceName));
      }
    }

    public new Environment SelectedHeader
    {
      [param: In] set
      {
        this.PropertySet(nameof (SelectedHeader), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (SelectedHeader));
      }
    }

    public Environment ServiceType
    {
      [param: In] set
      {
        this.PropertySet(nameof (ServiceType), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ServiceType));
      }
    }

    public Environment SecurityUserName
    {
      [param: In] set
      {
        this.PropertySet(nameof (SecurityUserName), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (SecurityUserName));
      }
    }
  }
}
