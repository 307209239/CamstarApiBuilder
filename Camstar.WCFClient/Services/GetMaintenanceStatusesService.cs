// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.GetMaintenanceStatusesService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class GetMaintenanceStatusesService : InquiryBase
  {
    public GetMaintenanceStatusesService(UserProfile userProfile)
    {
      this.Initialize(typeof (IGetMaintenanceStatusesService), userProfile);
    }

    public ResultStatus FilterDateReq(
      Camstar.WCF.ObjectStack.GetMaintenanceStatuses getMaintenanceStatuses,
      GetMaintenanceStatuses_FilterDateReq_Parameters parameters,
      GetMaintenanceStatuses_Request request,
      out GetMaintenanceStatuses_Result result)
    {
      result = (GetMaintenanceStatuses_Result) null;
      this.OnBeforeCall(nameof (FilterDateReq), (DCObject) getMaintenanceStatuses, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IGetMaintenanceStatusesService) this._Channel).FilterDateReq(this._UserProfile, getMaintenanceStatuses, parameters, request, out result) : this.AddMethod((Method) new GetMaintenanceStatusesMethod(getMaintenanceStatuses, GetMaintenanceStatusesMethods.FilterDateReq, (GetMaintenanceStatuses_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (FilterDateReq), res, (DCObject) getMaintenanceStatuses, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus FilterDateReq()
    {
      return this.FilterDateReq((Camstar.WCF.ObjectStack.GetMaintenanceStatuses) null, (GetMaintenanceStatuses_FilterDateReq_Parameters) null, (GetMaintenanceStatuses_Request) null, out GetMaintenanceStatuses_Result _);
    }

    public ResultStatus FilterDateReq(Camstar.WCF.ObjectStack.GetMaintenanceStatuses getMaintenanceStatuses)
    {
      return this.FilterDateReq(getMaintenanceStatuses, (GetMaintenanceStatuses_FilterDateReq_Parameters) null, (GetMaintenanceStatuses_Request) null, out GetMaintenanceStatuses_Result _);
    }

    public ResultStatus FilterDateReq(
      Camstar.WCF.ObjectStack.GetMaintenanceStatuses getMaintenanceStatuses,
      GetMaintenanceStatuses_Request request,
      out GetMaintenanceStatuses_Result result)
    {
      return this.FilterDateReq(getMaintenanceStatuses, (GetMaintenanceStatuses_FilterDateReq_Parameters) null, request, out result);
    }

    public ResultStatus FilterRecurringDateReq(
      Camstar.WCF.ObjectStack.GetMaintenanceStatuses getMaintenanceStatuses,
      GetMaintenanceStatuses_FilterRecurringDateReq_Parameters parameters,
      GetMaintenanceStatuses_Request request,
      out GetMaintenanceStatuses_Result result)
    {
      result = (GetMaintenanceStatuses_Result) null;
      this.OnBeforeCall(nameof (FilterRecurringDateReq), (DCObject) getMaintenanceStatuses, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IGetMaintenanceStatusesService) this._Channel).FilterRecurringDateReq(this._UserProfile, getMaintenanceStatuses, parameters, request, out result) : this.AddMethod((Method) new GetMaintenanceStatusesMethod(getMaintenanceStatuses, GetMaintenanceStatusesMethods.FilterRecurringDateReq, (GetMaintenanceStatuses_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (FilterRecurringDateReq), res, (DCObject) getMaintenanceStatuses, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus FilterRecurringDateReq()
    {
      return this.FilterRecurringDateReq((Camstar.WCF.ObjectStack.GetMaintenanceStatuses) null, (GetMaintenanceStatuses_FilterRecurringDateReq_Parameters) null, (GetMaintenanceStatuses_Request) null, out GetMaintenanceStatuses_Result _);
    }

    public ResultStatus FilterRecurringDateReq(
      Camstar.WCF.ObjectStack.GetMaintenanceStatuses getMaintenanceStatuses)
    {
      return this.FilterRecurringDateReq(getMaintenanceStatuses, (GetMaintenanceStatuses_FilterRecurringDateReq_Parameters) null, (GetMaintenanceStatuses_Request) null, out GetMaintenanceStatuses_Result _);
    }

    public ResultStatus FilterRecurringDateReq(
      Camstar.WCF.ObjectStack.GetMaintenanceStatuses getMaintenanceStatuses,
      GetMaintenanceStatuses_Request request,
      out GetMaintenanceStatuses_Result result)
    {
      return this.FilterRecurringDateReq(getMaintenanceStatuses, (GetMaintenanceStatuses_FilterRecurringDateReq_Parameters) null, request, out result);
    }

    public ResultStatus FilterThruputReq(
      Camstar.WCF.ObjectStack.GetMaintenanceStatuses getMaintenanceStatuses,
      GetMaintenanceStatuses_FilterThruputReq_Parameters parameters,
      GetMaintenanceStatuses_Request request,
      out GetMaintenanceStatuses_Result result)
    {
      result = (GetMaintenanceStatuses_Result) null;
      this.OnBeforeCall(nameof (FilterThruputReq), (DCObject) getMaintenanceStatuses, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IGetMaintenanceStatusesService) this._Channel).FilterThruputReq(this._UserProfile, getMaintenanceStatuses, parameters, request, out result) : this.AddMethod((Method) new GetMaintenanceStatusesMethod(getMaintenanceStatuses, GetMaintenanceStatusesMethods.FilterThruputReq, (GetMaintenanceStatuses_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (FilterThruputReq), res, (DCObject) getMaintenanceStatuses, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus FilterThruputReq()
    {
      return this.FilterThruputReq((Camstar.WCF.ObjectStack.GetMaintenanceStatuses) null, (GetMaintenanceStatuses_FilterThruputReq_Parameters) null, (GetMaintenanceStatuses_Request) null, out GetMaintenanceStatuses_Result _);
    }

    public ResultStatus FilterThruputReq(Camstar.WCF.ObjectStack.GetMaintenanceStatuses getMaintenanceStatuses)
    {
      return this.FilterThruputReq(getMaintenanceStatuses, (GetMaintenanceStatuses_FilterThruputReq_Parameters) null, (GetMaintenanceStatuses_Request) null, out GetMaintenanceStatuses_Result _);
    }

    public ResultStatus FilterThruputReq(
      Camstar.WCF.ObjectStack.GetMaintenanceStatuses getMaintenanceStatuses,
      GetMaintenanceStatuses_Request request,
      out GetMaintenanceStatuses_Result result)
    {
      return this.FilterThruputReq(getMaintenanceStatuses, (GetMaintenanceStatuses_FilterThruputReq_Parameters) null, request, out result);
    }

    public ResultStatus GetMaintenanceStatuses(
      Camstar.WCF.ObjectStack.GetMaintenanceStatuses getMaintenanceStatuses,
      GetMaintenanceStatuses_Parameters parameters,
      GetMaintenanceStatuses_Request request,
      out GetMaintenanceStatuses_Result result)
    {
      result = (GetMaintenanceStatuses_Result) null;
      this.OnBeforeCall(nameof (GetMaintenanceStatuses), (DCObject) getMaintenanceStatuses, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IGetMaintenanceStatusesService) this._Channel).GetMaintenanceStatuses(this._UserProfile, getMaintenanceStatuses, parameters, request, out result) : this.AddMethod((Method) new GetMaintenanceStatusesMethod(getMaintenanceStatuses, GetMaintenanceStatusesMethods.GetMaintenanceStatuses, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetMaintenanceStatuses), res, (DCObject) getMaintenanceStatuses, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetMaintenanceStatuses()
    {
      return this.GetMaintenanceStatuses((Camstar.WCF.ObjectStack.GetMaintenanceStatuses) null, (GetMaintenanceStatuses_Parameters) null, (GetMaintenanceStatuses_Request) null, out GetMaintenanceStatuses_Result _);
    }

    public ResultStatus GetMaintenanceStatuses(
      Camstar.WCF.ObjectStack.GetMaintenanceStatuses getMaintenanceStatuses)
    {
      return this.GetMaintenanceStatuses(getMaintenanceStatuses, (GetMaintenanceStatuses_Parameters) null, (GetMaintenanceStatuses_Request) null, out GetMaintenanceStatuses_Result _);
    }

    public ResultStatus GetMaintenanceStatuses(
      Camstar.WCF.ObjectStack.GetMaintenanceStatuses getMaintenanceStatuses,
      GetMaintenanceStatuses_Request request,
      out GetMaintenanceStatuses_Result result)
    {
      return this.GetMaintenanceStatuses(getMaintenanceStatuses, (GetMaintenanceStatuses_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      Camstar.WCF.ObjectStack.GetMaintenanceStatuses getMaintenanceStatuses,
      GetMaintenanceStatuses_Parameters parameters,
      GetMaintenanceStatuses_Request request,
      out GetMaintenanceStatuses_Result result)
    {
      result = (GetMaintenanceStatuses_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) getMaintenanceStatuses, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IGetMaintenanceStatusesService) this._Channel).GetWIPMsgs(this._UserProfile, getMaintenanceStatuses, parameters, request, out result) : this.AddMethod((Method) new GetMaintenanceStatusesMethod(getMaintenanceStatuses, GetMaintenanceStatusesMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) getMaintenanceStatuses, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((Camstar.WCF.ObjectStack.GetMaintenanceStatuses) null, (GetMaintenanceStatuses_Parameters) null, (GetMaintenanceStatuses_Request) null, out GetMaintenanceStatuses_Result _);
    }

    public ResultStatus GetWIPMsgs(Camstar.WCF.ObjectStack.GetMaintenanceStatuses getMaintenanceStatuses)
    {
      return this.GetWIPMsgs(getMaintenanceStatuses, (GetMaintenanceStatuses_Parameters) null, (GetMaintenanceStatuses_Request) null, out GetMaintenanceStatuses_Result _);
    }

    public ResultStatus GetWIPMsgs(
      Camstar.WCF.ObjectStack.GetMaintenanceStatuses getMaintenanceStatuses,
      GetMaintenanceStatuses_Request request,
      out GetMaintenanceStatuses_Result result)
    {
      return this.GetWIPMsgs(getMaintenanceStatuses, (GetMaintenanceStatuses_Parameters) null, request, out result);
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject getMaintenanceStatuses,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        GetMaintenanceStatuses_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((Camstar.WCF.ObjectStack.GetMaintenanceStatuses) getMaintenanceStatuses, (GetMaintenanceStatuses_Parameters) parameters, (GetMaintenanceStatuses_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      GetMaintenanceStatuses_Request request,
      out GetMaintenanceStatuses_Result result)
    {
      result = (GetMaintenanceStatuses_Result) null;
      try
      {
        GetMaintenanceStatusesMethod[] methods = new GetMaintenanceStatusesMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IGetMaintenanceStatusesService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        GetMaintenanceStatuses_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((GetMaintenanceStatuses_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      Camstar.WCF.ObjectStack.GetMaintenanceStatuses cdo,
      GetMaintenanceStatuses_Request request,
      out GetMaintenanceStatuses_Result result)
    {
      result = (GetMaintenanceStatuses_Result) null;
      try
      {
        return ((IGetMaintenanceStatusesService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        GetMaintenanceStatuses_Result result1;
        ResultStatus environment = this.GetEnvironment((Camstar.WCF.ObjectStack.GetMaintenanceStatuses) cdo, (GetMaintenanceStatuses_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      GetMaintenanceStatuses_Request request,
      out GetMaintenanceStatuses_Result result)
    {
      return this.GetEnvironment((Camstar.WCF.ObjectStack.GetMaintenanceStatuses) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      Camstar.WCF.ObjectStack.GetMaintenanceStatuses cdo,
      GetMaintenanceStatuses_Request request,
      out GetMaintenanceStatuses_Result result)
    {
      result = (GetMaintenanceStatuses_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IGetMaintenanceStatusesService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new GetMaintenanceStatusesMethod(cdo, GetMaintenanceStatusesMethods.ExecuteTransaction, (GetMaintenanceStatuses_Parameters) null));
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
        GetMaintenanceStatuses_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((Camstar.WCF.ObjectStack.GetMaintenanceStatuses) cdo, (GetMaintenanceStatuses_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(Camstar.WCF.ObjectStack.GetMaintenanceStatuses cdo)
    {
      return this.ExecuteTransaction(cdo, (GetMaintenanceStatuses_Request) null, out GetMaintenanceStatuses_Result _);
    }

    public ResultStatus ExecuteTransaction(
      GetMaintenanceStatuses_Request request,
      out GetMaintenanceStatuses_Result result)
    {
      return this.ExecuteTransaction((Camstar.WCF.ObjectStack.GetMaintenanceStatuses) null, request, out result);
    }

    public ResultStatus AddDataTransaction(Camstar.WCF.ObjectStack.GetMaintenanceStatuses cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new GetMaintenanceStatusesMethod(cdo, GetMaintenanceStatusesMethods.AddDataTransaction, (GetMaintenanceStatuses_Parameters) null));
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
        return this.AddDataTransaction((Camstar.WCF.ObjectStack.GetMaintenanceStatuses) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
