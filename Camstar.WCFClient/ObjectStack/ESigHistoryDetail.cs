// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ESigHistoryDetail
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
  public class ESigHistoryDetail : ServiceHistoryDetail
  {
    [DataMember(EmitDefaultValue = false, Name = "ESigHistoryDetail_ExportImportKey")]
    protected new Primitive<string> _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "ESigHistoryDetail_CosignReason")]
    protected NamedObjectRef _CosignReason;
    [DataMember(EmitDefaultValue = false, Name = "ESigHistoryDetail_VerificationMethod")]
    protected Enumeration<ESigVerificationMethodEnum, int> _VerificationMethod;
    [DataMember(EmitDefaultValue = false, Name = "ESigHistoryDetail_ESigRequirement")]
    protected NamedObjectRef _ESigRequirement;
    [DataMember(EmitDefaultValue = false, Name = "ESigHistoryDetail_DisplayName")]
    protected new Primitive<string> _DisplayName;
    [DataMember(EmitDefaultValue = false, Name = "ESigHistoryDetail_Comments")]
    protected Primitive<string> _Comments;
    [DataMember(EmitDefaultValue = false, Name = "ESigHistoryDetail_HistoryId")]
    protected new BaseObjectRef _HistoryId;
    [DataMember(EmitDefaultValue = false, Name = "ESigHistoryDetail_Signer")]
    protected NamedObjectRef _Signer;
    [DataMember(EmitDefaultValue = false, Name = "ESigHistoryDetail_CosignerRoleName")]
    protected Primitive<string> _CosignerRoleName;
    [DataMember(EmitDefaultValue = false, Name = "ESigHistoryDetail_CosignReasonName")]
    protected Primitive<string> _CosignReasonName;
    [DataMember(EmitDefaultValue = false, Name = "ESigHistoryDetail_MeaningName")]
    protected Primitive<string> _MeaningName;
    [DataMember(EmitDefaultValue = false, Name = "ESigHistoryDetail_RoleName")]
    protected Primitive<string> _RoleName;
    [DataMember(EmitDefaultValue = false, Name = "ESigHistoryDetail_CosignerFullName")]
    protected Primitive<string> _CosignerFullName;
    [DataMember(EmitDefaultValue = false, Name = "ESigHistoryDetail_SignerFullName")]
    protected Primitive<string> _SignerFullName;
    [DataMember(EmitDefaultValue = false, Name = "ESigHistoryDetail_Cosigner")]
    protected NamedObjectRef _Cosigner;

    public override bool Equals(object obj)
    {
      return obj is ESigHistoryDetail && object.Equals((object) this._ExportImportKey, (object) ((ESigHistoryDetail) obj)._ExportImportKey) && (object.Equals((object) this._CosignReason, (object) ((ESigHistoryDetail) obj)._CosignReason) && object.Equals((object) this._VerificationMethod, (object) ((ESigHistoryDetail) obj)._VerificationMethod)) && (object.Equals((object) this._ESigRequirement, (object) ((ESigHistoryDetail) obj)._ESigRequirement) && object.Equals((object) this._DisplayName, (object) ((ESigHistoryDetail) obj)._DisplayName) && (object.Equals((object) this._Comments, (object) ((ESigHistoryDetail) obj)._Comments) && object.Equals((object) this._HistoryId, (object) ((ESigHistoryDetail) obj)._HistoryId))) && (object.Equals((object) this._Signer, (object) ((ESigHistoryDetail) obj)._Signer) && object.Equals((object) this._CosignerRoleName, (object) ((ESigHistoryDetail) obj)._CosignerRoleName) && (object.Equals((object) this._CosignReasonName, (object) ((ESigHistoryDetail) obj)._CosignReasonName) && object.Equals((object) this._MeaningName, (object) ((ESigHistoryDetail) obj)._MeaningName)) && (object.Equals((object) this._RoleName, (object) ((ESigHistoryDetail) obj)._RoleName) && object.Equals((object) this._CosignerFullName, (object) ((ESigHistoryDetail) obj)._CosignerFullName) && (object.Equals((object) this._SignerFullName, (object) ((ESigHistoryDetail) obj)._SignerFullName) && object.Equals((object) this._Cosigner, (object) ((ESigHistoryDetail) obj)._Cosigner)))) && base.Equals(obj);
    }

    public new Primitive<string> ExportImportKey
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExportImportKey), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (ExportImportKey));
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

    public NamedObjectRef ESigRequirement
    {
      [param: In] set
      {
        this.PropertySet(nameof (ESigRequirement), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (ESigRequirement));
      }
    }

    public new Primitive<string> DisplayName
    {
      [param: In] set
      {
        this.PropertySet(nameof (DisplayName), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (DisplayName));
      }
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

    public new BaseObjectRef HistoryId
    {
      [param: In] set
      {
        this.PropertySet(nameof (HistoryId), (object) value);
      }
      get
      {
        return (BaseObjectRef) this.PropertyGet(nameof (HistoryId));
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

    public Primitive<string> CosignerRoleName
    {
      [param: In] set
      {
        this.PropertySet(nameof (CosignerRoleName), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (CosignerRoleName));
      }
    }

    public Primitive<string> CosignReasonName
    {
      [param: In] set
      {
        this.PropertySet(nameof (CosignReasonName), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (CosignReasonName));
      }
    }

    public Primitive<string> MeaningName
    {
      [param: In] set
      {
        this.PropertySet(nameof (MeaningName), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (MeaningName));
      }
    }

    public Primitive<string> RoleName
    {
      [param: In] set
      {
        this.PropertySet(nameof (RoleName), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (RoleName));
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
  }
}
