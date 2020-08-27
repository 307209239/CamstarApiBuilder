// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.EventLotDetailInquiryService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class EventLotDetailInquiryService : InquiryBase
  {
    public EventLotDetailInquiryService(UserProfile userProfile)
    {
      this.Initialize(typeof (IEventLotDetailInquiryService), userProfile);
    }

    public ResultStatus GetDispositions(
      EventLotDetailInquiry eventLotDetailInquiry,
      EventLotDetailInquiry_Parameters parameters,
      EventLotDetailInquiry_Request request,
      out EventLotDetailInquiry_Result result)
    {
      result = (EventLotDetailInquiry_Result) null;
      this.OnBeforeCall(nameof (GetDispositions), (DCObject) eventLotDetailInquiry, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IEventLotDetailInquiryService) this._Channel).GetDispositions(this._UserProfile, eventLotDetailInquiry, parameters, request, out result) : this.AddMethod((Method) new EventLotDetailInquiryMethod(eventLotDetailInquiry, EventLotDetailInquiryMethods.GetDispositions, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetDispositions), res, (DCObject) eventLotDetailInquiry, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetDispositions()
    {
      return this.GetDispositions((EventLotDetailInquiry) null, (EventLotDetailInquiry_Parameters) null, (EventLotDetailInquiry_Request) null, out EventLotDetailInquiry_Result _);
    }

    public ResultStatus GetDispositions(EventLotDetailInquiry eventLotDetailInquiry)
    {
      return this.GetDispositions(eventLotDetailInquiry, (EventLotDetailInquiry_Parameters) null, (EventLotDetailInquiry_Request) null, out EventLotDetailInquiry_Result _);
    }

    public ResultStatus GetDispositions(
      EventLotDetailInquiry eventLotDetailInquiry,
      EventLotDetailInquiry_Request request,
      out EventLotDetailInquiry_Result result)
    {
      return this.GetDispositions(eventLotDetailInquiry, (EventLotDetailInquiry_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      EventLotDetailInquiry eventLotDetailInquiry,
      EventLotDetailInquiry_Parameters parameters,
      EventLotDetailInquiry_Request request,
      out EventLotDetailInquiry_Result result)
    {
      result = (EventLotDetailInquiry_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) eventLotDetailInquiry, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IEventLotDetailInquiryService) this._Channel).GetWIPMsgs(this._UserProfile, eventLotDetailInquiry, parameters, request, out result) : this.AddMethod((Method) new EventLotDetailInquiryMethod(eventLotDetailInquiry, EventLotDetailInquiryMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) eventLotDetailInquiry, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((EventLotDetailInquiry) null, (EventLotDetailInquiry_Parameters) null, (EventLotDetailInquiry_Request) null, out EventLotDetailInquiry_Result _);
    }

    public ResultStatus GetWIPMsgs(EventLotDetailInquiry eventLotDetailInquiry)
    {
      return this.GetWIPMsgs(eventLotDetailInquiry, (EventLotDetailInquiry_Parameters) null, (EventLotDetailInquiry_Request) null, out EventLotDetailInquiry_Result _);
    }

    public ResultStatus GetWIPMsgs(
      EventLotDetailInquiry eventLotDetailInquiry,
      EventLotDetailInquiry_Request request,
      out EventLotDetailInquiry_Result result)
    {
      return this.GetWIPMsgs(eventLotDetailInquiry, (EventLotDetailInquiry_Parameters) null, request, out result);
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject eventLotDetailInquiry,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        EventLotDetailInquiry_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((EventLotDetailInquiry) eventLotDetailInquiry, (EventLotDetailInquiry_Parameters) parameters, (EventLotDetailInquiry_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      EventLotDetailInquiry_Request request,
      out EventLotDetailInquiry_Result result)
    {
      result = (EventLotDetailInquiry_Result) null;
      try
      {
        EventLotDetailInquiryMethod[] methods = new EventLotDetailInquiryMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IEventLotDetailInquiryService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        EventLotDetailInquiry_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((EventLotDetailInquiry_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      EventLotDetailInquiry cdo,
      EventLotDetailInquiry_Request request,
      out EventLotDetailInquiry_Result result)
    {
      result = (EventLotDetailInquiry_Result) null;
      try
      {
        return ((IEventLotDetailInquiryService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        EventLotDetailInquiry_Result result1;
        ResultStatus environment = this.GetEnvironment((EventLotDetailInquiry) cdo, (EventLotDetailInquiry_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      EventLotDetailInquiry_Request request,
      out EventLotDetailInquiry_Result result)
    {
      return this.GetEnvironment((EventLotDetailInquiry) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      EventLotDetailInquiry cdo,
      EventLotDetailInquiry_Request request,
      out EventLotDetailInquiry_Result result)
    {
      result = (EventLotDetailInquiry_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IEventLotDetailInquiryService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new EventLotDetailInquiryMethod(cdo, EventLotDetailInquiryMethods.ExecuteTransaction, (EventLotDetailInquiry_Parameters) null));
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
        EventLotDetailInquiry_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((EventLotDetailInquiry) cdo, (EventLotDetailInquiry_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(EventLotDetailInquiry cdo)
    {
      return this.ExecuteTransaction(cdo, (EventLotDetailInquiry_Request) null, out EventLotDetailInquiry_Result _);
    }

    public ResultStatus ExecuteTransaction(
      EventLotDetailInquiry_Request request,
      out EventLotDetailInquiry_Result result)
    {
      return this.ExecuteTransaction((EventLotDetailInquiry) null, request, out result);
    }

    public ResultStatus AddDataTransaction(EventLotDetailInquiry cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new EventLotDetailInquiryMethod(cdo, EventLotDetailInquiryMethods.AddDataTransaction, (EventLotDetailInquiry_Parameters) null));
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
        return this.AddDataTransaction((EventLotDetailInquiry) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
