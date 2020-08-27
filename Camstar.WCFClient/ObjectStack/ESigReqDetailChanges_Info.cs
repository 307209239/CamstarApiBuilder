// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ESigReqDetailChanges_Info
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
  public class ESigReqDetailChanges_Info : NamedSubentityChanges_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "ESigReqDetailChanges_Info_ObjectToChange")]
    protected new Info _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "ESigReqDetailChanges_Info_VerificationMethod")]
    protected Info _VerificationMethod;
    [DataMember(EmitDefaultValue = false, Name = "ESigReqDetailChanges_Info_Role")]
    protected Info _Role;
    [DataMember(EmitDefaultValue = false, Name = "ESigReqDetailChanges_Info_CosignerRole")]
    protected Info _CosignerRole;
    [DataMember(EmitDefaultValue = false, Name = "ESigReqDetailChanges_Info_Meaning")]
    protected Info _Meaning;
    [DataMember(EmitDefaultValue = false, Name = "ESigReqDetailChanges_Info_SignatureCount")]
    protected Info _SignatureCount;
    [DataMember(EmitDefaultValue = false, Name = "ESigReqDetailChanges_Info_Name")]
    protected new Info _Name;

    public new Info ObjectToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectToChange), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (ObjectToChange));
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

    public new Info Name
    {
      [param: In] set
      {
        this.PropertySet(nameof (Name), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Name));
      }
    }
  }
}
