// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.ViewContainerService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class ViewContainerService : InquiryBase
  {
    public ViewContainerService(UserProfile userProfile)
    {
      this.Initialize(typeof (IViewContainerService), userProfile);
    }

    public ResultStatus GetWIPMsgs(
      ViewContainer viewContainer,
      ViewContainer_Parameters parameters,
      ViewContainer_Request request,
      out ViewContainer_Result result)
    {
      result = (ViewContainer_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) viewContainer, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IViewContainerService) this._Channel).GetWIPMsgs(this._UserProfile, viewContainer, parameters, request, out result) : this.AddMethod((Method) new ViewContainerMethod(viewContainer, ViewContainerMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) viewContainer, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((ViewContainer) null, (ViewContainer_Parameters) null, (ViewContainer_Request) null, out ViewContainer_Result _);
    }

    public ResultStatus GetWIPMsgs(ViewContainer viewContainer)
    {
      return this.GetWIPMsgs(viewContainer, (ViewContainer_Parameters) null, (ViewContainer_Request) null, out ViewContainer_Result _);
    }

    public ResultStatus GetWIPMsgs(
      ViewContainer viewContainer,
      ViewContainer_Request request,
      out ViewContainer_Result result)
    {
      return this.GetWIPMsgs(viewContainer, (ViewContainer_Parameters) null, request, out result);
    }

    public ResultStatus ValidateUserPermission(
      ViewContainer viewContainer,
      ViewContainer_Parameters parameters,
      ViewContainer_Request request,
      out ViewContainer_Result result)
    {
      result = (ViewContainer_Result) null;
      this.OnBeforeCall(nameof (ValidateUserPermission), (DCObject) viewContainer, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IViewContainerService) this._Channel).ValidateUserPermission(this._UserProfile, viewContainer, parameters, request, out result) : this.AddMethod((Method) new ViewContainerMethod(viewContainer, ViewContainerMethods.ValidateUserPermission, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ValidateUserPermission), res, (DCObject) viewContainer, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ValidateUserPermission()
    {
      return this.ValidateUserPermission((ViewContainer) null, (ViewContainer_Parameters) null, (ViewContainer_Request) null, out ViewContainer_Result _);
    }

    public ResultStatus ValidateUserPermission(ViewContainer viewContainer)
    {
      return this.ValidateUserPermission(viewContainer, (ViewContainer_Parameters) null, (ViewContainer_Request) null, out ViewContainer_Result _);
    }

    public ResultStatus ValidateUserPermission(
      ViewContainer viewContainer,
      ViewContainer_Request request,
      out ViewContainer_Result result)
    {
      return this.ValidateUserPermission(viewContainer, (ViewContainer_Parameters) null, request, out result);
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject viewContainer,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ViewContainer_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((ViewContainer) viewContainer, (ViewContainer_Parameters) parameters, (ViewContainer_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      ViewContainer_Request request,
      out ViewContainer_Result result)
    {
      result = (ViewContainer_Result) null;
      try
      {
        ViewContainerMethod[] methods = new ViewContainerMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IViewContainerService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        ViewContainer_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((ViewContainer_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      ViewContainer cdo,
      ViewContainer_Request request,
      out ViewContainer_Result result)
    {
      result = (ViewContainer_Result) null;
      try
      {
        return ((IViewContainerService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        ViewContainer_Result result1;
        ResultStatus environment = this.GetEnvironment((ViewContainer) cdo, (ViewContainer_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      ViewContainer_Request request,
      out ViewContainer_Result result)
    {
      return this.GetEnvironment((ViewContainer) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      ViewContainer cdo,
      ViewContainer_Request request,
      out ViewContainer_Result result)
    {
      result = (ViewContainer_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IViewContainerService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new ViewContainerMethod(cdo, ViewContainerMethods.ExecuteTransaction, (ViewContainer_Parameters) null));
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
        ViewContainer_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((ViewContainer) cdo, (ViewContainer_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(ViewContainer cdo)
    {
      return this.ExecuteTransaction(cdo, (ViewContainer_Request) null, out ViewContainer_Result _);
    }

    public ResultStatus ExecuteTransaction(
      ViewContainer_Request request,
      out ViewContainer_Result result)
    {
      return this.ExecuteTransaction((ViewContainer) null, request, out result);
    }

    public ResultStatus AddDataTransaction(ViewContainer cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new ViewContainerMethod(cdo, ViewContainerMethods.AddDataTransaction, (ViewContainer_Parameters) null));
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
        return this.AddDataTransaction((ViewContainer) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
