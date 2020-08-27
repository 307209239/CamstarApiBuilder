// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.BusinessProcessSpecMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class BusinessProcessSpecMaintService : RevisionedObjectMaintBase
  {
    public BusinessProcessSpecMaintService(UserProfile userProfile)
    {
      this.Initialize(typeof (IBusinessProcessSpecMaintService), userProfile);
    }

    public ResultStatus Delete(
      BusinessProcessSpecMaint businessProcessSpecMaint,
      BusinessProcessSpecMaint_Parameters parameters,
      BusinessProcessSpecMaint_Request request,
      out BusinessProcessSpecMaint_Result result)
    {
      result = (BusinessProcessSpecMaint_Result) null;
      this.OnBeforeCall(nameof (Delete), (DCObject) businessProcessSpecMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IBusinessProcessSpecMaintService) this._Channel).Delete(this._UserProfile, businessProcessSpecMaint, parameters, request, out result) : this.AddMethod((Method) new BusinessProcessSpecMaintMethod(businessProcessSpecMaint, BusinessProcessSpecMaintMethods.Delete, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Delete), res, (DCObject) businessProcessSpecMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Delete()
    {
      return this.Delete((BusinessProcessSpecMaint) null, (BusinessProcessSpecMaint_Parameters) null, (BusinessProcessSpecMaint_Request) null, out BusinessProcessSpecMaint_Result _);
    }

    public ResultStatus Delete(BusinessProcessSpecMaint businessProcessSpecMaint)
    {
      return this.Delete(businessProcessSpecMaint, (BusinessProcessSpecMaint_Parameters) null, (BusinessProcessSpecMaint_Request) null, out BusinessProcessSpecMaint_Result _);
    }

    public ResultStatus Delete(
      BusinessProcessSpecMaint businessProcessSpecMaint,
      BusinessProcessSpecMaint_Request request,
      out BusinessProcessSpecMaint_Result result)
    {
      return this.Delete(businessProcessSpecMaint, (BusinessProcessSpecMaint_Parameters) null, request, out result);
    }

    public ResultStatus DeleteAllRevisions(
      BusinessProcessSpecMaint businessProcessSpecMaint,
      BusinessProcessSpecMaint_Parameters parameters,
      BusinessProcessSpecMaint_Request request,
      out BusinessProcessSpecMaint_Result result)
    {
      result = (BusinessProcessSpecMaint_Result) null;
      this.OnBeforeCall(nameof (DeleteAllRevisions), (DCObject) businessProcessSpecMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IBusinessProcessSpecMaintService) this._Channel).DeleteAllRevisions(this._UserProfile, businessProcessSpecMaint, parameters, request, out result) : this.AddMethod((Method) new BusinessProcessSpecMaintMethod(businessProcessSpecMaint, BusinessProcessSpecMaintMethods.DeleteAllRevisions, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (DeleteAllRevisions), res, (DCObject) businessProcessSpecMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus DeleteAllRevisions()
    {
      return this.DeleteAllRevisions((BusinessProcessSpecMaint) null, (BusinessProcessSpecMaint_Parameters) null, (BusinessProcessSpecMaint_Request) null, out BusinessProcessSpecMaint_Result _);
    }

    public ResultStatus DeleteAllRevisions(
      BusinessProcessSpecMaint businessProcessSpecMaint)
    {
      return this.DeleteAllRevisions(businessProcessSpecMaint, (BusinessProcessSpecMaint_Parameters) null, (BusinessProcessSpecMaint_Request) null, out BusinessProcessSpecMaint_Result _);
    }

    public ResultStatus DeleteAllRevisions(
      BusinessProcessSpecMaint businessProcessSpecMaint,
      BusinessProcessSpecMaint_Request request,
      out BusinessProcessSpecMaint_Result result)
    {
      return this.DeleteAllRevisions(businessProcessSpecMaint, (BusinessProcessSpecMaint_Parameters) null, request, out result);
    }

    public ResultStatus Freeze(
      BusinessProcessSpecMaint businessProcessSpecMaint,
      BusinessProcessSpecMaint_Parameters parameters,
      BusinessProcessSpecMaint_Request request,
      out BusinessProcessSpecMaint_Result result)
    {
      result = (BusinessProcessSpecMaint_Result) null;
      this.OnBeforeCall(nameof (Freeze), (DCObject) businessProcessSpecMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IBusinessProcessSpecMaintService) this._Channel).Freeze(this._UserProfile, businessProcessSpecMaint, parameters, request, out result) : this.AddMethod((Method) new BusinessProcessSpecMaintMethod(businessProcessSpecMaint, BusinessProcessSpecMaintMethods.Freeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Freeze), res, (DCObject) businessProcessSpecMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Freeze()
    {
      return this.Freeze((BusinessProcessSpecMaint) null, (BusinessProcessSpecMaint_Parameters) null, (BusinessProcessSpecMaint_Request) null, out BusinessProcessSpecMaint_Result _);
    }

    public ResultStatus Freeze(BusinessProcessSpecMaint businessProcessSpecMaint)
    {
      return this.Freeze(businessProcessSpecMaint, (BusinessProcessSpecMaint_Parameters) null, (BusinessProcessSpecMaint_Request) null, out BusinessProcessSpecMaint_Result _);
    }

    public ResultStatus Freeze(
      BusinessProcessSpecMaint businessProcessSpecMaint,
      BusinessProcessSpecMaint_Request request,
      out BusinessProcessSpecMaint_Result result)
    {
      return this.Freeze(businessProcessSpecMaint, (BusinessProcessSpecMaint_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      BusinessProcessSpecMaint businessProcessSpecMaint,
      BusinessProcessSpecMaint_Parameters parameters,
      BusinessProcessSpecMaint_Request request,
      out BusinessProcessSpecMaint_Result result)
    {
      result = (BusinessProcessSpecMaint_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) businessProcessSpecMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IBusinessProcessSpecMaintService) this._Channel).GetWIPMsgs(this._UserProfile, businessProcessSpecMaint, parameters, request, out result) : this.AddMethod((Method) new BusinessProcessSpecMaintMethod(businessProcessSpecMaint, BusinessProcessSpecMaintMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) businessProcessSpecMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((BusinessProcessSpecMaint) null, (BusinessProcessSpecMaint_Parameters) null, (BusinessProcessSpecMaint_Request) null, out BusinessProcessSpecMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(BusinessProcessSpecMaint businessProcessSpecMaint)
    {
      return this.GetWIPMsgs(businessProcessSpecMaint, (BusinessProcessSpecMaint_Parameters) null, (BusinessProcessSpecMaint_Request) null, out BusinessProcessSpecMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(
      BusinessProcessSpecMaint businessProcessSpecMaint,
      BusinessProcessSpecMaint_Request request,
      out BusinessProcessSpecMaint_Result result)
    {
      return this.GetWIPMsgs(businessProcessSpecMaint, (BusinessProcessSpecMaint_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      BusinessProcessSpecMaint businessProcessSpecMaint,
      BusinessProcessSpecMaint_Parameters parameters,
      BusinessProcessSpecMaint_Request request,
      out BusinessProcessSpecMaint_Result result)
    {
      result = (BusinessProcessSpecMaint_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) businessProcessSpecMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IBusinessProcessSpecMaintService) this._Channel).Load(this._UserProfile, businessProcessSpecMaint, parameters, request, out result) : this.AddMethod((Method) new BusinessProcessSpecMaintMethod(businessProcessSpecMaint, BusinessProcessSpecMaintMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) businessProcessSpecMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((BusinessProcessSpecMaint) null, (BusinessProcessSpecMaint_Parameters) null, (BusinessProcessSpecMaint_Request) null, out BusinessProcessSpecMaint_Result _);
    }

    public ResultStatus Load(BusinessProcessSpecMaint businessProcessSpecMaint)
    {
      return this.Load(businessProcessSpecMaint, (BusinessProcessSpecMaint_Parameters) null, (BusinessProcessSpecMaint_Request) null, out BusinessProcessSpecMaint_Result _);
    }

    public ResultStatus Load(
      BusinessProcessSpecMaint businessProcessSpecMaint,
      BusinessProcessSpecMaint_Request request,
      out BusinessProcessSpecMaint_Result result)
    {
      return this.Load(businessProcessSpecMaint, (BusinessProcessSpecMaint_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      BusinessProcessSpecMaint businessProcessSpecMaint,
      BusinessProcessSpecMaint_LoadESigDetails_Parameters parameters,
      BusinessProcessSpecMaint_Request request,
      out BusinessProcessSpecMaint_Result result)
    {
      result = (BusinessProcessSpecMaint_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) businessProcessSpecMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IBusinessProcessSpecMaintService) this._Channel).LoadESigDetails(this._UserProfile, businessProcessSpecMaint, parameters, request, out result) : this.AddMethod((Method) new BusinessProcessSpecMaintMethod(businessProcessSpecMaint, BusinessProcessSpecMaintMethods.LoadESigDetails, (BusinessProcessSpecMaint_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) businessProcessSpecMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((BusinessProcessSpecMaint) null, (BusinessProcessSpecMaint_LoadESigDetails_Parameters) null, (BusinessProcessSpecMaint_Request) null, out BusinessProcessSpecMaint_Result _);
    }

    public ResultStatus LoadESigDetails(
      BusinessProcessSpecMaint businessProcessSpecMaint)
    {
      return this.LoadESigDetails(businessProcessSpecMaint, (BusinessProcessSpecMaint_LoadESigDetails_Parameters) null, (BusinessProcessSpecMaint_Request) null, out BusinessProcessSpecMaint_Result _);
    }

    public ResultStatus LoadESigDetails(
      BusinessProcessSpecMaint businessProcessSpecMaint,
      BusinessProcessSpecMaint_Request request,
      out BusinessProcessSpecMaint_Result result)
    {
      return this.LoadESigDetails(businessProcessSpecMaint, (BusinessProcessSpecMaint_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus New(
      BusinessProcessSpecMaint businessProcessSpecMaint,
      BusinessProcessSpecMaint_Parameters parameters,
      BusinessProcessSpecMaint_Request request,
      out BusinessProcessSpecMaint_Result result)
    {
      result = (BusinessProcessSpecMaint_Result) null;
      this.OnBeforeCall(nameof (New), (DCObject) businessProcessSpecMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IBusinessProcessSpecMaintService) this._Channel).New(this._UserProfile, businessProcessSpecMaint, parameters, request, out result) : this.AddMethod((Method) new BusinessProcessSpecMaintMethod(businessProcessSpecMaint, BusinessProcessSpecMaintMethods.New, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (New), res, (DCObject) businessProcessSpecMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus New()
    {
      return this.New((BusinessProcessSpecMaint) null, (BusinessProcessSpecMaint_Parameters) null, (BusinessProcessSpecMaint_Request) null, out BusinessProcessSpecMaint_Result _);
    }

    public ResultStatus New(BusinessProcessSpecMaint businessProcessSpecMaint)
    {
      return this.New(businessProcessSpecMaint, (BusinessProcessSpecMaint_Parameters) null, (BusinessProcessSpecMaint_Request) null, out BusinessProcessSpecMaint_Result _);
    }

    public ResultStatus New(
      BusinessProcessSpecMaint businessProcessSpecMaint,
      BusinessProcessSpecMaint_Request request,
      out BusinessProcessSpecMaint_Result result)
    {
      return this.New(businessProcessSpecMaint, (BusinessProcessSpecMaint_Parameters) null, request, out result);
    }

    public ResultStatus NewCopy(
      BusinessProcessSpecMaint businessProcessSpecMaint,
      BusinessProcessSpecMaint_Parameters parameters,
      BusinessProcessSpecMaint_Request request,
      out BusinessProcessSpecMaint_Result result)
    {
      result = (BusinessProcessSpecMaint_Result) null;
      this.OnBeforeCall(nameof (NewCopy), (DCObject) businessProcessSpecMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IBusinessProcessSpecMaintService) this._Channel).NewCopy(this._UserProfile, businessProcessSpecMaint, parameters, request, out result) : this.AddMethod((Method) new BusinessProcessSpecMaintMethod(businessProcessSpecMaint, BusinessProcessSpecMaintMethods.NewCopy, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (NewCopy), res, (DCObject) businessProcessSpecMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus NewCopy()
    {
      return this.NewCopy((BusinessProcessSpecMaint) null, (BusinessProcessSpecMaint_Parameters) null, (BusinessProcessSpecMaint_Request) null, out BusinessProcessSpecMaint_Result _);
    }

    public ResultStatus NewCopy(BusinessProcessSpecMaint businessProcessSpecMaint)
    {
      return this.NewCopy(businessProcessSpecMaint, (BusinessProcessSpecMaint_Parameters) null, (BusinessProcessSpecMaint_Request) null, out BusinessProcessSpecMaint_Result _);
    }

    public ResultStatus NewCopy(
      BusinessProcessSpecMaint businessProcessSpecMaint,
      BusinessProcessSpecMaint_Request request,
      out BusinessProcessSpecMaint_Result result)
    {
      return this.NewCopy(businessProcessSpecMaint, (BusinessProcessSpecMaint_Parameters) null, request, out result);
    }

    public ResultStatus NewRev(
      BusinessProcessSpecMaint businessProcessSpecMaint,
      BusinessProcessSpecMaint_Parameters parameters,
      BusinessProcessSpecMaint_Request request,
      out BusinessProcessSpecMaint_Result result)
    {
      result = (BusinessProcessSpecMaint_Result) null;
      this.OnBeforeCall(nameof (NewRev), (DCObject) businessProcessSpecMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IBusinessProcessSpecMaintService) this._Channel).NewRev(this._UserProfile, businessProcessSpecMaint, parameters, request, out result) : this.AddMethod((Method) new BusinessProcessSpecMaintMethod(businessProcessSpecMaint, BusinessProcessSpecMaintMethods.NewRev, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (NewRev), res, (DCObject) businessProcessSpecMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus NewRev()
    {
      return this.NewRev((BusinessProcessSpecMaint) null, (BusinessProcessSpecMaint_Parameters) null, (BusinessProcessSpecMaint_Request) null, out BusinessProcessSpecMaint_Result _);
    }

    public ResultStatus NewRev(BusinessProcessSpecMaint businessProcessSpecMaint)
    {
      return this.NewRev(businessProcessSpecMaint, (BusinessProcessSpecMaint_Parameters) null, (BusinessProcessSpecMaint_Request) null, out BusinessProcessSpecMaint_Result _);
    }

    public ResultStatus NewRev(
      BusinessProcessSpecMaint businessProcessSpecMaint,
      BusinessProcessSpecMaint_Request request,
      out BusinessProcessSpecMaint_Result result)
    {
      return this.NewRev(businessProcessSpecMaint, (BusinessProcessSpecMaint_Parameters) null, request, out result);
    }

    public ResultStatus NewRevCopy(
      BusinessProcessSpecMaint businessProcessSpecMaint,
      BusinessProcessSpecMaint_Parameters parameters,
      BusinessProcessSpecMaint_Request request,
      out BusinessProcessSpecMaint_Result result)
    {
      result = (BusinessProcessSpecMaint_Result) null;
      this.OnBeforeCall(nameof (NewRevCopy), (DCObject) businessProcessSpecMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IBusinessProcessSpecMaintService) this._Channel).NewRevCopy(this._UserProfile, businessProcessSpecMaint, parameters, request, out result) : this.AddMethod((Method) new BusinessProcessSpecMaintMethod(businessProcessSpecMaint, BusinessProcessSpecMaintMethods.NewRevCopy, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (NewRevCopy), res, (DCObject) businessProcessSpecMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus NewRevCopy()
    {
      return this.NewRevCopy((BusinessProcessSpecMaint) null, (BusinessProcessSpecMaint_Parameters) null, (BusinessProcessSpecMaint_Request) null, out BusinessProcessSpecMaint_Result _);
    }

    public ResultStatus NewRevCopy(BusinessProcessSpecMaint businessProcessSpecMaint)
    {
      return this.NewRevCopy(businessProcessSpecMaint, (BusinessProcessSpecMaint_Parameters) null, (BusinessProcessSpecMaint_Request) null, out BusinessProcessSpecMaint_Result _);
    }

    public ResultStatus NewRevCopy(
      BusinessProcessSpecMaint businessProcessSpecMaint,
      BusinessProcessSpecMaint_Request request,
      out BusinessProcessSpecMaint_Result result)
    {
      return this.NewRevCopy(businessProcessSpecMaint, (BusinessProcessSpecMaint_Parameters) null, request, out result);
    }

    public ResultStatus SaveAs(
      BusinessProcessSpecMaint businessProcessSpecMaint,
      BusinessProcessSpecMaint_Parameters parameters,
      BusinessProcessSpecMaint_Request request,
      out BusinessProcessSpecMaint_Result result)
    {
      result = (BusinessProcessSpecMaint_Result) null;
      this.OnBeforeCall(nameof (SaveAs), (DCObject) businessProcessSpecMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IBusinessProcessSpecMaintService) this._Channel).SaveAs(this._UserProfile, businessProcessSpecMaint, parameters, request, out result) : this.AddMethod((Method) new BusinessProcessSpecMaintMethod(businessProcessSpecMaint, BusinessProcessSpecMaintMethods.SaveAs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SaveAs), res, (DCObject) businessProcessSpecMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SaveAs()
    {
      return this.SaveAs((BusinessProcessSpecMaint) null, (BusinessProcessSpecMaint_Parameters) null, (BusinessProcessSpecMaint_Request) null, out BusinessProcessSpecMaint_Result _);
    }

    public ResultStatus SaveAs(BusinessProcessSpecMaint businessProcessSpecMaint)
    {
      return this.SaveAs(businessProcessSpecMaint, (BusinessProcessSpecMaint_Parameters) null, (BusinessProcessSpecMaint_Request) null, out BusinessProcessSpecMaint_Result _);
    }

    public ResultStatus SaveAs(
      BusinessProcessSpecMaint businessProcessSpecMaint,
      BusinessProcessSpecMaint_Request request,
      out BusinessProcessSpecMaint_Result result)
    {
      return this.SaveAs(businessProcessSpecMaint, (BusinessProcessSpecMaint_Parameters) null, request, out result);
    }

    public ResultStatus SaveAsRev(
      BusinessProcessSpecMaint businessProcessSpecMaint,
      BusinessProcessSpecMaint_Parameters parameters,
      BusinessProcessSpecMaint_Request request,
      out BusinessProcessSpecMaint_Result result)
    {
      result = (BusinessProcessSpecMaint_Result) null;
      this.OnBeforeCall(nameof (SaveAsRev), (DCObject) businessProcessSpecMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IBusinessProcessSpecMaintService) this._Channel).SaveAsRev(this._UserProfile, businessProcessSpecMaint, parameters, request, out result) : this.AddMethod((Method) new BusinessProcessSpecMaintMethod(businessProcessSpecMaint, BusinessProcessSpecMaintMethods.SaveAsRev, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SaveAsRev), res, (DCObject) businessProcessSpecMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SaveAsRev()
    {
      return this.SaveAsRev((BusinessProcessSpecMaint) null, (BusinessProcessSpecMaint_Parameters) null, (BusinessProcessSpecMaint_Request) null, out BusinessProcessSpecMaint_Result _);
    }

    public ResultStatus SaveAsRev(BusinessProcessSpecMaint businessProcessSpecMaint)
    {
      return this.SaveAsRev(businessProcessSpecMaint, (BusinessProcessSpecMaint_Parameters) null, (BusinessProcessSpecMaint_Request) null, out BusinessProcessSpecMaint_Result _);
    }

    public ResultStatus SaveAsRev(
      BusinessProcessSpecMaint businessProcessSpecMaint,
      BusinessProcessSpecMaint_Request request,
      out BusinessProcessSpecMaint_Result result)
    {
      return this.SaveAsRev(businessProcessSpecMaint, (BusinessProcessSpecMaint_Parameters) null, request, out result);
    }

    public ResultStatus UnFreeze(
      BusinessProcessSpecMaint businessProcessSpecMaint,
      BusinessProcessSpecMaint_Parameters parameters,
      BusinessProcessSpecMaint_Request request,
      out BusinessProcessSpecMaint_Result result)
    {
      result = (BusinessProcessSpecMaint_Result) null;
      this.OnBeforeCall(nameof (UnFreeze), (DCObject) businessProcessSpecMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IBusinessProcessSpecMaintService) this._Channel).UnFreeze(this._UserProfile, businessProcessSpecMaint, parameters, request, out result) : this.AddMethod((Method) new BusinessProcessSpecMaintMethod(businessProcessSpecMaint, BusinessProcessSpecMaintMethods.UnFreeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (UnFreeze), res, (DCObject) businessProcessSpecMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus UnFreeze()
    {
      return this.UnFreeze((BusinessProcessSpecMaint) null, (BusinessProcessSpecMaint_Parameters) null, (BusinessProcessSpecMaint_Request) null, out BusinessProcessSpecMaint_Result _);
    }

    public ResultStatus UnFreeze(BusinessProcessSpecMaint businessProcessSpecMaint)
    {
      return this.UnFreeze(businessProcessSpecMaint, (BusinessProcessSpecMaint_Parameters) null, (BusinessProcessSpecMaint_Request) null, out BusinessProcessSpecMaint_Result _);
    }

    public ResultStatus UnFreeze(
      BusinessProcessSpecMaint businessProcessSpecMaint,
      BusinessProcessSpecMaint_Request request,
      out BusinessProcessSpecMaint_Result result)
    {
      return this.UnFreeze(businessProcessSpecMaint, (BusinessProcessSpecMaint_Parameters) null, request, out result);
    }

    protected override ResultStatus OnDeleteAllRevisions(
      DCObject businessProcessSpecMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        BusinessProcessSpecMaint_Result result1;
        ResultStatus resultStatus = this.DeleteAllRevisions((BusinessProcessSpecMaint) businessProcessSpecMaint, (BusinessProcessSpecMaint_Parameters) parameters, (BusinessProcessSpecMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNewRev(
      DCObject businessProcessSpecMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        BusinessProcessSpecMaint_Result result1;
        ResultStatus resultStatus = this.NewRev((BusinessProcessSpecMaint) businessProcessSpecMaint, (BusinessProcessSpecMaint_Parameters) parameters, (BusinessProcessSpecMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNewRevCopy(
      DCObject businessProcessSpecMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        BusinessProcessSpecMaint_Result result1;
        ResultStatus resultStatus = this.NewRevCopy((BusinessProcessSpecMaint) businessProcessSpecMaint, (BusinessProcessSpecMaint_Parameters) parameters, (BusinessProcessSpecMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnSaveAsRev(
      DCObject businessProcessSpecMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        BusinessProcessSpecMaint_Result result1;
        ResultStatus resultStatus = this.SaveAsRev((BusinessProcessSpecMaint) businessProcessSpecMaint, (BusinessProcessSpecMaint_Parameters) parameters, (BusinessProcessSpecMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnDelete(
      DCObject businessProcessSpecMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        BusinessProcessSpecMaint_Result result1;
        ResultStatus resultStatus = this.Delete((BusinessProcessSpecMaint) businessProcessSpecMaint, (BusinessProcessSpecMaint_Parameters) parameters, (BusinessProcessSpecMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnFreeze(
      DCObject businessProcessSpecMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        BusinessProcessSpecMaint_Result result1;
        ResultStatus resultStatus = this.Freeze((BusinessProcessSpecMaint) businessProcessSpecMaint, (BusinessProcessSpecMaint_Parameters) parameters, (BusinessProcessSpecMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject businessProcessSpecMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        BusinessProcessSpecMaint_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((BusinessProcessSpecMaint) businessProcessSpecMaint, (BusinessProcessSpecMaint_LoadESigDetails_Parameters) parameters, (BusinessProcessSpecMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNew(
      DCObject businessProcessSpecMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        BusinessProcessSpecMaint_Result result1;
        ResultStatus resultStatus = this.New((BusinessProcessSpecMaint) businessProcessSpecMaint, (BusinessProcessSpecMaint_Parameters) parameters, (BusinessProcessSpecMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNewCopy(
      DCObject businessProcessSpecMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        BusinessProcessSpecMaint_Result result1;
        ResultStatus resultStatus = this.NewCopy((BusinessProcessSpecMaint) businessProcessSpecMaint, (BusinessProcessSpecMaint_Parameters) parameters, (BusinessProcessSpecMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnSaveAs(
      DCObject businessProcessSpecMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        BusinessProcessSpecMaint_Result result1;
        ResultStatus resultStatus = this.SaveAs((BusinessProcessSpecMaint) businessProcessSpecMaint, (BusinessProcessSpecMaint_Parameters) parameters, (BusinessProcessSpecMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnUnFreeze(
      DCObject businessProcessSpecMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        BusinessProcessSpecMaint_Result result1;
        ResultStatus resultStatus = this.UnFreeze((BusinessProcessSpecMaint) businessProcessSpecMaint, (BusinessProcessSpecMaint_Parameters) parameters, (BusinessProcessSpecMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject businessProcessSpecMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        BusinessProcessSpecMaint_Result result1;
        ResultStatus resultStatus = this.Load((BusinessProcessSpecMaint) businessProcessSpecMaint, (BusinessProcessSpecMaint_Parameters) parameters, (BusinessProcessSpecMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject businessProcessSpecMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        BusinessProcessSpecMaint_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((BusinessProcessSpecMaint) businessProcessSpecMaint, (BusinessProcessSpecMaint_Parameters) parameters, (BusinessProcessSpecMaint_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      BusinessProcessSpecMaint_Request request,
      out BusinessProcessSpecMaint_Result result)
    {
      result = (BusinessProcessSpecMaint_Result) null;
      try
      {
        BusinessProcessSpecMaintMethod[] methods = new BusinessProcessSpecMaintMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IBusinessProcessSpecMaintService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        BusinessProcessSpecMaint_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((BusinessProcessSpecMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      BusinessProcessSpecMaint cdo,
      BusinessProcessSpecMaint_Request request,
      out BusinessProcessSpecMaint_Result result)
    {
      result = (BusinessProcessSpecMaint_Result) null;
      try
      {
        return ((IBusinessProcessSpecMaintService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        BusinessProcessSpecMaint_Result result1;
        ResultStatus environment = this.GetEnvironment((BusinessProcessSpecMaint) cdo, (BusinessProcessSpecMaint_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      BusinessProcessSpecMaint_Request request,
      out BusinessProcessSpecMaint_Result result)
    {
      return this.GetEnvironment((BusinessProcessSpecMaint) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      BusinessProcessSpecMaint cdo,
      BusinessProcessSpecMaint_Request request,
      out BusinessProcessSpecMaint_Result result)
    {
      result = (BusinessProcessSpecMaint_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IBusinessProcessSpecMaintService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new BusinessProcessSpecMaintMethod(cdo, BusinessProcessSpecMaintMethods.ExecuteTransaction, (BusinessProcessSpecMaint_Parameters) null));
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
        BusinessProcessSpecMaint_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((BusinessProcessSpecMaint) cdo, (BusinessProcessSpecMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(BusinessProcessSpecMaint cdo)
    {
      return this.ExecuteTransaction(cdo, (BusinessProcessSpecMaint_Request) null, out BusinessProcessSpecMaint_Result _);
    }

    public ResultStatus ExecuteTransaction(
      BusinessProcessSpecMaint_Request request,
      out BusinessProcessSpecMaint_Result result)
    {
      return this.ExecuteTransaction((BusinessProcessSpecMaint) null, request, out result);
    }

    public ResultStatus AddDataTransaction(BusinessProcessSpecMaint cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new BusinessProcessSpecMaintMethod(cdo, BusinessProcessSpecMaintMethods.AddDataTransaction, (BusinessProcessSpecMaint_Parameters) null));
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
        return this.AddDataTransaction((BusinessProcessSpecMaint) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
