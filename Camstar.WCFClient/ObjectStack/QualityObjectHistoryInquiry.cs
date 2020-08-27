// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.QualityObjectHistoryInquiry
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
  public class QualityObjectHistoryInquiry : ContainerHistoryInquiry
  {
    [DataMember(EmitDefaultValue = false, Name = "QualityObjectHistoryInquiry_AuditTrail")]
    protected ModelingAuditTrailHeader _AuditTrail;
    [DataMember(EmitDefaultValue = false, Name = "QualityObjectHistoryInquiry_QualityObject")]
    protected NamedObjectRef _QualityObject;
    [DataMember(EmitDefaultValue = false, Name = "QualityObjectHistoryInquiry_UIPreference")]
    protected new UIPreference _UIPreference;
    [DataMember(EmitDefaultValue = false, Name = "QualityObjectHistoryInquiry_RecordType")]
    protected new Enumeration<HistoryRecordTypeEnum, int> _RecordType;
    [DataMember(EmitDefaultValue = false, Name = "QualityObjectHistoryInquiry_Organization")]
    protected NamedObjectRef _Organization;
    [DataMember(EmitDefaultValue = false, Name = "QualityObjectHistoryInquiry_ShowTxnTypes")]
    protected new Primitive<int>[] _ShowTxnTypes;

    public override bool Equals(object obj)
    {
      return obj is QualityObjectHistoryInquiry && object.Equals((object) this._AuditTrail, (object) ((QualityObjectHistoryInquiry) obj)._AuditTrail) && (object.Equals((object) this._QualityObject, (object) ((QualityObjectHistoryInquiry) obj)._QualityObject) && object.Equals((object) this._UIPreference, (object) ((QualityObjectHistoryInquiry) obj)._UIPreference)) && (object.Equals((object) this._RecordType, (object) ((QualityObjectHistoryInquiry) obj)._RecordType) && object.Equals((object) this._Organization, (object) ((QualityObjectHistoryInquiry) obj)._Organization) && this.CompareArrays((Array) this._ShowTxnTypes, (Array) ((QualityObjectHistoryInquiry) obj)._ShowTxnTypes)) && base.Equals(obj);
    }

    public ModelingAuditTrailHeader AuditTrail
    {
      [param: In] set
      {
        this.PropertySet(nameof (AuditTrail), (object) value);
      }
      get
      {
        return (ModelingAuditTrailHeader) this.PropertyGet(nameof (AuditTrail));
      }
    }

    public NamedObjectRef QualityObject
    {
      [param: In] set
      {
        this.PropertySet(nameof (QualityObject), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (QualityObject));
      }
    }

    public new UIPreference UIPreference
    {
      [param: In] set
      {
        this.PropertySet(nameof (UIPreference), (object) value);
      }
      get
      {
        return (UIPreference) this.PropertyGet(nameof (UIPreference));
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

    public NamedObjectRef Organization
    {
      [param: In] set
      {
        this.PropertySet(nameof (Organization), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (Organization));
      }
    }

    public new Primitive<int>[] ShowTxnTypes
    {
      [param: In] set
      {
        this.PropertySet(nameof (ShowTxnTypes), (object) value);
      }
      get
      {
        return (Primitive<int>[]) this.PropertyGet(nameof (ShowTxnTypes));
      }
    }
  }
}
