// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.AssignSingleCPContentService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class AssignSingleCPContentService : AssignChangePkgContentBase
  {
    public AssignSingleCPContentService(UserProfile userProfile)
    {
      this.Initialize(typeof (IAssignSingleCPContentService), userProfile);
    }

    public ResultStatus CreateParametricData(
      AssignSingleCPContent assignSingleCPContent,
      AssignSingleCPContent_Parameters parameters,
      AssignSingleCPContent_Request request,
      out AssignSingleCPContent_Result result)
    {
      result = (AssignSingleCPContent_Result) null;
      this.OnBeforeCall(nameof (CreateParametricData), (DCObject) assignSingleCPContent, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IAssignSingleCPContentService) this._Channel).CreateParametricData(this._UserProfile, assignSingleCPContent, parameters, request, out result) : this.AddMethod((Method) new AssignSingleCPContentMethod(assignSingleCPContent, AssignSingleCPContentMethods.CreateParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (CreateParametricData), res, (DCObject) assignSingleCPContent, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus CreateParametricData()
    {
      return this.CreateParametricData((AssignSingleCPContent) null, (AssignSingleCPContent_Parameters) null, (AssignSingleCPContent_Request) null, out AssignSingleCPContent_Result _);
    }

    public ResultStatus CreateParametricData(AssignSingleCPContent assignSingleCPContent)
    {
      return this.CreateParametricData(assignSingleCPContent, (AssignSingleCPContent_Parameters) null, (AssignSingleCPContent_Request) null, out AssignSingleCPContent_Result _);
    }

    public ResultStatus CreateParametricData(
      AssignSingleCPContent assignSingleCPContent,
      AssignSingleCPContent_Request request,
      out AssignSingleCPContent_Result result)
    {
      return this.CreateParametricData(assignSingleCPContent, (AssignSingleCPContent_Parameters) null, request, out result);
    }

    public ResultStatus GetActions(
      AssignSingleCPContent assignSingleCPContent,
      AssignSingleCPContent_Parameters parameters,
      AssignSingleCPContent_Request request,
      out AssignSingleCPContent_Result result)
    {
      result = (AssignSingleCPContent_Result) null;
      this.OnBeforeCall(nameof (GetActions), (DCObject) assignSingleCPContent, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IAssignSingleCPContentService) this._Channel).GetActions(this._UserProfile, assignSingleCPContent, parameters, request, out result) : this.AddMethod((Method) new AssignSingleCPContentMethod(assignSingleCPContent, AssignSingleCPContentMethods.GetActions, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetActions), res, (DCObject) assignSingleCPContent, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetActions()
    {
      return this.GetActions((AssignSingleCPContent) null, (AssignSingleCPContent_Parameters) null, (AssignSingleCPContent_Request) null, out AssignSingleCPContent_Result _);
    }

    public ResultStatus GetActions(AssignSingleCPContent assignSingleCPContent)
    {
      return this.GetActions(assignSingleCPContent, (AssignSingleCPContent_Parameters) null, (AssignSingleCPContent_Request) null, out AssignSingleCPContent_Result _);
    }

    public ResultStatus GetActions(
      AssignSingleCPContent assignSingleCPContent,
      AssignSingleCPContent_Request request,
      out AssignSingleCPContent_Result result)
    {
      return this.GetActions(assignSingleCPContent, (AssignSingleCPContent_Parameters) null, request, out result);
    }

    public ResultStatus GetDataPoints(
      AssignSingleCPContent assignSingleCPContent,
      AssignSingleCPContent_Parameters parameters,
      AssignSingleCPContent_Request request,
      out AssignSingleCPContent_Result result)
    {
      result = (AssignSingleCPContent_Result) null;
      this.OnBeforeCall(nameof (GetDataPoints), (DCObject) assignSingleCPContent, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IAssignSingleCPContentService) this._Channel).GetDataPoints(this._UserProfile, assignSingleCPContent, parameters, request, out result) : this.AddMethod((Method) new AssignSingleCPContentMethod(assignSingleCPContent, AssignSingleCPContentMethods.GetDataPoints, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetDataPoints), res, (DCObject) assignSingleCPContent, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetDataPoints()
    {
      return this.GetDataPoints((AssignSingleCPContent) null, (AssignSingleCPContent_Parameters) null, (AssignSingleCPContent_Request) null, out AssignSingleCPContent_Result _);
    }

    public ResultStatus GetDataPoints(AssignSingleCPContent assignSingleCPContent)
    {
      return this.GetDataPoints(assignSingleCPContent, (AssignSingleCPContent_Parameters) null, (AssignSingleCPContent_Request) null, out AssignSingleCPContent_Result _);
    }

    public ResultStatus GetDataPoints(
      AssignSingleCPContent assignSingleCPContent,
      AssignSingleCPContent_Request request,
      out AssignSingleCPContent_Result result)
    {
      return this.GetDataPoints(assignSingleCPContent, (AssignSingleCPContent_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      AssignSingleCPContent assignSingleCPContent,
      AssignSingleCPContent_Parameters parameters,
      AssignSingleCPContent_Request request,
      out AssignSingleCPContent_Result result)
    {
      result = (AssignSingleCPContent_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) assignSingleCPContent, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IAssignSingleCPContentService) this._Channel).GetWIPMsgs(this._UserProfile, assignSingleCPContent, parameters, request, out result) : this.AddMethod((Method) new AssignSingleCPContentMethod(assignSingleCPContent, AssignSingleCPContentMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) assignSingleCPContent, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((AssignSingleCPContent) null, (AssignSingleCPContent_Parameters) null, (AssignSingleCPContent_Request) null, out AssignSingleCPContent_Result _);
    }

    public ResultStatus GetWIPMsgs(AssignSingleCPContent assignSingleCPContent)
    {
      return this.GetWIPMsgs(assignSingleCPContent, (AssignSingleCPContent_Parameters) null, (AssignSingleCPContent_Request) null, out AssignSingleCPContent_Result _);
    }

    public ResultStatus GetWIPMsgs(
      AssignSingleCPContent assignSingleCPContent,
      AssignSingleCPContent_Request request,
      out AssignSingleCPContent_Result result)
    {
      return this.GetWIPMsgs(assignSingleCPContent, (AssignSingleCPContent_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      AssignSingleCPContent assignSingleCPContent,
      AssignSingleCPContent_Parameters parameters,
      AssignSingleCPContent_Request request,
      out AssignSingleCPContent_Result result)
    {
      result = (AssignSingleCPContent_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) assignSingleCPContent, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IAssignSingleCPContentService) this._Channel).Load(this._UserProfile, assignSingleCPContent, parameters, request, out result) : this.AddMethod((Method) new AssignSingleCPContentMethod(assignSingleCPContent, AssignSingleCPContentMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) assignSingleCPContent, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((AssignSingleCPContent) null, (AssignSingleCPContent_Parameters) null, (AssignSingleCPContent_Request) null, out AssignSingleCPContent_Result _);
    }

    public ResultStatus Load(AssignSingleCPContent assignSingleCPContent)
    {
      return this.Load(assignSingleCPContent, (AssignSingleCPContent_Parameters) null, (AssignSingleCPContent_Request) null, out AssignSingleCPContent_Result _);
    }

    public ResultStatus Load(
      AssignSingleCPContent assignSingleCPContent,
      AssignSingleCPContent_Request request,
      out AssignSingleCPContent_Result result)
    {
      return this.Load(assignSingleCPContent, (AssignSingleCPContent_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      AssignSingleCPContent assignSingleCPContent,
      AssignSingleCPContent_LoadESigDetails_Parameters parameters,
      AssignSingleCPContent_Request request,
      out AssignSingleCPContent_Result result)
    {
      result = (AssignSingleCPContent_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) assignSingleCPContent, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IAssignSingleCPContentService) this._Channel).LoadESigDetails(this._UserProfile, assignSingleCPContent, parameters, request, out result) : this.AddMethod((Method) new AssignSingleCPContentMethod(assignSingleCPContent, AssignSingleCPContentMethods.LoadESigDetails, (AssignSingleCPContent_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) assignSingleCPContent, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((AssignSingleCPContent) null, (AssignSingleCPContent_LoadESigDetails_Parameters) null, (AssignSingleCPContent_Request) null, out AssignSingleCPContent_Result _);
    }

    public ResultStatus LoadESigDetails(AssignSingleCPContent assignSingleCPContent)
    {
      return this.LoadESigDetails(assignSingleCPContent, (AssignSingleCPContent_LoadESigDetails_Parameters) null, (AssignSingleCPContent_Request) null, out AssignSingleCPContent_Result _);
    }

    public ResultStatus LoadESigDetails(
      AssignSingleCPContent assignSingleCPContent,
      AssignSingleCPContent_Request request,
      out AssignSingleCPContent_Result result)
    {
      return this.LoadESigDetails(assignSingleCPContent, (AssignSingleCPContent_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus ProcessComputation(
      AssignSingleCPContent assignSingleCPContent,
      AssignSingleCPContent_Parameters parameters,
      AssignSingleCPContent_Request request,
      out AssignSingleCPContent_Result result)
    {
      result = (AssignSingleCPContent_Result) null;
      this.OnBeforeCall(nameof (ProcessComputation), (DCObject) assignSingleCPContent, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IAssignSingleCPContentService) this._Channel).ProcessComputation(this._UserProfile, assignSingleCPContent, parameters, request, out result) : this.AddMethod((Method) new AssignSingleCPContentMethod(assignSingleCPContent, AssignSingleCPContentMethods.ProcessComputation, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ProcessComputation), res, (DCObject) assignSingleCPContent, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ProcessComputation()
    {
      return this.ProcessComputation((AssignSingleCPContent) null, (AssignSingleCPContent_Parameters) null, (AssignSingleCPContent_Request) null, out AssignSingleCPContent_Result _);
    }

    public ResultStatus ProcessComputation(AssignSingleCPContent assignSingleCPContent)
    {
      return this.ProcessComputation(assignSingleCPContent, (AssignSingleCPContent_Parameters) null, (AssignSingleCPContent_Request) null, out AssignSingleCPContent_Result _);
    }

    public ResultStatus ProcessComputation(
      AssignSingleCPContent assignSingleCPContent,
      AssignSingleCPContent_Request request,
      out AssignSingleCPContent_Result result)
    {
      return this.ProcessComputation(assignSingleCPContent, (AssignSingleCPContent_Parameters) null, request, out result);
    }

    public ResultStatus ResolveParametricData(
      AssignSingleCPContent assignSingleCPContent,
      AssignSingleCPContent_Parameters parameters,
      AssignSingleCPContent_Request request,
      out AssignSingleCPContent_Result result)
    {
      result = (AssignSingleCPContent_Result) null;
      this.OnBeforeCall(nameof (ResolveParametricData), (DCObject) assignSingleCPContent, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IAssignSingleCPContentService) this._Channel).ResolveParametricData(this._UserProfile, assignSingleCPContent, parameters, request, out result) : this.AddMethod((Method) new AssignSingleCPContentMethod(assignSingleCPContent, AssignSingleCPContentMethods.ResolveParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ResolveParametricData), res, (DCObject) assignSingleCPContent, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ResolveParametricData()
    {
      return this.ResolveParametricData((AssignSingleCPContent) null, (AssignSingleCPContent_Parameters) null, (AssignSingleCPContent_Request) null, out AssignSingleCPContent_Result _);
    }

    public ResultStatus ResolveParametricData(
      AssignSingleCPContent assignSingleCPContent)
    {
      return this.ResolveParametricData(assignSingleCPContent, (AssignSingleCPContent_Parameters) null, (AssignSingleCPContent_Request) null, out AssignSingleCPContent_Result _);
    }

    public ResultStatus ResolveParametricData(
      AssignSingleCPContent assignSingleCPContent,
      AssignSingleCPContent_Request request,
      out AssignSingleCPContent_Result result)
    {
      return this.ResolveParametricData(assignSingleCPContent, (AssignSingleCPContent_Parameters) null, request, out result);
    }

    protected override ResultStatus OnCreateParametricData(
      DCObject assignSingleCPContent,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        AssignSingleCPContent_Result result1;
        ResultStatus parametricData = this.CreateParametricData((AssignSingleCPContent) assignSingleCPContent, (AssignSingleCPContent_Parameters) parameters, (AssignSingleCPContent_Request) request, out result1);
        result = (Result) result1;
        return parametricData;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetActions(
      DCObject assignSingleCPContent,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        AssignSingleCPContent_Result result1;
        ResultStatus actions = this.GetActions((AssignSingleCPContent) assignSingleCPContent, (AssignSingleCPContent_Parameters) parameters, (AssignSingleCPContent_Request) request, out result1);
        result = (Result) result1;
        return actions;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetDataPoints(
      DCObject assignSingleCPContent,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        AssignSingleCPContent_Result result1;
        ResultStatus dataPoints = this.GetDataPoints((AssignSingleCPContent) assignSingleCPContent, (AssignSingleCPContent_Parameters) parameters, (AssignSingleCPContent_Request) request, out result1);
        result = (Result) result1;
        return dataPoints;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject assignSingleCPContent,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        AssignSingleCPContent_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((AssignSingleCPContent) assignSingleCPContent, (AssignSingleCPContent_LoadESigDetails_Parameters) parameters, (AssignSingleCPContent_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnProcessComputation(
      DCObject assignSingleCPContent,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        AssignSingleCPContent_Result result1;
        ResultStatus resultStatus = this.ProcessComputation((AssignSingleCPContent) assignSingleCPContent, (AssignSingleCPContent_Parameters) parameters, (AssignSingleCPContent_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnResolveParametricData(
      DCObject assignSingleCPContent,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        AssignSingleCPContent_Result result1;
        ResultStatus resultStatus = this.ResolveParametricData((AssignSingleCPContent) assignSingleCPContent, (AssignSingleCPContent_Parameters) parameters, (AssignSingleCPContent_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject assignSingleCPContent,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        AssignSingleCPContent_Result result1;
        ResultStatus resultStatus = this.Load((AssignSingleCPContent) assignSingleCPContent, (AssignSingleCPContent_Parameters) parameters, (AssignSingleCPContent_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject assignSingleCPContent,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        AssignSingleCPContent_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((AssignSingleCPContent) assignSingleCPContent, (AssignSingleCPContent_Parameters) parameters, (AssignSingleCPContent_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      AssignSingleCPContent_Request request,
      out AssignSingleCPContent_Result result)
    {
      result = (AssignSingleCPContent_Result) null;
      try
      {
        AssignSingleCPContentMethod[] methods = new AssignSingleCPContentMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IAssignSingleCPContentService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        AssignSingleCPContent_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((AssignSingleCPContent_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      AssignSingleCPContent cdo,
      AssignSingleCPContent_Request request,
      out AssignSingleCPContent_Result result)
    {
      result = (AssignSingleCPContent_Result) null;
      try
      {
        return ((IAssignSingleCPContentService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        AssignSingleCPContent_Result result1;
        ResultStatus environment = this.GetEnvironment((AssignSingleCPContent) cdo, (AssignSingleCPContent_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      AssignSingleCPContent_Request request,
      out AssignSingleCPContent_Result result)
    {
      return this.GetEnvironment((AssignSingleCPContent) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      AssignSingleCPContent cdo,
      AssignSingleCPContent_Request request,
      out AssignSingleCPContent_Result result)
    {
      result = (AssignSingleCPContent_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IAssignSingleCPContentService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new AssignSingleCPContentMethod(cdo, AssignSingleCPContentMethods.ExecuteTransaction, (AssignSingleCPContent_Parameters) null));
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
        AssignSingleCPContent_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((AssignSingleCPContent) cdo, (AssignSingleCPContent_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(AssignSingleCPContent cdo)
    {
      return this.ExecuteTransaction(cdo, (AssignSingleCPContent_Request) null, out AssignSingleCPContent_Result _);
    }

    public ResultStatus ExecuteTransaction(
      AssignSingleCPContent_Request request,
      out AssignSingleCPContent_Result result)
    {
      return this.ExecuteTransaction((AssignSingleCPContent) null, request, out result);
    }

    public ResultStatus AddDataTransaction(AssignSingleCPContent cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new AssignSingleCPContentMethod(cdo, AssignSingleCPContentMethods.AddDataTransaction, (AssignSingleCPContent_Parameters) null));
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
        return this.AddDataTransaction((AssignSingleCPContent) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
