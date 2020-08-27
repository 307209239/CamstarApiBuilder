// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ModelingESigHistoryDetail
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
  public class ModelingESigHistoryDetail : Subentity
  {
    [DataMember(EmitDefaultValue = false, Name = "ModelingESigHistoryDetail_CosignReason")]
    protected NamedObjectRef _CosignReason;
    [DataMember(EmitDefaultValue = false, Name = "ModelingESigHistoryDetail_SignerRole")]
    protected NamedObjectRef _SignerRole;
    [DataMember(EmitDefaultValue = false, Name = "ModelingESigHistoryDetail_CosignerRole")]
    protected NamedObjectRef _CosignerRole;
    [DataMember(EmitDefaultValue = false, Name = "ModelingESigHistoryDetail_Meaning")]
    protected NamedObjectRef _Meaning;
    [DataMember(EmitDefaultValue = false, Name = "ModelingESigHistoryDetail_Comments")]
    protected Primitive<string> _Comments;
    [DataMember(EmitDefaultValue = false, Name = "ModelingESigHistoryDetail_VerificationMethod")]
    protected Enumeration<ESigVerificationMethodEnum, int> _VerificationMethod;
    [DataMember(EmitDefaultValue = false, Name = "ModelingESigHistoryDetail_ExportImportKey")]
    protected new Primitive<string> _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "ModelingESigHistoryDetail_IsFrozen")]
    protected Primitive<bool> _IsFrozen;
    [DataMember(EmitDefaultValue = false, Name = "ModelingESigHistoryDetail_CosignerFullName")]
    protected Primitive<string> _CosignerFullName;
    [DataMember(EmitDefaultValue = false, Name = "ModelingESigHistoryDetail_SignerFullName")]
    protected Primitive<string> _SignerFullName;

    public override bool Equals(object obj)
    {
      return obj is ModelingESigHistoryDetail && object.Equals((object) this._CosignReason, (object) ((ModelingESigHistoryDetail) obj)._CosignReason) && (object.Equals((object) this._SignerRole, (object) ((ModelingESigHistoryDetail) obj)._SignerRole) && object.Equals((object) this._CosignerRole, (object) ((ModelingESigHistoryDetail) obj)._CosignerRole)) && (object.Equals((object) this._Meaning, (object) ((ModelingESigHistoryDetail) obj)._Meaning) && object.Equals((object) this._Comments, (object) ((ModelingESigHistoryDetail) obj)._Comments) && (object.Equals((object) this._VerificationMethod, (object) ((ModelingESigHistoryDetail) obj)._VerificationMethod) && object.Equals((object) this._ExportImportKey, (object) ((ModelingESigHistoryDetail) obj)._ExportImportKey))) && (object.Equals((object) this._IsFrozen, (object) ((ModelingESigHistoryDetail) obj)._IsFrozen) && object.Equals((object) this._CosignerFullName, (object) ((ModelingESigHistoryDetail) obj)._CosignerFullName) && object.Equals((object) this._SignerFullName, (object) ((ModelingESigHistoryDetail) obj)._SignerFullName)) && base.Equals(obj);
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

    public NamedObjectRef SignerRole
    {
      [param: In] set
      {
        this.PropertySet(nameof (SignerRole), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (SignerRole));
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

    public Primitive<bool> IsFrozen
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsFrozen), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (IsFrozen));
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
  }
}
