// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.WCFServiceEventArgs
// Assembly: Camstar.WCFClientBase, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: E448AB03-ACEB-4B6E-82CB-FFB6A3DB1FB3
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClientBase.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class WCFServiceEventArgs : EventArgs
  {
    private UserProfile mUserProfile;
    private string mCallName;
    private DCObject mCdo;
    private Parameters mParameters;
    private Request mRequest;
    private Result mResult;
    private ResultStatus mResultStatus;

    public UserProfile UserProfile
    {
      get
      {
        return this.mUserProfile;
      }
    }

    public string CallName
    {
      get
      {
        return this.mCallName;
      }
    }

    public DCObject Cdo
    {
      get
      {
        return this.mCdo;
      }
    }

    public Parameters Parameters
    {
      get
      {
        return this.mParameters;
      }
    }

    public Request Request
    {
      get
      {
        return this.mRequest;
      }
    }

    public Result Result
    {
      get
      {
        return this.mResult;
      }
    }

    public ResultStatus ResultStatus
    {
      get
      {
        return this.mResultStatus;
      }
    }

    public WCFServiceEventArgs()
    {
    }

    public WCFServiceEventArgs(
      UserProfile userProfile,
      string callName,
      DCObject cdo,
      Parameters parameters,
      Request request,
      Result result)
      : this(userProfile, callName, cdo, parameters, request, result, (ResultStatus) null)
    {
    }

    public WCFServiceEventArgs(
      UserProfile userProfile,
      string callName,
      DCObject cdo,
      Parameters parameters,
      Request request,
      Result result,
      ResultStatus resultStatus)
    {
      this.mUserProfile = userProfile;
      this.mCallName = callName;
      this.mCdo = cdo;
      this.mParameters = parameters;
      this.mRequest = request;
      this.mResult = result;
      this.mResultStatus = resultStatus;
    }
  }
}
