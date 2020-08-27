// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.OpensService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class OpensService : ContainerStatusChangesBase
  {
    public OpensService(UserProfile userProfile)
    {
      this.Initialize(typeof (IOpensService), userProfile);
    }

    public ResultStatus CreateParametricData(
      Opens opens,
      Opens_Parameters parameters,
      Opens_Request request,
      out Opens_Result result)
    {
      result = (Opens_Result) null;
      this.OnBeforeCall(nameof (CreateParametricData), (DCObject) opens, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IOpensService) this._Channel).CreateParametricData(this._UserProfile, opens, parameters, request, out result) : this.AddMethod((Method) new OpensMethod(opens, OpensMethods.CreateParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (CreateParametricData), res, (DCObject) opens, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus CreateParametricData()
    {
      return this.CreateParametricData((Opens) null, (Opens_Parameters) null, (Opens_Request) null, out Opens_Result _);
    }

    public ResultStatus CreateParametricData(Opens opens)
    {
      return this.CreateParametricData(opens, (Opens_Parameters) null, (Opens_Request) null, out Opens_Result _);
    }

    public ResultStatus CreateParametricData(
      Opens opens,
      Opens_Request request,
      out Opens_Result result)
    {
      return this.CreateParametricData(opens, (Opens_Parameters) null, request, out result);
    }

    public ResultStatus GetActions(
      Opens opens,
      Opens_Parameters parameters,
      Opens_Request request,
      out Opens_Result result)
    {
      result = (Opens_Result) null;
      this.OnBeforeCall(nameof (GetActions), (DCObject) opens, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IOpensService) this._Channel).GetActions(this._UserProfile, opens, parameters, request, out result) : this.AddMethod((Method) new OpensMethod(opens, OpensMethods.GetActions, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetActions), res, (DCObject) opens, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetActions()
    {
      return this.GetActions((Opens) null, (Opens_Parameters) null, (Opens_Request) null, out Opens_Result _);
    }

    public ResultStatus GetActions(Opens opens)
    {
      return this.GetActions(opens, (Opens_Parameters) null, (Opens_Request) null, out Opens_Result _);
    }

    public ResultStatus GetActions(
      Opens opens,
      Opens_Request request,
      out Opens_Result result)
    {
      return this.GetActions(opens, (Opens_Parameters) null, request, out result);
    }

    public ResultStatus GetDataPoints(
      Opens opens,
      Opens_Parameters parameters,
      Opens_Request request,
      out Opens_Result result)
    {
      result = (Opens_Result) null;
      this.OnBeforeCall(nameof (GetDataPoints), (DCObject) opens, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IOpensService) this._Channel).GetDataPoints(this._UserProfile, opens, parameters, request, out result) : this.AddMethod((Method) new OpensMethod(opens, OpensMethods.GetDataPoints, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetDataPoints), res, (DCObject) opens, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetDataPoints()
    {
      return this.GetDataPoints((Opens) null, (Opens_Parameters) null, (Opens_Request) null, out Opens_Result _);
    }

    public ResultStatus GetDataPoints(Opens opens)
    {
      return this.GetDataPoints(opens, (Opens_Parameters) null, (Opens_Request) null, out Opens_Result _);
    }

    public ResultStatus GetDataPoints(
      Opens opens,
      Opens_Request request,
      out Opens_Result result)
    {
      return this.GetDataPoints(opens, (Opens_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      Opens opens,
      Opens_Parameters parameters,
      Opens_Request request,
      out Opens_Result result)
    {
      result = (Opens_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) opens, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IOpensService) this._Channel).GetWIPMsgs(this._UserProfile, opens, parameters, request, out result) : this.AddMethod((Method) new OpensMethod(opens, OpensMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) opens, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((Opens) null, (Opens_Parameters) null, (Opens_Request) null, out Opens_Result _);
    }

    public ResultStatus GetWIPMsgs(Opens opens)
    {
      return this.GetWIPMsgs(opens, (Opens_Parameters) null, (Opens_Request) null, out Opens_Result _);
    }

    public ResultStatus GetWIPMsgs(
      Opens opens,
      Opens_Request request,
      out Opens_Result result)
    {
      return this.GetWIPMsgs(opens, (Opens_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      Opens opens,
      Opens_Parameters parameters,
      Opens_Request request,
      out Opens_Result result)
    {
      result = (Opens_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) opens, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IOpensService) this._Channel).Load(this._UserProfile, opens, parameters, request, out result) : this.AddMethod((Method) new OpensMethod(opens, OpensMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) opens, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((Opens) null, (Opens_Parameters) null, (Opens_Request) null, out Opens_Result _);
    }

    public ResultStatus Load(Opens opens)
    {
      return this.Load(opens, (Opens_Parameters) null, (Opens_Request) null, out Opens_Result _);
    }

    public ResultStatus Load(
      Opens opens,
      Opens_Request request,
      out Opens_Result result)
    {
      return this.Load(opens, (Opens_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      Opens opens,
      Opens_LoadESigDetails_Parameters parameters,
      Opens_Request request,
      out Opens_Result result)
    {
      result = (Opens_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) opens, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IOpensService) this._Channel).LoadESigDetails(this._UserProfile, opens, parameters, request, out result) : this.AddMethod((Method) new OpensMethod(opens, OpensMethods.LoadESigDetails, (Opens_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) opens, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((Opens) null, (Opens_LoadESigDetails_Parameters) null, (Opens_Request) null, out Opens_Result _);
    }

    public ResultStatus LoadESigDetails(Opens opens)
    {
      return this.LoadESigDetails(opens, (Opens_LoadESigDetails_Parameters) null, (Opens_Request) null, out Opens_Result _);
    }

    public ResultStatus LoadESigDetails(
      Opens opens,
      Opens_Request request,
      out Opens_Result result)
    {
      return this.LoadESigDetails(opens, (Opens_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus ProcessComputation(
      Opens opens,
      Opens_Parameters parameters,
      Opens_Request request,
      out Opens_Result result)
    {
      result = (Opens_Result) null;
      this.OnBeforeCall(nameof (ProcessComputation), (DCObject) opens, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IOpensService) this._Channel).ProcessComputation(this._UserProfile, opens, parameters, request, out result) : this.AddMethod((Method) new OpensMethod(opens, OpensMethods.ProcessComputation, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ProcessComputation), res, (DCObject) opens, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ProcessComputation()
    {
      return this.ProcessComputation((Opens) null, (Opens_Parameters) null, (Opens_Request) null, out Opens_Result _);
    }

    public ResultStatus ProcessComputation(Opens opens)
    {
      return this.ProcessComputation(opens, (Opens_Parameters) null, (Opens_Request) null, out Opens_Result _);
    }

    public ResultStatus ProcessComputation(
      Opens opens,
      Opens_Request request,
      out Opens_Result result)
    {
      return this.ProcessComputation(opens, (Opens_Parameters) null, request, out result);
    }

    public ResultStatus ResolveParametricData(
      Opens opens,
      Opens_Parameters parameters,
      Opens_Request request,
      out Opens_Result result)
    {
      result = (Opens_Result) null;
      this.OnBeforeCall(nameof (ResolveParametricData), (DCObject) opens, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IOpensService) this._Channel).ResolveParametricData(this._UserProfile, opens, parameters, request, out result) : this.AddMethod((Method) new OpensMethod(opens, OpensMethods.ResolveParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ResolveParametricData), res, (DCObject) opens, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ResolveParametricData()
    {
      return this.ResolveParametricData((Opens) null, (Opens_Parameters) null, (Opens_Request) null, out Opens_Result _);
    }

    public ResultStatus ResolveParametricData(Opens opens)
    {
      return this.ResolveParametricData(opens, (Opens_Parameters) null, (Opens_Request) null, out Opens_Result _);
    }

    public ResultStatus ResolveParametricData(
      Opens opens,
      Opens_Request request,
      out Opens_Result result)
    {
      return this.ResolveParametricData(opens, (Opens_Parameters) null, request, out result);
    }

    protected override ResultStatus OnCreateParametricData(
      DCObject opens,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        Opens_Result result1;
        ResultStatus parametricData = this.CreateParametricData((Opens) opens, (Opens_Parameters) parameters, (Opens_Request) request, out result1);
        result = (Result) result1;
        return parametricData;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetActions(
      DCObject opens,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        Opens_Result result1;
        ResultStatus actions = this.GetActions((Opens) opens, (Opens_Parameters) parameters, (Opens_Request) request, out result1);
        result = (Result) result1;
        return actions;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetDataPoints(
      DCObject opens,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        Opens_Result result1;
        ResultStatus dataPoints = this.GetDataPoints((Opens) opens, (Opens_Parameters) parameters, (Opens_Request) request, out result1);
        result = (Result) result1;
        return dataPoints;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject opens,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        Opens_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((Opens) opens, (Opens_LoadESigDetails_Parameters) parameters, (Opens_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnProcessComputation(
      DCObject opens,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        Opens_Result result1;
        ResultStatus resultStatus = this.ProcessComputation((Opens) opens, (Opens_Parameters) parameters, (Opens_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnResolveParametricData(
      DCObject opens,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        Opens_Result result1;
        ResultStatus resultStatus = this.ResolveParametricData((Opens) opens, (Opens_Parameters) parameters, (Opens_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject opens,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        Opens_Result result1;
        ResultStatus resultStatus = this.Load((Opens) opens, (Opens_Parameters) parameters, (Opens_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject opens,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        Opens_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((Opens) opens, (Opens_Parameters) parameters, (Opens_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      Opens_Request request,
      out Opens_Result result)
    {
      result = (Opens_Result) null;
      try
      {
        OpensMethod[] methods = new OpensMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IOpensService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        Opens_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((Opens_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      Opens cdo,
      Opens_Request request,
      out Opens_Result result)
    {
      result = (Opens_Result) null;
      try
      {
        return ((IOpensService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        Opens_Result result1;
        ResultStatus environment = this.GetEnvironment((Opens) cdo, (Opens_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(Opens_Request request, out Opens_Result result)
    {
      return this.GetEnvironment((Opens) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      Opens cdo,
      Opens_Request request,
      out Opens_Result result)
    {
      result = (Opens_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IOpensService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new OpensMethod(cdo, OpensMethods.ExecuteTransaction, (Opens_Parameters) null));
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
        Opens_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((Opens) cdo, (Opens_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(Opens cdo)
    {
      return this.ExecuteTransaction(cdo, (Opens_Request) null, out Opens_Result _);
    }

    public ResultStatus ExecuteTransaction(
      Opens_Request request,
      out Opens_Result result)
    {
      return this.ExecuteTransaction((Opens) null, request, out result);
    }

    public ResultStatus AddDataTransaction(Opens cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new OpensMethod(cdo, OpensMethods.AddDataTransaction, (Opens_Parameters) null));
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
        return this.AddDataTransaction((Opens) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
