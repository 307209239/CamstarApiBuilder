// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ModelingESigHistoryDetail_Info
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
  public class ModelingESigHistoryDetail_Info : Subentity_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "ModelingESigHistoryDetail_Info_CosignReason")]
    protected Info _CosignReason;
    [DataMember(EmitDefaultValue = false, Name = "ModelingESigHistoryDetail_Info_SignerRole")]
    protected Info _SignerRole;
    [DataMember(EmitDefaultValue = false, Name = "ModelingESigHistoryDetail_Info_CosignerRole")]
    protected Info _CosignerRole;
    [DataMember(EmitDefaultValue = false, Name = "ModelingESigHistoryDetail_Info_Meaning")]
    protected Info _Meaning;
    [DataMember(EmitDefaultValue = false, Name = "ModelingESigHistoryDetail_Info_Comments")]
    protected Info _Comments;
    [DataMember(EmitDefaultValue = false, Name = "ModelingESigHistoryDetail_Info_VerificationMethod")]
    protected Info _VerificationMethod;
    [DataMember(EmitDefaultValue = false, Name = "ModelingESigHistoryDetail_Info_ExportImportKey")]
    protected new Info _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "ModelingESigHistoryDetail_Info_IsFrozen")]
    protected Info _IsFrozen;
    [DataMember(EmitDefaultValue = false, Name = "ModelingESigHistoryDetail_Info_CosignerFullName")]
    protected Info _CosignerFullName;
    [DataMember(EmitDefaultValue = false, Name = "ModelingESigHistoryDetail_Info_SignerFullName")]
    protected Info _SignerFullName;

    public Info CosignReason
    {
      [param: In] set
      {
        this.PropertySet(nameof (CosignReason), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (CosignReason));
      }
    }

    public Info SignerRole
    {
      [param: In] set
      {
        this.PropertySet(nameof (SignerRole), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (SignerRole));
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

    public Info Comments
    {
      [param: In] set
      {
        this.PropertySet(nameof (Comments), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Comments));
      }
    }

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

    public new Info ExportImportKey
    {
      [param: In] set
      {
        this.PropertySet(nameof (ExportImportKey), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ExportImportKey));
      }
    }

    public Info IsFrozen
    {
      [param: In] set
      {
        this.PropertySet(nameof (IsFrozen), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (IsFrozen));
      }
    }

    public Info CosignerFullName
    {
      [param: In] set
      {
        this.PropertySet(nameof (CosignerFullName), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (CosignerFullName));
      }
    }

    public Info SignerFullName
    {
      [param: In] set
      {
        this.PropertySet(nameof (SignerFullName), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (SignerFullName));
      }
    }
  }
}
