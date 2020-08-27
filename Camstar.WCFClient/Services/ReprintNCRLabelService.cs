// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.ReprintNCRLabelService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class ReprintNCRLabelService : ReprintLabelBase
  {
    public ReprintNCRLabelService(UserProfile userProfile)
    {
      this.Initialize(typeof (IReprintNCRLabelService), userProfile);
    }

    public ResultStatus CreateParametricData(
      ReprintNCRLabel reprintNCRLabel,
      ReprintNCRLabel_Parameters parameters,
      ReprintNCRLabel_Request request,
      out ReprintNCRLabel_Result result)
    {
      result = (ReprintNCRLabel_Result) null;
      this.OnBeforeCall(nameof (CreateParametricData), (DCObject) reprintNCRLabel, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IReprintNCRLabelService) this._Channel).CreateParametricData(this._UserProfile, reprintNCRLabel, parameters, request, out result) : this.AddMethod((Method) new ReprintNCRLabelMethod(reprintNCRLabel, ReprintNCRLabelMethods.CreateParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (CreateParametricData), res, (DCObject) reprintNCRLabel, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus CreateParametricData()
    {
      return this.CreateParametricData((ReprintNCRLabel) null, (ReprintNCRLabel_Parameters) null, (ReprintNCRLabel_Request) null, out ReprintNCRLabel_Result _);
    }

    public ResultStatus CreateParametricData(ReprintNCRLabel reprintNCRLabel)
    {
      return this.CreateParametricData(reprintNCRLabel, (ReprintNCRLabel_Parameters) null, (ReprintNCRLabel_Request) null, out ReprintNCRLabel_Result _);
    }

    public ResultStatus CreateParametricData(
      ReprintNCRLabel reprintNCRLabel,
      ReprintNCRLabel_Request request,
      out ReprintNCRLabel_Result result)
    {
      return this.CreateParametricData(reprintNCRLabel, (ReprintNCRLabel_Parameters) null, request, out result);
    }

    public ResultStatus GetActions(
      ReprintNCRLabel reprintNCRLabel,
      ReprintNCRLabel_Parameters parameters,
      ReprintNCRLabel_Request request,
      out ReprintNCRLabel_Result result)
    {
      result = (ReprintNCRLabel_Result) null;
      this.OnBeforeCall(nameof (GetActions), (DCObject) reprintNCRLabel, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IReprintNCRLabelService) this._Channel).GetActions(this._UserProfile, reprintNCRLabel, parameters, request, out result) : this.AddMethod((Method) new ReprintNCRLabelMethod(reprintNCRLabel, ReprintNCRLabelMethods.GetActions, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetActions), res, (DCObject) reprintNCRLabel, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetActions()
    {
      return this.GetActions((ReprintNCRLabel) null, (ReprintNCRLabel_Parameters) null, (ReprintNCRLabel_Request) null, out ReprintNCRLabel_Result _);
    }

    public ResultStatus GetActions(ReprintNCRLabel reprintNCRLabel)
    {
      return this.GetActions(reprintNCRLabel, (ReprintNCRLabel_Parameters) null, (ReprintNCRLabel_Request) null, out ReprintNCRLabel_Result _);
    }

    public ResultStatus GetActions(
      ReprintNCRLabel reprintNCRLabel,
      ReprintNCRLabel_Request request,
      out ReprintNCRLabel_Result result)
    {
      return this.GetActions(reprintNCRLabel, (ReprintNCRLabel_Parameters) null, request, out result);
    }

    public ResultStatus GetDataPoints(
      ReprintNCRLabel reprintNCRLabel,
      ReprintNCRLabel_Parameters parameters,
      ReprintNCRLabel_Request request,
      out ReprintNCRLabel_Result result)
    {
      result = (ReprintNCRLabel_Result) null;
      this.OnBeforeCall(nameof (GetDataPoints), (DCObject) reprintNCRLabel, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IReprintNCRLabelService) this._Channel).GetDataPoints(this._UserProfile, reprintNCRLabel, parameters, request, out result) : this.AddMethod((Method) new ReprintNCRLabelMethod(reprintNCRLabel, ReprintNCRLabelMethods.GetDataPoints, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetDataPoints), res, (DCObject) reprintNCRLabel, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetDataPoints()
    {
      return this.GetDataPoints((ReprintNCRLabel) null, (ReprintNCRLabel_Parameters) null, (ReprintNCRLabel_Request) null, out ReprintNCRLabel_Result _);
    }

    public ResultStatus GetDataPoints(ReprintNCRLabel reprintNCRLabel)
    {
      return this.GetDataPoints(reprintNCRLabel, (ReprintNCRLabel_Parameters) null, (ReprintNCRLabel_Request) null, out ReprintNCRLabel_Result _);
    }

    public ResultStatus GetDataPoints(
      ReprintNCRLabel reprintNCRLabel,
      ReprintNCRLabel_Request request,
      out ReprintNCRLabel_Result result)
    {
      return this.GetDataPoints(reprintNCRLabel, (ReprintNCRLabel_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      ReprintNCRLabel reprintNCRLabel,
      ReprintNCRLabel_Parameters parameters,
      ReprintNCRLabel_Request request,
      out ReprintNCRLabel_Result result)
    {
      result = (ReprintNCRLabel_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) reprintNCRLabel, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IReprintNCRLabelService) this._Channel).GetWIPMsgs(this._UserProfile, reprintNCRLabel, parameters, request, out result) : this.AddMethod((Method) new ReprintNCRLabelMethod(reprintNCRLabel, ReprintNCRLabelMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) reprintNCRLabel, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((ReprintNCRLabel) null, (ReprintNCRLabel_Parameters) null, (ReprintNCRLabel_Request) null, out ReprintNCRLabel_Result _);
    }

    public ResultStatus GetWIPMsgs(ReprintNCRLabel reprintNCRLabel)
    {
      return this.GetWIPMsgs(reprintNCRLabel, (ReprintNCRLabel_Parameters) null, (ReprintNCRLabel_Request) null, out ReprintNCRLabel_Result _);
    }

    public ResultStatus GetWIPMsgs(
      ReprintNCRLabel reprintNCRLabel,
      ReprintNCRLabel_Request request,
      out ReprintNCRLabel_Result result)
    {
      return this.GetWIPMsgs(reprintNCRLabel, (ReprintNCRLabel_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      ReprintNCRLabel reprintNCRLabel,
      ReprintNCRLabel_Parameters parameters,
      ReprintNCRLabel_Request request,
      out ReprintNCRLabel_Result result)
    {
      result = (ReprintNCRLabel_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) reprintNCRLabel, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IReprintNCRLabelService) this._Channel).Load(this._UserProfile, reprintNCRLabel, parameters, request, out result) : this.AddMethod((Method) new ReprintNCRLabelMethod(reprintNCRLabel, ReprintNCRLabelMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) reprintNCRLabel, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((ReprintNCRLabel) null, (ReprintNCRLabel_Parameters) null, (ReprintNCRLabel_Request) null, out ReprintNCRLabel_Result _);
    }

    public ResultStatus Load(ReprintNCRLabel reprintNCRLabel)
    {
      return this.Load(reprintNCRLabel, (ReprintNCRLabel_Parameters) null, (ReprintNCRLabel_Request) null, out ReprintNCRLabel_Result _);
    }

    public ResultStatus Load(
      ReprintNCRLabel reprintNCRLabel,
      ReprintNCRLabel_Request request,
      out ReprintNCRLabel_Result result)
    {
      return this.Load(reprintNCRLabel, (ReprintNCRLabel_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      ReprintNCRLabel reprintNCRLabel,
      ReprintNCRLabel_LoadESigDetails_Parameters parameters,
      ReprintNCRLabel_Request request,
      out ReprintNCRLabel_Result result)
    {
      result = (ReprintNCRLabel_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) reprintNCRLabel, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IReprintNCRLabelService) this._Channel).LoadESigDetails(this._UserProfile, reprintNCRLabel, parameters, request, out result) : this.AddMethod((Method) new ReprintNCRLabelMethod(reprintNCRLabel, ReprintNCRLabelMethods.LoadESigDetails, (ReprintNCRLabel_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) reprintNCRLabel, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((ReprintNCRLabel) null, (ReprintNCRLabel_LoadESigDetails_Parameters) null, (ReprintNCRLabel_Request) null, out ReprintNCRLabel_Result _);
    }

    public ResultStatus LoadESigDetails(ReprintNCRLabel reprintNCRLabel)
    {
      return this.LoadESigDetails(reprintNCRLabel, (ReprintNCRLabel_LoadESigDetails_Parameters) null, (ReprintNCRLabel_Request) null, out ReprintNCRLabel_Result _);
    }

    public ResultStatus LoadESigDetails(
      ReprintNCRLabel reprintNCRLabel,
      ReprintNCRLabel_Request request,
      out ReprintNCRLabel_Result result)
    {
      return this.LoadESigDetails(reprintNCRLabel, (ReprintNCRLabel_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus ProcessComputation(
      ReprintNCRLabel reprintNCRLabel,
      ReprintNCRLabel_Parameters parameters,
      ReprintNCRLabel_Request request,
      out ReprintNCRLabel_Result result)
    {
      result = (ReprintNCRLabel_Result) null;
      this.OnBeforeCall(nameof (ProcessComputation), (DCObject) reprintNCRLabel, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IReprintNCRLabelService) this._Channel).ProcessComputation(this._UserProfile, reprintNCRLabel, parameters, request, out result) : this.AddMethod((Method) new ReprintNCRLabelMethod(reprintNCRLabel, ReprintNCRLabelMethods.ProcessComputation, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ProcessComputation), res, (DCObject) reprintNCRLabel, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ProcessComputation()
    {
      return this.ProcessComputation((ReprintNCRLabel) null, (ReprintNCRLabel_Parameters) null, (ReprintNCRLabel_Request) null, out ReprintNCRLabel_Result _);
    }

    public ResultStatus ProcessComputation(ReprintNCRLabel reprintNCRLabel)
    {
      return this.ProcessComputation(reprintNCRLabel, (ReprintNCRLabel_Parameters) null, (ReprintNCRLabel_Request) null, out ReprintNCRLabel_Result _);
    }

    public ResultStatus ProcessComputation(
      ReprintNCRLabel reprintNCRLabel,
      ReprintNCRLabel_Request request,
      out ReprintNCRLabel_Result result)
    {
      return this.ProcessComputation(reprintNCRLabel, (ReprintNCRLabel_Parameters) null, request, out result);
    }

    public ResultStatus ResolveParametricData(
      ReprintNCRLabel reprintNCRLabel,
      ReprintNCRLabel_Parameters parameters,
      ReprintNCRLabel_Request request,
      out ReprintNCRLabel_Result result)
    {
      result = (ReprintNCRLabel_Result) null;
      this.OnBeforeCall(nameof (ResolveParametricData), (DCObject) reprintNCRLabel, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IReprintNCRLabelService) this._Channel).ResolveParametricData(this._UserProfile, reprintNCRLabel, parameters, request, out result) : this.AddMethod((Method) new ReprintNCRLabelMethod(reprintNCRLabel, ReprintNCRLabelMethods.ResolveParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ResolveParametricData), res, (DCObject) reprintNCRLabel, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ResolveParametricData()
    {
      return this.ResolveParametricData((ReprintNCRLabel) null, (ReprintNCRLabel_Parameters) null, (ReprintNCRLabel_Request) null, out ReprintNCRLabel_Result _);
    }

    public ResultStatus ResolveParametricData(ReprintNCRLabel reprintNCRLabel)
    {
      return this.ResolveParametricData(reprintNCRLabel, (ReprintNCRLabel_Parameters) null, (ReprintNCRLabel_Request) null, out ReprintNCRLabel_Result _);
    }

    public ResultStatus ResolveParametricData(
      ReprintNCRLabel reprintNCRLabel,
      ReprintNCRLabel_Request request,
      out ReprintNCRLabel_Result result)
    {
      return this.ResolveParametricData(reprintNCRLabel, (ReprintNCRLabel_Parameters) null, request, out result);
    }

    protected override ResultStatus OnCreateParametricData(
      DCObject reprintNCRLabel,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ReprintNCRLabel_Result result1;
        ResultStatus parametricData = this.CreateParametricData((ReprintNCRLabel) reprintNCRLabel, (ReprintNCRLabel_Parameters) parameters, (ReprintNCRLabel_Request) request, out result1);
        result = (Result) result1;
        return parametricData;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetActions(
      DCObject reprintNCRLabel,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ReprintNCRLabel_Result result1;
        ResultStatus actions = this.GetActions((ReprintNCRLabel) reprintNCRLabel, (ReprintNCRLabel_Parameters) parameters, (ReprintNCRLabel_Request) request, out result1);
        result = (Result) result1;
        return actions;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetDataPoints(
      DCObject reprintNCRLabel,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ReprintNCRLabel_Result result1;
        ResultStatus dataPoints = this.GetDataPoints((ReprintNCRLabel) reprintNCRLabel, (ReprintNCRLabel_Parameters) parameters, (ReprintNCRLabel_Request) request, out result1);
        result = (Result) result1;
        return dataPoints;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject reprintNCRLabel,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ReprintNCRLabel_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((ReprintNCRLabel) reprintNCRLabel, (ReprintNCRLabel_LoadESigDetails_Parameters) parameters, (ReprintNCRLabel_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnProcessComputation(
      DCObject reprintNCRLabel,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ReprintNCRLabel_Result result1;
        ResultStatus resultStatus = this.ProcessComputation((ReprintNCRLabel) reprintNCRLabel, (ReprintNCRLabel_Parameters) parameters, (ReprintNCRLabel_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnResolveParametricData(
      DCObject reprintNCRLabel,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ReprintNCRLabel_Result result1;
        ResultStatus resultStatus = this.ResolveParametricData((ReprintNCRLabel) reprintNCRLabel, (ReprintNCRLabel_Parameters) parameters, (ReprintNCRLabel_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject reprintNCRLabel,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ReprintNCRLabel_Result result1;
        ResultStatus resultStatus = this.Load((ReprintNCRLabel) reprintNCRLabel, (ReprintNCRLabel_Parameters) parameters, (ReprintNCRLabel_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject reprintNCRLabel,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ReprintNCRLabel_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((ReprintNCRLabel) reprintNCRLabel, (ReprintNCRLabel_Parameters) parameters, (ReprintNCRLabel_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      ReprintNCRLabel_Request request,
      out ReprintNCRLabel_Result result)
    {
      result = (ReprintNCRLabel_Result) null;
      try
      {
        ReprintNCRLabelMethod[] methods = new ReprintNCRLabelMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IReprintNCRLabelService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        ReprintNCRLabel_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((ReprintNCRLabel_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      ReprintNCRLabel cdo,
      ReprintNCRLabel_Request request,
      out ReprintNCRLabel_Result result)
    {
      result = (ReprintNCRLabel_Result) null;
      try
      {
        return ((IReprintNCRLabelService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        ReprintNCRLabel_Result result1;
        ResultStatus environment = this.GetEnvironment((ReprintNCRLabel) cdo, (ReprintNCRLabel_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      ReprintNCRLabel_Request request,
      out ReprintNCRLabel_Result result)
    {
      return this.GetEnvironment((ReprintNCRLabel) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      ReprintNCRLabel cdo,
      ReprintNCRLabel_Request request,
      out ReprintNCRLabel_Result result)
    {
      result = (ReprintNCRLabel_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IReprintNCRLabelService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new ReprintNCRLabelMethod(cdo, ReprintNCRLabelMethods.ExecuteTransaction, (ReprintNCRLabel_Parameters) null));
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
        ReprintNCRLabel_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((ReprintNCRLabel) cdo, (ReprintNCRLabel_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(ReprintNCRLabel cdo)
    {
      return this.ExecuteTransaction(cdo, (ReprintNCRLabel_Request) null, out ReprintNCRLabel_Result _);
    }

    public ResultStatus ExecuteTransaction(
      ReprintNCRLabel_Request request,
      out ReprintNCRLabel_Result result)
    {
      return this.ExecuteTransaction((ReprintNCRLabel) null, request, out result);
    }

    public ResultStatus AddDataTransaction(ReprintNCRLabel cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new ReprintNCRLabelMethod(cdo, ReprintNCRLabelMethods.AddDataTransaction, (ReprintNCRLabel_Parameters) null));
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
        return this.AddDataTransaction((ReprintNCRLabel) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
