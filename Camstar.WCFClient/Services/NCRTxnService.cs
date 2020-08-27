// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.NCRTxnService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class NCRTxnService : ShopFloorBase
  {
    public NCRTxnService(UserProfile userProfile)
    {
      this.Initialize(typeof (INCRTxnService), userProfile);
    }

    public ResultStatus CreateParametricData(
      NCRTxn nCRTxn,
      NCRTxn_Parameters parameters,
      NCRTxn_Request request,
      out NCRTxn_Result result)
    {
      result = (NCRTxn_Result) null;
      this.OnBeforeCall(nameof (CreateParametricData), (DCObject) nCRTxn, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((INCRTxnService) this._Channel).CreateParametricData(this._UserProfile, nCRTxn, parameters, request, out result) : this.AddMethod((Method) new NCRTxnMethod(nCRTxn, NCRTxnMethods.CreateParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (CreateParametricData), res, (DCObject) nCRTxn, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus CreateParametricData()
    {
      return this.CreateParametricData((NCRTxn) null, (NCRTxn_Parameters) null, (NCRTxn_Request) null, out NCRTxn_Result _);
    }

    public ResultStatus CreateParametricData(NCRTxn nCRTxn)
    {
      return this.CreateParametricData(nCRTxn, (NCRTxn_Parameters) null, (NCRTxn_Request) null, out NCRTxn_Result _);
    }

    public ResultStatus CreateParametricData(
      NCRTxn nCRTxn,
      NCRTxn_Request request,
      out NCRTxn_Result result)
    {
      return this.CreateParametricData(nCRTxn, (NCRTxn_Parameters) null, request, out result);
    }

    public ResultStatus GetActions(
      NCRTxn nCRTxn,
      NCRTxn_Parameters parameters,
      NCRTxn_Request request,
      out NCRTxn_Result result)
    {
      result = (NCRTxn_Result) null;
      this.OnBeforeCall(nameof (GetActions), (DCObject) nCRTxn, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((INCRTxnService) this._Channel).GetActions(this._UserProfile, nCRTxn, parameters, request, out result) : this.AddMethod((Method) new NCRTxnMethod(nCRTxn, NCRTxnMethods.GetActions, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetActions), res, (DCObject) nCRTxn, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetActions()
    {
      return this.GetActions((NCRTxn) null, (NCRTxn_Parameters) null, (NCRTxn_Request) null, out NCRTxn_Result _);
    }

    public ResultStatus GetActions(NCRTxn nCRTxn)
    {
      return this.GetActions(nCRTxn, (NCRTxn_Parameters) null, (NCRTxn_Request) null, out NCRTxn_Result _);
    }

    public ResultStatus GetActions(
      NCRTxn nCRTxn,
      NCRTxn_Request request,
      out NCRTxn_Result result)
    {
      return this.GetActions(nCRTxn, (NCRTxn_Parameters) null, request, out result);
    }

    public ResultStatus GetDataPoints(
      NCRTxn nCRTxn,
      NCRTxn_Parameters parameters,
      NCRTxn_Request request,
      out NCRTxn_Result result)
    {
      result = (NCRTxn_Result) null;
      this.OnBeforeCall(nameof (GetDataPoints), (DCObject) nCRTxn, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((INCRTxnService) this._Channel).GetDataPoints(this._UserProfile, nCRTxn, parameters, request, out result) : this.AddMethod((Method) new NCRTxnMethod(nCRTxn, NCRTxnMethods.GetDataPoints, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetDataPoints), res, (DCObject) nCRTxn, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetDataPoints()
    {
      return this.GetDataPoints((NCRTxn) null, (NCRTxn_Parameters) null, (NCRTxn_Request) null, out NCRTxn_Result _);
    }

    public ResultStatus GetDataPoints(NCRTxn nCRTxn)
    {
      return this.GetDataPoints(nCRTxn, (NCRTxn_Parameters) null, (NCRTxn_Request) null, out NCRTxn_Result _);
    }

    public ResultStatus GetDataPoints(
      NCRTxn nCRTxn,
      NCRTxn_Request request,
      out NCRTxn_Result result)
    {
      return this.GetDataPoints(nCRTxn, (NCRTxn_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      NCRTxn nCRTxn,
      NCRTxn_Parameters parameters,
      NCRTxn_Request request,
      out NCRTxn_Result result)
    {
      result = (NCRTxn_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) nCRTxn, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((INCRTxnService) this._Channel).GetWIPMsgs(this._UserProfile, nCRTxn, parameters, request, out result) : this.AddMethod((Method) new NCRTxnMethod(nCRTxn, NCRTxnMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) nCRTxn, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((NCRTxn) null, (NCRTxn_Parameters) null, (NCRTxn_Request) null, out NCRTxn_Result _);
    }

    public ResultStatus GetWIPMsgs(NCRTxn nCRTxn)
    {
      return this.GetWIPMsgs(nCRTxn, (NCRTxn_Parameters) null, (NCRTxn_Request) null, out NCRTxn_Result _);
    }

    public ResultStatus GetWIPMsgs(
      NCRTxn nCRTxn,
      NCRTxn_Request request,
      out NCRTxn_Result result)
    {
      return this.GetWIPMsgs(nCRTxn, (NCRTxn_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      NCRTxn nCRTxn,
      NCRTxn_Parameters parameters,
      NCRTxn_Request request,
      out NCRTxn_Result result)
    {
      result = (NCRTxn_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) nCRTxn, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((INCRTxnService) this._Channel).Load(this._UserProfile, nCRTxn, parameters, request, out result) : this.AddMethod((Method) new NCRTxnMethod(nCRTxn, NCRTxnMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) nCRTxn, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((NCRTxn) null, (NCRTxn_Parameters) null, (NCRTxn_Request) null, out NCRTxn_Result _);
    }

    public ResultStatus Load(NCRTxn nCRTxn)
    {
      return this.Load(nCRTxn, (NCRTxn_Parameters) null, (NCRTxn_Request) null, out NCRTxn_Result _);
    }

    public ResultStatus Load(
      NCRTxn nCRTxn,
      NCRTxn_Request request,
      out NCRTxn_Result result)
    {
      return this.Load(nCRTxn, (NCRTxn_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      NCRTxn nCRTxn,
      NCRTxn_LoadESigDetails_Parameters parameters,
      NCRTxn_Request request,
      out NCRTxn_Result result)
    {
      result = (NCRTxn_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) nCRTxn, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((INCRTxnService) this._Channel).LoadESigDetails(this._UserProfile, nCRTxn, parameters, request, out result) : this.AddMethod((Method) new NCRTxnMethod(nCRTxn, NCRTxnMethods.LoadESigDetails, (NCRTxn_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) nCRTxn, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((NCRTxn) null, (NCRTxn_LoadESigDetails_Parameters) null, (NCRTxn_Request) null, out NCRTxn_Result _);
    }

    public ResultStatus LoadESigDetails(NCRTxn nCRTxn)
    {
      return this.LoadESigDetails(nCRTxn, (NCRTxn_LoadESigDetails_Parameters) null, (NCRTxn_Request) null, out NCRTxn_Result _);
    }

    public ResultStatus LoadESigDetails(
      NCRTxn nCRTxn,
      NCRTxn_Request request,
      out NCRTxn_Result result)
    {
      return this.LoadESigDetails(nCRTxn, (NCRTxn_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus ProcessComputation(
      NCRTxn nCRTxn,
      NCRTxn_Parameters parameters,
      NCRTxn_Request request,
      out NCRTxn_Result result)
    {
      result = (NCRTxn_Result) null;
      this.OnBeforeCall(nameof (ProcessComputation), (DCObject) nCRTxn, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((INCRTxnService) this._Channel).ProcessComputation(this._UserProfile, nCRTxn, parameters, request, out result) : this.AddMethod((Method) new NCRTxnMethod(nCRTxn, NCRTxnMethods.ProcessComputation, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ProcessComputation), res, (DCObject) nCRTxn, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ProcessComputation()
    {
      return this.ProcessComputation((NCRTxn) null, (NCRTxn_Parameters) null, (NCRTxn_Request) null, out NCRTxn_Result _);
    }

    public ResultStatus ProcessComputation(NCRTxn nCRTxn)
    {
      return this.ProcessComputation(nCRTxn, (NCRTxn_Parameters) null, (NCRTxn_Request) null, out NCRTxn_Result _);
    }

    public ResultStatus ProcessComputation(
      NCRTxn nCRTxn,
      NCRTxn_Request request,
      out NCRTxn_Result result)
    {
      return this.ProcessComputation(nCRTxn, (NCRTxn_Parameters) null, request, out result);
    }

    public ResultStatus ResolveParametricData(
      NCRTxn nCRTxn,
      NCRTxn_Parameters parameters,
      NCRTxn_Request request,
      out NCRTxn_Result result)
    {
      result = (NCRTxn_Result) null;
      this.OnBeforeCall(nameof (ResolveParametricData), (DCObject) nCRTxn, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((INCRTxnService) this._Channel).ResolveParametricData(this._UserProfile, nCRTxn, parameters, request, out result) : this.AddMethod((Method) new NCRTxnMethod(nCRTxn, NCRTxnMethods.ResolveParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ResolveParametricData), res, (DCObject) nCRTxn, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ResolveParametricData()
    {
      return this.ResolveParametricData((NCRTxn) null, (NCRTxn_Parameters) null, (NCRTxn_Request) null, out NCRTxn_Result _);
    }

    public ResultStatus ResolveParametricData(NCRTxn nCRTxn)
    {
      return this.ResolveParametricData(nCRTxn, (NCRTxn_Parameters) null, (NCRTxn_Request) null, out NCRTxn_Result _);
    }

    public ResultStatus ResolveParametricData(
      NCRTxn nCRTxn,
      NCRTxn_Request request,
      out NCRTxn_Result result)
    {
      return this.ResolveParametricData(nCRTxn, (NCRTxn_Parameters) null, request, out result);
    }

    protected override ResultStatus OnCreateParametricData(
      DCObject nCRTxn,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        NCRTxn_Result result1;
        ResultStatus parametricData = this.CreateParametricData((NCRTxn) nCRTxn, (NCRTxn_Parameters) parameters, (NCRTxn_Request) request, out result1);
        result = (Result) result1;
        return parametricData;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetActions(
      DCObject nCRTxn,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        NCRTxn_Result result1;
        ResultStatus actions = this.GetActions((NCRTxn) nCRTxn, (NCRTxn_Parameters) parameters, (NCRTxn_Request) request, out result1);
        result = (Result) result1;
        return actions;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetDataPoints(
      DCObject nCRTxn,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        NCRTxn_Result result1;
        ResultStatus dataPoints = this.GetDataPoints((NCRTxn) nCRTxn, (NCRTxn_Parameters) parameters, (NCRTxn_Request) request, out result1);
        result = (Result) result1;
        return dataPoints;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject nCRTxn,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        NCRTxn_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((NCRTxn) nCRTxn, (NCRTxn_LoadESigDetails_Parameters) parameters, (NCRTxn_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnProcessComputation(
      DCObject nCRTxn,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        NCRTxn_Result result1;
        ResultStatus resultStatus = this.ProcessComputation((NCRTxn) nCRTxn, (NCRTxn_Parameters) parameters, (NCRTxn_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnResolveParametricData(
      DCObject nCRTxn,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        NCRTxn_Result result1;
        ResultStatus resultStatus = this.ResolveParametricData((NCRTxn) nCRTxn, (NCRTxn_Parameters) parameters, (NCRTxn_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject nCRTxn,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        NCRTxn_Result result1;
        ResultStatus resultStatus = this.Load((NCRTxn) nCRTxn, (NCRTxn_Parameters) parameters, (NCRTxn_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject nCRTxn,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        NCRTxn_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((NCRTxn) nCRTxn, (NCRTxn_Parameters) parameters, (NCRTxn_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      NCRTxn_Request request,
      out NCRTxn_Result result)
    {
      result = (NCRTxn_Result) null;
      try
      {
        NCRTxnMethod[] methods = new NCRTxnMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((INCRTxnService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        NCRTxn_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((NCRTxn_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      NCRTxn cdo,
      NCRTxn_Request request,
      out NCRTxn_Result result)
    {
      result = (NCRTxn_Result) null;
      try
      {
        return ((INCRTxnService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        NCRTxn_Result result1;
        ResultStatus environment = this.GetEnvironment((NCRTxn) cdo, (NCRTxn_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(NCRTxn_Request request, out NCRTxn_Result result)
    {
      return this.GetEnvironment((NCRTxn) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      NCRTxn cdo,
      NCRTxn_Request request,
      out NCRTxn_Result result)
    {
      result = (NCRTxn_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((INCRTxnService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new NCRTxnMethod(cdo, NCRTxnMethods.ExecuteTransaction, (NCRTxn_Parameters) null));
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
        NCRTxn_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((NCRTxn) cdo, (NCRTxn_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(NCRTxn cdo)
    {
      return this.ExecuteTransaction(cdo, (NCRTxn_Request) null, out NCRTxn_Result _);
    }

    public ResultStatus ExecuteTransaction(
      NCRTxn_Request request,
      out NCRTxn_Result result)
    {
      return this.ExecuteTransaction((NCRTxn) null, request, out result);
    }

    public ResultStatus AddDataTransaction(NCRTxn cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new NCRTxnMethod(cdo, NCRTxnMethods.AddDataTransaction, (NCRTxn_Parameters) null));
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
        return this.AddDataTransaction((NCRTxn) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
