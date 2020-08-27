// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.ComponentReplaceInquiryService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class ComponentReplaceInquiryService : InquiryBase
  {
    public ComponentReplaceInquiryService(UserProfile userProfile)
    {
      this.Initialize(typeof (IComponentReplaceInquiryService), userProfile);
    }

    public ResultStatus GetAllIssueDetails(
      ComponentReplaceInquiry componentReplaceInquiry,
      ComponentReplaceInquiry_Parameters parameters,
      ComponentReplaceInquiry_Request request,
      out ComponentReplaceInquiry_Result result)
    {
      result = (ComponentReplaceInquiry_Result) null;
      this.OnBeforeCall(nameof (GetAllIssueDetails), (DCObject) componentReplaceInquiry, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IComponentReplaceInquiryService) this._Channel).GetAllIssueDetails(this._UserProfile, componentReplaceInquiry, parameters, request, out result) : this.AddMethod((Method) new ComponentReplaceInquiryMethod(componentReplaceInquiry, ComponentReplaceInquiryMethods.GetAllIssueDetails, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetAllIssueDetails), res, (DCObject) componentReplaceInquiry, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetAllIssueDetails()
    {
      return this.GetAllIssueDetails((ComponentReplaceInquiry) null, (ComponentReplaceInquiry_Parameters) null, (ComponentReplaceInquiry_Request) null, out ComponentReplaceInquiry_Result _);
    }

    public ResultStatus GetAllIssueDetails(
      ComponentReplaceInquiry componentReplaceInquiry)
    {
      return this.GetAllIssueDetails(componentReplaceInquiry, (ComponentReplaceInquiry_Parameters) null, (ComponentReplaceInquiry_Request) null, out ComponentReplaceInquiry_Result _);
    }

    public ResultStatus GetAllIssueDetails(
      ComponentReplaceInquiry componentReplaceInquiry,
      ComponentReplaceInquiry_Request request,
      out ComponentReplaceInquiry_Result result)
    {
      return this.GetAllIssueDetails(componentReplaceInquiry, (ComponentReplaceInquiry_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      ComponentReplaceInquiry componentReplaceInquiry,
      ComponentReplaceInquiry_Parameters parameters,
      ComponentReplaceInquiry_Request request,
      out ComponentReplaceInquiry_Result result)
    {
      result = (ComponentReplaceInquiry_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) componentReplaceInquiry, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IComponentReplaceInquiryService) this._Channel).GetWIPMsgs(this._UserProfile, componentReplaceInquiry, parameters, request, out result) : this.AddMethod((Method) new ComponentReplaceInquiryMethod(componentReplaceInquiry, ComponentReplaceInquiryMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) componentReplaceInquiry, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((ComponentReplaceInquiry) null, (ComponentReplaceInquiry_Parameters) null, (ComponentReplaceInquiry_Request) null, out ComponentReplaceInquiry_Result _);
    }

    public ResultStatus GetWIPMsgs(ComponentReplaceInquiry componentReplaceInquiry)
    {
      return this.GetWIPMsgs(componentReplaceInquiry, (ComponentReplaceInquiry_Parameters) null, (ComponentReplaceInquiry_Request) null, out ComponentReplaceInquiry_Result _);
    }

    public ResultStatus GetWIPMsgs(
      ComponentReplaceInquiry componentReplaceInquiry,
      ComponentReplaceInquiry_Request request,
      out ComponentReplaceInquiry_Result result)
    {
      return this.GetWIPMsgs(componentReplaceInquiry, (ComponentReplaceInquiry_Parameters) null, request, out result);
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject componentReplaceInquiry,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ComponentReplaceInquiry_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((ComponentReplaceInquiry) componentReplaceInquiry, (ComponentReplaceInquiry_Parameters) parameters, (ComponentReplaceInquiry_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      ComponentReplaceInquiry_Request request,
      out ComponentReplaceInquiry_Result result)
    {
      result = (ComponentReplaceInquiry_Result) null;
      try
      {
        ComponentReplaceInquiryMethod[] methods = new ComponentReplaceInquiryMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IComponentReplaceInquiryService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        ComponentReplaceInquiry_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((ComponentReplaceInquiry_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      ComponentReplaceInquiry cdo,
      ComponentReplaceInquiry_Request request,
      out ComponentReplaceInquiry_Result result)
    {
      result = (ComponentReplaceInquiry_Result) null;
      try
      {
        return ((IComponentReplaceInquiryService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        ComponentReplaceInquiry_Result result1;
        ResultStatus environment = this.GetEnvironment((ComponentReplaceInquiry) cdo, (ComponentReplaceInquiry_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      ComponentReplaceInquiry_Request request,
      out ComponentReplaceInquiry_Result result)
    {
      return this.GetEnvironment((ComponentReplaceInquiry) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      ComponentReplaceInquiry cdo,
      ComponentReplaceInquiry_Request request,
      out ComponentReplaceInquiry_Result result)
    {
      result = (ComponentReplaceInquiry_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IComponentReplaceInquiryService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new ComponentReplaceInquiryMethod(cdo, ComponentReplaceInquiryMethods.ExecuteTransaction, (ComponentReplaceInquiry_Parameters) null));
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
        ComponentReplaceInquiry_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((ComponentReplaceInquiry) cdo, (ComponentReplaceInquiry_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(ComponentReplaceInquiry cdo)
    {
      return this.ExecuteTransaction(cdo, (ComponentReplaceInquiry_Request) null, out ComponentReplaceInquiry_Result _);
    }

    public ResultStatus ExecuteTransaction(
      ComponentReplaceInquiry_Request request,
      out ComponentReplaceInquiry_Result result)
    {
      return this.ExecuteTransaction((ComponentReplaceInquiry) null, request, out result);
    }

    public ResultStatus AddDataTransaction(ComponentReplaceInquiry cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new ComponentReplaceInquiryMethod(cdo, ComponentReplaceInquiryMethods.AddDataTransaction, (ComponentReplaceInquiry_Parameters) null));
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
        return this.AddDataTransaction((ComponentReplaceInquiry) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
