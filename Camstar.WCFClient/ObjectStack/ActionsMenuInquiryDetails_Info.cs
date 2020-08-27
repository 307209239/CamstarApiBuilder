// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ActionsMenuInquiryDetails_Info
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
  public class ActionsMenuInquiryDetails_Info : ServiceData_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "ActionsMenuInquiryDetails_Info_OptionalParameters")]
    protected Info _OptionalParameters;
    [DataMember(EmitDefaultValue = false, Name = "ActionsMenuInquiryDetails_Info_Caption")]
    protected Info _Caption;
    [DataMember(EmitDefaultValue = false, Name = "ActionsMenuInquiryDetails_Info_Sequence")]
    protected Info _Sequence;
    [DataMember(EmitDefaultValue = false, Name = "ActionsMenuInquiryDetails_Info_UIVirtualPage")]
    protected Info _UIVirtualPage;

    public Info OptionalParameters
    {
      [param: In] set
      {
        this.PropertySet(nameof (OptionalParameters), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (OptionalParameters));
      }
    }

    public Info Caption
    {
      [param: In] set
      {
        this.PropertySet(nameof (Caption), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Caption));
      }
    }

    public Info Sequence
    {
      [param: In] set
      {
        this.PropertySet(nameof (Sequence), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (Sequence));
      }
    }

    public Info UIVirtualPage
    {
      [param: In] set
      {
        this.PropertySet(nameof (UIVirtualPage), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (UIVirtualPage));
      }
    }
  }
}
