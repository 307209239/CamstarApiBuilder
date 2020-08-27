// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.GetGeneralMessageService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class GetGeneralMessageService : InquiryBase
  {
    public GetGeneralMessageService(UserProfile userProfile)
    {
      this.Initialize(typeof (IGetGeneralMessageService), userProfile);
    }

    public ResultStatus GetWIPMsgs(
      GetGeneralMessage getGeneralMessage,
      GetGeneralMessage_Parameters parameters,
      GetGeneralMessage_Request request,
      out GetGeneralMessage_Result result)
    {
      result = (GetGeneralMessage_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) getGeneralMessage, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IGetGeneralMessageService) this._Channel).GetWIPMsgs(this._UserProfile, getGeneralMessage, parameters, request, out result) : this.AddMethod((Method) new GetGeneralMessageMethod(getGeneralMessage, GetGeneralMessageMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) getGeneralMessage, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((GetGeneralMessage) null, (GetGeneralMessage_Parameters) null, (GetGeneralMessage_Request) null, out GetGeneralMessage_Result _);
    }

    public ResultStatus GetWIPMsgs(GetGeneralMessage getGeneralMessage)
    {
      return this.GetWIPMsgs(getGeneralMessage, (GetGeneralMessage_Parameters) null, (GetGeneralMessage_Request) null, out GetGeneralMessage_Result _);
    }

    public ResultStatus GetWIPMsgs(
      GetGeneralMessage getGeneralMessage,
      GetGeneralMessage_Request request,
      out GetGeneralMessage_Result result)
    {
      return this.GetWIPMsgs(getGeneralMessage, (GetGeneralMessage_Parameters) null, request, out result);
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject getGeneralMessage,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        GetGeneralMessage_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((GetGeneralMessage) getGeneralMessage, (GetGeneralMessage_Parameters) parameters, (GetGeneralMessage_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      GetGeneralMessage_Request request,
      out GetGeneralMessage_Result result)
    {
      result = (GetGeneralMessage_Result) null;
      try
      {
        GetGeneralMessageMethod[] methods = new GetGeneralMessageMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IGetGeneralMessageService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        GetGeneralMessage_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((GetGeneralMessage_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      GetGeneralMessage cdo,
      GetGeneralMessage_Request request,
      out GetGeneralMessage_Result result)
    {
      result = (GetGeneralMessage_Result) null;
      try
      {
        return ((IGetGeneralMessageService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        GetGeneralMessage_Result result1;
        ResultStatus environment = this.GetEnvironment((GetGeneralMessage) cdo, (GetGeneralMessage_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      GetGeneralMessage_Request request,
      out GetGeneralMessage_Result result)
    {
      return this.GetEnvironment((GetGeneralMessage) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      GetGeneralMessage cdo,
      GetGeneralMessage_Request request,
      out GetGeneralMessage_Result result)
    {
      result = (GetGeneralMessage_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IGetGeneralMessageService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new GetGeneralMessageMethod(cdo, GetGeneralMessageMethods.ExecuteTransaction, (GetGeneralMessage_Parameters) null));
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
        GetGeneralMessage_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((GetGeneralMessage) cdo, (GetGeneralMessage_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(GetGeneralMessage cdo)
    {
      return this.ExecuteTransaction(cdo, (GetGeneralMessage_Request) null, out GetGeneralMessage_Result _);
    }

    public ResultStatus ExecuteTransaction(
      GetGeneralMessage_Request request,
      out GetGeneralMessage_Result result)
    {
      return this.ExecuteTransaction((GetGeneralMessage) null, request, out result);
    }

    public ResultStatus AddDataTransaction(GetGeneralMessage cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new GetGeneralMessageMethod(cdo, GetGeneralMessageMethods.AddDataTransaction, (GetGeneralMessage_Parameters) null));
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
        return this.AddDataTransaction((GetGeneralMessage) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
