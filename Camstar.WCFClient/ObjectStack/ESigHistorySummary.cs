// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ESigHistorySummary
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
  public class ESigHistorySummary : ServiceHistorySummary
  {
    [DataMember(EmitDefaultValue = false, Name = "ESigHistorySummary_HistoryDetails")]
    protected ESigHistoryDetail[] _HistoryDetails;
    [DataMember(EmitDefaultValue = false, Name = "ESigHistorySummary_ExportImportKey")]
    protected new Primitive<string> _ExportImportKey;
    [DataMember(EmitDefaultValue = false, Name = "ESigHistorySummary_DisplayName")]
    protected new Primitive<string> _DisplayName;
    [DataMember(EmitDefaultValue = false, Name = "ESigHistorySummary_CosignerRole")]
    protected NamedObjectRef _CosignerRole;
    [DataMember(EmitDefaultValue = false, Name = "ESigHistorySummary_ESigReqDetail")]
    protected NamedSubentityRef _ESigReqDetail;
    [DataMember(EmitDefaultValue = false, Name = "ESigHistorySummary_VerificationMethod")]
    protected Enumeration<ESigVerificationMethodEnum, int> _VerificationMethod;
    [DataMember(EmitDefaultValue = false, Name = "ESigHistorySummary_Role")]
    protected NamedObjectRef _Role;
    [DataMember(EmitDefaultValue = false, Name = "ESigHistorySummary_Meaning")]
    protected NamedObjectRef _Meaning;
    [DataMember(EmitDefaultValue = false, Name = "ESigHistorySummary_HistoryId")]
    protected new BaseObjectRef _HistoryId;
    [DataMember(EmitDefaultValue = false, Name = "ESigHistorySummary_SignatureCount")]
    protected Primitive<int> _SignatureCount;

    public override bool Equals(object obj)
    {
      return obj is ESigHistorySummary && this.CompareArrays((Array) this._HistoryDetails, (Array) ((ESigHistorySummary) obj)._HistoryDetails) && (object.Equals((object) this._ExportImportKey, (object) ((ESigHistorySummary) obj)._ExportImportKey) && object.Equals((object) this._DisplayName, (object) ((ESigHistorySummary) obj)._DisplayName)) && (object.Equals((object) this._CosignerRole, (object) ((ESigHistorySummary) obj)._CosignerRole) && object.Equals((object) this._ESigReqDetail, (object) ((ESigHistorySummary) obj)._ESigReqDetail) && (object.Equals((object) this._VerificationMethod, (object) ((ESigHistorySummary) obj)._VerificationMethod) && object.Equals((object) this._Role, (object) ((ESigHistorySummary) obj)._Role))) && (object.Equals((object) this._Meaning, (object) ((ESigHistorySummary) obj)._Meaning) && object.Equals((object) this._HistoryId, (object) ((ESigHistorySummary) obj)._HistoryId) && object.Equals((object) this._SignatureCount, (object) ((ESigHistorySummary) obj)._SignatureCount)) && base.Equals(obj);
    }

    public ESigHistoryDetail[] HistoryDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (HistoryDetails), (object) value);
      }
      get
      {
        return (ESigHistoryDetail[]) this.PropertyGet(nameof (HistoryDetails));
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
  }
}
