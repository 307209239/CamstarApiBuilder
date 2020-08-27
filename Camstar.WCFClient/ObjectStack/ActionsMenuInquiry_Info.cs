// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ActionsMenuInquiry_Info
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
  public class ActionsMenuInquiry_Info : Inquiry_Info
  {
    [DataMember(EmitDefaultValue = false, Name = "ActionsMenuInquiry_Info_ActionsMenuInquiryDetails")]
    protected ActionsMenuInquiryDetails_Info _ActionsMenuInquiryDetails;
    [DataMember(EmitDefaultValue = false, Name = "ActionsMenuInquiry_Info_SelectedObject")]
    protected Info _SelectedObject;

    public ActionsMenuInquiryDetails_Info ActionsMenuInquiryDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (ActionsMenuInquiryDetails), (object) value);
      }
      get
      {
        return (ActionsMenuInquiryDetails_Info) this.PropertyGet(nameof (ActionsMenuInquiryDetails));
      }
    }

    public Info SelectedObject
    {
      [param: In] set
      {
        this.PropertySet(nameof (SelectedObject), (object) value);
      }
      get
      {
        return (Info) this.PropertyGet(nameof (SelectedObject));
      }
    }
  }
}
