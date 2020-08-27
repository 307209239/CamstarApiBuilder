// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.BusinessProcessWorkflowMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class BusinessProcessWorkflowMaintService : RevisionedObjectMaintBase
  {
    public BusinessProcessWorkflowMaintService(UserProfile userProfile)
    {
      this.Initialize(typeof (IBusinessProcessWorkflowMaintService), userProfile);
    }

    public ResultStatus Delete(
      BusinessProcessWorkflowMaint businessProcessWorkflowMaint,
      BusinessProcessWorkflowMaint_Parameters parameters,
      BusinessProcessWorkflowMaint_Request request,
      out BusinessProcessWorkflowMaint_Result result)
    {
      result = (BusinessProcessWorkflowMaint_Result) null;
      this.OnBeforeCall(nameof (Delete), (DCObject) businessProcessWorkflowMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IBusinessProcessWorkflowMaintService) this._Channel).Delete(this._UserProfile, businessProcessWorkflowMaint, parameters, request, out result) : this.AddMethod((Method) new BusinessProcessWorkflowMaintMethod(businessProcessWorkflowMaint, BusinessProcessWorkflowMaintMethods.Delete, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Delete), res, (DCObject) businessProcessWorkflowMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Delete()
    {
      return this.Delete((BusinessProcessWorkflowMaint) null, (BusinessProcessWorkflowMaint_Parameters) null, (BusinessProcessWorkflowMaint_Request) null, out BusinessProcessWorkflowMaint_Result _);
    }

    public ResultStatus Delete(
      BusinessProcessWorkflowMaint businessProcessWorkflowMaint)
    {
      return this.Delete(businessProcessWorkflowMaint, (BusinessProcessWorkflowMaint_Parameters) null, (BusinessProcessWorkflowMaint_Request) null, out BusinessProcessWorkflowMaint_Result _);
    }

    public ResultStatus Delete(
      BusinessProcessWorkflowMaint businessProcessWorkflowMaint,
      BusinessProcessWorkflowMaint_Request request,
      out BusinessProcessWorkflowMaint_Result result)
    {
      return this.Delete(businessProcessWorkflowMaint, (BusinessProcessWorkflowMaint_Parameters) null, request, out result);
    }

    public ResultStatus DeleteAllRevisions(
      BusinessProcessWorkflowMaint businessProcessWorkflowMaint,
      BusinessProcessWorkflowMaint_Parameters parameters,
      BusinessProcessWorkflowMaint_Request request,
      out BusinessProcessWorkflowMaint_Result result)
    {
      result = (BusinessProcessWorkflowMaint_Result) null;
      this.OnBeforeCall(nameof (DeleteAllRevisions), (DCObject) businessProcessWorkflowMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IBusinessProcessWorkflowMaintService) this._Channel).DeleteAllRevisions(this._UserProfile, businessProcessWorkflowMaint, parameters, request, out result) : this.AddMethod((Method) new BusinessProcessWorkflowMaintMethod(businessProcessWorkflowMaint, BusinessProcessWorkflowMaintMethods.DeleteAllRevisions, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (DeleteAllRevisions), res, (DCObject) businessProcessWorkflowMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus DeleteAllRevisions()
    {
      return this.DeleteAllRevisions((BusinessProcessWorkflowMaint) null, (BusinessProcessWorkflowMaint_Parameters) null, (BusinessProcessWorkflowMaint_Request) null, out BusinessProcessWorkflowMaint_Result _);
    }

    public ResultStatus DeleteAllRevisions(
      BusinessProcessWorkflowMaint businessProcessWorkflowMaint)
    {
      return this.DeleteAllRevisions(businessProcessWorkflowMaint, (BusinessProcessWorkflowMaint_Parameters) null, (BusinessProcessWorkflowMaint_Request) null, out BusinessProcessWorkflowMaint_Result _);
    }

    public ResultStatus DeleteAllRevisions(
      BusinessProcessWorkflowMaint businessProcessWorkflowMaint,
      BusinessProcessWorkflowMaint_Request request,
      out BusinessProcessWorkflowMaint_Result result)
    {
      return this.DeleteAllRevisions(businessProcessWorkflowMaint, (BusinessProcessWorkflowMaint_Parameters) null, request, out result);
    }

    public ResultStatus Freeze(
      BusinessProcessWorkflowMaint businessProcessWorkflowMaint,
      BusinessProcessWorkflowMaint_Parameters parameters,
      BusinessProcessWorkflowMaint_Request request,
      out BusinessProcessWorkflowMaint_Result result)
    {
      result = (BusinessProcessWorkflowMaint_Result) null;
      this.OnBeforeCall(nameof (Freeze), (DCObject) businessProcessWorkflowMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IBusinessProcessWorkflowMaintService) this._Channel).Freeze(this._UserProfile, businessProcessWorkflowMaint, parameters, request, out result) : this.AddMethod((Method) new BusinessProcessWorkflowMaintMethod(businessProcessWorkflowMaint, BusinessProcessWorkflowMaintMethods.Freeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Freeze), res, (DCObject) businessProcessWorkflowMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Freeze()
    {
      return this.Freeze((BusinessProcessWorkflowMaint) null, (BusinessProcessWorkflowMaint_Parameters) null, (BusinessProcessWorkflowMaint_Request) null, out BusinessProcessWorkflowMaint_Result _);
    }

    public ResultStatus Freeze(
      BusinessProcessWorkflowMaint businessProcessWorkflowMaint)
    {
      return this.Freeze(businessProcessWorkflowMaint, (BusinessProcessWorkflowMaint_Parameters) null, (BusinessProcessWorkflowMaint_Request) null, out BusinessProcessWorkflowMaint_Result _);
    }

    public ResultStatus Freeze(
      BusinessProcessWorkflowMaint businessProcessWorkflowMaint,
      BusinessProcessWorkflowMaint_Request request,
      out BusinessProcessWorkflowMaint_Result result)
    {
      return this.Freeze(businessProcessWorkflowMaint, (BusinessProcessWorkflowMaint_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      BusinessProcessWorkflowMaint businessProcessWorkflowMaint,
      BusinessProcessWorkflowMaint_Parameters parameters,
      BusinessProcessWorkflowMaint_Request request,
      out BusinessProcessWorkflowMaint_Result result)
    {
      result = (BusinessProcessWorkflowMaint_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) businessProcessWorkflowMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IBusinessProcessWorkflowMaintService) this._Channel).GetWIPMsgs(this._UserProfile, businessProcessWorkflowMaint, parameters, request, out result) : this.AddMethod((Method) new BusinessProcessWorkflowMaintMethod(businessProcessWorkflowMaint, BusinessProcessWorkflowMaintMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) businessProcessWorkflowMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((BusinessProcessWorkflowMaint) null, (BusinessProcessWorkflowMaint_Parameters) null, (BusinessProcessWorkflowMaint_Request) null, out BusinessProcessWorkflowMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(
      BusinessProcessWorkflowMaint businessProcessWorkflowMaint)
    {
      return this.GetWIPMsgs(businessProcessWorkflowMaint, (BusinessProcessWorkflowMaint_Parameters) null, (BusinessProcessWorkflowMaint_Request) null, out BusinessProcessWorkflowMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(
      BusinessProcessWorkflowMaint businessProcessWorkflowMaint,
      BusinessProcessWorkflowMaint_Request request,
      out BusinessProcessWorkflowMaint_Result result)
    {
      return this.GetWIPMsgs(businessProcessWorkflowMaint, (BusinessProcessWorkflowMaint_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      BusinessProcessWorkflowMaint businessProcessWorkflowMaint,
      BusinessProcessWorkflowMaint_Parameters parameters,
      BusinessProcessWorkflowMaint_Request request,
      out BusinessProcessWorkflowMaint_Result result)
    {
      result = (BusinessProcessWorkflowMaint_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) businessProcessWorkflowMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IBusinessProcessWorkflowMaintService) this._Channel).Load(this._UserProfile, businessProcessWorkflowMaint, parameters, request, out result) : this.AddMethod((Method) new BusinessProcessWorkflowMaintMethod(businessProcessWorkflowMaint, BusinessProcessWorkflowMaintMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) businessProcessWorkflowMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((BusinessProcessWorkflowMaint) null, (BusinessProcessWorkflowMaint_Parameters) null, (BusinessProcessWorkflowMaint_Request) null, out BusinessProcessWorkflowMaint_Result _);
    }

    public ResultStatus Load(
      BusinessProcessWorkflowMaint businessProcessWorkflowMaint)
    {
      return this.Load(businessProcessWorkflowMaint, (BusinessProcessWorkflowMaint_Parameters) null, (BusinessProcessWorkflowMaint_Request) null, out BusinessProcessWorkflowMaint_Result _);
    }

    public ResultStatus Load(
      BusinessProcessWorkflowMaint businessProcessWorkflowMaint,
      BusinessProcessWorkflowMaint_Request request,
      out BusinessProcessWorkflowMaint_Result result)
    {
      return this.Load(businessProcessWorkflowMaint, (BusinessProcessWorkflowMaint_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      BusinessProcessWorkflowMaint businessProcessWorkflowMaint,
      BusinessProcessWorkflowMaint_LoadESigDetails_Parameters parameters,
      BusinessProcessWorkflowMaint_Request request,
      out BusinessProcessWorkflowMaint_Result result)
    {
      result = (BusinessProcessWorkflowMaint_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) businessProcessWorkflowMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IBusinessProcessWorkflowMaintService) this._Channel).LoadESigDetails(this._UserProfile, businessProcessWorkflowMaint, parameters, request, out result) : this.AddMethod((Method) new BusinessProcessWorkflowMaintMethod(businessProcessWorkflowMaint, BusinessProcessWorkflowMaintMethods.LoadESigDetails, (BusinessProcessWorkflowMaint_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) businessProcessWorkflowMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((BusinessProcessWorkflowMaint) null, (BusinessProcessWorkflowMaint_LoadESigDetails_Parameters) null, (BusinessProcessWorkflowMaint_Request) null, out BusinessProcessWorkflowMaint_Result _);
    }

    public ResultStatus LoadESigDetails(
      BusinessProcessWorkflowMaint businessProcessWorkflowMaint)
    {
      return this.LoadESigDetails(businessProcessWorkflowMaint, (BusinessProcessWorkflowMaint_LoadESigDetails_Parameters) null, (BusinessProcessWorkflowMaint_Request) null, out BusinessProcessWorkflowMaint_Result _);
    }

    public ResultStatus LoadESigDetails(
      BusinessProcessWorkflowMaint businessProcessWorkflowMaint,
      BusinessProcessWorkflowMaint_Request request,
      out BusinessProcessWorkflowMaint_Result result)
    {
      return this.LoadESigDetails(businessProcessWorkflowMaint, (BusinessProcessWorkflowMaint_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus New(
      BusinessProcessWorkflowMaint businessProcessWorkflowMaint,
      BusinessProcessWorkflowMaint_Parameters parameters,
      BusinessProcessWorkflowMaint_Request request,
      out BusinessProcessWorkflowMaint_Result result)
    {
      result = (BusinessProcessWorkflowMaint_Result) null;
      this.OnBeforeCall(nameof (New), (DCObject) businessProcessWorkflowMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IBusinessProcessWorkflowMaintService) this._Channel).New(this._UserProfile, businessProcessWorkflowMaint, parameters, request, out result) : this.AddMethod((Method) new BusinessProcessWorkflowMaintMethod(businessProcessWorkflowMaint, BusinessProcessWorkflowMaintMethods.New, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (New), res, (DCObject) businessProcessWorkflowMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus New()
    {
      return this.New((BusinessProcessWorkflowMaint) null, (BusinessProcessWorkflowMaint_Parameters) null, (BusinessProcessWorkflowMaint_Request) null, out BusinessProcessWorkflowMaint_Result _);
    }

    public ResultStatus New(
      BusinessProcessWorkflowMaint businessProcessWorkflowMaint)
    {
      return this.New(businessProcessWorkflowMaint, (BusinessProcessWorkflowMaint_Parameters) null, (BusinessProcessWorkflowMaint_Request) null, out BusinessProcessWorkflowMaint_Result _);
    }

    public ResultStatus New(
      BusinessProcessWorkflowMaint businessProcessWorkflowMaint,
      BusinessProcessWorkflowMaint_Request request,
      out BusinessProcessWorkflowMaint_Result result)
    {
      return this.New(businessProcessWorkflowMaint, (BusinessProcessWorkflowMaint_Parameters) null, request, out result);
    }

    public ResultStatus NewCopy(
      BusinessProcessWorkflowMaint businessProcessWorkflowMaint,
      BusinessProcessWorkflowMaint_Parameters parameters,
      BusinessProcessWorkflowMaint_Request request,
      out BusinessProcessWorkflowMaint_Result result)
    {
      result = (BusinessProcessWorkflowMaint_Result) null;
      this.OnBeforeCall(nameof (NewCopy), (DCObject) businessProcessWorkflowMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IBusinessProcessWorkflowMaintService) this._Channel).NewCopy(this._UserProfile, businessProcessWorkflowMaint, parameters, request, out result) : this.AddMethod((Method) new BusinessProcessWorkflowMaintMethod(businessProcessWorkflowMaint, BusinessProcessWorkflowMaintMethods.NewCopy, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (NewCopy), res, (DCObject) businessProcessWorkflowMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus NewCopy()
    {
      return this.NewCopy((BusinessProcessWorkflowMaint) null, (BusinessProcessWorkflowMaint_Parameters) null, (BusinessProcessWorkflowMaint_Request) null, out BusinessProcessWorkflowMaint_Result _);
    }

    public ResultStatus NewCopy(
      BusinessProcessWorkflowMaint businessProcessWorkflowMaint)
    {
      return this.NewCopy(businessProcessWorkflowMaint, (BusinessProcessWorkflowMaint_Parameters) null, (BusinessProcessWorkflowMaint_Request) null, out BusinessProcessWorkflowMaint_Result _);
    }

    public ResultStatus NewCopy(
      BusinessProcessWorkflowMaint businessProcessWorkflowMaint,
      BusinessProcessWorkflowMaint_Request request,
      out BusinessProcessWorkflowMaint_Result result)
    {
      return this.NewCopy(businessProcessWorkflowMaint, (BusinessProcessWorkflowMaint_Parameters) null, request, out result);
    }

    public ResultStatus NewRev(
      BusinessProcessWorkflowMaint businessProcessWorkflowMaint,
      BusinessProcessWorkflowMaint_Parameters parameters,
      BusinessProcessWorkflowMaint_Request request,
      out BusinessProcessWorkflowMaint_Result result)
    {
      result = (BusinessProcessWorkflowMaint_Result) null;
      this.OnBeforeCall(nameof (NewRev), (DCObject) businessProcessWorkflowMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IBusinessProcessWorkflowMaintService) this._Channel).NewRev(this._UserProfile, businessProcessWorkflowMaint, parameters, request, out result) : this.AddMethod((Method) new BusinessProcessWorkflowMaintMethod(businessProcessWorkflowMaint, BusinessProcessWorkflowMaintMethods.NewRev, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (NewRev), res, (DCObject) businessProcessWorkflowMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus NewRev()
    {
      return this.NewRev((BusinessProcessWorkflowMaint) null, (BusinessProcessWorkflowMaint_Parameters) null, (BusinessProcessWorkflowMaint_Request) null, out BusinessProcessWorkflowMaint_Result _);
    }

    public ResultStatus NewRev(
      BusinessProcessWorkflowMaint businessProcessWorkflowMaint)
    {
      return this.NewRev(businessProcessWorkflowMaint, (BusinessProcessWorkflowMaint_Parameters) null, (BusinessProcessWorkflowMaint_Request) null, out BusinessProcessWorkflowMaint_Result _);
    }

    public ResultStatus NewRev(
      BusinessProcessWorkflowMaint businessProcessWorkflowMaint,
      BusinessProcessWorkflowMaint_Request request,
      out BusinessProcessWorkflowMaint_Result result)
    {
      return this.NewRev(businessProcessWorkflowMaint, (BusinessProcessWorkflowMaint_Parameters) null, request, out result);
    }

    public ResultStatus NewRevCopy(
      BusinessProcessWorkflowMaint businessProcessWorkflowMaint,
      BusinessProcessWorkflowMaint_Parameters parameters,
      BusinessProcessWorkflowMaint_Request request,
      out BusinessProcessWorkflowMaint_Result result)
    {
      result = (BusinessProcessWorkflowMaint_Result) null;
      this.OnBeforeCall(nameof (NewRevCopy), (DCObject) businessProcessWorkflowMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IBusinessProcessWorkflowMaintService) this._Channel).NewRevCopy(this._UserProfile, businessProcessWorkflowMaint, parameters, request, out result) : this.AddMethod((Method) new BusinessProcessWorkflowMaintMethod(businessProcessWorkflowMaint, BusinessProcessWorkflowMaintMethods.NewRevCopy, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (NewRevCopy), res, (DCObject) businessProcessWorkflowMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus NewRevCopy()
    {
      return this.NewRevCopy((BusinessProcessWorkflowMaint) null, (BusinessProcessWorkflowMaint_Parameters) null, (BusinessProcessWorkflowMaint_Request) null, out BusinessProcessWorkflowMaint_Result _);
    }

    public ResultStatus NewRevCopy(
      BusinessProcessWorkflowMaint businessProcessWorkflowMaint)
    {
      return this.NewRevCopy(businessProcessWorkflowMaint, (BusinessProcessWorkflowMaint_Parameters) null, (BusinessProcessWorkflowMaint_Request) null, out BusinessProcessWorkflowMaint_Result _);
    }

    public ResultStatus NewRevCopy(
      BusinessProcessWorkflowMaint businessProcessWorkflowMaint,
      BusinessProcessWorkflowMaint_Request request,
      out BusinessProcessWorkflowMaint_Result result)
    {
      return this.NewRevCopy(businessProcessWorkflowMaint, (BusinessProcessWorkflowMaint_Parameters) null, request, out result);
    }

    public ResultStatus SaveAs(
      BusinessProcessWorkflowMaint businessProcessWorkflowMaint,
      BusinessProcessWorkflowMaint_Parameters parameters,
      BusinessProcessWorkflowMaint_Request request,
      out BusinessProcessWorkflowMaint_Result result)
    {
      result = (BusinessProcessWorkflowMaint_Result) null;
      this.OnBeforeCall(nameof (SaveAs), (DCObject) businessProcessWorkflowMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IBusinessProcessWorkflowMaintService) this._Channel).SaveAs(this._UserProfile, businessProcessWorkflowMaint, parameters, request, out result) : this.AddMethod((Method) new BusinessProcessWorkflowMaintMethod(businessProcessWorkflowMaint, BusinessProcessWorkflowMaintMethods.SaveAs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SaveAs), res, (DCObject) businessProcessWorkflowMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SaveAs()
    {
      return this.SaveAs((BusinessProcessWorkflowMaint) null, (BusinessProcessWorkflowMaint_Parameters) null, (BusinessProcessWorkflowMaint_Request) null, out BusinessProcessWorkflowMaint_Result _);
    }

    public ResultStatus SaveAs(
      BusinessProcessWorkflowMaint businessProcessWorkflowMaint)
    {
      return this.SaveAs(businessProcessWorkflowMaint, (BusinessProcessWorkflowMaint_Parameters) null, (BusinessProcessWorkflowMaint_Request) null, out BusinessProcessWorkflowMaint_Result _);
    }

    public ResultStatus SaveAs(
      BusinessProcessWorkflowMaint businessProcessWorkflowMaint,
      BusinessProcessWorkflowMaint_Request request,
      out BusinessProcessWorkflowMaint_Result result)
    {
      return this.SaveAs(businessProcessWorkflowMaint, (BusinessProcessWorkflowMaint_Parameters) null, request, out result);
    }

    public ResultStatus SaveAsRev(
      BusinessProcessWorkflowMaint businessProcessWorkflowMaint,
      BusinessProcessWorkflowMaint_Parameters parameters,
      BusinessProcessWorkflowMaint_Request request,
      out BusinessProcessWorkflowMaint_Result result)
    {
      result = (BusinessProcessWorkflowMaint_Result) null;
      this.OnBeforeCall(nameof (SaveAsRev), (DCObject) businessProcessWorkflowMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IBusinessProcessWorkflowMaintService) this._Channel).SaveAsRev(this._UserProfile, businessProcessWorkflowMaint, parameters, request, out result) : this.AddMethod((Method) new BusinessProcessWorkflowMaintMethod(businessProcessWorkflowMaint, BusinessProcessWorkflowMaintMethods.SaveAsRev, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SaveAsRev), res, (DCObject) businessProcessWorkflowMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SaveAsRev()
    {
      return this.SaveAsRev((BusinessProcessWorkflowMaint) null, (BusinessProcessWorkflowMaint_Parameters) null, (BusinessProcessWorkflowMaint_Request) null, out BusinessProcessWorkflowMaint_Result _);
    }

    public ResultStatus SaveAsRev(
      BusinessProcessWorkflowMaint businessProcessWorkflowMaint)
    {
      return this.SaveAsRev(businessProcessWorkflowMaint, (BusinessProcessWorkflowMaint_Parameters) null, (BusinessProcessWorkflowMaint_Request) null, out BusinessProcessWorkflowMaint_Result _);
    }

    public ResultStatus SaveAsRev(
      BusinessProcessWorkflowMaint businessProcessWorkflowMaint,
      BusinessProcessWorkflowMaint_Request request,
      out BusinessProcessWorkflowMaint_Result result)
    {
      return this.SaveAsRev(businessProcessWorkflowMaint, (BusinessProcessWorkflowMaint_Parameters) null, request, out result);
    }

    public ResultStatus UnFreeze(
      BusinessProcessWorkflowMaint businessProcessWorkflowMaint,
      BusinessProcessWorkflowMaint_Parameters parameters,
      BusinessProcessWorkflowMaint_Request request,
      out BusinessProcessWorkflowMaint_Result result)
    {
      result = (BusinessProcessWorkflowMaint_Result) null;
      this.OnBeforeCall(nameof (UnFreeze), (DCObject) businessProcessWorkflowMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IBusinessProcessWorkflowMaintService) this._Channel).UnFreeze(this._UserProfile, businessProcessWorkflowMaint, parameters, request, out result) : this.AddMethod((Method) new BusinessProcessWorkflowMaintMethod(businessProcessWorkflowMaint, BusinessProcessWorkflowMaintMethods.UnFreeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (UnFreeze), res, (DCObject) businessProcessWorkflowMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus UnFreeze()
    {
      return this.UnFreeze((BusinessProcessWorkflowMaint) null, (BusinessProcessWorkflowMaint_Parameters) null, (BusinessProcessWorkflowMaint_Request) null, out BusinessProcessWorkflowMaint_Result _);
    }

    public ResultStatus UnFreeze(
      BusinessProcessWorkflowMaint businessProcessWorkflowMaint)
    {
      return this.UnFreeze(businessProcessWorkflowMaint, (BusinessProcessWorkflowMaint_Parameters) null, (BusinessProcessWorkflowMaint_Request) null, out BusinessProcessWorkflowMaint_Result _);
    }

    public ResultStatus UnFreeze(
      BusinessProcessWorkflowMaint businessProcessWorkflowMaint,
      BusinessProcessWorkflowMaint_Request request,
      out BusinessProcessWorkflowMaint_Result result)
    {
      return this.UnFreeze(businessProcessWorkflowMaint, (BusinessProcessWorkflowMaint_Parameters) null, request, out result);
    }

    protected override ResultStatus OnDeleteAllRevisions(
      DCObject businessProcessWorkflowMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        BusinessProcessWorkflowMaint_Result result1;
        ResultStatus resultStatus = this.DeleteAllRevisions((BusinessProcessWorkflowMaint) businessProcessWorkflowMaint, (BusinessProcessWorkflowMaint_Parameters) parameters, (BusinessProcessWorkflowMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNewRev(
      DCObject businessProcessWorkflowMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        BusinessProcessWorkflowMaint_Result result1;
        ResultStatus resultStatus = this.NewRev((BusinessProcessWorkflowMaint) businessProcessWorkflowMaint, (BusinessProcessWorkflowMaint_Parameters) parameters, (BusinessProcessWorkflowMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNewRevCopy(
      DCObject businessProcessWorkflowMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        BusinessProcessWorkflowMaint_Result result1;
        ResultStatus resultStatus = this.NewRevCopy((BusinessProcessWorkflowMaint) businessProcessWorkflowMaint, (BusinessProcessWorkflowMaint_Parameters) parameters, (BusinessProcessWorkflowMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnSaveAsRev(
      DCObject businessProcessWorkflowMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        BusinessProcessWorkflowMaint_Result result1;
        ResultStatus resultStatus = this.SaveAsRev((BusinessProcessWorkflowMaint) businessProcessWorkflowMaint, (BusinessProcessWorkflowMaint_Parameters) parameters, (BusinessProcessWorkflowMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnDelete(
      DCObject businessProcessWorkflowMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        BusinessProcessWorkflowMaint_Result result1;
        ResultStatus resultStatus = this.Delete((BusinessProcessWorkflowMaint) businessProcessWorkflowMaint, (BusinessProcessWorkflowMaint_Parameters) parameters, (BusinessProcessWorkflowMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnFreeze(
      DCObject businessProcessWorkflowMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        BusinessProcessWorkflowMaint_Result result1;
        ResultStatus resultStatus = this.Freeze((BusinessProcessWorkflowMaint) businessProcessWorkflowMaint, (BusinessProcessWorkflowMaint_Parameters) parameters, (BusinessProcessWorkflowMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject businessProcessWorkflowMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        BusinessProcessWorkflowMaint_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((BusinessProcessWorkflowMaint) businessProcessWorkflowMaint, (BusinessProcessWorkflowMaint_LoadESigDetails_Parameters) parameters, (BusinessProcessWorkflowMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNew(
      DCObject businessProcessWorkflowMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        BusinessProcessWorkflowMaint_Result result1;
        ResultStatus resultStatus = this.New((BusinessProcessWorkflowMaint) businessProcessWorkflowMaint, (BusinessProcessWorkflowMaint_Parameters) parameters, (BusinessProcessWorkflowMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNewCopy(
      DCObject businessProcessWorkflowMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        BusinessProcessWorkflowMaint_Result result1;
        ResultStatus resultStatus = this.NewCopy((BusinessProcessWorkflowMaint) businessProcessWorkflowMaint, (BusinessProcessWorkflowMaint_Parameters) parameters, (BusinessProcessWorkflowMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnSaveAs(
      DCObject businessProcessWorkflowMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        BusinessProcessWorkflowMaint_Result result1;
        ResultStatus resultStatus = this.SaveAs((BusinessProcessWorkflowMaint) businessProcessWorkflowMaint, (BusinessProcessWorkflowMaint_Parameters) parameters, (BusinessProcessWorkflowMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnUnFreeze(
      DCObject businessProcessWorkflowMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        BusinessProcessWorkflowMaint_Result result1;
        ResultStatus resultStatus = this.UnFreeze((BusinessProcessWorkflowMaint) businessProcessWorkflowMaint, (BusinessProcessWorkflowMaint_Parameters) parameters, (BusinessProcessWorkflowMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject businessProcessWorkflowMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        BusinessProcessWorkflowMaint_Result result1;
        ResultStatus resultStatus = this.Load((BusinessProcessWorkflowMaint) businessProcessWorkflowMaint, (BusinessProcessWorkflowMaint_Parameters) parameters, (BusinessProcessWorkflowMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject businessProcessWorkflowMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        BusinessProcessWorkflowMaint_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((BusinessProcessWorkflowMaint) businessProcessWorkflowMaint, (BusinessProcessWorkflowMaint_Parameters) parameters, (BusinessProcessWorkflowMaint_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      BusinessProcessWorkflowMaint_Request request,
      out BusinessProcessWorkflowMaint_Result result)
    {
      result = (BusinessProcessWorkflowMaint_Result) null;
      try
      {
        BusinessProcessWorkflowMaintMethod[] methods = new BusinessProcessWorkflowMaintMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IBusinessProcessWorkflowMaintService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        BusinessProcessWorkflowMaint_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((BusinessProcessWorkflowMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      BusinessProcessWorkflowMaint cdo,
      BusinessProcessWorkflowMaint_Request request,
      out BusinessProcessWorkflowMaint_Result result)
    {
      result = (BusinessProcessWorkflowMaint_Result) null;
      try
      {
        return ((IBusinessProcessWorkflowMaintService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        BusinessProcessWorkflowMaint_Result result1;
        ResultStatus environment = this.GetEnvironment((BusinessProcessWorkflowMaint) cdo, (BusinessProcessWorkflowMaint_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      BusinessProcessWorkflowMaint_Request request,
      out BusinessProcessWorkflowMaint_Result result)
    {
      return this.GetEnvironment((BusinessProcessWorkflowMaint) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      BusinessProcessWorkflowMaint cdo,
      BusinessProcessWorkflowMaint_Request request,
      out BusinessProcessWorkflowMaint_Result result)
    {
      result = (BusinessProcessWorkflowMaint_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IBusinessProcessWorkflowMaintService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new BusinessProcessWorkflowMaintMethod(cdo, BusinessProcessWorkflowMaintMethods.ExecuteTransaction, (BusinessProcessWorkflowMaint_Parameters) null));
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
        BusinessProcessWorkflowMaint_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((BusinessProcessWorkflowMaint) cdo, (BusinessProcessWorkflowMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(BusinessProcessWorkflowMaint cdo)
    {
      return this.ExecuteTransaction(cdo, (BusinessProcessWorkflowMaint_Request) null, out BusinessProcessWorkflowMaint_Result _);
    }

    public ResultStatus ExecuteTransaction(
      BusinessProcessWorkflowMaint_Request request,
      out BusinessProcessWorkflowMaint_Result result)
    {
      return this.ExecuteTransaction((BusinessProcessWorkflowMaint) null, request, out result);
    }

    public ResultStatus AddDataTransaction(BusinessProcessWorkflowMaint cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new BusinessProcessWorkflowMaintMethod(cdo, BusinessProcessWorkflowMaintMethods.AddDataTransaction, (BusinessProcessWorkflowMaint_Parameters) null));
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
        return this.AddDataTransaction((BusinessProcessWorkflowMaint) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
