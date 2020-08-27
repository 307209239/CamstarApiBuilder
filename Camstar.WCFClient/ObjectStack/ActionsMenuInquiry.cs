// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ActionsMenuInquiry
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
  public class ActionsMenuInquiry : Inquiry
  {
    [DataMember(EmitDefaultValue = false, Name = "ActionsMenuInquiry_ActionsMenuInquiryDetails")]
    protected Camstar.WCF.ObjectStack.ActionsMenuInquiryDetails[] _ActionsMenuInquiryDetails;
    [DataMember(EmitDefaultValue = false, Name = "ActionsMenuInquiry_SelectedObject")]
    protected BaseObjectRef _SelectedObject;

    public override bool Equals(object obj)
    {
      return obj is ActionsMenuInquiry && this.CompareArrays((Array) this._ActionsMenuInquiryDetails, (Array) ((ActionsMenuInquiry) obj)._ActionsMenuInquiryDetails) && object.Equals((object) this._SelectedObject, (object) ((ActionsMenuInquiry) obj)._SelectedObject) && base.Equals(obj);
    }

    public Camstar.WCF.ObjectStack.ActionsMenuInquiryDetails[] ActionsMenuInquiryDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (ActionsMenuInquiryDetails), (object) value);
      }
      get
      {
        return (Camstar.WCF.ObjectStack.ActionsMenuInquiryDetails[]) this.PropertyGet(nameof (ActionsMenuInquiryDetails));
      }
    }

    public BaseObjectRef SelectedObject
    {
      [param: In] set
      {
        this.PropertySet(nameof (SelectedObject), (object) value);
      }
      get
      {
        return (BaseObjectRef) this.PropertyGet(nameof (SelectedObject));
      }
    }
  }
}
