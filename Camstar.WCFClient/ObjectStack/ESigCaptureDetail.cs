// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ESigCaptureDetail
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Camstar.WCF.ObjectStack
{
  [KnownType(typeof (ESigPasswordCapture))]
  [DataContract(Namespace = "Camstar.WCF.ObjectStack")]
  [Serializable]
  public class ESigCaptureDetail : ServiceDetails
  {
    [DataMember(EmitDefaultValue = false, Name = "ESigCaptureDetail_Comments")]
    protected Primitive<string> _Comments;
    [DataMember(EmitDefaultValue = false, Name = "ESigCaptureDetail_CosignReason")]
    protected NamedObjectRef _CosignReason;
    [DataMember(EmitDefaultValue = false, Name = "ESigCaptureDetail_Cosigner")]
    protected NamedObjectRef _Cosigner;
    [DataMember(EmitDefaultValue = false, Name = "ESigCaptureDetail_Signer")]
    protected NamedObjectRef _Signer;
    [DataMember(EmitDefaultValue = false, Name = "ESigCaptureDetail_SignerFullName")]
    protected Primitive<string> _SignerFullName;
    [DataMember(EmitDefaultValue = false, Name = "ESigCaptureDetail_CosignerFullName")]
    protected Primitive<string> _CosignerFullName;

    public override bool Equals(object obj)
    {
      return obj is ESigCaptureDetail && object.Equals((object) this._Comments, (object) ((ESigCaptureDetail) obj)._Comments) && (object.Equals((object) this._CosignReason, (object) ((ESigCaptureDetail) obj)._CosignReason) && object.Equals((object) this._Cosigner, (object) ((ESigCaptureDetail) obj)._Cosigner)) && (object.Equals((object) this._Signer, (object) ((ESigCaptureDetail) obj)._Signer) && object.Equals((object) this._SignerFullName, (object) ((ESigCaptureDetail) obj)._SignerFullName) && object.Equals((object) this._CosignerFullName, (object) ((ESigCaptureDetail) obj)._CosignerFullName)) && base.Equals(obj);
    }

    public Primitive<string> Comments
    {
      [param: In] set
      {
        this.PropertySet(nameof (Comments), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (Comments));
      }
    }

    public NamedObjectRef CosignReason
    {
      [param: In] set
      {
        this.PropertySet(nameof (CosignReason), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (CosignReason));
      }
    }

    public NamedObjectRef Cosigner
    {
      [param: In] set
      {
        this.PropertySet(nameof (Cosigner), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (Cosigner));
      }
    }

    public NamedObjectRef Signer
    {
      [param: In] set
      {
        this.PropertySet(nameof (Signer), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (Signer));
      }
    }

    public Primitive<string> SignerFullName
    {
      [param: In] set
      {
        this.PropertySet(nameof (SignerFullName), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (SignerFullName));
      }
    }

    public Primitive<string> CosignerFullName
    {
      [param: In] set
      {
        this.PropertySet(nameof (CosignerFullName), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (CosignerFullName));
      }
    }
  }
}
