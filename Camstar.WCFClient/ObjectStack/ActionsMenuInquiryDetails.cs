// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ActionsMenuInquiryDetails
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
  public class ActionsMenuInquiryDetails : ServiceData
  {
    [DataMember(EmitDefaultValue = false, Name = "ActionsMenuInquiryDetails_OptionalParameters")]
    protected Primitive<string> _OptionalParameters;
    [DataMember(EmitDefaultValue = false, Name = "ActionsMenuInquiryDetails_Caption")]
    protected Primitive<string> _Caption;
    [DataMember(EmitDefaultValue = false, Name = "ActionsMenuInquiryDetails_Sequence")]
    protected Primitive<int> _Sequence;
    [DataMember(EmitDefaultValue = false, Name = "ActionsMenuInquiryDetails_UIVirtualPage")]
    protected NamedObjectRef _UIVirtualPage;

    public override bool Equals(object obj)
    {
      return obj is ActionsMenuInquiryDetails && object.Equals((object) this._OptionalParameters, (object) ((ActionsMenuInquiryDetails) obj)._OptionalParameters) && (object.Equals((object) this._Caption, (object) ((ActionsMenuInquiryDetails) obj)._Caption) && object.Equals((object) this._Sequence, (object) ((ActionsMenuInquiryDetails) obj)._Sequence)) && object.Equals((object) this._UIVirtualPage, (object) ((ActionsMenuInquiryDetails) obj)._UIVirtualPage) && base.Equals(obj);
    }

    public Primitive<string> OptionalParameters
    {
      [param: In] set
      {
        this.PropertySet(nameof (OptionalParameters), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (OptionalParameters));
      }
    }

    public Primitive<string> Caption
    {
      [param: In] set
      {
        this.PropertySet(nameof (Caption), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (Caption));
      }
    }

    public Primitive<int> Sequence
    {
      [param: In] set
      {
        this.PropertySet(nameof (Sequence), (object) value);
      }
      get
      {
        return (Primitive<int>) this.PropertyGet(nameof (Sequence));
      }
    }

    public NamedObjectRef UIVirtualPage
    {
      [param: In] set
      {
        this.PropertySet(nameof (UIVirtualPage), (object) value);
      }
      get
      {
        return (NamedObjectRef) this.PropertyGet(nameof (UIVirtualPage));
      }
    }
  }
}
