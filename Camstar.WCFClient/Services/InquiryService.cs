// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.InquiryService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class InquiryService : ServiceBase
  {
    public InquiryService(UserProfile userProfile)
    {
      this.Initialize(typeof (IInquiryService), userProfile);
    }

    public ResultStatus GetWIPMsgs(
      Inquiry inquiry,
      Inquiry_Parameters parameters,
      Inquiry_Request request,
      out Inquiry_Result result)
    {
      result = (Inquiry_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) inquiry, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IInquiryService) this._Channel).GetWIPMsgs(this._UserProfile, inquiry, parameters, request, out result) : this.AddMethod((Method) new InquiryMethod(inquiry, InquiryMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) inquiry, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((Inquiry) null, (Inquiry_Parameters) null, (Inquiry_Request) null, out Inquiry_Result _);
    }

    public ResultStatus GetWIPMsgs(Inquiry inquiry)
    {
      return this.GetWIPMsgs(inquiry, (Inquiry_Parameters) null, (Inquiry_Request) null, out Inquiry_Result _);
    }

    public ResultStatus GetWIPMsgs(
      Inquiry inquiry,
      Inquiry_Request request,
      out Inquiry_Result result)
    {
      return this.GetWIPMsgs(inquiry, (Inquiry_Parameters) null, request, out result);
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject inquiry,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        Inquiry_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((Inquiry) inquiry, (Inquiry_Parameters) parameters, (Inquiry_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      Inquiry_Request request,
      out Inquiry_Result result)
    {
      result = (Inquiry_Result) null;
      try
      {
        InquiryMethod[] methods = new InquiryMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IInquiryService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        Inquiry_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((Inquiry_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      Inquiry cdo,
      Inquiry_Request request,
      out Inquiry_Result result)
    {
      result = (Inquiry_Result) null;
      try
      {
        return ((IInquiryService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        Inquiry_Result result1;
        ResultStatus environment = this.GetEnvironment((Inquiry) cdo, (Inquiry_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      Inquiry_Request request,
      out Inquiry_Result result)
    {
      return this.GetEnvironment((Inquiry) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      Inquiry cdo,
      Inquiry_Request request,
      out Inquiry_Result result)
    {
      result = (Inquiry_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IInquiryService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new InquiryMethod(cdo, InquiryMethods.ExecuteTransaction, (Inquiry_Parameters) null));
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
        Inquiry_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((Inquiry) cdo, (Inquiry_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(Inquiry cdo)
    {
      return this.ExecuteTransaction(cdo, (Inquiry_Request) null, out Inquiry_Result _);
    }

    public ResultStatus ExecuteTransaction(
      Inquiry_Request request,
      out Inquiry_Result result)
    {
      return this.ExecuteTransaction((Inquiry) null, request, out result);
    }

    public ResultStatus AddDataTransaction(Inquiry cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new InquiryMethod(cdo, InquiryMethods.AddDataTransaction, (Inquiry_Parameters) null));
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
        return this.AddDataTransaction((Inquiry) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
