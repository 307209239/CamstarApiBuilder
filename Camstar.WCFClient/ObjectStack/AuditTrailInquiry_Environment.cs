// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.AuditTrailInquiry_Environment
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
  public class AuditTrailInquiry_Environment : Inquiry_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "AuditTrailInquiry_Environment_SelectedHeader")]
    [Metadata("Audit Trail Header encapsulates the basic header information captured during every maintenance transaction.", "AuditTrailHeader", false, false, false, "SubentityRef", 1050771, false, false, false, null)]
    protected Environment _SelectedHeader;
    [Metadata("Details of the Audit Trail information captured", "AuditTrail", false, false, true, "AuditTrail", 1050769, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "AuditTrailInquiry_Environment_AuditTrailDetail")]
    protected AuditTrail_Environment _AuditTrailDetail;
    [DataMember(EmitDefaultValue = false, Name = "AuditTrailInquiry_Environment_Headers")]
    [Metadata("Audit Trail Header encapsulates the basic header information captured during every maintenance transaction.", "AuditTrailHeader", false, false, true, "AuditTrailHeader", 1050770, false, true, false, null)]
    protected AuditTrailHeader_Environment _Headers;
    [Metadata("Generic Integer", "", false, false, false, "Integer", 1050772, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "AuditTrailInquiry_Environment_SelectedHeaderIndex")]
    protected Environment _SelectedHeaderIndex;

    public Environment SelectedHeader
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

    public AuditTrail_Environment AuditTrailDetail
    {
      [param: In] set
      {
        this.PropertySet(nameof (AuditTrailDetail), (object) value);
      }
      get
      {
        return (AuditTrail_Environment) this.PropertyGet(nameof (AuditTrailDetail));
      }
    }

    public AuditTrailHeader_Environment Headers
    {
      [param: In] set
      {
        this.PropertySet(nameof (Headers), (object) value);
      }
      get
      {
        return (AuditTrailHeader_Environment) this.PropertyGet(nameof (Headers));
      }
    }

    public Environment SelectedHeaderIndex
    {
      [param: In] set
      {
        this.PropertySet(nameof (SelectedHeaderIndex), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (SelectedHeaderIndex));
      }
    }
  }
}
