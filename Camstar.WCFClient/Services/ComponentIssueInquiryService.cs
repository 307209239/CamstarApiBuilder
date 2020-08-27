// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.ComponentIssueInquiryService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class ComponentIssueInquiryService : InquiryBase
  {
    public ComponentIssueInquiryService(UserProfile userProfile)
    {
      this.Initialize(typeof (IComponentIssueInquiryService), userProfile);
    }

    public ResultStatus GetWIPMsgs(
      ComponentIssueInquiry componentIssueInquiry,
      ComponentIssueInquiry_Parameters parameters,
      ComponentIssueInquiry_Request request,
      out ComponentIssueInquiry_Result result)
    {
      result = (ComponentIssueInquiry_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) componentIssueInquiry, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IComponentIssueInquiryService) this._Channel).GetWIPMsgs(this._UserProfile, componentIssueInquiry, parameters, request, out result) : this.AddMethod((Method) new ComponentIssueInquiryMethod(componentIssueInquiry, ComponentIssueInquiryMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) componentIssueInquiry, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((ComponentIssueInquiry) null, (ComponentIssueInquiry_Parameters) null, (ComponentIssueInquiry_Request) null, out ComponentIssueInquiry_Result _);
    }

    public ResultStatus GetWIPMsgs(ComponentIssueInquiry componentIssueInquiry)
    {
      return this.GetWIPMsgs(componentIssueInquiry, (ComponentIssueInquiry_Parameters) null, (ComponentIssueInquiry_Request) null, out ComponentIssueInquiry_Result _);
    }

    public ResultStatus GetWIPMsgs(
      ComponentIssueInquiry componentIssueInquiry,
      ComponentIssueInquiry_Request request,
      out ComponentIssueInquiry_Result result)
    {
      return this.GetWIPMsgs(componentIssueInquiry, (ComponentIssueInquiry_Parameters) null, request, out result);
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject componentIssueInquiry,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ComponentIssueInquiry_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((ComponentIssueInquiry) componentIssueInquiry, (ComponentIssueInquiry_Parameters) parameters, (ComponentIssueInquiry_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      ComponentIssueInquiry_Request request,
      out ComponentIssueInquiry_Result result)
    {
      result = (ComponentIssueInquiry_Result) null;
      try
      {
        ComponentIssueInquiryMethod[] methods = new ComponentIssueInquiryMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IComponentIssueInquiryService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        ComponentIssueInquiry_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((ComponentIssueInquiry_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      ComponentIssueInquiry cdo,
      ComponentIssueInquiry_Request request,
      out ComponentIssueInquiry_Result result)
    {
      result = (ComponentIssueInquiry_Result) null;
      try
      {
        return ((IComponentIssueInquiryService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        ComponentIssueInquiry_Result result1;
        ResultStatus environment = this.GetEnvironment((ComponentIssueInquiry) cdo, (ComponentIssueInquiry_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      ComponentIssueInquiry_Request request,
      out ComponentIssueInquiry_Result result)
    {
      return this.GetEnvironment((ComponentIssueInquiry) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      ComponentIssueInquiry cdo,
      ComponentIssueInquiry_Request request,
      out ComponentIssueInquiry_Result result)
    {
      result = (ComponentIssueInquiry_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IComponentIssueInquiryService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new ComponentIssueInquiryMethod(cdo, ComponentIssueInquiryMethods.ExecuteTransaction, (ComponentIssueInquiry_Parameters) null));
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
        ComponentIssueInquiry_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((ComponentIssueInquiry) cdo, (ComponentIssueInquiry_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(ComponentIssueInquiry cdo)
    {
      return this.ExecuteTransaction(cdo, (ComponentIssueInquiry_Request) null, out ComponentIssueInquiry_Result _);
    }

    public ResultStatus ExecuteTransaction(
      ComponentIssueInquiry_Request request,
      out ComponentIssueInquiry_Result result)
    {
      return this.ExecuteTransaction((ComponentIssueInquiry) null, request, out result);
    }

    public ResultStatus AddDataTransaction(ComponentIssueInquiry cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new ComponentIssueInquiryMethod(cdo, ComponentIssueInquiryMethods.AddDataTransaction, (ComponentIssueInquiry_Parameters) null));
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
        return this.AddDataTransaction((ComponentIssueInquiry) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
