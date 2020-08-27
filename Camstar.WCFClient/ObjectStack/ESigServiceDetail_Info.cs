// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ESigServiceDetail_Info
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
  public class ESigServiceDetail_Info : ServiceDetails_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "ESigServiceDetail_Info_VerificationMethod")]
    protected Info _VerificationMethod;
    [DataMember(EmitDefaultValue = false, Name = "ESigServiceDetail_Info_Role")]
    protected Info _Role;
    [DataMember(EmitDefaultValue = false, Name = "ESigServiceDetail_Info_Meaning")]
    protected Info _Meaning;
    [DataMember(EmitDefaultValue = false, Name = "ESigServiceDetail_Info_CosignerRole")]
    protected Info _CosignerRole;
    [DataMember(EmitDefaultValue = false, Name = "ESigServiceDetail_Info_CaptureDetails")]
    protected ESigCaptureDetail_Info _CaptureDetails;
    [DataMember(EmitDefaultValue = false, Name = "ESigServiceDetail_Info_ESigReqDetail")]
    protected Info _ESigReqDetail;
    [DataMember(EmitDefaultValue = false, Name = "ESigServiceDetail_Info_Spec")]
    protected Info _Spec;
    [DataMember(EmitDefaultValue = false, Name = "ESigServiceDetail_Info_UOM")]
    protected Info _UOM;
    [DataMember(EmitDefaultValue = false, Name = "ESigServiceDetail_Info_SignatureCount")]
    protected Info _SignatureCount;
    [DataMember(EmitDefaultValue = false, Name = "ESigServiceDetail_Info_CaptureCount")]
    protected Info _CaptureCount;
    [DataMember(EmitDefaultValue = false, Name = "ESigServiceDetail_Info_Container")]
    protected Info _Container;
    [DataMember(EmitDefaultValue = false, Name = "ESigServiceDetail_Info_Qty")]
    protected Info _Qty;

    public Info VerificationMethod
    {
      [param: In] set
      {
        this.PropertySet(nameof (VerificationMethod), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (VerificationMethod));
      }
    }

    public Info Role
    {
      [param: In] set
      {
        this.PropertySet(nameof (Role), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Role));
      }
    }

    public Info Meaning
    {
      [param: In] set
      {
        this.PropertySet(nameof (Meaning), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Meaning));
      }
    }

    public Info CosignerRole
    {
      [param: In] set
      {
        this.PropertySet(nameof (CosignerRole), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (CosignerRole));
      }
    }

    public ESigCaptureDetail_Info CaptureDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (CaptureDetails), (object) value);
      }
      get
      {
        return (ESigCaptureDetail_Info) this.PropertyGet(nameof (CaptureDetails));
      }
    }

    public Info ESigReqDetail
    {
      [param: In] set
      {
        this.PropertySet(nameof (ESigReqDetail), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ESigReqDetail));
      }
    }

    public Info Spec
    {
      [param: In] set
      {
        this.PropertySet(nameof (Spec), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Spec));
      }
    }

    public Info UOM
    {
      [param: In] set
      {
        this.PropertySet(nameof (UOM), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (UOM));
      }
    }

    public Info SignatureCount
    {
      [param: In] set
      {
        this.PropertySet(nameof (SignatureCount), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (SignatureCount));
      }
    }

    public Info CaptureCount
    {
      [param: In] set
      {
        this.PropertySet(nameof (CaptureCount), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (CaptureCount));
      }
    }

    public Info Container
    {
      [param: In] set
      {
        this.PropertySet(nameof (Container), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Container));
      }
    }

    public Info Qty
    {
      [param: In] set
      {
        this.PropertySet(nameof (Qty), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Qty));
      }
    }
  }
}
