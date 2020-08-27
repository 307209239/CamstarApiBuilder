// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.ResourceAuditTrailInquiryService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class ResourceAuditTrailInquiryService : MfgAuditTrailInquiryBase
  {
    public ResourceAuditTrailInquiryService(UserProfile userProfile)
    {
      this.Initialize(typeof (IResourceAuditTrailInquiryService), userProfile);
    }

    public ResultStatus GetWIPMsgs(
      ResourceAuditTrailInquiry resourceAuditTrailInquiry,
      ResourceAuditTrailInquiry_Parameters parameters,
      ResourceAuditTrailInquiry_Request request,
      out ResourceAuditTrailInquiry_Result result)
    {
      result = (ResourceAuditTrailInquiry_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) resourceAuditTrailInquiry, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IResourceAuditTrailInquiryService) this._Channel).GetWIPMsgs(this._UserProfile, resourceAuditTrailInquiry, parameters, request, out result) : this.AddMethod((Method) new ResourceAuditTrailInquiryMethod(resourceAuditTrailInquiry, ResourceAuditTrailInquiryMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) resourceAuditTrailInquiry, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((ResourceAuditTrailInquiry) null, (ResourceAuditTrailInquiry_Parameters) null, (ResourceAuditTrailInquiry_Request) null, out ResourceAuditTrailInquiry_Result _);
    }

    public ResultStatus GetWIPMsgs(
      ResourceAuditTrailInquiry resourceAuditTrailInquiry)
    {
      return this.GetWIPMsgs(resourceAuditTrailInquiry, (ResourceAuditTrailInquiry_Parameters) null, (ResourceAuditTrailInquiry_Request) null, out ResourceAuditTrailInquiry_Result _);
    }

    public ResultStatus GetWIPMsgs(
      ResourceAuditTrailInquiry resourceAuditTrailInquiry,
      ResourceAuditTrailInquiry_Request request,
      out ResourceAuditTrailInquiry_Result result)
    {
      return this.GetWIPMsgs(resourceAuditTrailInquiry, (ResourceAuditTrailInquiry_Parameters) null, request, out result);
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject resourceAuditTrailInquiry,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ResourceAuditTrailInquiry_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((ResourceAuditTrailInquiry) resourceAuditTrailInquiry, (ResourceAuditTrailInquiry_Parameters) parameters, (ResourceAuditTrailInquiry_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      ResourceAuditTrailInquiry_Request request,
      out ResourceAuditTrailInquiry_Result result)
    {
      result = (ResourceAuditTrailInquiry_Result) null;
      try
      {
        ResourceAuditTrailInquiryMethod[] methods = new ResourceAuditTrailInquiryMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IResourceAuditTrailInquiryService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        ResourceAuditTrailInquiry_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((ResourceAuditTrailInquiry_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      ResourceAuditTrailInquiry cdo,
      ResourceAuditTrailInquiry_Request request,
      out ResourceAuditTrailInquiry_Result result)
    {
      result = (ResourceAuditTrailInquiry_Result) null;
      try
      {
        return ((IResourceAuditTrailInquiryService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        ResourceAuditTrailInquiry_Result result1;
        ResultStatus environment = this.GetEnvironment((ResourceAuditTrailInquiry) cdo, (ResourceAuditTrailInquiry_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      ResourceAuditTrailInquiry_Request request,
      out ResourceAuditTrailInquiry_Result result)
    {
      return this.GetEnvironment((ResourceAuditTrailInquiry) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      ResourceAuditTrailInquiry cdo,
      ResourceAuditTrailInquiry_Request request,
      out ResourceAuditTrailInquiry_Result result)
    {
      result = (ResourceAuditTrailInquiry_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IResourceAuditTrailInquiryService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new ResourceAuditTrailInquiryMethod(cdo, ResourceAuditTrailInquiryMethods.ExecuteTransaction, (ResourceAuditTrailInquiry_Parameters) null));
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
        ResourceAuditTrailInquiry_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((ResourceAuditTrailInquiry) cdo, (ResourceAuditTrailInquiry_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(ResourceAuditTrailInquiry cdo)
    {
      return this.ExecuteTransaction(cdo, (ResourceAuditTrailInquiry_Request) null, out ResourceAuditTrailInquiry_Result _);
    }

    public ResultStatus ExecuteTransaction(
      ResourceAuditTrailInquiry_Request request,
      out ResourceAuditTrailInquiry_Result result)
    {
      return this.ExecuteTransaction((ResourceAuditTrailInquiry) null, request, out result);
    }

    public ResultStatus AddDataTransaction(ResourceAuditTrailInquiry cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new ResourceAuditTrailInquiryMethod(cdo, ResourceAuditTrailInquiryMethods.AddDataTransaction, (ResourceAuditTrailInquiry_Parameters) null));
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
        return this.AddDataTransaction((ResourceAuditTrailInquiry) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
