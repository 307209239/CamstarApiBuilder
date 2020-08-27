// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ContainerAttrMaint
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
  public class ContainerAttrMaint : ContainerTxn
  {
    [DataMember(EmitDefaultValue = false, Name = "ContainerAttrMaint_ServiceDetails")]
    protected ContainerAttrDetail[] _ServiceDetails;

    public override bool Equals(object obj)
    {
      return obj is ContainerAttrMaint && this.CompareArrays((Array) this._ServiceDetails, (Array) ((ContainerAttrMaint) obj)._ServiceDetails) && base.Equals(obj);
    }

    public ContainerAttrDetail[] ServiceDetails
    {
      [param: In] set
      {
        this.PropertySet(nameof (ServiceDetails), (object) value);
      }
      get
      {
        return (ContainerAttrDetail[]) this.PropertyGet(nameof (ServiceDetails));
      }
    }
  }
}
