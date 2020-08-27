// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.QualityObjectHistoryInquiry_Environment
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
  public class QualityObjectHistoryInquiry_Environment : ContainerHistoryInquiry_Environment
  {
    [DataMember(EmitDefaultValue = false, Name = "QualityObjectHistoryInquiry_Environment_AuditTrail")]
    [Metadata("Modeling Audit Trail Header encapsulates the header information captured during every modeling data object maintenance", "ModelingAuditTrailHeader", false, false, false, "ModelingAuditTrailHeader", 1050782, false, false, false, null)]
    protected ModelingAuditTrailHeader_Environment _AuditTrail;
    [Metadata("Hierarchy of trackable objects within the Quality Management System.", "QualityObject", false, true, false, "NamedObjectRef", 1051298, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "QualityObjectHistoryInquiry_Environment_QualityObject")]
    protected Environment _QualityObject;
    [Metadata("The UI (User Interface) Preference object is used to store a user configured set of fields for a container.  This set of fields is displayed in the \"current\" information section for a container by the Live Manufacturing Audit Trail application.", "UIPreference", true, false, false, "UIPreference", 1050029, false, false, true, null)]
    [DataMember(EmitDefaultValue = false, Name = "QualityObjectHistoryInquiry_Environment_UIPreference")]
    protected new UIPreference_Environment _UIPreference;
    [Metadata("Enumeration for the History Record Type:\r\n1 = Event\r\n2 = CAR\r\n3 = CAPA\r\n4 = Container\r\n5 = ContainerInCarrier", "HistoryRecordTypeEnum", false, false, false, "Integer", 1051578, false, false, true, "4")]
    [DataMember(EmitDefaultValue = false, Name = "QualityObjectHistoryInquiry_Environment_RecordType")]
    protected new Environment _RecordType;
    [Metadata("Identifies the scope of organizational information that a user has access to", "Organization", false, false, false, "NamedObjectRef", 1051060, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "QualityObjectHistoryInquiry_Environment_Organization")]
    protected Environment _Organization;
    [DataMember(EmitDefaultValue = false, Name = "QualityObjectHistoryInquiry_Environment_ShowTxnTypes")]
    [Metadata("CDO Definition Id", "", false, false, false, "Integer", 1049591, false, true, true, null)]
    protected new Environment _ShowTxnTypes;

    public ModelingAuditTrailHeader_Environment AuditTrail
    {
      [param: In] set
      {
        this.PropertySet(nameof (AuditTrail), (object) value);
      }
      get
      {
        return (ModelingAuditTrailHeader_Environment) this.PropertyGet(nameof (AuditTrail));
      }
    }

    public Environment QualityObject
    {
      [param: In] set
      {
        this.PropertySet(nameof (QualityObject), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (QualityObject));
      }
    }

    public new UIPreference_Environment UIPreference
    {
      [param: In] set
      {
        this.PropertySet(nameof (UIPreference), (object) value);
      }
      get
      {
        return (UIPreference_Environment) this.PropertyGet(nameof (UIPreference));
      }
    }

    public new Environment RecordType
    {
      [param: In] set
      {
        this.PropertySet(nameof (RecordType), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (RecordType));
      }
    }

    public Environment Organization
    {
      [param: In] set
      {
        this.PropertySet(nameof (Organization), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Organization));
      }
    }

    public new Environment ShowTxnTypes
    {
      [param: In] set
      {
        this.PropertySet(nameof (ShowTxnTypes), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (ShowTxnTypes));
      }
    }
  }
}
