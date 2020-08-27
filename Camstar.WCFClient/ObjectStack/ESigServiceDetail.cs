// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ESigServiceDetail
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
  public class ESigServiceDetail : ServiceDetails
  {
    [DataMember(EmitDefaultValue = false, Name = "ESigServiceDetail_VerificationMethod")]
    protected Enumeration<ESigVerificationMethodEnum, int> _VerificationMethod;
    [DataMember(EmitDefaultValue = false, Name = "ESigServiceDetail_Role")]
    protected NamedObjectRef _Role;
    [DataMember(EmitDefaultValue = false, Name = "ESigServiceDetail_Meaning")]
    protected NamedObjectRef _Meaning;
    [DataMember(EmitDefaultValue = false, Name = "ESigServiceDetail_CosignerRole")]
    protected NamedObjectRef _CosignerRole;
    [DataMember(EmitDefaultValue = false, Name = "ESigServiceDetail_CaptureDetails")]
    protected ESigCaptureDetail[] _CaptureDetails;
    [DataMember(EmitDefaultValue = false, Name = "ESigServiceDetail_ESigReqDetail")]
    protected NamedSubentityRef _ESigReqDetail;
    [DataMember(EmitDefaultValue = false, Name = "ESigServiceDetail_Spec")]
    protected RevisionedObjectRef _Spec;
    [DataMember(EmitDefaultValue = false, Name = "ESigServiceDetail_UOM")]
    protected NamedObjectRef _UOM;
    [DataMember(EmitDefaultValue = false, Name = "ESigServiceDetail_SignatureCount")]
    protected Primitive<int> _SignatureCount;
    [DataMember(EmitDefaultValue = false, Name = "ESigServiceDetail_CaptureCount")]
    protected Primitive<int> _CaptureCount;
    [DataMember(EmitDefaultValue = false, Name = "ESigServiceDetail_Container")]
    protected ContainerRef _Container;
    [DataMember(EmitDefaultValue = false, Name = "ESigServiceDetail_Qty")]
    protected Primitive<double> _Qty;

    public override bool Equals(object obj)
    {
      return obj is ESigServiceDetail && object.Equals((object) this._VerificationMethod, (object) ((ESigServiceDetail) obj)._VerificationMethod) && (object.Equals((object) this._Role, (object) ((ESigServiceDetail) obj)._Role) && object.Equals((object) this._Meaning, (object) ((ESigServiceDetail) obj)._Meaning)) && (object.Equals((object) this._CosignerRole, (object) ((ESigServiceDetail) obj)._CosignerRole) && this.CompareArrays((Array) this._CaptureDetails, (Array) ((ESigServiceDetail) obj)._CaptureDetails) && (object.Equals((object) this._ESigReqDetail, (object) ((ESigServiceDetail) obj)._ESigReqDetail) && object.Equals((object) this._Spec, (object) ((ESigServiceDetail) obj)._Spec))) && (object.Equals((object) this._UOM, (object) ((ESigServiceDetail) obj)._UOM) && object.Equals((object) this._SignatureCount, (object) ((ESigServiceDetail) obj)._SignatureCount) && (object.Equals((object) this._CaptureCount, (object) ((ESigServiceDetail) obj)._CaptureCount) && object.Equals((object) this._Container, (object) ((ESigServiceDetail) obj)._Container)) && object.Equals((object) this._Qty, (object) ((ESigServiceDetail) obj)._Qty)) && base.Equals(obj);
    }

    public Enumeration<ESigVerificationMethodEnum, int> VerificationMethod
    {
      [param: In] set
      {
        this.PropertySet(nameof (VerificationMethod), (object) value);
      }
      get
      {
        return (Enumeration<ESigVerificationMethodEnum, int>) this.PropertyGet(nameof (VerificationMethod));
      }
    }

    public NamedObjectRef Role
    {
      [param: In] set
      {
        this.PropertySet(nameof (Role), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (Role));
      }
    }

    public NamedObjectRef Meaning
    {
      [param: In] set
      {
        this.PropertySet(nameof (Meaning), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (Meaning));
      }
    }

    public NamedObjectRef CosignerRole
    {
      [param: In] set
      {
        this.PropertySet(nameof (CosignerRole), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (CosignerRole));
      }
    }

    public ESigCaptureDetail[] CaptureDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (CaptureDetails), (object) value);
      }
      get
      {
        return (ESigCaptureDetail[]) this.PropertyGet(nameof (CaptureDetails));
      }
    }

    public NamedSubentityRef ESigReqDetail
    {
      [param: In] set
      {
        this.PropertySet(nameof (ESigReqDetail), (object) value);
      }
      get
      {
        return (NamedSubentityRef) this.PropertyGet(nameof (ESigReqDetail));
      }
    }

    public RevisionedObjectRef Spec
    {
      [param: In] set
      {
        this.PropertySet(nameof (Spec), (object) value);
      }
      get
      {
        return (RevisionedObjectRef) this.PropertyGet(nameof (Spec));
      }
    }

    public NamedObjectRef UOM
    {
      [param: In] set
      {
        this.PropertySet(nameof (UOM), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (UOM));
      }
    }

    public Primitive<int> SignatureCount
    {
      [param: In] set
      {
        this.PropertySet(nameof (SignatureCount), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (SignatureCount));
      }
    }

    public Primitive<int> CaptureCount
    {
      [param: In] set
      {
        this.PropertySet(nameof (CaptureCount), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (CaptureCount));
      }
    }

    public ContainerRef Container
    {
      [param: In] set
      {
        this.PropertySet(nameof (Container), (object) value);
      }
      get
      {
        return (ContainerRef) this.PropertyGet(nameof (Container));
      }
    }

    public Primitive<double> Qty
    {
      [param: In] set
      {
        this.PropertySet(nameof (Qty), (object) value);
      }
      get
      {
        return (Primitive<double>) this.PropertyGet(nameof (Qty));
      }
    }
  }
}
