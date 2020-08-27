// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.DetachSingleCPContentService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class DetachSingleCPContentService : AssignChangePkgContentBase
  {
    public DetachSingleCPContentService(UserProfile userProfile)
    {
      this.Initialize(typeof (IDetachSingleCPContentService), userProfile);
    }

    public ResultStatus CreateParametricData(
      DetachSingleCPContent detachSingleCPContent,
      DetachSingleCPContent_Parameters parameters,
      DetachSingleCPContent_Request request,
      out DetachSingleCPContent_Result result)
    {
      result = (DetachSingleCPContent_Result) null;
      this.OnBeforeCall(nameof (CreateParametricData), (DCObject) detachSingleCPContent, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IDetachSingleCPContentService) this._Channel).CreateParametricData(this._UserProfile, detachSingleCPContent, parameters, request, out result) : this.AddMethod((Method) new DetachSingleCPContentMethod(detachSingleCPContent, DetachSingleCPContentMethods.CreateParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (CreateParametricData), res, (DCObject) detachSingleCPContent, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus CreateParametricData()
    {
      return this.CreateParametricData((DetachSingleCPContent) null, (DetachSingleCPContent_Parameters) null, (DetachSingleCPContent_Request) null, out DetachSingleCPContent_Result _);
    }

    public ResultStatus CreateParametricData(DetachSingleCPContent detachSingleCPContent)
    {
      return this.CreateParametricData(detachSingleCPContent, (DetachSingleCPContent_Parameters) null, (DetachSingleCPContent_Request) null, out DetachSingleCPContent_Result _);
    }

    public ResultStatus CreateParametricData(
      DetachSingleCPContent detachSingleCPContent,
      DetachSingleCPContent_Request request,
      out DetachSingleCPContent_Result result)
    {
      return this.CreateParametricData(detachSingleCPContent, (DetachSingleCPContent_Parameters) null, request, out result);
    }

    public ResultStatus GetActions(
      DetachSingleCPContent detachSingleCPContent,
      DetachSingleCPContent_Parameters parameters,
      DetachSingleCPContent_Request request,
      out DetachSingleCPContent_Result result)
    {
      result = (DetachSingleCPContent_Result) null;
      this.OnBeforeCall(nameof (GetActions), (DCObject) detachSingleCPContent, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IDetachSingleCPContentService) this._Channel).GetActions(this._UserProfile, detachSingleCPContent, parameters, request, out result) : this.AddMethod((Method) new DetachSingleCPContentMethod(detachSingleCPContent, DetachSingleCPContentMethods.GetActions, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetActions), res, (DCObject) detachSingleCPContent, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetActions()
    {
      return this.GetActions((DetachSingleCPContent) null, (DetachSingleCPContent_Parameters) null, (DetachSingleCPContent_Request) null, out DetachSingleCPContent_Result _);
    }

    public ResultStatus GetActions(DetachSingleCPContent detachSingleCPContent)
    {
      return this.GetActions(detachSingleCPContent, (DetachSingleCPContent_Parameters) null, (DetachSingleCPContent_Request) null, out DetachSingleCPContent_Result _);
    }

    public ResultStatus GetActions(
      DetachSingleCPContent detachSingleCPContent,
      DetachSingleCPContent_Request request,
      out DetachSingleCPContent_Result result)
    {
      return this.GetActions(detachSingleCPContent, (DetachSingleCPContent_Parameters) null, request, out result);
    }

    public ResultStatus GetDataPoints(
      DetachSingleCPContent detachSingleCPContent,
      DetachSingleCPContent_Parameters parameters,
      DetachSingleCPContent_Request request,
      out DetachSingleCPContent_Result result)
    {
      result = (DetachSingleCPContent_Result) null;
      this.OnBeforeCall(nameof (GetDataPoints), (DCObject) detachSingleCPContent, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IDetachSingleCPContentService) this._Channel).GetDataPoints(this._UserProfile, detachSingleCPContent, parameters, request, out result) : this.AddMethod((Method) new DetachSingleCPContentMethod(detachSingleCPContent, DetachSingleCPContentMethods.GetDataPoints, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetDataPoints), res, (DCObject) detachSingleCPContent, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetDataPoints()
    {
      return this.GetDataPoints((DetachSingleCPContent) null, (DetachSingleCPContent_Parameters) null, (DetachSingleCPContent_Request) null, out DetachSingleCPContent_Result _);
    }

    public ResultStatus GetDataPoints(DetachSingleCPContent detachSingleCPContent)
    {
      return this.GetDataPoints(detachSingleCPContent, (DetachSingleCPContent_Parameters) null, (DetachSingleCPContent_Request) null, out DetachSingleCPContent_Result _);
    }

    public ResultStatus GetDataPoints(
      DetachSingleCPContent detachSingleCPContent,
      DetachSingleCPContent_Request request,
      out DetachSingleCPContent_Result result)
    {
      return this.GetDataPoints(detachSingleCPContent, (DetachSingleCPContent_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      DetachSingleCPContent detachSingleCPContent,
      DetachSingleCPContent_Parameters parameters,
      DetachSingleCPContent_Request request,
      out DetachSingleCPContent_Result result)
    {
      result = (DetachSingleCPContent_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) detachSingleCPContent, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IDetachSingleCPContentService) this._Channel).GetWIPMsgs(this._UserProfile, detachSingleCPContent, parameters, request, out result) : this.AddMethod((Method) new DetachSingleCPContentMethod(detachSingleCPContent, DetachSingleCPContentMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) detachSingleCPContent, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((DetachSingleCPContent) null, (DetachSingleCPContent_Parameters) null, (DetachSingleCPContent_Request) null, out DetachSingleCPContent_Result _);
    }

    public ResultStatus GetWIPMsgs(DetachSingleCPContent detachSingleCPContent)
    {
      return this.GetWIPMsgs(detachSingleCPContent, (DetachSingleCPContent_Parameters) null, (DetachSingleCPContent_Request) null, out DetachSingleCPContent_Result _);
    }

    public ResultStatus GetWIPMsgs(
      DetachSingleCPContent detachSingleCPContent,
      DetachSingleCPContent_Request request,
      out DetachSingleCPContent_Result result)
    {
      return this.GetWIPMsgs(detachSingleCPContent, (DetachSingleCPContent_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      DetachSingleCPContent detachSingleCPContent,
      DetachSingleCPContent_Parameters parameters,
      DetachSingleCPContent_Request request,
      out DetachSingleCPContent_Result result)
    {
      result = (DetachSingleCPContent_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) detachSingleCPContent, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IDetachSingleCPContentService) this._Channel).Load(this._UserProfile, detachSingleCPContent, parameters, request, out result) : this.AddMethod((Method) new DetachSingleCPContentMethod(detachSingleCPContent, DetachSingleCPContentMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) detachSingleCPContent, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((DetachSingleCPContent) null, (DetachSingleCPContent_Parameters) null, (DetachSingleCPContent_Request) null, out DetachSingleCPContent_Result _);
    }

    public ResultStatus Load(DetachSingleCPContent detachSingleCPContent)
    {
      return this.Load(detachSingleCPContent, (DetachSingleCPContent_Parameters) null, (DetachSingleCPContent_Request) null, out DetachSingleCPContent_Result _);
    }

    public ResultStatus Load(
      DetachSingleCPContent detachSingleCPContent,
      DetachSingleCPContent_Request request,
      out DetachSingleCPContent_Result result)
    {
      return this.Load(detachSingleCPContent, (DetachSingleCPContent_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      DetachSingleCPContent detachSingleCPContent,
      DetachSingleCPContent_LoadESigDetails_Parameters parameters,
      DetachSingleCPContent_Request request,
      out DetachSingleCPContent_Result result)
    {
      result = (DetachSingleCPContent_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) detachSingleCPContent, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IDetachSingleCPContentService) this._Channel).LoadESigDetails(this._UserProfile, detachSingleCPContent, parameters, request, out result) : this.AddMethod((Method) new DetachSingleCPContentMethod(detachSingleCPContent, DetachSingleCPContentMethods.LoadESigDetails, (DetachSingleCPContent_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) detachSingleCPContent, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((DetachSingleCPContent) null, (DetachSingleCPContent_LoadESigDetails_Parameters) null, (DetachSingleCPContent_Request) null, out DetachSingleCPContent_Result _);
    }

    public ResultStatus LoadESigDetails(DetachSingleCPContent detachSingleCPContent)
    {
      return this.LoadESigDetails(detachSingleCPContent, (DetachSingleCPContent_LoadESigDetails_Parameters) null, (DetachSingleCPContent_Request) null, out DetachSingleCPContent_Result _);
    }

    public ResultStatus LoadESigDetails(
      DetachSingleCPContent detachSingleCPContent,
      DetachSingleCPContent_Request request,
      out DetachSingleCPContent_Result result)
    {
      return this.LoadESigDetails(detachSingleCPContent, (DetachSingleCPContent_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus ProcessComputation(
      DetachSingleCPContent detachSingleCPContent,
      DetachSingleCPContent_Parameters parameters,
      DetachSingleCPContent_Request request,
      out DetachSingleCPContent_Result result)
    {
      result = (DetachSingleCPContent_Result) null;
      this.OnBeforeCall(nameof (ProcessComputation), (DCObject) detachSingleCPContent, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IDetachSingleCPContentService) this._Channel).ProcessComputation(this._UserProfile, detachSingleCPContent, parameters, request, out result) : this.AddMethod((Method) new DetachSingleCPContentMethod(detachSingleCPContent, DetachSingleCPContentMethods.ProcessComputation, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ProcessComputation), res, (DCObject) detachSingleCPContent, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ProcessComputation()
    {
      return this.ProcessComputation((DetachSingleCPContent) null, (DetachSingleCPContent_Parameters) null, (DetachSingleCPContent_Request) null, out DetachSingleCPContent_Result _);
    }

    public ResultStatus ProcessComputation(DetachSingleCPContent detachSingleCPContent)
    {
      return this.ProcessComputation(detachSingleCPContent, (DetachSingleCPContent_Parameters) null, (DetachSingleCPContent_Request) null, out DetachSingleCPContent_Result _);
    }

    public ResultStatus ProcessComputation(
      DetachSingleCPContent detachSingleCPContent,
      DetachSingleCPContent_Request request,
      out DetachSingleCPContent_Result result)
    {
      return this.ProcessComputation(detachSingleCPContent, (DetachSingleCPContent_Parameters) null, request, out result);
    }

    public ResultStatus ResolveParametricData(
      DetachSingleCPContent detachSingleCPContent,
      DetachSingleCPContent_Parameters parameters,
      DetachSingleCPContent_Request request,
      out DetachSingleCPContent_Result result)
    {
      result = (DetachSingleCPContent_Result) null;
      this.OnBeforeCall(nameof (ResolveParametricData), (DCObject) detachSingleCPContent, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IDetachSingleCPContentService) this._Channel).ResolveParametricData(this._UserProfile, detachSingleCPContent, parameters, request, out result) : this.AddMethod((Method) new DetachSingleCPContentMethod(detachSingleCPContent, DetachSingleCPContentMethods.ResolveParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ResolveParametricData), res, (DCObject) detachSingleCPContent, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ResolveParametricData()
    {
      return this.ResolveParametricData((DetachSingleCPContent) null, (DetachSingleCPContent_Parameters) null, (DetachSingleCPContent_Request) null, out DetachSingleCPContent_Result _);
    }

    public ResultStatus ResolveParametricData(
      DetachSingleCPContent detachSingleCPContent)
    {
      return this.ResolveParametricData(detachSingleCPContent, (DetachSingleCPContent_Parameters) null, (DetachSingleCPContent_Request) null, out DetachSingleCPContent_Result _);
    }

    public ResultStatus ResolveParametricData(
      DetachSingleCPContent detachSingleCPContent,
      DetachSingleCPContent_Request request,
      out DetachSingleCPContent_Result result)
    {
      return this.ResolveParametricData(detachSingleCPContent, (DetachSingleCPContent_Parameters) null, request, out result);
    }

    protected override ResultStatus OnCreateParametricData(
      DCObject detachSingleCPContent,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        DetachSingleCPContent_Result result1;
        ResultStatus parametricData = this.CreateParametricData((DetachSingleCPContent) detachSingleCPContent, (DetachSingleCPContent_Parameters) parameters, (DetachSingleCPContent_Request) request, out result1);
        result = (Result) result1;
        return parametricData;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetActions(
      DCObject detachSingleCPContent,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        DetachSingleCPContent_Result result1;
        ResultStatus actions = this.GetActions((DetachSingleCPContent) detachSingleCPContent, (DetachSingleCPContent_Parameters) parameters, (DetachSingleCPContent_Request) request, out result1);
        result = (Result) result1;
        return actions;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetDataPoints(
      DCObject detachSingleCPContent,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        DetachSingleCPContent_Result result1;
        ResultStatus dataPoints = this.GetDataPoints((DetachSingleCPContent) detachSingleCPContent, (DetachSingleCPContent_Parameters) parameters, (DetachSingleCPContent_Request) request, out result1);
        result = (Result) result1;
        return dataPoints;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject detachSingleCPContent,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        DetachSingleCPContent_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((DetachSingleCPContent) detachSingleCPContent, (DetachSingleCPContent_LoadESigDetails_Parameters) parameters, (DetachSingleCPContent_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnProcessComputation(
      DCObject detachSingleCPContent,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        DetachSingleCPContent_Result result1;
        ResultStatus resultStatus = this.ProcessComputation((DetachSingleCPContent) detachSingleCPContent, (DetachSingleCPContent_Parameters) parameters, (DetachSingleCPContent_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnResolveParametricData(
      DCObject detachSingleCPContent,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        DetachSingleCPContent_Result result1;
        ResultStatus resultStatus = this.ResolveParametricData((DetachSingleCPContent) detachSingleCPContent, (DetachSingleCPContent_Parameters) parameters, (DetachSingleCPContent_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject detachSingleCPContent,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        DetachSingleCPContent_Result result1;
        ResultStatus resultStatus = this.Load((DetachSingleCPContent) detachSingleCPContent, (DetachSingleCPContent_Parameters) parameters, (DetachSingleCPContent_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject detachSingleCPContent,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        DetachSingleCPContent_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((DetachSingleCPContent) detachSingleCPContent, (DetachSingleCPContent_Parameters) parameters, (DetachSingleCPContent_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      DetachSingleCPContent_Request request,
      out DetachSingleCPContent_Result result)
    {
      result = (DetachSingleCPContent_Result) null;
      try
      {
        DetachSingleCPContentMethod[] methods = new DetachSingleCPContentMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IDetachSingleCPContentService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        DetachSingleCPContent_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((DetachSingleCPContent_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      DetachSingleCPContent cdo,
      DetachSingleCPContent_Request request,
      out DetachSingleCPContent_Result result)
    {
      result = (DetachSingleCPContent_Result) null;
      try
      {
        return ((IDetachSingleCPContentService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        DetachSingleCPContent_Result result1;
        ResultStatus environment = this.GetEnvironment((DetachSingleCPContent) cdo, (DetachSingleCPContent_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      DetachSingleCPContent_Request request,
      out DetachSingleCPContent_Result result)
    {
      return this.GetEnvironment((DetachSingleCPContent) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      DetachSingleCPContent cdo,
      DetachSingleCPContent_Request request,
      out DetachSingleCPContent_Result result)
    {
      result = (DetachSingleCPContent_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IDetachSingleCPContentService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new DetachSingleCPContentMethod(cdo, DetachSingleCPContentMethods.ExecuteTransaction, (DetachSingleCPContent_Parameters) null));
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
        DetachSingleCPContent_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((DetachSingleCPContent) cdo, (DetachSingleCPContent_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(DetachSingleCPContent cdo)
    {
      return this.ExecuteTransaction(cdo, (DetachSingleCPContent_Request) null, out DetachSingleCPContent_Result _);
    }

    public ResultStatus ExecuteTransaction(
      DetachSingleCPContent_Request request,
      out DetachSingleCPContent_Result result)
    {
      return this.ExecuteTransaction((DetachSingleCPContent) null, request, out result);
    }

    public ResultStatus AddDataTransaction(DetachSingleCPContent cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new DetachSingleCPContentMethod(cdo, DetachSingleCPContentMethods.AddDataTransaction, (DetachSingleCPContent_Parameters) null));
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
        return this.AddDataTransaction((DetachSingleCPContent) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
