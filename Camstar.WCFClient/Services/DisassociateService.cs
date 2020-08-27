// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.DisassociateService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class DisassociateService : ContainerTxnBase
  {
    public DisassociateService(UserProfile userProfile)
    {
      this.Initialize(typeof (IDisassociateService), userProfile);
    }

    public ResultStatus CreateParametricData(
      Disassociate disassociate,
      Disassociate_Parameters parameters,
      Disassociate_Request request,
      out Disassociate_Result result)
    {
      result = (Disassociate_Result) null;
      this.OnBeforeCall(nameof (CreateParametricData), (DCObject) disassociate, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IDisassociateService) this._Channel).CreateParametricData(this._UserProfile, disassociate, parameters, request, out result) : this.AddMethod((Method) new DisassociateMethod(disassociate, DisassociateMethods.CreateParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (CreateParametricData), res, (DCObject) disassociate, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus CreateParametricData()
    {
      return this.CreateParametricData((Disassociate) null, (Disassociate_Parameters) null, (Disassociate_Request) null, out Disassociate_Result _);
    }

    public ResultStatus CreateParametricData(Disassociate disassociate)
    {
      return this.CreateParametricData(disassociate, (Disassociate_Parameters) null, (Disassociate_Request) null, out Disassociate_Result _);
    }

    public ResultStatus CreateParametricData(
      Disassociate disassociate,
      Disassociate_Request request,
      out Disassociate_Result result)
    {
      return this.CreateParametricData(disassociate, (Disassociate_Parameters) null, request, out result);
    }

    public ResultStatus GetActions(
      Disassociate disassociate,
      Disassociate_Parameters parameters,
      Disassociate_Request request,
      out Disassociate_Result result)
    {
      result = (Disassociate_Result) null;
      this.OnBeforeCall(nameof (GetActions), (DCObject) disassociate, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IDisassociateService) this._Channel).GetActions(this._UserProfile, disassociate, parameters, request, out result) : this.AddMethod((Method) new DisassociateMethod(disassociate, DisassociateMethods.GetActions, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetActions), res, (DCObject) disassociate, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetActions()
    {
      return this.GetActions((Disassociate) null, (Disassociate_Parameters) null, (Disassociate_Request) null, out Disassociate_Result _);
    }

    public ResultStatus GetActions(Disassociate disassociate)
    {
      return this.GetActions(disassociate, (Disassociate_Parameters) null, (Disassociate_Request) null, out Disassociate_Result _);
    }

    public ResultStatus GetActions(
      Disassociate disassociate,
      Disassociate_Request request,
      out Disassociate_Result result)
    {
      return this.GetActions(disassociate, (Disassociate_Parameters) null, request, out result);
    }

    public ResultStatus GetDataPoints(
      Disassociate disassociate,
      Disassociate_Parameters parameters,
      Disassociate_Request request,
      out Disassociate_Result result)
    {
      result = (Disassociate_Result) null;
      this.OnBeforeCall(nameof (GetDataPoints), (DCObject) disassociate, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IDisassociateService) this._Channel).GetDataPoints(this._UserProfile, disassociate, parameters, request, out result) : this.AddMethod((Method) new DisassociateMethod(disassociate, DisassociateMethods.GetDataPoints, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetDataPoints), res, (DCObject) disassociate, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetDataPoints()
    {
      return this.GetDataPoints((Disassociate) null, (Disassociate_Parameters) null, (Disassociate_Request) null, out Disassociate_Result _);
    }

    public ResultStatus GetDataPoints(Disassociate disassociate)
    {
      return this.GetDataPoints(disassociate, (Disassociate_Parameters) null, (Disassociate_Request) null, out Disassociate_Result _);
    }

    public ResultStatus GetDataPoints(
      Disassociate disassociate,
      Disassociate_Request request,
      out Disassociate_Result result)
    {
      return this.GetDataPoints(disassociate, (Disassociate_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      Disassociate disassociate,
      Disassociate_Parameters parameters,
      Disassociate_Request request,
      out Disassociate_Result result)
    {
      result = (Disassociate_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) disassociate, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IDisassociateService) this._Channel).GetWIPMsgs(this._UserProfile, disassociate, parameters, request, out result) : this.AddMethod((Method) new DisassociateMethod(disassociate, DisassociateMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) disassociate, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((Disassociate) null, (Disassociate_Parameters) null, (Disassociate_Request) null, out Disassociate_Result _);
    }

    public ResultStatus GetWIPMsgs(Disassociate disassociate)
    {
      return this.GetWIPMsgs(disassociate, (Disassociate_Parameters) null, (Disassociate_Request) null, out Disassociate_Result _);
    }

    public ResultStatus GetWIPMsgs(
      Disassociate disassociate,
      Disassociate_Request request,
      out Disassociate_Result result)
    {
      return this.GetWIPMsgs(disassociate, (Disassociate_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      Disassociate disassociate,
      Disassociate_Parameters parameters,
      Disassociate_Request request,
      out Disassociate_Result result)
    {
      result = (Disassociate_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) disassociate, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IDisassociateService) this._Channel).Load(this._UserProfile, disassociate, parameters, request, out result) : this.AddMethod((Method) new DisassociateMethod(disassociate, DisassociateMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) disassociate, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((Disassociate) null, (Disassociate_Parameters) null, (Disassociate_Request) null, out Disassociate_Result _);
    }

    public ResultStatus Load(Disassociate disassociate)
    {
      return this.Load(disassociate, (Disassociate_Parameters) null, (Disassociate_Request) null, out Disassociate_Result _);
    }

    public ResultStatus Load(
      Disassociate disassociate,
      Disassociate_Request request,
      out Disassociate_Result result)
    {
      return this.Load(disassociate, (Disassociate_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      Disassociate disassociate,
      Disassociate_LoadESigDetails_Parameters parameters,
      Disassociate_Request request,
      out Disassociate_Result result)
    {
      result = (Disassociate_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) disassociate, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IDisassociateService) this._Channel).LoadESigDetails(this._UserProfile, disassociate, parameters, request, out result) : this.AddMethod((Method) new DisassociateMethod(disassociate, DisassociateMethods.LoadESigDetails, (Disassociate_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) disassociate, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((Disassociate) null, (Disassociate_LoadESigDetails_Parameters) null, (Disassociate_Request) null, out Disassociate_Result _);
    }

    public ResultStatus LoadESigDetails(Disassociate disassociate)
    {
      return this.LoadESigDetails(disassociate, (Disassociate_LoadESigDetails_Parameters) null, (Disassociate_Request) null, out Disassociate_Result _);
    }

    public ResultStatus LoadESigDetails(
      Disassociate disassociate,
      Disassociate_Request request,
      out Disassociate_Result result)
    {
      return this.LoadESigDetails(disassociate, (Disassociate_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus ProcessComputation(
      Disassociate disassociate,
      Disassociate_Parameters parameters,
      Disassociate_Request request,
      out Disassociate_Result result)
    {
      result = (Disassociate_Result) null;
      this.OnBeforeCall(nameof (ProcessComputation), (DCObject) disassociate, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IDisassociateService) this._Channel).ProcessComputation(this._UserProfile, disassociate, parameters, request, out result) : this.AddMethod((Method) new DisassociateMethod(disassociate, DisassociateMethods.ProcessComputation, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ProcessComputation), res, (DCObject) disassociate, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ProcessComputation()
    {
      return this.ProcessComputation((Disassociate) null, (Disassociate_Parameters) null, (Disassociate_Request) null, out Disassociate_Result _);
    }

    public ResultStatus ProcessComputation(Disassociate disassociate)
    {
      return this.ProcessComputation(disassociate, (Disassociate_Parameters) null, (Disassociate_Request) null, out Disassociate_Result _);
    }

    public ResultStatus ProcessComputation(
      Disassociate disassociate,
      Disassociate_Request request,
      out Disassociate_Result result)
    {
      return this.ProcessComputation(disassociate, (Disassociate_Parameters) null, request, out result);
    }

    public ResultStatus ResolveParametricData(
      Disassociate disassociate,
      Disassociate_Parameters parameters,
      Disassociate_Request request,
      out Disassociate_Result result)
    {
      result = (Disassociate_Result) null;
      this.OnBeforeCall(nameof (ResolveParametricData), (DCObject) disassociate, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IDisassociateService) this._Channel).ResolveParametricData(this._UserProfile, disassociate, parameters, request, out result) : this.AddMethod((Method) new DisassociateMethod(disassociate, DisassociateMethods.ResolveParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ResolveParametricData), res, (DCObject) disassociate, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ResolveParametricData()
    {
      return this.ResolveParametricData((Disassociate) null, (Disassociate_Parameters) null, (Disassociate_Request) null, out Disassociate_Result _);
    }

    public ResultStatus ResolveParametricData(Disassociate disassociate)
    {
      return this.ResolveParametricData(disassociate, (Disassociate_Parameters) null, (Disassociate_Request) null, out Disassociate_Result _);
    }

    public ResultStatus ResolveParametricData(
      Disassociate disassociate,
      Disassociate_Request request,
      out Disassociate_Result result)
    {
      return this.ResolveParametricData(disassociate, (Disassociate_Parameters) null, request, out result);
    }

    protected override ResultStatus OnCreateParametricData(
      DCObject disassociate,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        Disassociate_Result result1;
        ResultStatus parametricData = this.CreateParametricData((Disassociate) disassociate, (Disassociate_Parameters) parameters, (Disassociate_Request) request, out result1);
        result = (Result) result1;
        return parametricData;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetActions(
      DCObject disassociate,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        Disassociate_Result result1;
        ResultStatus actions = this.GetActions((Disassociate) disassociate, (Disassociate_Parameters) parameters, (Disassociate_Request) request, out result1);
        result = (Result) result1;
        return actions;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetDataPoints(
      DCObject disassociate,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        Disassociate_Result result1;
        ResultStatus dataPoints = this.GetDataPoints((Disassociate) disassociate, (Disassociate_Parameters) parameters, (Disassociate_Request) request, out result1);
        result = (Result) result1;
        return dataPoints;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject disassociate,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        Disassociate_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((Disassociate) disassociate, (Disassociate_LoadESigDetails_Parameters) parameters, (Disassociate_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnProcessComputation(
      DCObject disassociate,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        Disassociate_Result result1;
        ResultStatus resultStatus = this.ProcessComputation((Disassociate) disassociate, (Disassociate_Parameters) parameters, (Disassociate_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnResolveParametricData(
      DCObject disassociate,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        Disassociate_Result result1;
        ResultStatus resultStatus = this.ResolveParametricData((Disassociate) disassociate, (Disassociate_Parameters) parameters, (Disassociate_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject disassociate,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        Disassociate_Result result1;
        ResultStatus resultStatus = this.Load((Disassociate) disassociate, (Disassociate_Parameters) parameters, (Disassociate_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject disassociate,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        Disassociate_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((Disassociate) disassociate, (Disassociate_Parameters) parameters, (Disassociate_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      Disassociate_Request request,
      out Disassociate_Result result)
    {
      result = (Disassociate_Result) null;
      try
      {
        DisassociateMethod[] methods = new DisassociateMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IDisassociateService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        Disassociate_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((Disassociate_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      Disassociate cdo,
      Disassociate_Request request,
      out Disassociate_Result result)
    {
      result = (Disassociate_Result) null;
      try
      {
        return ((IDisassociateService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        Disassociate_Result result1;
        ResultStatus environment = this.GetEnvironment((Disassociate) cdo, (Disassociate_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      Disassociate_Request request,
      out Disassociate_Result result)
    {
      return this.GetEnvironment((Disassociate) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      Disassociate cdo,
      Disassociate_Request request,
      out Disassociate_Result result)
    {
      result = (Disassociate_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IDisassociateService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new DisassociateMethod(cdo, DisassociateMethods.ExecuteTransaction, (Disassociate_Parameters) null));
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
        Disassociate_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((Disassociate) cdo, (Disassociate_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(Disassociate cdo)
    {
      return this.ExecuteTransaction(cdo, (Disassociate_Request) null, out Disassociate_Result _);
    }

    public ResultStatus ExecuteTransaction(
      Disassociate_Request request,
      out Disassociate_Result result)
    {
      return this.ExecuteTransaction((Disassociate) null, request, out result);
    }

    public ResultStatus AddDataTransaction(Disassociate cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new DisassociateMethod(cdo, DisassociateMethods.AddDataTransaction, (Disassociate_Parameters) null));
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
        return this.AddDataTransaction((Disassociate) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
