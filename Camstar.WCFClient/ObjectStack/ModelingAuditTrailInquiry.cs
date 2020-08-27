// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ModelingAuditTrailInquiry
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
  public class ModelingAuditTrailInquiry : AuditTrailInquiry
  {
    [DataMember(EmitDefaultValue = false, Name = "ModelingAuditTrailInquiry_ObjectTypeName")]
    protected Enumeration<MaintainableObjectEnum, string> _ObjectTypeName;
    [DataMember(EmitDefaultValue = false, Name = "ModelingAuditTrailInquiry_SelectedHeader")]
    protected new SubentityRef _SelectedHeader;
    [DataMember(EmitDefaultValue = false, Name = "ModelingAuditTrailInquiry_AuditTrailDetail")]
    protected ModelingAuditTrail _AuditTrailDetail;
    [DataMember(EmitDefaultValue = false, Name = "ModelingAuditTrailInquiry_ObjectName")]
    protected Primitive<string> _ObjectName;
    [DataMember(EmitDefaultValue = false, Name = "ModelingAuditTrailInquiry_Headers")]
    protected ModelingAuditTrailHeader[] _Headers;
    [DataMember(EmitDefaultValue = false, Name = "ModelingAuditTrailInquiry_Recursive")]
    protected Primitive<bool> _Recursive;
    [DataMember(EmitDefaultValue = false, Name = "ModelingAuditTrailInquiry_ObjectInstanceId")]
    protected Primitive<string> _ObjectInstanceId;
    [DataMember(EmitDefaultValue = false, Name = "ModelingAuditTrailInquiry_ObjectRevisionOrParent")]
    protected Primitive<string> _ObjectRevisionOrParent;
    [DataMember(EmitDefaultValue = false, Name = "ModelingAuditTrailInquiry_ModelingAuditListSize")]
    protected Primitive<int> _ModelingAuditListSize;
    [DataMember(EmitDefaultValue = false, Name = "ModelingAuditTrailInquiry_ModelingAuditStartRow")]
    protected Primitive<int> _ModelingAuditStartRow;
    [DataMember(EmitDefaultValue = false, Name = "ModelingAuditTrailInquiry_ObjectType")]
    protected Primitive<int> _ObjectType;
    [DataMember(EmitDefaultValue = false, Name = "ModelingAuditTrailInquiry_ParentType")]
    protected Primitive<int> _ParentType;
    [DataMember(EmitDefaultValue = false, Name = "ModelingAuditTrailInquiry_DateToFilter")]
    protected Primitive<DateTime> _DateToFilter;
    [DataMember(EmitDefaultValue = false, Name = "ModelingAuditTrailInquiry_SelectedObjectId")]
    protected Primitive<string> _SelectedObjectId;
    [DataMember(EmitDefaultValue = false, Name = "ModelingAuditTrailInquiry_DateFromFilter")]
    protected Primitive<DateTime> _DateFromFilter;
    [DataMember(EmitDefaultValue = false, Name = "ModelingAuditTrailInquiry_ParentRevision")]
    protected Primitive<string> _ParentRevision;
    [DataMember(EmitDefaultValue = false, Name = "ModelingAuditTrailInquiry_PackageName")]
    protected Primitive<string> _PackageName;

    public override bool Equals(object obj)
    {
      return obj is ModelingAuditTrailInquiry && object.Equals((object) this._ObjectTypeName, (object) ((ModelingAuditTrailInquiry) obj)._ObjectTypeName) && (object.Equals((object) this._SelectedHeader, (object) ((ModelingAuditTrailInquiry) obj)._SelectedHeader) && object.Equals((object) this._AuditTrailDetail, (object) ((ModelingAuditTrailInquiry) obj)._AuditTrailDetail)) && (object.Equals((object) this._ObjectName, (object) ((ModelingAuditTrailInquiry) obj)._ObjectName) && this.CompareArrays((Array) this._Headers, (Array) ((ModelingAuditTrailInquiry) obj)._Headers) && (object.Equals((object) this._Recursive, (object) ((ModelingAuditTrailInquiry) obj)._Recursive) && object.Equals((object) this._ObjectInstanceId, (object) ((ModelingAuditTrailInquiry) obj)._ObjectInstanceId))) && (object.Equals((object) this._ObjectRevisionOrParent, (object) ((ModelingAuditTrailInquiry) obj)._ObjectRevisionOrParent) && object.Equals((object) this._ModelingAuditListSize, (object) ((ModelingAuditTrailInquiry) obj)._ModelingAuditListSize) && (object.Equals((object) this._ModelingAuditStartRow, (object) ((ModelingAuditTrailInquiry) obj)._ModelingAuditStartRow) && object.Equals((object) this._ObjectType, (object) ((ModelingAuditTrailInquiry) obj)._ObjectType)) && (object.Equals((object) this._ParentType, (object) ((ModelingAuditTrailInquiry) obj)._ParentType) && object.Equals((object) this._DateToFilter, (object) ((ModelingAuditTrailInquiry) obj)._DateToFilter) && (object.Equals((object) this._SelectedObjectId, (object) ((ModelingAuditTrailInquiry) obj)._SelectedObjectId) && object.Equals((object) this._DateFromFilter, (object) ((ModelingAuditTrailInquiry) obj)._DateFromFilter)))) && (object.Equals((object) this._ParentRevision, (object) ((ModelingAuditTrailInquiry) obj)._ParentRevision) && object.Equals((object) this._PackageName, (object) ((ModelingAuditTrailInquiry) obj)._PackageName)) && base.Equals(obj);
    }

    public Enumeration<MaintainableObjectEnum, string> ObjectTypeName
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectTypeName), (object) value);
      }
      get
      {
        return (Enumeration<MaintainableObjectEnum, string>) this.PropertyGet(nameof (ObjectTypeName));
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

    public ModelingAuditTrail AuditTrailDetail
    {
      [param: In] set
      {
        this.PropertySet(nameof (AuditTrailDetail), (object) value);
      }
      get
      {
        return (ModelingAuditTrail) this.PropertyGet(nameof (AuditTrailDetail));
      }
    }

    public Primitive<string> ObjectName
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectName), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (ObjectName));
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

    public Primitive<bool> Recursive
    {
      [param: In] set
      {
        this.PropertySet(nameof (Recursive), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (Recursive));
      }
    }

    public Primitive<string> ObjectInstanceId
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectInstanceId), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (ObjectInstanceId));
      }
    }

    public Primitive<string> ObjectRevisionOrParent
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectRevisionOrParent), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (ObjectRevisionOrParent));
      }
    }

    public Primitive<int> ModelingAuditListSize
    {
      [param: In] set
      {
        this.PropertySet(nameof (ModelingAuditListSize), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (ModelingAuditListSize));
      }
    }

    public Primitive<int> ModelingAuditStartRow
    {
      [param: In] set
      {
        this.PropertySet(nameof (ModelingAuditStartRow), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (ModelingAuditStartRow));
      }
    }

    public Primitive<int> ObjectType
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectType), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (ObjectType));
      }
    }

    public Primitive<int> ParentType
    {
      [param: In] set
      {
        this.PropertySet(nameof (ParentType), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (ParentType));
      }
    }

    public Primitive<DateTime> DateToFilter
    {
      [param: In] set
      {
        this.PropertySet(nameof (DateToFilter), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (DateToFilter));
      }
    }

    public Primitive<string> SelectedObjectId
    {
      [param: In] set
      {
        this.PropertySet(nameof (SelectedObjectId), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (SelectedObjectId));
      }
    }

    public Primitive<DateTime> DateFromFilter
    {
      [param: In] set
      {
        this.PropertySet(nameof (DateFromFilter), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (DateFromFilter));
      }
    }

    public Primitive<string> ParentRevision
    {
      [param: In] set
      {
        this.PropertySet(nameof (ParentRevision), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (ParentRevision));
      }
    }

    public Primitive<string> PackageName
    {
      [param: In] set
      {
        this.PropertySet(nameof (PackageName), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (PackageName));
      }
    }
  }
}
