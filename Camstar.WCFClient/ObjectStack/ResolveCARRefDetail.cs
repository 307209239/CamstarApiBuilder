// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.ObjectStack.ResolveCARRefDetail
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
  public class ResolveCARRefDetail : QualityCrossRefDetail
  {
    [DataMember(EmitDefaultValue = false, Name = "ResolveCARRefDetail_ResolutionAction")]
    protected new Enumeration<ResolutionActionEnum, int> _ResolutionAction;
    [DataMember(EmitDefaultValue = false, Name = "ResolveCARRefDetail_CloseReference")]
    protected new Primitive<bool> _CloseReference;

    public override bool Equals(object obj)
    {
      return obj is ResolveCARRefDetail && object.Equals((object) this._ResolutionAction, (object) ((ResolveCARRefDetail) obj)._ResolutionAction) && object.Equals((object) this._CloseReference, (object) ((ResolveCARRefDetail) obj)._CloseReference) && base.Equals(obj);
    }

    public new Enumeration<ResolutionActionEnum, int> ResolutionAction
    {
      [param: In] set
      {
        this.PropertySet(nameof (ResolutionAction), (object) value);
      }
      get
      {
        return (Enumeration<ResolutionActionEnum, int>) this.PropertyGet(nameof (ResolutionAction));
      }
    }

    public new Primitive<bool> CloseReference
    {
      [param: In] set
      {
        this.PropertySet(nameof (CloseReference), (object) value);
      }
      get
      {
        return (Primitive<bool>) this.PropertyGet(nameof (CloseReference));
      }
    }
  }
}
