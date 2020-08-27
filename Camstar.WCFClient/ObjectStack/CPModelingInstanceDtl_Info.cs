// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.CPModelingInstanceDtl_Info
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
  public class CPModelingInstanceDtl_Info : ServiceDetails_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "CPModelingInstanceDtl_Info_ObjectTypeValue")]
    protected Info _ObjectTypeValue;
    [DataMember(EmitDefaultValue = false, Name = "CPModelingInstanceDtl_Info_ObjectName")]
    protected Info _ObjectName;
    [DataMember(EmitDefaultValue = false, Name = "CPModelingInstanceDtl_Info_DisplayedName")]
    protected Info _DisplayedName;
    [DataMember(EmitDefaultValue = false, Name = "CPModelingInstanceDtl_Info_Sequence")]
    protected Info _Sequence;
    [DataMember(EmitDefaultValue = false, Name = "CPModelingInstanceDtl_Info_ObjectTypeName")]
    protected Info _ObjectTypeName;
    [DataMember(EmitDefaultValue = false, Name = "CPModelingInstanceDtl_Info_LastUpdatedDate")]
    protected Info _LastUpdatedDate;
    [DataMember(EmitDefaultValue = false, Name = "CPModelingInstanceDtl_Info_AddedToPackageGMT")]
    protected Info _AddedToPackageGMT;
    [DataMember(EmitDefaultValue = false, Name = "CPModelingInstanceDtl_Info_RDORef")]
    protected Info _RDORef;
    [DataMember(EmitDefaultValue = false, Name = "CPModelingInstanceDtl_Info_NDORef")]
    protected Info _NDORef;
    [DataMember(EmitDefaultValue = false, Name = "CPModelingInstanceDtl_Info_IsROR")]
    protected Info _IsROR;
    [DataMember(EmitDefaultValue = false, Name = "CPModelingInstanceDtl_Info_ObjectInstanceId")]
    protected Info _ObjectInstanceId;
    [DataMember(EmitDefaultValue = false, Name = "CPModelingInstanceDtl_Info_IsBadReference")]
    protected Info _IsBadReference;
    [DataMember(EmitDefaultValue = false, Name = "CPModelingInstanceDtl_Info_IsReference")]
    protected Info _IsReference;
    [DataMember(EmitDefaultValue = false, Name = "CPModelingInstanceDtl_Info_ObjectType")]
    protected Info _ObjectType;
    [DataMember(EmitDefaultValue = false, Name = "CPModelingInstanceDtl_Info_LastUpdatedBy")]
    protected Info _LastUpdatedBy;
    [DataMember(EmitDefaultValue = false, Name = "CPModelingInstanceDtl_Info_ErrorMessage")]
    protected Info _ErrorMessage;
    [DataMember(EmitDefaultValue = false, Name = "CPModelingInstanceDtl_Info_Revision")]
    protected Info _Revision;
    [DataMember(EmitDefaultValue = false, Name = "CPModelingInstanceDtl_Info_Description")]
    protected Info _Description;

    public Info ObjectTypeValue
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectTypeValue), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ObjectTypeValue));
      }
    }

    public Info ObjectName
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectName), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ObjectName));
      }
    }

    public Info DisplayedName
    {
      [param: In] set
      {
        this.PropertySet(nameof (DisplayedName), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (DisplayedName));
      }
    }

    public Info Sequence
    {
      [param: In] set
      {
        this.PropertySet(nameof (Sequence), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Sequence));
      }
    }

    public Info ObjectTypeName
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectTypeName), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ObjectTypeName));
      }
    }

    public Info LastUpdatedDate
    {
      [param: In] set
      {
        this.PropertySet(nameof (LastUpdatedDate), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (LastUpdatedDate));
      }
    }

    public Info AddedToPackageGMT
    {
      [param: In] set
      {
        this.PropertySet(nameof (AddedToPackageGMT), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (AddedToPackageGMT));
      }
    }

    public Info RDORef
    {
      [param: In] set
      {
        this.PropertySet(nameof (RDORef), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (RDORef));
      }
    }

    public Info NDORef
    {
      [param: In] set
      {
        this.PropertySet(nameof (NDORef), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (NDORef));
      }
    }

    public Info IsROR
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsROR), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (IsROR));
      }
    }

    public Info ObjectInstanceId
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectInstanceId), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ObjectInstanceId));
      }
    }

    public Info IsBadReference
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsBadReference), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (IsBadReference));
      }
    }

    public Info IsReference
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsReference), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (IsReference));
      }
    }

    public Info ObjectType
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectType), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ObjectType));
      }
    }

    public Info LastUpdatedBy
    {
      [param: In] set
      {
        this.PropertySet(nameof (LastUpdatedBy), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (LastUpdatedBy));
      }
    }

    public Info ErrorMessage
    {
      [param: In] set
      {
        this.PropertySet(nameof (ErrorMessage), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ErrorMessage));
      }
    }

    public Info Revision
    {
      [param: In] set
      {
        this.PropertySet(nameof (Revision), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Revision));
      }
    }

    public Info Description
    {
      [param: In] set
      {
        this.PropertySet(nameof (Description), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Description));
      }
    }
  }
}
