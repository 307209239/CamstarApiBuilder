// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.OpenService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class OpenService : ContainerStatusChangeBase
  {
    public OpenService(UserProfile userProfile)
    {
      this.Initialize(typeof (IOpenService), userProfile);
    }

    public ResultStatus CreateParametricData(
      Open open,
      Open_Parameters parameters,
      Open_Request request,
      out Open_Result result)
    {
      result = (Open_Result) null;
      this.OnBeforeCall(nameof (CreateParametricData), (DCObject) open, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IOpenService) this._Channel).CreateParametricData(this._UserProfile, open, parameters, request, out result) : this.AddMethod((Method) new OpenMethod(open, OpenMethods.CreateParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (CreateParametricData), res, (DCObject) open, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus CreateParametricData()
    {
      return this.CreateParametricData((Open) null, (Open_Parameters) null, (Open_Request) null, out Open_Result _);
    }

    public ResultStatus CreateParametricData(Open open)
    {
      return this.CreateParametricData(open, (Open_Parameters) null, (Open_Request) null, out Open_Result _);
    }

    public ResultStatus CreateParametricData(
      Open open,
      Open_Request request,
      out Open_Result result)
    {
      return this.CreateParametricData(open, (Open_Parameters) null, request, out result);
    }

    public ResultStatus GetActions(
      Open open,
      Open_Parameters parameters,
      Open_Request request,
      out Open_Result result)
    {
      result = (Open_Result) null;
      this.OnBeforeCall(nameof (GetActions), (DCObject) open, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IOpenService) this._Channel).GetActions(this._UserProfile, open, parameters, request, out result) : this.AddMethod((Method) new OpenMethod(open, OpenMethods.GetActions, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetActions), res, (DCObject) open, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetActions()
    {
      return this.GetActions((Open) null, (Open_Parameters) null, (Open_Request) null, out Open_Result _);
    }

    public ResultStatus GetActions(Open open)
    {
      return this.GetActions(open, (Open_Parameters) null, (Open_Request) null, out Open_Result _);
    }

    public ResultStatus GetActions(
      Open open,
      Open_Request request,
      out Open_Result result)
    {
      return this.GetActions(open, (Open_Parameters) null, request, out result);
    }

    public ResultStatus GetDataPoints(
      Open open,
      Open_Parameters parameters,
      Open_Request request,
      out Open_Result result)
    {
      result = (Open_Result) null;
      this.OnBeforeCall(nameof (GetDataPoints), (DCObject) open, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IOpenService) this._Channel).GetDataPoints(this._UserProfile, open, parameters, request, out result) : this.AddMethod((Method) new OpenMethod(open, OpenMethods.GetDataPoints, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetDataPoints), res, (DCObject) open, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetDataPoints()
    {
      return this.GetDataPoints((Open) null, (Open_Parameters) null, (Open_Request) null, out Open_Result _);
    }

    public ResultStatus GetDataPoints(Open open)
    {
      return this.GetDataPoints(open, (Open_Parameters) null, (Open_Request) null, out Open_Result _);
    }

    public ResultStatus GetDataPoints(
      Open open,
      Open_Request request,
      out Open_Result result)
    {
      return this.GetDataPoints(open, (Open_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      Open open,
      Open_Parameters parameters,
      Open_Request request,
      out Open_Result result)
    {
      result = (Open_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) open, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IOpenService) this._Channel).GetWIPMsgs(this._UserProfile, open, parameters, request, out result) : this.AddMethod((Method) new OpenMethod(open, OpenMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) open, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((Open) null, (Open_Parameters) null, (Open_Request) null, out Open_Result _);
    }

    public ResultStatus GetWIPMsgs(Open open)
    {
      return this.GetWIPMsgs(open, (Open_Parameters) null, (Open_Request) null, out Open_Result _);
    }

    public ResultStatus GetWIPMsgs(
      Open open,
      Open_Request request,
      out Open_Result result)
    {
      return this.GetWIPMsgs(open, (Open_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      Open open,
      Open_Parameters parameters,
      Open_Request request,
      out Open_Result result)
    {
      result = (Open_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) open, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IOpenService) this._Channel).Load(this._UserProfile, open, parameters, request, out result) : this.AddMethod((Method) new OpenMethod(open, OpenMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) open, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((Open) null, (Open_Parameters) null, (Open_Request) null, out Open_Result _);
    }

    public ResultStatus Load(Open open)
    {
      return this.Load(open, (Open_Parameters) null, (Open_Request) null, out Open_Result _);
    }

    public ResultStatus Load(Open open, Open_Request request, out Open_Result result)
    {
      return this.Load(open, (Open_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      Open open,
      Open_LoadESigDetails_Parameters parameters,
      Open_Request request,
      out Open_Result result)
    {
      result = (Open_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) open, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IOpenService) this._Channel).LoadESigDetails(this._UserProfile, open, parameters, request, out result) : this.AddMethod((Method) new OpenMethod(open, OpenMethods.LoadESigDetails, (Open_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) open, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((Open) null, (Open_LoadESigDetails_Parameters) null, (Open_Request) null, out Open_Result _);
    }

    public ResultStatus LoadESigDetails(Open open)
    {
      return this.LoadESigDetails(open, (Open_LoadESigDetails_Parameters) null, (Open_Request) null, out Open_Result _);
    }

    public ResultStatus LoadESigDetails(
      Open open,
      Open_Request request,
      out Open_Result result)
    {
      return this.LoadESigDetails(open, (Open_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus ProcessComputation(
      Open open,
      Open_Parameters parameters,
      Open_Request request,
      out Open_Result result)
    {
      result = (Open_Result) null;
      this.OnBeforeCall(nameof (ProcessComputation), (DCObject) open, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IOpenService) this._Channel).ProcessComputation(this._UserProfile, open, parameters, request, out result) : this.AddMethod((Method) new OpenMethod(open, OpenMethods.ProcessComputation, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ProcessComputation), res, (DCObject) open, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ProcessComputation()
    {
      return this.ProcessComputation((Open) null, (Open_Parameters) null, (Open_Request) null, out Open_Result _);
    }

    public ResultStatus ProcessComputation(Open open)
    {
      return this.ProcessComputation(open, (Open_Parameters) null, (Open_Request) null, out Open_Result _);
    }

    public ResultStatus ProcessComputation(
      Open open,
      Open_Request request,
      out Open_Result result)
    {
      return this.ProcessComputation(open, (Open_Parameters) null, request, out result);
    }

    public ResultStatus ResolveParametricData(
      Open open,
      Open_Parameters parameters,
      Open_Request request,
      out Open_Result result)
    {
      result = (Open_Result) null;
      this.OnBeforeCall(nameof (ResolveParametricData), (DCObject) open, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IOpenService) this._Channel).ResolveParametricData(this._UserProfile, open, parameters, request, out result) : this.AddMethod((Method) new OpenMethod(open, OpenMethods.ResolveParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ResolveParametricData), res, (DCObject) open, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ResolveParametricData()
    {
      return this.ResolveParametricData((Open) null, (Open_Parameters) null, (Open_Request) null, out Open_Result _);
    }

    public ResultStatus ResolveParametricData(Open open)
    {
      return this.ResolveParametricData(open, (Open_Parameters) null, (Open_Request) null, out Open_Result _);
    }

    public ResultStatus ResolveParametricData(
      Open open,
      Open_Request request,
      out Open_Result result)
    {
      return this.ResolveParametricData(open, (Open_Parameters) null, request, out result);
    }

    protected override ResultStatus OnCreateParametricData(
      DCObject open,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        Open_Result result1;
        ResultStatus parametricData = this.CreateParametricData((Open) open, (Open_Parameters) parameters, (Open_Request) request, out result1);
        result = (Result) result1;
        return parametricData;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetActions(
      DCObject open,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        Open_Result result1;
        ResultStatus actions = this.GetActions((Open) open, (Open_Parameters) parameters, (Open_Request) request, out result1);
        result = (Result) result1;
        return actions;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetDataPoints(
      DCObject open,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        Open_Result result1;
        ResultStatus dataPoints = this.GetDataPoints((Open) open, (Open_Parameters) parameters, (Open_Request) request, out result1);
        result = (Result) result1;
        return dataPoints;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject open,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        Open_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((Open) open, (Open_LoadESigDetails_Parameters) parameters, (Open_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnProcessComputation(
      DCObject open,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        Open_Result result1;
        ResultStatus resultStatus = this.ProcessComputation((Open) open, (Open_Parameters) parameters, (Open_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnResolveParametricData(
      DCObject open,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        Open_Result result1;
        ResultStatus resultStatus = this.ResolveParametricData((Open) open, (Open_Parameters) parameters, (Open_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject open,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        Open_Result result1;
        ResultStatus resultStatus = this.Load((Open) open, (Open_Parameters) parameters, (Open_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject open,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        Open_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((Open) open, (Open_Parameters) parameters, (Open_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(Open_Request request, out Open_Result result)
    {
      result = (Open_Result) null;
      try
      {
        OpenMethod[] methods = new OpenMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IOpenService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        Open_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((Open_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      Open cdo,
      Open_Request request,
      out Open_Result result)
    {
      result = (Open_Result) null;
      try
      {
        return ((IOpenService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        Open_Result result1;
        ResultStatus environment = this.GetEnvironment((Open) cdo, (Open_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(Open_Request request, out Open_Result result)
    {
      return this.GetEnvironment((Open) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      Open cdo,
      Open_Request request,
      out Open_Result result)
    {
      result = (Open_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IOpenService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new OpenMethod(cdo, OpenMethods.ExecuteTransaction, (Open_Parameters) null));
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
        Open_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((Open) cdo, (Open_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(Open cdo)
    {
      return this.ExecuteTransaction(cdo, (Open_Request) null, out Open_Result _);
    }

    public ResultStatus ExecuteTransaction(Open_Request request, out Open_Result result)
    {
      return this.ExecuteTransaction((Open) null, request, out result);
    }

    public ResultStatus AddDataTransaction(Open cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new OpenMethod(cdo, OpenMethods.AddDataTransaction, (Open_Parameters) null));
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
        return this.AddDataTransaction((Open) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
