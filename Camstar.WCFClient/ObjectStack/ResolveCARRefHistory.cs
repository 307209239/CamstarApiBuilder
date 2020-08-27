// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ResolveCARRefHistory
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
  public class ResolveCARRefHistory : QualityCrossRefHistory
  {
    [DataMember(EmitDefaultValue = false, Name = "ResolveCARRefHistory_CARResolutionAction")]
    protected Enumeration<CARResolutionActionEnum, int> _CARResolutionAction;

    public override bool Equals(object obj)
    {
      return obj is ResolveCARRefHistory && object.Equals((object) this._CARResolutionAction, (object) ((ResolveCARRefHistory) obj)._CARResolutionAction) && base.Equals(obj);
    }

    public Enumeration<CARResolutionActionEnum, int> CARResolutionAction
    {
      [param: In] set
      {
        this.PropertySet(nameof (CARResolutionAction), (object) value);
      }
      get
      {
        return (Enumeration<CARResolutionActionEnum, int>) this.PropertyGet(nameof (CARResolutionAction));
      }
    }
  }
}
