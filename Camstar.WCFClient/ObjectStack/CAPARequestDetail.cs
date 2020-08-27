// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.CAPARequestDetail
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
  public class CAPARequestDetail : CAPADetail
  {
    [DataMember(EmitDefaultValue = false, Name = "CAPARequestDetail_ProposedResolution")]
    protected Primitive<string> _ProposedResolution;

    public override bool Equals(object obj)
    {
      return obj is CAPARequestDetail && object.Equals((object) this._ProposedResolution, (object) ((CAPARequestDetail) obj)._ProposedResolution) && base.Equals(obj);
    }

    public Primitive<string> ProposedResolution
    {
      [param: In] set
      {
        this.PropertySet(nameof (ProposedResolution), (object) value);
      }
      get
      {
        return (Primitive<string>) this.PropertyGet(nameof (ProposedResolution));
      }
    }
  }
}
