// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.CPModelingInstanceDtl
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
  public class CPModelingInstanceDtl : ServiceDetails
  {
    [DataMember(EmitDefaultValue = false, Name = "CPModelingInstanceDtl_ObjectTypeValue")]
    protected Primitive<string> _ObjectTypeValue;
    [DataMember(EmitDefaultValue = false, Name = "CPModelingInstanceDtl_ObjectName")]
    protected Primitive<string> _ObjectName;
    [DataMember(EmitDefaultValue = false, Name = "CPModelingInstanceDtl_DisplayedName")]
    protected Primitive<string> _DisplayedName;
    [DataMember(EmitDefaultValue = false, Name = "CPModelingInstanceDtl_Sequence")]
    protected Primitive<int> _Sequence;
    [DataMember(EmitDefaultValue = false, Name = "CPModelingInstanceDtl_ObjectTypeName")]
    protected Enumeration<MaintainableObjectEnum, string> _ObjectTypeName;
    [DataMember(EmitDefaultValue = false, Name = "CPModelingInstanceDtl_LastUpdatedDate")]
    protected Primitive<DateTime> _LastUpdatedDate;
    [DataMember(EmitDefaultValue = false, Name = "CPModelingInstanceDtl_AddedToPackageGMT")]
    protected Primitive<DateTime> _AddedToPackageGMT;
    [DataMember(EmitDefaultValue = false, Name = "CPModelingInstanceDtl_RDORef")]
    protected RevisionedObjectRef _RDORef;
    [DataMember(EmitDefaultValue = false, Name = "CPModelingInstanceDtl_NDORef")]
    protected NamedObjectRef _NDORef;
    [DataMember(EmitDefaultValue = false, Name = "CPModelingInstanceDtl_IsROR")]
    protected Primitive<bool> _IsROR;
    [DataMember(EmitDefaultValue = false, Name = "CPModelingInstanceDtl_ObjectInstanceId")]
    protected Primitive<string> _ObjectInstanceId;
    [DataMember(EmitDefaultValue = false, Name = "CPModelingInstanceDtl_IsBadReference")]
    protected Primitive<bool> _IsBadReference;
    [DataMember(EmitDefaultValue = false, Name = "CPModelingInstanceDtl_IsReference")]
    protected Primitive<bool> _IsReference;
    [DataMember(EmitDefaultValue = false, Name = "CPModelingInstanceDtl_ObjectType")]
    protected Primitive<int> _ObjectType;
    [DataMember(EmitDefaultValue = false, Name = "CPModelingInstanceDtl_LastUpdatedBy")]
    protected NamedObjectRef _LastUpdatedBy;
    [DataMember(EmitDefaultValue = false, Name = "CPModelingInstanceDtl_ErrorMessage")]
    protected Primitive<string> _ErrorMessage;
    [DataMember(EmitDefaultValue = false, Name = "CPModelingInstanceDtl_Revision")]
    protected Primitive<string> _Revision;
    [DataMember(EmitDefaultValue = false, Name = "CPModelingInstanceDtl_Description")]
    protected Primitive<string> _Description;

    public override bool Equals(object obj)
    {
      return obj is CPModelingInstanceDtl && object.Equals((object) this._ObjectTypeValue, (object) ((CPModelingInstanceDtl) obj)._ObjectTypeValue) && (object.Equals((object) this._ObjectName, (object) ((CPModelingInstanceDtl) obj)._ObjectName) && object.Equals((object) this._DisplayedName, (object) ((CPModelingInstanceDtl) obj)._DisplayedName)) && (object.Equals((object) this._Sequence, (object) ((CPModelingInstanceDtl) obj)._Sequence) && object.Equals((object) this._ObjectTypeName, (object) ((CPModelingInstanceDtl) obj)._ObjectTypeName) && (object.Equals((object) this._LastUpdatedDate, (object) ((CPModelingInstanceDtl) obj)._LastUpdatedDate) && object.Equals((object) this._AddedToPackageGMT, (object) ((CPModelingInstanceDtl) obj)._AddedToPackageGMT))) && (object.Equals((object) this._RDORef, (object) ((CPModelingInstanceDtl) obj)._RDORef) && object.Equals((object) this._NDORef, (object) ((CPModelingInstanceDtl) obj)._NDORef) && (object.Equals((object) this._IsROR, (object) ((CPModelingInstanceDtl) obj)._IsROR) && object.Equals((object) this._ObjectInstanceId, (object) ((CPModelingInstanceDtl) obj)._ObjectInstanceId)) && (object.Equals((object) this._IsBadReference, (object) ((CPModelingInstanceDtl) obj)._IsBadReference) && object.Equals((object) this._IsReference, (object) ((CPModelingInstanceDtl) obj)._IsReference) && (object.Equals((object) this._ObjectType, (object) ((CPModelingInstanceDtl) obj)._ObjectType) && object.Equals((object) this._LastUpdatedBy, (object) ((CPModelingInstanceDtl) obj)._LastUpdatedBy)))) && (object.Equals((object) this._ErrorMessage, (object) ((CPModelingInstanceDtl) obj)._ErrorMessage) && object.Equals((object) this._Revision, (object) ((CPModelingInstanceDtl) obj)._Revision) && object.Equals((object) this._Description, (object) ((CPModelingInstanceDtl) obj)._Description)) && base.Equals(obj);
    }

    public Primitive<string> ObjectTypeValue
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectTypeValue), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (ObjectTypeValue));
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

    public Primitive<string> DisplayedName
    {
      [param: In] set
      {
        this.PropertySet(nameof (DisplayedName), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (DisplayedName));
      }
    }

    public Primitive<int> Sequence
    {
      [param: In] set
      {
        this.PropertySet(nameof (Sequence), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (Sequence));
      }
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

    public Primitive<DateTime> LastUpdatedDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (LastUpdatedDate), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (LastUpdatedDate));
      }
    }

    public Primitive<DateTime> AddedToPackageGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (AddedToPackageGMT), (object) value);
      }
      get
      {
        return (Primitive<DateTime>) this.PropertyGet(nameof (AddedToPackageGMT));
      }
    }

    public RevisionedObjectRef RDORef
    {
      [param: In] set
      {
        this.PropertySet(nameof (RDORef), (object) value);
      }
      get
      {
        return (RevisionedObjectRef) this.PropertyGet(nameof (RDORef));
      }
    }

    public NamedObjectRef NDORef
    {
      [param: In] set
      {
        this.PropertySet(nameof (NDORef), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (NDORef));
      }
    }

    public Primitive<bool> IsROR
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsROR), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (IsROR));
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

    public Primitive<bool> IsBadReference
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsBadReference), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (IsBadReference));
      }
    }

    public Primitive<bool> IsReference
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsReference), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (IsReference));
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

    public NamedObjectRef LastUpdatedBy
    {
      [param: In] set
      {
        this.PropertySet(nameof (LastUpdatedBy), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (LastUpdatedBy));
      }
    }

    public Primitive<string> ErrorMessage
    {
      [param: In] set
      {
        this.PropertySet(nameof (ErrorMessage), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (ErrorMessage));
      }
    }

    public Primitive<string> Revision
    {
      [param: In] set
      {
        this.PropertySet(nameof (Revision), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (Revision));
      }
    }

    public Primitive<string> Description
    {
      [param: In] set
      {
        this.PropertySet(nameof (Description), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (Description));
      }
    }
  }
}
