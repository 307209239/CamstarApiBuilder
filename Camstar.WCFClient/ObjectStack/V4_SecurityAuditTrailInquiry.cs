// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.V4_SecurityAuditTrailInquiry
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
  public class V4_SecurityAuditTrailInquiry : AuditTrailInquiry
  {
    [DataMember(EmitDefaultValue = false, Name = "V4_SecurityAuditTrailInquiry_Headers")]
    protected V4_SecurityAuditTrailHeader[] _Headers;
    [DataMember(EmitDefaultValue = false, Name = "V4_SecurityAuditTrailInquiry_AuditTrailDetail")]
    protected V4_SecurityAuditTrail _AuditTrailDetail;
    [DataMember(EmitDefaultValue = false, Name = "V4_SecurityAuditTrailInquiry_ServiceName")]
    protected Enumeration<ServiceNameEnum, string> _ServiceName;
    [DataMember(EmitDefaultValue = false, Name = "V4_SecurityAuditTrailInquiry_SelectedHeader")]
    protected new SubentityRef _SelectedHeader;
    [DataMember(EmitDefaultValue = false, Name = "V4_SecurityAuditTrailInquiry_ServiceType")]
    protected Primitive<int> _ServiceType;
    [DataMember(EmitDefaultValue = false, Name = "V4_SecurityAuditTrailInquiry_SecurityUserName")]
    protected Primitive<string> _SecurityUserName;

    public override bool Equals(object obj)
    {
      return obj is V4_SecurityAuditTrailInquiry && this.CompareArrays((Array) this._Headers, (Array) ((V4_SecurityAuditTrailInquiry) obj)._Headers) && (object.Equals((object) this._AuditTrailDetail, (object) ((V4_SecurityAuditTrailInquiry) obj)._AuditTrailDetail) && object.Equals((object) this._ServiceName, (object) ((V4_SecurityAuditTrailInquiry) obj)._ServiceName)) && (object.Equals((object) this._SelectedHeader, (object) ((V4_SecurityAuditTrailInquiry) obj)._SelectedHeader) && object.Equals((object) this._ServiceType, (object) ((V4_SecurityAuditTrailInquiry) obj)._ServiceType) && object.Equals((object) this._SecurityUserName, (object) ((V4_SecurityAuditTrailInquiry) obj)._SecurityUserName)) && base.Equals(obj);
    }

    public V4_SecurityAuditTrailHeader[] Headers
    {
      [param: In] set
      {
        this.PropertySet(nameof (Headers), (object) value);
      }
      get
      {
        return (V4_SecurityAuditTrailHeader[]) this.PropertyGet(nameof (Headers));
      }
    }

    public V4_SecurityAuditTrail AuditTrailDetail
    {
      [param: In] set
      {
        this.PropertySet(nameof (AuditTrailDetail), (object) value);
      }
      get
      {
        return (V4_SecurityAuditTrail) this.PropertyGet(nameof (AuditTrailDetail));
      }
    }

    public Enumeration<ServiceNameEnum, string> ServiceName
    {
      [param: In] set
      {
        this.PropertySet(nameof (ServiceName), (object) value);
      }
      get
      {
        return (Enumeration<ServiceNameEnum, string>) this.PropertyGet(nameof (ServiceName));
      }
    }

    public new SubentityRef SelectedHeader
    {
      [param: In] set
      {
        this.PropertySet(nameof (SelectedHeader), (object) value);
      }
      get
      {
        return (SubentityRef) this.PropertyGet(nameof (SelectedHeader));
      }
    }

    public Primitive<int> ServiceType
    {
      [param: In] set
      {
        this.PropertySet(nameof (ServiceType), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (ServiceType));
      }
    }

    public Primitive<string> SecurityUserName
    {
      [param: In] set
      {
        this.PropertySet(nameof (SecurityUserName), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (SecurityUserName));
      }
    }
  }
}
