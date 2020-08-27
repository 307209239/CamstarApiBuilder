// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ESigHistoryDetail_Info
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
  public class ESigHistoryDetail_Info : ServiceHistoryDetail_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "ESigHistoryDetail_Info_ExportImportKey")]
    protected new Info _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "ESigHistoryDetail_Info_CosignReason")]
    protected Info _CosignReason;
    [DataMember(EmitDefaultValue = false, Name = "ESigHistoryDetail_Info_VerificationMethod")]
    protected Info _VerificationMethod;
    [DataMember(EmitDefaultValue = false, Name = "ESigHistoryDetail_Info_ESigRequirement")]
    protected Info _ESigRequirement;
    [DataMember(EmitDefaultValue = false, Name = "ESigHistoryDetail_Info_DisplayName")]
    protected new Info _DisplayName;
    [DataMember(EmitDefaultValue = false, Name = "ESigHistoryDetail_Info_Comments")]
    protected Info _Comments;
    [DataMember(EmitDefaultValue = false, Name = "ESigHistoryDetail_Info_HistoryId")]
    protected new Info _HistoryId;
    [DataMember(EmitDefaultValue = false, Name = "ESigHistoryDetail_Info_Signer")]
    protected Info _Signer;
    [DataMember(EmitDefaultValue = false, Name = "ESigHistoryDetail_Info_CosignerRoleName")]
    protected Info _CosignerRoleName;
    [DataMember(EmitDefaultValue = false, Name = "ESigHistoryDetail_Info_CosignReasonName")]
    protected Info _CosignReasonName;
    [DataMember(EmitDefaultValue = false, Name = "ESigHistoryDetail_Info_MeaningName")]
    protected Info _MeaningName;
    [DataMember(EmitDefaultValue = false, Name = "ESigHistoryDetail_Info_RoleName")]
    protected Info _RoleName;
    [DataMember(EmitDefaultValue = false, Name = "ESigHistoryDetail_Info_CosignerFullName")]
    protected Info _CosignerFullName;
    [DataMember(EmitDefaultValue = false, Name = "ESigHistoryDetail_Info_SignerFullName")]
    protected Info _SignerFullName;
    [DataMember(EmitDefaultValue = false, Name = "ESigHistoryDetail_Info_Cosigner")]
    protected Info _Cosigner;

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

    public Info ESigRequirement
    {
      [param: In] set
      {
        this.PropertySet(nameof (ESigRequirement), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ESigRequirement));
      }
    }

    public new Info DisplayName
    {
      [param: In] set
      {
        this.PropertySet(nameof (DisplayName), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (DisplayName));
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

    public new Info HistoryId
    {
      [param: In] set
      {
        this.PropertySet(nameof (HistoryId), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (HistoryId));
      }
    }

    public Info Signer
    {
      [param: In] set
      {
        this.PropertySet(nameof (Signer), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Signer));
      }
    }

    public Info CosignerRoleName
    {
      [param: In] set
      {
        this.PropertySet(nameof (CosignerRoleName), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (CosignerRoleName));
      }
    }

    public Info CosignReasonName
    {
      [param: In] set
      {
        this.PropertySet(nameof (CosignReasonName), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (CosignReasonName));
      }
    }

    public Info MeaningName
    {
      [param: In] set
      {
        this.PropertySet(nameof (MeaningName), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (MeaningName));
      }
    }

    public Info RoleName
    {
      [param: In] set
      {
        this.PropertySet(nameof (RoleName), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (RoleName));
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

    public Info Cosigner
    {
      [param: In] set
      {
        this.PropertySet(nameof (Cosigner), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Cosigner));
      }
    }
  }
}
