// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.ReprintQualityObjectLabelService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class ReprintQualityObjectLabelService : ReprintLabelBase
  {
    public ReprintQualityObjectLabelService(UserProfile userProfile)
    {
      this.Initialize(typeof (IReprintQualityObjectLabelService), userProfile);
    }

    public ResultStatus CreateParametricData(
      ReprintQualityObjectLabel reprintQualityObjectLabel,
      ReprintQualityObjectLabel_Parameters parameters,
      ReprintQualityObjectLabel_Request request,
      out ReprintQualityObjectLabel_Result result)
    {
      result = (ReprintQualityObjectLabel_Result) null;
      this.OnBeforeCall(nameof (CreateParametricData), (DCObject) reprintQualityObjectLabel, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IReprintQualityObjectLabelService) this._Channel).CreateParametricData(this._UserProfile, reprintQualityObjectLabel, parameters, request, out result) : this.AddMethod((Method) new ReprintQualityObjectLabelMethod(reprintQualityObjectLabel, ReprintQualityObjectLabelMethods.CreateParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (CreateParametricData), res, (DCObject) reprintQualityObjectLabel, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus CreateParametricData()
    {
      return this.CreateParametricData((ReprintQualityObjectLabel) null, (ReprintQualityObjectLabel_Parameters) null, (ReprintQualityObjectLabel_Request) null, out ReprintQualityObjectLabel_Result _);
    }

    public ResultStatus CreateParametricData(
      ReprintQualityObjectLabel reprintQualityObjectLabel)
    {
      return this.CreateParametricData(reprintQualityObjectLabel, (ReprintQualityObjectLabel_Parameters) null, (ReprintQualityObjectLabel_Request) null, out ReprintQualityObjectLabel_Result _);
    }

    public ResultStatus CreateParametricData(
      ReprintQualityObjectLabel reprintQualityObjectLabel,
      ReprintQualityObjectLabel_Request request,
      out ReprintQualityObjectLabel_Result result)
    {
      return this.CreateParametricData(reprintQualityObjectLabel, (ReprintQualityObjectLabel_Parameters) null, request, out result);
    }

    public ResultStatus GetActions(
      ReprintQualityObjectLabel reprintQualityObjectLabel,
      ReprintQualityObjectLabel_Parameters parameters,
      ReprintQualityObjectLabel_Request request,
      out ReprintQualityObjectLabel_Result result)
    {
      result = (ReprintQualityObjectLabel_Result) null;
      this.OnBeforeCall(nameof (GetActions), (DCObject) reprintQualityObjectLabel, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IReprintQualityObjectLabelService) this._Channel).GetActions(this._UserProfile, reprintQualityObjectLabel, parameters, request, out result) : this.AddMethod((Method) new ReprintQualityObjectLabelMethod(reprintQualityObjectLabel, ReprintQualityObjectLabelMethods.GetActions, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetActions), res, (DCObject) reprintQualityObjectLabel, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetActions()
    {
      return this.GetActions((ReprintQualityObjectLabel) null, (ReprintQualityObjectLabel_Parameters) null, (ReprintQualityObjectLabel_Request) null, out ReprintQualityObjectLabel_Result _);
    }

    public ResultStatus GetActions(
      ReprintQualityObjectLabel reprintQualityObjectLabel)
    {
      return this.GetActions(reprintQualityObjectLabel, (ReprintQualityObjectLabel_Parameters) null, (ReprintQualityObjectLabel_Request) null, out ReprintQualityObjectLabel_Result _);
    }

    public ResultStatus GetActions(
      ReprintQualityObjectLabel reprintQualityObjectLabel,
      ReprintQualityObjectLabel_Request request,
      out ReprintQualityObjectLabel_Result result)
    {
      return this.GetActions(reprintQualityObjectLabel, (ReprintQualityObjectLabel_Parameters) null, request, out result);
    }

    public ResultStatus GetDataPoints(
      ReprintQualityObjectLabel reprintQualityObjectLabel,
      ReprintQualityObjectLabel_Parameters parameters,
      ReprintQualityObjectLabel_Request request,
      out ReprintQualityObjectLabel_Result result)
    {
      result = (ReprintQualityObjectLabel_Result) null;
      this.OnBeforeCall(nameof (GetDataPoints), (DCObject) reprintQualityObjectLabel, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IReprintQualityObjectLabelService) this._Channel).GetDataPoints(this._UserProfile, reprintQualityObjectLabel, parameters, request, out result) : this.AddMethod((Method) new ReprintQualityObjectLabelMethod(reprintQualityObjectLabel, ReprintQualityObjectLabelMethods.GetDataPoints, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetDataPoints), res, (DCObject) reprintQualityObjectLabel, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetDataPoints()
    {
      return this.GetDataPoints((ReprintQualityObjectLabel) null, (ReprintQualityObjectLabel_Parameters) null, (ReprintQualityObjectLabel_Request) null, out ReprintQualityObjectLabel_Result _);
    }

    public ResultStatus GetDataPoints(
      ReprintQualityObjectLabel reprintQualityObjectLabel)
    {
      return this.GetDataPoints(reprintQualityObjectLabel, (ReprintQualityObjectLabel_Parameters) null, (ReprintQualityObjectLabel_Request) null, out ReprintQualityObjectLabel_Result _);
    }

    public ResultStatus GetDataPoints(
      ReprintQualityObjectLabel reprintQualityObjectLabel,
      ReprintQualityObjectLabel_Request request,
      out ReprintQualityObjectLabel_Result result)
    {
      return this.GetDataPoints(reprintQualityObjectLabel, (ReprintQualityObjectLabel_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      ReprintQualityObjectLabel reprintQualityObjectLabel,
      ReprintQualityObjectLabel_Parameters parameters,
      ReprintQualityObjectLabel_Request request,
      out ReprintQualityObjectLabel_Result result)
    {
      result = (ReprintQualityObjectLabel_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) reprintQualityObjectLabel, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IReprintQualityObjectLabelService) this._Channel).GetWIPMsgs(this._UserProfile, reprintQualityObjectLabel, parameters, request, out result) : this.AddMethod((Method) new ReprintQualityObjectLabelMethod(reprintQualityObjectLabel, ReprintQualityObjectLabelMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) reprintQualityObjectLabel, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((ReprintQualityObjectLabel) null, (ReprintQualityObjectLabel_Parameters) null, (ReprintQualityObjectLabel_Request) null, out ReprintQualityObjectLabel_Result _);
    }

    public ResultStatus GetWIPMsgs(
      ReprintQualityObjectLabel reprintQualityObjectLabel)
    {
      return this.GetWIPMsgs(reprintQualityObjectLabel, (ReprintQualityObjectLabel_Parameters) null, (ReprintQualityObjectLabel_Request) null, out ReprintQualityObjectLabel_Result _);
    }

    public ResultStatus GetWIPMsgs(
      ReprintQualityObjectLabel reprintQualityObjectLabel,
      ReprintQualityObjectLabel_Request request,
      out ReprintQualityObjectLabel_Result result)
    {
      return this.GetWIPMsgs(reprintQualityObjectLabel, (ReprintQualityObjectLabel_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      ReprintQualityObjectLabel reprintQualityObjectLabel,
      ReprintQualityObjectLabel_Parameters parameters,
      ReprintQualityObjectLabel_Request request,
      out ReprintQualityObjectLabel_Result result)
    {
      result = (ReprintQualityObjectLabel_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) reprintQualityObjectLabel, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IReprintQualityObjectLabelService) this._Channel).Load(this._UserProfile, reprintQualityObjectLabel, parameters, request, out result) : this.AddMethod((Method) new ReprintQualityObjectLabelMethod(reprintQualityObjectLabel, ReprintQualityObjectLabelMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) reprintQualityObjectLabel, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((ReprintQualityObjectLabel) null, (ReprintQualityObjectLabel_Parameters) null, (ReprintQualityObjectLabel_Request) null, out ReprintQualityObjectLabel_Result _);
    }

    public ResultStatus Load(
      ReprintQualityObjectLabel reprintQualityObjectLabel)
    {
      return this.Load(reprintQualityObjectLabel, (ReprintQualityObjectLabel_Parameters) null, (ReprintQualityObjectLabel_Request) null, out ReprintQualityObjectLabel_Result _);
    }

    public ResultStatus Load(
      ReprintQualityObjectLabel reprintQualityObjectLabel,
      ReprintQualityObjectLabel_Request request,
      out ReprintQualityObjectLabel_Result result)
    {
      return this.Load(reprintQualityObjectLabel, (ReprintQualityObjectLabel_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      ReprintQualityObjectLabel reprintQualityObjectLabel,
      ReprintQualityObjectLabel_LoadESigDetails_Parameters parameters,
      ReprintQualityObjectLabel_Request request,
      out ReprintQualityObjectLabel_Result result)
    {
      result = (ReprintQualityObjectLabel_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) reprintQualityObjectLabel, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IReprintQualityObjectLabelService) this._Channel).LoadESigDetails(this._UserProfile, reprintQualityObjectLabel, parameters, request, out result) : this.AddMethod((Method) new ReprintQualityObjectLabelMethod(reprintQualityObjectLabel, ReprintQualityObjectLabelMethods.LoadESigDetails, (ReprintQualityObjectLabel_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) reprintQualityObjectLabel, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((ReprintQualityObjectLabel) null, (ReprintQualityObjectLabel_LoadESigDetails_Parameters) null, (ReprintQualityObjectLabel_Request) null, out ReprintQualityObjectLabel_Result _);
    }

    public ResultStatus LoadESigDetails(
      ReprintQualityObjectLabel reprintQualityObjectLabel)
    {
      return this.LoadESigDetails(reprintQualityObjectLabel, (ReprintQualityObjectLabel_LoadESigDetails_Parameters) null, (ReprintQualityObjectLabel_Request) null, out ReprintQualityObjectLabel_Result _);
    }

    public ResultStatus LoadESigDetails(
      ReprintQualityObjectLabel reprintQualityObjectLabel,
      ReprintQualityObjectLabel_Request request,
      out ReprintQualityObjectLabel_Result result)
    {
      return this.LoadESigDetails(reprintQualityObjectLabel, (ReprintQualityObjectLabel_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus ProcessComputation(
      ReprintQualityObjectLabel reprintQualityObjectLabel,
      ReprintQualityObjectLabel_Parameters parameters,
      ReprintQualityObjectLabel_Request request,
      out ReprintQualityObjectLabel_Result result)
    {
      result = (ReprintQualityObjectLabel_Result) null;
      this.OnBeforeCall(nameof (ProcessComputation), (DCObject) reprintQualityObjectLabel, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IReprintQualityObjectLabelService) this._Channel).ProcessComputation(this._UserProfile, reprintQualityObjectLabel, parameters, request, out result) : this.AddMethod((Method) new ReprintQualityObjectLabelMethod(reprintQualityObjectLabel, ReprintQualityObjectLabelMethods.ProcessComputation, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ProcessComputation), res, (DCObject) reprintQualityObjectLabel, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ProcessComputation()
    {
      return this.ProcessComputation((ReprintQualityObjectLabel) null, (ReprintQualityObjectLabel_Parameters) null, (ReprintQualityObjectLabel_Request) null, out ReprintQualityObjectLabel_Result _);
    }

    public ResultStatus ProcessComputation(
      ReprintQualityObjectLabel reprintQualityObjectLabel)
    {
      return this.ProcessComputation(reprintQualityObjectLabel, (ReprintQualityObjectLabel_Parameters) null, (ReprintQualityObjectLabel_Request) null, out ReprintQualityObjectLabel_Result _);
    }

    public ResultStatus ProcessComputation(
      ReprintQualityObjectLabel reprintQualityObjectLabel,
      ReprintQualityObjectLabel_Request request,
      out ReprintQualityObjectLabel_Result result)
    {
      return this.ProcessComputation(reprintQualityObjectLabel, (ReprintQualityObjectLabel_Parameters) null, request, out result);
    }

    public ResultStatus ResolveParametricData(
      ReprintQualityObjectLabel reprintQualityObjectLabel,
      ReprintQualityObjectLabel_Parameters parameters,
      ReprintQualityObjectLabel_Request request,
      out ReprintQualityObjectLabel_Result result)
    {
      result = (ReprintQualityObjectLabel_Result) null;
      this.OnBeforeCall(nameof (ResolveParametricData), (DCObject) reprintQualityObjectLabel, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IReprintQualityObjectLabelService) this._Channel).ResolveParametricData(this._UserProfile, reprintQualityObjectLabel, parameters, request, out result) : this.AddMethod((Method) new ReprintQualityObjectLabelMethod(reprintQualityObjectLabel, ReprintQualityObjectLabelMethods.ResolveParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ResolveParametricData), res, (DCObject) reprintQualityObjectLabel, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ResolveParametricData()
    {
      return this.ResolveParametricData((ReprintQualityObjectLabel) null, (ReprintQualityObjectLabel_Parameters) null, (ReprintQualityObjectLabel_Request) null, out ReprintQualityObjectLabel_Result _);
    }

    public ResultStatus ResolveParametricData(
      ReprintQualityObjectLabel reprintQualityObjectLabel)
    {
      return this.ResolveParametricData(reprintQualityObjectLabel, (ReprintQualityObjectLabel_Parameters) null, (ReprintQualityObjectLabel_Request) null, out ReprintQualityObjectLabel_Result _);
    }

    public ResultStatus ResolveParametricData(
      ReprintQualityObjectLabel reprintQualityObjectLabel,
      ReprintQualityObjectLabel_Request request,
      out ReprintQualityObjectLabel_Result result)
    {
      return this.ResolveParametricData(reprintQualityObjectLabel, (ReprintQualityObjectLabel_Parameters) null, request, out result);
    }

    protected override ResultStatus OnCreateParametricData(
      DCObject reprintQualityObjectLabel,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ReprintQualityObjectLabel_Result result1;
        ResultStatus parametricData = this.CreateParametricData((ReprintQualityObjectLabel) reprintQualityObjectLabel, (ReprintQualityObjectLabel_Parameters) parameters, (ReprintQualityObjectLabel_Request) request, out result1);
        result = (Result) result1;
        return parametricData;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetActions(
      DCObject reprintQualityObjectLabel,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ReprintQualityObjectLabel_Result result1;
        ResultStatus actions = this.GetActions((ReprintQualityObjectLabel) reprintQualityObjectLabel, (ReprintQualityObjectLabel_Parameters) parameters, (ReprintQualityObjectLabel_Request) request, out result1);
        result = (Result) result1;
        return actions;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetDataPoints(
      DCObject reprintQualityObjectLabel,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ReprintQualityObjectLabel_Result result1;
        ResultStatus dataPoints = this.GetDataPoints((ReprintQualityObjectLabel) reprintQualityObjectLabel, (ReprintQualityObjectLabel_Parameters) parameters, (ReprintQualityObjectLabel_Request) request, out result1);
        result = (Result) result1;
        return dataPoints;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject reprintQualityObjectLabel,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ReprintQualityObjectLabel_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((ReprintQualityObjectLabel) reprintQualityObjectLabel, (ReprintQualityObjectLabel_LoadESigDetails_Parameters) parameters, (ReprintQualityObjectLabel_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnProcessComputation(
      DCObject reprintQualityObjectLabel,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ReprintQualityObjectLabel_Result result1;
        ResultStatus resultStatus = this.ProcessComputation((ReprintQualityObjectLabel) reprintQualityObjectLabel, (ReprintQualityObjectLabel_Parameters) parameters, (ReprintQualityObjectLabel_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnResolveParametricData(
      DCObject reprintQualityObjectLabel,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ReprintQualityObjectLabel_Result result1;
        ResultStatus resultStatus = this.ResolveParametricData((ReprintQualityObjectLabel) reprintQualityObjectLabel, (ReprintQualityObjectLabel_Parameters) parameters, (ReprintQualityObjectLabel_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject reprintQualityObjectLabel,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ReprintQualityObjectLabel_Result result1;
        ResultStatus resultStatus = this.Load((ReprintQualityObjectLabel) reprintQualityObjectLabel, (ReprintQualityObjectLabel_Parameters) parameters, (ReprintQualityObjectLabel_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject reprintQualityObjectLabel,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ReprintQualityObjectLabel_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((ReprintQualityObjectLabel) reprintQualityObjectLabel, (ReprintQualityObjectLabel_Parameters) parameters, (ReprintQualityObjectLabel_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      ReprintQualityObjectLabel_Request request,
      out ReprintQualityObjectLabel_Result result)
    {
      result = (ReprintQualityObjectLabel_Result) null;
      try
      {
        ReprintQualityObjectLabelMethod[] methods = new ReprintQualityObjectLabelMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IReprintQualityObjectLabelService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        ReprintQualityObjectLabel_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((ReprintQualityObjectLabel_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      ReprintQualityObjectLabel cdo,
      ReprintQualityObjectLabel_Request request,
      out ReprintQualityObjectLabel_Result result)
    {
      result = (ReprintQualityObjectLabel_Result) null;
      try
      {
        return ((IReprintQualityObjectLabelService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        ReprintQualityObjectLabel_Result result1;
        ResultStatus environment = this.GetEnvironment((ReprintQualityObjectLabel) cdo, (ReprintQualityObjectLabel_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      ReprintQualityObjectLabel_Request request,
      out ReprintQualityObjectLabel_Result result)
    {
      return this.GetEnvironment((ReprintQualityObjectLabel) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      ReprintQualityObjectLabel cdo,
      ReprintQualityObjectLabel_Request request,
      out ReprintQualityObjectLabel_Result result)
    {
      result = (ReprintQualityObjectLabel_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IReprintQualityObjectLabelService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new ReprintQualityObjectLabelMethod(cdo, ReprintQualityObjectLabelMethods.ExecuteTransaction, (ReprintQualityObjectLabel_Parameters) null));
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
        ReprintQualityObjectLabel_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((ReprintQualityObjectLabel) cdo, (ReprintQualityObjectLabel_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(ReprintQualityObjectLabel cdo)
    {
      return this.ExecuteTransaction(cdo, (ReprintQualityObjectLabel_Request) null, out ReprintQualityObjectLabel_Result _);
    }

    public ResultStatus ExecuteTransaction(
      ReprintQualityObjectLabel_Request request,
      out ReprintQualityObjectLabel_Result result)
    {
      return this.ExecuteTransaction((ReprintQualityObjectLabel) null, request, out result);
    }

    public ResultStatus AddDataTransaction(ReprintQualityObjectLabel cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new ReprintQualityObjectLabelMethod(cdo, ReprintQualityObjectLabelMethods.AddDataTransaction, (ReprintQualityObjectLabel_Parameters) null));
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
        return this.AddDataTransaction((ReprintQualityObjectLabel) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
