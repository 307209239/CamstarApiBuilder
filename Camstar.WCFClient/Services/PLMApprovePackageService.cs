// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.PLMApprovePackageService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class PLMApprovePackageService : SignatureApprovalBase
  {
    public PLMApprovePackageService(UserProfile userProfile)
    {
      this.Initialize(typeof (IPLMApprovePackageService), userProfile);
    }

    public ResultStatus CreateParametricData(
      PLMApprovePackage pLMApprovePackage,
      PLMApprovePackage_Parameters parameters,
      PLMApprovePackage_Request request,
      out PLMApprovePackage_Result result)
    {
      result = (PLMApprovePackage_Result) null;
      this.OnBeforeCall(nameof (CreateParametricData), (DCObject) pLMApprovePackage, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IPLMApprovePackageService) this._Channel).CreateParametricData(this._UserProfile, pLMApprovePackage, parameters, request, out result) : this.AddMethod((Method) new PLMApprovePackageMethod(pLMApprovePackage, PLMApprovePackageMethods.CreateParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (CreateParametricData), res, (DCObject) pLMApprovePackage, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus CreateParametricData()
    {
      return this.CreateParametricData((PLMApprovePackage) null, (PLMApprovePackage_Parameters) null, (PLMApprovePackage_Request) null, out PLMApprovePackage_Result _);
    }

    public ResultStatus CreateParametricData(PLMApprovePackage pLMApprovePackage)
    {
      return this.CreateParametricData(pLMApprovePackage, (PLMApprovePackage_Parameters) null, (PLMApprovePackage_Request) null, out PLMApprovePackage_Result _);
    }

    public ResultStatus CreateParametricData(
      PLMApprovePackage pLMApprovePackage,
      PLMApprovePackage_Request request,
      out PLMApprovePackage_Result result)
    {
      return this.CreateParametricData(pLMApprovePackage, (PLMApprovePackage_Parameters) null, request, out result);
    }

    public ResultStatus GetActions(
      PLMApprovePackage pLMApprovePackage,
      PLMApprovePackage_Parameters parameters,
      PLMApprovePackage_Request request,
      out PLMApprovePackage_Result result)
    {
      result = (PLMApprovePackage_Result) null;
      this.OnBeforeCall(nameof (GetActions), (DCObject) pLMApprovePackage, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IPLMApprovePackageService) this._Channel).GetActions(this._UserProfile, pLMApprovePackage, parameters, request, out result) : this.AddMethod((Method) new PLMApprovePackageMethod(pLMApprovePackage, PLMApprovePackageMethods.GetActions, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetActions), res, (DCObject) pLMApprovePackage, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetActions()
    {
      return this.GetActions((PLMApprovePackage) null, (PLMApprovePackage_Parameters) null, (PLMApprovePackage_Request) null, out PLMApprovePackage_Result _);
    }

    public ResultStatus GetActions(PLMApprovePackage pLMApprovePackage)
    {
      return this.GetActions(pLMApprovePackage, (PLMApprovePackage_Parameters) null, (PLMApprovePackage_Request) null, out PLMApprovePackage_Result _);
    }

    public ResultStatus GetActions(
      PLMApprovePackage pLMApprovePackage,
      PLMApprovePackage_Request request,
      out PLMApprovePackage_Result result)
    {
      return this.GetActions(pLMApprovePackage, (PLMApprovePackage_Parameters) null, request, out result);
    }

    public ResultStatus GetDataPoints(
      PLMApprovePackage pLMApprovePackage,
      PLMApprovePackage_Parameters parameters,
      PLMApprovePackage_Request request,
      out PLMApprovePackage_Result result)
    {
      result = (PLMApprovePackage_Result) null;
      this.OnBeforeCall(nameof (GetDataPoints), (DCObject) pLMApprovePackage, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IPLMApprovePackageService) this._Channel).GetDataPoints(this._UserProfile, pLMApprovePackage, parameters, request, out result) : this.AddMethod((Method) new PLMApprovePackageMethod(pLMApprovePackage, PLMApprovePackageMethods.GetDataPoints, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetDataPoints), res, (DCObject) pLMApprovePackage, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetDataPoints()
    {
      return this.GetDataPoints((PLMApprovePackage) null, (PLMApprovePackage_Parameters) null, (PLMApprovePackage_Request) null, out PLMApprovePackage_Result _);
    }

    public ResultStatus GetDataPoints(PLMApprovePackage pLMApprovePackage)
    {
      return this.GetDataPoints(pLMApprovePackage, (PLMApprovePackage_Parameters) null, (PLMApprovePackage_Request) null, out PLMApprovePackage_Result _);
    }

    public ResultStatus GetDataPoints(
      PLMApprovePackage pLMApprovePackage,
      PLMApprovePackage_Request request,
      out PLMApprovePackage_Result result)
    {
      return this.GetDataPoints(pLMApprovePackage, (PLMApprovePackage_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      PLMApprovePackage pLMApprovePackage,
      PLMApprovePackage_Parameters parameters,
      PLMApprovePackage_Request request,
      out PLMApprovePackage_Result result)
    {
      result = (PLMApprovePackage_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) pLMApprovePackage, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IPLMApprovePackageService) this._Channel).GetWIPMsgs(this._UserProfile, pLMApprovePackage, parameters, request, out result) : this.AddMethod((Method) new PLMApprovePackageMethod(pLMApprovePackage, PLMApprovePackageMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) pLMApprovePackage, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((PLMApprovePackage) null, (PLMApprovePackage_Parameters) null, (PLMApprovePackage_Request) null, out PLMApprovePackage_Result _);
    }

    public ResultStatus GetWIPMsgs(PLMApprovePackage pLMApprovePackage)
    {
      return this.GetWIPMsgs(pLMApprovePackage, (PLMApprovePackage_Parameters) null, (PLMApprovePackage_Request) null, out PLMApprovePackage_Result _);
    }

    public ResultStatus GetWIPMsgs(
      PLMApprovePackage pLMApprovePackage,
      PLMApprovePackage_Request request,
      out PLMApprovePackage_Result result)
    {
      return this.GetWIPMsgs(pLMApprovePackage, (PLMApprovePackage_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      PLMApprovePackage pLMApprovePackage,
      PLMApprovePackage_Parameters parameters,
      PLMApprovePackage_Request request,
      out PLMApprovePackage_Result result)
    {
      result = (PLMApprovePackage_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) pLMApprovePackage, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IPLMApprovePackageService) this._Channel).Load(this._UserProfile, pLMApprovePackage, parameters, request, out result) : this.AddMethod((Method) new PLMApprovePackageMethod(pLMApprovePackage, PLMApprovePackageMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) pLMApprovePackage, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((PLMApprovePackage) null, (PLMApprovePackage_Parameters) null, (PLMApprovePackage_Request) null, out PLMApprovePackage_Result _);
    }

    public ResultStatus Load(PLMApprovePackage pLMApprovePackage)
    {
      return this.Load(pLMApprovePackage, (PLMApprovePackage_Parameters) null, (PLMApprovePackage_Request) null, out PLMApprovePackage_Result _);
    }

    public ResultStatus Load(
      PLMApprovePackage pLMApprovePackage,
      PLMApprovePackage_Request request,
      out PLMApprovePackage_Result result)
    {
      return this.Load(pLMApprovePackage, (PLMApprovePackage_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      PLMApprovePackage pLMApprovePackage,
      PLMApprovePackage_LoadESigDetails_Parameters parameters,
      PLMApprovePackage_Request request,
      out PLMApprovePackage_Result result)
    {
      result = (PLMApprovePackage_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) pLMApprovePackage, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IPLMApprovePackageService) this._Channel).LoadESigDetails(this._UserProfile, pLMApprovePackage, parameters, request, out result) : this.AddMethod((Method) new PLMApprovePackageMethod(pLMApprovePackage, PLMApprovePackageMethods.LoadESigDetails, (PLMApprovePackage_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) pLMApprovePackage, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((PLMApprovePackage) null, (PLMApprovePackage_LoadESigDetails_Parameters) null, (PLMApprovePackage_Request) null, out PLMApprovePackage_Result _);
    }

    public ResultStatus LoadESigDetails(PLMApprovePackage pLMApprovePackage)
    {
      return this.LoadESigDetails(pLMApprovePackage, (PLMApprovePackage_LoadESigDetails_Parameters) null, (PLMApprovePackage_Request) null, out PLMApprovePackage_Result _);
    }

    public ResultStatus LoadESigDetails(
      PLMApprovePackage pLMApprovePackage,
      PLMApprovePackage_Request request,
      out PLMApprovePackage_Result result)
    {
      return this.LoadESigDetails(pLMApprovePackage, (PLMApprovePackage_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus ProcessComputation(
      PLMApprovePackage pLMApprovePackage,
      PLMApprovePackage_Parameters parameters,
      PLMApprovePackage_Request request,
      out PLMApprovePackage_Result result)
    {
      result = (PLMApprovePackage_Result) null;
      this.OnBeforeCall(nameof (ProcessComputation), (DCObject) pLMApprovePackage, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IPLMApprovePackageService) this._Channel).ProcessComputation(this._UserProfile, pLMApprovePackage, parameters, request, out result) : this.AddMethod((Method) new PLMApprovePackageMethod(pLMApprovePackage, PLMApprovePackageMethods.ProcessComputation, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ProcessComputation), res, (DCObject) pLMApprovePackage, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ProcessComputation()
    {
      return this.ProcessComputation((PLMApprovePackage) null, (PLMApprovePackage_Parameters) null, (PLMApprovePackage_Request) null, out PLMApprovePackage_Result _);
    }

    public ResultStatus ProcessComputation(PLMApprovePackage pLMApprovePackage)
    {
      return this.ProcessComputation(pLMApprovePackage, (PLMApprovePackage_Parameters) null, (PLMApprovePackage_Request) null, out PLMApprovePackage_Result _);
    }

    public ResultStatus ProcessComputation(
      PLMApprovePackage pLMApprovePackage,
      PLMApprovePackage_Request request,
      out PLMApprovePackage_Result result)
    {
      return this.ProcessComputation(pLMApprovePackage, (PLMApprovePackage_Parameters) null, request, out result);
    }

    public ResultStatus ResolveParametricData(
      PLMApprovePackage pLMApprovePackage,
      PLMApprovePackage_Parameters parameters,
      PLMApprovePackage_Request request,
      out PLMApprovePackage_Result result)
    {
      result = (PLMApprovePackage_Result) null;
      this.OnBeforeCall(nameof (ResolveParametricData), (DCObject) pLMApprovePackage, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IPLMApprovePackageService) this._Channel).ResolveParametricData(this._UserProfile, pLMApprovePackage, parameters, request, out result) : this.AddMethod((Method) new PLMApprovePackageMethod(pLMApprovePackage, PLMApprovePackageMethods.ResolveParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ResolveParametricData), res, (DCObject) pLMApprovePackage, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ResolveParametricData()
    {
      return this.ResolveParametricData((PLMApprovePackage) null, (PLMApprovePackage_Parameters) null, (PLMApprovePackage_Request) null, out PLMApprovePackage_Result _);
    }

    public ResultStatus ResolveParametricData(PLMApprovePackage pLMApprovePackage)
    {
      return this.ResolveParametricData(pLMApprovePackage, (PLMApprovePackage_Parameters) null, (PLMApprovePackage_Request) null, out PLMApprovePackage_Result _);
    }

    public ResultStatus ResolveParametricData(
      PLMApprovePackage pLMApprovePackage,
      PLMApprovePackage_Request request,
      out PLMApprovePackage_Result result)
    {
      return this.ResolveParametricData(pLMApprovePackage, (PLMApprovePackage_Parameters) null, request, out result);
    }

    protected override ResultStatus OnCreateParametricData(
      DCObject pLMApprovePackage,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        PLMApprovePackage_Result result1;
        ResultStatus parametricData = this.CreateParametricData((PLMApprovePackage) pLMApprovePackage, (PLMApprovePackage_Parameters) parameters, (PLMApprovePackage_Request) request, out result1);
        result = (Result) result1;
        return parametricData;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetActions(
      DCObject pLMApprovePackage,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        PLMApprovePackage_Result result1;
        ResultStatus actions = this.GetActions((PLMApprovePackage) pLMApprovePackage, (PLMApprovePackage_Parameters) parameters, (PLMApprovePackage_Request) request, out result1);
        result = (Result) result1;
        return actions;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetDataPoints(
      DCObject pLMApprovePackage,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        PLMApprovePackage_Result result1;
        ResultStatus dataPoints = this.GetDataPoints((PLMApprovePackage) pLMApprovePackage, (PLMApprovePackage_Parameters) parameters, (PLMApprovePackage_Request) request, out result1);
        result = (Result) result1;
        return dataPoints;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject pLMApprovePackage,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        PLMApprovePackage_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((PLMApprovePackage) pLMApprovePackage, (PLMApprovePackage_LoadESigDetails_Parameters) parameters, (PLMApprovePackage_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnProcessComputation(
      DCObject pLMApprovePackage,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        PLMApprovePackage_Result result1;
        ResultStatus resultStatus = this.ProcessComputation((PLMApprovePackage) pLMApprovePackage, (PLMApprovePackage_Parameters) parameters, (PLMApprovePackage_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnResolveParametricData(
      DCObject pLMApprovePackage,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        PLMApprovePackage_Result result1;
        ResultStatus resultStatus = this.ResolveParametricData((PLMApprovePackage) pLMApprovePackage, (PLMApprovePackage_Parameters) parameters, (PLMApprovePackage_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject pLMApprovePackage,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        PLMApprovePackage_Result result1;
        ResultStatus resultStatus = this.Load((PLMApprovePackage) pLMApprovePackage, (PLMApprovePackage_Parameters) parameters, (PLMApprovePackage_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject pLMApprovePackage,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        PLMApprovePackage_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((PLMApprovePackage) pLMApprovePackage, (PLMApprovePackage_Parameters) parameters, (PLMApprovePackage_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      PLMApprovePackage_Request request,
      out PLMApprovePackage_Result result)
    {
      result = (PLMApprovePackage_Result) null;
      try
      {
        PLMApprovePackageMethod[] methods = new PLMApprovePackageMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IPLMApprovePackageService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        PLMApprovePackage_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((PLMApprovePackage_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      PLMApprovePackage cdo,
      PLMApprovePackage_Request request,
      out PLMApprovePackage_Result result)
    {
      result = (PLMApprovePackage_Result) null;
      try
      {
        return ((IPLMApprovePackageService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        PLMApprovePackage_Result result1;
        ResultStatus environment = this.GetEnvironment((PLMApprovePackage) cdo, (PLMApprovePackage_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      PLMApprovePackage_Request request,
      out PLMApprovePackage_Result result)
    {
      return this.GetEnvironment((PLMApprovePackage) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      PLMApprovePackage cdo,
      PLMApprovePackage_Request request,
      out PLMApprovePackage_Result result)
    {
      result = (PLMApprovePackage_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IPLMApprovePackageService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new PLMApprovePackageMethod(cdo, PLMApprovePackageMethods.ExecuteTransaction, (PLMApprovePackage_Parameters) null));
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
        PLMApprovePackage_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((PLMApprovePackage) cdo, (PLMApprovePackage_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(PLMApprovePackage cdo)
    {
      return this.ExecuteTransaction(cdo, (PLMApprovePackage_Request) null, out PLMApprovePackage_Result _);
    }

    public ResultStatus ExecuteTransaction(
      PLMApprovePackage_Request request,
      out PLMApprovePackage_Result result)
    {
      return this.ExecuteTransaction((PLMApprovePackage) null, request, out result);
    }

    public ResultStatus AddDataTransaction(PLMApprovePackage cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new PLMApprovePackageMethod(cdo, PLMApprovePackageMethods.AddDataTransaction, (PLMApprovePackage_Parameters) null));
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
        return this.AddDataTransaction((PLMApprovePackage) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
