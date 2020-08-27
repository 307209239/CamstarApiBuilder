// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ActionsMenuInquiryDetails_Environment
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
  public class ActionsMenuInquiryDetails_Environment : ServiceData_Environment
  {
    [Metadata("Field Expression.", "", false, false, true, "String", 1052555, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ActionsMenuInquiryDetails_Environment_OptionalParameters")]
    protected Environment _OptionalParameters;
    [Metadata("Caption", "", false, false, true, "String", 1049386, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ActionsMenuInquiryDetails_Environment_Caption")]
    protected Environment _Caption;
    [DataMember(EmitDefaultValue = false, Name = "ActionsMenuInquiryDetails_Environment_Sequence")]
    [Metadata("Relative sequence number", "", false, false, true, "Integer", 1048917, false, false, false, null)]
    protected Environment _Sequence;
    [DataMember(EmitDefaultValue = false, Name = "ActionsMenuInquiryDetails_Environment_UIVirtualPage")]
    [Metadata("Virtual Page component for the UI Personalization Persistence Provider.", "UIVirtualPage", false, false, true, "NamedObjectRef", 1052556, false, false, false, null)]
    protected Environment _UIVirtualPage;

    public Environment OptionalParameters
    {
      [param: In] set
      {
        this.PropertySet(nameof (OptionalParameters), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (OptionalParameters));
      }
    }

    public Environment Caption
    {
      [param: In] set
      {
        this.PropertySet(nameof (Caption), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Caption));
      }
    }

    public Environment Sequence
    {
      [param: In] set
      {
        this.PropertySet(nameof (Sequence), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (Sequence));
      }
    }

    public Environment UIVirtualPage
    {
      [param: In] set
      {
        this.PropertySet(nameof (UIVirtualPage), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (UIVirtualPage));
      }
    }
  }
}
