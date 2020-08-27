// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.AssignSingleCPContent
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
  public class AssignSingleCPContent : AssignChangePkgContent
  {
    [DataMember(EmitDefaultValue = false, Name = "AssignSingleCPContent_ServiceDetail")]
    protected AssignSingleCPContentDtl _ServiceDetail;

    public override bool Equals(object obj)
    {
      return obj is AssignSingleCPContent && object.Equals((object) this._ServiceDetail, (object) ((AssignSingleCPContent) obj)._ServiceDetail) && base.Equals(obj);
    }

    public AssignSingleCPContentDtl ServiceDetail
    {
      [param: In] set
      {
        this.PropertySet(nameof (ServiceDetail), (object) value);
      }
      get
      {
        return (AssignSingleCPContentDtl) this.PropertyGet(nameof (ServiceDetail));
      }
    }
  }
}
