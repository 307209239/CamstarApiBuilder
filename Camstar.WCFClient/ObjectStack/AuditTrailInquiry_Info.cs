// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.AuditTrailInquiry_Info
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
  public class AuditTrailInquiry_Info : Inquiry_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "AuditTrailInquiry_Info_SelectedHeader")]
    protected Info _SelectedHeader;
    [DataMember(EmitDefaultValue = false, Name = "AuditTrailInquiry_Info_AuditTrailDetail")]
    protected AuditTrail_Info _AuditTrailDetail;
    [DataMember(EmitDefaultValue = false, Name = "AuditTrailInquiry_Info_Headers")]
    protected AuditTrailHeader_Info _Headers;
    [DataMember(EmitDefaultValue = false, Name = "AuditTrailInquiry_Info_SelectedHeaderIndex")]
    protected Info _SelectedHeaderIndex;

    public Info SelectedHeader
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

    public AuditTrail_Info AuditTrailDetail
    {
      [param: In] set
      {
        this.PropertySet(nameof (AuditTrailDetail), (object) value);
      }
      get
      {
        return (AuditTrail_Info) this.PropertyGet(nameof (AuditTrailDetail));
      }
    }

    public AuditTrailHeader_Info Headers
    {
      [param: In] set
      {
        this.PropertySet(nameof (Headers), (object) value);
      }
      get
      {
        return (AuditTrailHeader_Info) this.PropertyGet(nameof (Headers));
      }
    }

    public Info SelectedHeaderIndex
    {
      [param: In] set
      {
        this.PropertySet(nameof (SelectedHeaderIndex), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (SelectedHeaderIndex));
      }
    }
  }
}
