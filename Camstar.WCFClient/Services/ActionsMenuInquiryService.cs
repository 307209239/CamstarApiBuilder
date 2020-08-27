// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.ActionsMenuInquiryService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class ActionsMenuInquiryService : InquiryBase
  {
    public ActionsMenuInquiryService(UserProfile userProfile)
    {
      this.Initialize(typeof (IActionsMenuInquiryService), userProfile);
    }

    public ResultStatus GetActionsMenuDetails(
      ActionsMenuInquiry actionsMenuInquiry,
      ActionsMenuInquiry_Parameters parameters,
      ActionsMenuInquiry_Request request,
      out ActionsMenuInquiry_Result result)
    {
      result = (ActionsMenuInquiry_Result) null;
      this.OnBeforeCall(nameof (GetActionsMenuDetails), (DCObject) actionsMenuInquiry, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IActionsMenuInquiryService) this._Channel).GetActionsMenuDetails(this._UserProfile, actionsMenuInquiry, parameters, request, out result) : this.AddMethod((Method) new ActionsMenuInquiryMethod(actionsMenuInquiry, ActionsMenuInquiryMethods.GetActionsMenuDetails, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetActionsMenuDetails), res, (DCObject) actionsMenuInquiry, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetActionsMenuDetails()
    {
      return this.GetActionsMenuDetails((ActionsMenuInquiry) null, (ActionsMenuInquiry_Parameters) null, (ActionsMenuInquiry_Request) null, out ActionsMenuInquiry_Result _);
    }

    public ResultStatus GetActionsMenuDetails(ActionsMenuInquiry actionsMenuInquiry)
    {
      return this.GetActionsMenuDetails(actionsMenuInquiry, (ActionsMenuInquiry_Parameters) null, (ActionsMenuInquiry_Request) null, out ActionsMenuInquiry_Result _);
    }

    public ResultStatus GetActionsMenuDetails(
      ActionsMenuInquiry actionsMenuInquiry,
      ActionsMenuInquiry_Request request,
      out ActionsMenuInquiry_Result result)
    {
      return this.GetActionsMenuDetails(actionsMenuInquiry, (ActionsMenuInquiry_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      ActionsMenuInquiry actionsMenuInquiry,
      ActionsMenuInquiry_Parameters parameters,
      ActionsMenuInquiry_Request request,
      out ActionsMenuInquiry_Result result)
    {
      result = (ActionsMenuInquiry_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) actionsMenuInquiry, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IActionsMenuInquiryService) this._Channel).GetWIPMsgs(this._UserProfile, actionsMenuInquiry, parameters, request, out result) : this.AddMethod((Method) new ActionsMenuInquiryMethod(actionsMenuInquiry, ActionsMenuInquiryMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) actionsMenuInquiry, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((ActionsMenuInquiry) null, (ActionsMenuInquiry_Parameters) null, (ActionsMenuInquiry_Request) null, out ActionsMenuInquiry_Result _);
    }

    public ResultStatus GetWIPMsgs(ActionsMenuInquiry actionsMenuInquiry)
    {
      return this.GetWIPMsgs(actionsMenuInquiry, (ActionsMenuInquiry_Parameters) null, (ActionsMenuInquiry_Request) null, out ActionsMenuInquiry_Result _);
    }

    public ResultStatus GetWIPMsgs(
      ActionsMenuInquiry actionsMenuInquiry,
      ActionsMenuInquiry_Request request,
      out ActionsMenuInquiry_Result result)
    {
      return this.GetWIPMsgs(actionsMenuInquiry, (ActionsMenuInquiry_Parameters) null, request, out result);
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject actionsMenuInquiry,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ActionsMenuInquiry_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((ActionsMenuInquiry) actionsMenuInquiry, (ActionsMenuInquiry_Parameters) parameters, (ActionsMenuInquiry_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      ActionsMenuInquiry_Request request,
      out ActionsMenuInquiry_Result result)
    {
      result = (ActionsMenuInquiry_Result) null;
      try
      {
        ActionsMenuInquiryMethod[] methods = new ActionsMenuInquiryMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IActionsMenuInquiryService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        ActionsMenuInquiry_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((ActionsMenuInquiry_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      ActionsMenuInquiry cdo,
      ActionsMenuInquiry_Request request,
      out ActionsMenuInquiry_Result result)
    {
      result = (ActionsMenuInquiry_Result) null;
      try
      {
        return ((IActionsMenuInquiryService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        ActionsMenuInquiry_Result result1;
        ResultStatus environment = this.GetEnvironment((ActionsMenuInquiry) cdo, (ActionsMenuInquiry_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      ActionsMenuInquiry_Request request,
      out ActionsMenuInquiry_Result result)
    {
      return this.GetEnvironment((ActionsMenuInquiry) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      ActionsMenuInquiry cdo,
      ActionsMenuInquiry_Request request,
      out ActionsMenuInquiry_Result result)
    {
      result = (ActionsMenuInquiry_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IActionsMenuInquiryService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new ActionsMenuInquiryMethod(cdo, ActionsMenuInquiryMethods.ExecuteTransaction, (ActionsMenuInquiry_Parameters) null));
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
        ActionsMenuInquiry_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((ActionsMenuInquiry) cdo, (ActionsMenuInquiry_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(ActionsMenuInquiry cdo)
    {
      return this.ExecuteTransaction(cdo, (ActionsMenuInquiry_Request) null, out ActionsMenuInquiry_Result _);
    }

    public ResultStatus ExecuteTransaction(
      ActionsMenuInquiry_Request request,
      out ActionsMenuInquiry_Result result)
    {
      return this.ExecuteTransaction((ActionsMenuInquiry) null, request, out result);
    }

    public ResultStatus AddDataTransaction(ActionsMenuInquiry cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new ActionsMenuInquiryMethod(cdo, ActionsMenuInquiryMethods.AddDataTransaction, (ActionsMenuInquiry_Parameters) null));
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
        return this.AddDataTransaction((ActionsMenuInquiry) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
