// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.NCRCloseQualityService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class NCRCloseQualityService : NCRCloseBase
  {
    public NCRCloseQualityService(UserProfile userProfile)
    {
      this.Initialize(typeof (INCRCloseQualityService), userProfile);
    }

    public ResultStatus CreateParametricData(
      NCRCloseQuality nCRCloseQuality,
      NCRCloseQuality_Parameters parameters,
      NCRCloseQuality_Request request,
      out NCRCloseQuality_Result result)
    {
      result = (NCRCloseQuality_Result) null;
      this.OnBeforeCall(nameof (CreateParametricData), (DCObject) nCRCloseQuality, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((INCRCloseQualityService) this._Channel).CreateParametricData(this._UserProfile, nCRCloseQuality, parameters, request, out result) : this.AddMethod((Method) new NCRCloseQualityMethod(nCRCloseQuality, NCRCloseQualityMethods.CreateParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (CreateParametricData), res, (DCObject) nCRCloseQuality, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus CreateParametricData()
    {
      return this.CreateParametricData((NCRCloseQuality) null, (NCRCloseQuality_Parameters) null, (NCRCloseQuality_Request) null, out NCRCloseQuality_Result _);
    }

    public ResultStatus CreateParametricData(NCRCloseQuality nCRCloseQuality)
    {
      return this.CreateParametricData(nCRCloseQuality, (NCRCloseQuality_Parameters) null, (NCRCloseQuality_Request) null, out NCRCloseQuality_Result _);
    }

    public ResultStatus CreateParametricData(
      NCRCloseQuality nCRCloseQuality,
      NCRCloseQuality_Request request,
      out NCRCloseQuality_Result result)
    {
      return this.CreateParametricData(nCRCloseQuality, (NCRCloseQuality_Parameters) null, request, out result);
    }

    public ResultStatus GetActions(
      NCRCloseQuality nCRCloseQuality,
      NCRCloseQuality_Parameters parameters,
      NCRCloseQuality_Request request,
      out NCRCloseQuality_Result result)
    {
      result = (NCRCloseQuality_Result) null;
      this.OnBeforeCall(nameof (GetActions), (DCObject) nCRCloseQuality, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((INCRCloseQualityService) this._Channel).GetActions(this._UserProfile, nCRCloseQuality, parameters, request, out result) : this.AddMethod((Method) new NCRCloseQualityMethod(nCRCloseQuality, NCRCloseQualityMethods.GetActions, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetActions), res, (DCObject) nCRCloseQuality, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetActions()
    {
      return this.GetActions((NCRCloseQuality) null, (NCRCloseQuality_Parameters) null, (NCRCloseQuality_Request) null, out NCRCloseQuality_Result _);
    }

    public ResultStatus GetActions(NCRCloseQuality nCRCloseQuality)
    {
      return this.GetActions(nCRCloseQuality, (NCRCloseQuality_Parameters) null, (NCRCloseQuality_Request) null, out NCRCloseQuality_Result _);
    }

    public ResultStatus GetActions(
      NCRCloseQuality nCRCloseQuality,
      NCRCloseQuality_Request request,
      out NCRCloseQuality_Result result)
    {
      return this.GetActions(nCRCloseQuality, (NCRCloseQuality_Parameters) null, request, out result);
    }

    public ResultStatus GetAttributes(
      NCRCloseQuality nCRCloseQuality,
      NCRCloseQuality_Parameters parameters,
      NCRCloseQuality_Request request,
      out NCRCloseQuality_Result result)
    {
      result = (NCRCloseQuality_Result) null;
      this.OnBeforeCall(nameof (GetAttributes), (DCObject) nCRCloseQuality, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((INCRCloseQualityService) this._Channel).GetAttributes(this._UserProfile, nCRCloseQuality, parameters, request, out result) : this.AddMethod((Method) new NCRCloseQualityMethod(nCRCloseQuality, NCRCloseQualityMethods.GetAttributes, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetAttributes), res, (DCObject) nCRCloseQuality, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetAttributes()
    {
      return this.GetAttributes((NCRCloseQuality) null, (NCRCloseQuality_Parameters) null, (NCRCloseQuality_Request) null, out NCRCloseQuality_Result _);
    }

    public ResultStatus GetAttributes(NCRCloseQuality nCRCloseQuality)
    {
      return this.GetAttributes(nCRCloseQuality, (NCRCloseQuality_Parameters) null, (NCRCloseQuality_Request) null, out NCRCloseQuality_Result _);
    }

    public ResultStatus GetAttributes(
      NCRCloseQuality nCRCloseQuality,
      NCRCloseQuality_Request request,
      out NCRCloseQuality_Result result)
    {
      return this.GetAttributes(nCRCloseQuality, (NCRCloseQuality_Parameters) null, request, out result);
    }

    public ResultStatus GetDataPoints(
      NCRCloseQuality nCRCloseQuality,
      NCRCloseQuality_Parameters parameters,
      NCRCloseQuality_Request request,
      out NCRCloseQuality_Result result)
    {
      result = (NCRCloseQuality_Result) null;
      this.OnBeforeCall(nameof (GetDataPoints), (DCObject) nCRCloseQuality, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((INCRCloseQualityService) this._Channel).GetDataPoints(this._UserProfile, nCRCloseQuality, parameters, request, out result) : this.AddMethod((Method) new NCRCloseQualityMethod(nCRCloseQuality, NCRCloseQualityMethods.GetDataPoints, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetDataPoints), res, (DCObject) nCRCloseQuality, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetDataPoints()
    {
      return this.GetDataPoints((NCRCloseQuality) null, (NCRCloseQuality_Parameters) null, (NCRCloseQuality_Request) null, out NCRCloseQuality_Result _);
    }

    public ResultStatus GetDataPoints(NCRCloseQuality nCRCloseQuality)
    {
      return this.GetDataPoints(nCRCloseQuality, (NCRCloseQuality_Parameters) null, (NCRCloseQuality_Request) null, out NCRCloseQuality_Result _);
    }

    public ResultStatus GetDataPoints(
      NCRCloseQuality nCRCloseQuality,
      NCRCloseQuality_Request request,
      out NCRCloseQuality_Result result)
    {
      return this.GetDataPoints(nCRCloseQuality, (NCRCloseQuality_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      NCRCloseQuality nCRCloseQuality,
      NCRCloseQuality_Parameters parameters,
      NCRCloseQuality_Request request,
      out NCRCloseQuality_Result result)
    {
      result = (NCRCloseQuality_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) nCRCloseQuality, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((INCRCloseQualityService) this._Channel).GetWIPMsgs(this._UserProfile, nCRCloseQuality, parameters, request, out result) : this.AddMethod((Method) new NCRCloseQualityMethod(nCRCloseQuality, NCRCloseQualityMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) nCRCloseQuality, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((NCRCloseQuality) null, (NCRCloseQuality_Parameters) null, (NCRCloseQuality_Request) null, out NCRCloseQuality_Result _);
    }

    public ResultStatus GetWIPMsgs(NCRCloseQuality nCRCloseQuality)
    {
      return this.GetWIPMsgs(nCRCloseQuality, (NCRCloseQuality_Parameters) null, (NCRCloseQuality_Request) null, out NCRCloseQuality_Result _);
    }

    public ResultStatus GetWIPMsgs(
      NCRCloseQuality nCRCloseQuality,
      NCRCloseQuality_Request request,
      out NCRCloseQuality_Result result)
    {
      return this.GetWIPMsgs(nCRCloseQuality, (NCRCloseQuality_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      NCRCloseQuality nCRCloseQuality,
      NCRCloseQuality_Parameters parameters,
      NCRCloseQuality_Request request,
      out NCRCloseQuality_Result result)
    {
      result = (NCRCloseQuality_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) nCRCloseQuality, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((INCRCloseQualityService) this._Channel).Load(this._UserProfile, nCRCloseQuality, parameters, request, out result) : this.AddMethod((Method) new NCRCloseQualityMethod(nCRCloseQuality, NCRCloseQualityMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) nCRCloseQuality, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((NCRCloseQuality) null, (NCRCloseQuality_Parameters) null, (NCRCloseQuality_Request) null, out NCRCloseQuality_Result _);
    }

    public ResultStatus Load(NCRCloseQuality nCRCloseQuality)
    {
      return this.Load(nCRCloseQuality, (NCRCloseQuality_Parameters) null, (NCRCloseQuality_Request) null, out NCRCloseQuality_Result _);
    }

    public ResultStatus Load(
      NCRCloseQuality nCRCloseQuality,
      NCRCloseQuality_Request request,
      out NCRCloseQuality_Result result)
    {
      return this.Load(nCRCloseQuality, (NCRCloseQuality_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      NCRCloseQuality nCRCloseQuality,
      NCRCloseQuality_LoadESigDetails_Parameters parameters,
      NCRCloseQuality_Request request,
      out NCRCloseQuality_Result result)
    {
      result = (NCRCloseQuality_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) nCRCloseQuality, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((INCRCloseQualityService) this._Channel).LoadESigDetails(this._UserProfile, nCRCloseQuality, parameters, request, out result) : this.AddMethod((Method) new NCRCloseQualityMethod(nCRCloseQuality, NCRCloseQualityMethods.LoadESigDetails, (NCRCloseQuality_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) nCRCloseQuality, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((NCRCloseQuality) null, (NCRCloseQuality_LoadESigDetails_Parameters) null, (NCRCloseQuality_Request) null, out NCRCloseQuality_Result _);
    }

    public ResultStatus LoadESigDetails(NCRCloseQuality nCRCloseQuality)
    {
      return this.LoadESigDetails(nCRCloseQuality, (NCRCloseQuality_LoadESigDetails_Parameters) null, (NCRCloseQuality_Request) null, out NCRCloseQuality_Result _);
    }

    public ResultStatus LoadESigDetails(
      NCRCloseQuality nCRCloseQuality,
      NCRCloseQuality_Request request,
      out NCRCloseQuality_Result result)
    {
      return this.LoadESigDetails(nCRCloseQuality, (NCRCloseQuality_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus ProcessComputation(
      NCRCloseQuality nCRCloseQuality,
      NCRCloseQuality_Parameters parameters,
      NCRCloseQuality_Request request,
      out NCRCloseQuality_Result result)
    {
      result = (NCRCloseQuality_Result) null;
      this.OnBeforeCall(nameof (ProcessComputation), (DCObject) nCRCloseQuality, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((INCRCloseQualityService) this._Channel).ProcessComputation(this._UserProfile, nCRCloseQuality, parameters, request, out result) : this.AddMethod((Method) new NCRCloseQualityMethod(nCRCloseQuality, NCRCloseQualityMethods.ProcessComputation, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ProcessComputation), res, (DCObject) nCRCloseQuality, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ProcessComputation()
    {
      return this.ProcessComputation((NCRCloseQuality) null, (NCRCloseQuality_Parameters) null, (NCRCloseQuality_Request) null, out NCRCloseQuality_Result _);
    }

    public ResultStatus ProcessComputation(NCRCloseQuality nCRCloseQuality)
    {
      return this.ProcessComputation(nCRCloseQuality, (NCRCloseQuality_Parameters) null, (NCRCloseQuality_Request) null, out NCRCloseQuality_Result _);
    }

    public ResultStatus ProcessComputation(
      NCRCloseQuality nCRCloseQuality,
      NCRCloseQuality_Request request,
      out NCRCloseQuality_Result result)
    {
      return this.ProcessComputation(nCRCloseQuality, (NCRCloseQuality_Parameters) null, request, out result);
    }

    public ResultStatus ResolveParametricData(
      NCRCloseQuality nCRCloseQuality,
      NCRCloseQuality_Parameters parameters,
      NCRCloseQuality_Request request,
      out NCRCloseQuality_Result result)
    {
      result = (NCRCloseQuality_Result) null;
      this.OnBeforeCall(nameof (ResolveParametricData), (DCObject) nCRCloseQuality, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((INCRCloseQualityService) this._Channel).ResolveParametricData(this._UserProfile, nCRCloseQuality, parameters, request, out result) : this.AddMethod((Method) new NCRCloseQualityMethod(nCRCloseQuality, NCRCloseQualityMethods.ResolveParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ResolveParametricData), res, (DCObject) nCRCloseQuality, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ResolveParametricData()
    {
      return this.ResolveParametricData((NCRCloseQuality) null, (NCRCloseQuality_Parameters) null, (NCRCloseQuality_Request) null, out NCRCloseQuality_Result _);
    }

    public ResultStatus ResolveParametricData(NCRCloseQuality nCRCloseQuality)
    {
      return this.ResolveParametricData(nCRCloseQuality, (NCRCloseQuality_Parameters) null, (NCRCloseQuality_Request) null, out NCRCloseQuality_Result _);
    }

    public ResultStatus ResolveParametricData(
      NCRCloseQuality nCRCloseQuality,
      NCRCloseQuality_Request request,
      out NCRCloseQuality_Result result)
    {
      return this.ResolveParametricData(nCRCloseQuality, (NCRCloseQuality_Parameters) null, request, out result);
    }

    protected override ResultStatus OnGetAttributes(
      DCObject nCRCloseQuality,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        NCRCloseQuality_Result result1;
        ResultStatus attributes = this.GetAttributes((NCRCloseQuality) nCRCloseQuality, (NCRCloseQuality_Parameters) parameters, (NCRCloseQuality_Request) request, out result1);
        result = (Result) result1;
        return attributes;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnCreateParametricData(
      DCObject nCRCloseQuality,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        NCRCloseQuality_Result result1;
        ResultStatus parametricData = this.CreateParametricData((NCRCloseQuality) nCRCloseQuality, (NCRCloseQuality_Parameters) parameters, (NCRCloseQuality_Request) request, out result1);
        result = (Result) result1;
        return parametricData;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetActions(
      DCObject nCRCloseQuality,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        NCRCloseQuality_Result result1;
        ResultStatus actions = this.GetActions((NCRCloseQuality) nCRCloseQuality, (NCRCloseQuality_Parameters) parameters, (NCRCloseQuality_Request) request, out result1);
        result = (Result) result1;
        return actions;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetDataPoints(
      DCObject nCRCloseQuality,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        NCRCloseQuality_Result result1;
        ResultStatus dataPoints = this.GetDataPoints((NCRCloseQuality) nCRCloseQuality, (NCRCloseQuality_Parameters) parameters, (NCRCloseQuality_Request) request, out result1);
        result = (Result) result1;
        return dataPoints;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject nCRCloseQuality,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        NCRCloseQuality_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((NCRCloseQuality) nCRCloseQuality, (NCRCloseQuality_LoadESigDetails_Parameters) parameters, (NCRCloseQuality_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnProcessComputation(
      DCObject nCRCloseQuality,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        NCRCloseQuality_Result result1;
        ResultStatus resultStatus = this.ProcessComputation((NCRCloseQuality) nCRCloseQuality, (NCRCloseQuality_Parameters) parameters, (NCRCloseQuality_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnResolveParametricData(
      DCObject nCRCloseQuality,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        NCRCloseQuality_Result result1;
        ResultStatus resultStatus = this.ResolveParametricData((NCRCloseQuality) nCRCloseQuality, (NCRCloseQuality_Parameters) parameters, (NCRCloseQuality_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject nCRCloseQuality,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        NCRCloseQuality_Result result1;
        ResultStatus resultStatus = this.Load((NCRCloseQuality) nCRCloseQuality, (NCRCloseQuality_Parameters) parameters, (NCRCloseQuality_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject nCRCloseQuality,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        NCRCloseQuality_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((NCRCloseQuality) nCRCloseQuality, (NCRCloseQuality_Parameters) parameters, (NCRCloseQuality_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      NCRCloseQuality_Request request,
      out NCRCloseQuality_Result result)
    {
      result = (NCRCloseQuality_Result) null;
      try
      {
        NCRCloseQualityMethod[] methods = new NCRCloseQualityMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((INCRCloseQualityService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        NCRCloseQuality_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((NCRCloseQuality_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      NCRCloseQuality cdo,
      NCRCloseQuality_Request request,
      out NCRCloseQuality_Result result)
    {
      result = (NCRCloseQuality_Result) null;
      try
      {
        return ((INCRCloseQualityService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        NCRCloseQuality_Result result1;
        ResultStatus environment = this.GetEnvironment((NCRCloseQuality) cdo, (NCRCloseQuality_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      NCRCloseQuality_Request request,
      out NCRCloseQuality_Result result)
    {
      return this.GetEnvironment((NCRCloseQuality) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      NCRCloseQuality cdo,
      NCRCloseQuality_Request request,
      out NCRCloseQuality_Result result)
    {
      result = (NCRCloseQuality_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((INCRCloseQualityService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new NCRCloseQualityMethod(cdo, NCRCloseQualityMethods.ExecuteTransaction, (NCRCloseQuality_Parameters) null));
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
        NCRCloseQuality_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((NCRCloseQuality) cdo, (NCRCloseQuality_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(NCRCloseQuality cdo)
    {
      return this.ExecuteTransaction(cdo, (NCRCloseQuality_Request) null, out NCRCloseQuality_Result _);
    }

    public ResultStatus ExecuteTransaction(
      NCRCloseQuality_Request request,
      out NCRCloseQuality_Result result)
    {
      return this.ExecuteTransaction((NCRCloseQuality) null, request, out result);
    }

    public ResultStatus AddDataTransaction(NCRCloseQuality cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new NCRCloseQualityMethod(cdo, NCRCloseQualityMethods.AddDataTransaction, (NCRCloseQuality_Parameters) null));
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
        return this.AddDataTransaction((NCRCloseQuality) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
