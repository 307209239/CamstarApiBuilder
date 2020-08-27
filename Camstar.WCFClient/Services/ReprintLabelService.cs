// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.ReprintLabelService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class ReprintLabelService : PrintLabelTxnBase
  {
    public ReprintLabelService(UserProfile userProfile)
    {
      this.Initialize(typeof (IReprintLabelService), userProfile);
    }

    public ResultStatus CreateParametricData(
      ReprintLabel reprintLabel,
      ReprintLabel_Parameters parameters,
      ReprintLabel_Request request,
      out ReprintLabel_Result result)
    {
      result = (ReprintLabel_Result) null;
      this.OnBeforeCall(nameof (CreateParametricData), (DCObject) reprintLabel, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IReprintLabelService) this._Channel).CreateParametricData(this._UserProfile, reprintLabel, parameters, request, out result) : this.AddMethod((Method) new ReprintLabelMethod(reprintLabel, ReprintLabelMethods.CreateParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (CreateParametricData), res, (DCObject) reprintLabel, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus CreateParametricData()
    {
      return this.CreateParametricData((ReprintLabel) null, (ReprintLabel_Parameters) null, (ReprintLabel_Request) null, out ReprintLabel_Result _);
    }

    public ResultStatus CreateParametricData(ReprintLabel reprintLabel)
    {
      return this.CreateParametricData(reprintLabel, (ReprintLabel_Parameters) null, (ReprintLabel_Request) null, out ReprintLabel_Result _);
    }

    public ResultStatus CreateParametricData(
      ReprintLabel reprintLabel,
      ReprintLabel_Request request,
      out ReprintLabel_Result result)
    {
      return this.CreateParametricData(reprintLabel, (ReprintLabel_Parameters) null, request, out result);
    }

    public ResultStatus GetActions(
      ReprintLabel reprintLabel,
      ReprintLabel_Parameters parameters,
      ReprintLabel_Request request,
      out ReprintLabel_Result result)
    {
      result = (ReprintLabel_Result) null;
      this.OnBeforeCall(nameof (GetActions), (DCObject) reprintLabel, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IReprintLabelService) this._Channel).GetActions(this._UserProfile, reprintLabel, parameters, request, out result) : this.AddMethod((Method) new ReprintLabelMethod(reprintLabel, ReprintLabelMethods.GetActions, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetActions), res, (DCObject) reprintLabel, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetActions()
    {
      return this.GetActions((ReprintLabel) null, (ReprintLabel_Parameters) null, (ReprintLabel_Request) null, out ReprintLabel_Result _);
    }

    public ResultStatus GetActions(ReprintLabel reprintLabel)
    {
      return this.GetActions(reprintLabel, (ReprintLabel_Parameters) null, (ReprintLabel_Request) null, out ReprintLabel_Result _);
    }

    public ResultStatus GetActions(
      ReprintLabel reprintLabel,
      ReprintLabel_Request request,
      out ReprintLabel_Result result)
    {
      return this.GetActions(reprintLabel, (ReprintLabel_Parameters) null, request, out result);
    }

    public ResultStatus GetDataPoints(
      ReprintLabel reprintLabel,
      ReprintLabel_Parameters parameters,
      ReprintLabel_Request request,
      out ReprintLabel_Result result)
    {
      result = (ReprintLabel_Result) null;
      this.OnBeforeCall(nameof (GetDataPoints), (DCObject) reprintLabel, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IReprintLabelService) this._Channel).GetDataPoints(this._UserProfile, reprintLabel, parameters, request, out result) : this.AddMethod((Method) new ReprintLabelMethod(reprintLabel, ReprintLabelMethods.GetDataPoints, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetDataPoints), res, (DCObject) reprintLabel, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetDataPoints()
    {
      return this.GetDataPoints((ReprintLabel) null, (ReprintLabel_Parameters) null, (ReprintLabel_Request) null, out ReprintLabel_Result _);
    }

    public ResultStatus GetDataPoints(ReprintLabel reprintLabel)
    {
      return this.GetDataPoints(reprintLabel, (ReprintLabel_Parameters) null, (ReprintLabel_Request) null, out ReprintLabel_Result _);
    }

    public ResultStatus GetDataPoints(
      ReprintLabel reprintLabel,
      ReprintLabel_Request request,
      out ReprintLabel_Result result)
    {
      return this.GetDataPoints(reprintLabel, (ReprintLabel_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      ReprintLabel reprintLabel,
      ReprintLabel_Parameters parameters,
      ReprintLabel_Request request,
      out ReprintLabel_Result result)
    {
      result = (ReprintLabel_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) reprintLabel, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IReprintLabelService) this._Channel).GetWIPMsgs(this._UserProfile, reprintLabel, parameters, request, out result) : this.AddMethod((Method) new ReprintLabelMethod(reprintLabel, ReprintLabelMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) reprintLabel, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((ReprintLabel) null, (ReprintLabel_Parameters) null, (ReprintLabel_Request) null, out ReprintLabel_Result _);
    }

    public ResultStatus GetWIPMsgs(ReprintLabel reprintLabel)
    {
      return this.GetWIPMsgs(reprintLabel, (ReprintLabel_Parameters) null, (ReprintLabel_Request) null, out ReprintLabel_Result _);
    }

    public ResultStatus GetWIPMsgs(
      ReprintLabel reprintLabel,
      ReprintLabel_Request request,
      out ReprintLabel_Result result)
    {
      return this.GetWIPMsgs(reprintLabel, (ReprintLabel_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      ReprintLabel reprintLabel,
      ReprintLabel_Parameters parameters,
      ReprintLabel_Request request,
      out ReprintLabel_Result result)
    {
      result = (ReprintLabel_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) reprintLabel, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IReprintLabelService) this._Channel).Load(this._UserProfile, reprintLabel, parameters, request, out result) : this.AddMethod((Method) new ReprintLabelMethod(reprintLabel, ReprintLabelMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) reprintLabel, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((ReprintLabel) null, (ReprintLabel_Parameters) null, (ReprintLabel_Request) null, out ReprintLabel_Result _);
    }

    public ResultStatus Load(ReprintLabel reprintLabel)
    {
      return this.Load(reprintLabel, (ReprintLabel_Parameters) null, (ReprintLabel_Request) null, out ReprintLabel_Result _);
    }

    public ResultStatus Load(
      ReprintLabel reprintLabel,
      ReprintLabel_Request request,
      out ReprintLabel_Result result)
    {
      return this.Load(reprintLabel, (ReprintLabel_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      ReprintLabel reprintLabel,
      ReprintLabel_LoadESigDetails_Parameters parameters,
      ReprintLabel_Request request,
      out ReprintLabel_Result result)
    {
      result = (ReprintLabel_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) reprintLabel, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IReprintLabelService) this._Channel).LoadESigDetails(this._UserProfile, reprintLabel, parameters, request, out result) : this.AddMethod((Method) new ReprintLabelMethod(reprintLabel, ReprintLabelMethods.LoadESigDetails, (ReprintLabel_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) reprintLabel, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((ReprintLabel) null, (ReprintLabel_LoadESigDetails_Parameters) null, (ReprintLabel_Request) null, out ReprintLabel_Result _);
    }

    public ResultStatus LoadESigDetails(ReprintLabel reprintLabel)
    {
      return this.LoadESigDetails(reprintLabel, (ReprintLabel_LoadESigDetails_Parameters) null, (ReprintLabel_Request) null, out ReprintLabel_Result _);
    }

    public ResultStatus LoadESigDetails(
      ReprintLabel reprintLabel,
      ReprintLabel_Request request,
      out ReprintLabel_Result result)
    {
      return this.LoadESigDetails(reprintLabel, (ReprintLabel_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus ProcessComputation(
      ReprintLabel reprintLabel,
      ReprintLabel_Parameters parameters,
      ReprintLabel_Request request,
      out ReprintLabel_Result result)
    {
      result = (ReprintLabel_Result) null;
      this.OnBeforeCall(nameof (ProcessComputation), (DCObject) reprintLabel, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IReprintLabelService) this._Channel).ProcessComputation(this._UserProfile, reprintLabel, parameters, request, out result) : this.AddMethod((Method) new ReprintLabelMethod(reprintLabel, ReprintLabelMethods.ProcessComputation, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ProcessComputation), res, (DCObject) reprintLabel, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ProcessComputation()
    {
      return this.ProcessComputation((ReprintLabel) null, (ReprintLabel_Parameters) null, (ReprintLabel_Request) null, out ReprintLabel_Result _);
    }

    public ResultStatus ProcessComputation(ReprintLabel reprintLabel)
    {
      return this.ProcessComputation(reprintLabel, (ReprintLabel_Parameters) null, (ReprintLabel_Request) null, out ReprintLabel_Result _);
    }

    public ResultStatus ProcessComputation(
      ReprintLabel reprintLabel,
      ReprintLabel_Request request,
      out ReprintLabel_Result result)
    {
      return this.ProcessComputation(reprintLabel, (ReprintLabel_Parameters) null, request, out result);
    }

    public ResultStatus ResolveParametricData(
      ReprintLabel reprintLabel,
      ReprintLabel_Parameters parameters,
      ReprintLabel_Request request,
      out ReprintLabel_Result result)
    {
      result = (ReprintLabel_Result) null;
      this.OnBeforeCall(nameof (ResolveParametricData), (DCObject) reprintLabel, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IReprintLabelService) this._Channel).ResolveParametricData(this._UserProfile, reprintLabel, parameters, request, out result) : this.AddMethod((Method) new ReprintLabelMethod(reprintLabel, ReprintLabelMethods.ResolveParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ResolveParametricData), res, (DCObject) reprintLabel, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ResolveParametricData()
    {
      return this.ResolveParametricData((ReprintLabel) null, (ReprintLabel_Parameters) null, (ReprintLabel_Request) null, out ReprintLabel_Result _);
    }

    public ResultStatus ResolveParametricData(ReprintLabel reprintLabel)
    {
      return this.ResolveParametricData(reprintLabel, (ReprintLabel_Parameters) null, (ReprintLabel_Request) null, out ReprintLabel_Result _);
    }

    public ResultStatus ResolveParametricData(
      ReprintLabel reprintLabel,
      ReprintLabel_Request request,
      out ReprintLabel_Result result)
    {
      return this.ResolveParametricData(reprintLabel, (ReprintLabel_Parameters) null, request, out result);
    }

    protected override ResultStatus OnCreateParametricData(
      DCObject reprintLabel,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ReprintLabel_Result result1;
        ResultStatus parametricData = this.CreateParametricData((ReprintLabel) reprintLabel, (ReprintLabel_Parameters) parameters, (ReprintLabel_Request) request, out result1);
        result = (Result) result1;
        return parametricData;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetActions(
      DCObject reprintLabel,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ReprintLabel_Result result1;
        ResultStatus actions = this.GetActions((ReprintLabel) reprintLabel, (ReprintLabel_Parameters) parameters, (ReprintLabel_Request) request, out result1);
        result = (Result) result1;
        return actions;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetDataPoints(
      DCObject reprintLabel,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ReprintLabel_Result result1;
        ResultStatus dataPoints = this.GetDataPoints((ReprintLabel) reprintLabel, (ReprintLabel_Parameters) parameters, (ReprintLabel_Request) request, out result1);
        result = (Result) result1;
        return dataPoints;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject reprintLabel,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ReprintLabel_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((ReprintLabel) reprintLabel, (ReprintLabel_LoadESigDetails_Parameters) parameters, (ReprintLabel_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnProcessComputation(
      DCObject reprintLabel,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ReprintLabel_Result result1;
        ResultStatus resultStatus = this.ProcessComputation((ReprintLabel) reprintLabel, (ReprintLabel_Parameters) parameters, (ReprintLabel_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnResolveParametricData(
      DCObject reprintLabel,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ReprintLabel_Result result1;
        ResultStatus resultStatus = this.ResolveParametricData((ReprintLabel) reprintLabel, (ReprintLabel_Parameters) parameters, (ReprintLabel_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject reprintLabel,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ReprintLabel_Result result1;
        ResultStatus resultStatus = this.Load((ReprintLabel) reprintLabel, (ReprintLabel_Parameters) parameters, (ReprintLabel_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject reprintLabel,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ReprintLabel_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((ReprintLabel) reprintLabel, (ReprintLabel_Parameters) parameters, (ReprintLabel_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      ReprintLabel_Request request,
      out ReprintLabel_Result result)
    {
      result = (ReprintLabel_Result) null;
      try
      {
        ReprintLabelMethod[] methods = new ReprintLabelMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IReprintLabelService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        ReprintLabel_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((ReprintLabel_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      ReprintLabel cdo,
      ReprintLabel_Request request,
      out ReprintLabel_Result result)
    {
      result = (ReprintLabel_Result) null;
      try
      {
        return ((IReprintLabelService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        ReprintLabel_Result result1;
        ResultStatus environment = this.GetEnvironment((ReprintLabel) cdo, (ReprintLabel_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      ReprintLabel_Request request,
      out ReprintLabel_Result result)
    {
      return this.GetEnvironment((ReprintLabel) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      ReprintLabel cdo,
      ReprintLabel_Request request,
      out ReprintLabel_Result result)
    {
      result = (ReprintLabel_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IReprintLabelService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new ReprintLabelMethod(cdo, ReprintLabelMethods.ExecuteTransaction, (ReprintLabel_Parameters) null));
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
        ReprintLabel_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((ReprintLabel) cdo, (ReprintLabel_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(ReprintLabel cdo)
    {
      return this.ExecuteTransaction(cdo, (ReprintLabel_Request) null, out ReprintLabel_Result _);
    }

    public ResultStatus ExecuteTransaction(
      ReprintLabel_Request request,
      out ReprintLabel_Result result)
    {
      return this.ExecuteTransaction((ReprintLabel) null, request, out result);
    }

    public ResultStatus AddDataTransaction(ReprintLabel cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new ReprintLabelMethod(cdo, ReprintLabelMethods.AddDataTransaction, (ReprintLabel_Parameters) null));
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
        return this.AddDataTransaction((ReprintLabel) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
