// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.GetToDoListService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class GetToDoListService : InquiryBase
  {
    public GetToDoListService(UserProfile userProfile)
    {
      this.Initialize(typeof (IGetToDoListService), userProfile);
    }

    public ResultStatus GetToDoList(
      Camstar.WCF.ObjectStack.GetToDoList getToDoList,
      GetToDoList_Parameters parameters,
      GetToDoList_Request request,
      out GetToDoList_Result result)
    {
      result = (GetToDoList_Result) null;
      this.OnBeforeCall(nameof (GetToDoList), (DCObject) getToDoList, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IGetToDoListService) this._Channel).GetToDoList(this._UserProfile, getToDoList, parameters, request, out result) : this.AddMethod((Method) new GetToDoListMethod(getToDoList, GetToDoListMethods.GetToDoList, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetToDoList), res, (DCObject) getToDoList, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetToDoList()
    {
      return this.GetToDoList((Camstar.WCF.ObjectStack.GetToDoList) null, (GetToDoList_Parameters) null, (GetToDoList_Request) null, out GetToDoList_Result _);
    }

    public ResultStatus GetToDoList(Camstar.WCF.ObjectStack.GetToDoList getToDoList)
    {
      return this.GetToDoList(getToDoList, (GetToDoList_Parameters) null, (GetToDoList_Request) null, out GetToDoList_Result _);
    }

    public ResultStatus GetToDoList(
      Camstar.WCF.ObjectStack.GetToDoList getToDoList,
      GetToDoList_Request request,
      out GetToDoList_Result result)
    {
      return this.GetToDoList(getToDoList, (GetToDoList_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      Camstar.WCF.ObjectStack.GetToDoList getToDoList,
      GetToDoList_Parameters parameters,
      GetToDoList_Request request,
      out GetToDoList_Result result)
    {
      result = (GetToDoList_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) getToDoList, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IGetToDoListService) this._Channel).GetWIPMsgs(this._UserProfile, getToDoList, parameters, request, out result) : this.AddMethod((Method) new GetToDoListMethod(getToDoList, GetToDoListMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) getToDoList, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((Camstar.WCF.ObjectStack.GetToDoList) null, (GetToDoList_Parameters) null, (GetToDoList_Request) null, out GetToDoList_Result _);
    }

    public ResultStatus GetWIPMsgs(Camstar.WCF.ObjectStack.GetToDoList getToDoList)
    {
      return this.GetWIPMsgs(getToDoList, (GetToDoList_Parameters) null, (GetToDoList_Request) null, out GetToDoList_Result _);
    }

    public ResultStatus GetWIPMsgs(
      Camstar.WCF.ObjectStack.GetToDoList getToDoList,
      GetToDoList_Request request,
      out GetToDoList_Result result)
    {
      return this.GetWIPMsgs(getToDoList, (GetToDoList_Parameters) null, request, out result);
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject getToDoList,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        GetToDoList_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((Camstar.WCF.ObjectStack.GetToDoList) getToDoList, (GetToDoList_Parameters) parameters, (GetToDoList_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      GetToDoList_Request request,
      out GetToDoList_Result result)
    {
      result = (GetToDoList_Result) null;
      try
      {
        GetToDoListMethod[] methods = new GetToDoListMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IGetToDoListService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        GetToDoList_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((GetToDoList_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      Camstar.WCF.ObjectStack.GetToDoList cdo,
      GetToDoList_Request request,
      out GetToDoList_Result result)
    {
      result = (GetToDoList_Result) null;
      try
      {
        return ((IGetToDoListService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        GetToDoList_Result result1;
        ResultStatus environment = this.GetEnvironment((Camstar.WCF.ObjectStack.GetToDoList) cdo, (GetToDoList_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      GetToDoList_Request request,
      out GetToDoList_Result result)
    {
      return this.GetEnvironment((Camstar.WCF.ObjectStack.GetToDoList) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      Camstar.WCF.ObjectStack.GetToDoList cdo,
      GetToDoList_Request request,
      out GetToDoList_Result result)
    {
      result = (GetToDoList_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IGetToDoListService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new GetToDoListMethod(cdo, GetToDoListMethods.ExecuteTransaction, (GetToDoList_Parameters) null));
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
        GetToDoList_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((Camstar.WCF.ObjectStack.GetToDoList) cdo, (GetToDoList_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(Camstar.WCF.ObjectStack.GetToDoList cdo)
    {
      return this.ExecuteTransaction(cdo, (GetToDoList_Request) null, out GetToDoList_Result _);
    }

    public ResultStatus ExecuteTransaction(
      GetToDoList_Request request,
      out GetToDoList_Result result)
    {
      return this.ExecuteTransaction((Camstar.WCF.ObjectStack.GetToDoList) null, request, out result);
    }

    public ResultStatus AddDataTransaction(Camstar.WCF.ObjectStack.GetToDoList cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new GetToDoListMethod(cdo, GetToDoListMethods.AddDataTransaction, (GetToDoList_Parameters) null));
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
        return this.AddDataTransaction((Camstar.WCF.ObjectStack.GetToDoList) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
