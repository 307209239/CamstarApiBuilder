// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.BusinessRuleMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class BusinessRuleMaintService : NamedDataObjectMaintBase
  {
    public BusinessRuleMaintService(UserProfile userProfile)
    {
      this.Initialize(typeof (IBusinessRuleMaintService), userProfile);
    }

    public ResultStatus Delete(
      BusinessRuleMaint businessRuleMaint,
      BusinessRuleMaint_Parameters parameters,
      BusinessRuleMaint_Request request,
      out BusinessRuleMaint_Result result)
    {
      result = (BusinessRuleMaint_Result) null;
      this.OnBeforeCall(nameof (Delete), (DCObject) businessRuleMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IBusinessRuleMaintService) this._Channel).Delete(this._UserProfile, businessRuleMaint, parameters, request, out result) : this.AddMethod((Method) new BusinessRuleMaintMethod(businessRuleMaint, BusinessRuleMaintMethods.Delete, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Delete), res, (DCObject) businessRuleMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Delete()
    {
      return this.Delete((BusinessRuleMaint) null, (BusinessRuleMaint_Parameters) null, (BusinessRuleMaint_Request) null, out BusinessRuleMaint_Result _);
    }

    public ResultStatus Delete(BusinessRuleMaint businessRuleMaint)
    {
      return this.Delete(businessRuleMaint, (BusinessRuleMaint_Parameters) null, (BusinessRuleMaint_Request) null, out BusinessRuleMaint_Result _);
    }

    public ResultStatus Delete(
      BusinessRuleMaint businessRuleMaint,
      BusinessRuleMaint_Request request,
      out BusinessRuleMaint_Result result)
    {
      return this.Delete(businessRuleMaint, (BusinessRuleMaint_Parameters) null, request, out result);
    }

    public ResultStatus Freeze(
      BusinessRuleMaint businessRuleMaint,
      BusinessRuleMaint_Parameters parameters,
      BusinessRuleMaint_Request request,
      out BusinessRuleMaint_Result result)
    {
      result = (BusinessRuleMaint_Result) null;
      this.OnBeforeCall(nameof (Freeze), (DCObject) businessRuleMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IBusinessRuleMaintService) this._Channel).Freeze(this._UserProfile, businessRuleMaint, parameters, request, out result) : this.AddMethod((Method) new BusinessRuleMaintMethod(businessRuleMaint, BusinessRuleMaintMethods.Freeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Freeze), res, (DCObject) businessRuleMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Freeze()
    {
      return this.Freeze((BusinessRuleMaint) null, (BusinessRuleMaint_Parameters) null, (BusinessRuleMaint_Request) null, out BusinessRuleMaint_Result _);
    }

    public ResultStatus Freeze(BusinessRuleMaint businessRuleMaint)
    {
      return this.Freeze(businessRuleMaint, (BusinessRuleMaint_Parameters) null, (BusinessRuleMaint_Request) null, out BusinessRuleMaint_Result _);
    }

    public ResultStatus Freeze(
      BusinessRuleMaint businessRuleMaint,
      BusinessRuleMaint_Request request,
      out BusinessRuleMaint_Result result)
    {
      return this.Freeze(businessRuleMaint, (BusinessRuleMaint_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      BusinessRuleMaint businessRuleMaint,
      BusinessRuleMaint_Parameters parameters,
      BusinessRuleMaint_Request request,
      out BusinessRuleMaint_Result result)
    {
      result = (BusinessRuleMaint_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) businessRuleMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IBusinessRuleMaintService) this._Channel).GetWIPMsgs(this._UserProfile, businessRuleMaint, parameters, request, out result) : this.AddMethod((Method) new BusinessRuleMaintMethod(businessRuleMaint, BusinessRuleMaintMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) businessRuleMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((BusinessRuleMaint) null, (BusinessRuleMaint_Parameters) null, (BusinessRuleMaint_Request) null, out BusinessRuleMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(BusinessRuleMaint businessRuleMaint)
    {
      return this.GetWIPMsgs(businessRuleMaint, (BusinessRuleMaint_Parameters) null, (BusinessRuleMaint_Request) null, out BusinessRuleMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(
      BusinessRuleMaint businessRuleMaint,
      BusinessRuleMaint_Request request,
      out BusinessRuleMaint_Result result)
    {
      return this.GetWIPMsgs(businessRuleMaint, (BusinessRuleMaint_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      BusinessRuleMaint businessRuleMaint,
      BusinessRuleMaint_Parameters parameters,
      BusinessRuleMaint_Request request,
      out BusinessRuleMaint_Result result)
    {
      result = (BusinessRuleMaint_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) businessRuleMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IBusinessRuleMaintService) this._Channel).Load(this._UserProfile, businessRuleMaint, parameters, request, out result) : this.AddMethod((Method) new BusinessRuleMaintMethod(businessRuleMaint, BusinessRuleMaintMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) businessRuleMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((BusinessRuleMaint) null, (BusinessRuleMaint_Parameters) null, (BusinessRuleMaint_Request) null, out BusinessRuleMaint_Result _);
    }

    public ResultStatus Load(BusinessRuleMaint businessRuleMaint)
    {
      return this.Load(businessRuleMaint, (BusinessRuleMaint_Parameters) null, (BusinessRuleMaint_Request) null, out BusinessRuleMaint_Result _);
    }

    public ResultStatus Load(
      BusinessRuleMaint businessRuleMaint,
      BusinessRuleMaint_Request request,
      out BusinessRuleMaint_Result result)
    {
      return this.Load(businessRuleMaint, (BusinessRuleMaint_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      BusinessRuleMaint businessRuleMaint,
      BusinessRuleMaint_LoadESigDetails_Parameters parameters,
      BusinessRuleMaint_Request request,
      out BusinessRuleMaint_Result result)
    {
      result = (BusinessRuleMaint_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) businessRuleMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IBusinessRuleMaintService) this._Channel).LoadESigDetails(this._UserProfile, businessRuleMaint, parameters, request, out result) : this.AddMethod((Method) new BusinessRuleMaintMethod(businessRuleMaint, BusinessRuleMaintMethods.LoadESigDetails, (BusinessRuleMaint_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) businessRuleMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((BusinessRuleMaint) null, (BusinessRuleMaint_LoadESigDetails_Parameters) null, (BusinessRuleMaint_Request) null, out BusinessRuleMaint_Result _);
    }

    public ResultStatus LoadESigDetails(BusinessRuleMaint businessRuleMaint)
    {
      return this.LoadESigDetails(businessRuleMaint, (BusinessRuleMaint_LoadESigDetails_Parameters) null, (BusinessRuleMaint_Request) null, out BusinessRuleMaint_Result _);
    }

    public ResultStatus LoadESigDetails(
      BusinessRuleMaint businessRuleMaint,
      BusinessRuleMaint_Request request,
      out BusinessRuleMaint_Result result)
    {
      return this.LoadESigDetails(businessRuleMaint, (BusinessRuleMaint_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus New(
      BusinessRuleMaint businessRuleMaint,
      BusinessRuleMaint_Parameters parameters,
      BusinessRuleMaint_Request request,
      out BusinessRuleMaint_Result result)
    {
      result = (BusinessRuleMaint_Result) null;
      this.OnBeforeCall(nameof (New), (DCObject) businessRuleMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IBusinessRuleMaintService) this._Channel).New(this._UserProfile, businessRuleMaint, parameters, request, out result) : this.AddMethod((Method) new BusinessRuleMaintMethod(businessRuleMaint, BusinessRuleMaintMethods.New, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (New), res, (DCObject) businessRuleMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus New()
    {
      return this.New((BusinessRuleMaint) null, (BusinessRuleMaint_Parameters) null, (BusinessRuleMaint_Request) null, out BusinessRuleMaint_Result _);
    }

    public ResultStatus New(BusinessRuleMaint businessRuleMaint)
    {
      return this.New(businessRuleMaint, (BusinessRuleMaint_Parameters) null, (BusinessRuleMaint_Request) null, out BusinessRuleMaint_Result _);
    }

    public ResultStatus New(
      BusinessRuleMaint businessRuleMaint,
      BusinessRuleMaint_Request request,
      out BusinessRuleMaint_Result result)
    {
      return this.New(businessRuleMaint, (BusinessRuleMaint_Parameters) null, request, out result);
    }

    public ResultStatus NewCopy(
      BusinessRuleMaint businessRuleMaint,
      BusinessRuleMaint_Parameters parameters,
      BusinessRuleMaint_Request request,
      out BusinessRuleMaint_Result result)
    {
      result = (BusinessRuleMaint_Result) null;
      this.OnBeforeCall(nameof (NewCopy), (DCObject) businessRuleMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IBusinessRuleMaintService) this._Channel).NewCopy(this._UserProfile, businessRuleMaint, parameters, request, out result) : this.AddMethod((Method) new BusinessRuleMaintMethod(businessRuleMaint, BusinessRuleMaintMethods.NewCopy, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (NewCopy), res, (DCObject) businessRuleMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus NewCopy()
    {
      return this.NewCopy((BusinessRuleMaint) null, (BusinessRuleMaint_Parameters) null, (BusinessRuleMaint_Request) null, out BusinessRuleMaint_Result _);
    }

    public ResultStatus NewCopy(BusinessRuleMaint businessRuleMaint)
    {
      return this.NewCopy(businessRuleMaint, (BusinessRuleMaint_Parameters) null, (BusinessRuleMaint_Request) null, out BusinessRuleMaint_Result _);
    }

    public ResultStatus NewCopy(
      BusinessRuleMaint businessRuleMaint,
      BusinessRuleMaint_Request request,
      out BusinessRuleMaint_Result result)
    {
      return this.NewCopy(businessRuleMaint, (BusinessRuleMaint_Parameters) null, request, out result);
    }

    public ResultStatus SaveAs(
      BusinessRuleMaint businessRuleMaint,
      BusinessRuleMaint_Parameters parameters,
      BusinessRuleMaint_Request request,
      out BusinessRuleMaint_Result result)
    {
      result = (BusinessRuleMaint_Result) null;
      this.OnBeforeCall(nameof (SaveAs), (DCObject) businessRuleMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IBusinessRuleMaintService) this._Channel).SaveAs(this._UserProfile, businessRuleMaint, parameters, request, out result) : this.AddMethod((Method) new BusinessRuleMaintMethod(businessRuleMaint, BusinessRuleMaintMethods.SaveAs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SaveAs), res, (DCObject) businessRuleMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SaveAs()
    {
      return this.SaveAs((BusinessRuleMaint) null, (BusinessRuleMaint_Parameters) null, (BusinessRuleMaint_Request) null, out BusinessRuleMaint_Result _);
    }

    public ResultStatus SaveAs(BusinessRuleMaint businessRuleMaint)
    {
      return this.SaveAs(businessRuleMaint, (BusinessRuleMaint_Parameters) null, (BusinessRuleMaint_Request) null, out BusinessRuleMaint_Result _);
    }

    public ResultStatus SaveAs(
      BusinessRuleMaint businessRuleMaint,
      BusinessRuleMaint_Request request,
      out BusinessRuleMaint_Result result)
    {
      return this.SaveAs(businessRuleMaint, (BusinessRuleMaint_Parameters) null, request, out result);
    }

    public ResultStatus UnFreeze(
      BusinessRuleMaint businessRuleMaint,
      BusinessRuleMaint_Parameters parameters,
      BusinessRuleMaint_Request request,
      out BusinessRuleMaint_Result result)
    {
      result = (BusinessRuleMaint_Result) null;
      this.OnBeforeCall(nameof (UnFreeze), (DCObject) businessRuleMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IBusinessRuleMaintService) this._Channel).UnFreeze(this._UserProfile, businessRuleMaint, parameters, request, out result) : this.AddMethod((Method) new BusinessRuleMaintMethod(businessRuleMaint, BusinessRuleMaintMethods.UnFreeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (UnFreeze), res, (DCObject) businessRuleMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus UnFreeze()
    {
      return this.UnFreeze((BusinessRuleMaint) null, (BusinessRuleMaint_Parameters) null, (BusinessRuleMaint_Request) null, out BusinessRuleMaint_Result _);
    }

    public ResultStatus UnFreeze(BusinessRuleMaint businessRuleMaint)
    {
      return this.UnFreeze(businessRuleMaint, (BusinessRuleMaint_Parameters) null, (BusinessRuleMaint_Request) null, out BusinessRuleMaint_Result _);
    }

    public ResultStatus UnFreeze(
      BusinessRuleMaint businessRuleMaint,
      BusinessRuleMaint_Request request,
      out BusinessRuleMaint_Result result)
    {
      return this.UnFreeze(businessRuleMaint, (BusinessRuleMaint_Parameters) null, request, out result);
    }

    protected override ResultStatus OnDelete(
      DCObject businessRuleMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        BusinessRuleMaint_Result result1;
        ResultStatus resultStatus = this.Delete((BusinessRuleMaint) businessRuleMaint, (BusinessRuleMaint_Parameters) parameters, (BusinessRuleMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnFreeze(
      DCObject businessRuleMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        BusinessRuleMaint_Result result1;
        ResultStatus resultStatus = this.Freeze((BusinessRuleMaint) businessRuleMaint, (BusinessRuleMaint_Parameters) parameters, (BusinessRuleMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject businessRuleMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        BusinessRuleMaint_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((BusinessRuleMaint) businessRuleMaint, (BusinessRuleMaint_LoadESigDetails_Parameters) parameters, (BusinessRuleMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNew(
      DCObject businessRuleMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        BusinessRuleMaint_Result result1;
        ResultStatus resultStatus = this.New((BusinessRuleMaint) businessRuleMaint, (BusinessRuleMaint_Parameters) parameters, (BusinessRuleMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNewCopy(
      DCObject businessRuleMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        BusinessRuleMaint_Result result1;
        ResultStatus resultStatus = this.NewCopy((BusinessRuleMaint) businessRuleMaint, (BusinessRuleMaint_Parameters) parameters, (BusinessRuleMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnSaveAs(
      DCObject businessRuleMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        BusinessRuleMaint_Result result1;
        ResultStatus resultStatus = this.SaveAs((BusinessRuleMaint) businessRuleMaint, (BusinessRuleMaint_Parameters) parameters, (BusinessRuleMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnUnFreeze(
      DCObject businessRuleMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        BusinessRuleMaint_Result result1;
        ResultStatus resultStatus = this.UnFreeze((BusinessRuleMaint) businessRuleMaint, (BusinessRuleMaint_Parameters) parameters, (BusinessRuleMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject businessRuleMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        BusinessRuleMaint_Result result1;
        ResultStatus resultStatus = this.Load((BusinessRuleMaint) businessRuleMaint, (BusinessRuleMaint_Parameters) parameters, (BusinessRuleMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject businessRuleMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        BusinessRuleMaint_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((BusinessRuleMaint) businessRuleMaint, (BusinessRuleMaint_Parameters) parameters, (BusinessRuleMaint_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      BusinessRuleMaint_Request request,
      out BusinessRuleMaint_Result result)
    {
      result = (BusinessRuleMaint_Result) null;
      try
      {
        BusinessRuleMaintMethod[] methods = new BusinessRuleMaintMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IBusinessRuleMaintService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        BusinessRuleMaint_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((BusinessRuleMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      BusinessRuleMaint cdo,
      BusinessRuleMaint_Request request,
      out BusinessRuleMaint_Result result)
    {
      result = (BusinessRuleMaint_Result) null;
      try
      {
        return ((IBusinessRuleMaintService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        BusinessRuleMaint_Result result1;
        ResultStatus environment = this.GetEnvironment((BusinessRuleMaint) cdo, (BusinessRuleMaint_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      BusinessRuleMaint_Request request,
      out BusinessRuleMaint_Result result)
    {
      return this.GetEnvironment((BusinessRuleMaint) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      BusinessRuleMaint cdo,
      BusinessRuleMaint_Request request,
      out BusinessRuleMaint_Result result)
    {
      result = (BusinessRuleMaint_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IBusinessRuleMaintService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new BusinessRuleMaintMethod(cdo, BusinessRuleMaintMethods.ExecuteTransaction, (BusinessRuleMaint_Parameters) null));
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
        BusinessRuleMaint_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((BusinessRuleMaint) cdo, (BusinessRuleMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(BusinessRuleMaint cdo)
    {
      return this.ExecuteTransaction(cdo, (BusinessRuleMaint_Request) null, out BusinessRuleMaint_Result _);
    }

    public ResultStatus ExecuteTransaction(
      BusinessRuleMaint_Request request,
      out BusinessRuleMaint_Result result)
    {
      return this.ExecuteTransaction((BusinessRuleMaint) null, request, out result);
    }

    public ResultStatus AddDataTransaction(BusinessRuleMaint cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new BusinessRuleMaintMethod(cdo, BusinessRuleMaintMethods.AddDataTransaction, (BusinessRuleMaint_Parameters) null));
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
        return this.AddDataTransaction((BusinessRuleMaint) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
