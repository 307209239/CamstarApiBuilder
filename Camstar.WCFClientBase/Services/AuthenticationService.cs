// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.AuthenticationService
// Assembly: Camstar.WCFClientBase, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: E448AB03-ACEB-4B6E-82CB-FFB6A3DB1FB3
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClientBase.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class AuthenticationService : WCFServiceBase
  {
    public AuthenticationService(UserProfile userProfile)
    {
      this.Initialize(typeof (IAuthenticationService), userProfile);
    }

    public ResultStatus Login(out SessionData sessionData)
    {
      sessionData = (SessionData) null;
      try
      {
        return ((IAuthenticationService) this._Channel).Login(this._UserProfile, out sessionData);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
