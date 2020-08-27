// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.ViewContainerStatusService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class ViewContainerStatusService : ViewContainerBase
  {
    public ViewContainerStatusService(UserProfile userProfile)
    {
      this.Initialize(typeof (IViewContainerStatusService), userProfile);
    }

    public ResultStatus GetWIPMsgs(
      ViewContainerStatus viewContainerStatus,
      ViewContainerStatus_Parameters parameters,
      ViewContainerStatus_Request request,
      out ViewContainerStatus_Result result)
    {
      result = (ViewContainerStatus_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) viewContainerStatus, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IViewContainerStatusService) this._Channel).GetWIPMsgs(this._UserProfile, viewContainerStatus, parameters, request, out result) : this.AddMethod((Method) new ViewContainerStatusMethod(viewContainerStatus, ViewContainerStatusMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) viewContainerStatus, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((ViewContainerStatus) null, (ViewContainerStatus_Parameters) null, (ViewContainerStatus_Request) null, out ViewContainerStatus_Result _);
    }

    public ResultStatus GetWIPMsgs(ViewContainerStatus viewContainerStatus)
    {
      return this.GetWIPMsgs(viewContainerStatus, (ViewContainerStatus_Parameters) null, (ViewContainerStatus_Request) null, out ViewContainerStatus_Result _);
    }

    public ResultStatus GetWIPMsgs(
      ViewContainerStatus viewContainerStatus,
      ViewContainerStatus_Request request,
      out ViewContainerStatus_Result result)
    {
      return this.GetWIPMsgs(viewContainerStatus, (ViewContainerStatus_Parameters) null, request, out result);
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject viewContainerStatus,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ViewContainerStatus_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((ViewContainerStatus) viewContainerStatus, (ViewContainerStatus_Parameters) parameters, (ViewContainerStatus_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      ViewContainerStatus_Request request,
      out ViewContainerStatus_Result result)
    {
      result = (ViewContainerStatus_Result) null;
      try
      {
        ViewContainerStatusMethod[] methods = new ViewContainerStatusMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IViewContainerStatusService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        ViewContainerStatus_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((ViewContainerStatus_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      ViewContainerStatus cdo,
      ViewContainerStatus_Request request,
      out ViewContainerStatus_Result result)
    {
      result = (ViewContainerStatus_Result) null;
      try
      {
        return ((IViewContainerStatusService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        ViewContainerStatus_Result result1;
        ResultStatus environment = this.GetEnvironment((ViewContainerStatus) cdo, (ViewContainerStatus_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      ViewContainerStatus_Request request,
      out ViewContainerStatus_Result result)
    {
      return this.GetEnvironment((ViewContainerStatus) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      ViewContainerStatus cdo,
      ViewContainerStatus_Request request,
      out ViewContainerStatus_Result result)
    {
      result = (ViewContainerStatus_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IViewContainerStatusService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new ViewContainerStatusMethod(cdo, ViewContainerStatusMethods.ExecuteTransaction, (ViewContainerStatus_Parameters) null));
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
        ViewContainerStatus_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((ViewContainerStatus) cdo, (ViewContainerStatus_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(ViewContainerStatus cdo)
    {
      return this.ExecuteTransaction(cdo, (ViewContainerStatus_Request) null, out ViewContainerStatus_Result _);
    }

    public ResultStatus ExecuteTransaction(
      ViewContainerStatus_Request request,
      out ViewContainerStatus_Result result)
    {
      return this.ExecuteTransaction((ViewContainerStatus) null, request, out result);
    }

    public ResultStatus AddDataTransaction(ViewContainerStatus cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new ViewContainerStatusMethod(cdo, ViewContainerStatusMethods.AddDataTransaction, (ViewContainerStatus_Parameters) null));
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
        return this.AddDataTransaction((ViewContainerStatus) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
