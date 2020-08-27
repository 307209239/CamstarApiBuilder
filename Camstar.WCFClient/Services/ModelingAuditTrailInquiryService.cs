// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.ModelingAuditTrailInquiryService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class ModelingAuditTrailInquiryService : AuditTrailInquiryBase
  {
    public ModelingAuditTrailInquiryService(UserProfile userProfile)
    {
      this.Initialize(typeof (IModelingAuditTrailInquiryService), userProfile);
    }

    public ResultStatus GetAuditTrailDetails(
      ModelingAuditTrailInquiry modelingAuditTrailInquiry,
      ModelingAuditTrailInquiry_Parameters parameters,
      ModelingAuditTrailInquiry_Request request,
      out ModelingAuditTrailInquiry_Result result)
    {
      result = (ModelingAuditTrailInquiry_Result) null;
      this.OnBeforeCall(nameof (GetAuditTrailDetails), (DCObject) modelingAuditTrailInquiry, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IModelingAuditTrailInquiryService) this._Channel).GetAuditTrailDetails(this._UserProfile, modelingAuditTrailInquiry, parameters, request, out result) : this.AddMethod((Method) new ModelingAuditTrailInquiryMethod(modelingAuditTrailInquiry, ModelingAuditTrailInquiryMethods.GetAuditTrailDetails, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetAuditTrailDetails), res, (DCObject) modelingAuditTrailInquiry, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetAuditTrailDetails()
    {
      return this.GetAuditTrailDetails((ModelingAuditTrailInquiry) null, (ModelingAuditTrailInquiry_Parameters) null, (ModelingAuditTrailInquiry_Request) null, out ModelingAuditTrailInquiry_Result _);
    }

    public ResultStatus GetAuditTrailDetails(
      ModelingAuditTrailInquiry modelingAuditTrailInquiry)
    {
      return this.GetAuditTrailDetails(modelingAuditTrailInquiry, (ModelingAuditTrailInquiry_Parameters) null, (ModelingAuditTrailInquiry_Request) null, out ModelingAuditTrailInquiry_Result _);
    }

    public ResultStatus GetAuditTrailDetails(
      ModelingAuditTrailInquiry modelingAuditTrailInquiry,
      ModelingAuditTrailInquiry_Request request,
      out ModelingAuditTrailInquiry_Result result)
    {
      return this.GetAuditTrailDetails(modelingAuditTrailInquiry, (ModelingAuditTrailInquiry_Parameters) null, request, out result);
    }

    public ResultStatus GetAuditTrailHeaders(
      ModelingAuditTrailInquiry modelingAuditTrailInquiry,
      ModelingAuditTrailInquiry_Parameters parameters,
      ModelingAuditTrailInquiry_Request request,
      out ModelingAuditTrailInquiry_Result result)
    {
      result = (ModelingAuditTrailInquiry_Result) null;
      this.OnBeforeCall(nameof (GetAuditTrailHeaders), (DCObject) modelingAuditTrailInquiry, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IModelingAuditTrailInquiryService) this._Channel).GetAuditTrailHeaders(this._UserProfile, modelingAuditTrailInquiry, parameters, request, out result) : this.AddMethod((Method) new ModelingAuditTrailInquiryMethod(modelingAuditTrailInquiry, ModelingAuditTrailInquiryMethods.GetAuditTrailHeaders, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetAuditTrailHeaders), res, (DCObject) modelingAuditTrailInquiry, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetAuditTrailHeaders()
    {
      return this.GetAuditTrailHeaders((ModelingAuditTrailInquiry) null, (ModelingAuditTrailInquiry_Parameters) null, (ModelingAuditTrailInquiry_Request) null, out ModelingAuditTrailInquiry_Result _);
    }

    public ResultStatus GetAuditTrailHeaders(
      ModelingAuditTrailInquiry modelingAuditTrailInquiry)
    {
      return this.GetAuditTrailHeaders(modelingAuditTrailInquiry, (ModelingAuditTrailInquiry_Parameters) null, (ModelingAuditTrailInquiry_Request) null, out ModelingAuditTrailInquiry_Result _);
    }

    public ResultStatus GetAuditTrailHeaders(
      ModelingAuditTrailInquiry modelingAuditTrailInquiry,
      ModelingAuditTrailInquiry_Request request,
      out ModelingAuditTrailInquiry_Result result)
    {
      return this.GetAuditTrailHeaders(modelingAuditTrailInquiry, (ModelingAuditTrailInquiry_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      ModelingAuditTrailInquiry modelingAuditTrailInquiry,
      ModelingAuditTrailInquiry_Parameters parameters,
      ModelingAuditTrailInquiry_Request request,
      out ModelingAuditTrailInquiry_Result result)
    {
      result = (ModelingAuditTrailInquiry_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) modelingAuditTrailInquiry, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IModelingAuditTrailInquiryService) this._Channel).GetWIPMsgs(this._UserProfile, modelingAuditTrailInquiry, parameters, request, out result) : this.AddMethod((Method) new ModelingAuditTrailInquiryMethod(modelingAuditTrailInquiry, ModelingAuditTrailInquiryMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) modelingAuditTrailInquiry, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((ModelingAuditTrailInquiry) null, (ModelingAuditTrailInquiry_Parameters) null, (ModelingAuditTrailInquiry_Request) null, out ModelingAuditTrailInquiry_Result _);
    }

    public ResultStatus GetWIPMsgs(
      ModelingAuditTrailInquiry modelingAuditTrailInquiry)
    {
      return this.GetWIPMsgs(modelingAuditTrailInquiry, (ModelingAuditTrailInquiry_Parameters) null, (ModelingAuditTrailInquiry_Request) null, out ModelingAuditTrailInquiry_Result _);
    }

    public ResultStatus GetWIPMsgs(
      ModelingAuditTrailInquiry modelingAuditTrailInquiry,
      ModelingAuditTrailInquiry_Request request,
      out ModelingAuditTrailInquiry_Result result)
    {
      return this.GetWIPMsgs(modelingAuditTrailInquiry, (ModelingAuditTrailInquiry_Parameters) null, request, out result);
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject modelingAuditTrailInquiry,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ModelingAuditTrailInquiry_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((ModelingAuditTrailInquiry) modelingAuditTrailInquiry, (ModelingAuditTrailInquiry_Parameters) parameters, (ModelingAuditTrailInquiry_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      ModelingAuditTrailInquiry_Request request,
      out ModelingAuditTrailInquiry_Result result)
    {
      result = (ModelingAuditTrailInquiry_Result) null;
      try
      {
        ModelingAuditTrailInquiryMethod[] methods = new ModelingAuditTrailInquiryMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IModelingAuditTrailInquiryService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        ModelingAuditTrailInquiry_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((ModelingAuditTrailInquiry_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      ModelingAuditTrailInquiry cdo,
      ModelingAuditTrailInquiry_Request request,
      out ModelingAuditTrailInquiry_Result result)
    {
      result = (ModelingAuditTrailInquiry_Result) null;
      try
      {
        return ((IModelingAuditTrailInquiryService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        ModelingAuditTrailInquiry_Result result1;
        ResultStatus environment = this.GetEnvironment((ModelingAuditTrailInquiry) cdo, (ModelingAuditTrailInquiry_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      ModelingAuditTrailInquiry_Request request,
      out ModelingAuditTrailInquiry_Result result)
    {
      return this.GetEnvironment((ModelingAuditTrailInquiry) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      ModelingAuditTrailInquiry cdo,
      ModelingAuditTrailInquiry_Request request,
      out ModelingAuditTrailInquiry_Result result)
    {
      result = (ModelingAuditTrailInquiry_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IModelingAuditTrailInquiryService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new ModelingAuditTrailInquiryMethod(cdo, ModelingAuditTrailInquiryMethods.ExecuteTransaction, (ModelingAuditTrailInquiry_Parameters) null));
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
        ModelingAuditTrailInquiry_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((ModelingAuditTrailInquiry) cdo, (ModelingAuditTrailInquiry_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(ModelingAuditTrailInquiry cdo)
    {
      return this.ExecuteTransaction(cdo, (ModelingAuditTrailInquiry_Request) null, out ModelingAuditTrailInquiry_Result _);
    }

    public ResultStatus ExecuteTransaction(
      ModelingAuditTrailInquiry_Request request,
      out ModelingAuditTrailInquiry_Result result)
    {
      return this.ExecuteTransaction((ModelingAuditTrailInquiry) null, request, out result);
    }

    public ResultStatus AddDataTransaction(ModelingAuditTrailInquiry cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new ModelingAuditTrailInquiryMethod(cdo, ModelingAuditTrailInquiryMethods.AddDataTransaction, (ModelingAuditTrailInquiry_Parameters) null));
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
        return this.AddDataTransaction((ModelingAuditTrailInquiry) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
