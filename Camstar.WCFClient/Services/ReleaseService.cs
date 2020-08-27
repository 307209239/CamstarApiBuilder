// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.ReleaseService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class ReleaseService : HoldStatusTxnBase
  {
    public ReleaseService(UserProfile userProfile)
    {
      this.Initialize(typeof (IReleaseService), userProfile);
    }

    public ResultStatus CreateParametricData(
      Release release,
      Release_Parameters parameters,
      Release_Request request,
      out Release_Result result)
    {
      result = (Release_Result) null;
      this.OnBeforeCall(nameof (CreateParametricData), (DCObject) release, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IReleaseService) this._Channel).CreateParametricData(this._UserProfile, release, parameters, request, out result) : this.AddMethod((Method) new ReleaseMethod(release, ReleaseMethods.CreateParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (CreateParametricData), res, (DCObject) release, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus CreateParametricData()
    {
      return this.CreateParametricData((Release) null, (Release_Parameters) null, (Release_Request) null, out Release_Result _);
    }

    public ResultStatus CreateParametricData(Release release)
    {
      return this.CreateParametricData(release, (Release_Parameters) null, (Release_Request) null, out Release_Result _);
    }

    public ResultStatus CreateParametricData(
      Release release,
      Release_Request request,
      out Release_Result result)
    {
      return this.CreateParametricData(release, (Release_Parameters) null, request, out result);
    }

    public ResultStatus GetActions(
      Release release,
      Release_Parameters parameters,
      Release_Request request,
      out Release_Result result)
    {
      result = (Release_Result) null;
      this.OnBeforeCall(nameof (GetActions), (DCObject) release, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IReleaseService) this._Channel).GetActions(this._UserProfile, release, parameters, request, out result) : this.AddMethod((Method) new ReleaseMethod(release, ReleaseMethods.GetActions, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetActions), res, (DCObject) release, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetActions()
    {
      return this.GetActions((Release) null, (Release_Parameters) null, (Release_Request) null, out Release_Result _);
    }

    public ResultStatus GetActions(Release release)
    {
      return this.GetActions(release, (Release_Parameters) null, (Release_Request) null, out Release_Result _);
    }

    public ResultStatus GetActions(
      Release release,
      Release_Request request,
      out Release_Result result)
    {
      return this.GetActions(release, (Release_Parameters) null, request, out result);
    }

    public ResultStatus GetDataPoints(
      Release release,
      Release_Parameters parameters,
      Release_Request request,
      out Release_Result result)
    {
      result = (Release_Result) null;
      this.OnBeforeCall(nameof (GetDataPoints), (DCObject) release, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IReleaseService) this._Channel).GetDataPoints(this._UserProfile, release, parameters, request, out result) : this.AddMethod((Method) new ReleaseMethod(release, ReleaseMethods.GetDataPoints, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetDataPoints), res, (DCObject) release, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetDataPoints()
    {
      return this.GetDataPoints((Release) null, (Release_Parameters) null, (Release_Request) null, out Release_Result _);
    }

    public ResultStatus GetDataPoints(Release release)
    {
      return this.GetDataPoints(release, (Release_Parameters) null, (Release_Request) null, out Release_Result _);
    }

    public ResultStatus GetDataPoints(
      Release release,
      Release_Request request,
      out Release_Result result)
    {
      return this.GetDataPoints(release, (Release_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      Release release,
      Release_Parameters parameters,
      Release_Request request,
      out Release_Result result)
    {
      result = (Release_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) release, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IReleaseService) this._Channel).GetWIPMsgs(this._UserProfile, release, parameters, request, out result) : this.AddMethod((Method) new ReleaseMethod(release, ReleaseMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) release, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((Release) null, (Release_Parameters) null, (Release_Request) null, out Release_Result _);
    }

    public ResultStatus GetWIPMsgs(Release release)
    {
      return this.GetWIPMsgs(release, (Release_Parameters) null, (Release_Request) null, out Release_Result _);
    }

    public ResultStatus GetWIPMsgs(
      Release release,
      Release_Request request,
      out Release_Result result)
    {
      return this.GetWIPMsgs(release, (Release_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      Release release,
      Release_Parameters parameters,
      Release_Request request,
      out Release_Result result)
    {
      result = (Release_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) release, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IReleaseService) this._Channel).Load(this._UserProfile, release, parameters, request, out result) : this.AddMethod((Method) new ReleaseMethod(release, ReleaseMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) release, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((Release) null, (Release_Parameters) null, (Release_Request) null, out Release_Result _);
    }

    public ResultStatus Load(Release release)
    {
      return this.Load(release, (Release_Parameters) null, (Release_Request) null, out Release_Result _);
    }

    public ResultStatus Load(
      Release release,
      Release_Request request,
      out Release_Result result)
    {
      return this.Load(release, (Release_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      Release release,
      Release_LoadESigDetails_Parameters parameters,
      Release_Request request,
      out Release_Result result)
    {
      result = (Release_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) release, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IReleaseService) this._Channel).LoadESigDetails(this._UserProfile, release, parameters, request, out result) : this.AddMethod((Method) new ReleaseMethod(release, ReleaseMethods.LoadESigDetails, (Release_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) release, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((Release) null, (Release_LoadESigDetails_Parameters) null, (Release_Request) null, out Release_Result _);
    }

    public ResultStatus LoadESigDetails(Release release)
    {
      return this.LoadESigDetails(release, (Release_LoadESigDetails_Parameters) null, (Release_Request) null, out Release_Result _);
    }

    public ResultStatus LoadESigDetails(
      Release release,
      Release_Request request,
      out Release_Result result)
    {
      return this.LoadESigDetails(release, (Release_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus ProcessComputation(
      Release release,
      Release_Parameters parameters,
      Release_Request request,
      out Release_Result result)
    {
      result = (Release_Result) null;
      this.OnBeforeCall(nameof (ProcessComputation), (DCObject) release, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IReleaseService) this._Channel).ProcessComputation(this._UserProfile, release, parameters, request, out result) : this.AddMethod((Method) new ReleaseMethod(release, ReleaseMethods.ProcessComputation, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ProcessComputation), res, (DCObject) release, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ProcessComputation()
    {
      return this.ProcessComputation((Release) null, (Release_Parameters) null, (Release_Request) null, out Release_Result _);
    }

    public ResultStatus ProcessComputation(Release release)
    {
      return this.ProcessComputation(release, (Release_Parameters) null, (Release_Request) null, out Release_Result _);
    }

    public ResultStatus ProcessComputation(
      Release release,
      Release_Request request,
      out Release_Result result)
    {
      return this.ProcessComputation(release, (Release_Parameters) null, request, out result);
    }

    public ResultStatus ResolveParametricData(
      Release release,
      Release_Parameters parameters,
      Release_Request request,
      out Release_Result result)
    {
      result = (Release_Result) null;
      this.OnBeforeCall(nameof (ResolveParametricData), (DCObject) release, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IReleaseService) this._Channel).ResolveParametricData(this._UserProfile, release, parameters, request, out result) : this.AddMethod((Method) new ReleaseMethod(release, ReleaseMethods.ResolveParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ResolveParametricData), res, (DCObject) release, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ResolveParametricData()
    {
      return this.ResolveParametricData((Release) null, (Release_Parameters) null, (Release_Request) null, out Release_Result _);
    }

    public ResultStatus ResolveParametricData(Release release)
    {
      return this.ResolveParametricData(release, (Release_Parameters) null, (Release_Request) null, out Release_Result _);
    }

    public ResultStatus ResolveParametricData(
      Release release,
      Release_Request request,
      out Release_Result result)
    {
      return this.ResolveParametricData(release, (Release_Parameters) null, request, out result);
    }

    protected override ResultStatus OnCreateParametricData(
      DCObject release,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        Release_Result result1;
        ResultStatus parametricData = this.CreateParametricData((Release) release, (Release_Parameters) parameters, (Release_Request) request, out result1);
        result = (Result) result1;
        return parametricData;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetActions(
      DCObject release,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        Release_Result result1;
        ResultStatus actions = this.GetActions((Release) release, (Release_Parameters) parameters, (Release_Request) request, out result1);
        result = (Result) result1;
        return actions;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetDataPoints(
      DCObject release,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        Release_Result result1;
        ResultStatus dataPoints = this.GetDataPoints((Release) release, (Release_Parameters) parameters, (Release_Request) request, out result1);
        result = (Result) result1;
        return dataPoints;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject release,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        Release_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((Release) release, (Release_LoadESigDetails_Parameters) parameters, (Release_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnProcessComputation(
      DCObject release,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        Release_Result result1;
        ResultStatus resultStatus = this.ProcessComputation((Release) release, (Release_Parameters) parameters, (Release_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnResolveParametricData(
      DCObject release,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        Release_Result result1;
        ResultStatus resultStatus = this.ResolveParametricData((Release) release, (Release_Parameters) parameters, (Release_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject release,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        Release_Result result1;
        ResultStatus resultStatus = this.Load((Release) release, (Release_Parameters) parameters, (Release_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject release,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        Release_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((Release) release, (Release_Parameters) parameters, (Release_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      Release_Request request,
      out Release_Result result)
    {
      result = (Release_Result) null;
      try
      {
        ReleaseMethod[] methods = new ReleaseMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IReleaseService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnCommitTransaction(
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        Release_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((Release_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      Release cdo,
      Release_Request request,
      out Release_Result result)
    {
      result = (Release_Result) null;
      try
      {
        return ((IReleaseService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetEnvironment(
      DCObject cdo,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        Release_Result result1;
        ResultStatus environment = this.GetEnvironment((Release) cdo, (Release_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      Release_Request request,
      out Release_Result result)
    {
      return this.GetEnvironment((Release) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      Release cdo,
      Release_Request request,
      out Release_Result result)
    {
      result = (Release_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IReleaseService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new ReleaseMethod(cdo, ReleaseMethods.ExecuteTransaction, (Release_Parameters) null));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ExecuteTransaction), res, (DCObject) cdo, (Parameters) null, (Request) request, (Result) result);
      return res;
    }

    protected override ResultStatus OnExecuteTransaction(
      DCObject cdo,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        Release_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((Release) cdo, (Release_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(Release cdo)
    {
      return this.ExecuteTransaction(cdo, (Release_Request) null, out Release_Result _);
    }

    public ResultStatus ExecuteTransaction(
      Release_Request request,
      out Release_Result result)
    {
      return this.ExecuteTransaction((Release) null, request, out result);
    }

    public ResultStatus AddDataTransaction(Release cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new ReleaseMethod(cdo, ReleaseMethods.AddDataTransaction, (Release_Parameters) null));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
      {
        Result result;
        this.OnAfterCall(nameof (AddDataTransaction), res, (DCObject) cdo, (Parameters) null, (Request) null, result);
      }
      return res;
    }

    protected override ResultStatus OnAddDataTransaction(DCObject cdo)
    {
      try
      {
        return this.AddDataTransaction((Release) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
