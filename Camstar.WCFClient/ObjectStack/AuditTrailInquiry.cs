// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.AuditTrailInquiry
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
  public class AuditTrailInquiry : Inquiry
  {
    [DataMember(EmitDefaultValue = false, Name = "AuditTrailInquiry_SelectedHeader")]
    protected SubentityRef _SelectedHeader;
    [DataMember(EmitDefaultValue = false, Name = "AuditTrailInquiry_AuditTrailDetail")]
    protected AuditTrail _AuditTrailDetail;
    [DataMember(EmitDefaultValue = false, Name = "AuditTrailInquiry_Headers")]
    protected AuditTrailHeader[] _Headers;
    [DataMember(EmitDefaultValue = false, Name = "AuditTrailInquiry_SelectedHeaderIndex")]
    protected Primitive<int> _SelectedHeaderIndex;

    public override bool Equals(object obj)
    {
      return obj is AuditTrailInquiry && object.Equals((object) this._SelectedHeader, (object) ((AuditTrailInquiry) obj)._SelectedHeader) && (object.Equals((object) this._AuditTrailDetail, (object) ((AuditTrailInquiry) obj)._AuditTrailDetail) && this.CompareArrays((Array) this._Headers, (Array) ((AuditTrailInquiry) obj)._Headers)) && object.Equals((object) this._SelectedHeaderIndex, (object) ((AuditTrailInquiry) obj)._SelectedHeaderIndex) && base.Equals(obj);
    }

    public SubentityRef SelectedHeader
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

    public AuditTrail AuditTrailDetail
    {
      [param: In] set
      {
        this.PropertySet(nameof (AuditTrailDetail), (object) value);
      }
      get
      {
        return (AuditTrail) this.PropertyGet(nameof (AuditTrailDetail));
      }
    }

    public AuditTrailHeader[] Headers
    {
      [param: In] set
      {
        this.PropertySet(nameof (Headers), (object) value);
      }
      get
      {
        return (AuditTrailHeader[]) this.PropertyGet(nameof (Headers));
      }
    }

    public Primitive<int> SelectedHeaderIndex
    {
      [param: In] set
      {
        this.PropertySet(nameof (SelectedHeaderIndex), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (SelectedHeaderIndex));
      }
    }
  }
}
