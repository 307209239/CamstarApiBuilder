// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ESigReqDetailChanges
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
  public class ESigReqDetailChanges : NamedSubentityChanges
  {
    [DataMember(EmitDefaultValue = false, Name = "ESigReqDetailChanges_ObjectToChange")]
    protected NamedSubentityRef _ObjectToChange;
    [DataMember(EmitDefaultValue = false, Name = "ESigReqDetailChanges_VerificationMethod")]
    protected Enumeration<ESigVerificationMethodEnum, int> _VerificationMethod;
    [DataMember(EmitDefaultValue = false, Name = "ESigReqDetailChanges_Role")]
    protected NamedObjectRef _Role;
    [DataMember(EmitDefaultValue = false, Name = "ESigReqDetailChanges_CosignerRole")]
    protected NamedObjectRef _CosignerRole;
    [DataMember(EmitDefaultValue = false, Name = "ESigReqDetailChanges_Meaning")]
    protected NamedObjectRef _Meaning;
    [DataMember(EmitDefaultValue = false, Name = "ESigReqDetailChanges_SignatureCount")]
    protected Primitive<int> _SignatureCount;
    [DataMember(EmitDefaultValue = false, Name = "ESigReqDetailChanges_Name")]
    protected new Primitive<string> _Name;

    public override bool Equals(object obj)
    {
      return obj is ESigReqDetailChanges && object.Equals((object) this._ObjectToChange, (object) ((ESigReqDetailChanges) obj)._ObjectToChange) && (object.Equals((object) this._VerificationMethod, (object) ((ESigReqDetailChanges) obj)._VerificationMethod) && object.Equals((object) this._Role, (object) ((ESigReqDetailChanges) obj)._Role)) && (object.Equals((object) this._CosignerRole, (object) ((ESigReqDetailChanges) obj)._CosignerRole) && object.Equals((object) this._Meaning, (object) ((ESigReqDetailChanges) obj)._Meaning) && (object.Equals((object) this._SignatureCount, (object) ((ESigReqDetailChanges) obj)._SignatureCount) && object.Equals((object) this._Name, (object) ((ESigReqDetailChanges) obj)._Name))) && base.Equals(obj);
    }

    public NamedSubentityRef ObjectToChange
    {
      [param: In] set
      {
        this.PropertySet(nameof (ObjectToChange), (object) value);
      }
      get
      {
        return (NamedSubentityRef) this.PropertyGet(nameof (ObjectToChange));
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

    public new Primitive<string> Name
    {
      [param: In] set
      {
        this.PropertySet(nameof (Name), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (Name));
      }
    }
  }
}
