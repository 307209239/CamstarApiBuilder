// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.DirectAccessService
// Assembly: Camstar.WCFClientBase, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: E448AB03-ACEB-4B6E-82CB-FFB6A3DB1FB3
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClientBase.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class DirectAccessService : WCFServiceBase
  {
    public DirectAccessService()
    {
      this.Initialize(typeof (IDirectAccessService), (UserProfile) null);
    }

    public DirectAccessService(UserProfile userProfile)
    {
      this._UserProfile = userProfile;
      this.Initialize(typeof (IDirectAccessService), (UserProfile) null);
    }

    public ResultStatus Submit(string inputXml, out string outputXml)
    {
      outputXml = (string) null;
      try
      {
        return ((IDirectAccessService) this._Channel).Submit(this._UserProfile, inputXml, out outputXml);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
