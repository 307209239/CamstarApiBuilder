// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.QualityObjectHistoryInquiry_Info
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
  public class QualityObjectHistoryInquiry_Info : ContainerHistoryInquiry_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "QualityObjectHistoryInquiry_Info_AuditTrail")]
    protected ModelingAuditTrailHeader_Info _AuditTrail;
    [DataMember(EmitDefaultValue = false, Name = "QualityObjectHistoryInquiry_Info_QualityObject")]
    protected Info _QualityObject;
    [DataMember(EmitDefaultValue = false, Name = "QualityObjectHistoryInquiry_Info_UIPreference")]
    protected new UIPreference_Info _UIPreference;
    [DataMember(EmitDefaultValue = false, Name = "QualityObjectHistoryInquiry_Info_RecordType")]
    protected new Info _RecordType;
    [DataMember(EmitDefaultValue = false, Name = "QualityObjectHistoryInquiry_Info_Organization")]
    protected Info _Organization;
    [DataMember(EmitDefaultValue = false, Name = "QualityObjectHistoryInquiry_Info_ShowTxnTypes")]
    protected new Info _ShowTxnTypes;

    public ModelingAuditTrailHeader_Info AuditTrail
    {
      [param: In] set
      {
        this.PropertySet(nameof (AuditTrail), (object) value);
      }
      get
      {
        return (ModelingAuditTrailHeader_Info) this.PropertyGet(nameof (AuditTrail));
      }
    }

    public Info QualityObject
    {
      [param: In] set
      {
        this.PropertySet(nameof (QualityObject), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (QualityObject));
      }
    }

    public new UIPreference_Info UIPreference
    {
      [param: In] set
      {
        this.PropertySet(nameof (UIPreference), (object) value);
      }
      get
      {
        return (UIPreference_Info) this.PropertyGet(nameof (UIPreference));
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

    public Info Organization
    {
      [param: In] set
      {
        this.PropertySet(nameof (Organization), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Organization));
      }
    }

    public new Info ShowTxnTypes
    {
      [param: In] set
      {
        this.PropertySet(nameof (ShowTxnTypes), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ShowTxnTypes));
      }
    }
  }
}
