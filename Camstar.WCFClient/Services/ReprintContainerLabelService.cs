// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.ReprintContainerLabelService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class ReprintContainerLabelService : ReprintLabelBase
  {
    public ReprintContainerLabelService(UserProfile userProfile)
    {
      this.Initialize(typeof (IReprintContainerLabelService), userProfile);
    }

    public ResultStatus CreateParametricData(
      ReprintContainerLabel reprintContainerLabel,
      ReprintContainerLabel_Parameters parameters,
      ReprintContainerLabel_Request request,
      out ReprintContainerLabel_Result result)
    {
      result = (ReprintContainerLabel_Result) null;
      this.OnBeforeCall(nameof (CreateParametricData), (DCObject) reprintContainerLabel, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IReprintContainerLabelService) this._Channel).CreateParametricData(this._UserProfile, reprintContainerLabel, parameters, request, out result) : this.AddMethod((Method) new ReprintContainerLabelMethod(reprintContainerLabel, ReprintContainerLabelMethods.CreateParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (CreateParametricData), res, (DCObject) reprintContainerLabel, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus CreateParametricData()
    {
      return this.CreateParametricData((ReprintContainerLabel) null, (ReprintContainerLabel_Parameters) null, (ReprintContainerLabel_Request) null, out ReprintContainerLabel_Result _);
    }

    public ResultStatus CreateParametricData(ReprintContainerLabel reprintContainerLabel)
    {
      return this.CreateParametricData(reprintContainerLabel, (ReprintContainerLabel_Parameters) null, (ReprintContainerLabel_Request) null, out ReprintContainerLabel_Result _);
    }

    public ResultStatus CreateParametricData(
      ReprintContainerLabel reprintContainerLabel,
      ReprintContainerLabel_Request request,
      out ReprintContainerLabel_Result result)
    {
      return this.CreateParametricData(reprintContainerLabel, (ReprintContainerLabel_Parameters) null, request, out result);
    }

    public ResultStatus GetActions(
      ReprintContainerLabel reprintContainerLabel,
      ReprintContainerLabel_Parameters parameters,
      ReprintContainerLabel_Request request,
      out ReprintContainerLabel_Result result)
    {
      result = (ReprintContainerLabel_Result) null;
      this.OnBeforeCall(nameof (GetActions), (DCObject) reprintContainerLabel, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IReprintContainerLabelService) this._Channel).GetActions(this._UserProfile, reprintContainerLabel, parameters, request, out result) : this.AddMethod((Method) new ReprintContainerLabelMethod(reprintContainerLabel, ReprintContainerLabelMethods.GetActions, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetActions), res, (DCObject) reprintContainerLabel, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetActions()
    {
      return this.GetActions((ReprintContainerLabel) null, (ReprintContainerLabel_Parameters) null, (ReprintContainerLabel_Request) null, out ReprintContainerLabel_Result _);
    }

    public ResultStatus GetActions(ReprintContainerLabel reprintContainerLabel)
    {
      return this.GetActions(reprintContainerLabel, (ReprintContainerLabel_Parameters) null, (ReprintContainerLabel_Request) null, out ReprintContainerLabel_Result _);
    }

    public ResultStatus GetActions(
      ReprintContainerLabel reprintContainerLabel,
      ReprintContainerLabel_Request request,
      out ReprintContainerLabel_Result result)
    {
      return this.GetActions(reprintContainerLabel, (ReprintContainerLabel_Parameters) null, request, out result);
    }

    public ResultStatus GetDataPoints(
      ReprintContainerLabel reprintContainerLabel,
      ReprintContainerLabel_Parameters parameters,
      ReprintContainerLabel_Request request,
      out ReprintContainerLabel_Result result)
    {
      result = (ReprintContainerLabel_Result) null;
      this.OnBeforeCall(nameof (GetDataPoints), (DCObject) reprintContainerLabel, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IReprintContainerLabelService) this._Channel).GetDataPoints(this._UserProfile, reprintContainerLabel, parameters, request, out result) : this.AddMethod((Method) new ReprintContainerLabelMethod(reprintContainerLabel, ReprintContainerLabelMethods.GetDataPoints, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetDataPoints), res, (DCObject) reprintContainerLabel, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetDataPoints()
    {
      return this.GetDataPoints((ReprintContainerLabel) null, (ReprintContainerLabel_Parameters) null, (ReprintContainerLabel_Request) null, out ReprintContainerLabel_Result _);
    }

    public ResultStatus GetDataPoints(ReprintContainerLabel reprintContainerLabel)
    {
      return this.GetDataPoints(reprintContainerLabel, (ReprintContainerLabel_Parameters) null, (ReprintContainerLabel_Request) null, out ReprintContainerLabel_Result _);
    }

    public ResultStatus GetDataPoints(
      ReprintContainerLabel reprintContainerLabel,
      ReprintContainerLabel_Request request,
      out ReprintContainerLabel_Result result)
    {
      return this.GetDataPoints(reprintContainerLabel, (ReprintContainerLabel_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      ReprintContainerLabel reprintContainerLabel,
      ReprintContainerLabel_Parameters parameters,
      ReprintContainerLabel_Request request,
      out ReprintContainerLabel_Result result)
    {
      result = (ReprintContainerLabel_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) reprintContainerLabel, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IReprintContainerLabelService) this._Channel).GetWIPMsgs(this._UserProfile, reprintContainerLabel, parameters, request, out result) : this.AddMethod((Method) new ReprintContainerLabelMethod(reprintContainerLabel, ReprintContainerLabelMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) reprintContainerLabel, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((ReprintContainerLabel) null, (ReprintContainerLabel_Parameters) null, (ReprintContainerLabel_Request) null, out ReprintContainerLabel_Result _);
    }

    public ResultStatus GetWIPMsgs(ReprintContainerLabel reprintContainerLabel)
    {
      return this.GetWIPMsgs(reprintContainerLabel, (ReprintContainerLabel_Parameters) null, (ReprintContainerLabel_Request) null, out ReprintContainerLabel_Result _);
    }

    public ResultStatus GetWIPMsgs(
      ReprintContainerLabel reprintContainerLabel,
      ReprintContainerLabel_Request request,
      out ReprintContainerLabel_Result result)
    {
      return this.GetWIPMsgs(reprintContainerLabel, (ReprintContainerLabel_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      ReprintContainerLabel reprintContainerLabel,
      ReprintContainerLabel_Parameters parameters,
      ReprintContainerLabel_Request request,
      out ReprintContainerLabel_Result result)
    {
      result = (ReprintContainerLabel_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) reprintContainerLabel, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IReprintContainerLabelService) this._Channel).Load(this._UserProfile, reprintContainerLabel, parameters, request, out result) : this.AddMethod((Method) new ReprintContainerLabelMethod(reprintContainerLabel, ReprintContainerLabelMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) reprintContainerLabel, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((ReprintContainerLabel) null, (ReprintContainerLabel_Parameters) null, (ReprintContainerLabel_Request) null, out ReprintContainerLabel_Result _);
    }

    public ResultStatus Load(ReprintContainerLabel reprintContainerLabel)
    {
      return this.Load(reprintContainerLabel, (ReprintContainerLabel_Parameters) null, (ReprintContainerLabel_Request) null, out ReprintContainerLabel_Result _);
    }

    public ResultStatus Load(
      ReprintContainerLabel reprintContainerLabel,
      ReprintContainerLabel_Request request,
      out ReprintContainerLabel_Result result)
    {
      return this.Load(reprintContainerLabel, (ReprintContainerLabel_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      ReprintContainerLabel reprintContainerLabel,
      ReprintContainerLabel_LoadESigDetails_Parameters parameters,
      ReprintContainerLabel_Request request,
      out ReprintContainerLabel_Result result)
    {
      result = (ReprintContainerLabel_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) reprintContainerLabel, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IReprintContainerLabelService) this._Channel).LoadESigDetails(this._UserProfile, reprintContainerLabel, parameters, request, out result) : this.AddMethod((Method) new ReprintContainerLabelMethod(reprintContainerLabel, ReprintContainerLabelMethods.LoadESigDetails, (ReprintContainerLabel_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) reprintContainerLabel, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((ReprintContainerLabel) null, (ReprintContainerLabel_LoadESigDetails_Parameters) null, (ReprintContainerLabel_Request) null, out ReprintContainerLabel_Result _);
    }

    public ResultStatus LoadESigDetails(ReprintContainerLabel reprintContainerLabel)
    {
      return this.LoadESigDetails(reprintContainerLabel, (ReprintContainerLabel_LoadESigDetails_Parameters) null, (ReprintContainerLabel_Request) null, out ReprintContainerLabel_Result _);
    }

    public ResultStatus LoadESigDetails(
      ReprintContainerLabel reprintContainerLabel,
      ReprintContainerLabel_Request request,
      out ReprintContainerLabel_Result result)
    {
      return this.LoadESigDetails(reprintContainerLabel, (ReprintContainerLabel_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus ProcessComputation(
      ReprintContainerLabel reprintContainerLabel,
      ReprintContainerLabel_Parameters parameters,
      ReprintContainerLabel_Request request,
      out ReprintContainerLabel_Result result)
    {
      result = (ReprintContainerLabel_Result) null;
      this.OnBeforeCall(nameof (ProcessComputation), (DCObject) reprintContainerLabel, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IReprintContainerLabelService) this._Channel).ProcessComputation(this._UserProfile, reprintContainerLabel, parameters, request, out result) : this.AddMethod((Method) new ReprintContainerLabelMethod(reprintContainerLabel, ReprintContainerLabelMethods.ProcessComputation, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ProcessComputation), res, (DCObject) reprintContainerLabel, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ProcessComputation()
    {
      return this.ProcessComputation((ReprintContainerLabel) null, (ReprintContainerLabel_Parameters) null, (ReprintContainerLabel_Request) null, out ReprintContainerLabel_Result _);
    }

    public ResultStatus ProcessComputation(ReprintContainerLabel reprintContainerLabel)
    {
      return this.ProcessComputation(reprintContainerLabel, (ReprintContainerLabel_Parameters) null, (ReprintContainerLabel_Request) null, out ReprintContainerLabel_Result _);
    }

    public ResultStatus ProcessComputation(
      ReprintContainerLabel reprintContainerLabel,
      ReprintContainerLabel_Request request,
      out ReprintContainerLabel_Result result)
    {
      return this.ProcessComputation(reprintContainerLabel, (ReprintContainerLabel_Parameters) null, request, out result);
    }

    public ResultStatus ResolveParametricData(
      ReprintContainerLabel reprintContainerLabel,
      ReprintContainerLabel_Parameters parameters,
      ReprintContainerLabel_Request request,
      out ReprintContainerLabel_Result result)
    {
      result = (ReprintContainerLabel_Result) null;
      this.OnBeforeCall(nameof (ResolveParametricData), (DCObject) reprintContainerLabel, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IReprintContainerLabelService) this._Channel).ResolveParametricData(this._UserProfile, reprintContainerLabel, parameters, request, out result) : this.AddMethod((Method) new ReprintContainerLabelMethod(reprintContainerLabel, ReprintContainerLabelMethods.ResolveParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ResolveParametricData), res, (DCObject) reprintContainerLabel, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ResolveParametricData()
    {
      return this.ResolveParametricData((ReprintContainerLabel) null, (ReprintContainerLabel_Parameters) null, (ReprintContainerLabel_Request) null, out ReprintContainerLabel_Result _);
    }

    public ResultStatus ResolveParametricData(
      ReprintContainerLabel reprintContainerLabel)
    {
      return this.ResolveParametricData(reprintContainerLabel, (ReprintContainerLabel_Parameters) null, (ReprintContainerLabel_Request) null, out ReprintContainerLabel_Result _);
    }

    public ResultStatus ResolveParametricData(
      ReprintContainerLabel reprintContainerLabel,
      ReprintContainerLabel_Request request,
      out ReprintContainerLabel_Result result)
    {
      return this.ResolveParametricData(reprintContainerLabel, (ReprintContainerLabel_Parameters) null, request, out result);
    }

    protected override ResultStatus OnCreateParametricData(
      DCObject reprintContainerLabel,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ReprintContainerLabel_Result result1;
        ResultStatus parametricData = this.CreateParametricData((ReprintContainerLabel) reprintContainerLabel, (ReprintContainerLabel_Parameters) parameters, (ReprintContainerLabel_Request) request, out result1);
        result = (Result) result1;
        return parametricData;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetActions(
      DCObject reprintContainerLabel,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ReprintContainerLabel_Result result1;
        ResultStatus actions = this.GetActions((ReprintContainerLabel) reprintContainerLabel, (ReprintContainerLabel_Parameters) parameters, (ReprintContainerLabel_Request) request, out result1);
        result = (Result) result1;
        return actions;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetDataPoints(
      DCObject reprintContainerLabel,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ReprintContainerLabel_Result result1;
        ResultStatus dataPoints = this.GetDataPoints((ReprintContainerLabel) reprintContainerLabel, (ReprintContainerLabel_Parameters) parameters, (ReprintContainerLabel_Request) request, out result1);
        result = (Result) result1;
        return dataPoints;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject reprintContainerLabel,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ReprintContainerLabel_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((ReprintContainerLabel) reprintContainerLabel, (ReprintContainerLabel_LoadESigDetails_Parameters) parameters, (ReprintContainerLabel_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnProcessComputation(
      DCObject reprintContainerLabel,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ReprintContainerLabel_Result result1;
        ResultStatus resultStatus = this.ProcessComputation((ReprintContainerLabel) reprintContainerLabel, (ReprintContainerLabel_Parameters) parameters, (ReprintContainerLabel_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnResolveParametricData(
      DCObject reprintContainerLabel,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ReprintContainerLabel_Result result1;
        ResultStatus resultStatus = this.ResolveParametricData((ReprintContainerLabel) reprintContainerLabel, (ReprintContainerLabel_Parameters) parameters, (ReprintContainerLabel_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject reprintContainerLabel,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ReprintContainerLabel_Result result1;
        ResultStatus resultStatus = this.Load((ReprintContainerLabel) reprintContainerLabel, (ReprintContainerLabel_Parameters) parameters, (ReprintContainerLabel_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject reprintContainerLabel,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ReprintContainerLabel_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((ReprintContainerLabel) reprintContainerLabel, (ReprintContainerLabel_Parameters) parameters, (ReprintContainerLabel_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      ReprintContainerLabel_Request request,
      out ReprintContainerLabel_Result result)
    {
      result = (ReprintContainerLabel_Result) null;
      try
      {
        ReprintContainerLabelMethod[] methods = new ReprintContainerLabelMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IReprintContainerLabelService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        ReprintContainerLabel_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((ReprintContainerLabel_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      ReprintContainerLabel cdo,
      ReprintContainerLabel_Request request,
      out ReprintContainerLabel_Result result)
    {
      result = (ReprintContainerLabel_Result) null;
      try
      {
        return ((IReprintContainerLabelService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        ReprintContainerLabel_Result result1;
        ResultStatus environment = this.GetEnvironment((ReprintContainerLabel) cdo, (ReprintContainerLabel_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      ReprintContainerLabel_Request request,
      out ReprintContainerLabel_Result result)
    {
      return this.GetEnvironment((ReprintContainerLabel) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      ReprintContainerLabel cdo,
      ReprintContainerLabel_Request request,
      out ReprintContainerLabel_Result result)
    {
      result = (ReprintContainerLabel_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IReprintContainerLabelService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new ReprintContainerLabelMethod(cdo, ReprintContainerLabelMethods.ExecuteTransaction, (ReprintContainerLabel_Parameters) null));
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
        ReprintContainerLabel_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((ReprintContainerLabel) cdo, (ReprintContainerLabel_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(ReprintContainerLabel cdo)
    {
      return this.ExecuteTransaction(cdo, (ReprintContainerLabel_Request) null, out ReprintContainerLabel_Result _);
    }

    public ResultStatus ExecuteTransaction(
      ReprintContainerLabel_Request request,
      out ReprintContainerLabel_Result result)
    {
      return this.ExecuteTransaction((ReprintContainerLabel) null, request, out result);
    }

    public ResultStatus AddDataTransaction(ReprintContainerLabel cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new ReprintContainerLabelMethod(cdo, ReprintContainerLabelMethods.AddDataTransaction, (ReprintContainerLabel_Parameters) null));
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
        return this.AddDataTransaction((ReprintContainerLabel) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
