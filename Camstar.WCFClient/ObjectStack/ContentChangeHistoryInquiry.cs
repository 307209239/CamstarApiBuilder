// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ContentChangeHistoryInquiry
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
  public class ContentChangeHistoryInquiry : ChangePackageInquiry
  {
    [DataMember(EmitDefaultValue = false, Name = "ContentChangeHistoryInquiry_InstanceName")]
    protected Primitive<string> _InstanceName;
    [DataMember(EmitDefaultValue = false, Name = "ContentChangeHistoryInquiry_Headers")]
    protected ModelingAuditTrailHeader[] _Headers;
    [DataMember(EmitDefaultValue = false, Name = "ContentChangeHistoryInquiry_ChangePackageHeader")]
    protected ChangePackageHeader _ChangePackageHeader;
    [DataMember(EmitDefaultValue = false, Name = "ContentChangeHistoryInquiry_ChangePackage")]
    protected NamedObjectRef _ChangePackage;
    [DataMember(EmitDefaultValue = false, Name = "ContentChangeHistoryInquiry_Instances")]
    protected CPModelingInstanceDtl[] _Instances;
    [DataMember(EmitDefaultValue = false, Name = "ContentChangeHistoryInquiry_ShowAllPackageHistory")]
    protected Primitive<bool> _ShowAllPackageHistory;
    [DataMember(EmitDefaultValue = false, Name = "ContentChangeHistoryInquiry_StartTimestamp")]
    protected Primitive<DateTime> _StartTimestamp;
    [DataMember(EmitDefaultValue = false, Name = "ContentChangeHistoryInquiry_ObjectType")]
    protected Primitive<string> _ObjectType;
    [DataMember(EmitDefaultValue = false, Name = "ContentChangeHistoryInquiry_EndTimestamp")]
    protected Primitive<DateTime> _EndTimestamp;
    [DataMember(EmitDefaultValue = false, Name = "ContentChangeHistoryInquiry_LastChangeUser")]
    protected NamedObjectRef _LastChangeUser;

    public override bool Equals(object obj)
    {
      return obj is ContentChangeHistoryInquiry && object.Equals((object) this._InstanceName, (object) ((ContentChangeHistoryInquiry) obj)._InstanceName) && (this.CompareArrays((Array) this._Headers, (Array) ((ContentChangeHistoryInquiry) obj)._Headers) && object.Equals((object) this._ChangePackageHeader, (object) ((ContentChangeHistoryInquiry) obj)._ChangePackageHeader)) && (object.Equals((object) this._ChangePackage, (object) ((ContentChangeHistoryInquiry) obj)._ChangePackage) && this.CompareArrays((Array) this._Instances, (Array) ((ContentChangeHistoryInquiry) obj)._Instances) && (object.Equals((object) this._ShowAllPackageHistory, (object) ((ContentChangeHistoryInquiry) obj)._ShowAllPackageHistory) && object.Equals((object) this._StartTimestamp, (object) ((ContentChangeHistoryInquiry) obj)._StartTimestamp))) && (object.Equals((object) this._ObjectType, (object) ((ContentChangeHistoryInquiry) obj)._ObjectType) && object.Equals((object) this._EndTimestamp, (object) ((ContentChangeHistoryInquiry) obj)._EndTimestamp) && object.Equals((object) this._LastChangeUser, (object) ((ContentChangeHistoryInquiry) obj)._LastChangeUser)) && base.Equals(obj);
    }

    public Primitive<string> InstanceName
    {
      [param: In] set
      {
        this.PropertySet(nameof (InstanceName), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (InstanceName));
      }
    }

    public ModelingAuditTrailHeader[] Headers
    {
      [param: In] set
      {
        this.PropertySet(nameof (Headers), (object) value);
      }
      get
      {
        return (ModelingAuditTrailHeader[]) this.PropertyGet(nameof (Headers));
      }
    }

    public ChangePackageHeader ChangePackageHeader
    {
      [param: In] set
      {
        this.PropertySet(nameof (ChangePackageHeader), (object) value);
      }
      get
      {
        return (ChangePackageHeader) this.PropertyGet(nameof (ChangePackageHeader));
      }
    }

    public NamedObjectRef ChangePackage
    {
      [param: In] set
      {
        this.PropertySet(nameof (ChangePackage), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (ChangePackage));
      }
    }

    public CPModelingInstanceDtl[] Instances
    {
      [param: In] set
      {
        this.PropertySet(nameof (Instances), (object) value);
      }
      get
      {
        return (CPModelingInstanceDtl[]) this.PropertyGet(nameof (Instances));
      }
    }

    public Primitive<bool> ShowAllPackageHistory
    {
      [param: In] set
      {
        this.PropertySet(nameof (ShowAllPackageHistory), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (ShowAllPackageHistory));
      }
    }

    public Primitive<DateTime> StartTimestamp
    {
      [param: In] set
      {
        this.PropertySet(nameof (StartTimestamp), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (StartTimestamp));
      }
    }

    public Primitive<string> ObjectType
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectType), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (ObjectType));
      }
    }

    public Primitive<DateTime> EndTimestamp
    {
      [param: In] set
      {
        this.PropertySet(nameof (EndTimestamp), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (EndTimestamp));
      }
    }

    public NamedObjectRef LastChangeUser
    {
      [param: In] set
      {
        this.PropertySet(nameof (LastChangeUser), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (LastChangeUser));
      }
    }
  }
}
