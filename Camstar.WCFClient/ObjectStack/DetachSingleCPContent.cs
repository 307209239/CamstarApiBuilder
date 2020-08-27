// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.DetachSingleCPContent
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
  public class DetachSingleCPContent : AssignChangePkgContent
  {
    [DataMember(EmitDefaultValue = false, Name = "DetachSingleCPContent_ServiceDetail")]
    protected DetachSingleCPContentDtl _ServiceDetail;

    public override bool Equals(object obj)
    {
      return obj is DetachSingleCPContent && object.Equals((object) this._ServiceDetail, (object) ((DetachSingleCPContent) obj)._ServiceDetail) && base.Equals(obj);
    }

    public DetachSingleCPContentDtl ServiceDetail
    {
      [param: In] set
      {
        this.PropertySet(nameof (ServiceDetail), (object) value);
      }
      get
      {
        return (DetachSingleCPContentDtl) this.PropertyGet(nameof (ServiceDetail));
      }
    }
  }
}
