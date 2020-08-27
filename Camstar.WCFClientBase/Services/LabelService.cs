// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.LabelService
// Assembly: Camstar.WCFClientBase, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: E448AB03-ACEB-4B6E-82CB-FFB6A3DB1FB3
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClientBase.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class LabelService : WCFServiceBase
  {
    public LabelService(UserProfile userProfile)
    {
      this.Initialize(typeof (ILabelService), userProfile);
    }

    public ResultStatus GetLabels(LabelRequest request, out LabelResult result)
    {
      result = (LabelResult) null;
      try
      {
        return ((ILabelService) this._Channel).GetLabels(this._UserProfile, request, out result);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
