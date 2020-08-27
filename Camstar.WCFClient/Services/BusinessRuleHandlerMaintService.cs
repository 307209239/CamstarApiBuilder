// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.BusinessRuleHandlerMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class BusinessRuleHandlerMaintService : NamedDataObjectMaintBase
  {
    public BusinessRuleHandlerMaintService(UserProfile userProfile)
    {
      this.Initialize(typeof (IBusinessRuleHandlerMaintService), userProfile);
    }

    public ResultStatus Delete(
      BusinessRuleHandlerMaint businessRuleHandlerMaint,
      BusinessRuleHandlerMaint_Parameters parameters,
      BusinessRuleHandlerMaint_Request request,
      out BusinessRuleHandlerMaint_Result result)
    {
      result = (BusinessRuleHandlerMaint_Result) null;
      this.OnBeforeCall(nameof (Delete), (DCObject) businessRuleHandlerMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IBusinessRuleHandlerMaintService) this._Channel).Delete(this._UserProfile, businessRuleHandlerMaint, parameters, request, out result) : this.AddMethod((Method) new BusinessRuleHandlerMaintMethod(businessRuleHandlerMaint, BusinessRuleHandlerMaintMethods.Delete, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Delete), res, (DCObject) businessRuleHandlerMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Delete()
    {
      return this.Delete((BusinessRuleHandlerMaint) null, (BusinessRuleHandlerMaint_Parameters) null, (BusinessRuleHandlerMaint_Request) null, out BusinessRuleHandlerMaint_Result _);
    }

    public ResultStatus Delete(BusinessRuleHandlerMaint businessRuleHandlerMaint)
    {
      return this.Delete(businessRuleHandlerMaint, (BusinessRuleHandlerMaint_Parameters) null, (BusinessRuleHandlerMaint_Request) null, out BusinessRuleHandlerMaint_Result _);
    }

    public ResultStatus Delete(
      BusinessRuleHandlerMaint businessRuleHandlerMaint,
      BusinessRuleHandlerMaint_Request request,
      out BusinessRuleHandlerMaint_Result result)
    {
      return this.Delete(businessRuleHandlerMaint, (BusinessRuleHandlerMaint_Parameters) null, request, out result);
    }

    public ResultStatus Freeze(
      BusinessRuleHandlerMaint businessRuleHandlerMaint,
      BusinessRuleHandlerMaint_Parameters parameters,
      BusinessRuleHandlerMaint_Request request,
      out BusinessRuleHandlerMaint_Result result)
    {
      result = (BusinessRuleHandlerMaint_Result) null;
      this.OnBeforeCall(nameof (Freeze), (DCObject) businessRuleHandlerMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IBusinessRuleHandlerMaintService) this._Channel).Freeze(this._UserProfile, businessRuleHandlerMaint, parameters, request, out result) : this.AddMethod((Method) new BusinessRuleHandlerMaintMethod(businessRuleHandlerMaint, BusinessRuleHandlerMaintMethods.Freeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Freeze), res, (DCObject) businessRuleHandlerMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Freeze()
    {
      return this.Freeze((BusinessRuleHandlerMaint) null, (BusinessRuleHandlerMaint_Parameters) null, (BusinessRuleHandlerMaint_Request) null, out BusinessRuleHandlerMaint_Result _);
    }

    public ResultStatus Freeze(BusinessRuleHandlerMaint businessRuleHandlerMaint)
    {
      return this.Freeze(businessRuleHandlerMaint, (BusinessRuleHandlerMaint_Parameters) null, (BusinessRuleHandlerMaint_Request) null, out BusinessRuleHandlerMaint_Result _);
    }

    public ResultStatus Freeze(
      BusinessRuleHandlerMaint businessRuleHandlerMaint,
      BusinessRuleHandlerMaint_Request request,
      out BusinessRuleHandlerMaint_Result result)
    {
      return this.Freeze(businessRuleHandlerMaint, (BusinessRuleHandlerMaint_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      BusinessRuleHandlerMaint businessRuleHandlerMaint,
      BusinessRuleHandlerMaint_Parameters parameters,
      BusinessRuleHandlerMaint_Request request,
      out BusinessRuleHandlerMaint_Result result)
    {
      result = (BusinessRuleHandlerMaint_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) businessRuleHandlerMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IBusinessRuleHandlerMaintService) this._Channel).GetWIPMsgs(this._UserProfile, businessRuleHandlerMaint, parameters, request, out result) : this.AddMethod((Method) new BusinessRuleHandlerMaintMethod(businessRuleHandlerMaint, BusinessRuleHandlerMaintMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) businessRuleHandlerMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((BusinessRuleHandlerMaint) null, (BusinessRuleHandlerMaint_Parameters) null, (BusinessRuleHandlerMaint_Request) null, out BusinessRuleHandlerMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(BusinessRuleHandlerMaint businessRuleHandlerMaint)
    {
      return this.GetWIPMsgs(businessRuleHandlerMaint, (BusinessRuleHandlerMaint_Parameters) null, (BusinessRuleHandlerMaint_Request) null, out BusinessRuleHandlerMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(
      BusinessRuleHandlerMaint businessRuleHandlerMaint,
      BusinessRuleHandlerMaint_Request request,
      out BusinessRuleHandlerMaint_Result result)
    {
      return this.GetWIPMsgs(businessRuleHandlerMaint, (BusinessRuleHandlerMaint_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      BusinessRuleHandlerMaint businessRuleHandlerMaint,
      BusinessRuleHandlerMaint_Parameters parameters,
      BusinessRuleHandlerMaint_Request request,
      out BusinessRuleHandlerMaint_Result result)
    {
      result = (BusinessRuleHandlerMaint_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) businessRuleHandlerMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IBusinessRuleHandlerMaintService) this._Channel).Load(this._UserProfile, businessRuleHandlerMaint, parameters, request, out result) : this.AddMethod((Method) new BusinessRuleHandlerMaintMethod(businessRuleHandlerMaint, BusinessRuleHandlerMaintMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) businessRuleHandlerMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((BusinessRuleHandlerMaint) null, (BusinessRuleHandlerMaint_Parameters) null, (BusinessRuleHandlerMaint_Request) null, out BusinessRuleHandlerMaint_Result _);
    }

    public ResultStatus Load(BusinessRuleHandlerMaint businessRuleHandlerMaint)
    {
      return this.Load(businessRuleHandlerMaint, (BusinessRuleHandlerMaint_Parameters) null, (BusinessRuleHandlerMaint_Request) null, out BusinessRuleHandlerMaint_Result _);
    }

    public ResultStatus Load(
      BusinessRuleHandlerMaint businessRuleHandlerMaint,
      BusinessRuleHandlerMaint_Request request,
      out BusinessRuleHandlerMaint_Result result)
    {
      return this.Load(businessRuleHandlerMaint, (BusinessRuleHandlerMaint_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      BusinessRuleHandlerMaint businessRuleHandlerMaint,
      BusinessRuleHandlerMaint_LoadESigDetails_Parameters parameters,
      BusinessRuleHandlerMaint_Request request,
      out BusinessRuleHandlerMaint_Result result)
    {
      result = (BusinessRuleHandlerMaint_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) businessRuleHandlerMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IBusinessRuleHandlerMaintService) this._Channel).LoadESigDetails(this._UserProfile, businessRuleHandlerMaint, parameters, request, out result) : this.AddMethod((Method) new BusinessRuleHandlerMaintMethod(businessRuleHandlerMaint, BusinessRuleHandlerMaintMethods.LoadESigDetails, (BusinessRuleHandlerMaint_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) businessRuleHandlerMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((BusinessRuleHandlerMaint) null, (BusinessRuleHandlerMaint_LoadESigDetails_Parameters) null, (BusinessRuleHandlerMaint_Request) null, out BusinessRuleHandlerMaint_Result _);
    }

    public ResultStatus LoadESigDetails(
      BusinessRuleHandlerMaint businessRuleHandlerMaint)
    {
      return this.LoadESigDetails(businessRuleHandlerMaint, (BusinessRuleHandlerMaint_LoadESigDetails_Parameters) null, (BusinessRuleHandlerMaint_Request) null, out BusinessRuleHandlerMaint_Result _);
    }

    public ResultStatus LoadESigDetails(
      BusinessRuleHandlerMaint businessRuleHandlerMaint,
      BusinessRuleHandlerMaint_Request request,
      out BusinessRuleHandlerMaint_Result result)
    {
      return this.LoadESigDetails(businessRuleHandlerMaint, (BusinessRuleHandlerMaint_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus New(
      BusinessRuleHandlerMaint businessRuleHandlerMaint,
      BusinessRuleHandlerMaint_Parameters parameters,
      BusinessRuleHandlerMaint_Request request,
      out BusinessRuleHandlerMaint_Result result)
    {
      result = (BusinessRuleHandlerMaint_Result) null;
      this.OnBeforeCall(nameof (New), (DCObject) businessRuleHandlerMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IBusinessRuleHandlerMaintService) this._Channel).New(this._UserProfile, businessRuleHandlerMaint, parameters, request, out result) : this.AddMethod((Method) new BusinessRuleHandlerMaintMethod(businessRuleHandlerMaint, BusinessRuleHandlerMaintMethods.New, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (New), res, (DCObject) businessRuleHandlerMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus New()
    {
      return this.New((BusinessRuleHandlerMaint) null, (BusinessRuleHandlerMaint_Parameters) null, (BusinessRuleHandlerMaint_Request) null, out BusinessRuleHandlerMaint_Result _);
    }

    public ResultStatus New(BusinessRuleHandlerMaint businessRuleHandlerMaint)
    {
      return this.New(businessRuleHandlerMaint, (BusinessRuleHandlerMaint_Parameters) null, (BusinessRuleHandlerMaint_Request) null, out BusinessRuleHandlerMaint_Result _);
    }

    public ResultStatus New(
      BusinessRuleHandlerMaint businessRuleHandlerMaint,
      BusinessRuleHandlerMaint_Request request,
      out BusinessRuleHandlerMaint_Result result)
    {
      return this.New(businessRuleHandlerMaint, (BusinessRuleHandlerMaint_Parameters) null, request, out result);
    }

    public ResultStatus NewCopy(
      BusinessRuleHandlerMaint businessRuleHandlerMaint,
      BusinessRuleHandlerMaint_Parameters parameters,
      BusinessRuleHandlerMaint_Request request,
      out BusinessRuleHandlerMaint_Result result)
    {
      result = (BusinessRuleHandlerMaint_Result) null;
      this.OnBeforeCall(nameof (NewCopy), (DCObject) businessRuleHandlerMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IBusinessRuleHandlerMaintService) this._Channel).NewCopy(this._UserProfile, businessRuleHandlerMaint, parameters, request, out result) : this.AddMethod((Method) new BusinessRuleHandlerMaintMethod(businessRuleHandlerMaint, BusinessRuleHandlerMaintMethods.NewCopy, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (NewCopy), res, (DCObject) businessRuleHandlerMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus NewCopy()
    {
      return this.NewCopy((BusinessRuleHandlerMaint) null, (BusinessRuleHandlerMaint_Parameters) null, (BusinessRuleHandlerMaint_Request) null, out BusinessRuleHandlerMaint_Result _);
    }

    public ResultStatus NewCopy(BusinessRuleHandlerMaint businessRuleHandlerMaint)
    {
      return this.NewCopy(businessRuleHandlerMaint, (BusinessRuleHandlerMaint_Parameters) null, (BusinessRuleHandlerMaint_Request) null, out BusinessRuleHandlerMaint_Result _);
    }

    public ResultStatus NewCopy(
      BusinessRuleHandlerMaint businessRuleHandlerMaint,
      BusinessRuleHandlerMaint_Request request,
      out BusinessRuleHandlerMaint_Result result)
    {
      return this.NewCopy(businessRuleHandlerMaint, (BusinessRuleHandlerMaint_Parameters) null, request, out result);
    }

    public ResultStatus SaveAs(
      BusinessRuleHandlerMaint businessRuleHandlerMaint,
      BusinessRuleHandlerMaint_Parameters parameters,
      BusinessRuleHandlerMaint_Request request,
      out BusinessRuleHandlerMaint_Result result)
    {
      result = (BusinessRuleHandlerMaint_Result) null;
      this.OnBeforeCall(nameof (SaveAs), (DCObject) businessRuleHandlerMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IBusinessRuleHandlerMaintService) this._Channel).SaveAs(this._UserProfile, businessRuleHandlerMaint, parameters, request, out result) : this.AddMethod((Method) new BusinessRuleHandlerMaintMethod(businessRuleHandlerMaint, BusinessRuleHandlerMaintMethods.SaveAs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SaveAs), res, (DCObject) businessRuleHandlerMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SaveAs()
    {
      return this.SaveAs((BusinessRuleHandlerMaint) null, (BusinessRuleHandlerMaint_Parameters) null, (BusinessRuleHandlerMaint_Request) null, out BusinessRuleHandlerMaint_Result _);
    }

    public ResultStatus SaveAs(BusinessRuleHandlerMaint businessRuleHandlerMaint)
    {
      return this.SaveAs(businessRuleHandlerMaint, (BusinessRuleHandlerMaint_Parameters) null, (BusinessRuleHandlerMaint_Request) null, out BusinessRuleHandlerMaint_Result _);
    }

    public ResultStatus SaveAs(
      BusinessRuleHandlerMaint businessRuleHandlerMaint,
      BusinessRuleHandlerMaint_Request request,
      out BusinessRuleHandlerMaint_Result result)
    {
      return this.SaveAs(businessRuleHandlerMaint, (BusinessRuleHandlerMaint_Parameters) null, request, out result);
    }

    public ResultStatus UnFreeze(
      BusinessRuleHandlerMaint businessRuleHandlerMaint,
      BusinessRuleHandlerMaint_Parameters parameters,
      BusinessRuleHandlerMaint_Request request,
      out BusinessRuleHandlerMaint_Result result)
    {
      result = (BusinessRuleHandlerMaint_Result) null;
      this.OnBeforeCall(nameof (UnFreeze), (DCObject) businessRuleHandlerMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IBusinessRuleHandlerMaintService) this._Channel).UnFreeze(this._UserProfile, businessRuleHandlerMaint, parameters, request, out result) : this.AddMethod((Method) new BusinessRuleHandlerMaintMethod(businessRuleHandlerMaint, BusinessRuleHandlerMaintMethods.UnFreeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (UnFreeze), res, (DCObject) businessRuleHandlerMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus UnFreeze()
    {
      return this.UnFreeze((BusinessRuleHandlerMaint) null, (BusinessRuleHandlerMaint_Parameters) null, (BusinessRuleHandlerMaint_Request) null, out BusinessRuleHandlerMaint_Result _);
    }

    public ResultStatus UnFreeze(BusinessRuleHandlerMaint businessRuleHandlerMaint)
    {
      return this.UnFreeze(businessRuleHandlerMaint, (BusinessRuleHandlerMaint_Parameters) null, (BusinessRuleHandlerMaint_Request) null, out BusinessRuleHandlerMaint_Result _);
    }

    public ResultStatus UnFreeze(
      BusinessRuleHandlerMaint businessRuleHandlerMaint,
      BusinessRuleHandlerMaint_Request request,
      out BusinessRuleHandlerMaint_Result result)
    {
      return this.UnFreeze(businessRuleHandlerMaint, (BusinessRuleHandlerMaint_Parameters) null, request, out result);
    }

    protected override ResultStatus OnDelete(
      DCObject businessRuleHandlerMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        BusinessRuleHandlerMaint_Result result1;
        ResultStatus resultStatus = this.Delete((BusinessRuleHandlerMaint) businessRuleHandlerMaint, (BusinessRuleHandlerMaint_Parameters) parameters, (BusinessRuleHandlerMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnFreeze(
      DCObject businessRuleHandlerMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        BusinessRuleHandlerMaint_Result result1;
        ResultStatus resultStatus = this.Freeze((BusinessRuleHandlerMaint) businessRuleHandlerMaint, (BusinessRuleHandlerMaint_Parameters) parameters, (BusinessRuleHandlerMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject businessRuleHandlerMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        BusinessRuleHandlerMaint_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((BusinessRuleHandlerMaint) businessRuleHandlerMaint, (BusinessRuleHandlerMaint_LoadESigDetails_Parameters) parameters, (BusinessRuleHandlerMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNew(
      DCObject businessRuleHandlerMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        BusinessRuleHandlerMaint_Result result1;
        ResultStatus resultStatus = this.New((BusinessRuleHandlerMaint) businessRuleHandlerMaint, (BusinessRuleHandlerMaint_Parameters) parameters, (BusinessRuleHandlerMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNewCopy(
      DCObject businessRuleHandlerMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        BusinessRuleHandlerMaint_Result result1;
        ResultStatus resultStatus = this.NewCopy((BusinessRuleHandlerMaint) businessRuleHandlerMaint, (BusinessRuleHandlerMaint_Parameters) parameters, (BusinessRuleHandlerMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnSaveAs(
      DCObject businessRuleHandlerMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        BusinessRuleHandlerMaint_Result result1;
        ResultStatus resultStatus = this.SaveAs((BusinessRuleHandlerMaint) businessRuleHandlerMaint, (BusinessRuleHandlerMaint_Parameters) parameters, (BusinessRuleHandlerMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnUnFreeze(
      DCObject businessRuleHandlerMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        BusinessRuleHandlerMaint_Result result1;
        ResultStatus resultStatus = this.UnFreeze((BusinessRuleHandlerMaint) businessRuleHandlerMaint, (BusinessRuleHandlerMaint_Parameters) parameters, (BusinessRuleHandlerMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject businessRuleHandlerMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        BusinessRuleHandlerMaint_Result result1;
        ResultStatus resultStatus = this.Load((BusinessRuleHandlerMaint) businessRuleHandlerMaint, (BusinessRuleHandlerMaint_Parameters) parameters, (BusinessRuleHandlerMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject businessRuleHandlerMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        BusinessRuleHandlerMaint_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((BusinessRuleHandlerMaint) businessRuleHandlerMaint, (BusinessRuleHandlerMaint_Parameters) parameters, (BusinessRuleHandlerMaint_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      BusinessRuleHandlerMaint_Request request,
      out BusinessRuleHandlerMaint_Result result)
    {
      result = (BusinessRuleHandlerMaint_Result) null;
      try
      {
        BusinessRuleHandlerMaintMethod[] methods = new BusinessRuleHandlerMaintMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IBusinessRuleHandlerMaintService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        BusinessRuleHandlerMaint_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((BusinessRuleHandlerMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      BusinessRuleHandlerMaint cdo,
      BusinessRuleHandlerMaint_Request request,
      out BusinessRuleHandlerMaint_Result result)
    {
      result = (BusinessRuleHandlerMaint_Result) null;
      try
      {
        return ((IBusinessRuleHandlerMaintService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        BusinessRuleHandlerMaint_Result result1;
        ResultStatus environment = this.GetEnvironment((BusinessRuleHandlerMaint) cdo, (BusinessRuleHandlerMaint_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      BusinessRuleHandlerMaint_Request request,
      out BusinessRuleHandlerMaint_Result result)
    {
      return this.GetEnvironment((BusinessRuleHandlerMaint) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      BusinessRuleHandlerMaint cdo,
      BusinessRuleHandlerMaint_Request request,
      out BusinessRuleHandlerMaint_Result result)
    {
      result = (BusinessRuleHandlerMaint_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IBusinessRuleHandlerMaintService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new BusinessRuleHandlerMaintMethod(cdo, BusinessRuleHandlerMaintMethods.ExecuteTransaction, (BusinessRuleHandlerMaint_Parameters) null));
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
        BusinessRuleHandlerMaint_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((BusinessRuleHandlerMaint) cdo, (BusinessRuleHandlerMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(BusinessRuleHandlerMaint cdo)
    {
      return this.ExecuteTransaction(cdo, (BusinessRuleHandlerMaint_Request) null, out BusinessRuleHandlerMaint_Result _);
    }

    public ResultStatus ExecuteTransaction(
      BusinessRuleHandlerMaint_Request request,
      out BusinessRuleHandlerMaint_Result result)
    {
      return this.ExecuteTransaction((BusinessRuleHandlerMaint) null, request, out result);
    }

    public ResultStatus AddDataTransaction(BusinessRuleHandlerMaint cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new BusinessRuleHandlerMaintMethod(cdo, BusinessRuleHandlerMaintMethods.AddDataTransaction, (BusinessRuleHandlerMaint_Parameters) null));
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
        return this.AddDataTransaction((BusinessRuleHandlerMaint) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
