// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.GroupStartService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class GroupStartService : StartBase
  {
    public GroupStartService(UserProfile userProfile)
    {
      this.Initialize(typeof (IGroupStartService), userProfile);
    }

    public ResultStatus CreateParametricData(
      GroupStart groupStart,
      GroupStart_Parameters parameters,
      GroupStart_Request request,
      out GroupStart_Result result)
    {
      result = (GroupStart_Result) null;
      this.OnBeforeCall(nameof (CreateParametricData), (DCObject) groupStart, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IGroupStartService) this._Channel).CreateParametricData(this._UserProfile, groupStart, parameters, request, out result) : this.AddMethod((Method) new GroupStartMethod(groupStart, GroupStartMethods.CreateParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (CreateParametricData), res, (DCObject) groupStart, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus CreateParametricData()
    {
      return this.CreateParametricData((GroupStart) null, (GroupStart_Parameters) null, (GroupStart_Request) null, out GroupStart_Result _);
    }

    public ResultStatus CreateParametricData(GroupStart groupStart)
    {
      return this.CreateParametricData(groupStart, (GroupStart_Parameters) null, (GroupStart_Request) null, out GroupStart_Result _);
    }

    public ResultStatus CreateParametricData(
      GroupStart groupStart,
      GroupStart_Request request,
      out GroupStart_Result result)
    {
      return this.CreateParametricData(groupStart, (GroupStart_Parameters) null, request, out result);
    }

    public ResultStatus GetActions(
      GroupStart groupStart,
      GroupStart_Parameters parameters,
      GroupStart_Request request,
      out GroupStart_Result result)
    {
      result = (GroupStart_Result) null;
      this.OnBeforeCall(nameof (GetActions), (DCObject) groupStart, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IGroupStartService) this._Channel).GetActions(this._UserProfile, groupStart, parameters, request, out result) : this.AddMethod((Method) new GroupStartMethod(groupStart, GroupStartMethods.GetActions, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetActions), res, (DCObject) groupStart, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetActions()
    {
      return this.GetActions((GroupStart) null, (GroupStart_Parameters) null, (GroupStart_Request) null, out GroupStart_Result _);
    }

    public ResultStatus GetActions(GroupStart groupStart)
    {
      return this.GetActions(groupStart, (GroupStart_Parameters) null, (GroupStart_Request) null, out GroupStart_Result _);
    }

    public ResultStatus GetActions(
      GroupStart groupStart,
      GroupStart_Request request,
      out GroupStart_Result result)
    {
      return this.GetActions(groupStart, (GroupStart_Parameters) null, request, out result);
    }

    public ResultStatus GetDataPoints(
      GroupStart groupStart,
      GroupStart_Parameters parameters,
      GroupStart_Request request,
      out GroupStart_Result result)
    {
      result = (GroupStart_Result) null;
      this.OnBeforeCall(nameof (GetDataPoints), (DCObject) groupStart, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IGroupStartService) this._Channel).GetDataPoints(this._UserProfile, groupStart, parameters, request, out result) : this.AddMethod((Method) new GroupStartMethod(groupStart, GroupStartMethods.GetDataPoints, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetDataPoints), res, (DCObject) groupStart, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetDataPoints()
    {
      return this.GetDataPoints((GroupStart) null, (GroupStart_Parameters) null, (GroupStart_Request) null, out GroupStart_Result _);
    }

    public ResultStatus GetDataPoints(GroupStart groupStart)
    {
      return this.GetDataPoints(groupStart, (GroupStart_Parameters) null, (GroupStart_Request) null, out GroupStart_Result _);
    }

    public ResultStatus GetDataPoints(
      GroupStart groupStart,
      GroupStart_Request request,
      out GroupStart_Result result)
    {
      return this.GetDataPoints(groupStart, (GroupStart_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      GroupStart groupStart,
      GroupStart_Parameters parameters,
      GroupStart_Request request,
      out GroupStart_Result result)
    {
      result = (GroupStart_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) groupStart, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IGroupStartService) this._Channel).GetWIPMsgs(this._UserProfile, groupStart, parameters, request, out result) : this.AddMethod((Method) new GroupStartMethod(groupStart, GroupStartMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) groupStart, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((GroupStart) null, (GroupStart_Parameters) null, (GroupStart_Request) null, out GroupStart_Result _);
    }

    public ResultStatus GetWIPMsgs(GroupStart groupStart)
    {
      return this.GetWIPMsgs(groupStart, (GroupStart_Parameters) null, (GroupStart_Request) null, out GroupStart_Result _);
    }

    public ResultStatus GetWIPMsgs(
      GroupStart groupStart,
      GroupStart_Request request,
      out GroupStart_Result result)
    {
      return this.GetWIPMsgs(groupStart, (GroupStart_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      GroupStart groupStart,
      GroupStart_Parameters parameters,
      GroupStart_Request request,
      out GroupStart_Result result)
    {
      result = (GroupStart_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) groupStart, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IGroupStartService) this._Channel).Load(this._UserProfile, groupStart, parameters, request, out result) : this.AddMethod((Method) new GroupStartMethod(groupStart, GroupStartMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) groupStart, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((GroupStart) null, (GroupStart_Parameters) null, (GroupStart_Request) null, out GroupStart_Result _);
    }

    public ResultStatus Load(GroupStart groupStart)
    {
      return this.Load(groupStart, (GroupStart_Parameters) null, (GroupStart_Request) null, out GroupStart_Result _);
    }

    public ResultStatus Load(
      GroupStart groupStart,
      GroupStart_Request request,
      out GroupStart_Result result)
    {
      return this.Load(groupStart, (GroupStart_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      GroupStart groupStart,
      GroupStart_LoadESigDetails_Parameters parameters,
      GroupStart_Request request,
      out GroupStart_Result result)
    {
      result = (GroupStart_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) groupStart, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IGroupStartService) this._Channel).LoadESigDetails(this._UserProfile, groupStart, parameters, request, out result) : this.AddMethod((Method) new GroupStartMethod(groupStart, GroupStartMethods.LoadESigDetails, (GroupStart_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) groupStart, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((GroupStart) null, (GroupStart_LoadESigDetails_Parameters) null, (GroupStart_Request) null, out GroupStart_Result _);
    }

    public ResultStatus LoadESigDetails(GroupStart groupStart)
    {
      return this.LoadESigDetails(groupStart, (GroupStart_LoadESigDetails_Parameters) null, (GroupStart_Request) null, out GroupStart_Result _);
    }

    public ResultStatus LoadESigDetails(
      GroupStart groupStart,
      GroupStart_Request request,
      out GroupStart_Result result)
    {
      return this.LoadESigDetails(groupStart, (GroupStart_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus ProcessComputation(
      GroupStart groupStart,
      GroupStart_Parameters parameters,
      GroupStart_Request request,
      out GroupStart_Result result)
    {
      result = (GroupStart_Result) null;
      this.OnBeforeCall(nameof (ProcessComputation), (DCObject) groupStart, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IGroupStartService) this._Channel).ProcessComputation(this._UserProfile, groupStart, parameters, request, out result) : this.AddMethod((Method) new GroupStartMethod(groupStart, GroupStartMethods.ProcessComputation, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ProcessComputation), res, (DCObject) groupStart, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ProcessComputation()
    {
      return this.ProcessComputation((GroupStart) null, (GroupStart_Parameters) null, (GroupStart_Request) null, out GroupStart_Result _);
    }

    public ResultStatus ProcessComputation(GroupStart groupStart)
    {
      return this.ProcessComputation(groupStart, (GroupStart_Parameters) null, (GroupStart_Request) null, out GroupStart_Result _);
    }

    public ResultStatus ProcessComputation(
      GroupStart groupStart,
      GroupStart_Request request,
      out GroupStart_Result result)
    {
      return this.ProcessComputation(groupStart, (GroupStart_Parameters) null, request, out result);
    }

    public ResultStatus ResolveParametricData(
      GroupStart groupStart,
      GroupStart_Parameters parameters,
      GroupStart_Request request,
      out GroupStart_Result result)
    {
      result = (GroupStart_Result) null;
      this.OnBeforeCall(nameof (ResolveParametricData), (DCObject) groupStart, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IGroupStartService) this._Channel).ResolveParametricData(this._UserProfile, groupStart, parameters, request, out result) : this.AddMethod((Method) new GroupStartMethod(groupStart, GroupStartMethods.ResolveParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ResolveParametricData), res, (DCObject) groupStart, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ResolveParametricData()
    {
      return this.ResolveParametricData((GroupStart) null, (GroupStart_Parameters) null, (GroupStart_Request) null, out GroupStart_Result _);
    }

    public ResultStatus ResolveParametricData(GroupStart groupStart)
    {
      return this.ResolveParametricData(groupStart, (GroupStart_Parameters) null, (GroupStart_Request) null, out GroupStart_Result _);
    }

    public ResultStatus ResolveParametricData(
      GroupStart groupStart,
      GroupStart_Request request,
      out GroupStart_Result result)
    {
      return this.ResolveParametricData(groupStart, (GroupStart_Parameters) null, request, out result);
    }

    protected override ResultStatus OnCreateParametricData(
      DCObject groupStart,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        GroupStart_Result result1;
        ResultStatus parametricData = this.CreateParametricData((GroupStart) groupStart, (GroupStart_Parameters) parameters, (GroupStart_Request) request, out result1);
        result = (Result) result1;
        return parametricData;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetActions(
      DCObject groupStart,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        GroupStart_Result result1;
        ResultStatus actions = this.GetActions((GroupStart) groupStart, (GroupStart_Parameters) parameters, (GroupStart_Request) request, out result1);
        result = (Result) result1;
        return actions;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetDataPoints(
      DCObject groupStart,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        GroupStart_Result result1;
        ResultStatus dataPoints = this.GetDataPoints((GroupStart) groupStart, (GroupStart_Parameters) parameters, (GroupStart_Request) request, out result1);
        result = (Result) result1;
        return dataPoints;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject groupStart,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        GroupStart_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((GroupStart) groupStart, (GroupStart_LoadESigDetails_Parameters) parameters, (GroupStart_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnProcessComputation(
      DCObject groupStart,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        GroupStart_Result result1;
        ResultStatus resultStatus = this.ProcessComputation((GroupStart) groupStart, (GroupStart_Parameters) parameters, (GroupStart_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnResolveParametricData(
      DCObject groupStart,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        GroupStart_Result result1;
        ResultStatus resultStatus = this.ResolveParametricData((GroupStart) groupStart, (GroupStart_Parameters) parameters, (GroupStart_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject groupStart,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        GroupStart_Result result1;
        ResultStatus resultStatus = this.Load((GroupStart) groupStart, (GroupStart_Parameters) parameters, (GroupStart_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject groupStart,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        GroupStart_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((GroupStart) groupStart, (GroupStart_Parameters) parameters, (GroupStart_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      GroupStart_Request request,
      out GroupStart_Result result)
    {
      result = (GroupStart_Result) null;
      try
      {
        GroupStartMethod[] methods = new GroupStartMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IGroupStartService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        GroupStart_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((GroupStart_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      GroupStart cdo,
      GroupStart_Request request,
      out GroupStart_Result result)
    {
      result = (GroupStart_Result) null;
      try
      {
        return ((IGroupStartService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        GroupStart_Result result1;
        ResultStatus environment = this.GetEnvironment((GroupStart) cdo, (GroupStart_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      GroupStart_Request request,
      out GroupStart_Result result)
    {
      return this.GetEnvironment((GroupStart) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      GroupStart cdo,
      GroupStart_Request request,
      out GroupStart_Result result)
    {
      result = (GroupStart_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IGroupStartService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new GroupStartMethod(cdo, GroupStartMethods.ExecuteTransaction, (GroupStart_Parameters) null));
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
        GroupStart_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((GroupStart) cdo, (GroupStart_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(GroupStart cdo)
    {
      return this.ExecuteTransaction(cdo, (GroupStart_Request) null, out GroupStart_Result _);
    }

    public ResultStatus ExecuteTransaction(
      GroupStart_Request request,
      out GroupStart_Result result)
    {
      return this.ExecuteTransaction((GroupStart) null, request, out result);
    }

    public ResultStatus AddDataTransaction(GroupStart cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new GroupStartMethod(cdo, GroupStartMethods.AddDataTransaction, (GroupStart_Parameters) null));
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
        return this.AddDataTransaction((GroupStart) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
