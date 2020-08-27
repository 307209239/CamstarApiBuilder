// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ActionsMenuInquiry_Environment
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
  public class ActionsMenuInquiry_Environment : Inquiry_Environment
  {
    [Metadata("The detail information for the ActionsMenuInquiry service.", "ActionsMenuInquiryDetails", false, false, true, "ActionsMenuInquiryDetails", 1052558, false, true, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ActionsMenuInquiry_Environment_ActionsMenuInquiryDetails")]
    protected ActionsMenuInquiryDetails_Environment _ActionsMenuInquiryDetails;
    [Metadata("BaseObject", "BaseObject", false, false, false, "BaseObjectRef", 1049474, false, false, false, null)]
    [DataMember(EmitDefaultValue = false, Name = "ActionsMenuInquiry_Environment_SelectedObject")]
    protected Environment _SelectedObject;

    public ActionsMenuInquiryDetails_Environment ActionsMenuInquiryDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (ActionsMenuInquiryDetails), (object) value);
      }
      get
      {
        return (ActionsMenuInquiryDetails_Environment) this.PropertyGet(nameof (ActionsMenuInquiryDetails));
      }
    }

    public Environment SelectedObject
    {
      [param: In] set
      {
        this.PropertySet(nameof (SelectedObject), (object) value);
      }
      get
      {
        return (Environment) this.PropertyGet(nameof (SelectedObject));
      }
    }
  }
}
